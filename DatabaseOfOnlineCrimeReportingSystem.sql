USE [master]
GO
/****** Object:  Database [OnlineCrimeReportingSystem]    Script Date: 12/29/2018 8:44:23 PM ******/
CREATE DATABASE [OnlineCrimeReportingSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OnlineCrimeReportingSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\OnlineCrimeReportingSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OnlineCrimeReportingSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\OnlineCrimeReportingSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OnlineCrimeReportingSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET RECOVERY FULL 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET  MULTI_USER 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'OnlineCrimeReportingSystem', N'ON'
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET QUERY_STORE = OFF
GO
USE [OnlineCrimeReportingSystem]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [OnlineCrimeReportingSystem]
GO
/****** Object:  Table [dbo].[AdminCriminalRecords]    Script Date: 12/29/2018 8:44:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminCriminalRecords](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[FrontDescription] [nvarchar](max) NOT NULL,
	[BackDescription] [nvarchar](max) NOT NULL,
	[Image] [varchar](50) NOT NULL,
 CONSTRAINT [PK_AdminCriminalRecords] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AdminProfile]    Script Date: 12/29/2018 8:44:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminProfile](
	[AdminID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_AdminProfile] PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContactUsMessage]    Script Date: 12/29/2018 8:44:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactUsMessage](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[MobileNo] [varchar](10) NOT NULL,
	[Message] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_ContactUsMessage] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Crime]    Script Date: 12/29/2018 8:44:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Crime](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Message] [nvarchar](max) NOT NULL,
	[CrimeDate] [datetime] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[CriminalName] [varchar](50) NULL,
	[Email] [varchar](50) NOT NULL,
	[Subject] [nvarchar](max) NOT NULL,
	[Location] [varchar](50) NOT NULL,
	[Files] [varchar](100) NULL,
	[Status] [bit] NOT NULL,
	[ReportingDate] [datetime2](7) NOT NULL,
	[UpdateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Crime] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CrimeType]    Script Date: 12/29/2018 8:44:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CrimeType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CrimeTypes] [varchar](50) NULL,
 CONSTRAINT [PK_CrimeType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Criminal]    Script Date: 12/29/2018 8:44:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Criminal](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[CrimeID] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Criminal] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserProfile]    Script Date: 12/29/2018 8:44:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserProfile](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_UserRegisterDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Crime] ADD  CONSTRAINT [DF_Crime_Status]  DEFAULT ((1)) FOR [Status]
GO
USE [master]
GO
ALTER DATABASE [OnlineCrimeReportingSystem] SET  READ_WRITE 
GO
