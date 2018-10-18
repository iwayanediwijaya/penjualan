-- ================================================
-- Template generated from Template Explorer using:
-- Create Trigger (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- See additional Create Trigger templates for more
-- examples of different Trigger statements.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER stock_bertambah ON tbl_detail_transaksi
FOR DELETE, UPDATE

AS 
BEGIN
	
	UPDATE tbl_barang SET stock = tbl_barang.stock +
	deleted.qty FROM DELETED where tbl_barang.Kode_barang =
	deleted.kode_barang
	
END
GO
