USE [Following]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BusinessCustomer](
	[CustomerCode] [int] NOT NULL,
	[CompanyName] [nvarchar](50) NULL,
	[ContactName] [nvarchar](50) NULL,
	[Phone] [int] NULL,
	[Mail] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_businessCustomer] PRIMARY KEY CLUSTERED 
(
	[CustomerCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
