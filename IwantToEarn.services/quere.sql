CREATE DATABASE IwantToEarn
SELECT * FROM Sys.Tables



SELECT * FROM INFORMATION_SCHEMA.TABLES 

SELECT * FROM JobModels

INSERT INTO JobModels
VALUES (1, 'password', 'emaila@wp.pl')
GO

CREATE TABLE [JobModels] (
	[id] [nchar](10) NOT NULL,
	[Cash] [numeric](18, 0) NOT NULL,
	[Description] [ntext] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Where] [nchar](15) NOT NULL,
	[WholeOrHour] [bit] NOT NULL
);

DROP TABLE JobModels

DELETE FROM
JobModels
 WHERE id = 1
