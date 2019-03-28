USE [master]
GO
/****** Object:  Database [Lab]    Script Date: 03/28/2019 07:43:30 ******/
CREATE DATABASE [Lab] ON  PRIMARY 
( NAME = N'Lab', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Lab.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Lab_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Lab_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Lab] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Lab].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Lab] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Lab] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Lab] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Lab] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Lab] SET ARITHABORT OFF
GO
ALTER DATABASE [Lab] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Lab] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Lab] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Lab] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Lab] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Lab] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Lab] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Lab] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Lab] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Lab] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Lab] SET  DISABLE_BROKER
GO
ALTER DATABASE [Lab] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Lab] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Lab] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Lab] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Lab] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Lab] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Lab] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Lab] SET  READ_WRITE
GO
ALTER DATABASE [Lab] SET RECOVERY SIMPLE
GO
ALTER DATABASE [Lab] SET  MULTI_USER
GO
ALTER DATABASE [Lab] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Lab] SET DB_CHAINING OFF
GO
USE [Lab]
GO
/****** Object:  Table [dbo].[loglms]    Script Date: 03/28/2019 07:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[loglms](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[username] [varchar](max) NULL,
	[password] [varchar](max) NULL,
	[country] [varchar](max) NULL,
	[email] [varchar](max) NULL,
 CONSTRAINT [PK_loglms] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[lmsret]    Script Date: 03/28/2019 07:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[lmsret](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](max) NULL,
	[book] [varchar](max) NULL,
	[contact] [varchar](max) NULL,
	[country] [varchar](max) NULL,
	[issue_date] [varchar](max) NULL,
	[return_date] [varchar](max) NULL,
	[pin] [bigint] NULL,
 CONSTRAINT [PK_lmsret] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[lms]    Script Date: 03/28/2019 07:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[lms](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[member_name] [varchar](max) NOT NULL,
	[book_name] [varchar](max) NOT NULL,
	[contact_number] [varchar](max) NOT NULL,
	[country] [varchar](max) NOT NULL,
	[date] [varchar](max) NOT NULL,
	[time] [varchar](max) NOT NULL,
	[pin] [bigint] NOT NULL,
	[book_id] [bigint] NULL,
 CONSTRAINT [PK_lms] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[dms]    Script Date: 03/28/2019 07:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dms](
	[getdate] [bigint] NULL,
	[backdate] [bigint] NULL,
	[pin] [bigint] NULL,
	[gettime] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[book]    Script Date: 03/28/2019 07:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[book](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[book_name] [varchar](max) NULL,
	[total] [varchar](max) NULL,
	[issue] [varchar](max) NULL,
	[reamining] [varchar](max) NULL,
 CONSTRAINT [PK_book] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
