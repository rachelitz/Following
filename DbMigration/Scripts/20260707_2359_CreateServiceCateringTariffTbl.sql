USE [Following]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ServiceCateringTariff](
	[ServiceCateringTariffCode] [int] IDENTITY(1,1) NOT NULL,
	[CateringCode] [int] NULL,
	[MealTypeCode] [int] NULL,
	[TariffA] [float] NULL,
	[TariffB] [float] NULL,
	[TariffC] [float] NULL,
	[CurrencyCode] [int] NULL,
 CONSTRAINT [PK_tbl_serviceCateringTariff] PRIMARY KEY CLUSTERED 
(
	[ServiceCateringTariffCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO