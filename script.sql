use master
go
create database SV21521252
go
USE [SV21521252]
GO

CREATE TABLE [dbo].[DanhSachKhachHang](
	[MSKH] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[BirthDay] [smalldatetime] NOT NULL,
	[NGDK] [smalldatetime] NOT NULL,
)
GO
INSERT [dbo].[DanhSachKhachHang] ([MSKH], [Name], [BirthDay], [NGDK]) VALUES (N'12', N'Lý Tiểu Long', CAST(N'2022-12-01T00:00:00' AS SmallDateTime), CAST(N'2022-12-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[DanhSachKhachHang] ([MSKH], [Name], [BirthDay], [NGDK]) VALUES (N'2', N'Lý Bá Kỳ', CAST(N'2022-12-11T00:00:00' AS SmallDateTime), CAST(N'2022-12-12T00:00:00' AS SmallDateTime))
INSERT [dbo].[DanhSachKhachHang] ([MSKH], [Name], [BirthDay], [NGDK]) VALUES (N'3', N'Lý Khánh', CAST(N'2022-12-06T00:00:00' AS SmallDateTime), CAST(N'2022-12-07T00:00:00' AS SmallDateTime))
GO
