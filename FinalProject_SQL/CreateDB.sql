USE [master]
GO

CREATE DATABASE [Orders]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Orders', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Orders.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB ), 
 FILEGROUP [SECONDARY]  DEFAULT
( NAME = N'Orders_act', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Orders_act.ndf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Orders_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Orders_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO


GO
USE [Orders]
GO

/****** Object:  Table [dbo].[Gifts]    Script Date: 29.01.2022 17:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[HouseNameShort] [nvarchar](50) NOT NULL,
	[OrdertTextShort] [nvarchar](50) NOT NULL,
	[OrderURL] [text] NULL,
	[DeliveryDate] [date] NULL,
 CONSTRAINT [Id] PRIMARY KEY CLUSTERED ([Id] ASC))
GO
INSERT INTO dbo.[Orders]([FirstName], [LastName], [HouseNameShort], [OrdertTextShort], [OrderURL], [DeliveryDate])
  VALUES ('Иван', 'Иванов', 'Дом 1', 'Книга', 'www.ozon.ru', '2022-12-20'),
		 ('Петр', 'Петров', 'Дом 1', 'Часы', 'www.ozon.ru', '2022-12-20'),
		 ('Сидор', 'Сидоров', 'Дом 2', 'Мяч', 'www.ozon.ru', '2022-12-20')

Go
Select * from [dbo].[Orders]