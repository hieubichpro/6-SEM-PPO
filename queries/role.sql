create role league_admin with
	connection limit -1
	login
	password '#admin123';

grant all privileges
on all tables in schema public
to league_admin;

create role league_footballer with
	connection limit -1
	login
	password '#footballer123';
	
grant select on all tables in schema public
to league_footballer;

grant insert on
	public."feedbacks",
	public."requests"
to league_footballer;

grant update on
	public."users"
to league_footballer;

grant delete on
	public."requests",
	public."feedbacks"
to league_footballer;

create role league_coach with
	connection limit - 1
	login
	password '#coach123';
	
grant select on all tables in schema public
to league_coach;

grant insert on
	public."clubs",
	public."feedbacks",
	public."requests"
to league_coach;

grant update on
	public."clubs",
	public."users"
to league_coach;

grant delete on
	public."requests"
to league_coach;

create role league_referee with
	connection limit - 1
	login
	password '#referee123';
	
grant select on all tables in schema public
to league_referee;

grant insert on
	public."leagues",
	public."leagueclub",
	public."feedbacks",
	public."matches"
to league_referee;	

grant update on
	public."leagues",
	public."users",
	public."matches"
to league_referee;

grant delete on
	public."requests"
to league_referee;


create role league_guest with
	connection limit -1
	login
	password '#guest123';
	
grant select on all tables in schema public
to league_referee;	

grant insert on
	public."users",
	public."feedbacks"
to league_guest
	