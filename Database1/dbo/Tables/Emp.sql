CREATE TABLE [dbo].[Emp] (
    [Id]      INT          IDENTITY (1, 1) NOT NULL,
    [Ename]   VARCHAR (50) NULL,
    [Address] VARCHAR (50) NULL,
    [Salary]  MONEY        NULL,
    [Gender]  VARCHAR (50) NULL,
    [DepID]   INT          NULL,
    FOREIGN KEY ([DepID]) REFERENCES [dbo].[Dept] ([DepId])
);

