USE [Following]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [HotelServiceParticular](
	[HotelServiceParticularCode] [int] IDENTITY(1,1) NOT NULL,
	[HotelCode] [int] NULL,
	[HotelServiceCode] [int] NULL,
	[Amount] [int] NULL,
	[TariffGroup] [float] NOT NULL,
	[TariffSingle] [float] NOT NULL,
 CONSTRAINT [PK_tbl_hotelServiceParticular] PRIMARY KEY CLUSTERED 
(
	[HotelServiceParticularCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO