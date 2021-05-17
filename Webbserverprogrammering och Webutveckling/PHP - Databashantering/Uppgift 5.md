> Skriv en fråga som visar alla statusinlägg från person med user_id = 2.

```sql
SELECT * FROM status
WHERE user_id = 2
```

> Skriv en fråga som visar alla kommentarer till ett statusinlägg med status_id = 3.

```sql
SELECT * FROM comment
WHERE status_id = 3
```
