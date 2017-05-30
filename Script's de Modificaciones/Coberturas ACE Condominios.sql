 --select a.*,b.*
select b.Nombre, a.Coberturaid,TipoMonto, TextoMonto, TipoDeducible, TextoDeducible --  b.CoberturaID, a.DeducibleID, b.Nombre, a.POLCAD, TipoPrima,  
from Cfg_DistribucionPrima a,  Bus_Cobertura b 
where a.ProductoID = '00000000-0000-0000-0000-000000000969'   --and b.Nombre like '%sismo%' --a.POLCAD like '%120130709%' -- -- --  --  
and a.CoberturaID = b.CoberturaID
--and a.CoberturaID = 31854
--and a.CoberturaID in (31837,31838,31839,31840,31842,31843,31844,31845,31846,31847,31848,31849,31850,31851,31852,31853)




--update Cfg_DistribucionPrima set TipoDeducible = 9 where ProductoID = '00000000-0000-0000-0000-000000000969' and CoberturaID in (31855,31858,31865,31866,31867,31868,31872);
 