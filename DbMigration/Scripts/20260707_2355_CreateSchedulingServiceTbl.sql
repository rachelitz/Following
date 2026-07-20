USE [Following]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [SchedulingService](
	[SchedulingServiceCode] [int] IDENTITY(1,1) NOT NULL,
	[JourneyCode] [int] NULL,
	[PassengerId] [int] NULL,
	[HotelServiceParticularCode] [int] NULL,
	[TeamOrPassenger] [bit] NULL,
	[StatusCode] [int] NULL,
	[Date] [date] NULL,
	[BeginingTime] [time](7) NULL,
	[EndTime] [time](7) NULL,
 CONSTRAINT [PK_tbl_schedulingService] PRIMARY KEY CLUSTERED 
(
	[SchedulingServiceCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO