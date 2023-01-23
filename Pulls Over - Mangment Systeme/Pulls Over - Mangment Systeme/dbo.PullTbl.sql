CREATE TABLE [dbo].[PullTbl] (
    [Bld]        INT          IDENTITY (500, 1) NOT NULL,
    [Genre]      VARCHAR (50) NOT NULL,
    [Size]       VARCHAR (50) NOT NULL,
    [Mark] VARCHAR (50) NOT NULL,
    [Quantity]   INT          NOT NULL,
    [Price]      INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Bld] ASC)
);

