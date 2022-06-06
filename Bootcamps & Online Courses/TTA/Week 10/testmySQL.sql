CREATE DATABASE library;
CREATE TABLE Books (
	title VARCHAR(100) NOT NULL,
    author_1 VARCHAR(30) NOT NULL,
    author_2 VARCHAR(30), -- all these other "author" fields are for books with more than one author, but they can be NULL
    author_3 VARCHAR(30),
    author_4 VARCHAR(30),
    author_5 VARCHAR(30),
    author_6 VARCHAR(30),
    author_7 VARCHAR(30),
    author_8 VARCHAR(30),
    author_9 VARCHAR(30),
    author_10 VARCHAR(30),
    ISBN BIGINT NOT NULL, -- an ISBN can be between 10 and 13 num long, so not enough for an INT
    PRIMARY KEY(ISBN),
    stock INT NOT NULL
);
INSERT INTO Books VALUES ("Call of Cthulhu: Fantasy Roleplaying in the Worlds of HP Lovecraft", "Sandy Petersen", NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 9780933635586, 2); -- Since I included the possibility of having multiple authors, I'm forced to write NULL for the empty fields, as I don't know how else to manage this (as of the time of me writing this)
INSERT INTO Books VALUES ("Vampire: The Masquerade", "Phil Brucato", "Tom Dowd", "Mark Rein-Hagen", "Richard E. Dansky", NULL, NULL, NULL, NULL, NULL, NULL, 9781565042490, 4);
INSERT INTO Books VALUES ("IT", "Stephen King", NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 9780670813025, 27);
INSERT INTO Books VALUES ("Elantris", "Brandon Sanderson", NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 9780765311771, 12);
INSERT INTO Books VALUES ("Watchmen", "Alan Moore", "Dave Gibson", NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 9781852860240, 15);
INSERT INTO Books VALUES ("Supergod", "Warren Ellis", "Garrie Gastonny", NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 9781592911004, 6);
INSERT INTO Books VALUES ("Necronomicon", "H. R. Giger", NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL,  9780905664064, 8);
INSERT INTO Books VALUES ("The Fantastic Art of Frank Frazetta", "Frank Frazetta", "Betty Ballantine",  NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 9780684144160, 1);
INSERT INTO Books VALUES ("Trigun", "Yasuhiro Nightow",  NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 9783551767011, 2);
INSERT INTO Books VALUES ("Ghost in the Shell", "Masamune Shirow",  NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 9781569710814, 5);
COMMIT;