CREATE DATABASE [Employee]
GO
USE [Employee]
GO
/****** Object:  Table [dbo].[ContractType]    Script Date: 27/10/2020 12:25:08 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ContractType]') AND type in (N'U'))
DROP TABLE [dbo].[ContractType]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 27/10/2020 12:25:08 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[__EFMigrationsHistory]') AND type in (N'U'))
DROP TABLE [dbo].[__EFMigrationsHistory]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 27/10/2020 12:25:08 ******/
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
/****** Object:  Table [dbo].[ContractType]    Script Date: 27/10/2020 12:25:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContractType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ContractTypeName] [varchar](50) NOT NULL,
	[Name] [varchar](250) NOT NULL,
	[AnnualSalary] [float] NOT NULL,
 CONSTRAINT [PK_ContractType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201026154256_Initial', N'2.1.14-servicing-32113')
GO
SET IDENTITY_INSERT [dbo].[ContractType] ON 
GO
INSERT [dbo].[ContractType] ([Id], [ContractTypeName], [Name], [AnnualSalary]) VALUES (1, N'HourlySalaryEmployee', N'Hourly', 12)
GO
INSERT [dbo].[ContractType] ([Id], [ContractTypeName], [Name], [AnnualSalary]) VALUES (3, N'MonthlySalaryEmployee', N'Monthly', 1)
GO
SET IDENTITY_INSERT [dbo].[ContractType] OFF
GO
