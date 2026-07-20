USE [Following]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Journey](
	[JourneyCode] [int] IDENTITY(1,1) NOT NULL,
	[JourneyName] [nvarchar](50) NULL,
	[CountryCode] [int] NULL,
	[TypeGroupCode] [int] NULL,
	[BeginningDate] [date] NULL,
	[EndDate] [date] NULL,
	[BuisnessCustomersCode] [int] NULL,
	[StatusCode] [int] NULL,
	[BeginningFlighCode] [int] NULL,
	[EndFlighCode] [int] NULL,
 CONSTRAINT [PK_tbl_journey] PRIMARY KEY CLUSTERED 
(
	[JourneyCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO