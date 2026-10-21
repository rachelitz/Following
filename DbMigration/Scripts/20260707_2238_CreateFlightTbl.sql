USE [Following]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Flight](
	[FlightCode] [int] NOT NULL,
	[TakeoffTime] [time](7) NULL,
	[LandingTime] [time](7) NULL,
	[SourceTerminal] [nvarchar](50) NULL,
	[DestinationTerminal] [nvarchar](50) NULL,
	[SourceCountryCode] [int] NULL,
	[DestinationCountryCode] [int] NULL,
	[CityCode] [int] NULL,
	[FlightCost] [float] NULL,
	[FlightDate] [date] NULL,
	[AirlineCode] [int] NULL,
 CONSTRAINT [PK_tbl_flight] PRIMARY KEY CLUSTERED 
(
	[FlightCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO