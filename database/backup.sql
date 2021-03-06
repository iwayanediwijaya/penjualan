USE [db_ti15e]
GO
/****** Object:  View [dbo].[vw_detail_transaksi]    Script Date: 03/03/2017 14:39:45 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_detail_transaksi]'))
DROP VIEW [dbo].[vw_detail_transaksi]
GO
/****** Object:  View [dbo].[vw_transaksi]    Script Date: 03/03/2017 14:39:45 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_transaksi]'))
DROP VIEW [dbo].[vw_transaksi]
GO
/****** Object:  Table [dbo].[tbl_barang]    Script Date: 03/03/2017 14:39:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_barang]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_barang]
GO
/****** Object:  Table [dbo].[tbl_detail_transaksi]    Script Date: 03/03/2017 14:39:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_detail_transaksi]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_detail_transaksi]
GO
/****** Object:  Table [dbo].[tbl_pelanggan]    Script Date: 03/03/2017 14:39:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_pelanggan]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_pelanggan]
GO
/****** Object:  Table [dbo].[tbl_transaksi]    Script Date: 03/03/2017 14:39:44 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_transaksi]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_transaksi]
GO
USE [master]
GO
/****** Object:  Login [##MS_PolicyEventProcessingLogin##]    Script Date: 03/03/2017 14:39:45 ******/
IF  EXISTS (SELECT * FROM sys.server_principals WHERE name = N'##MS_PolicyEventProcessingLogin##')
DROP LOGIN [##MS_PolicyEventProcessingLogin##]
GO
/****** Object:  Login [##MS_PolicyTsqlExecutionLogin##]    Script Date: 03/03/2017 14:39:46 ******/
IF  EXISTS (SELECT * FROM sys.server_principals WHERE name = N'##MS_PolicyTsqlExecutionLogin##')
DROP LOGIN [##MS_PolicyTsqlExecutionLogin##]
GO
/****** Object:  Login [BUILTIN\Users]    Script Date: 03/03/2017 14:39:46 ******/
IF  EXISTS (SELECT * FROM sys.server_principals WHERE name = N'BUILTIN\Users')
DROP LOGIN [BUILTIN\Users]
GO
/****** Object:  Login [mahasiswa-PC\mahasiswa]    Script Date: 03/03/2017 14:39:46 ******/
IF  EXISTS (SELECT * FROM sys.server_principals WHERE name = N'mahasiswa-PC\mahasiswa')
DROP LOGIN [mahasiswa-PC\mahasiswa]
GO
/****** Object:  Login [NT AUTHORITY\SYSTEM]    Script Date: 03/03/2017 14:39:46 ******/
IF  EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT AUTHORITY\SYSTEM')
DROP LOGIN [NT AUTHORITY\SYSTEM]
GO
/****** Object:  Login [NT SERVICE\MSSQL$SQLEXPRESS]    Script Date: 03/03/2017 14:39:46 ******/
IF  EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\MSSQL$SQLEXPRESS')
DROP LOGIN [NT SERVICE\MSSQL$SQLEXPRESS]
GO
/****** Object:  Login [##MS_PolicyEventProcessingLogin##]    Script Date: 03/03/2017 14:39:45 ******/
/* For security reasons the login is created disabled and with a random password. */
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'##MS_PolicyEventProcessingLogin##')
CREATE LOGIN [##MS_PolicyEventProcessingLogin##] WITH PASSWORD=N'ÚríÇÖÜ)ó#ím#ùu!:¬wMnÇ^ð¡qB', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyEventProcessingLogin##] DISABLE
GO
/****** Object:  Login [##MS_PolicyTsqlExecutionLogin##]    Script Date: 03/03/2017 14:39:46 ******/
/* For security reasons the login is created disabled and with a random password. */
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'##MS_PolicyTsqlExecutionLogin##')
CREATE LOGIN [##MS_PolicyTsqlExecutionLogin##] WITH PASSWORD=N'ï¾Þ­]ÉZ/®WYùVÆíÅðî¡ñHkÅgj±m5', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyTsqlExecutionLogin##] DISABLE
GO
/****** Object:  Login [BUILTIN\Users]    Script Date: 03/03/2017 14:39:46 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'BUILTIN\Users')
CREATE LOGIN [BUILTIN\Users] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [mahasiswa-PC\mahasiswa]    Script Date: 03/03/2017 14:39:46 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'mahasiswa-PC\mahasiswa')
CREATE LOGIN [mahasiswa-PC\mahasiswa] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT AUTHORITY\SYSTEM]    Script Date: 03/03/2017 14:39:46 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT AUTHORITY\SYSTEM')
CREATE LOGIN [NT AUTHORITY\SYSTEM] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\MSSQL$SQLEXPRESS]    Script Date: 03/03/2017 14:39:46 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\MSSQL$SQLEXPRESS')
CREATE LOGIN [NT SERVICE\MSSQL$SQLEXPRESS] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
USE [db_ti15e]
GO
/****** Object:  Table [dbo].[tbl_transaksi]    Script Date: 03/03/2017 14:39:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_transaksi]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_transaksi](
	[no_faktur] [char](15) COLLATE Latin1_General_CI_AS NOT NULL,
	[tgl_faktur] [date] NOT NULL,
	[kode_pelanggan] [char](10) COLLATE Latin1_General_CI_AS NOT NULL,
	[total_faktur] [int] NOT NULL,
 CONSTRAINT [PK_tbl_transaksi] PRIMARY KEY CLUSTERED 
(
	[no_faktur] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_pelanggan]    Script Date: 03/03/2017 14:39:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_pelanggan]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_pelanggan](
	[kode_pelanggan] [char](10) COLLATE Latin1_General_CI_AS NOT NULL,
	[nama_pelanggan] [varchar](40) COLLATE Latin1_General_CI_AS NOT NULL,
	[alamat] [varchar](100) COLLATE Latin1_General_CI_AS NOT NULL,
	[no_telepon] [varchar](12) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_tbl_pelanggan] PRIMARY KEY CLUSTERED 
(
	[kode_pelanggan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_pelanggan] ([kode_pelanggan], [nama_pelanggan], [alamat], [no_telepon]) VALUES (N'kd01      ', N'wayan', N'lamsel', N'081224768909')
INSERT [dbo].[tbl_pelanggan] ([kode_pelanggan], [nama_pelanggan], [alamat], [no_telepon]) VALUES (N'kd02      ', N'edi', N'lamtim', N'081245657854')
INSERT [dbo].[tbl_pelanggan] ([kode_pelanggan], [nama_pelanggan], [alamat], [no_telepon]) VALUES (N'kd03      ', N'wijaya', N'bandar lampung', N'081234534345')
INSERT [dbo].[tbl_pelanggan] ([kode_pelanggan], [nama_pelanggan], [alamat], [no_telepon]) VALUES (N'kd04      ', N'kusuma', N'metro', N'081267768998')
INSERT [dbo].[tbl_pelanggan] ([kode_pelanggan], [nama_pelanggan], [alamat], [no_telepon]) VALUES (N'kd05      ', N'ridwan', N'teluk', N'081258859669')
INSERT [dbo].[tbl_pelanggan] ([kode_pelanggan], [nama_pelanggan], [alamat], [no_telepon]) VALUES (N'kd06      ', N'ayu', N'jauh', N'081521123223')
INSERT [dbo].[tbl_pelanggan] ([kode_pelanggan], [nama_pelanggan], [alamat], [no_telepon]) VALUES (N'kd07      ', N'wawan', N'garuntang', N'081623234343')
INSERT [dbo].[tbl_pelanggan] ([kode_pelanggan], [nama_pelanggan], [alamat], [no_telepon]) VALUES (N'kd08      ', N'kaka', N'kedaton', N'081621345678')
INSERT [dbo].[tbl_pelanggan] ([kode_pelanggan], [nama_pelanggan], [alamat], [no_telepon]) VALUES (N'kd09      ', N'joko', N'jawa', N'081624423553')
/****** Object:  Table [dbo].[tbl_detail_transaksi]    Script Date: 03/03/2017 14:39:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_detail_transaksi]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_detail_transaksi](
	[no_faktur] [char](15) COLLATE Latin1_General_CI_AS NOT NULL,
	[kode_barang] [char](10) COLLATE Latin1_General_CI_AS NOT NULL,
	[qty] [int] NOT NULL,
 CONSTRAINT [PK_tbl_detail_transaksi] PRIMARY KEY CLUSTERED 
(
	[no_faktur] ASC,
	[kode_barang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_barang]    Script Date: 03/03/2017 14:39:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_barang]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_barang](
	[kode_barang] [char](10) COLLATE Latin1_General_CI_AS NOT NULL,
	[nama_barang] [varchar](40) COLLATE Latin1_General_CI_AS NOT NULL,
	[satuan] [varchar](15) COLLATE Latin1_General_CI_AS NOT NULL,
	[harga] [int] NOT NULL,
	[stock] [int] NOT NULL,
 CONSTRAINT [PK_tbl_barang] PRIMARY KEY CLUSTERED 
(
	[kode_barang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_barang] ([kode_barang], [nama_barang], [satuan], [harga], [stock]) VALUES (N'kd001     ', N'harddisk', N'unit', 50000, 5)
INSERT [dbo].[tbl_barang] ([kode_barang], [nama_barang], [satuan], [harga], [stock]) VALUES (N'kd002     ', N'flashdisk', N'unit', 45000, 10)
INSERT [dbo].[tbl_barang] ([kode_barang], [nama_barang], [satuan], [harga], [stock]) VALUES (N'kd003     ', N'monitor', N'unit', 100000, 3)
INSERT [dbo].[tbl_barang] ([kode_barang], [nama_barang], [satuan], [harga], [stock]) VALUES (N'kd004     ', N'mouse', N'unit', 35000, 5)
INSERT [dbo].[tbl_barang] ([kode_barang], [nama_barang], [satuan], [harga], [stock]) VALUES (N'kd005     ', N'keyboard', N'unit', 40000, 6)
INSERT [dbo].[tbl_barang] ([kode_barang], [nama_barang], [satuan], [harga], [stock]) VALUES (N'kd006     ', N'cpu', N'unit', 500000, 7)
INSERT [dbo].[tbl_barang] ([kode_barang], [nama_barang], [satuan], [harga], [stock]) VALUES (N'kd007     ', N'ram', N'unit', 200000, 8)
INSERT [dbo].[tbl_barang] ([kode_barang], [nama_barang], [satuan], [harga], [stock]) VALUES (N'kd008     ', N'motherboard', N'unit', 300000, 3)
INSERT [dbo].[tbl_barang] ([kode_barang], [nama_barang], [satuan], [harga], [stock]) VALUES (N'kd009     ', N'laptop', N'unit', 2000000, 5)
INSERT [dbo].[tbl_barang] ([kode_barang], [nama_barang], [satuan], [harga], [stock]) VALUES (N'kd010     ', N'processor', N'unit', 350000, 6)
/****** Object:  View [dbo].[vw_transaksi]    Script Date: 03/03/2017 14:39:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_transaksi]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vw_transaksi]
AS
SELECT     dbo.tbl_transaksi.no_faktur, dbo.tbl_transaksi.tgl_faktur, dbo.tbl_transaksi.kode_pelanggan, dbo.tbl_pelanggan.nama_pelanggan, dbo.tbl_pelanggan.alamat, 
                      dbo.tbl_pelanggan.no_telepon, dbo.tbl_transaksi.total_faktur
FROM         dbo.tbl_pelanggan INNER JOIN
                      dbo.tbl_transaksi ON dbo.tbl_pelanggan.kode_pelanggan = dbo.tbl_transaksi.kode_pelanggan
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vw_transaksi', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_pelanggan"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 209
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_transaksi"
            Begin Extent = 
               Top = 6
               Left = 247
               Bottom = 125
               Right = 415
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_transaksi'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vw_transaksi', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_transaksi'
GO
/****** Object:  View [dbo].[vw_detail_transaksi]    Script Date: 03/03/2017 14:39:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_detail_transaksi]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vw_detail_transaksi]
AS
SELECT     dbo.tbl_detail_transaksi.no_faktur, dbo.tbl_detail_transaksi.kode_barang, dbo.tbl_barang.nama_barang, dbo.tbl_barang.satuan, dbo.tbl_barang.harga, 
                      dbo.tbl_barang.stock, dbo.tbl_detail_transaksi.qty, dbo.tbl_barang.harga * dbo.tbl_detail_transaksi.qty AS total_harga
FROM         dbo.tbl_barang INNER JOIN
                      dbo.tbl_detail_transaksi ON dbo.tbl_barang.kode_barang = dbo.tbl_detail_transaksi.kode_barang
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vw_detail_transaksi', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_barang"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "tbl_detail_transaksi"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 110
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_detail_transaksi'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vw_detail_transaksi', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_detail_transaksi'
GO
