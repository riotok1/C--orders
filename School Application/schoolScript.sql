USE [master]
GO
/****** Object:  Database [SchoolDB]    Script Date: 09.02.2022 22:01:16 ******/
CREATE DATABASE [SchoolDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SchoolDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SchoolDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SchoolDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SchoolDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SchoolDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SchoolDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SchoolDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SchoolDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SchoolDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SchoolDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SchoolDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SchoolDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SchoolDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SchoolDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SchoolDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SchoolDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SchoolDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SchoolDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SchoolDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SchoolDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SchoolDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SchoolDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SchoolDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SchoolDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SchoolDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SchoolDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SchoolDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SchoolDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SchoolDB] SET RECOVERY FULL 
GO
ALTER DATABASE [SchoolDB] SET  MULTI_USER 
GO
ALTER DATABASE [SchoolDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SchoolDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SchoolDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SchoolDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SchoolDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SchoolDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SchoolDB', N'ON'
GO
ALTER DATABASE [SchoolDB] SET QUERY_STORE = OFF
GO
USE [SchoolDB]
GO
/****** Object:  Table [dbo].[Circles]    Script Date: 09.02.2022 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Circles](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CircTypeID] [int] NOT NULL,
	[TeacheID] [int] NULL,
	[ClassID] [int] NOT NULL,
 CONSTRAINT [PK_Circles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 09.02.2022 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Letter] [nvarchar](5) NOT NULL,
	[ClassNumber] [int] NOT NULL,
 CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Competition]    Script Date: 09.02.2022 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Competition](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CompName] [nvarchar](50) NOT NULL,
	[Location] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Competition] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nominations]    Script Date: 09.02.2022 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nominations](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CompetitionID] [int] NOT NULL,
	[ProjectName] [nvarchar](50) NOT NULL,
	[NominationName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Nominations] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaintingCompetition]    Script Date: 09.02.2022 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaintingCompetition](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[WorkID] [int] NOT NULL,
	[NominationID] [int] NULL,
	[Result] [nvarchar](50) NOT NULL,
	[TeacherID] [int] NOT NULL,
 CONSTRAINT [PK_PaintingCompetition] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schedule]    Script Date: 09.02.2022 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedule](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CircleID] [int] NULL,
	[Cabinet] [nvarchar](10) NOT NULL,
	[WeekDay] [nvarchar](30) NOT NULL,
	[StartTime] [nvarchar](20) NULL,
	[FinishTime] [nvarchar](20) NULL,
	[HalfYear] [int] NOT NULL,
	[AcademicYear] [nvarchar](20) NOT NULL,
	[ClassID] [int] NULL,
 CONSTRAINT [PK_Schedule] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 09.02.2022 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NOT NULL,
	[ClassID] [int] NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentsWorks]    Script Date: 09.02.2022 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentsWorks](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NULL,
	[WorkName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_StudentsWorks] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 09.02.2022 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeOfCircle]    Script Date: 09.02.2022 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeOfCircle](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TypeOfCircle] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visits]    Script Date: 09.02.2022 22:01:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visits](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TableID] [int] NULL,
	[StudentID] [int] NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_Visits] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Circles] ON 

INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (1, 1, 1, 5)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (2, 2, 2, 18)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (3, 3, 3, 16)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (4, 4, 4, 6)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (5, 5, 5, 5)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (6, 1, 6, 1)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (7, 1, 7, 13)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (8, 3, 8, 17)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (9, 4, 9, 12)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (10, 5, 10, 8)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (11, 6, 11, 4)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (12, 1, 1, 3)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (13, 2, 2, 10)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (14, 3, 3, 11)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (15, 4, 4, 15)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (16, 5, 5, 10)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (17, 6, 6, 1)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (18, 1, 7, 7)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (19, 4, 8, 5)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (20, 6, 9, 17)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (21, 4, 10, 8)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (22, 1, 11, 9)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (23, 2, 1, 1)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (24, 3, 2, 2)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (25, 4, 3, 11)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (26, 5, 4, 6)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (27, 6, 5, 5)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (28, 1, 6, 18)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (29, 2, 7, 4)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (30, 3, 8, 10)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (31, 4, 9, 12)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (32, 5, 10, 2)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (33, 6, 11, 6)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (34, 1, 1, 8)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (35, 2, 2, 1)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (36, 3, 3, 18)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (37, 4, 4, 15)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (38, 5, 5, 10)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (39, 6, 6, 3)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (40, 1, 7, 10)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (41, 2, 8, 1)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (42, 3, 9, 2)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (43, 4, 10, 5)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (44, 5, 11, 7)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (45, 6, 1, 18)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (46, 1, 2, 13)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (47, 2, 3, 15)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (48, 3, 4, 3)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (49, 4, 5, 2)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (50, 5, 6, 8)
INSERT [dbo].[Circles] ([ID], [CircTypeID], [TeacheID], [ClassID]) VALUES (51, 6, 7, 5)
SET IDENTITY_INSERT [dbo].[Circles] OFF
GO
SET IDENTITY_INSERT [dbo].[Class] ON 

INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (1, N'А', 1)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (2, N'Б', 1)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (3, N'А', 2)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (4, N'Б', 2)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (5, N'А', 9)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (6, N'Б', 3)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (7, N'А', 4)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (8, N'Б', 4)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (9, N'А', 5)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (10, N'Б', 9)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (11, N'А', 6)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (12, N'Б', 6)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (13, N'Б', 2)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (14, N'Б', 7)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (15, N'А', 8)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (16, N'Б', 8)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (17, N'А', 9)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (18, N'Б', 9)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (19, N'А', 10)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (20, N'Б', 10)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (21, N'А', 11)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (22, N'Б', 11)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (23, N'в', 5)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (24, N'Ш', 15)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (25, N'и', 200)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (26, N'Р', 11)
INSERT [dbo].[Class] ([ID], [Letter], [ClassNumber]) VALUES (27, N'Z', 7)
SET IDENTITY_INSERT [dbo].[Class] OFF
GO
SET IDENTITY_INSERT [dbo].[Competition] ON 

INSERT [dbo].[Competition] ([ID], [CompName], [Location]) VALUES (1, N'Международный', N'Китай')
INSERT [dbo].[Competition] ([ID], [CompName], [Location]) VALUES (2, N'Республиканский', N'Беларусь')
INSERT [dbo].[Competition] ([ID], [CompName], [Location]) VALUES (3, N'Областной', N'Гомель')
SET IDENTITY_INSERT [dbo].[Competition] OFF
GO
SET IDENTITY_INSERT [dbo].[Nominations] ON 

INSERT [dbo].[Nominations] ([ID], [CompetitionID], [ProjectName], [NominationName]) VALUES (1, 1, N' В деревне у бабушки', N'Традиция')
INSERT [dbo].[Nominations] ([ID], [CompetitionID], [ProjectName], [NominationName]) VALUES (2, 1, N'Рожденственский ангел', N'Исскуство')
INSERT [dbo].[Nominations] ([ID], [CompetitionID], [ProjectName], [NominationName]) VALUES (3, 2, N'Снегири', N'Традиция')
INSERT [dbo].[Nominations] ([ID], [CompetitionID], [ProjectName], [NominationName]) VALUES (4, 2, N'Любопытная лиса', N'Традиция')
INSERT [dbo].[Nominations] ([ID], [CompetitionID], [ProjectName], [NominationName]) VALUES (5, 3, N'Зимнее озеро', N'Исскуство')
INSERT [dbo].[Nominations] ([ID], [CompetitionID], [ProjectName], [NominationName]) VALUES (6, 3, N'Зимняя ночь', N'Традиция')
SET IDENTITY_INSERT [dbo].[Nominations] OFF
GO
SET IDENTITY_INSERT [dbo].[PaintingCompetition] ON 

INSERT [dbo].[PaintingCompetition] ([ID], [WorkID], [NominationID], [Result], [TeacherID]) VALUES (1, 1, NULL, N'Хороший', 1)
INSERT [dbo].[PaintingCompetition] ([ID], [WorkID], [NominationID], [Result], [TeacherID]) VALUES (2, 2, NULL, N'Отличный', 2)
INSERT [dbo].[PaintingCompetition] ([ID], [WorkID], [NominationID], [Result], [TeacherID]) VALUES (3, 3, NULL, N'Отличный', 3)
INSERT [dbo].[PaintingCompetition] ([ID], [WorkID], [NominationID], [Result], [TeacherID]) VALUES (4, 4, NULL, N'Отличный', 4)
INSERT [dbo].[PaintingCompetition] ([ID], [WorkID], [NominationID], [Result], [TeacherID]) VALUES (5, 5, NULL, N'Хороший', 5)
INSERT [dbo].[PaintingCompetition] ([ID], [WorkID], [NominationID], [Result], [TeacherID]) VALUES (6, 6, NULL, N'Хороший', 6)
INSERT [dbo].[PaintingCompetition] ([ID], [WorkID], [NominationID], [Result], [TeacherID]) VALUES (7, 7, NULL, N'Отличный', 7)
INSERT [dbo].[PaintingCompetition] ([ID], [WorkID], [NominationID], [Result], [TeacherID]) VALUES (8, 8, NULL, N'Отличный', 8)
INSERT [dbo].[PaintingCompetition] ([ID], [WorkID], [NominationID], [Result], [TeacherID]) VALUES (9, 9, NULL, N'Отличный', 9)
INSERT [dbo].[PaintingCompetition] ([ID], [WorkID], [NominationID], [Result], [TeacherID]) VALUES (10, 10, NULL, N'Хороший', 10)
SET IDENTITY_INSERT [dbo].[PaintingCompetition] OFF
GO
SET IDENTITY_INSERT [dbo].[Schedule] ON 

INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (2, 1, N'3-7', N'Понедельник', N'10:00', N'11:00', 3, N'2021/2022', 5)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (3, 2, N'3-7', N'Понедельник', N'11:00', N'12:00', 2, N'2021/2022', 18)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (4, 3, N'3-7', N'Понедельник', N'12:00', N'13:00', 2, N'2021/2022', 1)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (5, 4, N'3-7', N'Понедельник', N'13:00', N'14:00', 2, N'2021/2022', 13)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (6, 5, N'3-7', N'Понедельник', N'14:00', N'15:00', 1, N'2021/2022', 17)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (8, 7, N'3-7', N'Понедельник', N'15:00', N'16:00', 2, N'2021/2022', 4)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (9, 8, N'3-5', N'Понедельник', N'16:00', N'17:00', 2, N'2021/2022', 7)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (10, 9, N'3-5', N'Понедельник', N'11:00', N'12:00', 2, N'2021/2022', 14)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (11, 10, N'3-5', N'Понедельник', N'12:00', N'13:00', 2, N'2021/2022', 16)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (12, 11, N'3-5', N'Понедельник', N'13:00', N'14:00', 2, N'2021/2022', 2)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (14, 13, N'1-6', N'Понедельник', N'12.45', N'13.25', 2, N'2021/2022', 9)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (15, 14, N'1-6', N'Понедельник', N'11.10', N'11.45', 2, N'2021/2022', 3)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (16, 15, N'1-3', N'Понедельник', N'12:00', N'13:00', 2, N'2021/2022', 10)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (17, 16, N'1-3', N'Понедельник', N'13.55', N'14.35', 2, N'2021/2022', 8)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (18, 17, N'1-3', N'Понедельник', N'14:00', N'15:00', 2, N'2021/2022', 12)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (19, 18, N'1-3', N'Понедельник', N'15:00', N'16:00', 2, N'2021/2022', 6)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (20, 19, N'1-3', N'Понедельник', N'16:00', N'17:00', 2, N'2021/2022', 11)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (21, 20, N'1-8', N'Вторник', N'17:00', N'18:00', 2, N'2021/2022', 5)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (22, 21, N'1-8', N'Вторник', N'11:00', N'12:00', 2, N'2021/2022', 18)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (23, 22, N'1-8', N'Вторник', N'12:00', N'13:00', 2, N'2021/2022', 1)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (24, 23, N'3-5', N'Вторник', N'13:00', N'14:00', 2, N'2021/2022', 13)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (25, 24, N'3-5', N'Вторник', N'14:00', N'15:00', 2, N'2021/2022', 17)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (26, 25, N'3-5', N'Вторник', N'15:00', N'16:00', 2, N'2021/2022', 12)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (27, 26, N'3-5', N'Вторник', N'16:00', N'17:00', 2, N'2021/2022', 4)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (28, 27, N'3-5', N'Вторник', N'10.10', N'10.45', 2, N'2021/2022', 7)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (29, 28, N'3-5', N'Вторник', N'11:00', N'12:00', 2, N'2021/2022', 14)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (30, 29, N'3-5', N'Вторник', N'12.45', N'13.25', 2, N'2021/2022', 16)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (31, 30, N'3-5', N'Вторник', N'12:00', N'15:00', 2, N'2021/2022', 2)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (32, 31, N'3-5', N'Вторник', N'13:00', N'14:00', 2, N'2021/2022', 15)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (33, 32, N'3-7', N'Вторник', N'11.40', N'12.15', 2, N'2021/2022', 9)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (34, 33, N'3-7', N'Вторник', N'13.55', N'14.35', 2, N'2021/2022', 3)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (35, 34, N'3-7', N'Вторник', N'14:00', N'15:00', 2, N'2021/2022', 10)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (36, 35, N'3-7', N'Вторник', N'9.55', N'10.35', 2, N'2021/2022', 8)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (37, 36, N'3-7', N'Вторник', N'10:00', N'11:00', 2, N'2021/2022', 12)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (38, 37, N'3-7', N'Вторник', N'11.50', N'12.30', 2, N'2021/2022', 6)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (39, 38, N'3-7', N'Вторник', N'13.30', N'14.05', 2, N'2021/2022', 11)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (40, 39, N'3-5', N'Среда', N'11.40', N'12.15', 2, N'2021/2022', 5)
INSERT [dbo].[Schedule] ([ID], [CircleID], [Cabinet], [WeekDay], [StartTime], [FinishTime], [HalfYear], [AcademicYear], [ClassID]) VALUES (41, 40, N'3-5', N'Среда', N'13.55', N'14.35', 2, N'2021/2022', 18)
SET IDENTITY_INSERT [dbo].[Schedule] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([ID], [Surname], [Name], [Patronymic], [ClassID]) VALUES (1, N'Михальцова', N'Милана', N'Олеговна', 6)
INSERT [dbo].[Students] ([ID], [Surname], [Name], [Patronymic], [ClassID]) VALUES (2, N'Гатилов', N'Олег', N'Николаевич', 8)
INSERT [dbo].[Students] ([ID], [Surname], [Name], [Patronymic], [ClassID]) VALUES (3, N'Тимофеева', N'Дарья', N'Александровна', 16)
INSERT [dbo].[Students] ([ID], [Surname], [Name], [Patronymic], [ClassID]) VALUES (4, N'Панкова', N'Александра', N'Владимировна', 10)
INSERT [dbo].[Students] ([ID], [Surname], [Name], [Patronymic], [ClassID]) VALUES (5, N'Гусарова', N'Александра', N'Викторовна', 17)
INSERT [dbo].[Students] ([ID], [Surname], [Name], [Patronymic], [ClassID]) VALUES (6, N'Прохоренко', N'Дарья', N'Александровна', 2)
INSERT [dbo].[Students] ([ID], [Surname], [Name], [Patronymic], [ClassID]) VALUES (7, N'Савицкий', N'Кирилл', N'Александрович', 9)
INSERT [dbo].[Students] ([ID], [Surname], [Name], [Patronymic], [ClassID]) VALUES (8, N'Шатунова', N'Анастасия', N'Владимировна', 18)
INSERT [dbo].[Students] ([ID], [Surname], [Name], [Patronymic], [ClassID]) VALUES (9, N'Махаев', N'Николай', N'Николаевич', 11)
INSERT [dbo].[Students] ([ID], [Surname], [Name], [Patronymic], [ClassID]) VALUES (10, N'Пинчук', N'Эмилия', N'Олеговна', 14)
INSERT [dbo].[Students] ([ID], [Surname], [Name], [Patronymic], [ClassID]) VALUES (13, N'Иванов', N'Иван', N'Иванович', 22)
INSERT [dbo].[Students] ([ID], [Surname], [Name], [Patronymic], [ClassID]) VALUES (14, N'Петров', N'Петр', N'Петрович', 23)
INSERT [dbo].[Students] ([ID], [Surname], [Name], [Patronymic], [ClassID]) VALUES (15, N'Сергеев', N'Сергей', N'Сергеевич', 25)
INSERT [dbo].[Students] ([ID], [Surname], [Name], [Patronymic], [ClassID]) VALUES (16, N'Гусарова', N'Александра', N'Викторовна', 26)
INSERT [dbo].[Students] ([ID], [Surname], [Name], [Patronymic], [ClassID]) VALUES (17, N'V', N'Q', N'V', 27)
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
SET IDENTITY_INSERT [dbo].[StudentsWorks] ON 

INSERT [dbo].[StudentsWorks] ([ID], [StudentID], [WorkName], [Description], [Image]) VALUES (1, 1, N'Весеннняя дорога', N'Прощание с зимой', N'D:\Рисунки\Весенняя дрога.jpg')
INSERT [dbo].[StudentsWorks] ([ID], [StudentID], [WorkName], [Description], [Image]) VALUES (2, 2, N'В деревне у бабушки', N'Летние каникулы', N'D:\Рисунки\В деревне у бабушки.jpg')
INSERT [dbo].[StudentsWorks] ([ID], [StudentID], [WorkName], [Description], [Image]) VALUES (3, 3, N'Рожденственский ангел', N'Празднуем рождество с ангелом', N'D:\Рисунки\Рожденственский ангел.jpg')
INSERT [dbo].[StudentsWorks] ([ID], [StudentID], [WorkName], [Description], [Image]) VALUES (4, 4, N'Снегири', N'Пришла зима', N'D:\Рисунки\Снегири.jpg')
INSERT [dbo].[StudentsWorks] ([ID], [StudentID], [WorkName], [Description], [Image]) VALUES (5, 5, N'Новогодний ангел', N'С новым годом', N'D:\Рисунки\Новогодний ангел.jpg')
INSERT [dbo].[StudentsWorks] ([ID], [StudentID], [WorkName], [Description], [Image]) VALUES (6, 6, N'Серебрянное копытце', N'Дед мороз пришел', N'D:\Рисунки\Серебрянное копытце.jpg')
INSERT [dbo].[StudentsWorks] ([ID], [StudentID], [WorkName], [Description], [Image]) VALUES (7, 7, N'Любопытная лиса', N'Стучится новый год', N'D:\Рисунки\Любопытная лиса.jpg')
INSERT [dbo].[StudentsWorks] ([ID], [StudentID], [WorkName], [Description], [Image]) VALUES (8, 8, N'Зимнее озеро', N'На улице очень холодно стало', N'D:\Рисунки\Зимнее озеро.jpg')
INSERT [dbo].[StudentsWorks] ([ID], [StudentID], [WorkName], [Description], [Image]) VALUES (9, 9, N'Зимняя ночь', N'Выпал первый снег', N'D:\Рисунки\Зимняя ночь.jpg')
INSERT [dbo].[StudentsWorks] ([ID], [StudentID], [WorkName], [Description], [Image]) VALUES (10, 10, N'Каменный цветок', N'Весна пришла', N'D:\Рисунки\Каменнй цветок.jpg')
SET IDENTITY_INSERT [dbo].[StudentsWorks] OFF
GO
SET IDENTITY_INSERT [dbo].[Teachers] ON 

INSERT [dbo].[Teachers] ([ID], [Surname], [Name], [Patronymic]) VALUES (1, N'Бондарева', N'Юлия', N'Бондарева')
INSERT [dbo].[Teachers] ([ID], [Surname], [Name], [Patronymic]) VALUES (2, N'Борисевич', N'Наталья', N'Борисевич')
INSERT [dbo].[Teachers] ([ID], [Surname], [Name], [Patronymic]) VALUES (3, N'Шатунова', N'Мария', N'Владимировна')
INSERT [dbo].[Teachers] ([ID], [Surname], [Name], [Patronymic]) VALUES (4, N'Юдашкина', N'Рената', N'Николаевна')
INSERT [dbo].[Teachers] ([ID], [Surname], [Name], [Patronymic]) VALUES (5, N'Прищепова', N'Екатерина', N'Михайловна')
INSERT [dbo].[Teachers] ([ID], [Surname], [Name], [Patronymic]) VALUES (6, N'Двалишливи', N'Виктория', N'Игорьевна')
INSERT [dbo].[Teachers] ([ID], [Surname], [Name], [Patronymic]) VALUES (7, N'Козловский', N'Владимир', N'Козловский')
INSERT [dbo].[Teachers] ([ID], [Surname], [Name], [Patronymic]) VALUES (8, N'Панкова', N'Ирина', N'Игорьевна')
INSERT [dbo].[Teachers] ([ID], [Surname], [Name], [Patronymic]) VALUES (9, N'Макарова', N'Елизавета', N'Макарова')
INSERT [dbo].[Teachers] ([ID], [Surname], [Name], [Patronymic]) VALUES (10, N'Костюшко', N'Татьяна', N'Андреевна')
INSERT [dbo].[Teachers] ([ID], [Surname], [Name], [Patronymic]) VALUES (11, N'Петрова', N'Анна', N'Михайловна')
SET IDENTITY_INSERT [dbo].[Teachers] OFF
GO
SET IDENTITY_INSERT [dbo].[TypeOfCircle] ON 

INSERT [dbo].[TypeOfCircle] ([ID], [Title]) VALUES (1, N'Лепка')
INSERT [dbo].[TypeOfCircle] ([ID], [Title]) VALUES (2, N'Рисунок')
INSERT [dbo].[TypeOfCircle] ([ID], [Title]) VALUES (3, N'Живопись')
INSERT [dbo].[TypeOfCircle] ([ID], [Title]) VALUES (4, N'Композиция')
INSERT [dbo].[TypeOfCircle] ([ID], [Title]) VALUES (5, N'Дизайн')
INSERT [dbo].[TypeOfCircle] ([ID], [Title]) VALUES (6, N'Керамика')
SET IDENTITY_INSERT [dbo].[TypeOfCircle] OFF
GO
SET IDENTITY_INSERT [dbo].[Visits] ON 

INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (4, 2, 1, CAST(N'2022-01-31' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (5, 2, 2, CAST(N'2022-01-31' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (6, 2, 3, CAST(N'2022-01-31' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (7, 2, 4, CAST(N'2022-01-31' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (8, 2, 5, CAST(N'2022-01-31' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (9, 2, 6, CAST(N'2022-01-31' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (10, 2, 7, CAST(N'2022-01-31' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (11, 2, 8, CAST(N'2022-01-31' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (12, 2, 9, CAST(N'2022-01-31' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (13, 3, 2, CAST(N'2022-02-01' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (14, 3, 4, CAST(N'2022-02-01' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (15, 3, 5, CAST(N'2022-02-01' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (16, 3, 6, CAST(N'2022-02-01' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (17, 3, 7, CAST(N'2022-02-01' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (18, 3, 8, CAST(N'2022-02-01' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (19, 4, 1, CAST(N'2022-02-02' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (20, 4, 2, CAST(N'2022-02-02' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (21, 4, 5, CAST(N'2022-02-02' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (22, 4, 6, CAST(N'2022-02-02' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (23, 5, 1, CAST(N'2022-02-03' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (24, 5, 3, CAST(N'2022-02-03' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (25, 5, 4, CAST(N'2022-02-03' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (26, 5, 5, CAST(N'2022-02-03' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (27, 5, 7, CAST(N'2022-02-03' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (28, 5, 8, CAST(N'2022-02-03' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (29, 5, 10, CAST(N'2022-02-03' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (30, 6, 1, CAST(N'2022-02-04' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (31, 6, 2, CAST(N'2022-02-04' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (32, 6, 3, CAST(N'2022-02-04' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (33, 6, 4, CAST(N'2022-02-04' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (34, 6, 5, CAST(N'2022-02-04' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (35, 6, 6, CAST(N'2022-02-04' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (36, 6, 7, CAST(N'2022-02-04' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (37, 6, 8, CAST(N'2022-02-04' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (38, 6, 9, CAST(N'2022-02-04' AS Date))
INSERT [dbo].[Visits] ([ID], [TableID], [StudentID], [Date]) VALUES (39, 6, 10, CAST(N'2022-02-04' AS Date))
SET IDENTITY_INSERT [dbo].[Visits] OFF
GO
ALTER TABLE [dbo].[Circles]  WITH CHECK ADD  CONSTRAINT [FK_Circles_Class] FOREIGN KEY([ClassID])
REFERENCES [dbo].[Class] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Circles] CHECK CONSTRAINT [FK_Circles_Class]
GO
ALTER TABLE [dbo].[Circles]  WITH CHECK ADD  CONSTRAINT [FK_Circles_Teachers] FOREIGN KEY([TeacheID])
REFERENCES [dbo].[Teachers] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Circles] CHECK CONSTRAINT [FK_Circles_Teachers]
GO
ALTER TABLE [dbo].[Circles]  WITH CHECK ADD  CONSTRAINT [FK_Circles_TypeOfCircle] FOREIGN KEY([CircTypeID])
REFERENCES [dbo].[TypeOfCircle] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Circles] CHECK CONSTRAINT [FK_Circles_TypeOfCircle]
GO
ALTER TABLE [dbo].[Nominations]  WITH CHECK ADD  CONSTRAINT [FK_Nominations_Competition] FOREIGN KEY([CompetitionID])
REFERENCES [dbo].[Competition] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Nominations] CHECK CONSTRAINT [FK_Nominations_Competition]
GO
ALTER TABLE [dbo].[PaintingCompetition]  WITH CHECK ADD  CONSTRAINT [FK_PaintingCompetition_Nominations] FOREIGN KEY([NominationID])
REFERENCES [dbo].[Nominations] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PaintingCompetition] CHECK CONSTRAINT [FK_PaintingCompetition_Nominations]
GO
ALTER TABLE [dbo].[PaintingCompetition]  WITH CHECK ADD  CONSTRAINT [FK_PaintingCompetition_StudentsWorks] FOREIGN KEY([WorkID])
REFERENCES [dbo].[StudentsWorks] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PaintingCompetition] CHECK CONSTRAINT [FK_PaintingCompetition_StudentsWorks]
GO
ALTER TABLE [dbo].[PaintingCompetition]  WITH CHECK ADD  CONSTRAINT [FK_PaintingCompetition_Teachers] FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teachers] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PaintingCompetition] CHECK CONSTRAINT [FK_PaintingCompetition_Teachers]
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_Circles] FOREIGN KEY([CircleID])
REFERENCES [dbo].[Circles] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [FK_Schedule_Circles]
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_Class] FOREIGN KEY([ClassID])
REFERENCES [dbo].[Class] ([ID])
GO
ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [FK_Schedule_Class]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Class] FOREIGN KEY([ClassID])
REFERENCES [dbo].[Class] ([ID])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Class]
GO
ALTER TABLE [dbo].[StudentsWorks]  WITH CHECK ADD  CONSTRAINT [FK_StudentsWorks_Students] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StudentsWorks] CHECK CONSTRAINT [FK_StudentsWorks_Students]
GO
ALTER TABLE [dbo].[Visits]  WITH CHECK ADD  CONSTRAINT [FK_Visits_Schedule] FOREIGN KEY([TableID])
REFERENCES [dbo].[Schedule] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Visits] CHECK CONSTRAINT [FK_Visits_Schedule]
GO
ALTER TABLE [dbo].[Visits]  WITH CHECK ADD  CONSTRAINT [FK_Visits_Students] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Visits] CHECK CONSTRAINT [FK_Visits_Students]
GO
USE [master]
GO
ALTER DATABASE [SchoolDB] SET  READ_WRITE 
GO
