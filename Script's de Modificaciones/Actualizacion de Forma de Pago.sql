INSERT INTO Cfg_ProductoCompaniaFormaPago VALUES ('00000000-0000-0000-0000-000000000969',1,5,120,0,10,'00000000-0000-0000-0000-000000000000',1,1,0,0,0,0,0) -- Creado OK
INSERT INTO Cfg_ProductoCompaniaFormaPago VALUES ('00000000-0000-0000-0000-000000000969',1,5,130,0,10,'00000000-0000-0000-0000-000000000000',1,1,1,0,0,0,0) -- Creado OK

select * from Cfg_ProductoCompaniaFormaPago where ProductoID = '00000000-0000-0000-0000-000000000969'

INSERT INTO Cfg_PeriodicidadFormaPago VALUES(120,5,1,'00000000-0000-0000-0000-000000000969',120) -- PAC Cargo Cuenta Corriente
INSERT INTO Cfg_PeriodicidadFormaPago VALUES(120,5,1,'00000000-0000-0000-0000-000000000969',130) -- PAT Cargo Tarjeta de Crédito

-- Dias de pago PAC Cargo Cuenta Corriente
INSERT INTO Cfg_DiasFormaPago(ProductoID,CompaniaID,Version,FomaPagoID,Dia) VALUES ('00000000-0000-0000-0000-000000000969',5,1,120,5);
INSERT INTO Cfg_DiasFormaPago(ProductoID,CompaniaID,Version,FomaPagoID,Dia) VALUES ('00000000-0000-0000-0000-000000000969',5,1,120,10);
INSERT INTO Cfg_DiasFormaPago(ProductoID,CompaniaID,Version,FomaPagoID,Dia) VALUES ('00000000-0000-0000-0000-000000000969',5,1,120,15);
INSERT INTO Cfg_DiasFormaPago(ProductoID,CompaniaID,Version,FomaPagoID,Dia) VALUES ('00000000-0000-0000-0000-000000000969',5,1,120,20);

-- Dias de pago PAT	Cargo Tarjeta de Crédito
INSERT INTO Cfg_DiasFormaPago(ProductoID,CompaniaID,Version,FomaPagoID,Dia) VALUES ('00000000-0000-0000-0000-000000000969',5,1,130,5);
INSERT INTO Cfg_DiasFormaPago(ProductoID,CompaniaID,Version,FomaPagoID,Dia) VALUES ('00000000-0000-0000-0000-000000000969',5,1,130,10);
INSERT INTO Cfg_DiasFormaPago(ProductoID,CompaniaID,Version,FomaPagoID,Dia) VALUES ('00000000-0000-0000-0000-000000000969',5,1,130,15);
INSERT INTO Cfg_DiasFormaPago(ProductoID,CompaniaID,Version,FomaPagoID,Dia) VALUES ('00000000-0000-0000-0000-000000000969',5,1,130,20);

--  Tarjeta Forma de Pag PAT	Cargo Tarjeta de Crédito
INSERT INTO Cfg_TarjetaFormaPago(ProductoID,CompaniaID,Version,TipoTarjetaID,FomaPagoID) VALUES  ('00000000-0000-0000-0000-000000000969',5,1,1,120) -- Visa
INSERT INTO Cfg_TarjetaFormaPago(ProductoID,CompaniaID,Version,TipoTarjetaID,FomaPagoID) VALUES  ('00000000-0000-0000-0000-000000000969',5,1,2,120) -- MasterCard
INSERT INTO Cfg_TarjetaFormaPago(ProductoID,CompaniaID,Version,TipoTarjetaID,FomaPagoID) VALUES  ('00000000-0000-0000-0000-000000000969',5,1,3,120) -- Diners
INSERT INTO Cfg_TarjetaFormaPago(ProductoID,CompaniaID,Version,TipoTarjetaID,FomaPagoID) VALUES  ('00000000-0000-0000-0000-000000000969',5,1,4,120) -- Magna
INSERT INTO Cfg_TarjetaFormaPago(ProductoID,CompaniaID,Version,TipoTarjetaID,FomaPagoID) VALUES  ('00000000-0000-0000-0000-000000000969',5,1,5,120) -- American Express

-- Tarjeta Forma de Pago PAC Cargo Cuenta Corriente
INSERT INTO Cfg_TarjetaFormaPago(ProductoID,CompaniaID,Version,TipoTarjetaID,FomaPagoID) VALUES  ('00000000-0000-0000-0000-000000000969',5,1,1,130) -- Visa
INSERT INTO Cfg_TarjetaFormaPago(ProductoID,CompaniaID,Version,TipoTarjetaID,FomaPagoID) VALUES  ('00000000-0000-0000-0000-000000000969',5,1,2,130) -- MasterCard
INSERT INTO Cfg_TarjetaFormaPago(ProductoID,CompaniaID,Version,TipoTarjetaID,FomaPagoID) VALUES  ('00000000-0000-0000-0000-000000000969',5,1,3,130) -- Diners
INSERT INTO Cfg_TarjetaFormaPago(ProductoID,CompaniaID,Version,TipoTarjetaID,FomaPagoID) VALUES  ('00000000-0000-0000-0000-000000000969',5,1,4,130) -- Magna
INSERT INTO Cfg_TarjetaFormaPago(ProductoID,CompaniaID,Version,TipoTarjetaID,FomaPagoID) VALUES  ('00000000-0000-0000-0000-000000000969',5,1,5,130) -- American Express

-- 120 PAC	Cargo Cuenta Corriente
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,1,120); -- Banco de Chile
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,12,120); -- Banco Estado
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,14,120); -- Scotiabank
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,16,120); -- Banco Credito e Inversiones
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,27,120); -- Corpbanca
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,28,120); -- BICE
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,29,120); -- Banco A. Edwards
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,33,120); -- CitiBank
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,35,120); -- Santander Chile
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,39,120); -- Banco Itaú
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,49,120); -- Security
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,504,120); -- BBVA
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,507,120); -- Banco del Desarrollo
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,508,120); -- BHIF
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,509,120); -- TBanc
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,510,120); -- Banco Falabella
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,511,120); -- Internacional
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,512,120); -- Banco Consorcio

-- 130 PAT	Cargo Tarjetas de Crédito
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,1,130);  -- Banco de Chile
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,12,130); -- Banco Estado
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,14,130); -- Scotiabank
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,16,130); -- Banco Credito e Inversiones
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,27,130); -- Corpbanca
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,28,130); -- BICE
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,29,130); -- Banco A. Edwards
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,33,130); -- CitiBank
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,35,130); -- Santander Chile
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,39,130); -- Banco Itaú
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,49,130); -- Security
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,504,130); -- BBVA
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,507,130); -- Banco del Desarrollo
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,508,130); -- BHIF
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,509,130); -- TBanc
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,510,130); -- Banco Falabella
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,511,130); -- Internacional
INSERT INTO Cfg_FinancieraFormaPago(ProductoID,Version,CompaniaID,EntidadFinancieraID,FomaPagoID) VALUES('00000000-0000-0000-0000-000000000969',1,5,512,130); -- Banco Consorcio