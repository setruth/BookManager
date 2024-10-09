use bookManager
go

create table dbo.book_info
(
    bookId char(20)       not null
        primary key,
    name   varchar(50)    not null,
    author varchar(50)    not null,
    press  varchar(50)    not null,
    price  decimal(18, 2) not null,
    status int            not null
)
go

create table dbo.borrow_info
(
    readerId       char(20) not null,
    bookId         char(20) not null,
    borrowDate     datetime not null,
    borrowOverDate datetime not null,
    status         int
)
go

create table dbo.login_info
(
    id       int identity
        primary key,
    account  varchar(25) not null,
    password varchar(25) not null
)
go

create table dbo.reader_info
(
    readerId      char(20)    not null
        constraint PK__reader_i__40E38288A6AC2714
            primary key,
    typeId        int         not null,
    name          varchar(25) not null,
    department    varchar(40) not null,
    qq            varchar(25) not null,
    alreadyBorrow varchar(25) not null
)
go

create table dbo.reader_type
(
    typeId       int identity
        primary key,
    typeName     varchar(20),
    borrowDay    int,
    borrowNumber int
)
go

