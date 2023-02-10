CREATE TABLE [dbo].[Projects] (
    [PId]       INT          NOT NULL,
    [Title]     VARCHAR (50) NOT NULL,
	[StartDate] Date         NOT NULL,
    [Deadline]  DATE         NOT NULL,
    [People]    INT          NOT NULL,
    [ManagerId] VARCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([PId] ASC),
    FOREIGN KEY ([ManagerId]) REFERENCES [dbo].[Employees] ([Id])
);

