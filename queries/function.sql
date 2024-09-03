create or replace function rotate_teams(full_id int[])
returns int[] 
as
$$
declare
	last_id int;
	size int;
begin
	size := array_length(full_id, 1);
	last_id := full_id[size];
    for i in reverse size..3 loop
        full_id[i] := full_id[i - 1];
    end loop;
	full_id[2] := last_id;
	return full_id;
end;
$$
language plpgsql;

create or replace procedure createMatch(idLeague int, idHome int, idGuest int, week int, timestart date)
language plpgsql
as
$$
begin
	insert into matches(id_league, id_home_club, id_guest_club, week, time_start) values
	(idLeague, idHome, idGuest, week, timestart);
end;
$$

create or replace function create_schedule(id_l int) returns void as $$
declare
    size int;
	ss int;
    start_first_leg date := '2024-05-24';
    start_second_leg date;
	full_id int[];
    week int;
    random_index int;
begin
	select array_agg(id_club) into full_id from leagueclub where id_league = id_l;
	size := array_length(full_id, 1);

    start_second_leg := start_first_leg + INTERVAL '7' DAY * (size - 1);

    for week in 1..(size - 1) loop
        call createMatch(id_l, full_id[1], full_id[2], week, start_first_leg);
		call createMatch(id_l, full_id[2], full_id[1], week + size - 1, start_second_leg);

        for i in 0..(size / 2 - 2) loop
			call createMatch(id_l, full_id[3 + i], full_id[size - i], week, start_first_leg);
			call createMatch(id_l, full_id[size - i], full_id[3 + i], week + size - 1, start_second_leg);			
        end loop;

        full_id = rotate_teams(full_id);
        start_first_leg := start_first_leg + INTERVAL '7' day;
        start_second_leg := start_second_leg + INTERVAL '7' day;
    end loop;
end;
$$
language plpgsql;


select create_schedule(1);
select * from matches



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
	sum(case when m.goal_home_club > m.goal_guest_club then 1 else 0 end),
	sum(case when m.goal_home_club = m.goal_guest_club then 1 else 0 end),
	sum(case when m.goal_home_club < m.goal_guest_club then 1 else 0 end),
	sum(case when m.goal_home_club is null then 0 else m.goal_home_club end),
	sum(case when m.goal_guest_club is null then 0 else m.goal_guest_club end)
	from clubs_in_league c join matches m on c.id = m.id_home_club
	where m.id_league = id_
	group by c.id;
	
	drop table if exists guest_count;
	create temp table if not exists guest_count(id int, notplayed int, played int, wins int, draws int, loses int, goals int, losts int);
	insert into guest_count(id, notplayed, played, wins, draws, loses, goals, losts)
	select c.id,
	sum(case when m.goal_home_club is null then 1 else 0 end),
	sum(case when m.goal_home_club is not null then 1 else 0 end),
	sum(case when m.goal_home_club < m.goal_guest_club then 1 else 0 end),
	sum(case when m.goal_home_club = m.goal_guest_club then 1 else 0 end),
	sum(case when m.goal_home_club > m.goal_guest_club then 1 else 0 end),
	sum(case when m.goal_home_club is null then 0 else m.goal_guest_club end),
	sum(case when m.goal_guest_club is null then 0 else m.goal_home_club end)
	from clubs_in_league c join matches m on c.id = m.id_guest_club
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
-- select * from matches where id_league = 1;
select * from get_table_league(1);