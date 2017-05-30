-- SE ACTUALIZA NOMBRE DE LAS COBERTURAS
update Bus_Cobertura set Nombre = 'Robo con Violencia en las Persona (Cobertura solo para bienes y espacios comunes)' where CoberturaID = 31841;
update Bus_Cobertura set Nombre = 'Terrorismo (Cobertura solo para bienes y espacios comunes)', NumeroPOL = 'POL 120150692' where CoberturaID = 31855;
update Bus_Cobertura set Nombre = 'Equipos e Instalaciones Electrónicas (Cobertura solo para bienes y espacios comunes)' where CoberturaID = 31858;
update Bus_Cobertura set Nombre = 'Responsabilidad Civil (Cobertura para bienes comunes y/o departamentos)' where CoberturaID = 31860;
update Bus_Cobertura set Nombre = 'Responsabilidad Civil Propietario Inmueble (Cobertura solo para bienes y espacios comunes)' where CoberturaID = 31861;
update Bus_Cobertura set Nombre = 'Cláusula Responsabilidad Civil particular, cabeza de familia (Cobertura para bienes comunes y/o departamentos)' where CoberturaID = 31862;
update Bus_Cobertura set Nombre = 'Robo con Fuerza en las cosas (Cobertura solo para bienes y espacios comunes)' where CoberturaID = 31864;
update Bus_Cobertura set Nombre = 'Bienes de trabajadores del asegurado (de la comunidad) (Cobertura solo para bienes y espacios comunes)' where CoberturaID = 31867;
update Bus_Cobertura set Nombre = 'Bienes de terceros Bienes de terceros (Cobertura solo para bienes y espacios comunes)' where CoberturaID = 31870;

-- SE INGRESA NUEVA COBERTURA
INSERT INTO Bus_Cobertura values (31878 ,'ACCIDENTES PERSONALES PLAN A Y B (Cobertura para bienes o espacios comunes)',22,'POL 3 2013 0570','',0,1,'ACCIDENTES PERSONALES PLAN A Y B (Cobertura para bienes o espacios comunes)',0)
INSERT INTO Cfg_ProductoSeccionCobertura VALUES ('00000000-0000-0000-0000-000000000969',1,190,31878,1,1,'',0,41,22,'POL320130570','',1,1,100,0,270,0,0,0,-1,1)
INSERT INTO Cfg_DistribucionPrima VALUES ('00000000-0000-0000-0000-000000000969',1,5,31878,-1,41,'POL320130570',0,'Plan A UF250 Plan B UF250. Monto máx. de indemnización UF 1.500 en vigencia de póliza.Hasta 6 pers.',0,0.01,0,5,'Sin Deducible',-1) 

-- SE ACTUALIZA TEXTOMONTO en el parametro
update Cfg_ProductoParametrosTexto set Texto = 'hasta UF 1000 con un límite de UF 50 por pieza' where ProductoID = '00000000-0000-0000-0000-000000000969' and Parametro = 'TEXTOMONTO_ROTURA' -- Rotura de Cristales

-- SE ACTUALIZA TEXTOMONTO en la distribucion de prima 
update Cfg_DistribucionPrima set TextoMonto = 'hasta UF 1000 con un límite de UF 50 por pieza' where ProductoID = '00000000-0000-0000-0000-000000000969' and CoberturaID = 31856; -- Rotura de Cristales

-- SE ACTUALIZA TEXTODEDUCIBLE en la distribucion de la prima
update Cfg_DistribucionPrima set TextoDeducible = 'Deducible UF 2 por pieza' where ProductoID = '00000000-0000-0000-0000-000000000969' and CoberturaID = 31856; -- Rotura de Cristales
update Cfg_DistribucionPrima set TextoDeducible = 'Sin Deducibl' where ProductoID = '00000000-0000-0000-0000-000000000969' and CoberturaID = 31859; -- Remocion de escombros
update Cfg_DistribucionPrima set TextoMonto = 'Hasta UF 2.000' where ProductoID = '00000000-0000-0000-0000-000000000969' and CoberturaID = 31864; --Robo con Fuerza en las cosas
update Cfg_DistribucionPrima set TextoDeducible = 'Sin Deducible' where ProductoID = '00000000-0000-0000-0000-000000000969' and CoberturaID = 31865; --Reparaciones provisorias
update Cfg_DistribucionPrima set TextoDeducible = 'Sin Deducible' where ProductoID = '00000000-0000-0000-0000-000000000969' and CoberturaID = 31866; --Gastos de obtención de permisos de reconstrucción
update Cfg_DistribucionPrima set TextoDeducible = 'Sin Deducible' where ProductoID = '00000000-0000-0000-0000-000000000969' and CoberturaID = 31867; --Bienes de trabajadores del asegurado (de la comunidad)
update Cfg_DistribucionPrima set TextoDeducible = 'Sin Deducible' where ProductoID = '00000000-0000-0000-0000-000000000969' and CoberturaID = 31868; --Gastos de Aceleración
update Cfg_DistribucionPrima set TextoDeducible = 'Sin Deducible' where ProductoID = '00000000-0000-0000-0000-000000000969' and CoberturaID = 31869; --Honorarios Profesionales
update Cfg_DistribucionPrima set TextoDeducible = 'Sin Deducible' where ProductoID = '00000000-0000-0000-0000-000000000969' and CoberturaID = 31870; --Bienes de terceros
update Cfg_DistribucionPrima set TextoDeducible = 'Sin Deducible' where ProductoID = '00000000-0000-0000-0000-000000000969' and CoberturaID = 31871; --Sprinklers
update Cfg_DistribucionPrima set TextoDeducible = 'Sin Deducible' where ProductoID = '00000000-0000-0000-0000-000000000969' and CoberturaID = 31872; --Trabajos de construcción, reparación y ampliaciones
update Cfg_DistribucionPrima set TextoDeducible = 'Sin Deducible' where ProductoID = '00000000-0000-0000-0000-000000000969' and CoberturaID = 31873; --Daño Eléctrico
update Cfg_DistribucionPrima set TextoDeducible = 'Sin Deducible' where ProductoID = '00000000-0000-0000-0000-000000000969' and CoberturaID = 31874; --Costos de Alivio de Pérdidas y/o Gastos de Salvamento
update Cfg_DistribucionPrima set TextoDeducible = 'Sin Deducible' where ProductoID = '00000000-0000-0000-0000-000000000969' and CoberturaID = 31875; --Daños por autoridad civil

-- SE ACTUALIZA TIPOMOMTO y TIPODEDUCIBLE
update Cfg_DistribucionPrima set TipoMonto = 60 where ProductoID = '00000000-0000-0000-0000-000000000969' and CoberturaID in (31855,31857,31858,31865,31866,31867,31868,31872);
update Cfg_DistribucionPrima set TipoDeducible = 9 where ProductoID = '00000000-0000-0000-0000-000000000969' and CoberturaID in (31837,31847,31848,31853,31855,31860,31861,31862)
