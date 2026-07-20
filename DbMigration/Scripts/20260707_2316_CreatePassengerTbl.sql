USE [Following]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Passenger](
	[PassengerId] [int] IDENTITY(1,1) NOT NULL,
	[HebrewFirstNamePassenger] [nvarchar](50) NULL,
	[EnglishFirstNamePassenger] [nvarchar](50) NULL,
	[HebrewLastNamePassenger] [nvarchar](50) NULL,
	[EnglishLastNamePassenger] [nvarchar](50) NULL,
	[Mail] [nvarchar](50) NULL,
	[Phone] [int] NULL,
	[Gender] [bit] NULL,
 CONSTRAINT [PK_tbl_passenger] PRIMARY KEY CLUSTERED 
(
	[PassengerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO