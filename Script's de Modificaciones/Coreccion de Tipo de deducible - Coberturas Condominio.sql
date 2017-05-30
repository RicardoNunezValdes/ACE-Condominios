-- Update de correccion tipomonto y tipo deducible
update Cfg_DistribucionPrima set TipoMonto = 0, TipoDeducible = 0 where CoberturaID = 31854

-- Update de correccion tipo deducible
update Cfg_DistribucionPrima set TipoDeducible = 5 where CoberturaID = 31858;
update Cfg_DistribucionPrima set TipoDeducible = 5 where CoberturaID = 31865;
update Cfg_DistribucionPrima set TipoDeducible = 5 where CoberturaID = 31866;
update Cfg_DistribucionPrima set TipoDeducible = 5 where CoberturaID = 31867;
update Cfg_DistribucionPrima set TipoDeducible = 5 where CoberturaID = 31868;
update Cfg_DistribucionPrima set TipoDeducible = 5 where CoberturaID = 31872;

-- Se deja tipoDeducible en 9 para las coberturas que corresponde (Deducibles con Logica)
update Cfg_DistribucionPrima set TipoDeducible = 9 where CoberturaID = 31837;
update Cfg_DistribucionPrima set TipoDeducible = 9 where CoberturaID = 31847;
update Cfg_DistribucionPrima set TipoDeducible = 9 where CoberturaID = 31848;
update Cfg_DistribucionPrima set TipoDeducible = 9 where CoberturaID = 31853;
update Cfg_DistribucionPrima set TipoDeducible = 9 where CoberturaID = 31855;
update Cfg_DistribucionPrima set TipoDeducible = 9 where CoberturaID = 31860;
update Cfg_DistribucionPrima set TipoDeducible = 9 where CoberturaID = 31861;
update Cfg_DistribucionPrima set TipoDeducible = 9 where CoberturaID = 31862;