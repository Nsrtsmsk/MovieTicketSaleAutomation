USE [master]
GO
/****** Object:  Database [30Cinema]    Script Date: 28.12.2021 15:26:14 ******/
CREATE DATABASE [30Cinema]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'30Cinema', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\30Cinema.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'30Cinema_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\30Cinema_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [30Cinema] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [30Cinema].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [30Cinema] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [30Cinema] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [30Cinema] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [30Cinema] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [30Cinema] SET ARITHABORT OFF 
GO
ALTER DATABASE [30Cinema] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [30Cinema] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [30Cinema] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [30Cinema] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [30Cinema] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [30Cinema] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [30Cinema] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [30Cinema] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [30Cinema] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [30Cinema] SET  DISABLE_BROKER 
GO
ALTER DATABASE [30Cinema] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [30Cinema] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [30Cinema] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [30Cinema] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [30Cinema] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [30Cinema] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [30Cinema] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [30Cinema] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [30Cinema] SET  MULTI_USER 
GO
ALTER DATABASE [30Cinema] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [30Cinema] SET DB_CHAINING OFF 
GO
ALTER DATABASE [30Cinema] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [30Cinema] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [30Cinema] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [30Cinema] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [30Cinema] SET QUERY_STORE = OFF
GO
USE [30Cinema]
GO
/****** Object:  Table [dbo].[HALL]    Script Date: 28.12.2021 15:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HALL](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HALLNAME] [nvarchar](50) NULL,
 CONSTRAINT [PK_HALL] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MHS]    Script Date: 28.12.2021 15:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MHS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MOVIEID] [int] NULL,
	[HALLID] [int] NULL,
	[SESSIONID] [int] NULL,
 CONSTRAINT [PK_MHS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MHSS]    Script Date: 28.12.2021 15:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MHSS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MHSID] [int] NULL,
	[SEATNO] [nvarchar](50) NULL,
 CONSTRAINT [PK_MHSS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MOVIE]    Script Date: 28.12.2021 15:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOVIE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MOVIENAME] [nvarchar](50) NULL,
	[DIRECTOR] [nvarchar](50) NULL,
	[GENRE] [nvarchar](50) NULL,
	[DESCRIPTION] [nvarchar](max) NULL,
	[IMAGE] [nvarchar](max) NULL,
	[DURATION] [nvarchar](50) NULL,
	[STATUS] [bit] NULL,
 CONSTRAINT [PK_MOVIE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SEAT]    Script Date: 28.12.2021 15:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SEAT](
	[SEATNO] [nvarchar](50) NOT NULL,
	[PRICE] [decimal](18, 2) NULL,
 CONSTRAINT [PK_SEAT_1] PRIMARY KEY CLUSTERED 
(
	[SEATNO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SESSION]    Script Date: 28.12.2021 15:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SESSION](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SESSIONTIME] [time](7) NULL,
 CONSTRAINT [PK_SESSION] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TICKET]    Script Date: 28.12.2021 15:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TICKET](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MHSSID] [int] NULL,
	[USERID] [int] NULL,
 CONSTRAINT [PK_TICKET] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TICKETDETAILS]    Script Date: 28.12.2021 15:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TICKETDETAILS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TICKETID] [int] NULL,
	[PAYMENTTYPE] [bit] NULL,
	[PAYMENTTOTAL] [money] NULL,
	[DATE] [date] NULL,
 CONSTRAINT [PK_TICKETDETAILS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USER]    Script Date: 28.12.2021 15:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USER](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [nvarchar](50) NULL,
	[PASSWORD] [nvarchar](50) NULL,
 CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MHS]  WITH CHECK ADD  CONSTRAINT [FK_MHS_HALL] FOREIGN KEY([HALLID])
REFERENCES [dbo].[HALL] ([ID])
GO
ALTER TABLE [dbo].[MHS] CHECK CONSTRAINT [FK_MHS_HALL]
GO
ALTER TABLE [dbo].[MHS]  WITH CHECK ADD  CONSTRAINT [FK_MHS_MOVIE] FOREIGN KEY([MOVIEID])
REFERENCES [dbo].[MOVIE] ([ID])
GO
ALTER TABLE [dbo].[MHS] CHECK CONSTRAINT [FK_MHS_MOVIE]
GO
ALTER TABLE [dbo].[MHS]  WITH CHECK ADD  CONSTRAINT [FK_MHS_SESSION] FOREIGN KEY([SESSIONID])
REFERENCES [dbo].[SESSION] ([ID])
GO
ALTER TABLE [dbo].[MHS] CHECK CONSTRAINT [FK_MHS_SESSION]
GO
ALTER TABLE [dbo].[MHSS]  WITH CHECK ADD  CONSTRAINT [FK_MHSS_MHS] FOREIGN KEY([MHSID])
REFERENCES [dbo].[MHS] ([ID])
GO
ALTER TABLE [dbo].[MHSS] CHECK CONSTRAINT [FK_MHSS_MHS]
GO
ALTER TABLE [dbo].[MHSS]  WITH CHECK ADD  CONSTRAINT [FK_MHSS_SEAT] FOREIGN KEY([SEATNO])
REFERENCES [dbo].[SEAT] ([SEATNO])
GO
ALTER TABLE [dbo].[MHSS] CHECK CONSTRAINT [FK_MHSS_SEAT]
GO
ALTER TABLE [dbo].[TICKET]  WITH CHECK ADD  CONSTRAINT [FK_TICKET_MHSS] FOREIGN KEY([MHSSID])
REFERENCES [dbo].[MHSS] ([ID])
GO
ALTER TABLE [dbo].[TICKET] CHECK CONSTRAINT [FK_TICKET_MHSS]
GO
ALTER TABLE [dbo].[TICKET]  WITH CHECK ADD  CONSTRAINT [FK_TICKET_USER] FOREIGN KEY([USERID])
REFERENCES [dbo].[USER] ([ID])
GO
ALTER TABLE [dbo].[TICKET] CHECK CONSTRAINT [FK_TICKET_USER]
GO
ALTER TABLE [dbo].[TICKETDETAILS]  WITH CHECK ADD  CONSTRAINT [FK_TICKETDETAILS_TICKET] FOREIGN KEY([TICKETID])
REFERENCES [dbo].[TICKET] ([ID])
GO
ALTER TABLE [dbo].[TICKETDETAILS] CHECK CONSTRAINT [FK_TICKETDETAILS_TICKET]
GO
USE [master]
GO
ALTER DATABASE [30Cinema] SET  READ_WRITE 
GO
