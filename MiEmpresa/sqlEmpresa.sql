USE [master]
GO
/****** Object:  Database [Empresa_DB]    Script Date: 28/7/2022 15:46:02 ******/
CREATE DATABASE [Empresa_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Empresa_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Empresa_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Empresa_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Empresa_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Empresa_DB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Empresa_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Empresa_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Empresa_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Empresa_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Empresa_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Empresa_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [Empresa_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Empresa_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Empresa_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Empresa_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Empresa_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Empresa_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Empresa_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Empresa_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Empresa_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Empresa_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Empresa_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Empresa_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Empresa_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Empresa_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Empresa_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Empresa_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Empresa_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Empresa_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [Empresa_DB] SET  MULTI_USER 
GO
ALTER DATABASE [Empresa_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Empresa_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Empresa_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Empresa_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Empresa_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Empresa_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Empresa_DB', N'ON'
GO
ALTER DATABASE [Empresa_DB] SET QUERY_STORE = OFF
GO
USE [Empresa_DB]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 28/7/2022 15:46:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](250) NOT NULL,
	[APELLIDO] [varchar](250) NOT NULL,
	[SEXO] [varchar](250) NOT NULL,
	[FECHA_INGRESO] [date] NOT NULL,
	[ID_PUESTO] [int] NOT NULL,
	[ESTADO] [bit] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Puestos]    Script Date: 28/7/2022 15:46:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Puestos](
	[ID] [int] IDENTITY(1,11) NOT NULL,
	[DESCRIPCION] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Puestos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON 
GO
INSERT [dbo].[Empleados] ([ID], [NOMBRE], [APELLIDO], [SEXO], [FECHA_INGRESO], [ID_PUESTO], [ESTADO]) VALUES (6, N'Ramiro', N'Olicino', N'Masculino', CAST(N'2022-08-17' AS Date), 77, 0)
GO
INSERT [dbo].[Empleados] ([ID], [NOMBRE], [APELLIDO], [SEXO], [FECHA_INGRESO], [ID_PUESTO], [ESTADO]) VALUES (7, N'Juan', N'Xxxxx', N'Masculino', CAST(N'2021-02-22' AS Date), 77, 1)
GO
INSERT [dbo].[Empleados] ([ID], [NOMBRE], [APELLIDO], [SEXO], [FECHA_INGRESO], [ID_PUESTO], [ESTADO]) VALUES (8, N'Maria', N'Dalez', N'Femenino', CAST(N'2018-03-12' AS Date), 88, 1)
GO
INSERT [dbo].[Empleados] ([ID], [NOMBRE], [APELLIDO], [SEXO], [FECHA_INGRESO], [ID_PUESTO], [ESTADO]) VALUES (9, N'Roberto', N'Tropez', N'No Binario', CAST(N'2015-05-08' AS Date), 99, 1)
GO
INSERT [dbo].[Empleados] ([ID], [NOMBRE], [APELLIDO], [SEXO], [FECHA_INGRESO], [ID_PUESTO], [ESTADO]) VALUES (10, N'Claudia', N'Mochio', N'Femenino', CAST(N'2018-06-21' AS Date), 110, 0)
GO
INSERT [dbo].[Empleados] ([ID], [NOMBRE], [APELLIDO], [SEXO], [FECHA_INGRESO], [ID_PUESTO], [ESTADO]) VALUES (15, N'Zzzzz', N'Cccccc', N'Masculino', CAST(N'2022-07-28' AS Date), 77, 0)
GO
SET IDENTITY_INSERT [dbo].[Empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[Puestos] ON 
GO
INSERT [dbo].[Puestos] ([ID], [DESCRIPCION]) VALUES (66, N'Administracion')
GO
INSERT [dbo].[Puestos] ([ID], [DESCRIPCION]) VALUES (77, N'Cocina')
GO
INSERT [dbo].[Puestos] ([ID], [DESCRIPCION]) VALUES (88, N'Mozo')
GO
INSERT [dbo].[Puestos] ([ID], [DESCRIPCION]) VALUES (99, N'Limpieza')
GO
INSERT [dbo].[Puestos] ([ID], [DESCRIPCION]) VALUES (110, N'Recepcionista')
GO
SET IDENTITY_INSERT [dbo].[Puestos] OFF
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Puestos] FOREIGN KEY([ID_PUESTO])
REFERENCES [dbo].[Puestos] ([ID])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Puestos]
GO
USE [master]
GO
ALTER DATABASE [Empresa_DB] SET  READ_WRITE 
GO
