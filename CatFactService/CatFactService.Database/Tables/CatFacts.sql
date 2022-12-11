CREATE TABLE [dbo].[CatFacts](
	[CatFactId] [uniqueidentifier] NOT NULL,
	[Text] [nvarchar](2000) NOT NULL,
	[SourceId] [int] NOT NULL,
	[TypeId] [int] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[Verified] [bit] NULL,
	[SentCount] [int] NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdatedAt] [datetime] NULL,
	[Deleted] [bit] NULL,
	[Used] [bit] NULL,
	[Votes] [int] NULL,
	CONSTRAINT [PK_CatFact] PRIMARY KEY CLUSTERED (	[CatFactId] ASC)
)
GO

ALTER TABLE [dbo].[CatFacts] ADD  CONSTRAINT [DF_CatFact_Deleted]  DEFAULT ((0)) FOR [Deleted]
GO

ALTER TABLE [dbo].[CatFacts]  WITH CHECK ADD  CONSTRAINT [FK_CatFacts_Sources] FOREIGN KEY([SourceId])REFERENCES [dbo].[Sources] ([SourceId])
GO

ALTER TABLE [dbo].[CatFacts] CHECK CONSTRAINT [FK_CatFacts_Sources]
GO

ALTER TABLE [dbo].[CatFacts]  WITH CHECK ADD  CONSTRAINT [FK_CatFacts_Types] FOREIGN KEY([TypeId])REFERENCES [dbo].[Types] ([TypeId])
GO

ALTER TABLE [dbo].[CatFacts] CHECK CONSTRAINT [FK_CatFacts_Types]
GO

ALTER TABLE [dbo].[CatFacts]  WITH CHECK ADD  CONSTRAINT [FK_CatFacts_Users] FOREIGN KEY([UserId]) REFERENCES [dbo].[Users] ([UserId])
GO

ALTER TABLE [dbo].[CatFacts] CHECK CONSTRAINT [FK_CatFacts_Users]
GO