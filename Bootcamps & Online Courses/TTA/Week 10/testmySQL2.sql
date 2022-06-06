USE library;
CREATE TABLE Users (
	user_id MEDIUMINT AUTO_INCREMENT NOT NULL, -- MEDIUMINT because I don't think a library is going to have more than 8388607 users but it might have more than 32767 (SMALLINT)
	PRIMARY KEY(user_id),
    First_Name VARCHAR(15) NOT NULL,
	Last_Name VARCHAR(15) NOT NULL,
    Contact_Number VARCHAR(32) NOT NULL, -- Longest telephone number possible should be at max 15 num long, then there are the +, the country code, the area code and the possibility of other char like () - and so on
    City VARCHAR(85) NOT NULL, -- 85 is the longest name recorded for any place
    Address_1 VARCHAR(50) NOT NULL, -- Address shouldn't be more than 35-40, but just in case
    Address_2 VARCHAR(50), -- can be NULL, as it's not necessary to fill
    County VARCHAR(30) NOT NULL, -- longest county name in the UK is "Cambridgeshire and Isle of Ely", a total of 30 char
    Postcode CHAR(7) NOT NULL -- I chose a CHAR because postcodes a pretty consistent, being 5 to 7 char, so maybe it could save up memory?
);
INSERT INTO Users VALUES (4, "Bruce", "Wayne", 07893475629, "Gotham City", "1007, Mountain Drive", "Batcave", "Gotham", "NG8 2AE");
INSERT INTO Users VALUES (6, "Tony", "Stark", 09023853948, "Point Dume", "10880, Malibu Point", NULL, "Malibu", "MRVL616");
INSERT INTO Users VALUES (49, "Jessica", "Fletcher", 93829774, "Cabot Cove", "698, CAndlewood Lane", NULL, "Maine", "FN39F");
INSERT INTO Users VALUES (287, "Sherlock", "Holmes", 2984723987, "London", "221B, Baker Street", NULL, "Greater London", "OFN38");
INSERT INTO Users VALUES (2397, "Herman", "Munster", 2593528955, "Mockingbird Heights", "1313, Mockingbird Lane", NULL, "Los Angeles", "NF93FN");
INSERT INTO Users VALUES (29374, "Phileas", "Fogg", 234829384, "London", "7, Savile Row", "Burlington Gardens", "Greater London", "984NF");
INSERT INTO Users VALUES (37, "Spongebob", "Squarepants", 293829493, "Bikini Bottom", "124, Conch Street", NULL, "Pacific Ocean", "46BF9");
INSERT INTO Users VALUES (7, "Sweeny", "Todd", 0923492734, "London", "186, Fleet Street", NULL, "Greater London", "8DK92");
INSERT INTO Users VALUES (2, "Homer", "Simpson", 0234475923, "Springfield", "742, Evergreen Terrace", NULL, "Maine", "PE02SN");
INSERT INTO Users VALUES (73387, "Harry", "Potter", 02387426, "Little Whinging", "4, Privet Drive", "The Cupboard unda the Stairs", "Surrey", "FO9FH");
COMMIT;