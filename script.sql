create database SV21521252
go
USE SV21521252
GO
CREATE TABLE [dbo].[DanhSachKhachHang](
	[MSKH] [nvarchar](50) Primary Key,
	[Name] [nvarchar](max) NOT NULL,
	[BirthDay] [smalldatetime] NOT NULL,
	[NGDK] [smalldatetime] NOT NULL,
)
GO
INSERT [dbo].[DanhSachKhachHang] ([MSKH], [Name], [BirthDay], [NGDK]) VALUES (N'1', N'NN', CAST(N'2001-01-01T00:00:00' AS SmallDateTime), CAST(N'2002-02-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[DanhSachKhachHang] ([MSKH], [Name], [BirthDay], [NGDK]) VALUES (N'2', N'NN', CAST(N'2001-01-01T00:00:00' AS SmallDateTime), CAST(N'2002-02-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[DanhSachKhachHang] ([MSKH], [Name], [BirthDay], [NGDK]) VALUES (N'3', N'NN', CAST(N'2001-01-01T00:00:00' AS SmallDateTime), CAST(N'2002-02-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[DanhSachKhachHang] ([MSKH], [Name], [BirthDay], [NGDK]) VALUES (N'4', N'NN', CAST(N'2001-01-01T00:00:00' AS SmallDateTime), CAST(N'2002-02-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[DanhSachKhachHang] ([MSKH], [Name], [BirthDay], [NGDK]) VALUES (N'6', N'NN', CAST(N'2001-01-01T00:00:00' AS SmallDateTime), CAST(N'2002-02-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[DanhSachKhachHang] ([MSKH], [Name], [BirthDay], [NGDK]) VALUES (N'7', N'NN', CAST(N'2001-01-01T00:00:00' AS SmallDateTime), CAST(N'2002-02-02T00:00:00' AS SmallDateTime))
GO
