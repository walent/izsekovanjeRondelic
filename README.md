#Introduction

Tukaj je repozitorj za projekt Izsekovanje rondelic

#Database

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Slugs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[lenght] [decimal](18, 0) NOT NULL,
	[width] [decimal](18, 0) NOT NULL,
	[radious] [decimal](18, 0) NOT NULL,
	[space] [decimal](18, 0) NOT NULL,
	[result] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Slugs] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO