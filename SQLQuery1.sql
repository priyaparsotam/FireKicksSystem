USE [Firekicks]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblOrderProcessing_FilterbyOrderID]
		@OrderID = NULL

SELECT	@return_value as 'Return Value'

GO
