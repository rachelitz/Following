USE [Following]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [MealsInJourney](
	[MealInJourneyCode] [int] IDENTITY(1,1) NOT NULL,
	[JourneyCode] [int] NULL,
	[SchedulingMealCode] [int] NULL,
	[Date] [date] NULL,
	[BeginningTime] [time](7) NULL,
	[EndTime] [time](7) NULL,
	[Location] [nvarchar](50) NULL,
	[Comment] [text] NOT NULL,
 CONSTRAINT [PK_tbl_mealsInJourney] PRIMARY KEY CLUSTERED 
(
	[MealInJourneyCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO