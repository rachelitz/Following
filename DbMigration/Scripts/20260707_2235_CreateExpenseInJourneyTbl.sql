USE [Following]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ExpenseInJourney](
	[ExpenseInJourneyCode] [int] IDENTITY(1,1) NOT NULL,
	[ExpenseCode] [int] NULL,
	[Cost] [float] NULL,
	[CurrencyCode] [int] NULL,
	[SingleOrGroup] [bit] NULL,
 CONSTRAINT [PK_tbl_expenseInJourney] PRIMARY KEY CLUSTERED 
(
	[ExpenseInJourneyCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO