USE [master]
GO
/****** Object:  Database [SatısProgrami] ******/
CREATE DATABASE [SatısProgrami]
GO
ALTER DATABASE [SatısProgrami] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SatısProgrami].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SatısProgrami] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SatısProgrami] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SatısProgrami] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SatısProgrami] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SatısProgrami] SET ARITHABORT OFF 
GO
ALTER DATABASE [SatısProgrami] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SatısProgrami] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SatısProgrami] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SatısProgrami] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SatısProgrami] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SatısProgrami] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SatısProgrami] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SatısProgrami] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SatısProgrami] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SatısProgrami] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SatısProgrami] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SatısProgrami] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SatısProgrami] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SatısProgrami] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SatısProgrami] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SatısProgrami] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SatısProgrami] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SatısProgrami] SET RECOVERY FULL 
GO
ALTER DATABASE [SatısProgrami] SET  MULTI_USER 
GO
ALTER DATABASE [SatısProgrami] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SatısProgrami] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SatısProgrami] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SatısProgrami] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SatısProgrami] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SatısProgrami] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SatısProgrami', N'ON'
GO
ALTER DATABASE [SatısProgrami] SET QUERY_STORE = OFF
GO
USE [SatısProgrami]
GO
/****** Object:  Table [dbo].[Musteriler] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteriler](
	[MusteriId] [int] IDENTITY(1,1) NOT NULL,
	[MusteriAd] [nvarchar](30) NULL,
	[MusteriTelefon] [nvarchar](11) NULL,
	[MusteriAdres] [nvarchar](100) NULL,
	[MusteriEmail] [nvarchar](30) NULL,
	[MusteriTarih] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urunler] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urunler](
	[UrunId] [int] IDENTITY(1,1) NOT NULL,
	[UrunAd] [nvarchar](50) NULL,
	[UrunMarka] [nvarchar](20) NULL,
	[UrunMiktar] [float] NULL,
	[UrunKategori] [nvarchar](50) NULL,
	[UrunAciklama] [nvarchar](100) NULL,
	[UrunTarih] [datetime] NULL,
	[UrunFiyat] [float] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Musteriler] ON 

INSERT [dbo].[Musteriler] ([MusteriId], [MusteriAd], [MusteriTelefon], [MusteriAdres], [MusteriEmail], [MusteriTarih]) VALUES (13, N'Özge', N'05222222222', N'İstanbul / Avcılar.', N'ozge@gmail.com', CAST(N'2022-06-04T13:00:42.237' AS DateTime))
INSERT [dbo].[Musteriler] ([MusteriId], [MusteriAd], [MusteriTelefon], [MusteriAdres], [MusteriEmail], [MusteriTarih]) VALUES (15, N'Ayato', N'05888888888', N'İstanbul / Avcılar.', N'Aya@gmail.com', CAST(N'2022-06-04T19:24:05.007' AS DateTime))
SET IDENTITY_INSERT [dbo].[Musteriler] OFF
GO
SET IDENTITY_INSERT [dbo].[Urunler] ON 

INSERT [dbo].[Urunler] ([UrunId], [UrunAd], [UrunMarka], [UrunMiktar], [UrunKategori], [UrunAciklama], [UrunTarih], [UrunFiyat]) VALUES (12, N'Harry Potter Figur', N'Toyzz Shop', 2, N'Eğlence', N'Efsane', CAST(N'2022-06-07T05:00:09.773' AS DateTime), 350)
INSERT [dbo].[Urunler] ([UrunId], [UrunAd], [UrunMarka], [UrunMiktar], [UrunKategori], [UrunAciklama], [UrunTarih], [UrunFiyat]) VALUES (9, N'RTX3090', N'Nvidia', 23, N'Teknoloji', N'Ucuyooo', CAST(N'2022-06-04T14:23:31.130' AS DateTime), 50000)
INSERT [dbo].[Urunler] ([UrunId], [UrunAd], [UrunMarka], [UrunMiktar], [UrunKategori], [UrunAciklama], [UrunTarih], [UrunFiyat]) VALUES (14, N'Haydar Akın Üniforma', N'Haydar Akın', 11, N'Giysi', N'Evt', CAST(N'2022-06-07T05:01:23.990' AS DateTime), 200)
INSERT [dbo].[Urunler] ([UrunId], [UrunAd], [UrunMarka], [UrunMiktar], [UrunKategori], [UrunAciklama], [UrunTarih], [UrunFiyat]) VALUES (15, N'Suç ve Ceza', N'Kitap', 14, N'Kitap', N'Herkesokusunabi', CAST(N'2022-06-07T05:02:35.207' AS DateTime), 40)
SET IDENTITY_INSERT [dbo].[Urunler] OFF
GO
USE [master]
GO
ALTER DATABASE [SatısProgrami] SET  READ_WRITE 
GO
