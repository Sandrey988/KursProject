USE [master]
GO
CREATE DATABASE [PharmacyCourseProject]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Pharmacy', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Pharmacy.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Pharmacy_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Pharmacy_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PharmacyCourseProject] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PharmacyCourseProject].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PharmacyCourseProject] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PharmacyCourseProject] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PharmacyCourseProject] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PharmacyCourseProject] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PharmacyCourseProject] SET ARITHABORT OFF 
GO
ALTER DATABASE [PharmacyCourseProject] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PharmacyCourseProject] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PharmacyCourseProject] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PharmacyCourseProject] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PharmacyCourseProject] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PharmacyCourseProject] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PharmacyCourseProject] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PharmacyCourseProject] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PharmacyCourseProject] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PharmacyCourseProject] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PharmacyCourseProject] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PharmacyCourseProject] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PharmacyCourseProject] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PharmacyCourseProject] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PharmacyCourseProject] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PharmacyCourseProject] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PharmacyCourseProject] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PharmacyCourseProject] SET RECOVERY FULL 
GO
ALTER DATABASE [PharmacyCourseProject] SET  MULTI_USER 
GO
ALTER DATABASE [PharmacyCourseProject] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PharmacyCourseProject] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PharmacyCourseProject] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PharmacyCourseProject] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PharmacyCourseProject] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'PharmacyCourseProject', N'ON'
GO
USE [PharmacyCourseProject]
GO
/****** Object:  Table [dbo].[Analogs]    Script Date: 23.05.2017 18:37:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

use PharmacyCourseProject

CREATE TABLE [dbo].[Analogs](
	[DrugName] [nvarchar](50) NOT NULL,
	[AnalogName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Analogs] PRIMARY KEY CLUSTERED 
(
	[DrugName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Discount]    Script Date: 23.05.2017 18:37:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discount](
	[DrugId] [int] NOT NULL,
	[Discount] [int] NOT NULL,
 CONSTRAINT [PK_Discount] PRIMARY KEY CLUSTERED 
(
	[DrugId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Drugs]    Script Date: 23.05.2017 18:37:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drugs](
	[DrugID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ManufactureDate] [date] NOT NULL,
	[DisposeDate] [date] NOT NULL,
	[Cost] [float] NOT NULL,
	[ProducerId] [int] NOT NULL,
	[Count] [int] NOT NULL,
 CONSTRAINT [PK_Drugs] PRIMARY KEY CLUSTERED 
(
	[DrugID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medications](
	[Name] [nvarchar](50) NOT NULL,
	[PharmachologicEffect] [nvarchar](3000) NOT NULL,
	[IndicationsForUse] [nvarchar](1000) NOT NULL,
	[ModeOfApplication] [nvarchar](1000) NOT NULL,
	[SideEffects] [nvarchar](1000) NOT NULL,
	[Contraindications] [nvarchar](1000) NOT NULL,
	[Pregnancy] [nvarchar](1000) NOT NULL,
	[DrugInteractions] [nvarchar](1000) NOT NULL,
	[Overdose] [nvarchar](1000) NOT NULL,
	[Composition] [nvarchar](1000) NOT NULL,
	[PharmacologicalGroup] [nvarchar](100) NOT NULL,
	[ActiveSubstance] [nvarchar](50) NOT NULL,
	[LeaveConditions] [nvarchar](20) NOT NULL,
	[IssueForm] [nvarchar](500) NOT NULL,
	[StorageConditions] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_Medications_1] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PharmacologicalGroup](
	[PharmacologicalGroup] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_PharmacologicalGroup] PRIMARY KEY CLUSTERED 
(
	[PharmacologicalGroup] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Producers]    Script Date: 23.05.2017 18:37:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producers](
	[ProducerID] [int] IDENTITY(1,1) NOT NULL,
	[FirmName] [nvarchar](50) NOT NULL,
	[County] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Producers] PRIMARY KEY CLUSTERED 
(
	[ProducerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Analogs]  WITH CHECK ADD  CONSTRAINT [FK_Analogs_Medications] FOREIGN KEY([DrugName])
REFERENCES [dbo].[Medications] ([Name])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Analogs] CHECK CONSTRAINT [FK_Analogs_Medications]
GO
ALTER TABLE [dbo].[Discount]  WITH CHECK ADD  CONSTRAINT [FK_Discount_Drugs] FOREIGN KEY([DrugId])
REFERENCES [dbo].[Drugs] ([DrugID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Discount] CHECK CONSTRAINT [FK_Discount_Drugs]
GO
ALTER TABLE [dbo].[Drugs]  WITH CHECK ADD  CONSTRAINT [FK_Drugs_Medications] FOREIGN KEY([Name])
REFERENCES [dbo].[Medications] ([Name])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Drugs] CHECK CONSTRAINT [FK_Drugs_Medications]
GO
ALTER TABLE [dbo].[Drugs]  WITH CHECK ADD  CONSTRAINT [FK_Drugs_Producers] FOREIGN KEY([ProducerId])
REFERENCES [dbo].[Producers] ([ProducerID])
GO
ALTER TABLE [dbo].[Drugs] CHECK CONSTRAINT [FK_Drugs_Producers]
GO
ALTER TABLE [dbo].[Medications]  WITH CHECK ADD  CONSTRAINT [FK_Medications_PharmacologicalGroup] FOREIGN KEY([PharmacologicalGroup])
REFERENCES [dbo].[PharmacologicalGroup] ([PharmacologicalGroup])
GO
ALTER TABLE [dbo].[Medications] CHECK CONSTRAINT [FK_Medications_PharmacologicalGroup]
GO
USE [master]
GO
ALTER DATABASE [PharmacyCourseProject] SET  READ_WRITE 
GO
