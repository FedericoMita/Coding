SELECT * FROM Users; -- All Users
SELECT * FROM Books; -- All Books
SELECT l.user_id_loaned, u.First_Name, u.Last_Name, b.title, l.ISBN_Loaned FROM Users u 
INNER JOIN Loaned l ON u.user_id = l.user_id_loaned
INNER JOIN Books b ON b.ISBN = l.ISBN_loaned
ORDER BY user_id; -- this, from 3 to here, to get all the users who loaned books and what books
SELECT l.user_id_loaned, u.First_Name, u.Last_Name, b.title, b.author_1, l.due_date, l.ISBN_Loaned FROM Users u 
INNER JOIN Loaned l ON u.user_id = l.user_id_loaned
INNER JOIN Books b ON b.ISBN = l.ISBN_loaned
WHERE due_date<CURDATE()
ORDER BY user_id; -- this, from 7 to here, to show just the books due to be given back and who has them