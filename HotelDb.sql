USE [master]
GO
/****** Object:  Database [HotelDB]    Script Date: 14.07.2019 19:37:28 ******/
CREATE DATABASE [HotelDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HotelDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\HotelDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HotelDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\HotelDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [HotelDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HotelDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HotelDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HotelDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HotelDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HotelDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HotelDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [HotelDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HotelDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HotelDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HotelDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HotelDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HotelDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HotelDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HotelDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HotelDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HotelDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HotelDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HotelDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HotelDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HotelDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HotelDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HotelDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HotelDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HotelDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HotelDB] SET  MULTI_USER 
GO
ALTER DATABASE [HotelDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HotelDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HotelDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HotelDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [HotelDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HotelDB] SET QUERY_STORE = OFF
GO
USE [HotelDB]
GO
/****** Object:  Table [dbo].[Hotel]    Script Date: 14.07.2019 19:37:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hotel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](200) NULL,
	[Description] [varchar](200) NULL,
	[MainImage] [varchar](200) NULL,
 CONSTRAINT [PK_Hotel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HotelAddress]    Script Date: 14.07.2019 19:37:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HotelAddress](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HotelId] [int] NULL,
	[AddressText] [varchar](200) NULL,
	[CityId] [int] NULL,
	[PostalCode] [varchar](5) NULL,
	[LocationLatitude] [varchar](100) NULL,
	[LocationLongtitude] [varchar](100) NULL,
 CONSTRAINT [PK_HotelAddress] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HotelComment]    Script Date: 14.07.2019 19:37:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HotelComment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HotelId] [int] NULL,
	[UserId] [int] NULL,
	[Comment] [varchar](1000) NULL,
	[Score] [int] NULL,
 CONSTRAINT [PK_HotelComment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HotelContact]    Script Date: 14.07.2019 19:37:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HotelContact](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HotelId] [int] NOT NULL,
	[ContactValue] [varchar](100) NULL,
	[HotelContactTypeId] [int] NOT NULL,
 CONSTRAINT [PK_HotelContact] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HotelContactType]    Script Date: 14.07.2019 19:37:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HotelContactType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_HotelContactType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HotelImage]    Script Date: 14.07.2019 19:37:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HotelImage](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HotelId] [int] NULL,
	[ImagePath] [varchar](100) NULL,
	[Description] [varchar](200) NULL,
 CONSTRAINT [PK_HotelImage] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HotelRoom]    Script Date: 14.07.2019 19:37:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HotelRoom](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HotelId] [int] NULL,
	[RoomTypeId] [int] NULL,
	[RoomSummary] [varchar](100) NULL,
	[RoomDetail] [varchar](max) NULL,
 CONSTRAINT [PK_HotelRoom] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HotelRoomPrice]    Script Date: 14.07.2019 19:37:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HotelRoomPrice](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HotelRoomId] [int] NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[Price] [money] NULL,
	[IsAvailable] [bit] NULL,
 CONSTRAINT [PK_HotelRoomPrice] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HotelScore]    Script Date: 14.07.2019 19:37:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HotelScore](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HotelId] [int] NULL,
	[HotelScoreTypeId] [int] NULL,
	[ScoreValue] [int] NULL,
 CONSTRAINT [PK_HotelScore] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomType]    Script Date: 14.07.2019 19:37:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [varchar](50) NULL,
 CONSTRAINT [PK_RoomType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 14.07.2019 19:37:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NULL,
	[EmailAddress] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Hotel] ON 

INSERT [dbo].[Hotel] ([Id], [Name], [Description], [MainImage]) VALUES (1, N'Ladonia Hotels Adakule', N'Kuşadası merkeze 500 mt uzaklıkta', N'1.jpg')
INSERT [dbo].[Hotel] ([Id], [Name], [Description], [MainImage]) VALUES (2, N'Palmin Hotel', N'Denize sıfır', N'2.jpg')
INSERT [dbo].[Hotel] ([Id], [Name], [Description], [MainImage]) VALUES (3, N'The Grand Blue Sky International', N'Kuşadası merkeze 2 km uzaklıkta', N'3.jpg')
INSERT [dbo].[Hotel] ([Id], [Name], [Description], [MainImage]) VALUES (4, N'Hotel Corner Boutique', N'Didim Altınkum denize 200 metre uzaklıkta', N'4.jpg')
INSERT [dbo].[Hotel] ([Id], [Name], [Description], [MainImage]) VALUES (5, N'The Roxy Luxury Spa', N'Tatil köyü', N'5.jpg')
SET IDENTITY_INSERT [dbo].[Hotel] OFF
SET IDENTITY_INSERT [dbo].[HotelAddress] ON 

INSERT [dbo].[HotelAddress] ([Id], [HotelId], [AddressText], [CityId], [PostalCode], [LocationLatitude], [LocationLongtitude]) VALUES (1, 1, N'Ilica mevkii, 9440, Kuşadası, Türkiye
', 9, N'09440', N'42,2451', N'41,5547841')
INSERT [dbo].[HotelAddress] ([Id], [HotelId], [AddressText], [CityId], [PostalCode], [LocationLatitude], [LocationLongtitude]) VALUES (2, 2, N'Güzelçamlı Mahallesi Milli Park Caddesi No : 53, 09460, Kuşadası, Türkiye
', 9, N'09460', N'42,2451', N'41,5597841')
SET IDENTITY_INSERT [dbo].[HotelAddress] OFF
SET IDENTITY_INSERT [dbo].[HotelComment] ON 

INSERT [dbo].[HotelComment] ([Id], [HotelId], [UserId], [Comment], [Score]) VALUES (1, 1, 1, N'Yemekleri iyiydi, çalışanları ilgiliydi ama oda temizliği biraz daha iyi olabilirdi', 4)
INSERT [dbo].[HotelComment] ([Id], [HotelId], [UserId], [Comment], [Score]) VALUES (2, 1, 2, N'Herşey çok iyiydi, çok memnun kaldık genel olarak hizmetlerinden', 5)
INSERT [dbo].[HotelComment] ([Id], [HotelId], [UserId], [Comment], [Score]) VALUES (3, 2, 1, N'Konumu iyi değildi, denize ve şehir merkezine biraz uzak. Oda temizliği ve konforu iyiydi ama yemekleri biraz vasattı', 3)
INSERT [dbo].[HotelComment] ([Id], [HotelId], [UserId], [Comment], [Score]) VALUES (4, 1, 3, N'Otel efsaneydi gerçekten özellikle açık büfesindeki çeşitlilik olarak beni benden aldı', 5)
INSERT [dbo].[HotelComment] ([Id], [HotelId], [UserId], [Comment], [Score]) VALUES (5, 1, 3, N'Denememe', 4)
INSERT [dbo].[HotelComment] ([Id], [HotelId], [UserId], [Comment], [Score]) VALUES (6, 1, 3, N'Otyhrfehgf', 1)
INSERT [dbo].[HotelComment] ([Id], [HotelId], [UserId], [Comment], [Score]) VALUES (7, 2, 3, N'cxzxzcxczxzc', 2)
INSERT [dbo].[HotelComment] ([Id], [HotelId], [UserId], [Comment], [Score]) VALUES (8, 2, 3, N'tergerrerere', 2)
INSERT [dbo].[HotelComment] ([Id], [HotelId], [UserId], [Comment], [Score]) VALUES (9, 3, 3, N'Muhteşem Efsane', 5)
INSERT [dbo].[HotelComment] ([Id], [HotelId], [UserId], [Comment], [Score]) VALUES (10, 2, 3, N'gfddfdgfhdgf', 3)
INSERT [dbo].[HotelComment] ([Id], [HotelId], [UserId], [Comment], [Score]) VALUES (11, 1, 2, N'DENmneömenm', 5)
INSERT [dbo].[HotelComment] ([Id], [HotelId], [UserId], [Comment], [Score]) VALUES (12, 3, 3, N'wqwqeqweweq', 6)
INSERT [dbo].[HotelComment] ([Id], [HotelId], [UserId], [Comment], [Score]) VALUES (13, 1, 7, N'eewweewew', 23)
SET IDENTITY_INSERT [dbo].[HotelComment] OFF
SET IDENTITY_INSERT [dbo].[HotelContact] ON 

INSERT [dbo].[HotelContact] ([Id], [HotelId], [ContactValue], [HotelContactTypeId]) VALUES (2, 1, N'02565550011', 1)
INSERT [dbo].[HotelContact] ([Id], [HotelId], [ContactValue], [HotelContactTypeId]) VALUES (3, 1, N'02565550012', 2)
INSERT [dbo].[HotelContact] ([Id], [HotelId], [ContactValue], [HotelContactTypeId]) VALUES (4, 1, N'ladonia.hotel@gmail.com', 4)
SET IDENTITY_INSERT [dbo].[HotelContact] OFF
SET IDENTITY_INSERT [dbo].[HotelContactType] ON 

INSERT [dbo].[HotelContactType] ([Id], [Name]) VALUES (1, N'Telefon')
INSERT [dbo].[HotelContactType] ([Id], [Name]) VALUES (2, N'Fax')
INSERT [dbo].[HotelContactType] ([Id], [Name]) VALUES (3, N'Rezervasyon')
INSERT [dbo].[HotelContactType] ([Id], [Name]) VALUES (4, N'E-posta')
SET IDENTITY_INSERT [dbo].[HotelContactType] OFF
SET IDENTITY_INSERT [dbo].[HotelImage] ON 

INSERT [dbo].[HotelImage] ([Id], [HotelId], [ImagePath], [Description]) VALUES (1, 1, N'1.jpg', N'dfsdsfdfs')
INSERT [dbo].[HotelImage] ([Id], [HotelId], [ImagePath], [Description]) VALUES (2, 1, N'2.jpg', N'fdsfdsffdsfsdf')
INSERT [dbo].[HotelImage] ([Id], [HotelId], [ImagePath], [Description]) VALUES (3, 1, N'3.jpg', N'dsfsdfsdfsdf')
INSERT [dbo].[HotelImage] ([Id], [HotelId], [ImagePath], [Description]) VALUES (4, 1, N'4.jpg', N'sdfsdfsdfsdfsdfsd')
SET IDENTITY_INSERT [dbo].[HotelImage] OFF
SET IDENTITY_INSERT [dbo].[HotelRoom] ON 

INSERT [dbo].[HotelRoom] ([Id], [HotelId], [RoomTypeId], [RoomSummary], [RoomDetail]) VALUES (1, 1, 1, N'2 tek kişilik yatak 
', N'Yatak nevresimleri ve havlular tesis tarafından sağlanmaktadır. Odada duş, klima ve minibar bulunmaktadır.')
INSERT [dbo].[HotelRoom] ([Id], [HotelId], [RoomTypeId], [RoomSummary], [RoomDetail]) VALUES (2, 1, 2, N'1 geniş çift kişilik yatak 
', N'Bu modern odada klima, uydu TV ve minibar vardır. Ayrıca çay/kahve yapma imkanı ve en-suite banyo mevcuttur. ')
INSERT [dbo].[HotelRoom] ([Id], [HotelId], [RoomTypeId], [RoomSummary], [RoomDetail]) VALUES (3, 2, 2, N'denememenem', N'detay yok deneme')
SET IDENTITY_INSERT [dbo].[HotelRoom] OFF
SET IDENTITY_INSERT [dbo].[HotelRoomPrice] ON 

INSERT [dbo].[HotelRoomPrice] ([Id], [HotelRoomId], [StartDate], [EndDate], [Price], [IsAvailable]) VALUES (1, 1, CAST(N'2019-07-01T00:00:00.000' AS DateTime), CAST(N'2019-07-20T00:00:00.000' AS DateTime), 350.0000, 1)
INSERT [dbo].[HotelRoomPrice] ([Id], [HotelRoomId], [StartDate], [EndDate], [Price], [IsAvailable]) VALUES (2, 1, CAST(N'2019-07-21T00:00:00.000' AS DateTime), CAST(N'2019-08-15T00:00:00.000' AS DateTime), 390.0000, 1)
INSERT [dbo].[HotelRoomPrice] ([Id], [HotelRoomId], [StartDate], [EndDate], [Price], [IsAvailable]) VALUES (3, 1, NULL, NULL, 270.0000, 1)
INSERT [dbo].[HotelRoomPrice] ([Id], [HotelRoomId], [StartDate], [EndDate], [Price], [IsAvailable]) VALUES (4, 2, CAST(N'2019-07-01T00:00:00.000' AS DateTime), CAST(N'2019-07-20T00:00:00.000' AS DateTime), 450.0000, 0)
INSERT [dbo].[HotelRoomPrice] ([Id], [HotelRoomId], [StartDate], [EndDate], [Price], [IsAvailable]) VALUES (5, 2, CAST(N'2019-07-21T00:00:00.000' AS DateTime), CAST(N'2019-08-15T00:00:00.000' AS DateTime), 520.0000, 1)
INSERT [dbo].[HotelRoomPrice] ([Id], [HotelRoomId], [StartDate], [EndDate], [Price], [IsAvailable]) VALUES (6, 2, NULL, NULL, 370.0000, 1)
INSERT [dbo].[HotelRoomPrice] ([Id], [HotelRoomId], [StartDate], [EndDate], [Price], [IsAvailable]) VALUES (7, 1, CAST(N'2019-07-13T00:00:00.000' AS DateTime), CAST(N'2019-08-10T00:00:00.000' AS DateTime), 670.0000, 1)
SET IDENTITY_INSERT [dbo].[HotelRoomPrice] OFF
SET IDENTITY_INSERT [dbo].[HotelScore] ON 

INSERT [dbo].[HotelScore] ([Id], [HotelId], [HotelScoreTypeId], [ScoreValue]) VALUES (1, 1, 1, 5)
INSERT [dbo].[HotelScore] ([Id], [HotelId], [HotelScoreTypeId], [ScoreValue]) VALUES (2, 2, 1, 4)
INSERT [dbo].[HotelScore] ([Id], [HotelId], [HotelScoreTypeId], [ScoreValue]) VALUES (3, 3, 1, 5)
INSERT [dbo].[HotelScore] ([Id], [HotelId], [HotelScoreTypeId], [ScoreValue]) VALUES (4, 4, 1, 3)
SET IDENTITY_INSERT [dbo].[HotelScore] OFF
SET IDENTITY_INSERT [dbo].[RoomType] ON 

INSERT [dbo].[RoomType] ([Id], [TypeName]) VALUES (1, N'Standart Oda')
INSERT [dbo].[RoomType] ([Id], [TypeName]) VALUES (2, N'Suit Oda')
INSERT [dbo].[RoomType] ([Id], [TypeName]) VALUES (3, N'Aile Odası')
SET IDENTITY_INSERT [dbo].[RoomType] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [UserName], [EmailAddress], [Password]) VALUES (1, N'ugur', N'umutluoglu@gmail.com', N'123')
INSERT [dbo].[User] ([Id], [UserName], [EmailAddress], [Password]) VALUES (2, N'ahmet', N'ahmet@gmail.com', N'234')
INSERT [dbo].[User] ([Id], [UserName], [EmailAddress], [Password]) VALUES (3, N'Emrah', N'inamemrah@gmail.com', N'123123')
INSERT [dbo].[User] ([Id], [UserName], [EmailAddress], [Password]) VALUES (5, N'Deneme12', N'denemne@mail.com', N'123123')
INSERT [dbo].[User] ([Id], [UserName], [EmailAddress], [Password]) VALUES (6, N'asasasdsa', N'adsasasdas@mail.com', N'56465416')
INSERT [dbo].[User] ([Id], [UserName], [EmailAddress], [Password]) VALUES (7, N'Denem', N'deneme@mail.com', N'123123')
SET IDENTITY_INSERT [dbo].[User] OFF
ALTER TABLE [dbo].[HotelAddress]  WITH CHECK ADD  CONSTRAINT [FK_HotelAddress_Hotel] FOREIGN KEY([HotelId])
REFERENCES [dbo].[Hotel] ([Id])
GO
ALTER TABLE [dbo].[HotelAddress] CHECK CONSTRAINT [FK_HotelAddress_Hotel]
GO
ALTER TABLE [dbo].[HotelComment]  WITH CHECK ADD  CONSTRAINT [FK_HotelComment_Hotel] FOREIGN KEY([HotelId])
REFERENCES [dbo].[Hotel] ([Id])
GO
ALTER TABLE [dbo].[HotelComment] CHECK CONSTRAINT [FK_HotelComment_Hotel]
GO
ALTER TABLE [dbo].[HotelComment]  WITH CHECK ADD  CONSTRAINT [FK_HotelComment_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[HotelComment] CHECK CONSTRAINT [FK_HotelComment_User]
GO
ALTER TABLE [dbo].[HotelContact]  WITH CHECK ADD  CONSTRAINT [FK_HotelContact_Hotel] FOREIGN KEY([HotelId])
REFERENCES [dbo].[Hotel] ([Id])
GO
ALTER TABLE [dbo].[HotelContact] CHECK CONSTRAINT [FK_HotelContact_Hotel]
GO
ALTER TABLE [dbo].[HotelContact]  WITH CHECK ADD  CONSTRAINT [FK_HotelContact_HotelContactType] FOREIGN KEY([HotelContactTypeId])
REFERENCES [dbo].[HotelContactType] ([Id])
GO
ALTER TABLE [dbo].[HotelContact] CHECK CONSTRAINT [FK_HotelContact_HotelContactType]
GO
ALTER TABLE [dbo].[HotelImage]  WITH CHECK ADD  CONSTRAINT [FK_HotelImage_Hotel] FOREIGN KEY([HotelId])
REFERENCES [dbo].[Hotel] ([Id])
GO
ALTER TABLE [dbo].[HotelImage] CHECK CONSTRAINT [FK_HotelImage_Hotel]
GO
ALTER TABLE [dbo].[HotelRoom]  WITH CHECK ADD  CONSTRAINT [FK_HotelRoom_Hotel] FOREIGN KEY([HotelId])
REFERENCES [dbo].[Hotel] ([Id])
GO
ALTER TABLE [dbo].[HotelRoom] CHECK CONSTRAINT [FK_HotelRoom_Hotel]
GO
ALTER TABLE [dbo].[HotelRoom]  WITH CHECK ADD  CONSTRAINT [FK_HotelRoom_RoomType] FOREIGN KEY([RoomTypeId])
REFERENCES [dbo].[RoomType] ([Id])
GO
ALTER TABLE [dbo].[HotelRoom] CHECK CONSTRAINT [FK_HotelRoom_RoomType]
GO
ALTER TABLE [dbo].[HotelRoomPrice]  WITH CHECK ADD  CONSTRAINT [FK_HotelRoomPrice_HotelRoom] FOREIGN KEY([HotelRoomId])
REFERENCES [dbo].[HotelRoom] ([Id])
GO
ALTER TABLE [dbo].[HotelRoomPrice] CHECK CONSTRAINT [FK_HotelRoomPrice_HotelRoom]
GO
ALTER TABLE [dbo].[HotelScore]  WITH CHECK ADD  CONSTRAINT [FK_HotelScore_Hotel] FOREIGN KEY([HotelId])
REFERENCES [dbo].[Hotel] ([Id])
GO
ALTER TABLE [dbo].[HotelScore] CHECK CONSTRAINT [FK_HotelScore_Hotel]
GO
USE [master]
GO
ALTER DATABASE [HotelDB] SET  READ_WRITE 
GO
