USE [master]
GO
/****** Object:  Database [DBpetz]    Script Date: 14-05-2024 09:00:06 ******/
CREATE DATABASE [DBpetz]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBpetz', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DBpetz.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBpetz_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DBpetz_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DBpetz] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBpetz].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBpetz] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBpetz] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBpetz] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBpetz] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBpetz] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBpetz] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBpetz] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBpetz] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBpetz] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBpetz] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBpetz] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBpetz] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBpetz] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBpetz] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBpetz] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DBpetz] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBpetz] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBpetz] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBpetz] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBpetz] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBpetz] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBpetz] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBpetz] SET RECOVERY FULL 
GO
ALTER DATABASE [DBpetz] SET  MULTI_USER 
GO
ALTER DATABASE [DBpetz] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBpetz] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBpetz] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBpetz] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBpetz] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBpetz] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBpetz', N'ON'
GO
ALTER DATABASE [DBpetz] SET QUERY_STORE = ON
GO
ALTER DATABASE [DBpetz] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DBpetz]
GO
/****** Object:  User [soudha]    Script Date: 14-05-2024 09:00:06 ******/
CREATE USER [soudha] FOR LOGIN [soudha] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 14-05-2024 09:00:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PetsCategory]    Script Date: 14-05-2024 09:00:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PetsCategory](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Image] [varbinary](max) NULL,
	[ImagePath] [nvarchar](max) NULL,
 CONSTRAINT [PK_PetsCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profile]    Script Date: 14-05-2024 09:00:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profile](
	[Id] [uniqueidentifier] NOT NULL,
	[ProfileName] [varbinary](50) NOT NULL,
	[Gender] [nchar](10) NOT NULL,
	[Discription] [nvarchar](50) NOT NULL,
	[Image] [varbinary](50) NOT NULL,
	[User] [uniqueidentifier] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 14-05-2024 09:00:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [uniqueidentifier] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Phone] [nvarchar](20) NOT NULL,
	[Image] [varbinary](max) NULL,
	[ConnectionId] [nvarchar](max) NULL,
	[IsOnline] [bit] NOT NULL,
	[Address] [nvarchar](max) NULL,
	[Role] [int] NULL,
	[Accountcreated] [datetime2](7) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_Profile_User]    Script Date: 14-05-2024 09:00:06 ******/
CREATE NONCLUSTERED INDEX [IX_Profile_User] ON [dbo].[Profile]
(
	[User] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Profile]  WITH CHECK ADD  CONSTRAINT [FK_Profile_PublicUser] FOREIGN KEY([User])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Profile] CHECK CONSTRAINT [FK_Profile_PublicUser]
GO
USE [master]
GO
ALTER DATABASE [DBpetz] SET  READ_WRITE 
GO
