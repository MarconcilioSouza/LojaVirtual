

USE [master]
GO

/****** Object:  Database [LojaVirtual]    Script Date: 28/11/2017 09:05:03 ******/
CREATE DATABASE [LojaVirtual] ON  PRIMARY 
( NAME = N'LojaVirtual', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\LojaVirtual.mdf' , SIZE = 3328KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LojaVirtual_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\LojaVirtual_log.LDF' , SIZE = 2112KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [LojaVirtual] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LojaVirtual].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [LojaVirtual] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [LojaVirtual] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [LojaVirtual] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [LojaVirtual] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [LojaVirtual] SET ARITHABORT OFF 
GO

ALTER DATABASE [LojaVirtual] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [LojaVirtual] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [LojaVirtual] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [LojaVirtual] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [LojaVirtual] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [LojaVirtual] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [LojaVirtual] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [LojaVirtual] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [LojaVirtual] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [LojaVirtual] SET  ENABLE_BROKER 
GO

ALTER DATABASE [LojaVirtual] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [LojaVirtual] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [LojaVirtual] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [LojaVirtual] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [LojaVirtual] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [LojaVirtual] SET READ_COMMITTED_SNAPSHOT ON 
GO

ALTER DATABASE [LojaVirtual] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [LojaVirtual] SET RECOVERY FULL 
GO

ALTER DATABASE [LojaVirtual] SET  MULTI_USER 
GO

ALTER DATABASE [LojaVirtual] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [LojaVirtual] SET DB_CHAINING OFF 
GO

ALTER DATABASE [LojaVirtual] SET  READ_WRITE 
GO


