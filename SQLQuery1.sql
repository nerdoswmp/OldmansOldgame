create table Usr(
	id int identity primary key,
	nickname varchar(50) not null,
	email varchar(100) not null,
	password varchar(50) not null,
	scoreRegular smallint not null,
	scoreSuper smallint not null
	)

create table Matches(
	id int identity primary key,
	playerId1 int foreign key references Usr(id) not null,
	playerId2 int foreign key references Usr(id) not null,
	boardLayout varchar(18) not null,
	)

create table MatchQueue(
	id int identity primary key,
	playerId int foreign key references Usr(id),
	QueueState int,
	GameMode int,
	)

drop table MatchQueue