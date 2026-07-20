USE [Following]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Site](
	[SiteCode] [int] IDENTITY(1,1) NOT NULL,
	[CityCode] [int] NULL,
	[CountryCode] [int] NULL,
	[HebrewSiteName] [nvarchar](50) NULL,
	[EnglishSiteName] [nvarchar](50) NULL,
	[StayTime] [int] NULL,
	[Cost] [float] NULL,
	[PointX] [float] NULL,
	[PointY] [float] NULL,
 CONSTRAINT [PK_tbl_site] PRIMARY KEY CLUSTERED 
(
	[siteCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO