-- Create a new database called 'PasswordWeb'
-- Connect to the 'master' database to run this snippet
USE master
GO
-- Create the new database if it does not exist already
IF NOT EXISTS (
    SELECT name
        FROM sys.databases
        WHERE name = N'PasswordWeb'
)
CREATE DATABASE PasswordWeb
GO
USE PasswordWeb
GO
-- Create a new table called 'TableName' in schema 'SchemaName'
-- Drop the table if it already exists
IF OBJECT_ID('dbo.School', 'U') IS NOT NULL
BEGIN
    ALTER TABLE dbo.TeachesAt
        DROP CONSTRAINT [FK_TeachesAt_School]
    DROP TABLE School
END
GO
-- Create the table in the specified schema
CREATE TABLE School
(
    Id INT NOT NULL PRIMARY KEY, -- primary key column
    Name [NVARCHAR](255) NOT NULL
);
GO
-- Create a new table called 'Teacher' in schema 'SchemaName'
-- Drop the table if it already exists
IF OBJECT_ID('dbo.Teacher', 'U') IS NOT NULL
BEGIN
    ALTER TABLE dbo.TeachesAt
        DROP CONSTRAINT [FK_TeachesAt_Teacher]
    DROP TABLE Teacher
END
GO
-- Create the table in the specified schema
CREATE TABLE Teacher
(
    Id INT NOT NULL PRIMARY KEY, -- primary key column
    Name [NVARCHAR](255) NOT NULL
);
GO
-- Create a new table called 'Student' in schema 'SchemaName'
-- Drop the table if it already exists
IF OBJECT_ID('dbo.Student', 'U') IS NOT NULL
DROP TABLE Student
GO
-- Create the table in the specified schema
CREATE TABLE Student
(
    Id INT NOT NULL PRIMARY KEY, -- primary key column
    Name [NVARCHAR](50) NOT NULL
);
GO
-- Create a new table called 'TeachesAt' in schema 'dbo'
-- Drop the table if it already exists
IF OBJECT_ID('dbo.TeachesAt', 'U') IS NOT NULL
DROP TABLE dbo.TeachesAt
GO
-- Create the table in the specified schema
CREATE TABLE dbo.TeachesAt
(
    SchoolId INT NOT NULL,
    TeacherId INT NOT NULL,
    CONSTRAINT [PK_TeachesAt] PRIMARY KEY CLUSTERED (
        [SchoolId] ASC,
        [TeacherId] ASC
    )
);
GO
ALTER TABLE dbo.TeachesAt WITH CHECK 
    ADD CONSTRAINT [FK_TeachesAt_School] FOREIGN KEY([SchoolId])
    REFERENCES [dbo].[School] ([Id])
GO
ALTER TABLE [dbo].[TeachesAt]  WITH CHECK 
    ADD  CONSTRAINT [FK_TeachesAt_Teacher] FOREIGN KEY([TeacherId])
    REFERENCES [dbo].[Teacher] ([Id])
GO
-- Create a new table called 'GoesTo' in schema 'SchemaName'
-- Drop the table if it already exists
IF OBJECT_ID('dbo.GoesTo', 'U') IS NOT NULL
DROP TABLE dbo.GoesTo
GO
-- Create the table in the specified schema
CREATE TABLE dbo.GoesTo
(
    SchoolId INT NOT NULL,
    StudentId INT NOT NULL
);
GO