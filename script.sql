USE [projectBugaboo]
GO
/****** Object:  Table [dbo].[BuyDetails]    Script Date: 29/01/2025 12:27:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BuyDetails](
	[BuyDetailsId] [int] IDENTITY(100,1) NOT NULL,
	[buyId] [int] NULL,
	[productId] [int] NULL,
	[amount] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[BuyDetailsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Buys]    Script Date: 29/01/2025 12:27:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Buys](
	[buyId] [int] IDENTITY(1,1) NOT NULL,
	[customerId] [int] NULL,
	[buyDate] [date] NULL,
	[payment] [int] NULL,
	[remark] [varchar](50) NULL,
 CONSTRAINT [PK__Buys__BBB36FEC55A4A248] PRIMARY KEY CLUSTERED 
(
	[buyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 29/01/2025 12:27:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[categoryId] [int] IDENTITY(0,1) NOT NULL,
	[nameCategory] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[categoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 29/01/2025 12:27:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[customerId] [int] IDENTITY(100,1) NOT NULL,
	[nameCustomer] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[dateBirth] [date] NULL,
 CONSTRAINT [PK__Customer__B611CB7D56DE711F] PRIMARY KEY CLUSTERED 
(
	[customerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Models]    Script Date: 29/01/2025 12:27:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Models](
	[modelId] [int] IDENTITY(0,1) NOT NULL,
	[nameModel] [text] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[modelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 29/01/2025 12:27:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[productId] [int] IDENTITY(100,1) NOT NULL,
	[nameProduct] [text] NOT NULL,
	[modelId] [int] NULL,
	[categoryId] [int] NULL,
	[descriptions] [text] NULL,
	[price] [int] NULL,
	[picture] [varchar](50) NULL,
	[quantity] [int] NULL,
	[lastUpdate] [date] NULL,
 CONSTRAINT [PK__Products__2D10D16AD67F707A] PRIMARY KEY CLUSTERED 
(
	[productId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BuyDetails] ON 
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (100, 93, 112, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (101, NULL, 112, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (102, NULL, 111, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (103, NULL, 109, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (104, NULL, 109, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (105, 136, 110, 9)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (106, 137, 111, 2)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (107, 137, 112, 5)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (108, 138, 109, 4)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (109, 139, 112, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (110, 140, 112, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (111, 141, 112, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (112, 142, 112, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (113, 143, 108, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (114, 144, 108, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (115, 145, 108, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (116, 146, 108, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (117, 147, 108, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (118, 148, 108, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (119, 149, 111, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (120, 150, 112, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (121, 151, 112, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (122, 152, 112, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (123, 153, 108, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (124, 154, 108, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (125, 155, 108, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (126, 156, 108, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (127, 157, 108, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (128, 158, 108, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (129, 159, 108, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (130, 160, 108, 2)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (131, 161, 108, 4)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (132, 162, 108, 4)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (133, 162, 111, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (134, 163, 108, 4)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (135, 163, 111, 2)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (136, 164, 111, 2)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (137, 165, 108, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (138, 166, 108, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (139, 167, 108, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (140, 168, 108, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (141, 169, 108, 1)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (142, 170, 108, 2)
GO
INSERT [dbo].[BuyDetails] ([BuyDetailsId], [buyId], [productId], [amount]) VALUES (143, 171, 108, 1)
GO
SET IDENTITY_INSERT [dbo].[BuyDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Buys] ON 
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (86, NULL, CAST(N'2025-01-26' AS Date), NULL, N'remark')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (87, NULL, CAST(N'2025-01-26' AS Date), NULL, N'תודה רבה!!')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (88, NULL, CAST(N'2025-01-26' AS Date), NULL, N'remarkללללללללללללללללללל')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (89, NULL, CAST(N'2025-01-26' AS Date), NULL, N'ccccccccccccccccccccccc')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (90, NULL, CAST(N'2025-01-26' AS Date), 6290, N'ccccccccccccccccccccccc')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (91, NULL, CAST(N'2025-01-26' AS Date), 656, N'ccccccccccccccccccccccc')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (92, NULL, CAST(N'2025-01-26' AS Date), 400, N'ccccccccccccccccccccccc')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (93, NULL, CAST(N'2025-01-26' AS Date), 420, N'ccccccccccccccccccccccc')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (94, NULL, CAST(N'2025-01-26' AS Date), 5060, N'ccccccccccccccccccccccc')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (95, NULL, CAST(N'2025-01-26' AS Date), 5032, N'remark')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (96, NULL, CAST(N'2025-01-26' AS Date), 13960, N'remark')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (97, NULL, CAST(N'2025-01-26' AS Date), 1112, N'remark')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (98, NULL, CAST(N'2025-01-26' AS Date), 14744, N'remark')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (99, NULL, CAST(N'2025-01-26' AS Date), 1532, N'remark')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (100, NULL, CAST(N'2025-01-26' AS Date), 1112, N'remark')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (101, NULL, CAST(N'2025-01-26' AS Date), 18430, N'remark')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (102, NULL, CAST(N'2025-01-26' AS Date), 5850, N'remark')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (103, NULL, NULL, 0, N'עעעעע')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (104, 106, NULL, 0, N'WOW')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (105, 106, NULL, 0, N'WOW')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (106, 134, NULL, 0, N'wowwowwow')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (107, NULL, CAST(N'2025-01-27' AS Date), 3336, N'remark')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (108, NULL, CAST(N'2025-01-27' AS Date), 3336, N'remark')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (109, NULL, CAST(N'2025-01-27' AS Date), 3336, N'remarrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrk')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (110, NULL, CAST(N'2025-01-27' AS Date), 25160, N'remark55555555555555555555')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (112, NULL, CAST(N'2025-01-27' AS Date), 5452, N'qqqqqqqqqq')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (113, NULL, CAST(N'2025-01-27' AS Date), 12232, N'ha')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (114, NULL, CAST(N'2025-01-27' AS Date), 8896, N'fyguh')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (115, NULL, CAST(N'2025-01-27' AS Date), 8896, N'fyguh')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (116, NULL, CAST(N'2025-01-27' AS Date), 14456, N'ה'' תעזור')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (117, NULL, CAST(N'2025-01-27' AS Date), 4200, N'ה תציל אותנו')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (118, NULL, CAST(N'2025-01-27' AS Date), 11120, N'wrrrrrrt')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (119, NULL, CAST(N'2025-01-27' AS Date), 17792, N'wwwwwwwww')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (120, NULL, CAST(N'2025-01-27' AS Date), 1112, N'remarkrfehghadjlksa')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (126, NULL, CAST(N'2025-01-27' AS Date), 1112, N'remarkm,')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (127, NULL, CAST(N'2025-01-28' AS Date), 420, N'yyyyy')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (128, NULL, CAST(N'2025-01-28' AS Date), 9360, N'trtrtr')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (129, NULL, CAST(N'2025-01-28' AS Date), 46800, N'eeeee')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (130, NULL, CAST(N'2025-01-28' AS Date), 4200, N'check')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (131, NULL, CAST(N'2025-01-28' AS Date), 35224, N'remarkedrtfyguhkjlk,')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (132, NULL, CAST(N'2025-01-28' AS Date), 41760, N'תמר')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (133, NULL, CAST(N'2025-01-28' AS Date), 41760, N'תמר')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (134, NULL, CAST(N'2025-01-28' AS Date), 41760, N'תמר')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (135, NULL, CAST(N'2025-01-28' AS Date), 41760, N'תמר')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (136, NULL, CAST(N'2025-01-28' AS Date), 41760, N'תמר')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (137, NULL, CAST(N'2025-01-28' AS Date), 4324, N'זה עובד?')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (138, NULL, CAST(N'2025-01-28' AS Date), 18720, N'remark3544tr')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (139, NULL, CAST(N'2025-01-28' AS Date), 420, N'remark')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (140, NULL, CAST(N'2025-01-28' AS Date), 525, N'remark''3')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (141, NULL, CAST(N'2025-01-28' AS Date), 525, N'remarksrtfh')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (142, NULL, CAST(N'2025-01-28' AS Date), 525, N'remark12')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (143, NULL, CAST(N'2025-01-28' AS Date), 5032, N'remark')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (144, NULL, CAST(N'2025-01-28' AS Date), 6290, N'remark')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (145, NULL, CAST(N'2025-01-28' AS Date), 6290, N'remark')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (146, NULL, CAST(N'2025-01-28' AS Date), 6290, N'remark')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (147, NULL, CAST(N'2025-01-28' AS Date), 6290, N'remark')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (148, NULL, CAST(N'2025-01-28' AS Date), 6290, N'remark')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (149, NULL, CAST(N'2025-01-28' AS Date), 1112, N'remark\\')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (150, NULL, CAST(N'2025-01-28' AS Date), 420, N'remarkbb')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (151, NULL, CAST(N'2025-01-28' AS Date), 420, N'remarknn')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (152, NULL, CAST(N'2025-01-28' AS Date), 420, N'remark')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (153, NULL, CAST(N'2025-01-28' AS Date), 5032, N'remark4eer')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (154, NULL, CAST(N'2025-01-28' AS Date), 5032, N'remark4eer')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (155, NULL, CAST(N'2025-01-28' AS Date), 5032, N'remark')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (156, NULL, CAST(N'2025-01-28' AS Date), 6290, N'remark/ר')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (157, NULL, CAST(N'2025-01-28' AS Date), 6290, N'remark/ר')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (158, NULL, CAST(N'2025-01-28' AS Date), 6290, N'remark/ר')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (159, NULL, CAST(N'2025-01-28' AS Date), 6290, N'remark')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (160, NULL, CAST(N'2025-01-28' AS Date), 10064, N'remark8977')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (161, NULL, CAST(N'2025-01-28' AS Date), 20128, N'remark')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (162, NULL, CAST(N'2025-01-28' AS Date), 21240, N'remark08979')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (163, NULL, CAST(N'2025-01-28' AS Date), 22352, N'remark0')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (164, NULL, CAST(N'2025-01-28' AS Date), 2224, N'12')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (165, NULL, CAST(N'2025-01-29' AS Date), 5032, N'קרא')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (166, NULL, CAST(N'2025-01-29' AS Date), 5032, N'קרא')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (167, NULL, CAST(N'2025-01-29' AS Date), 5032, N'stdyfg')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (168, NULL, CAST(N'2025-01-29' AS Date), 5032, N'stdyfg')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (169, NULL, CAST(N'2025-01-29' AS Date), 5032, N'')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (170, NULL, CAST(N'2025-01-29' AS Date), 10064, N'אוטאוע')
GO
INSERT [dbo].[Buys] ([buyId], [customerId], [buyDate], [payment], [remark]) VALUES (171, NULL, CAST(N'2025-01-29' AS Date), 5032, N'')
GO
SET IDENTITY_INSERT [dbo].[Buys] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 
GO
INSERT [dbo].[Categories] ([categoryId], [nameCategory]) VALUES (0, N'עגלות')
GO
INSERT [dbo].[Categories] ([categoryId], [nameCategory]) VALUES (1, N'אביזרים')
GO
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 
GO
INSERT [dbo].[Customers] ([customerId], [nameCustomer], [phone], [email], [dateBirth]) VALUES (106, N'y', N'y', N'y', CAST(N'2025-01-14' AS Date))
GO
INSERT [dbo].[Customers] ([customerId], [nameCustomer], [phone], [email], [dateBirth]) VALUES (107, N'קראר', N'גכ', N'''קר', CAST(N'2025-01-14' AS Date))
GO
INSERT [dbo].[Customers] ([customerId], [nameCustomer], [phone], [email], [dateBirth]) VALUES (108, N'יתיחךלץ', N'0500000000', N'דכססנס@ךכילך', CAST(N'2025-01-15' AS Date))
GO
INSERT [dbo].[Customers] ([customerId], [nameCustomer], [phone], [email], [dateBirth]) VALUES (109, N'gfghhcvdsh', N'054-3673762', N'e025000168@gmail.com', CAST(N'2025-01-15' AS Date))
GO
INSERT [dbo].[Customers] ([customerId], [nameCustomer], [phone], [email], [dateBirth]) VALUES (110, N'hfjk', N'054-3673762', N'rivki229@gmail.com', CAST(N'2025-01-15' AS Date))
GO
INSERT [dbo].[Customers] ([customerId], [nameCustomer], [phone], [email], [dateBirth]) VALUES (111, N'tamar', N'0583229455', N'tamar455@gmail.com', CAST(N'2025-01-15' AS Date))
GO
INSERT [dbo].[Customers] ([customerId], [nameCustomer], [phone], [email], [dateBirth]) VALUES (123, N'chaya', N'0583205358', N'c0583205358@gmail.com', CAST(N'2025-01-15' AS Date))
GO
INSERT [dbo].[Customers] ([customerId], [nameCustomer], [phone], [email], [dateBirth]) VALUES (124, N'w', N'0583205358', N'elyashiv168@gmail.com', CAST(N'2025-01-15' AS Date))
GO
INSERT [dbo].[Customers] ([customerId], [nameCustomer], [phone], [email], [dateBirth]) VALUES (128, N'cfgg', N'445565686', N'098765', CAST(N'2025-01-22' AS Date))
GO
INSERT [dbo].[Customers] ([customerId], [nameCustomer], [phone], [email], [dateBirth]) VALUES (129, N'יחךבנחלכסח', N'0583229455', N'ew@gmail.com', CAST(N'2025-01-26' AS Date))
GO
INSERT [dbo].[Customers] ([customerId], [nameCustomer], [phone], [email], [dateBirth]) VALUES (132, N'תמר', N'0556765229', N'tr@gmail.com', CAST(N'2025-01-26' AS Date))
GO
INSERT [dbo].[Customers] ([customerId], [nameCustomer], [phone], [email], [dateBirth]) VALUES (134, N'יחךבנחלכסח', N'0583205358', N'e344@gmail.com', CAST(N'2025-01-26' AS Date))
GO
INSERT [dbo].[Customers] ([customerId], [nameCustomer], [phone], [email], [dateBirth]) VALUES (135, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Customers] ([customerId], [nameCustomer], [phone], [email], [dateBirth]) VALUES (138, N'צהגסל', N'0500055555', N'reyq12@gmail.com', CAST(N'2025-01-26' AS Date))
GO
INSERT [dbo].[Customers] ([customerId], [nameCustomer], [phone], [email], [dateBirth]) VALUES (140, N'רנגלחסכה', N'0556765229', N'fchvjm@gmail.com', CAST(N'2025-01-26' AS Date))
GO
INSERT [dbo].[Customers] ([customerId], [nameCustomer], [phone], [email], [dateBirth]) VALUES (145, N'צהגסל', N'0556765229', N'wqe@gmail.com', CAST(N'2025-01-15' AS Date))
GO
INSERT [dbo].[Customers] ([customerId], [nameCustomer], [phone], [email], [dateBirth]) VALUES (149, N'רנגלחסכה', N'0500055555', N'3קר@gmail.com', CAST(N'2025-01-15' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Models] ON 
GO
INSERT [dbo].[Models] ([modelId], [nameModel]) VALUES (0, N'BugabooFox5')
GO
INSERT [dbo].[Models] ([modelId], [nameModel]) VALUES (1, N'BugabooDragonfly')
GO
INSERT [dbo].[Models] ([modelId], [nameModel]) VALUES (2, N'BugabooDonkey 5 Mono')
GO
INSERT [dbo].[Models] ([modelId], [nameModel]) VALUES (3, N'BugabooButterfly')
GO
INSERT [dbo].[Models] ([modelId], [nameModel]) VALUES (4, N'BugabooDragonflySeat')
GO
INSERT [dbo].[Models] ([modelId], [nameModel]) VALUES (5, N'BugabooDonkey 5 Duo')
GO
INSERT [dbo].[Models] ([modelId], [nameModel]) VALUES (6, N'BugabooDonkey 5 Twin')
GO
INSERT [dbo].[Models] ([modelId], [nameModel]) VALUES (7, N'Eccessories')
GO
SET IDENTITY_INSERT [dbo].[Models] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
GO
INSERT [dbo].[Products] ([productId], [nameProduct], [modelId], [categoryId], [descriptions], [price], [picture], [quantity], [lastUpdate]) VALUES (108, N'Bugaboo Fox 5', 0, 0, N'הנה זה קורה – הכירו בשמחה את בוגבו פוקס 5 – הדרך החדשנית והטובה ביותר לשאת את התינוק שלכם. בוגבו פוקס 5 היא עגלה פורצת דרך המתקפלת בקלות בשנייה אחת וביד אחת עם העריסה ושתיקח אתכם רחוק מאי פעם בשיא הנוחות והבטיחות. בוגבו פוקס 5 היא עגלת השטח האולטימטיבית לנסיעה הטובה ביותר אי פעם, המצטיינת בעיצוב ארגונומי משובח, בדים סופר איכותיים ועמידים, ועיצוב עכשווי, סוחף, קלאסי ונצחי', 6290, N'/Fox5.png', 100, CAST(N'2025-01-01' AS Date))
GO
INSERT [dbo].[Products] ([productId], [nameProduct], [modelId], [categoryId], [descriptions], [price], [picture], [quantity], [lastUpdate]) VALUES (109, N'Bugaboo Dragonfly', 1, 0, N'היא כבר כאן – בוגבו דרגונפליי (Bugaboo Dragonfly) – עגלת התינוק הקומפקטית של המחר, המגיעה כעת חדשנית ומלוטשת מתמיד עם מנגנון בוגבו FOLD   המהפכני, המאפשר קיפול ביד אחת, בשנייה אחת, כיחידה אחת עם העריסה/ טיולון', 5850, N'/Dargon.jpg', 100, CAST(N'2025-01-01' AS Date))
GO
INSERT [dbo].[Products] ([productId], [nameProduct], [modelId], [categoryId], [descriptions], [price], [picture], [quantity], [lastUpdate]) VALUES (110, N'Bugaboo Donkey 5 Mono', 2, 0, N'הכירו את עגלת בוגבו דונקי 5 שכובשת את המדרכות, השבילים וסמטאות העיר, כמו גם רבבות הורים ותינוקות שמחים מכל רחבי העולם. בוגבו דונקי 5 מתאימה עצמה בדיוק למה שהמשפחה צריכה, וכמו כל עגלות בוגבו, מספקת נסיעה חלומית וחלקה, עם שפע שיפורים חדשניים, ביצועים יוצאי דופן וסטייל מנצח.', 5800, N'/doo.png', 0, CAST(N'2025-01-01' AS Date))
GO
INSERT [dbo].[Products] ([productId], [nameProduct], [modelId], [categoryId], [descriptions], [price], [picture], [quantity], [lastUpdate]) VALUES (111, N'סלקל בוגבו טרטל AIR', 7, 1, N'בטיחותי. זהו מושב בטיחות המתאים לכל דגמי עגלות בוגבו, שיהפוך את החיים לקלים, פשוטים ובטוחים יותר גם בנסיעה ברכב, ובהתאמה מושלמת לסטייל הנצחי של בוגבו.', 1390, N'/sal.png', 100, CAST(N'2025-01-01' AS Date))
GO
INSERT [dbo].[Products] ([productId], [nameProduct], [modelId], [categoryId], [descriptions], [price], [picture], [quantity], [lastUpdate]) VALUES (112, N'תיק החתלה בוגבו החדש', 7, 1, N'תיק החתלה בוגבו החדש הוא האביזר המושלם לכל הורה שרוצה לטייל בחוץ עם הבייבי ולקחת כל מה שצריך בצורה חכמה ונוחה ביותר ועם סטייל כובש ועכשווי', 525, N'/bag.jpg', 0, CAST(N'2025-01-01' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_Email]    Script Date: 29/01/2025 12:27:21 ******/
ALTER TABLE [dbo].[Customers] ADD  CONSTRAINT [UQ_Email] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BuyDetails]  WITH CHECK ADD  CONSTRAINT [FK__BuyDetail__buyId__440B1D61] FOREIGN KEY([buyId])
REFERENCES [dbo].[Buys] ([buyId])
GO
ALTER TABLE [dbo].[BuyDetails] CHECK CONSTRAINT [FK__BuyDetail__buyId__440B1D61]
GO
ALTER TABLE [dbo].[BuyDetails]  WITH CHECK ADD  CONSTRAINT [FK__BuyDetail__produ__44FF419A] FOREIGN KEY([productId])
REFERENCES [dbo].[Products] ([productId])
GO
ALTER TABLE [dbo].[BuyDetails] CHECK CONSTRAINT [FK__BuyDetail__produ__44FF419A]
GO
ALTER TABLE [dbo].[Buys]  WITH CHECK ADD  CONSTRAINT [FK__Buys__customerId__412EB0B6] FOREIGN KEY([customerId])
REFERENCES [dbo].[Customers] ([customerId])
GO
ALTER TABLE [dbo].[Buys] CHECK CONSTRAINT [FK__Buys__customerId__412EB0B6]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK__Products__catego__3C69FB99] FOREIGN KEY([categoryId])
REFERENCES [dbo].[Categories] ([categoryId])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK__Products__catego__3C69FB99]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK__Products__modelI__3B75D760] FOREIGN KEY([modelId])
REFERENCES [dbo].[Models] ([modelId])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK__Products__modelI__3B75D760]
GO
