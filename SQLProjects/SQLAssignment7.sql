CREATE DATABASE moviesDB;
USE moviesDB
GO

/* Creates the actors table */
CREATE TABLE tbl_actors (
	actor_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	actor_fname VARCHAR(50) NOT NULL,
	actor_lname VARCHAR(50) NOT NULL,
	movie_name VARCHAR(50) NOT NULL
	);

/* Inserts available data for actors */
INSERT INTO tbl_actors 
	(actor_fname, actor_lname, movie_name)
	VALUES
	('Harrison', 'Ford', 'Star Wars'),
	('Samuel', 'Jackson', 'Pulp Fiction'),
	('Bruce', 'Willis', 'Die Hard'),
	('Jeff', 'Goldblum', 'Jurassic Park'),
	('Drew', 'Barrymore', 'E.T.')
;

/* Creates the directors table*/
CREATE TABLE tbl_directors (
	director_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	director_fname VARCHAR(50) NOT NULL,
	director_lname VARCHAR(50) NOT NULL,
	director_movie VARCHAR(50) NOT NULL,
);

/*Inserts the data about the available directors*/
INSERT INTO tbl_directors 
	(director_fname, director_lname, director_movie)
	VALUES
	('Steven','Spielberg', 'Jurassic Park'),
	('Quentin', 'Tarantino', 'Pulp Fiction'),
	('Christopher', 'Nolan', 'Memento'),
	('Peter', 'Jackson', 'The Lord of the Rings'),
	('Mel', 'Brooks', 'Blazing Saddles')
;

/* Query that searches for actors and directors that have worked on the same movie */
SELECT 
	a1.actor_fname, a1.actor_lname, d1.director_fname,
	d1.director_lname, a1.movie_name 
	FROM tbl_actors a1
	INNER JOIN tbl_directors d1 ON a1.movie_name = d1.director_movie
	