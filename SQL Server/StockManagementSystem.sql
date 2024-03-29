USE [StockManagementSystem]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 7/4/2019 3:40:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Companies]    Script Date: 7/4/2019 3:40:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Companies](
	[CompanyID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 7/4/2019 3:40:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [varchar](100) NULL,
	[CompanyID] [int] NULL,
	[CategoryID] [int] NULL,
	[ItemReorderLevel] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StocksIn]    Script Date: 7/4/2019 3:40:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StocksIn](
	[StockInID] [int] IDENTITY(1,1) NOT NULL,
	[ItemID] [int] NULL,
	[StockInQuantity] [int] NULL,
	[StockInDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[StockInID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StocksOut]    Script Date: 7/4/2019 3:40:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StocksOut](
	[StockOutID] [int] IDENTITY(1,1) NOT NULL,
	[ItemID] [int] NULL,
	[StockOutQuantity] [int] NULL,
	[StockOutType] [varchar](20) NULL,
	[StockOutDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[StockOutID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (1, N'naim')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (2, N's')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (3, N'1')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (4, N'asdasd')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (5, N'ssss')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (6, N'asdad')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (7, N'1111')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (8, N'asdasd')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (9, N'asdasd')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (10, N'121211')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (11, N'sdsdsd')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (12, N'sdsdsd')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (13, N'2222')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (14, N'22')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (15, N'ssss')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (16, N'naim')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (17, N'naim')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (18, N'abcd')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (19, N's')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (20, N's')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (21, N'aaa')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (22, N'ccc')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (23, N'sss')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (24, N'aaa')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (25, N'z')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (26, N'x')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (27, N'z')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (28, N'zzz')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (29, N's')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (30, N'c')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (31, N'v')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (32, N'asas')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (33, N'v')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (34, N'c')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (35, N's')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (36, N's')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (37, N'aaa')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (38, N'ss')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (39, N'zzzzz')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (40, N'cccc')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (41, N's')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (42, N's')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (43, N's')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (44, N'c')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (45, N'a')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (46, N'naimul islam')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (47, N'naimul islam')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (48, N'bappy')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (49, N'naim')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (50, N'sp')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (51, N'ab')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Companies] ON 

INSERT [dbo].[Companies] ([CompanyID], [CompanyName]) VALUES (1, N'nike c')
INSERT [dbo].[Companies] ([CompanyID], [CompanyName]) VALUES (2, N'naim')
SET IDENTITY_INSERT [dbo].[Companies] OFF
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([ItemID], [ItemName], [CompanyID], [CategoryID], [ItemReorderLevel]) VALUES (2, N'a', 1, 1, 1)
INSERT [dbo].[Items] ([ItemID], [ItemName], [CompanyID], [CategoryID], [ItemReorderLevel]) VALUES (3, N'b', 2, 2, 33)
INSERT [dbo].[Items] ([ItemID], [ItemName], [CompanyID], [CategoryID], [ItemReorderLevel]) VALUES (4, N'a', 1, 1, 3)
INSERT [dbo].[Items] ([ItemID], [ItemName], [CompanyID], [CategoryID], [ItemReorderLevel]) VALUES (5, N'a', 1, 1, 3)
INSERT [dbo].[Items] ([ItemID], [ItemName], [CompanyID], [CategoryID], [ItemReorderLevel]) VALUES (6, N'd', 1, 1, 5)
INSERT [dbo].[Items] ([ItemID], [ItemName], [CompanyID], [CategoryID], [ItemReorderLevel]) VALUES (7, N'd', 1, 1, 5)
INSERT [dbo].[Items] ([ItemID], [ItemName], [CompanyID], [CategoryID], [ItemReorderLevel]) VALUES (9, N'sd', 1, 2, 1)
SET IDENTITY_INSERT [dbo].[Items] OFF
ALTER TABLE [dbo].[Items]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD FOREIGN KEY([CompanyID])
REFERENCES [dbo].[Companies] ([CompanyID])
GO
ALTER TABLE [dbo].[StocksIn]  WITH CHECK ADD FOREIGN KEY([ItemID])
REFERENCES [dbo].[Items] ([ItemID])
GO
ALTER TABLE [dbo].[StocksOut]  WITH CHECK ADD FOREIGN KEY([ItemID])
REFERENCES [dbo].[Items] ([ItemID])
GO
