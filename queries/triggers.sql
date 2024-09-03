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
	insert into feedbacks(grade, id_league) values (5, new.id);
	return new;
end;
$$
language plpgsql;

create trigger auto_insert
after insert on leagues
for each row execute function insert_feedback();

