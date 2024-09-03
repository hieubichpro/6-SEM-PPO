select * from users where id_club = 9 and role = 'Coach'
select * from users
-- drop function get_table_league(id_ int);

create or replace function get_table_league(id_ int)
returns table(
	name varchar,
	allgames int,
	games int,
	wins int,
	draws int,
	loses int,
	goals int,
	losts int,
	diff int,
	points int
)
as
$$
begin
	drop table if exists clubs_in_league;
	create temp table if not exists clubs_in_league(id int, name varchar(64));
	insert into clubs_in_league(id, name)
	select c.id, c.name
	from clubs c join leagueclub lc on c.id = lc.id_club
	where lc.id_league = id_;
	
	drop table if exists home_count;
	create temp table if not exists home_count(id int, notplayed int, played int, wins int, draws int, loses int, goals int, losts int);
	insert into home_count(id, notplayed, played, wins, draws, loses, goals, losts)
	select c.id,
	sum(case when m.goal_home_club is null then 1 else 0 end),
	sum(case when m.goal_home_club is not null then 1 else 0 end),
	sum(case when m.goal_home_club > m.goal_guess_club then 1 else 0 end),
	sum(case when m.goal_home_club = m.goal_guess_club then 1 else 0 end),
	sum(case when m.goal_home_club < m.goal_guess_club then 1 else 0 end),
	sum(case when m.goal_home_club is null then 0 else m.goal_home_club end),
	sum(case when m.goal_guess_club is null then 0 else m.goal_guess_club end)
	from clubs_in_league c join matches m on c.id = m.id_home_club
	where m.id_league = id_
	group by c.id;
	
	drop table if exists guest_count;
	create temp table if not exists guest_count(id int, notplayed int, played int, wins int, draws int, loses int, goals int, losts int);
	insert into guest_count(id, notplayed, played, wins, draws, loses, goals, losts)
	select c.id,
	sum(case when m.goal_home_club is null then 1 else 0 end),
	sum(case when m.goal_home_club is not null then 1 else 0 end),
	sum(case when m.goal_home_club < m.goal_guess_club then 1 else 0 end),
	sum(case when m.goal_home_club = m.goal_guess_club then 1 else 0 end),
	sum(case when m.goal_home_club > m.goal_guess_club then 1 else 0 end),
	sum(case when m.goal_home_club is null then 0 else m.goal_guess_club end),
	sum(case when m.goal_guess_club is null then 0 else m.goal_home_club end)
	from clubs_in_league c join matches m on c.id = m.id_guess_club
	where m.id_league = id_
	group by c.id;
	
	drop table if exists summary;
	create table if not exists summary(name varchar(64), all_games int, games int, wins int, draws int, loses int, goals int, losts int, diff int, points int);
	insert into summary(name, all_games, games, wins, draws, loses, goals, losts, diff, points)
	select c.name,
	h.notplayed + g.notplayed + h.played + g.played,
	h.played + g.played, 
	h.wins + g.wins, 
	h.draws + g.draws, 
	h.loses + g.loses, 
	h.goals + g.goals, 
	h.losts + g.losts, 
	h.goals + g.goals - h.losts - g.losts, 
	(h.wins + g.wins) * 3 + (h.draws + g.draws)
	from clubs_in_league c join home_count h on c.id = h.id
	join guest_count g on c.id = g.id;
	
	return query
	select s.name, s.all_games, s.games, s.wins, s.draws, s.loses, s.goals, s.losts, s.diff, s.points
	from summary s
	order by s.points desc, s.diff desc, s.wins desc, s.name;
	
end
$$
language plpgsql;

select * from get_table_league(5);

delete from matches where id_league = 5
select * from clubs
select * from leagueclub where id_league = 5
select * from matches order by week

delete from matches where id_league = 5;
select * from matches order by week

select * from home_count
select * from guest_count
select * from clubs where id = 6

select * from matches
update matches set goal_home_club = floor(random() * 10 + 1)::int, goal_guess_club = floor(random() * 10 + 1)::int where id = 219;
select * from matches where id = 219

create or replace procedure auto_fill(id_ int)
language plpgsql
as
$$
declare
	row record;
begin
	for row in select * from matches where id_league = id_
	loop
		update matches set goal_home_club = floor(random() * 10 + 1)::int, goal_guess_club = floor(random() * 10 + 1)::int where id = row.id;
	end loop;
end;
$$

call auto_fill(5);

select * from matches

create or replace function calculate_rating()
returns trigger
as
$$
begin
	update leagues set rating = (select sum(f.grade) / count(*)::double precision as rating
								 from feedbacks f
								 where id_league = new.id_league)
	where id = new.id_league;
	return new;
end;
$$
language plpgsql;

create trigger auto_cal_rating
after insert on feedbacks
for each row execute function calculate_rating();

create or replace function insert_feedback()
returns trigger
as
$$
begin
	insert into feedbacks(grade, id_user, id_league) values (5, new.id_user, new.id);
	return new;
end;
$$
language plpgsql;

create trigger auto_insert
after insert on leagues
for each row execute function insert_feedback();

create or replace function delete_requests()
returns trigger
as
$$
begin
	delete from requests where id_user = new.id;
	return new;
end;
$$
language plpgsql;

create trigger auto_del_requests
after update on users
for each row execute function delete_requests();

select * from leagues where id = 12
select * from users where id = 17
select * from users where login = 'cr7'