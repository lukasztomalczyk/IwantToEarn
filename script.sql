IF OBJECT_ID(N'__EFMigrationsHistory') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [JobModels] (
    [Id] int NOT NULL IDENTITY,
    [Cash] money NOT NULL,
    [Description] ntext NOT NULL,
    [JobTitle] nchar(20) NOT NULL,
    [WhereIsJob] nchar(20) NOT NULL,
    [ForHourOrWholeJob] bit NOT NULL,
    CONSTRAINT [PK_JobModels] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20180225192509_second', N'2.0.0-rtm-26452');

GO


