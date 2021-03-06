USE [master]
GO
/****** Object:  Database [GestionUsuarios]    Script Date: 16/11/2021 20:43:23 ******/
CREATE DATABASE [GestionUsuarios]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GestionUsuarios', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GestionUsuarios.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GestionUsuarios_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GestionUsuarios_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GestionUsuarios] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GestionUsuarios].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GestionUsuarios] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GestionUsuarios] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GestionUsuarios] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GestionUsuarios] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GestionUsuarios] SET ARITHABORT OFF 
GO
ALTER DATABASE [GestionUsuarios] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GestionUsuarios] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GestionUsuarios] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GestionUsuarios] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GestionUsuarios] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GestionUsuarios] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GestionUsuarios] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GestionUsuarios] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GestionUsuarios] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GestionUsuarios] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GestionUsuarios] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GestionUsuarios] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GestionUsuarios] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GestionUsuarios] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GestionUsuarios] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GestionUsuarios] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GestionUsuarios] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GestionUsuarios] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GestionUsuarios] SET  MULTI_USER 
GO
ALTER DATABASE [GestionUsuarios] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GestionUsuarios] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GestionUsuarios] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GestionUsuarios] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GestionUsuarios] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GestionUsuarios] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GestionUsuarios] SET QUERY_STORE = OFF
GO
USE [GestionUsuarios]
GO
/****** Object:  Table [dbo].[Formularios]    Script Date: 16/11/2021 20:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Formularios](
	[id_formulario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [int] NOT NULL,
 CONSTRAINT [PK_Formularios] PRIMARY KEY CLUSTERED 
(
	[id_formulario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistorialPerfilesUsuarios]    Script Date: 16/11/2021 20:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistorialPerfilesUsuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NOT NULL,
	[id_perfil] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_HistorialPerfilesUsuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistorialPermisos]    Script Date: 16/11/2021 20:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistorialPermisos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_formulario] [int] NOT NULL,
	[id_perfil] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[estado] [nchar](10) NULL,
 CONSTRAINT [PK_HistorialPermisos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 16/11/2021 20:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfiles](
	[id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [int] NOT NULL,
 CONSTRAINT [PK_Perfiles] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 16/11/2021 20:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos](
	[id_formulario] [int] NOT NULL,
	[id_perfil] [int] NOT NULL,
	[borrado] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 16/11/2021 20:43:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_perfil] [int] NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[email] [varchar](50) NULL,
	[estado] [varchar](50) NOT NULL,
	[borrado] [int] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Formularios]  WITH CHECK ADD  CONSTRAINT [FK_Formularios_Formularios] FOREIGN KEY([id_formulario])
REFERENCES [dbo].[Formularios] ([id_formulario])
GO
ALTER TABLE [dbo].[Formularios] CHECK CONSTRAINT [FK_Formularios_Formularios]
GO
ALTER TABLE [dbo].[HistorialPerfilesUsuarios]  WITH CHECK ADD  CONSTRAINT [FK_HistorialPerfilesUsuarios_Perfiles1] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[HistorialPerfilesUsuarios] CHECK CONSTRAINT [FK_HistorialPerfilesUsuarios_Perfiles1]
GO
ALTER TABLE [dbo].[HistorialPerfilesUsuarios]  WITH CHECK ADD  CONSTRAINT [FK_HistorialPerfilesUsuarios_Usuarios1] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[HistorialPerfilesUsuarios] CHECK CONSTRAINT [FK_HistorialPerfilesUsuarios_Usuarios1]
GO
ALTER TABLE [dbo].[HistorialPermisos]  WITH CHECK ADD  CONSTRAINT [FK_HistorialPermisos_Formularios] FOREIGN KEY([id_formulario])
REFERENCES [dbo].[Formularios] ([id_formulario])
GO
ALTER TABLE [dbo].[HistorialPermisos] CHECK CONSTRAINT [FK_HistorialPermisos_Formularios]
GO
ALTER TABLE [dbo].[HistorialPermisos]  WITH CHECK ADD  CONSTRAINT [FK_HistorialPermisos_Perfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[HistorialPermisos] CHECK CONSTRAINT [FK_HistorialPermisos_Perfiles]
GO
ALTER TABLE [dbo].[Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Permisos_Perfiles] FOREIGN KEY([id_formulario])
REFERENCES [dbo].[Formularios] ([id_formulario])
GO
ALTER TABLE [dbo].[Permisos] CHECK CONSTRAINT [FK_Permisos_Perfiles]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Perfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Perfiles]
GO
USE [master]
GO
ALTER DATABASE [GestionUsuarios] SET  READ_WRITE 
GO
