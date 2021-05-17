> Skapa databasen egyface om du inte redan gjort detta.

```sql
CREATE DATABASE egyface;
```

> Skapa tabellen user i databasen egyface på det sätt vi gått igenom.

```sql
CREATE TABLE User (
    user_id int UNSIGNED AUTO_INCREMENT,
    firstname varchar(30),
    surname varchar(30),
    username varchar(30),
    password varchar(80),
    PRIMARY KEY (user_id)
);
```

> Skapa tabellen status i databasen egyface enligt nedan. Skapa sedan referensintegritet mellan tabellerna status och user i phpMyAdmin.

```sql
CREATE TABLE Status (
    status_id int UNSIGNED AUTO_INCREMENT,
    user_id int UNSIGNED,
    status varchar(500),
    pubdate DATETIME,
    PRIMARY KEY (status_id),
    INDEX (user_id)
);
```

> Lägg även till ett antal statusuppdateringar.

```sql
ALTER TABLE Status
ADD statusuppdateringar int(255);
```
