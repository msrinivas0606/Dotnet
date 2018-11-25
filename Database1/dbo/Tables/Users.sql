CREATE TABLE [dbo].[Users] (
    [UerId]    INT          IDENTITY (1, 1) NOT NULL,
    [UserName] VARCHAR (50) NULL,
    [Password] VARCHAR (50) NULL,
    [RId]      INT          NULL,
    PRIMARY KEY CLUSTERED ([UerId] ASC)
);

