> Skapa tabellen comment i databasen egyface. Du skall själv välja vilka egenskaper de olika fälten skall tilldelas där jag markerat med "…".

```sql
CREATE TABLE Comment (
    comment_id int UNSIGNED AUTO_INCREMENT,
    user_id int UNSIGNED,
    status_id int UNSIGNED,
    comment varchar(2000),
    pubdate DATETIME,
    PRIMARY KEY (comment_id),
    INDEX (user_id),
    INDEX (status_id)
);
```

> Skapa sedan referensintegritet mellan tabellerna status och comment i phpMyAdmin.
> Skapa sedan referensintegritet mellan tabellerna user och comment i phpMyAdmin.

![](https://i.imgur.com/xlRKCpN.png)

> Lägg även till några kommentarer i tabellen och ange rätt user_id. user_id är den personen som kommenterat en annan användares status.

### Create users

```sql
INSERT INTO User (firstname, surname, username, password)
VALUES
    ("Stearn", "McKeran", "smckeran0", "dNya61jIPZl"),
    ("Florina", "Benza", "fbenza0", "qS8O4D8"),
    ("Donetta", "Marcam", "dmarcam1", "y12kdPq"),
    ("Hollis", "Gambell", "hgambell0", "6llegHec"),
    ("Marieann", "Badger", "mbadger1", "iOnXB8BHHan");
```

### Create Status

```sql
INSERT INTO Status (user_id, status, pubdate, statusuppdateringar)
VALUES
    (1, "Re-engineered dedicated methodology", "2020-12-07 16:44:33", 78),
    (1, "Enhanced dynamic task-force", "2020-12-07 16:44:33", 79),
    (1, "Networked global matrix", "2020-07-19 14:38:49", 80),
    (1, "Down-sized background leverage", "2020-09-05 05:56:07", 81);
```

```sql
INSERT INTO Status (user_id, status, pubdate, statusuppdateringar)
VALUES
    (2, 'Optimized client-driven initiative', '2021-02-12 01:31:59', 65),
    (2, 'Down-sized homogeneous leverage', '2021-03-14 01:22:07', 66),
    (2, 'Grass-roots web-enabled moratorium', '2021-04-16 15:17:19', 67),
    (2, 'Innovative encompassing circuit', '2020-09-07 18:13:58', 68);
```

```sql
INSERT INTO Status (user_id, status, pubdate, statusuppdateringar)
VALUES
    (3, 'Pre-emptive systemic collaboration', '2020-07-01 12:25:04', 21),
    (3, 'Fully-configurable incremental productivity', '2020-08-26 18:19:51', 22),
    (3, 'Persistent context-sensitive adapter', '2020-05-18 00:24:49', 23),
    (3, 'Right-sized asynchronous project', '2020-10-05 08:58:18', 24);
```

```sql
INSERT INTO Status (user_id, status, pubdate, statusuppdateringar)
VALUES
    (4, 'Fully-configurable solution-oriented archive', '2020-11-20 16:00:48', 44),
    (4, 'Face to face even-keeled installation', '2020-12-10 06:46:47', 45),
    (4, 'Centralized methodical circuit', '2021-01-16 09:25:00', 46),
    (4, 'Integrated scalable superstructure', '2020-06-10 11:04:55', 47);
```

```sql
INSERT INTO Status (user_id, status, pubdate, statusuppdateringar)
VALUES
    (5, 'Switchable directional extranet', '2021-04-02 05:09:17', 69),
    (5, 'Synergized mobile archive', '2020-12-24 13:26:23', 70),
    (5, 'Secured static approach', '2020-05-23 18:18:48', 71),
    (5, 'Face to face fresh-thinking project', '2021-04-04 14:01:27', 72);
```

### Create Comments

```sql
INSERT INTO Comment (user_id, status_id, comment, pubdate)
VALUES
    (1, 3, 'extend magnetic synergies', '2021-02-09 13:53:01'),
    (5, 4, 'iterate next-generation methodologies', '2020-12-30 03:47:13'),
    (3, 12, 'innovate ubiquitous experiences', '2020-09-22 15:21:24'),
    (5, 20, 'repurpose virtual supply-chains', '2021-03-02 22:06:05'),
    (4, 15, 'transform wireless partnerships', '2020-10-09 14:13:33'),
    (1, 1, 'extend scalable systems', '2020-11-27 14:13:24'),
    (4, 12, 'cultivate visionary communities', '2020-12-25 18:17:10'),
    (3, 13, 'deploy e-business networks', '2020-10-19 11:51:49'),
    (4, 9, 'unleash visionary architectures', '2020-06-25 02:04:34'),
    (1, 16, 'recontextualize bricks-and-clicks applications', '2020-08-01 06:38:08'),
    (1, 5, 'productize B2C portals', '2020-12-22 06:11:59'),
    (3, 2, 'visualize user-centric supply-chains', '2021-01-30 08:08:25'),
    (3, 19, 'productize robust applications', '2021-03-24 21:35:21'),
    (4, 4, 'repurpose bricks-and-clicks portals', '2020-10-08 07:53:08'),
    (4, 19, 'matrix collaborative e-services', '2020-09-22 15:56:09'),
    (2, 16, 'engage seamless systems', '2020-07-20 08:47:59'),
    (4, 12, 'maximize turn-key metrics', '2021-04-05 12:30:56'),
    (2, 18, 'synthesize open-source vortals', '2020-10-06 10:52:06'),
    (3, 16, 'generate integrated relationships', '2021-01-23 05:37:33');
```
