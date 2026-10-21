USE [Following]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [TeamInJourney](
	[TeamInJourneyCode] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NULL,
	[JourneyCode] [int] NULL,
	[CostToDay] [float] NULL,
	[RoomType] [nvarchar](50) NULL,
	[LocalOrNotLocal] [bit] NULL,
	[StayFromDate] [date] NULL,
	[StayUntilDate] [date] NULL,
	[WageExtension] [float] NULL,
	[BeginningFlighCode] [int] NULL,
	[EndFlighCode] [int] NULL,
	[CurencyCode] [int] NULL,
	[BeginningFlighCost] [float] NULL,
	[EndFlighCost] [float] NULL,
 CONSTRAINT [PK_tbl_teamInJourney] PRIMARY KEY CLUSTERED 
(
	[TeamInJourneyCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO