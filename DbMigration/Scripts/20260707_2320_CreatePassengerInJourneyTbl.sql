USE [Following]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [PassengerInJourney](
	[PassengerInJournetCode] [int] NOT NULL,
	[PassengerId] [int] NULL,
	[JourneyCode] [int] NULL,
	[TypeInsurance] [nvarchar](50) NULL,
	[RationTypeCode] [int] NULL,
	[TypeRoom] [nvarchar](50) NULL,
	[NumberInvitation] [int] NULL,
	[BeginningFlighCode] [int] NULL,
	[EndFlightCode] [int] NULL,
	[BeginningFlighCost] [float] NULL,
	[EndFlightCost] [float] NULL,
 CONSTRAINT [PK_tbl_passengerInJourney] PRIMARY KEY CLUSTERED 
(
	[PassengerInJournetCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO