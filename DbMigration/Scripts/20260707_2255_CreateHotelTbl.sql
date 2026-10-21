USE [Following]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Hotel](
	[HotelCode] [int] IDENTITY(1,1) NOT NULL,
	[HotelName] [nvarchar](50) NULL,
	[CityCode] [int] NULL,
	[Certified] [bit] NULL,
	[Mail] [nvarchar](50) NULL,
	[Phone] [int] NULL,
	[ContactName] [nvarchar](50) NULL,
	[Comment] [text] NOT NULL,
	[PointX] [float] NULL,
	[PointY] [float] NULL,
	[Stars] [int] NULL,
	[Location] [bit] NULL,
	[RatingCode] [int] NULL,
	[PaymentCurrencyCode] [int] NULL,
 CONSTRAINT [PK_tbl_hotel] PRIMARY KEY CLUSTERED 
(
	[HotelCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO