CREATE DATABASE IwantToEarn
SELECT * FROM Sys.Tables



SELECT * FROM INFORMATION_SCHEMA.TABLES 

SELECT * FROM JobModels

INSERT INTO JobModels
VALUES ('Lukasz', 'password', 'emaila@wp.pl')
GO

CREATE TABLE [JobModels] (
    [Id] int NOT NULL IDENTITY,
    [Cash] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [Title] nvarchar(max) NULL,
    [Where] nvarchar(max) NULL,
    [WholeOrHour] nvarchar(max) NULL,
    CONSTRAINT [PK_JobModels] PRIMARY KEY ([Id])
);