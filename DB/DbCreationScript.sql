USE [master]
GO
/****** Object:  Database [BinaryOperationsDb]    Script Date: 09/04/2025 01:05:19 ******/
CREATE DATABASE [BinaryOperationsDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BinaryOperations', FILENAME = N'C:\Users\P0035580\BinaryOperations.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BinaryOperations_log', FILENAME = N'C:\Users\P0035580\BinaryOperations_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BinaryOperationsDb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BinaryOperationsDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BinaryOperationsDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BinaryOperationsDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BinaryOperationsDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BinaryOperationsDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BinaryOperationsDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [BinaryOperationsDb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BinaryOperationsDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BinaryOperationsDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BinaryOperationsDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BinaryOperationsDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BinaryOperationsDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BinaryOperationsDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BinaryOperationsDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BinaryOperationsDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BinaryOperationsDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BinaryOperationsDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BinaryOperationsDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BinaryOperationsDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BinaryOperationsDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BinaryOperationsDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BinaryOperationsDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BinaryOperationsDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BinaryOperationsDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BinaryOperationsDb] SET  MULTI_USER 
GO
ALTER DATABASE [BinaryOperationsDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BinaryOperationsDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BinaryOperationsDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BinaryOperationsDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BinaryOperationsDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BinaryOperationsDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BinaryOperationsDb] SET QUERY_STORE = OFF
GO
USE [BinaryOperationsDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 09/04/2025 01:05:19 ******/
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
/****** Object:  Table [dbo].[CalculationHistory]    Script Date: 09/04/2025 01:05:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CalculationHistory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Value1] [nvarchar](max) NOT NULL,
	[Value2] [nvarchar](max) NOT NULL,
	[OperationId] [int] NOT NULL,
	[Result] [nvarchar](max) NOT NULL,
	[Operation] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedAt] [datetime2](7) NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_CalculationHistory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[operation_type]    Script Date: 09/04/2025 01:05:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[operation_type](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NULL,
	[CreatedBy] [int] NULL,
	[CreatedAt] [datetime2](7) NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_operation_type] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[parameter_type]    Script Date: 09/04/2025 01:05:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[parameter_type](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CreatedBy] [int] NULL,
	[CreatedAt] [datetime2](7) NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_parameter_type] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[parameter_type_operations]    Script Date: 09/04/2025 01:05:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[parameter_type_operations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OperationTypesId] [int] NULL,
	[ParameterTypesId] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedAt] [datetime2](7) NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_parameter_type_operations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET IDENTITY_INSERT [dbo].[CalculationHistory] ON 

INSERT [dbo].[CalculationHistory] ([Id], [Value1], [Value2], [OperationId], [Result], [Operation], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (1, N'string1', N'string2', 3, N'string1string2', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CalculationHistory] ([Id], [Value1], [Value2], [OperationId], [Result], [Operation], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (2, N'02.02.2020', N'15', 3, N'17/02/2020 00:00:00', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CalculationHistory] ([Id], [Value1], [Value2], [OperationId], [Result], [Operation], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (3, N'5', N'15', 3, N'20', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CalculationHistory] ([Id], [Value1], [Value2], [OperationId], [Result], [Operation], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (4, N'15', N'15', 6, N'1', NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[CalculationHistory] OFF
GO
SET IDENTITY_INSERT [dbo].[operation_type] ON 

INSERT [dbo].[operation_type] ([Id], [Name], [Description], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (3, N'add', N'+', NULL, NULL, NULL, NULL)
INSERT [dbo].[operation_type] ([Id], [Name], [Description], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (4, N'subtract', N'=', NULL, NULL, NULL, NULL)
INSERT [dbo].[operation_type] ([Id], [Name], [Description], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (5, N'multiply', N'*', NULL, NULL, NULL, NULL)
INSERT [dbo].[operation_type] ([Id], [Name], [Description], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (6, N'divide', N'\', NULL, NULL, NULL, NULL)
INSERT [dbo].[operation_type] ([Id], [Name], [Description], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (7, N'concat', N'concat', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[operation_type] OFF
GO
SET IDENTITY_INSERT [dbo].[parameter_type] ON 

INSERT [dbo].[parameter_type] ([Id], [Name], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (1, N'String', NULL, NULL, NULL, NULL)
INSERT [dbo].[parameter_type] ([Id], [Name], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (2, N'Date', NULL, NULL, NULL, NULL)
INSERT [dbo].[parameter_type] ([Id], [Name], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (3, N'Number', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[parameter_type] OFF
GO
SET IDENTITY_INSERT [dbo].[parameter_type_operations] ON 

INSERT [dbo].[parameter_type_operations] ([Id], [OperationTypesId], [ParameterTypesId], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (3, 7, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[parameter_type_operations] ([Id], [OperationTypesId], [ParameterTypesId], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (4, 3, 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[parameter_type_operations] ([Id], [OperationTypesId], [ParameterTypesId], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (5, 4, 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[parameter_type_operations] ([Id], [OperationTypesId], [ParameterTypesId], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (6, 5, 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[parameter_type_operations] ([Id], [OperationTypesId], [ParameterTypesId], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (7, 6, 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[parameter_type_operations] ([Id], [OperationTypesId], [ParameterTypesId], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (8, 3, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[parameter_type_operations] ([Id], [OperationTypesId], [ParameterTypesId], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (9, 4, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[parameter_type_operations] ([Id], [OperationTypesId], [ParameterTypesId], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (10, 3, 1, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[parameter_type_operations] OFF
GO
/****** Object:  Index [IX_parameter_type_operations_OperationTypesId]    Script Date: 09/04/2025 01:05:19 ******/
CREATE NONCLUSTERED INDEX [IX_parameter_type_operations_OperationTypesId] ON [dbo].[parameter_type_operations]
(
	[OperationTypesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_parameter_type_operations_ParameterTypesId]    Script Date: 09/04/2025 01:05:19 ******/
CREATE NONCLUSTERED INDEX [IX_parameter_type_operations_ParameterTypesId] ON [dbo].[parameter_type_operations]
(
	[ParameterTypesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[parameter_type_operations]  WITH CHECK ADD  CONSTRAINT [FK_parameter_type_operations_operation_type_OperationTypesId] FOREIGN KEY([OperationTypesId])
REFERENCES [dbo].[operation_type] ([Id])
GO
ALTER TABLE [dbo].[parameter_type_operations] CHECK CONSTRAINT [FK_parameter_type_operations_operation_type_OperationTypesId]
GO
ALTER TABLE [dbo].[parameter_type_operations]  WITH CHECK ADD  CONSTRAINT [FK_parameter_type_operations_parameter_type_ParameterTypesId] FOREIGN KEY([ParameterTypesId])
REFERENCES [dbo].[parameter_type] ([Id])
GO
ALTER TABLE [dbo].[parameter_type_operations] CHECK CONSTRAINT [FK_parameter_type_operations_parameter_type_ParameterTypesId]
GO
USE [master]
GO
ALTER DATABASE [BinaryOperationsDb] SET  READ_WRITE 
GO
