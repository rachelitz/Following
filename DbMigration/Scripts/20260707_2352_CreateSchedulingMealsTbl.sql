USE [Following]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [SchedulingMeals](
	[SchedulingMealCode] [int] IDENTITY(1,1) NOT NULL,
	[ServiceCateringTariffCode] [int] NULL,
	[Level] [nvarchar](50) NULL,
	[DayInWeek] [int] NULL,
 CONSTRAINT [PK_tbl_schedulingMeals] PRIMARY KEY CLUSTERED 
(
	[SchedulingMealCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO