
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/15/2020 00:30:02
-- Generated from EDMX file: T:\.Net Framework\Day_21\Q2_ModelFirst\Model_Emp_DB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Demodata];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Empdemoes'
CREATE TABLE [dbo].[Empdemoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Salary] real  NOT NULL,
    [DeptdemoId] int  NOT NULL
);
GO

-- Creating table 'Deptdemoes'
CREATE TABLE [dbo].[Deptdemoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Empdemoes'
ALTER TABLE [dbo].[Empdemoes]
ADD CONSTRAINT [PK_Empdemoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Deptdemoes'
ALTER TABLE [dbo].[Deptdemoes]
ADD CONSTRAINT [PK_Deptdemoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DeptdemoId] in table 'Empdemoes'
ALTER TABLE [dbo].[Empdemoes]
ADD CONSTRAINT [FK_DeptdemoEmpdemo]
    FOREIGN KEY ([DeptdemoId])
    REFERENCES [dbo].[Deptdemoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeptdemoEmpdemo'
CREATE INDEX [IX_FK_DeptdemoEmpdemo]
ON [dbo].[Empdemoes]
    ([DeptdemoId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------