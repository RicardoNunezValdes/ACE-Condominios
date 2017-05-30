SELECT TOP 1000 *  FROM Cfg_ProductoCompaniaFormaPago where ProductoID = '00000000-0000-0000-0000-000000000969'

SELECT TOP 1000 *  FROM Bus_PlanPago

SELECT TOP 1000 *  from Cfg_ProductoCompaniaFormaPago where ProductoID = '00000000-0000-0000-0000-000000000969'

SELECT TOP 1000 *  from Par_CompaniaSeguro

SELECT TOP 1000 *  from Par_FormaPago

SELECT TOP 1000 *  from Cfg_TablaInteres

SELECT TOP 1000 *  from Cfg_DiasFormaPago where ProductoID = '00000000-0000-0000-0000-000000000969'

SELECT TOP 1000 *  from dbo.Bus_Producto

SELECT * FROM Cfg_ProductoCompania where ProductoID in (SELECT ProductoID from Cfg_DiasFormaPago where ProductoID = '00000000-0000-0270-0000-000000000001')

SELECT TOP 1000 *  from Cfg_FinancieraFormaPago  where ProductoID = '00000000-0000-0000-0000-000000000969'

SELECT TOP 1000 *  from Cfg_PeriodicidadFormaPago where ProductoID = '00000000-0000-0000-0000-000000000969'

SELECT TOP 1000 *  from Par_Periodicidad



