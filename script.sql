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
    [Cash] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [Title] nvarchar(max) NULL,
    [Where] nvarchar(max) NULL,
    [WholeOrHour] nvarchar(max) NULL,
    CONSTRAINT [PK_JobModels] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20180223183417_first', N'2.0.0-rtm-26452');

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'JobModels') AND [c].[name] = N'WholeOrHour');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [JobModels] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [JobModels] ALTER COLUMN [WholeOrHour] int NOT NULL;

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'JobModels') AND [c].[name] = N'Cash');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [JobModels] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [JobModels] ALTER COLUMN [Cash] float NOT NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20180223192906_second', N'2.0.0-rtm-26452');

GO


