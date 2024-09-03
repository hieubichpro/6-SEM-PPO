select * from users
insert into users(login, password, role, name) values ('messi', '1', 'Referee', 'LM10');
insert into users(login, password, role, name) values ('ronaldo', '1', 'Referee', 'hieu');
select * from leagues
insert into leagues(name, rating, id_user) values ('EPL', 5, 1);
insert into leagues(name, rating, id_user) values ('CPL', 5, 2);
select * from leagueclub
select * from clubs
select * from leagues