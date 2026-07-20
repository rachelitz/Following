USE [Following]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Route](
	[RouteCode] [int] IDENTITY(1,1) NOT NULL,
	[JourneyCode] [int] NULL,
	[SiteCode] [int] NULL,
	[Date] [date] NULL,
	[Comment] [text] NULL,
	[ChronologicalOrder] [int] NULL,
	[DayInWeek] [int] NULL,
	[BeginningTime] [time](7) NULL,
	[EndTime] [time](7) NULL,
	[StatusCode] [int] NULL,
 CONSTRAINT [PK_tbl_route] PRIMARY KEY CLUSTERED 
(
	[RouteCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO