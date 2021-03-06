USE [master]
GO
/****** Object:  Database [ServicesDB]    Script Date: 14.06.2022 22:25:04 ******/
CREATE DATABASE [ServicesDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ServicesDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ServicesDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ServicesDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ServicesDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ServicesDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ServicesDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ServicesDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ServicesDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ServicesDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ServicesDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ServicesDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ServicesDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ServicesDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ServicesDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ServicesDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ServicesDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ServicesDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ServicesDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ServicesDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ServicesDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ServicesDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ServicesDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ServicesDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ServicesDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ServicesDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ServicesDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ServicesDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ServicesDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ServicesDB] SET RECOVERY FULL 
GO
ALTER DATABASE [ServicesDB] SET  MULTI_USER 
GO
ALTER DATABASE [ServicesDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ServicesDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ServicesDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ServicesDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ServicesDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ServicesDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ServicesDB', N'ON'
GO
ALTER DATABASE [ServicesDB] SET QUERY_STORE = OFF
GO
USE [ServicesDB]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 14.06.2022 22:25:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NULL,
	[Phone] [nvarchar](20) NOT NULL,
	[SignInID] [int] NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientServices]    Script Date: 14.06.2022 22:25:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientServices](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
	[ServiceName] [nvarchar](max) NOT NULL,
	[ServiceTiiming] [nvarchar](50) NOT NULL,
	[ServiceDate] [date] NOT NULL,
	[Price] [int] NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_ClientServices] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 14.06.2022 22:25:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [nchar](1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 14.06.2022 22:25:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceName] [nvarchar](max) NOT NULL,
	[ServiceTiming] [nvarchar](50) NOT NULL,
	[ServiceDate] [date] NULL,
	[Price] [int] NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SignIn]    Script Date: 14.06.2022 22:25:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SignIn](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[RoleID] [nchar](1) NOT NULL,
 CONSTRAINT [PK_SignIn] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([ID], [Surname], [Name], [Patronymic], [Phone], [SignInID]) VALUES (1, N'A', N'A', N'A', N'232', 1)
INSERT [dbo].[Clients] ([ID], [Surname], [Name], [Patronymic], [Phone], [SignInID]) VALUES (2, N'u', N'u', N'u', N'213', 2)
INSERT [dbo].[Clients] ([ID], [Surname], [Name], [Patronymic], [Phone], [SignInID]) VALUES (3, N'И', N'И', N'И', N'89898', 3)
INSERT [dbo].[Clients] ([ID], [Surname], [Name], [Patronymic], [Phone], [SignInID]) VALUES (4, N'Иванов', N'Иван', N'Иванович', N'898989898989', 4)
INSERT [dbo].[Clients] ([ID], [Surname], [Name], [Patronymic], [Phone], [SignInID]) VALUES (5, N'ff', N'gf', N'gf', N'34343434334434343', 5)
SET IDENTITY_INSERT [dbo].[Clients] OFF
GO
SET IDENTITY_INSERT [dbo].[ClientServices] ON 

INSERT [dbo].[ClientServices] ([ID], [ClientID], [ServiceName], [ServiceTiiming], [ServiceDate], [Price], [Description]) VALUES (1, 4, N'Ресницы', N'1ч.20мин.', CAST(N'2022-06-23' AS Date), 200, N'Наращивание')
SET IDENTITY_INSERT [dbo].[ClientServices] OFF
GO
INSERT [dbo].[Role] ([ID], [Title]) VALUES (N'A', N'Admin')
INSERT [dbo].[Role] ([ID], [Title]) VALUES (N'U', N'User')
GO
SET IDENTITY_INSERT [dbo].[Services] ON 

INSERT [dbo].[Services] ([ID], [ServiceName], [ServiceTiming], [ServiceDate], [Price], [Description]) VALUES (2, N'Ногти', N'2ч.50мин.', CAST(N'2022-06-15' AS Date), 300, N'Наращивание')
INSERT [dbo].[Services] ([ID], [ServiceName], [ServiceTiming], [ServiceDate], [Price], [Description]) VALUES (4, N'Брови', N'20мин.', CAST(N'2022-06-24' AS Date), 300, N'Краска')
SET IDENTITY_INSERT [dbo].[Services] OFF
GO
SET IDENTITY_INSERT [dbo].[SignIn] ON 

INSERT [dbo].[SignIn] ([ID], [Login], [Password], [RoleID]) VALUES (1, N'Sali', N'1004', N'A')
INSERT [dbo].[SignIn] ([ID], [Login], [Password], [RoleID]) VALUES (2, N'User', N'1234', N'U')
INSERT [dbo].[SignIn] ([ID], [Login], [Password], [RoleID]) VALUES (3, N'ioio', N'1234', N'U')
INSERT [dbo].[SignIn] ([ID], [Login], [Password], [RoleID]) VALUES (4, N'ivan01', N'1234', N'U')
INSERT [dbo].[SignIn] ([ID], [Login], [Password], [RoleID]) VALUES (5, N'gffg', N'rc4', N'U')
SET IDENTITY_INSERT [dbo].[SignIn] OFF
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD  CONSTRAINT [FK_Clients_SignIn] FOREIGN KEY([SignInID])
REFERENCES [dbo].[SignIn] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Clients] CHECK CONSTRAINT [FK_Clients_SignIn]
GO
ALTER TABLE [dbo].[ClientServices]  WITH CHECK ADD  CONSTRAINT [FK_ClientServices_Clients] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ClientServices] CHECK CONSTRAINT [FK_ClientServices_Clients]
GO
ALTER TABLE [dbo].[SignIn]  WITH CHECK ADD  CONSTRAINT [FK_SignIn_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SignIn] CHECK CONSTRAINT [FK_SignIn_Role]
GO
USE [master]
GO
ALTER DATABASE [ServicesDB] SET  READ_WRITE 
GO
