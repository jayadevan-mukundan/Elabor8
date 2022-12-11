CREATE TABLE [dbo].[Users](
	[UserId] [uniqueidentifier] NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED (	[UserId] ASC)
);
GO