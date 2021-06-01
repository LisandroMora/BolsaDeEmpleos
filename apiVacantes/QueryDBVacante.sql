USE [master]
GO
/****** Object:  Database [DBVacantes]    Script Date: 01/06/2021 15:17:56 ******/
CREATE DATABASE [DBVacantes]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBVacantes', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DBVacantes.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBVacantes_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DBVacantes_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DBVacantes] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBVacantes].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBVacantes] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBVacantes] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBVacantes] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBVacantes] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBVacantes] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBVacantes] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBVacantes] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBVacantes] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBVacantes] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBVacantes] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBVacantes] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBVacantes] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBVacantes] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBVacantes] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBVacantes] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DBVacantes] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBVacantes] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBVacantes] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBVacantes] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBVacantes] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBVacantes] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBVacantes] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBVacantes] SET RECOVERY FULL 
GO
ALTER DATABASE [DBVacantes] SET  MULTI_USER 
GO
ALTER DATABASE [DBVacantes] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBVacantes] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBVacantes] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBVacantes] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBVacantes] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBVacantes', N'ON'
GO
ALTER DATABASE [DBVacantes] SET QUERY_STORE = OFF
GO
USE [DBVacantes]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 01/06/2021 15:17:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[idCategoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo]    Script Date: 01/06/2021 15:17:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo](
	[idTipo] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trabajos]    Script Date: 01/06/2021 15:17:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trabajos](
	[idTrabajo] [int] IDENTITY(1,1) NOT NULL,
	[idCategoria] [int] NULL,
	[fecha] [date] NULL,
	[ubicacion] [varchar](100) NULL,
	[posicion] [varchar](100) NULL,
	[empresa] [varchar](100) NULL,
	[idTipo] [int] NULL,
	[logo] [image] NULL,
	[urlString] [varchar](500) NULL,
	[descripcion] [varchar](500) NULL,
	[email] [varchar](50) NULL,
	[comoAplicar] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[idTrabajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 
GO
INSERT [dbo].[Categoria] ([idCategoria], [nombre]) VALUES (1, N'TI')
GO
INSERT [dbo].[Categoria] ([idCategoria], [nombre]) VALUES (2, N'Marketing')
GO
INSERT [dbo].[Categoria] ([idCategoria], [nombre]) VALUES (3, N'Desarrollo Web')
GO
INSERT [dbo].[Categoria] ([idCategoria], [nombre]) VALUES (4, N'Analisis de Datos')
GO
INSERT [dbo].[Categoria] ([idCategoria], [nombre]) VALUES (5, N'Community Manager')
GO
SET IDENTITY_INSERT [dbo].[Categoria] OFF
GO
INSERT [dbo].[Tipo] ([idTipo], [nombre]) VALUES (1, N'full-time')
GO
INSERT [dbo].[Tipo] ([idTipo], [nombre]) VALUES (2, N'part-time')
GO
INSERT [dbo].[Tipo] ([idTipo], [nombre]) VALUES (3, N'freelance')
GO
SET IDENTITY_INSERT [dbo].[Trabajos] ON 
GO
INSERT [dbo].[Trabajos] ([idTrabajo], [idCategoria], [fecha], [ubicacion], [posicion], [empresa], [idTipo], [logo], [urlString], [descripcion], [email], [comoAplicar]) VALUES (1, 1, CAST(N'2021-06-01' AS Date), N'Rep Dom', N'Gerente', N'GBH', 1, NULL, N'asdasd', N'Gerente de TI', N'lisandro06@gmail.com', N'Mandar CV')
GO
INSERT [dbo].[Trabajos] ([idTrabajo], [idCategoria], [fecha], [ubicacion], [posicion], [empresa], [idTipo], [logo], [urlString], [descripcion], [email], [comoAplicar]) VALUES (2, 2, CAST(N'2020-05-09' AS Date), N'Santiago', N'Jefe', N'Claro', 2, NULL, N'asdasd', N'Jefe publicitario', N'claro@vacante.es', N'Ir a la sucursal')
GO
INSERT [dbo].[Trabajos] ([idTrabajo], [idCategoria], [fecha], [ubicacion], [posicion], [empresa], [idTipo], [logo], [urlString], [descripcion], [email], [comoAplicar]) VALUES (3, 3, CAST(N'2021-02-04' AS Date), N'Santo Domingo Este', N'Desarrollador JR', N'Banco Popular', 3, NULL, N'asdasd', N'Desarrollador JR .NET', N'rafa@gmail.com', N'Mandar email')
GO
INSERT [dbo].[Trabajos] ([idTrabajo], [idCategoria], [fecha], [ubicacion], [posicion], [empresa], [idTipo], [logo], [urlString], [descripcion], [email], [comoAplicar]) VALUES (4, 3, CAST(N'2021-02-04' AS Date), N'Santo Domingo Norte', N'Desarrollador SR', N'Banco BHD', 3, NULL, N'asdasd', N'Desarrollador JR .NET', N'rafa@gmail.com', N'Mandar email')
GO
SET IDENTITY_INSERT [dbo].[Trabajos] OFF
GO
ALTER TABLE [dbo].[Trabajos]  WITH CHECK ADD FOREIGN KEY([idCategoria])
REFERENCES [dbo].[Categoria] ([idCategoria])
GO
ALTER TABLE [dbo].[Trabajos]  WITH CHECK ADD FOREIGN KEY([idTipo])
REFERENCES [dbo].[Tipo] ([idTipo])
GO
USE [master]
GO
ALTER DATABASE [DBVacantes] SET  READ_WRITE 
GO
