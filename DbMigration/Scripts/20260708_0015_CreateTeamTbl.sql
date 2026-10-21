USE [Following]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Team](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[HebrewFirstNameEmployee] [nvarchar](50) NULL,
	[EnglishFirstNameEmployee] [nvarchar](50) NULL,
	[HebrewLastNameEmployee] [nvarchar](50) NULL,
	[EnglishLastNameEmployee] [nvarchar](50) NULL,
	[Phone] [int] NULL,
	[Mail] [nvarchar](50) NULL,
	[RoleCode] [int] NULL,
	[CostToDay] [int] NULL,
 CONSTRAINT [PK_tbl_team] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO