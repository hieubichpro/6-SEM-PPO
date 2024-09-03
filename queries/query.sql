drop table if exists Users;
drop table if exists Matches;
drop table if exists Clubs;
drop table if exists Leagues;
drop table if exists Feedbacks;
drop table if exists LeagueClub;

create table if not exists Users
(
	id serial primary key,
	login varchar(32) not null,
	password varchar(32) not null,
	role varchar(32) not null,
	name varchar(64) default 'hieu'
);

create table if not exists Clubs
(
	id serial not null primary key,
	name varchar(32) not null
);

create table if not exists Leagues
(
	id serial not null primary key,
	name varchar(30) not null,
	rating float,
	id_user int,
	
	foreign key (id_user) references Users(id)
);

create table if not exists Matches
(
	id serial not null primary key,
	goal_home_club int,
	goal_guest_club int,
	id_league int not null,
	id_home_club int not null,
	id_guest_club int not null,
	time_start varchar(64),
	week int,
	
	foreign key (id_league) references Leagues(id),
	foreign key (id_home_club) references Clubs(id),
	foreign key (id_guest_club) references Clubs(id)
);

create table if not exists Feedbacks
(
	id serial not null primary key,
	grade int not null,
	id_league int not null,
	foreign key (id_league) references Leagues(id)
);

create table if not exists LeagueClub
(
	id serial not null primary key,
	id_league int not null,
	id_club int not null,
	
	foreign key (id_league) references Leagues(id),
	foreign key (id_club) references Clubs(id)
);

create table if not exists ClubStat
(
	id serial not null pri
);