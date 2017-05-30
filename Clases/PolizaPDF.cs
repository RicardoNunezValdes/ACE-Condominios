/*
 * Autor: Ricardo Nuñez || Tacker: MTRXCL-241 || Código: RJNV020. || Fecha: 22/05/2017 - 09:00hrs || Descripcion: Se modifica texto para el monto y el deducible de las coberturas
 * Autor: Juan Cerda 	|| Tacker: MTRXCL-65  || Código: JC019. || Fecha: 14/03/2016 - 11:12hrs || Descripcion: Control de cambios
 * Autor: Juan Cerda	|| OPANSCL-192 - Hogar Chilena Rural-Vacional-   || Código: JC018|| Fecha: 14/02/2017 - 17:04hrs || Descripcion:sE AGREGAN TAG PARA PRODUCTOS
 * Autor: Ricardo Nuñez || Tacker: 18281 || Código: RJNV017 || Fecha: 27/01/2017 - 11:10hrs || Descripcion: Se agrega enum para Ap Individual Vida
 * Autor: juan cerda	|| Tracker: 14685 - Auto Comercial Consorcio   || Código: JC016 || Fecha: 30/12/2016 - 17:04hrs || Descripcion: Auto Comercial Consorcio
 * Autor: Christian Ibacache	|| Tracker: 18722 - RC empresa   || Código: CI015 || Fecha: 16/12/2016 - 17:04hrs || Descripcion: Mejora para RC Empresa-Contrato
 * Autor: Juan Cerda || Tracker: 19023 || Código: JC005|| Fecha: 07/12/2017 - 10:24hrs || Descripción: mejora Fecha Renovaciones
 * Autor: Juan Cerda || Tracker: 17313 || Código: JC004|| Fecha: 29/09/2016 - 10:24hrs || Descripción: mejora Condominio ACE.
 * Autor: Juan Cerda || Tracker: 13603 || Código: JC003|| Fecha: 29/09/2016 - 10:24hrs || Descripción: Mejoras´Pyme ACE.
 * Autor: Fernando Gutierrez || Tracker:  || Código: FG006 || Fecha: 07/11/2016 - 15:52hrs || Descripción: Nuevo Tag Caratula Vehiculo
 * Autor: Fernando Gutierrez || Tracker:  || Código: FG005 || Fecha: 04/11/2016 - 11:37hrs || Descripción: Nuevo Tag MontoAseguradoTotal para hipotecario

 * * Autor: Juan Cerda || Tracker: 17313 || Código: JC002|| Fecha: 07/09/2016 - 10:24hrs || Descripción: Se Agrega Campo Para Condominio ACE.
 * * Autor: Juan Cerda || Tacker: SPDF   || Código: JC001|| Fecha: 10/08/2016 - 09:47hrs || Descripcion: Se agregan fotos por default a spdf
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ANT.Utilidades;
using System.Reflection;

using System.Data;
using System.Net;
namespace ANT.OnLine.Negocio
{
    public class PolizaPDF
    {
        public static Respuesta Mapear(Entidades.PolizaPDF pol, PolizaBC oPoliza)
        {
            try
            {
                MapearRaiz(pol, oPoliza);
            }
            catch (Exception ex)
            {
                return new Respuesta() { Error = -1, Mensaje = "Error al Mapear PDF:", Detalle = " Catch: Proyecto:Negocio , Clase:PolizaPDF, Metodo: Mapear(Entidades.PolizaPDF pol, PolizaBC oPoliza) ,Error al Mapear PDF --  " +" -- Message--"+   ex.Message + " --  Trace -- "+ ex.StackTrace };
            }
            return new Respuesta() { Error = 0, Resultado = pol };
        }
        private static void MapearRaiz(Entidades.PolizaPDF pol, PolizaBC oPoliza)
        {
            //Lo correcto es 24-10-2016 pero no funciona, se baja a 23-10-2016
            DateTime FechaInicioSura = new DateTime(2016, 10, 23, 00, 00, 00);
            if (oPoliza.Emision >= FechaInicioSura)
                    pol.EsSura = true;

            Contratante(pol, oPoliza);
            Corredor(pol, oPoliza);
            Cuotas(pol, oPoliza);
            MapearDatosRiesgos(pol, oPoliza);
            pol.FechaEmision = oPoliza.Emision.ToString("dd-MM-yyyy");
            pol.EmisionNumero = oPoliza.Emision.ToString("yyyyMMdd");
            pol.InicioVigencia = oPoliza.InicioVigencia.ToString().Substring(0, oPoliza.InicioVigencia.ToString().Length - 3).Replace("/","-");
            pol.Moneda = oPoliza.oMoneda.NombreCorto;
            pol.Ramo = oPoliza.oProducto.oRamoS[0].NombreCorto;
            pol.FinVigencia = oPoliza.FinVigencia.ToString().Substring(0, oPoliza.FinVigencia.ToString().Length - 3).Replace("/", "-"); 
            pol.NumeroPoliza = oPoliza.PolizaMadre;
            pol.Certificado = oPoliza.Certificado;
            pol.NombreBanco = oPoliza.oPlanPago.oEntidadFinanciera.NombreLargo;
            pol.CuentaCorriente = oPoliza.oPlanPago.NumeroMedioPago;
            pol.NumeroTarjeta = oPoliza.oPlanPago.NumeroMedioPago;
            pol.TipoTarjeta = oPoliza.oPlanPago.oTipoTarjeta.NombreCorto;
            pol.VencimientoTarjeta = oPoliza.oPlanPago.Expiracion.ToShortDateString();
            pol.DiaPago = oPoliza.oPlanPago.DiaPago.ToString();
            pol.Compania = oPoliza.oCompania.NombreCorto;
            pol.NombreProducto = oPoliza.oProducto.Nombre;
            pol.TotalIVA = oPoliza.IVA.ToString("N", CultureFormat.Cultura); ;
            pol.TotalAfecta = oPoliza.PrimaNetaAfecta.ToString("N", CultureFormat.Cultura);
            //Código: CI015 
            pol.TotalBruta = oPoliza.PrimaBruta.ToString("N", CultureFormat.Cultura); 
            pol.TotalExenta = oPoliza.PrimaNetaExenta.ToString("N", CultureFormat.Cultura); 
            pol.TotalNeta = oPoliza.PrimaNetaTotal.ToString("N", CultureFormat.Cultura); 
            pol.DocumentoID = oPoliza.DocumentoID;
            pol.ProductoID = oPoliza.oProducto.ProductoID;
            pol.PromocionID = oPoliza.PromocionID;

            string urlImagenes = ((Respuesta)Utilidades.AppSettings.GetValue("urlImagenes")).Resultado.ToString();
            string LogoCorredor = ((Respuesta)Utilidades.AppSettings.GetValue("LogoCorredor")).Resultado.ToString();
            string FirmaCorredor = ((Respuesta)Utilidades.AppSettings.GetValue("FirmaCorredor")).Resultado.ToString();
            string CorredorMiembro = ((Respuesta)Utilidades.AppSettings.GetValue("CorredorMiembro")).Resultado.ToString();
            
            //Ini: Código: JC001
            string LogoCorredorDefault = ((Respuesta)Utilidades.AppSettings.GetValue("LogoCorredorDefault")).Resultado.ToString();
            string FirmaCorredorDefault = ((Respuesta)Utilidades.AppSettings.GetValue("FirmaCorredorDefault")).Resultado.ToString();
            string CorredorMiembroDefault = ((Respuesta)Utilidades.AppSettings.GetValue("CorredorMiembroDefault")).Resultado.ToString();


            pol.Logo = urlImagenes + oPoliza.oCorredor.Identificacion + "/" + LogoCorredor;
            pol.Firma = urlImagenes + oPoliza.oCorredor.Identificacion + "/" + FirmaCorredor;
            pol.CorredorMiembro = urlImagenes + CorredorMiembro;
            
            if (!RemoteFileExists(pol.Logo,2000))
                    pol.Logo = LogoCorredorDefault;

            if (!RemoteFileExists(pol.Firma, 2000))
                    pol.Firma = FirmaCorredorDefault;

            if (!RemoteFileExists(pol.CorredorMiembro, 2000))
                    pol.CorredorMiembro = CorredorMiembroDefault;
            //Fin: Código: JC001

            
           // pol.EsPagoElectronico = true;
            DateTime despuesDel4 = new DateTime(2016,10,04,0,0,0);
            if (oPoliza.Emision > despuesDel4)
                 pol.EsPlus = true;

           //para Sura Auto SS
            if (pol.EsSura == true && pol.EsAseguramientoRenovacion == false)
            {
                pol.EsAseguramientoRenovacionSura = true;
                pol.EsAseguramientoRenovacionRSA = false;
            }
            else if (pol.EsSura == false && pol.EsAseguramientoRenovacion == false)
            {
                pol.EsAseguramientoRenovacionSura = false;
                pol.EsAseguramientoRenovacionRSA = true;
            }

            //para Sura Hogar
            if (pol.EsSura == true && pol.EsBeneficiarioBancoPagoContado == true)
            {
                pol.EsBeneficiarioBancoPagoContadoRSA = false;
                pol.EsBeneficiarioBancoPagoContadoSura = true;
            }
            else if (pol.EsSura == false && pol.EsBeneficiarioBancoPagoContado == true)
            {
                pol.EsBeneficiarioBancoPagoContadoRSA = true;
                pol.EsBeneficiarioBancoPagoContadoSura = false;
            }

            //Caratula
            if (pol.EsAseguramientoRenovacion)
            {
                pol.EsRenovacionSi = "X";
                pol.EsRenovacionNo = "";
            }
            else
            {
                pol.EsRenovacionSi = "";
                pol.EsRenovacionNo = "X";
            }

            if (pol.EsBeneficiarioBancoPagoContado)
            {
                pol.AcreedorNombreCompleto = pol.BeneficiarioNombreCompleto;
                pol.AcreedorRut = pol.BeneficiarioRut;
            }

            string logosFirmas = urlImagenes.Replace("Corredor/", "");
            switch (oPoliza.oCompania.Id)
            { 
                case 3: //Chilena
                    pol.LogoCompania = logosFirmas + "Chilena/logo.jpg";
                    break;
                case 5: //ACE
                    pol.LogoCompania = logosFirmas + "Ace/logo2.jpg";
                    break; 
                case 12: //Sura
                    if(pol.EsSura)
                        pol.LogoCompania = logosFirmas + "Royal/Sura.jpg";
                    else
                        pol.LogoCompania = logosFirmas + "Royal/Royal.jpg";
                    break;
                case 16: //BCI
                    pol.LogoCompania = logosFirmas + "BCI/BCI_Seguros.jpg";
                    break;
                case 17: //Consorcio
                    pol.LogoCompania = logosFirmas + "Consorcio/logo.jpg";
                    break;
                case 18: //Renta
                    pol.LogoCompania = logosFirmas + "Renta/logo.jpg";
                    break;
                case 55: //Auxilia
                    pol.LogoCompania = logosFirmas + "Auxilia/logo_auxilia.gif";
                    break;              
            }

            //Caratula de Auto
            switch (oPoliza.oProducto.ProductoID)
            { 
                case "00000000-0000-0000-0000-000000000126": //Auto RC RSA
                case "00000000-0000-0000-0000-000000000105": //Auto RC BCI
                case "00000000-0000-0000-0000-000000000170": //RC Internacional 5 días                    
                case "00000000-0000-0000-0000-000000000171": //RC Internacional 10 días
                case "00000000-0000-0000-0000-000000000172": //RC Internacional 15 días
                case "00000000-0000-0000-0000-000000000173": //RC Internacional 30 días
                case "00000000-0000-0000-0000-000000000174": //RC Internacional 6 meses
                case "00000000-0000-0000-0000-000000000175": //RC Internacional 1 año
                    pol.DanoTercero = "X";
                    pol.DanoPropioTercero = "";
                    break;
                default:
                    pol.DanoTercero = "";
                    pol.DanoPropioTercero = "X";
                    break;
            }
            
            //Caratula de Hogar
            switch (oPoliza.oProducto.oSubAgrupacion.Id)
            {
                case 15000: //Hipotecarios
                    pol.IncendioSimple = "";
                    pol.IncendioHipotecario = "X";
                    break;
                default:
                    pol.IncendioSimple = "X";
                    pol.IncendioHipotecario = "";
                    break;
            }

            FormaPago(pol, oPoliza);
        }
        public static bool RemoteFileExists(string url, int timeout)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.Timeout = timeout;
                request.Method = "HEAD";
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                return (response.StatusCode == HttpStatusCode.OK);
            }
            catch
            {
                return false;
            }
        }
        private static void FormaPago(Entidades.PolizaPDF pol, PolizaBC oPoliza)
        {
            

            switch (oPoliza.oPlanPago.oFormaPago.Id)
            {
                case (int)Negocio.eeFormaPago.ePAC:
                    pol.EsPAC = true;
                    if (pol.EsSura)
                        pol.EsPACSura = true;
                    else
                        pol.EsPACRSA = true;
                    
                    break;

                case (int)Negocio.eeFormaPago.ePAT:
                    pol.EsPAT = true;

                    if (pol.EsSura)
                        pol.EsPATSura = true;
                    else
                        pol.EsPATRSA = true;

                    break;

                case (int)Negocio.eeFormaPago.eAvisoVencimiento:
                    pol.EsAvisoDeVencimiento = true;
                    break;

                default:
                    pol.EsContado = true;
                    break;
            }
        }
        private static void Cuotas(Entidades.PolizaPDF pol, PolizaBC oPoliza)
        {
            pol.FormaDePago = oPoliza.oPlanPago.oFormaPago.NombreCorto;
            pol.MontoContado = oPoliza.oPlanPago.MontoContado.ToString("N", CultureFormat.Cultura); 

            if (oPoliza.oPlanPago.oCuotas.Count > 0)
            {
                pol.MontoCuotaMensual = oPoliza.oPlanPago.oCuotas.Select(c => c.Monto).First().ToString("N", CultureFormat.Cultura);
                //pol.NumeroCuotas = oPoliza.oPlanPago.oCuotas.Max(c => c.CuotaID).ToString();
                pol.NumeroCuotas = oPoliza.oPlanPago.oCuotas.Count.ToString();
                pol.VencimientoPrimeraCuota = oPoliza.oPlanPago.oCuotas.Select(c => c.Vencimiento).First().ToString("dd-MM-yyyy");;

                DataTable dt = new DataTable();
                DataRow row2 = dt.NewRow();

                for (int i = 0; i < oPoliza.oPlanPago.oCuotas.Count; i++)
                {
                    Entidades.Cuota oCuota = oPoliza.oPlanPago.oCuotas[i];
                    DataColumn col = new DataColumn();
                    //col.ColumnName = "Cuota " + oPoliza.oPlanPago.oCuotas.Where(c => c.CuotaID == (i + 1)).Select(a => a.CuotaID).FirstOrDefault();
                    col.ColumnName = "Cuota " + oCuota.CuotaID.ToString();
                    dt.Columns.Add(col);
                    
                    //row2["Cuota " + oPoliza.oPlanPago.oCuotas.Where(c => c.CuotaID == (i + 1)).Select(a => a.CuotaID).FirstOrDefault()] = oPoliza.oPlanPago.oCuotas.Where(c => c.CuotaID == (i + 1)).Select(a => a.Monto).FirstOrDefault().ToString("0.00");
                    row2["Cuota " + oCuota.CuotaID.ToString()] = oCuota.Monto.ToString("0.00");
                }

                dt.Rows.Add(row2);
                pol.DetalleCuotas = 
                new
        {
            Data = dt,
            Style = new
                   {

                       GeneralLevel = new
                       {
                           Font = new
                           {
                               Bold = false,
                               Italic = false,
                               Size = 11,
                               Color = "#333",
                               Underline = false,
                               Family = "Arial",
                               TextTransform = ""
                           },

                           Border = new
                           {
                               Color = "#888",
                               Width = 0
                           },

                           HAlign = "Center",
                           VAlign = "Middle",
                           Width = 100,
                           BackgroundColor = "#FFFFFF"
                       },

                       HeaderLevel = new
                       {
                           Font = new
                           {
                               Bold = false,
                               Italic = false,
                               Size = 11,
                               Color = "#333",
                               Underline = false,
                               Family = "Arial",
                               TextTransform = ""
                           },

                           Border = new
                           {
                               Color = "#888",
                               Width = 0
                           },

                           HAlign = "Center",
                           VAlign = "Middle",
                           BackgroundColor = "#CCC"

                       } 
                   }


        };

            }
        }
        private static void Corredor(Entidades.PolizaPDF pol, PolizaBC oPoliza)
        {
            //Corredor
            pol.CorredorNombres = oPoliza.oCorredor.Nombres;
            pol.CorredorApellidoPaterno = oPoliza.oCorredor.ApellidoPaterno;
            pol.CorredorApellidoMaterno = oPoliza.oCorredor.ApellidoMaterno;
            pol.CorredorRazonSocial = oPoliza.oCorredor.RazonSocial;
            pol.CorredorNombreCompleto = NombreCompleto(oPoliza.oCorredor);
            pol.CorredorRut = Rut.FormatRut(oPoliza.oCorredor.Identificacion);

            Respuesta resp = new Respuesta();
            resp = Datos.Poliza.GetCodigoCorredorCompania(oPoliza.oCorredor.CorredorID, oPoliza.oCompania.Id);
            if (resp.Error == 0)
                pol.CorredorCodigoCompania = resp.Resultado.ToString();

            pol.CorredorComision = (oPoliza.oCorredor.PorcentajeComision * 100).ToString("N",CultureFormat.Cultura) ;

            if (oPoliza.oCorredor.Contactos.Any(c => c.oTipoContacto.Id == 4))
            {
                pol.CorredorEmail = oPoliza.oCorredor.Contactos.Where(c => c.oTipoContacto.Id == 4).Select(c => c.Contacto).First();
            }

            if (oPoliza.oCorredor.Contactos.Any(c => c.oTipoContacto.Id == 2 || c.oTipoContacto.Id == 1 || c.oTipoContacto.Id == 6))
            {
                if (oPoliza.oCorredor.Contactos.Any(c => c.oTipoContacto.Id == 1))
                {
                    pol.CorredorTelefono = oPoliza.oCorredor.Contactos.Where(c => c.oTipoContacto.Id == 1).Select(c => c.Contacto).First();
                }
                if (pol.CorredorTelefono.Trim() == string.Empty)
                {
                    if (oPoliza.oCorredor.Contactos.Any(c => c.oTipoContacto.Id == 2))
                    {
                        pol.CorredorTelefono += oPoliza.oCorredor.Contactos.Where(c => c.oTipoContacto.Id == 2).Select(c => c.Contacto).First();
                    }
                }
                if (pol.CorredorTelefono.Trim() == string.Empty)
                {
                    if (oPoliza.oCorredor.Contactos.Any(c => c.oTipoContacto.Id == 6))
                    {
                        pol.CorredorTelefono += oPoliza.oCorredor.Contactos.Where(c => c.oTipoContacto.Id == 6).Select(c => c.Contacto).First();
                    }
                }
            }
        }
        private static void Contratante(Entidades.PolizaPDF pol, PolizaBC oPoliza)
        {
            //Contratante
            pol.ContratanteNombres = oPoliza.oContratante.Nombres;
            pol.ContratanteApellidoPaterno = oPoliza.oContratante.ApellidoPaterno;
            pol.ContratanteApellidoMaterno = oPoliza.oContratante.ApellidoMaterno;
            pol.ContratanteRazonSocial = oPoliza.oContratante.RazonSocial;
            pol.ContratanteNombreCompleto = NombreCompleto(oPoliza.oContratante);
            pol.ContratanteRut = Rut.FormatRut(oPoliza.oContratante.Identificacion);

            for (int i = 0; i < oPoliza.oContratante.Direcciones.Count; i++)
            {
                pol.ContratanteComuna = oPoliza.oContratante.Direcciones[i].Comuna.NombreLargo;
                pol.ContratanteCiudad = oPoliza.oContratante.Direcciones[i].Ciudad.NombreLargo;
                pol.ContratanteDireccion = oPoliza.oContratante.Direcciones[i].Direccion;
                pol.ContratanteRegion = oPoliza.oContratante.Direcciones[i].Region.NombreLargo;
            }

            if (oPoliza.oContratante.Contactos.Any(c => c.oTipoContacto.Id == 4))
            {
                pol.ContratanteEmail = oPoliza.oContratante.Contactos.Where(c => c.oTipoContacto.Id == 4).Select(c => c.Contacto).First();
            }

            //if (oPoliza.oContratante.Contactos.Any(c => c.oTipoContacto.Id == 2 || c.oTipoContacto.Id == 1 || c.oTipoContacto.Id == 6))
            //{
            //    if (oPoliza.oContratante.Contactos.Any(c => c.oTipoContacto.Id == 1))
            //    {
            //        pol.ContratanteTelefono = oPoliza.oContratante.Contactos.Where(c => c.oTipoContacto.Id == 1).Select(c => c.Contacto).First();
            //    }
            //    if (oPoliza.oContratante.Contactos.Any(c => c.oTipoContacto.Id == 2))
            //    {

            //        pol.ContratanteTelefono += oPoliza.oContratante.Contactos.Where(c => c.oTipoContacto.Id == 2).Select(c => c.Contacto).First();
            //    }
            //    if (oPoliza.oContratante.Contactos.Any(c => c.oTipoContacto.Id == 6))
            //    {

            //        pol.ContratanteTelefono += oPoliza.oContratante.Contactos.Where(c => c.oTipoContacto.Id == 6).Select(c => c.Contacto).First();
            //    }
            //}
            pol.ContratanteTelefono = string.Join(" ", oPoliza.oContratante.Contactos.Where(c => c.oTipoContacto.Id == 1 || c.oTipoContacto.Id == 2 || c.oTipoContacto.Id == 6).Select(c => c.Contacto));
         

        }
        private static void MapearDatosRiesgos(Entidades.PolizaPDF pol, PolizaBC oPoliza)
        {
            for (int i = 0; i < oPoliza.oRiesgoS.Count; i++)
            {
                //Ini:Código: RJNV017
                if (oPoliza.oRiesgoS[i].oTipoMateriaAsegurada.TipoMateriaID != (int)Entidades.Enum.Materia.eAPVida)
                {
                    Beneficiario(pol, oPoliza.oRiesgoS[i]);
                }
                else
                {
                    BeneficiarioEspecialApVida(oPoliza.OrigenID, oPoliza.oRiesgoS[i],pol);
                }
                //Fin:Código: RJNV017

                Asegurado(pol,oPoliza.oRiesgoS[i]);
                Materia( oPoliza,  oPoliza.oRiesgoS[i],pol);

                pol.CoberturaBase = oPoliza.oRiesgoS[i].oDeducible.Texto;
                pol.NombrePlan = oPoliza.oRiesgoS[i].oDeducible.Texto;
                pol.NumeroItem = oPoliza.oRiesgoS[i].ItemRiesgoID.ToString();
                pol.Minuta = oPoliza.oRiesgoS[i].Minuta;
                if(oPoliza.oRiesgoS[i].Minuta.Trim()!=string.Empty)
                        pol.TieneMinuta = true;

                pol.CompaniaAnterior = oPoliza.oRiesgoS[i].oCompaniaAnterior.NombreLargo.Trim();
                pol.PolizaAnterior = oPoliza.oRiesgoS[i].PolizaAnterior.Trim();
                pol.MontoAsegurado = (int)oPoliza.oRiesgoS[i].MontoAsegurado;
                Validaciones(oPoliza.oRiesgoS[i],oPoliza,pol);

               

                Coberturas(pol, oPoliza.oRiesgoS[i],oPoliza);
            }
        }

        //Ini:Código: RJNV017
        private static void BeneficiarioEspecialApVida(string OrigenId, Entidades.PolizaRiesgo polizaRiesgo, Entidades.PolizaPDF pol)
        {
            List<Entidades.ItemCotizacionPersonaDistribuirCapital> listaBeneficiarios = new List<Entidades.ItemCotizacionPersonaDistribuirCapital>();
            listaBeneficiarios = Datos.ItemCotizacionPersonaDistribuirCapital.Read(OrigenId, polizaRiesgo.ItemRiesgoID);

                if (listaBeneficiarios.Count > 0)
                {
                    //Beneficiario
                    for (int z = 0; z < listaBeneficiarios.Count; z++)
                    {
                        if (z > 0)
                            break;

                        var beneficiario = polizaRiesgo.oBeneficiarios.Where(c => c.Identificacion == listaBeneficiarios[z].Identificacion).FirstOrDefault();
                        if (beneficiario != null)
                        {
                            pol.BeneficiarioNombres = beneficiario.Nombres;
                            pol.BeneficiarioApellidoPaterno = beneficiario.ApellidoPaterno;
                            pol.BeneficiarioApellidoMaterno = beneficiario.ApellidoMaterno;
                            pol.BeneficiarioRazonSocial = beneficiario.RazonSocial;
                            pol.BeneficiarioRut = Rut.FormatRut(beneficiario.Identificacion);
                            pol.BeneficiarioNombreCompleto = NombreCompleto(beneficiario);
                            //Ini:Código: JC019.
                            pol.BeneficiarioPorcentaje = listaBeneficiarios[z].porcentaje.FormatoCulture();
                            var contactosTelefonos = beneficiario.Contactos.Where(c=>c.oTipoContacto.Id==(int)Entidades.Enum.TipoContacto.Celular || c.oTipoContacto.Id==(int)Entidades.Enum.TipoContacto.TelParticular).ToList();
                            for (int i = 0; i < contactosTelefonos.Count; i++)
			                    {
                                    pol.BeneficiarioTelefono += contactosTelefonos[i].Contacto;
                                    if (i != contactosTelefonos.Count-1)
                                        pol.BeneficiarioTelefono += "-";
			                     }

                            var contactosmail = beneficiario.Contactos.Where(c => c.oTipoContacto.Id == (int)Entidades.Enum.TipoContacto.email).ToList();
                            for (int i = 0; i < contactosmail.Count; i++)
                            {
                                pol.BeneficiarioMail += contactosmail[i].Contacto;
                                if (i != contactosmail.Count - 1)
                                    pol.BeneficiarioMail += "-";
                            }
                            //Fin:Código: JC019.
                           
                        }
                    }
                    if (listaBeneficiarios.Count > 1)
                    {
                        pol.TieneMasDeUnBeneficiario = true;
                        CuadroBeneficiarios(pol, polizaRiesgo, OrigenId);
                    }
                    pol.TieneBeneficiario = true;
                     
                }

        }
        //Fin:Código: RJNV017
        private static void Validaciones(Entidades.PolizaRiesgo polizaRiesgo, PolizaBC oPoliza, Entidades.PolizaPDF pol)
        {

            Respuesta resp = new Respuesta();

            if (polizaRiesgo.oDeducible.DeducibleID != 240)
            {
                    pol.PlanTieneDeducible = true;

                    pol.DeducibleTituloPoliza ="Deducible:" + " " +oPoliza.oMoneda.NombreCorto + " " + polizaRiesgo.oDeducible.Texto;
             }
            else
            {
                pol.DeducibleTituloPoliza = "Sin Deducible";
            }

            if (polizaRiesgo.oDeducible.DeducibleID == 300)
            {
                pol.TienePlanIncendioSismoRobo = true;
            }
            else
            {
                pol.TienePlanIncendioSismoRobo = false;
            }



            if (polizaRiesgo.oDeducible.DeducibleID == 240
                || polizaRiesgo.oDeducible.DeducibleID == 100)
                pol.EsDeducibleHastaUF3 = true;

            if (polizaRiesgo.oDeducible.DeducibleID != 120)
                pol.EsDeducibleHastaUF5 = true;
                    
            if (polizaRiesgo.oCoberturas.Any(c => c.oCobertura.CoberturaID == 970))
                    pol.EsTieneCoberturaRCConductoresDependientes = true;

            if (polizaRiesgo.oCoberturas.Any(c => c.oCobertura.CoberturaID == 960))
                pol.EsTieneCoberturaRCPropiaCarga = true;

            if (polizaRiesgo.InicioVigencia.Date == new DateTime(2012,03,01))
                    pol.EsTieneInicioVigencia01_03_2012 = true;

            if (oPoliza.PromocionID == 7)//PinchAZO
                    pol.EsTienePromocionAntipinchazo = true;

            if (polizaRiesgo.oCoberturas.Any(c => c.oCobertura.CoberturaID == 960))
                    pol.EsTieneCoberturaRCPropiaCarga = true;

            if (polizaRiesgo.oCoberturas.Any(c => c.oCobertura.CoberturaID == 790))
                    pol.EsTieneCoberturaRoboAccesorios = true;
                
            if (polizaRiesgo.oCoberturas.Any(c => c.oCobertura.CoberturaID == 880)
                || polizaRiesgo.oCoberturas.Any(c => c.oCobertura.CoberturaID == 885))
                pol.TieneCoberturaDanosExtranjero = true;

            if (polizaRiesgo.oCoberturas.Any(c => c.oCobertura.CoberturaID == 890))
                pol.TieneCoberturaDefensaPenal = true;

            if (polizaRiesgo.oCoberturas.Any(c => c.oCobertura.CoberturaID == 25913))
                    pol.EsTieneCoberturaVehiculoReemplazo = true;

            if (oPoliza.Emision >= new DateTime(2013, 04, 01))
                    pol.EsEmision01_04_2013 = true;

            if (oPoliza.Emision == new DateTime(2013, 04, 01))
                    pol.EsEmision01_04_2014 = true;

            if (polizaRiesgo.oDeducible.DeducibleID == 300 || polizaRiesgo.oDeducible.DeducibleID == 280)
            {
                resp = Datos.PDF.EsPrimeraRenovacion(oPoliza.DocumentoID);
                if(resp.Error==0)
                {
                    List<object> listaResultado = new List<object>();
                    float resultado = 0f;
                    DateTime fecha = new DateTime(1900, 01, 01, 00, 00, 00);
                    listaResultado = (List<object>)resp.Resultado;

                    if (listaResultado.Count>0)
                    {
                        pol.PrimaBrutaAnterior = ((float)listaResultado[0]).ToString("N", CultureFormat.Cultura);
                        //Código: JC005
                        pol.FechaHastaCaduca = (DateTime.Parse(listaResultado[1].ToString())).ToString("dd-MM-yyyy");
                        pol.EsTieneCartaRenovacionRSA = true;
                    }
                }
                pol.EsTieneCoberturaRobo = true;
            }
            
            if (polizaRiesgo.oDeducible.DeducibleID == 300 || polizaRiesgo.oDeducible.DeducibleID == 290)
                   pol.EstieneCoberturaSismo = true;



            if (polizaRiesgo.oCoberturas.Any(c => c.oCobertura.CoberturaID == 2070))
                pol.TieneCoberturaMuerteInvalidez = true;

            if (polizaRiesgo.oCoberturas.Any(c => c.oCobertura.CoberturaID == 380))
                pol.TieneCoberturaCristales = true;

            if (polizaRiesgo.oCoberturas.Any(c => c.oCobertura.CoberturaID == 370))
                pol.TieneCoberturaResponsabilidadCivil = true;

            resp = Datos.PDF.EsBeneficiarioBanco(pol.BeneficiarioRut.Replace(".","").Replace("-",""));
            if (resp.Error == 0)
            {
                List<Entidades.Banco> lista = new List<Entidades.Banco>();
                lista = ( List<Entidades.Banco>)resp.Resultado;
                if (lista.Count > 0)
                {
                    ////INi:Código: JC002
                    pol.EstieneBeneficiarioBancoCualquierPago = true;
                    if (oPoliza.oPlanPago.oFormaPago.Id ==(int) eeFormaPago.eContado)
                    {
                        pol.EstieneBeneficiarioBanco = true;
                        pol.EsBeneficiarioBancoPagoContado = true;
                        pol.BeneficiarioBanco = lista.Select(c => c.NombreCorto).First();

                        Respuesta verificaPE = PolizaBC.VerificarPolizaPagada(oPoliza.DocumentoID);
                        if (verificaPE.Error == 0)
                        {
                            if ((bool)verificaPE.Resultado)
                                pol.EsBeneficiarioBancoPagoContadoElectronico = true;
                        }
                    }
                    ////INi:Código: JC002
                    if (oPoliza.oPlanPago.oFormaPago.Id == (int)eeFormaPago.eContado || oPoliza.oPlanPago.oFormaPago.Id == (int)eeFormaPago.ePAT)
                    {
                        pol.EsTieneBeneficiarioBancoContadoPAT = true;
                        pol.BeneficiarioBanco = lista.Select(c => c.NombreCorto).First();
                    }

                    if (pol.BeneficiarioRut.Trim().Replace(".", "").Replace("-", "") == "970320008")
                        pol.EsTieneBancoBBVA = true;

                    if (pol.BeneficiarioRut.Trim().Replace(".", "").Replace("-", "").ToUpper() == "97036000K")
                        pol.EsTieneBancoSantander = true;
                }
                   
            }

            switch (oPoliza.oCompania.Id)
	        {
                case (int)Negocio.eeCompania.eChilena:
                    if (polizaRiesgo.oCoberturas.Any(c => c.oCobertura.CoberturaID == 390))
                        pol.MontoAseguradoRobo = polizaRiesgo.oCoberturas.Where(c => c.oCobertura.CoberturaID == 390).Select(d=>(d.PrimaNetaAfecta + d.PrimaNetaExenta)).First().ToString("N", CultureFormat.Cultura);
                
                    break;
		        
                case (int)Negocio.eeCompania.eConsorcio:
                     if (polizaRiesgo.oCoberturas.Any(c => c.oCobertura.CoberturaID == 30585))
                         pol.MontoAseguradoRobo = polizaRiesgo.oCoberturas.Where(c => c.oCobertura.CoberturaID == 30585).Select(d=>(d.PrimaNetaAfecta + d.PrimaNetaExenta)).First().ToString("N", CultureFormat.Cultura);

                    
                    

                    break;
                //Ini:Código: RJNV017
                case (int)Entidades.Enum.Compania.ConsorcioVida:
                    pol.TieneCoberturaIncapacidadPermanente = (polizaRiesgo.oCoberturas.Any(c => c.oCobertura.CoberturaID == 32937));
                    pol.TieneCoberturaDesmembramiento = (polizaRiesgo.oCoberturas.Any(c => c.oCobertura.CoberturaID == 32938));
                    pol.TieneCoberturaReembolsoGastos = (polizaRiesgo.oCoberturas.Any(c => c.oCobertura.CoberturaID == 32939));
                    pol.TieneCoberturaIndemnizacionDiaria = (polizaRiesgo.oCoberturas.Any(c => c.oCobertura.CoberturaID == 32940));
                    //Ini:Código: JC019.
                    //Preguntas adicionales
                    resp = Negocio.CuestionarioVida.ReadCoberturasAdicionalesPoliza((int)Entidades.Enum.TipoPreguntas.eAdicionales , oPoliza.OrigenID);
                    List<Entidades.CuestionarioVida> lista = new List<Entidades.CuestionarioVida>();
                    if(resp.Error==0)
                    {
                        lista=(List<Entidades.CuestionarioVida>)resp.Resultado;
                        pol.TienePreguntaAdicionalRiesgosos= (lista.Any(c => c.PreguntaID == 7));
                        pol.TienePreguntaAdicionalFallecimiento = (lista.Any(c => c.PreguntaID == 6));
                    }
                    //Fin:Código: JC019.
                    

                    break;
                //Fin:Código: RJNV017
	        }

            

        }
        private static void Coberturas(Entidades.PolizaPDF pol, Entidades.PolizaRiesgo polizaRiesgo, PolizaBC oPoliza)
        {
            if (polizaRiesgo.oCoberturas.Count > 0)
            {
                Respuesta resp = new Respuesta();
               
                resp = CrearCuadroCobertura(polizaRiesgo ,oPoliza,pol);
                if (resp.Error == 0)
                {
                    pol.CuadroDeCoberturas =

                        new
                    {
                        Data = (DataTable)resp.Resultado,
                        Style = new
                        {

                            GeneralLevel = new
                            {
                                Font = new
                                {
                                    Bold = false,
                                    Italic = false,
                                    Size = 11,
                                    Color = "#333",
                                    Underline = false,
                                    Family = "Arial",
                                    TextTransform = ""
                                },

                                Border = new
                                {
                                    Color = "#888",
                                    Width = 0
                                },

                                HAlign = "Center",
                                VAlign = "Middle",
                                Width = 100,
                                BackgroundColor = "#FFFFFF"
                            },

                            HeaderLevel = new
                            {
                                Font = new
                                {
                                    Bold = false,
                                    Italic = false,
                                    Size = 11,
                                    Color = "#333",
                                    Underline = false,
                                    Family = "Arial",
                                    TextTransform = ""
                                },

                                Border = new
                                {
                                    Color = "#888",
                                    Width = 0
                                },

                                HAlign = "Center",
                                VAlign = "Middle",
                                BackgroundColor = "#CCC"

                            }

                        }
                    };
                }
            }
        }
        private static Respuesta CrearCuadroCobertura(Entidades.PolizaRiesgo polizaRiesgo,PolizaBC oPoliza,Entidades.PolizaPDF pol )
        {
            Respuesta resp = new Respuesta();
            DataTable dt = new DataTable();

            resp= CargarDistribucion(polizaRiesgo,oPoliza);
            List<Entidades.DistribucionPrima> oDistribucionPrima =  new List<Entidades.DistribucionPrima>();
            if (resp.Error == 0)
            {
                oDistribucionPrima = (List<Entidades.DistribucionPrima>)resp.Resultado;
                //Codigo:JC002
                dt = CrearColumnas(oPoliza.oProducto.oAgrupacion.Id ,oPoliza.oProducto.oSubAgrupacion.Id );
                for (int distr = 0; distr < oDistribucionPrima.Count; distr++)
                {
                    if (polizaRiesgo.oCoberturas.Any(c => c.oCobertura.CoberturaID == oDistribucionPrima[distr].CoberturaID))
                    {
                        Entidades.PolizaRiesgoCobertura cobertura = polizaRiesgo.oCoberturas.Where(c => c.oCobertura.CoberturaID == oDistribucionPrima[distr].CoberturaID).First();
                        DataRow filas = dt.NewRow();
                        filas["COBERTURA BASE"] = cobertura.oCobertura.Nombre.ToString();
                        filas["CODIGO POL CAD SVS"] = oDistribucionPrima[distr].POLCAD;
                        filas["MONTO ASEGURADO"] = (string)BuscarMonto(oDistribucionPrima[distr].TipoMonto, polizaRiesgo, cobertura, oDistribucionPrima[distr],oPoliza);
                        //Código: JC002
                        //Código: CI015
                        if (oPoliza.oProducto.oAgrupacion.Id == 100 || oPoliza.oProducto.oSubAgrupacion.Id == 13000 || oPoliza.oProducto.oSubAgrupacion.Id ==(int) eeSubAgrupacion.eEmpresa || oPoliza.oProducto.oSubAgrupacion.Id == (int) eeSubAgrupacion.eContrato)
                        {
                            filas["DEDUCIBLE"] = (string)BuscarDeducible(oDistribucionPrima[distr].TipoDeducible, polizaRiesgo, cobertura, oDistribucionPrima[distr], oPoliza, pol);
                       }
                        if (oPoliza.oProducto.oSubAgrupacion.Id != 13000)
                        {
                            filas["PRIMA NETA"] = (cobertura.PrimaNetaAfecta + cobertura.PrimaNetaExenta).ToString("0.00");
                        }
                        dt.Rows.Add(filas);

                        if (distr == 0)
                        {
                            pol.CodigoSvsPoliza = oDistribucionPrima[distr].POLCAD;
                        }
                    }
                }
            }
            return new Respuesta() { Resultado = dt };
        }
        private static string BuscarDeducible(int TipoDeducibleID, Entidades.PolizaRiesgo riesgo, Entidades.PolizaRiesgoCobertura cobertura, Entidades.DistribucionPrima oDistribucion, PolizaBC oPoliza,Entidades.PolizaPDF pol)
        {
            string resultado = string.Empty;

            if (oDistribucion.Orden==1 && pol.ModeloTieneDeducibleAdicional)
                    return "ver Condiciones Particulares"; 

            string Texto = string.Empty;

            switch (TipoDeducibleID)
            {
                case 0:
                    /* Copia texto del deducible del Item */
                    resultado = riesgo.oDeducible.Texto;
                    break;
                case 1:
                    /* Copia texto de la distribucion */
                    #region Copia texto de la distribucion
                    string textoDeducible = oDistribucion.TextoDeducible.ToString();
                    string[] textos = textoDeducible.Split('/');
                    if (textos.Length > 1)
                    {
                        switch (riesgo.oDeducible.DeducibleID)
                        {
                            case 240:
                                resultado = textos[0];
                                break;
                            case 100:
                                resultado = textos[1];
                                break;
                            case 110:
                                resultado = textos[2];
                                break;
                            case 120:
                                resultado = textos[3];
                                break;
                            default:
                                resultado = textos[0];
                                break;

                        }
                    }
                    else
                        resultado = textos[0];
                    break; 
                    #endregion
                case 2:
                    /* deducible con minimo*/
                    #region deducible con minimo
                    try
                    {
                        float dedMin = float.Parse(oDistribucion.TextoDeducible.ToString().Replace("UF", "").Trim());
                        switch (riesgo.oDeducible.DeducibleID)
                        {
                            case 240:
                                //Ini - RG008
                                if (dedMin == 0f)
                                    resultado = "SD";
                                else
                                    //FIn - RG008
                                    resultado = oDistribucion.TextoDeducible.ToString();
                                break;
                            case 100:
                                if (dedMin > 3f)
                                    resultado = oDistribucion.TextoDeducible.ToString();
                                else
                                    resultado = riesgo.oDeducible.Texto;

                                break;
                            case 110:
                                if (dedMin > 5f)
                                    resultado = oDistribucion.TextoDeducible;
                                else
                                    resultado = "UF " + riesgo.oDeducible.Texto;

                                break;
                            case 120:
                                if (dedMin > 10f)
                                    resultado = oDistribucion.TextoDeducible;
                                else
                                    resultado = "UF " + riesgo.oDeducible.Texto;

                                break;
                            default:
                                resultado = "UF " + riesgo.oDeducible.Texto;
                                break;

                        }
                    }
                    catch
                    {
                        resultado = riesgo.oDeducible.Texto;
                    }
                    break; 
                    #endregion
                case 3:
                    /* Copia texto del deducible del Item */
                    resultado = "UF " + riesgo.oDeducible.Texto.Replace("S/D", "0");
                    break;
                case 4:
                    /* Depende de la Actividad Propiedad */
                    #region Depende de la Actividad Propiedad
                    string textoDeducible4 = oDistribucion.TextoDeducible;
                    string[] textos4 = textoDeducible4.Split('/');
                    string tex = "";
                    //((Entidades.MateriaPropiedad)((PolizaRiesgoBC)(_Parent.oRiesgoS[0])).oMateria).oOcupacionComercio.Id
                    //JC002
                    Entidades.MateriaPropiedad oPropiedad = (Entidades.MateriaPropiedad)riesgo.oMateria;

                    //switch (((Entidades.MateriaPropiedad)riesgo.oMateria).oActividadPropiedad.Id)
                    switch (oPropiedad.oActividadPropiedad.Id)
                    {
                        case 1526:
                            tex = textos4[0] + " del mta. con min. UF " + textos4[1] + " en toda y cada pérdida.";
                            resultado = tex;
                            break;
                        case 1527:
                            tex = textos4[2] + " del mta. con min. UF " + textos4[3] + " en toda y cada pérdida.";
                            resultado = tex;
                            break;
                    }

                    break; 
                    #endregion
                //INi:Código: JC010
                case 5:
                    /* Copia texto completo distribucion */
                    string textoDeducible5 = oDistribucion.TextoDeducible.ToString();
                    resultado = textoDeducible5;
                    break;
                //Fin:Código: JC010

                //Ini:Código: JC002
                case 6:
                    /* Depende del Tipo Actividad Condominio */
                    #region Depende del Tipo Actividad Condominio
                    Entidades.MateriaPropiedad oPropiedadCondominio = (Entidades.MateriaPropiedad)riesgo.oMateria;

                    Respuesta respdedu = new Respuesta();

                    switch (cobertura.oCobertura.CoberturaID)
                    {
                        case 31854://Cañerías Condominio
                            respdedu = Negocio.ProductoParametro.ObtenerParametrosTexto(oDistribucion.ProductoID, "TextoDeducibleCanerias");
                            if (respdedu.Error == 0)
                                Texto = respdedu.Resultado.ToString();
                            break;
                        case 31839:
                            if (oPropiedadCondominio.oActividadPropiedad.Id == 1526)//Habitacional
                            {
                                respdedu = Negocio.ProductoParametro.ObtenerParametrosTexto(oDistribucion.ProductoID, "TextoDeducibleHabitacionalDanosSismo");
                                if (respdedu.Error == 0)
                                    Texto = respdedu.Resultado.ToString();
                            }
                            if (oPropiedadCondominio.oActividadPropiedad.Id == 1527)//Comerciales
                            {
                                respdedu = Negocio.ProductoParametro.ObtenerParametrosTexto(oDistribucion.ProductoID, "TextoDeducibleComercialDanosSismo");
                                if (respdedu.Error == 0)
                                    Texto = respdedu.Resultado.ToString();
                            }
                            break;
                        case 31840:
                            if (oPropiedadCondominio.oActividadPropiedad.Id == 1526)//Habitacional
                            {
                                respdedu = Negocio.ProductoParametro.ObtenerParametrosTexto(oDistribucion.ProductoID, "TextoDeducibleHabitacionalIncendioSismo");
                                if (respdedu.Error == 0)
                                    Texto = respdedu.Resultado.ToString();
                            }
                            if (oPropiedadCondominio.oActividadPropiedad.Id == 1527)//Comerciales
                            {
                                respdedu = Negocio.ProductoParametro.ObtenerParametrosTexto(oDistribucion.ProductoID, "TextoDeducibleComercialIncendioSismo");
                                if (respdedu.Error == 0)
                                    Texto = respdedu.Resultado.ToString();
                            }
                            break;
                        case 31848:
                            if (oPropiedadCondominio.oActividadPropiedad.Id == 1526)//Habitacional
                            {
                                respdedu = Negocio.ProductoParametro.ObtenerParametrosTexto(oDistribucion.ProductoID, "TextoDeducibleHabitacionalSalidaMar");
                                if (respdedu.Error == 0)
                                    Texto = respdedu.Resultado.ToString();
                            }
                            if (oPropiedadCondominio.oActividadPropiedad.Id == 1527)//Comerciales
                            {
                                respdedu = Negocio.ProductoParametro.ObtenerParametrosTexto(oDistribucion.ProductoID, "TextoDeducibleComercialSalidaMar");
                                if (respdedu.Error == 0)
                                    Texto = respdedu.Resultado.ToString();
                            }
                            break;
                        default:
                            Texto = string.Empty;
                            break;
                    }
                    resultado = Texto;
                    break; 
                    #endregion
                //INi:Código: CI015
                case 7:
                    /* Depende del tipo de RC */
                    #region Depende del tipo de RC
                    switch (riesgo.oDeducible.DeducibleID)
                    {
                        case (int)eeDeducibleRc.e1500:
                        case (int)eeDeducibleRc.e3000:
                        case (int)eeDeducibleRc.e5000:
                            resultado = riesgo.oDeducible.Texto;
                            break;

                        case (int)eeDeducibleRc.eEstandar:
                            respdedu = Negocio.ProductoParametro.ObtenerTodos(oDistribucion.ProductoID);
                            List<Entidades.ProductoParametros> lista = new List<Entidades.ProductoParametros>();

                            if (respdedu.Error == 0)
                                lista = (List<Entidades.ProductoParametros>)respdedu.Resultado;
                            else
                                return resultado;

                            float DesdeTramo1 = lista.Where(c => c.Parametro == "MONTO_DEDUCBLE_TRAMO1_DESDE").Select(c => c.Valor).First();
                            float HastaTramo1 = lista.Where(c => c.Parametro == "MONTO_DEDUCBLE_TRAMO1_HASTA").Select(c => c.Valor).First();
                            float DesdeTramo2 = lista.Where(c => c.Parametro == "MONTO_DEDUCBLE_TRAMO2_DESDE").Select(c => c.Valor).First();
                            float HastaTramo2 = lista.Where(c => c.Parametro == "MONTO_DEDUCBLE_TRAMO2_HASTA").Select(c => c.Valor).First();

                            switch (riesgo.oTipoMateriaAsegurada.TipoMateriaID)
                            {
                                case (int)eeMateriaCatalog.eRCEmpresa:
                                    Entidades.MateriaRCEmpresa oMateriaRCEmpresa = (Entidades.MateriaRCEmpresa)riesgo.oMateria;
                                    if ((oMateriaRCEmpresa.MontoRC >= DesdeTramo1) && (oMateriaRCEmpresa.MontoRC <= HastaTramo1))
                                    {
                                        respdedu = Negocio.ProductoParametro.ObtenerParametrosTexto(oDistribucion.ProductoID, "TEXTO_DEDUCBLE_TRAMO1");
                                        if (respdedu.Error == 0)
                                            Texto = respdedu.Resultado.ToString();
                                        else
                                            return resultado;

                                    }
                                    if ((oMateriaRCEmpresa.MontoRC >= DesdeTramo2) && (oMateriaRCEmpresa.MontoRC <= HastaTramo2))
                                    {
                                        respdedu = Negocio.ProductoParametro.ObtenerParametrosTexto(oDistribucion.ProductoID, "TEXTO_DEDUCBLE_TRAMO2");
                                        if (respdedu.Error == 0)
                                            Texto = respdedu.Resultado.ToString();
                                        else
                                            return resultado;

                                    }
                                    break;
                                case (int)eeMateriaCatalog.eRCContrato:
                                    Entidades.MateriaRCContrato oMateriaRCContrato = (Entidades.MateriaRCContrato)riesgo.oMateria;
                                    if ((oMateriaRCContrato.MontoRC >= DesdeTramo1) && (oMateriaRCContrato.MontoRC <= HastaTramo1))
                                    {
                                        respdedu = Negocio.ProductoParametro.ObtenerParametrosTexto(oDistribucion.ProductoID, "TEXTO_DEDUCBLE_TRAMO1");
                                        if (respdedu.Error == 0)
                                            Texto = respdedu.Resultado.ToString();
                                        else
                                            return resultado;

                                    }
                                    if ((oMateriaRCContrato.MontoRC >= DesdeTramo2) && (oMateriaRCContrato.MontoRC <= HastaTramo2))
                                    {
                                        respdedu = Negocio.ProductoParametro.ObtenerParametrosTexto(oDistribucion.ProductoID, "TEXTO_DEDUCBLE_TRAMO2");
                                        if (respdedu.Error == 0)
                                            Texto = respdedu.Resultado.ToString();
                                        else
                                            return resultado;

                                    }
                                    if (lista.Any(c => c.Parametro == "MONTO_DEDUCBLE_TRAMO3_DESDE"))
                                    {
                                        float DesdeTramo3 = lista.Where(c => c.Parametro == "MONTO_DEDUCBLE_TRAMO3_DESDE").Select(c => c.Valor).First();
                                        float HastaTramo3 = lista.Where(c => c.Parametro == "MONTO_DEDUCBLE_TRAMO3_HASTA").Select(c => c.Valor).First();
                                        if ((oMateriaRCContrato.MontoRC >= DesdeTramo3) && (oMateriaRCContrato.MontoRC <= HastaTramo3))
                                        {
                                            respdedu = Negocio.ProductoParametro.ObtenerParametrosTexto(oDistribucion.ProductoID, "TEXTO_DEDUCBLE_TRAMO3");
                                            if (respdedu.Error == 0)
                                                Texto = respdedu.Resultado.ToString();
                                            else
                                                return resultado;
                                        }
                                    }
                                    break;
                            }

                            resultado = Texto;
                            break;
                    }

                    break; 
                    #endregion
                //Ini:Código: JC016
                case 8:
                    if(riesgo.oDeducible.DeducibleID != 240)
                        resultado = riesgo.oDeducible.Texto;
                    else
                       resultado = oDistribucion.TextoDeducible.ToString();
                    break;
                case 9:
                    //INI RJNV020 PYMES y por cobertura
                    #region  Para PYMES y por cobertura
		            if (oPoliza.oProducto.oAgrupacion.Id == 200) //PYMES
                    {
                        float montoMaximo = 250000;
                        switch (cobertura.oCobertura.CoberturaID)
                        {
                            case 31877: //Incendio, Rayo y Explosión Edificio y Contenidos
                                if (riesgo.MontoAsegurado > montoMaximo)
                                    resultado = "5% de la pérdida con un mínimo de UF 10";
                                else
                                    resultado = "Sin Deducible";
                                break;
                            case 31847: //Incendio y Daños Materiales a consecuencia directa de huelga, saqueo o desorden popular
                                if (riesgo.MontoAsegurado > montoMaximo)
                                    resultado = "5% de la pérdida con un mínimo de UF 20";
                                else
                                    resultado = "Deducible UF 10 a toda y cada pérdida";
                                break;
                            case 31848: //Incendio y Daños materiales causados por salida de mar
                                ANT.OnLine.Entidades.MateriaPropiedad oMatPropiedad = new Entidades.MateriaPropiedad();
                                oMatPropiedad = (ANT.OnLine.Entidades.MateriaPropiedad)riesgo.oMateria;
                                if (riesgo.MontoAsegurado > montoMaximo)
                                    if (oMatPropiedad.oActividadPropiedad.Id == 1526)//Habitacional
                                    {
                                        resultado = "1% del monto asegurado con un mínimo de UF 25";
                                    }
                                    else if (oMatPropiedad.oActividadPropiedad.Id == 1527) //Comercial
                                    {
                                        resultado = "2% del monto asegurado con un mínimo de UF 50 en toda y cada perdida";
                                    }
                                else
                                        resultado = "Deducible 10% de la perdida con un mínimo de UF 5";
                                break;
                            case 31853: //Daños materiales causados por explosión
                                if (riesgo.MontoAsegurado > montoMaximo)
                                    resultado = "5% de la pérdida con un mínimo de UF 15";
                                else
                                    resultado = "Sin Deducible";
                                break;
                            case 31855: //Incendio y Daños materiales por actos terroristas (Esta cobertura cambia de nombre a [Terrorismo (Cobertura solo para bienes y espacios comunes)]
                                if (riesgo.MontoAsegurado > montoMaximo)
                                    resultado = "Deducible mínimo UF 100";
                                else
                                    resultado = "Deducible 10% de la pérdida con mínimo UF 50";
                                break;
                            case 31860: //Responsabilidad Civil
                                if (riesgo.MontoAsegurado > montoMaximo)
                                    resultado = "10% de la pérdida con un mínimo de UF 30";
                                else
                                    resultado = "10% de la pérdida con un mínimo de UF 15";
                                break;
                            case 31861: //Responsabilidad Civil Propietario Inmueble
                                if (riesgo.MontoAsegurado > montoMaximo)
                                    resultado = "10% de la pérdida con un mínimo de UF 30";
                                else
                                    resultado = "10% de la pérdida con un mínimo de UF 15";
                                break;
                            case 31862: //Cláusula Responsabilidad Civil particular,cabeza de familia
                                if (riesgo.MontoAsegurado > montoMaximo)
                                    resultado = "10% de la pérdida con un mínimo de UF 30";
                                else
                                    resultado = "10% de la pérdida con un mínimo de UF 15";
                                break;                   
                        }
                    } 
	                #endregion
                    //FIN RJNV020

                    break;
                //Fin:Código: JC016
            }
            //Fin:Código: CI015
            return resultado;

        }
        private static string BuscarMonto(int tipoMonto, Entidades.PolizaRiesgo riesgo, Entidades.PolizaRiesgoCobertura cobertura, Entidades.DistribucionPrima oDistribucion,PolizaBC oPoliza)
        {

            if(oDistribucion.CoberturaID==31854)
            {
                string a = "0";
            }
            string resultado = string.Empty;
            switch (tipoMonto)
            {
                case 0:
                    /* Copia el texto del monto */
                    resultado =  oDistribucion.TextoMonto;
                    break;

                case 1:
                    //INICIO60 RJNV020
                    if (oPoliza.oProducto.oAgrupacion.Id == 200) //PYMES
                        resultado = "UF " + oDistribucion.TextoMonto;
                    else
                        //FIN RJNV020
                        resultado = riesgo.MontoAsegurado.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    break;

                case 2:
                    /* Copia Monto Edificio */
                    Entidades.MateriaPropiedad oPropiedadE = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    resultado =  oPropiedadE.ValorEdificio.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    break;

                case 3:
                    /* Copia Monto Contenido */
                    Entidades.MateriaPropiedad oPropiedadC = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    resultado =  oPropiedadC.ValorContenido.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    break;

                case 4:
                    /* El menor valor entre Monto Contenido y el valor del tope de la cobertura */
                    //el monto se almacena en el valor TextoMonto
                    Entidades.MateriaPropiedad oPropiedadMenor = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    float topeCobertura = float.Parse(oDistribucion.TextoMonto);
                    if (oPropiedadMenor.ValorContenido < topeCobertura)
                        resultado = "UF " + oPropiedadMenor.ValorContenido.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    else
                        resultado = "UF " + topeCobertura.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    break;

                /* Menor monto entre EEelectronicos + 200 y 300 UF */
                case 5:
                    Entidades.MateriaPropiedad oPropiedadEE = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    float EEmas200 = 0;
                    EEmas200 = oPropiedadEE.MontoEquiposElectronicos + 200;
                    if (EEmas200 < 300)
                        resultado = "UF " + EEmas200.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    else
                        resultado = "UF 300";
                    break;

                /* contenidos + mercaderia */
                case 6:
                    Entidades.MateriaPropiedad oPropiedadCM = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    float ContenidosMasMercaderias = oPropiedadCM.ValorContenido + oPropiedadCM.MontoMercaderias;
                    resultado = "UF " + ContenidosMasMercaderias.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    break;

                /* Edificio + Contenido */
                case 7:
                    Entidades.MateriaPropiedad oPropiedadCE = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    float ContenidosMasEdificio = oPropiedadCE.ValorContenido + oPropiedadCE.ValorEdificio;
                    resultado = "UF " + ContenidosMasEdificio.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    break;

                /* Monto Equipo electronico */
                case 8:
                    Entidades.MateriaPropiedad oPropiedadMEE = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    resultado = "UF " + oPropiedadMEE.MontoEquiposElectronicos.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    break;

                /* porcentaje de los montos asegurados con maximo*/
                case 9:
                    float maximo = float.Parse(oDistribucion.TextoMonto);
                    string monto9 = "UF ";
                    float porcentajeMontoAsegurado = 0;
                    switch (cobertura.oCobertura.CoberturaID)
                    {
                        case 420:
                        case 31808:
                            porcentajeMontoAsegurado = riesgo.MontoAsegurado * 0.01f;
                            break;
                        case 400:
                            Entidades.MateriaPropiedad oPropiedadMEE2 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                            porcentajeMontoAsegurado = oPropiedadMEE2.ValorEdificio * 0.02f;
                            break;
                    }
                    if (porcentajeMontoAsegurado > maximo)
                    {
                        monto9 = monto9 + maximo.ToString();
                    }
                    else
                    {
                        monto9 = monto9 + porcentajeMontoAsegurado.ToString();
                    }
                    resultado = monto9;
                    break;

                case 10:
                    Entidades.MateriaPropiedad oPropiedadMEE3 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    if (oPropiedadMEE3.MontoEquiposElectronicos > 0)
                        resultado = "UF " + oPropiedadMEE3.MontoEquiposElectronicos.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    else
                        resultado = oDistribucion.TextoMonto.ToString();
					break;

                case 11:
                    Entidades.MateriaPropiedad oPropiedad11 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    float monto11 = oPropiedad11.ValorContenido + oPropiedad11.ValorEdificio + oPropiedad11.MontoMercaderias
                                    +oPropiedad11.MontoMaquinarias + oPropiedad11.MontoEquiposElectronicos;
                    resultado = "UF " + monto11.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    break;

                case 12:
                    /* Maquinarias Equipos Electronicos */
                    Entidades.MateriaPropiedad oPropiedad12 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    float monto12 = oPropiedad12.MontoMaquinarias + oPropiedad12.MontoEquiposElectronicos;
                    resultado = "UF " + monto12.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    break;

                case 13:
                    /*Maquinarias*/
                    Entidades.MateriaPropiedad oPropiedad13 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    float monto13 = oPropiedad13.MontoMaquinarias;

                    //INICIO - WS015
                    if (oPoliza.oProducto.ProductoID == "00000000-0000-0000-0000-000000000275")
                    {
                        Respuesta resp = Datos.ProductoParametros.ObtenerTodos(new Guid(oPoliza.oProducto.ProductoID));
                        if (resp.Error == 0)
                        {
                            List<Entidades.ProductoParametros> listaParametros = (List<Entidades.ProductoParametros>)resp.Resultado;
                            if (listaParametros.Any(c => c.Parametro == "MAXIMO_VALOR_AVERIAMAQUINARIA"))
                            {
                                float MaximoAveriaM = listaParametros.Where(c => c.Parametro == "MAXIMO_VALOR_AVERIAMAQUINARIA").Select(c => c.Valor).First();
                                if (monto13 > MaximoAveriaM)
                                    monto13 = MaximoAveriaM;

                                resultado = "UF " + monto13.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                            }
                        }
                    }
                    else
                        //FIN - WS015
                        resultado = "UF " + monto13.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    break;

                case 14:
                    /* Mercaderias */
                    Entidades.MateriaPropiedad oPropiedad14 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    float monto14 = oPropiedad14.MontoMercaderias;
                    resultado = "UF " + monto14.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    break;

                case 15:
                    /*Contenido + Mercaderia + Maquinarias + Electronicos*/
                    Entidades.MateriaPropiedad oPropiedad15 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    float monto15 = oPropiedad15.ValorContenido + oPropiedad15.MontoMercaderias
                        + oPropiedad15.MontoMaquinarias + oPropiedad15.MontoEquiposElectronicos;
                    //ME002
                    resultado = "UF " + monto15.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "") + " " + oDistribucion.TextoMonto.ToString();
                    break;

                /* Edificio + Contenido com Maximo*/
                case 16:
                    /* Edificio + Contenido com Maximo*/
                    Entidades.MateriaPropiedad oPropiedadCE_2 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    float ContenidosMasEdificio_2 = oPropiedadCE_2.ValorContenido + oPropiedadCE_2.ValorEdificio;
                    float topeCobertura_2 = float.Parse(oDistribucion.TextoMonto.ToString());
                    if (ContenidosMasEdificio_2 < topeCobertura_2)
                        resultado = "UF " + ContenidosMasEdificio_2.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    else
                        resultado = "UF " + topeCobertura_2.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    break;

                case 17:
                    /* Monto RC Vehiculo*/
                    MateriaVehiculoBC oVehiculo = (MateriaVehiculoBC)riesgo.oMateria;
                    resultado = oVehiculo.MontoRC.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    break;


                case 18:
                    /* Monto PxP */
                    Entidades.MateriaPropiedad oPropiedad18 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    switch (oPoliza.oProducto.ProductoID)
                    {
                        case "00000000-0000-0000-0000-000000000260": //ANS Piloto
                            resultado = "UF " + oPropiedad18.MontoPxP.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "") + " " + oDistribucion.TextoMonto.ToString();
                            break;
                        case "00000000-0000-0000-0000-000000000261": //RSA Piloto
                            resultado = "UF "  + oPropiedad18.MontoPxP.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "") + " " + oDistribucion.TextoMonto.ToString();
                            break;
                        //Ini:Código: JC013
                        case "00000000-0000-0000-0000-000000000276": //PymeAce
                            //WS017
                            resultado = "UF " + oPropiedad18.MontoPxP.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "") + " " + oDistribucion.TextoMonto.ToString();
                            break;
                        case "00000000-0000-0000-0000-000000000274":
                            //WS017
                            resultado = "UF "  + oPropiedad18.MontoPxP.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "") + " " + oDistribucion.TextoMonto.ToString();
                            break;
                        case "00000000-0000-0000-0000-000000000275":
                            //WS017
                            resultado = "UF " + oPropiedad18.MontoPxP.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "") + " " + oDistribucion.TextoMonto.ToString();
                            break;
                        case "00000000-0000-0000-0000-000000000283":
                            //WS017
                            resultado = "UF "  + oPropiedad18.MontoPxP.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "") + " " + oDistribucion.TextoMonto.ToString();
                            break;
                        case "00000000-0000-0000-0000-000000000284":
                            resultado = "UF "  + oPropiedad18.MontoPxP.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "") + " " + oDistribucion.TextoMonto.ToString();
                            break;

                        //Fin:Código: JC013
                        default:
                            resultado = "UF " + oPropiedad18.MontoPxP.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                            break;
                    }
                    break;


                case 19:
					/* Monto RC Propiedad */
					Entidades.MateriaPropiedad oPropiedad19 = (Entidades.MateriaPropiedad) riesgo.oMateria;
                    resultado = "UF "  + oPropiedad19.MontoRC.ToString("N",CultureFormat.Cultura.NumberFormat).Replace(",00",""); 
					break;

               case 20:
				    /* Monto Cristales */
				    Entidades.MateriaPropiedad oPropiedad20 = (Entidades.MateriaPropiedad) riesgo.oMateria;
                    resultado = "UF " + oPropiedad20.Cristales.ToString("N",CultureFormat.Cultura.NumberFormat).Replace(",00","");
				    break;

               case 21:
					/* Monto Muerte Accidental */
					Entidades.MateriaPropiedad oPropiedad21 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                     resultado = "UF " +oPropiedad21.MontoMuerte.ToString("N",CultureFormat.Cultura.NumberFormat).Replace(",00","");
					break;


                case 22:
					/* Monto Dinero Caja Seguridad */
					Entidades.MateriaPropiedad oPropiedad22 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    resultado = "UF " +oPropiedad22.CajaSeguridad.ToString("N",CultureFormat.Cultura.NumberFormat).Replace(",00","");
					break;

               case 23:
					Entidades.MateriaPropiedad oPropiedad23 = (Entidades.MateriaPropiedad)riesgo.oMateria;

					float montototal = 0;
					if(cobertura.oCobertura.CoberturaID == 1070)
					{
						montototal = oPropiedad23.ValorContenido + oPropiedad23.MontoMaquinarias 
							+ oPropiedad23.MontoMercaderias + oPropiedad23.MontoEquiposElectronicos;
						if( montototal < 10000f)
                            resultado = "UF " +montototal.ToString("N",CultureFormat.Cultura.NumberFormat).Replace(",00","");
						else 
                            resultado = "UF 10.000";
					}
					else if(cobertura.oCobertura.CoberturaID == 2100)
					{
						montototal = oPropiedad23.MontoMaquinarias 
							+ oPropiedad23.MontoEquiposElectronicos;
						if( montototal < 15000f)
                             resultado = "UF " + montototal.ToString("N",CultureFormat.Cultura.NumberFormat).Replace(",00","");
						else 
                            resultado = "UF 15.000" ;
					}
					else if(cobertura.oCobertura.CoberturaID == 3162)
					{
						montototal = oPropiedad23.MontoEquiposElectronicos;
						if( montototal == 0)
                            resultado = "UF 2.000";
						else	if( montototal < 2000f)
                            resultado ="UF "+ montototal.ToString("N",CultureFormat.Cultura.NumberFormat).Replace(",00","");
						else 
                            resultado ="UF 2.000";
					}
					break;


                case 24:
					/* Contenido + Edificio + Mercaderias + Maquinarias*/
					Entidades.MateriaPropiedad oPropiedad24 = (Entidades.MateriaPropiedad)riesgo.oMateria;
					float monto24 = oPropiedad24.ValorContenido 
						+ oPropiedad24.ValorEdificio 
						+ oPropiedad24.MontoMercaderias
						+ oPropiedad24.MontoMaquinarias ;
                     resultado ="UF "+monto24.ToString("N",CultureFormat.Cultura.NumberFormat).Replace(",00","");
					break;

               case 25:
					/* Contenido + Mercaderias + Maquinarias*/
					Entidades.MateriaPropiedad oPropiedad25 = (Entidades.MateriaPropiedad) riesgo.oMateria;
					float monto25 = oPropiedad25.ValorContenido + oPropiedad25.MontoMercaderias
						+ oPropiedad25.MontoMaquinarias;
                    resultado ="UF "+ monto25.ToString("N",CultureFormat.Cultura.NumberFormat).Replace(",00","");
					break;

               case 26: 
					/*[Monto Máximo Remesa V.]*/
					Entidades.MateriaPropiedad oPropiedad26 = (Entidades.MateriaPropiedad) riesgo.oMateria;
					float monto26 = oPropiedad26.RemesaValores;
                    resultado ="UF "+ monto26.ToString("N",CultureFormat.Cultura.NumberFormat).Replace(",00","");
					break;

               case 27: 						
					/*[Monto Robo para Pyme Especial.]*/	
					Entidades.MateriaPropiedad oPropiedad27 = (Entidades.MateriaPropiedad)riesgo.oMateria;
					float monto27 = oPropiedad27.MontoMercaderias; // en pyme especial no se usa y es el monto robo
                    resultado ="UF "+monto27.ToString("N",CultureFormat.Cultura.NumberFormat).Replace(",00","");
					break;	

               case 28:
					/* Edificio + Contenido + PXP para Pyme Especial*/
					Entidades.MateriaPropiedad oPropiedadCE2 = (Entidades.MateriaPropiedad) riesgo.oMateria;
					float ContenidosMasEdificio2 = oPropiedadCE2.ValorContenido + oPropiedadCE2.ValorEdificio
						+ oPropiedadCE2.MontoPxP;
                    resultado ="UF " + ContenidosMasEdificio2.ToString("N",CultureFormat.Cultura.NumberFormat).Replace(",00","");
					break;	

                case 29:
					/*Contenido + Mercaderia + Maquinarias  +  Con Maximo 10.000*/							
					Entidades.MateriaPropiedad oPropiedad29 = (Entidades.MateriaPropiedad) riesgo.oMateria;
					float monto29 = oPropiedad29.ValorContenido + oPropiedad29.MontoMercaderias
						+ oPropiedad29.MontoMaquinarias ; //+ oPropiedad29.MontoEquiposElectronicos;

					if(monto29 > 10000f) monto29 = 10000f;
                    resultado ="UF " +monto29.ToString("N",CultureFormat.Cultura.NumberFormat).Replace(",00","");
					break;

				case 30:
					/* Monto RC Propiedad + El texto del monto  */
					Entidades.MateriaPropiedad oPropiedad30 = (Entidades.MateriaPropiedad) riesgo.oMateria;
                     resultado ="UF " + oPropiedad30.MontoRC.ToString("N",CultureFormat.Cultura.NumberFormat).Replace(",00","") + " " + oDistribucion.TextoMonto.ToString();					
					break;

				case 31:
					/* Monto Cristales + El texto del monto*/
					Entidades.MateriaPropiedad oPropiedad31 = (Entidades.MateriaPropiedad) riesgo.oMateria;
                    resultado ="UF " +oPropiedad31.Cristales.ToString("N",CultureFormat.Cultura.NumberFormat).Replace(",00","")+ " " + oDistribucion.TextoMonto.ToString();
					break;

				case 32:
					/* Copia el texto del monto + Monto Asegurado  */
                    resultado ="UF " + riesgo.MontoAsegurado.ToString("N",CultureFormat.Cultura.NumberFormat).Replace(",00","");
					break;
                case 33:
                    /*Menor valor entre el valor contenido y un tope que está en prima Adicional */
                    Entidades.MateriaPropiedad oPropiedad32 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    float valorContenido = 1000f;

                    if (oPropiedad32.ValorContenido < 1000f)
                        valorContenido = oPropiedad32.ValorContenido;

                    resultado ="UF " +valorContenido.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "") + " " + oDistribucion.TextoMonto;
                    
                    break;

                case 34:
					Entidades.MateriaPropiedad oPropiedad34 = (Entidades.MateriaPropiedad) riesgo.oMateria;
					float monto34 = oPropiedad34.ValorContenido + oPropiedad34.MontoMercaderias + oPropiedad34.MontoMaquinarias + oPropiedad34.MontoEquiposElectronicos;

					if(monto34 > 15000f) monto34 = 15000f;

                     resultado ="UF "+ monto34.ToString("N",CultureFormat.Cultura.NumberFormat).Replace(",00","");
					break;

				case 35:
					string texto35 = "";
					switch(cobertura.oCobertura.CoberturaID)
					{
						case 380://Cristales
							texto35 = ( (Entidades.MateriaPropiedad) riesgo.oMateria).Cristales.ToString();
							texto35 ="UF " +  texto35 + " por evento y vigencia";
							break;
						case 2127://Responsabilidad Civil – Empresa – Propietario Inmueble
							texto35 = ( (Entidades.MateriaPropiedad) riesgo.oMateria).MontoRC.ToString();
							texto35 ="UF " +  texto35 + " por evento y vigencia";
							break;
						case 3162://Equipos Electrónicos
						case 3165:
							float montoEE35 = ( (Entidades.MateriaPropiedad) riesgo.oMateria).MontoEquiposElectronicos;
							if(montoEE35 > 15000f) montoEE35 = 15000f;
							texto35 = "UF " + montoEE35.ToString("N",CultureFormat.Cultura).Replace(",00","");
							break;

						case 2130:
						case 2131:
							texto35 = ( (Entidades.MateriaPropiedad) riesgo.oMateria).MontoPxP.ToString();
							texto35 ="UF " +  texto35 + " periodo indemnizable 6 meses";
							break;
						case 2132://Responsabilidad Civil Patronal
							if(( (Entidades.MateriaPropiedad) riesgo.oMateria).MontoRC <= 100f)
								texto35 ="Hasta UF 100 por evento y vigencia";
							else
								texto35 ="Hasta UF 300 por evento y vigencia";
							break;
							
					}
                    resultado = texto35;
					break;

					case 36:
						//ini fc016
						Entidades.MateriaPropiedad oPropiedad36 = (Entidades.MateriaPropiedad) riesgo.oMateria;
						float monto36 = oPropiedad36.ValorContenido + oPropiedad36.ValorEdificio + oPropiedad36.MontoMercaderias
							+ oPropiedad36.MontoMaquinarias;
						//fin fc016
                    

                        resultado = "UF "  + monto36.ToString("N",CultureFormat.Cultura.NumberFormat).Replace(",00","") ;
						break;

					case 37:
						MateriaVehiculoBC oPropiedad37 = (MateriaVehiculoBC) riesgo.oMateria;
						resultado = "UF "+ oPropiedad37.MontoTransporte.ToString("N",CultureFormat.Cultura.NumberFormat).Replace(",00","") ;
 					break;

					case 38:
						Entidades.MateriaPropiedad oPropiedad38 = (Entidades.MateriaPropiedad) riesgo.oMateria;
						float monto38 = oPropiedad38.ValorContenido + oPropiedad38.MontoMercaderias
							+ oPropiedad38.MontoMaquinarias ; //+ oPropiedad29.MontoEquiposElectronicos;

                        resultado = "UF "  + monto38.ToString("N",CultureFormat.Cultura.NumberFormat).Replace(",00","") ;
						break;

					case 39:
                    
						MateriaTodoRiesgoConstruccionBC oTRC = (MateriaTodoRiesgoConstruccionBC) riesgo.oMateria;
						float monto39 = oTRC.MontoObra;
                        resultado = "UF "+ monto39.ToString("N",CultureFormat.Cultura.NumberFormat).Replace(",00","") ;
						break;


                case 40:
                    //Ini--VS009							
                    if (oPoliza.oProducto.ProductoID == "00000000-0000-0000-0000-000000000415")
                    {
                        resultado = "UF " + "0";
                    }
                    else
                    {
                        Entidades.MateriaPropiedad oProp40 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                        float monto40 = oProp40.ValorContenido;
                        if (monto40 >= float.Parse(oDistribucion.TextoMonto.ToString()))
                        {
                            monto40 = 1000f;
                        }
                        resultado = "UF " + monto40.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    }
                    //Fin--VS009
                    break;

                case 41:
                    Entidades.MateriaPropiedad oProp41 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    float monto41 = oProp41.ValorContenido;
                    float valorBd41 = float.Parse(oDistribucion.TextoMonto.ToString());

                    if (monto41 >= valorBd41)
                    {
                        monto41 = valorBd41;
                    }
                    resultado = "UF " + monto41.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    break;

                case 42:
                    //Monto de RC
                    if (riesgo.oTipoMateriaAsegurada.TipoMateriaID == 11)
                    {
                        resultado = "UF "+ ((Entidades.MateriaRCConstruccion)riesgo.oMateria).MontoRC.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    }
                    else if (riesgo.oTipoMateriaAsegurada.TipoMateriaID == 12)
                    {
                        resultado = "UF "+ ((Entidades.MateriaRCMOP)riesgo.oMateria).MontoRC.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    }
                    break;

                case 43:
                    /* PORCENTAJE DE EDIFICIO */
                    Entidades.MateriaPropiedad oPropiedad43 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    float valorEdificio43 = oPropiedad43.ValorEdificio;
                    float porcentaje43 = float.Parse(oDistribucion.TextoMonto) / 100f;
                    float monto43 = valorEdificio43 * porcentaje43;

                    resultado = "UF "+ monto43.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    


                    break;

                case 44:
                    /* MENOR ENTRE X EDIFICIO * Y MESES Y Z EDIFICIO */
                    Entidades.MateriaPropiedad oPropiedad44 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    float valorEdificio44 = oPropiedad44.ValorEdificio;
                    string[] texto44 = oDistribucion.TextoMonto.Split('|');
                    float monto44_1 = (valorEdificio44 * float.Parse(texto44[0]) / 100f) * float.Parse(texto44[1]);
                    float monto44_2 = valorEdificio44 * float.Parse(texto44[2]) / 100f;

                    if (monto44_1 > monto44_2) monto44_1 = monto44_2;

                    resultado = "UF "+  monto44_1.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");

                    break;
                case 45:
                    /* El menor valor entre Monto Edificio y el valor del tope de la cobertura */
                    //el monto se almacena en el valor TextoMonto
                    Entidades.MateriaPropiedad oPropiedad45 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    float topeCobertura45 = float.Parse(oDistribucion.TextoMonto);
                    if (oPropiedad45.ValorContenido < topeCobertura45)
                        resultado = "UF " + oPropiedad45.ValorContenido.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    else
                        resultado = "UF " + topeCobertura45.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    break;
                // Ini - JM018
                //Ini - FF033
                case 46:
                    /*Monto Edificio + Monto Contenido + Monto Mercadería + Monto Maquinaria + Monto en Mejoras Inmueble*/
                    Entidades.MateriaPropiedad oProp46 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    float monto46 = oProp46.ValorEdificio + oProp46.ValorContenido + oProp46.MontoMercaderias +
                        oProp46.MontoMaquinarias;// + oProp46.MejoraInmueble;
                     resultado = "UF "+ monto46.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");

                    break;
                /* TEXTO + [MONTO] + TEXTO*/
                case 47:
                    Entidades.MateriaPropiedad oProp47 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    float montoTotal47 = oProp47.ValorEdificio + oProp47.ValorContenido + oProp47.MontoMercaderias +
                        oProp47.MontoMaquinarias; //+ oProp47.MejoraInmueble;
                    string texto47 = oDistribucion.TextoMonto; //oDistribucion.TextoMonto.ToString();
                    int inicioTexto = texto47.IndexOf("[");
                    int finTexto = texto47.IndexOf("]");
                    if (inicioTexto > 0 && finTexto > 0)
                    {
                        string limiteTexto = texto47.Substring(inicioTexto, finTexto - inicioTexto + 1);
                        string limiteCalculado = "";
                        switch (limiteTexto)
                        {
                            case "[Monto (I)]":
                                limiteCalculado = montoTotal47.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                                break;
                            case "[MontoRC]":
                                limiteCalculado = oProp47.MontoRC.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                                break;
                            case "[RCPatronal]":
                                limiteCalculado = oProp47.MontoRC.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                                break;
                            case "[10% MontoEE <= UF25]":
                                float montoEE47 = oProp47.MontoEquiposElectronicos * 0.1f;
                                if (montoEE47 > 25f) montoEE47 = 25f;
                                limiteCalculado = montoEE47.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                                break;
                            case "[Cristales - 50]":
                                if (oProp47.Cristales > 50)
                                {
                                    float cristalesMenos50 = oProp47.Cristales - 50;
                                    limiteCalculado = cristalesMenos50.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                                }
                                else texto47 = "";
                                break;
                            case "[CajaSeguridad]":
                                limiteCalculado = oProp47.CajaSeguridad.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                                break;
                            case "[Cristales]":
                                limiteCalculado = oProp47.Cristales.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                                break;
                            case "[PXP]":
                                limiteCalculado = oProp47.MontoPxP.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                                break;
                            case "[RemesaValores]":
                                limiteCalculado = oProp47.RemesaValores.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                                break;
                            case "[MontoMuerte]":
                                limiteCalculado = oProp47.MontoMuerte.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                                break;
                            case "[MontoEE =< UF 5.000]":
                                float montoE47 = oProp47.MontoEquiposElectronicos;
                                if (montoE47 > 5000f) montoE47 = 5000f;
                                limiteCalculado = montoE47.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                                break;
                            case "[10% MontoEE <= UF150]":
                                float montoEEE47 = oProp47.MontoEquiposElectronicos * 0.1f;
                                if (montoEEE47 > 150f) montoEEE47 = 150f;
                                limiteCalculado = montoEEE47.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                                break;
                            case "[MontoMercaderías <= UF500]":
                                float montoMer47 = oProp47.MontoMercaderias;
                                if (montoMer47 > 500f) montoMer47 = 500f;
                                limiteCalculado = montoMer47.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                                break;
                            case "[10% Monto (I) <= UF25.000]":
                                montoTotal47 = montoTotal47 * 0.1f;
                                if (montoTotal47 > 25000f) montoTotal47 = 25000f;
                                limiteCalculado = montoTotal47.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                                break;



                        }
                        texto47 = texto47.Replace(limiteTexto, limiteCalculado);
                    }
                    resultado = texto47; 
                    break;
                //Fin - FF033
                //FF033
                case 48:

                    if (riesgo.oMateria is MateriaTodoRiesgoConstruccionBC)
                    {
                        MateriaTodoRiesgoConstruccionBC oTRCAce = (MateriaTodoRiesgoConstruccionBC)riesgo.oMateria;
                        //Ini RA005 TRC ACE
                        switch (cobertura.oCobertura.CoberturaID)
                        {
                            case 31024:

                                float monto48 = oTRCAce.MontoObra;
                                monto48 = (monto48 * 10) / 100;

                                if (monto48 > 5000)
                                {
                                    monto48 = 5000;
                                }
                                resultado = "UF " + monto48.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                                break;
                        }
                    }

                    else
                    {
                        /*  MONTO PARA EQUIPO MOVIL CONTRATISTA BCI */
                        Entidades.MateriaEquipoContratista oEquipo46 = (Entidades.MateriaEquipoContratista)riesgo.oMateria;
                        switch (cobertura.oCobertura.CoberturaID)
                        {
                            case 30588:
                                resultado = oEquipo46.MontoDP;// Monto Equipo
                                break;

                            case 30589:
                                resultado = oEquipo46.MontoGTo;// Monto Gasto Salvamento
                                break;

                            case 30590:
                            case 30591:
                            case 30592:
                                resultado = oEquipo46.MontoDP; // Monto Equipo
                                break;



                            case 30595:
                                resultado = oEquipo46.MontoRC; // Monto RC
                                break;

                            default:
                                resultado = oDistribucion.TextoMonto;
                                break;
                        }
                    }

                    

                    break;
                // Fin - JM018

                //Ini RA019
                //FF033
                case 49:
                    if (riesgo.oMateria is Entidades.MateriaPropiedad)
                    {/* Monto RC Propiedad vs tope 300 UF + El texto del monto  */
                        Entidades.MateriaPropiedad oPropiedad49 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                        int montoMostrar49 = 0;
                        if (oPropiedad49.MontoRC >= 300)
                            montoMostrar49 = 300;
                        else
                            montoMostrar49 = oPropiedad49.MontoRC;

                        resultado = "UF " + montoMostrar49.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "") + " " + oDistribucion.TextoMonto.ToString();

                    }
                    else
                    {
                        /*  Monto para AP Colectivo */
                        Entidades.MateriaAPColectivo materia = new Entidades.MateriaAPColectivo();
                        materia = (Entidades.MateriaAPColectivo)riesgo.oMateria;

                        string texto = materia.CapitalMAD + " por empleado, con un límite máximo de UF " + ((materia.CapitalMAD / 100 * 20) * materia.Empleados) + " o UF 50.000 por evento y de " + ((materia.CapitalMAD / 100 * 20) * materia.Empleados) + " o UF 50.000*2 como límite maximo anual";
                        resultado = texto;
                    }

                    break;
                //Fin RA019 consultar;
                //INICIO - WS035
                //case 50:
                //    Entidades.MateriaRCAgricola oEquipo50 = (Entidades.MateriaRCAgricola)riesgo.oMateria;
                //    float _totalF = oEquipo50.FacturacionAnual;
                //    Respuesta parametro = Negocio.TablaMontosRCAgricolaBC.Obtener(int.Parse(_totalF.ToString()));
                //    switch (cobertura.oCobertura.CoberturaID)
                //    {
                //        case 31008:
                //            x.Append(Singular.FormatXmlTag("RCPatronalEmpleado", (((Entidades.TablaMontosRCAgricola)parametro.Resultado).RCPatronalxEmpleado).ToString()));
                //            x.Append(Singular.FormatXmlTag("RCPatronalEvento", (((Entidades.TablaMontosRCAgricola)parametro.Resultado).RCPatronalxEvento).ToString()));
                //            x.Append(Singular.FormatXmlTag("RCPatronalAgregado", (((Entidades.TablaMontosRCAgricola)parametro.Resultado).RCPatronalxAgregado).ToString()));
                //            break;
                //        case 31014:
                //            x.Append(Singular.FormatXmlTag("RCVehicularxEvento", (((Entidades.TablaMontosRCAgricola)parametro.Resultado).RCVehicularxEvento).ToString()));
                //            x.Append(Singular.FormatXmlTag("RCVehicularxAgregado", (((Entidades.TablaMontosRCAgricola)parametro.Resultado).RCVehicularxAgregado).ToString()));
                //            break;
                //        case 31017:
                //            x.Append(Singular.FormatXmlTag("RCPenalxEvento", (((Entidades.TablaMontosRCAgricola)parametro.Resultado).RCPenalxEvento).ToString()));
                //            x.Append(Singular.FormatXmlTag("RCPenalxAgregado", (((Entidades.TablaMontosRCAgricola)parametro.Resultado).RCPenalxAgregado).ToString()));
                //            break;


                //        //Ini:Código: JC038
                //        case 31002:
                //            x.Append(Singular.FormatXmlTag("RCCivilEmpresaxEvento", (((Entidades.TablaMontosRCAgricola)parametro.Resultado).RCCivilEmpresaxEvento).ToString()));
                //            x.Append(Singular.FormatXmlTag("RCCivilEmpresaxAgregado", (((Entidades.TablaMontosRCAgricola)parametro.Resultado).RCCivilEmpresaxAgregado).ToString()));
                //            break;

                //        case 31004:
                //            x.Append(Singular.FormatXmlTag("RCCivilPolucionxEvento", (((Entidades.TablaMontosRCAgricola)parametro.Resultado).RCCivilPolucionxEvento).ToString()));
                //            x.Append(Singular.FormatXmlTag("RCCivilPolucionxAnual", (((Entidades.TablaMontosRCAgricola)parametro.Resultado).RCCivilPolucionxAnual).ToString()));
                //            break;

                //        case 31010:
                //            x.Append(Singular.FormatXmlTag("RCTransportexAnual", (((Entidades.TablaMontosRCAgricola)parametro.Resultado).RCTransportexAnual).ToString()));
                //            x.Append(Singular.FormatXmlTag("RCTransportexEvento", (((Entidades.TablaMontosRCAgricola)parametro.Resultado).RCTransportexEvento).ToString()));
                //            x.Append(Singular.FormatXmlTag("RCTransportexEmpleado", (((Entidades.TablaMontosRCAgricola)parametro.Resultado).RCTransportexEmpleado).ToString()));
                //            break;

                //        //Fin:Código: JC038

                //        //INICIO - WS042
                //        case 31018:
                //            x.Append(Singular.FormatXmlTag("RCConstxEvento", (((Entidades.TablaMontosRCAgricola)parametro.Resultado).RCCivilEmpresaxEvento).ToString()));
                //            x.Append(Singular.FormatXmlTag("RCConstxAgregado", (((Entidades.TablaMontosRCAgricola)parametro.Resultado).RCCivilEmpresaxAgregado).ToString()));
                //            break;
                //        //FIN - WS042

                //    }
                //    break;
                //FIN - WS035
                case 51:
                    /* uf + RC + textomonto  */
                    Entidades.MateriaPropiedad oPropiedad51 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    int montoMostrar51 = 0;
                    if (oPropiedad51.MontoRC >= 1000)
                        montoMostrar51 = 1000;
                    else
                        montoMostrar51 = oPropiedad51.MontoRC;

                    resultado = "UF " + montoMostrar51.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    break;

                case 52:
                    /* Minimo entre (RC y tope 200 UF)*/
                    Entidades.MateriaPropiedad oPropiedad52 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    int montoMostrar52 = 0;
                    if (oPropiedad52.MontoRC >= 200)
                        montoMostrar52 = 200;
                    else
                        montoMostrar52 = oPropiedad52.MontoRC;

                    resultado = "UF " + montoMostrar52.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                   
                    break;

                case 53:
                    /* MontoEE + TextoMonto */
                    Entidades.MateriaPropiedad oPropiedad53 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    resultado = "UF " + oPropiedad53.MontoEquiposElectronicos.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "") + " " + oDistribucion.TextoMonto.ToString();

                    break;

                case 54:
                    /* menor RC vs 1000 + texto + menor RC vs 300*/
                    //Ini FC016

                    if (oPoliza.oProducto.ProductoID == "00000000-0000-0000-0000-000000000275")
                    {
                        Respuesta resp = Datos.ProductoParametros.ObtenerTodos(new Guid(oPoliza.oProducto.ProductoID));
                        if (resp.Error == 0)
                        {
                            List<Entidades.ProductoParametros> listaParametros = (List<Entidades.ProductoParametros>)resp.Resultado;
                            if (listaParametros.Any(c => c.Parametro == "MAXIMO_VALOR_RC"))
                            {
                                float MaximoRC54 = (float)listaParametros.Where(c => c.Parametro == "MAXIMO_VALOR_RC").Select(c => c.Valor).First();
                                Entidades.MateriaPropiedad oPropiedad54 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                                float montoMostrar54A = 0;
                                float montoMostrar54B = 0;
                                if (oPropiedad54.MontoRC >= MaximoRC54)
                                    montoMostrar54A = MaximoRC54;
                                else
                                    montoMostrar54A = oPropiedad54.MontoRC;

                                if (oPropiedad54.MontoRC >= 300)
                                    montoMostrar54B = 300;
                                else
                                    montoMostrar54B = oPropiedad54.MontoRC;

                                resultado = "UF " + montoMostrar54A.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "") + " por vigencia con un tope de UF " +
                                                        montoMostrar54B.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "") + " " + oDistribucion.TextoMonto.ToString();


                            }
                        }
                    }

                    break;
                //Fin FC016
                //FIN:FC011

                //Ini:Código: JC013
                case 55:
                    //ini FC016
                    /* EQUIPO ELECTRONICO PYME */
                   Respuesta respx = Datos.ProductoParametros.ObtenerTodos(new Guid(oPoliza.oProducto.ProductoID));
                   if (respx.Error == 0)
                    {
                        List<Entidades.ProductoParametros> listaParametros = (List<Entidades.ProductoParametros>)respx.Resultado;
                        if (listaParametros.Any(c => c.Parametro == "MAXIMO_VALOR_EQUIPOE"))
                        {
                            float MaximoEE55 = (float)listaParametros.Where(c => c.Parametro == "MAXIMO_VALOR_EQUIPOE").Select(c => c.Valor).First();


                            Entidades.MateriaPropiedad oPropiedad55 = (Entidades.MateriaPropiedad)riesgo.oMateria;

                            float montoMostrar55 = 0;

                            if (oPropiedad55.MontoEquiposElectronicos > MaximoEE55)
                                montoMostrar55 = MaximoEE55;
                            else
                                montoMostrar55 = oPropiedad55.MontoEquiposElectronicos;

                            resultado = "UF " + montoMostrar55.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                            
                        }
                    }
                    break;
                //Fin FC016
                //Fin:Código: JC013
                case 56:
                    /* uf + RC + textomonto  */
                   Respuesta respxx = Datos.ProductoParametros.ObtenerTodos(new Guid(oPoliza.oProducto.ProductoID));
                   if (respxx.Error == 0)
                   {
                       List<Entidades.ProductoParametros> listaParametros = (List<Entidades.ProductoParametros>)respxx.Resultado;
                       if (listaParametros.Any(c => c.Parametro == "MAXIMO_VALOR_RC"))
                       {
                           float MaximoRC56 = (float)listaParametros.Where(c => c.Parametro == "MAXIMO_VALOR_RC").Select(c => c.Valor).First();
                           Entidades.MateriaPropiedad oPropiedad56 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                           float montoMostrar56 = 0;
                           if (oPropiedad56.MontoRC >= MaximoRC56)
                               montoMostrar56 = MaximoRC56;
                           else
                               montoMostrar56 = oPropiedad56.MontoRC;
                           
                           resultado = "UF " + montoMostrar56.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "") + " " + oDistribucion.TextoMonto.ToString();

                       }
                   }

                    break;
                //Ini FC016
                case 57:
                    /* monto max  robo segun bd + textomonto  */
                    Respuesta respxxx = Datos.ProductoParametros.ObtenerTodos(new Guid(oPoliza.oProducto.ProductoID));
                    if (respxxx.Error == 0)
                    {
                        List<Entidades.ProductoParametros> listaParametros = (List<Entidades.ProductoParametros>)respxxx.Resultado;
                        if (listaParametros.Any(c => c.Parametro == "MAXIMO_VALOR_ROBO"))
                        {
                            float MaximoRobo57 = (float)listaParametros.Where(c => c.Parametro == "MAXIMO_VALOR_ROBO").Select(c => c.Valor).First();

                            Entidades.MateriaPropiedad oPropiedad57 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                            float montoEvaluar = oPropiedad57.MontoMercaderias + oPropiedad57.MontoMaquinarias + oPropiedad57.ValorContenido;
                            float montoMostrar57 = 0;

                            if (montoEvaluar >= MaximoRobo57)
                                montoMostrar57 = MaximoRobo57;
                            else
                                montoMostrar57 = montoEvaluar;

                            resultado = "UF " + montoMostrar57.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "") + " " + oDistribucion.TextoMonto.ToString();
                        }
                    }

                    break;
                //Fin FC016

                //Ini:JC003
                //Menor Valor entre Monto Asegurado y Texto Monto
                case 58:
                    Entidades.MateriaPropiedad oPropiedad58 = (Entidades.MateriaPropiedad)riesgo.oMateria;
                    float monto58 = oPropiedad58.ValorContenido
                        + oPropiedad58.ValorEdificio
                        + oPropiedad58.MontoMercaderias
                        + oPropiedad58.MontoMaquinarias;

                    float textoMonto58 = float.Parse(oDistribucion.TextoMonto.ToString());

                    if (monto58 < textoMonto58)
                    {
                        resultado = "UF " + monto58.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                        //distribucion.Append(this.FormatXmlTag("Monto", "UF " + monto58.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "")));
                    }
                    else
                    {
                        resultado = "UF " + textoMonto58.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                        //distribucion.Append(this.FormatXmlTag("Monto", "UF " + textoMonto58.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "")));

                    }
                    break;

                case 59:
                    string texto59 = string.Empty;
                    Respuesta respxxx59 = Datos.ProductoParametros.ObtenerParametrosTexto(oPoliza.oProducto.ProductoID.ToString(),"TEXTO_DEDUCIBLEROBO");
                    if (respxxx59.Error == 0)
                    {
                        texto59 = respxxx59.Resultado.ToString();
                    }

                    resultado = texto59;
                    //string Texto = ObtenerValorParametroTexto(dtParametros59, "TEXTO_DEDUCIBLEROBO");
                    //distribucion.Append(this.FormatXmlTag("Monto", Texto.ToString()));

                    break;


                //Fin:Código: JC003

                //Ini:Código: JC004
                case 60:
                     string texto60 = string.Empty;
                    Respuesta respxxx60 = new Respuesta();
                    switch (oDistribucion.CoberturaID)
                    {
                        case 31854:
                            respxxx60 = Datos.ProductoParametros.ObtenerParametrosTexto(oPoliza.oProducto.ProductoID.ToString(), "TEXTOMONTO_DANOS_MATERIALES");
                            if (respxxx60.Error == 0)
                            {
                                texto60 = respxxx60.Resultado.ToString();
                            }
                            break;

                        case 31856:
                            respxxx60 = Datos.ProductoParametros.ObtenerParametrosTexto(oPoliza.oProducto.ProductoID.ToString(), "TEXTOMONTO_ROTURA");
                            if (respxxx60.Error == 0)
                            {
                               
                            }
                            break;

                        case 31855:
                            respxxx60 = Datos.ProductoParametros.ObtenerParametrosTexto(oPoliza.oProducto.ProductoID.ToString(), "TEXTOMONTO_INCENDIO_TERRORISTAS");
                            if (respxxx60.Error == 0)
                            {
                                texto60 = respxxx60.Resultado.ToString();
                            }
                            float ValorMaxIncedioTerro = 0f;
                            respxxx60 = Datos.ProductoParametros.ObtenerParametrosTexto(oPoliza.oProducto.ProductoID.ToString(), "VALORMONTO_INCENDIO_TERRORISTAS");
                             if (respxxx60.Error == 0)
                             {
                                  ValorMaxIncedioTerro = float.Parse(respxxx60.Resultado.ToString());
                             }
                            
                            float monto60 = riesgo.MontoAsegurado;

                            float valorFinal = 0f;
                            if (monto60 < ValorMaxIncedioTerro)
                                valorFinal = monto60;
                            else
                                valorFinal = ValorMaxIncedioTerro;

                            texto60 += " " + valorFinal.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");

                            break;
                    }
                    //INI RJNV020
                    if (oPoliza.oProducto.oAgrupacion.Id == 200) //PYMES
                    {
                        resultado =  ObtenerMontoPorCobertura(riesgo,cobertura);
                    }
                    //FIN RJNV020
                    break;
                //Fin:Código: JC004
                //Ini:Código: CI015
                case 61 :
                    string textoMonto61 = oDistribucion.TextoMonto;
                    float MontoRC61=0f;
                    if (riesgo.oTipoMateriaAsegurada.TipoMateriaID == (int)Negocio.eeMateriaCatalog.eRCEmpresa)
                    {
                        Entidades.MateriaRCEmpresa oMateriaRC61 = (Entidades.MateriaRCEmpresa)riesgo.oMateria;
                        MontoRC61 = oMateriaRC61.MontoRC;
                    }
                    else if (riesgo.oTipoMateriaAsegurada.TipoMateriaID == (int)Negocio.eeMateriaCatalog.eRCContrato)
                    {
                        Entidades.MateriaRCContrato oMateriaRCContrato61 = (Entidades.MateriaRCContrato)riesgo.oMateria;
                        MontoRC61 = oMateriaRCContrato61.MontoRC;
                    }
                    resultado = (textoMonto61 + " " + MontoRC61.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "")).ToString();
                    
                    break;

                case 62:
                    
                    float Monto62 = float.Parse(oDistribucion.TextoMonto);
                    float MontoRC62 = 0f;;

                    if (riesgo.oTipoMateriaAsegurada.TipoMateriaID == (int)Negocio.eeMateriaCatalog.eRCEmpresa)
                    {
                        Entidades.MateriaRCEmpresa oMateriaRC62 = (Entidades.MateriaRCEmpresa)riesgo.oMateria;
                        MontoRC62 = oMateriaRC62.MontoRC;
                    }
                    else if (riesgo.oTipoMateriaAsegurada.TipoMateriaID == (int)Negocio.eeMateriaCatalog.eRCContrato)
                    {
                        Entidades.MateriaRCContrato oMateriaRCContrato62 = (Entidades.MateriaRCContrato)riesgo.oMateria;
                        MontoRC62 = oMateriaRCContrato62.MontoRC;
                    }


                    if (MontoRC62 < Monto62)
                        resultado = "UF " + (MontoRC62.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "")).ToString();
                    else
                        resultado = "UF "+ (Monto62.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "")).ToString();

                    break;

                case 63:
                    Entidades.MateriaRCContrato oMateriaRC63 = (Entidades.MateriaRCContrato)riesgo.oMateria;
                    Respuesta resp63 = new Respuesta();
                    resp63 = Datos.ProductoParametros.ObtenerTodos(new Guid(oPoliza.oProducto.ProductoID));
                    if (resp63.Error == 0)
                    {
                        List<Entidades.ProductoParametros> listaParametros63 = (List<Entidades.ProductoParametros>)resp63.Resultado;
                        float MontoRcMenorValor = listaParametros63.Where(c => c.Parametro == "MENORVALORMONTORC_TRAMO1").Select(c => c.Valor).First();
                        float MontoRcMenorValor2 = listaParametros63.Where(c => c.Parametro == "MENORVALORMONTORC_TRAMO2").Select(c => c.Valor).First();

                        
                        float MontoRC63 = oMateriaRC63.MontoRC;
                        if (MontoRcMenorValor < MontoRC63)
                            resultado = "UF " + (MontoRcMenorValor.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "")).ToString();
                        else
                            resultado = "UF " + (MontoRC63.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "")).ToString();

                        resultado += " "+ "por empleado. Tope de evento y vigencia anual UF ";
                        if (MontoRcMenorValor2 < MontoRC63)
                            resultado +=  (MontoRcMenorValor2.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "")).ToString();
                        else
                            resultado += (MontoRC63.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "")).ToString();


                    }
                    else
                    {

                        return resultado;
                    }
                    
                    break;

                case 64:
                    Entidades.MateriaRCEmpresa oMateriaRC64 = (Entidades.MateriaRCEmpresa)riesgo.oMateria;
                    Respuesta resp64 = new Respuesta();
                    resp64 = Datos.ProductoParametros.ObtenerTodos(new Guid(oPoliza.oProducto.ProductoID));
                    if (resp64.Error == 0)
                    {
                        List<Entidades.ProductoParametros> listaParametros63 = (List<Entidades.ProductoParametros>)resp64.Resultado;
                        float montoMaximoEmpleado = listaParametros63.Where(c => c.Parametro == "MONTOMAXIMOEMPLEADO").Select(c => c.Valor).First();
                        float montoMaximoEvento = listaParametros63.Where(c => c.Parametro == "MONTOMAXIMOEVENTO").Select(c => c.Valor).First();
                        float montoMaximoVigencia = listaParametros63.Where(c => c.Parametro == "MONTOMAXIMOVIGENCIAANUAL").Select(c => c.Valor).First();

                        string textoMontoPatronal_1 = string.Empty;
                        string textoMontoPatronal_2 = string.Empty;

                        resp64 =Datos.ProductoParametros.ObtenerParametrosTexto(oPoliza.oProducto.ProductoID.ToString(), "TEXTOMONTOPATRONAL_TRAMO1");
                        if (resp64.Error == 0)
                        {
                            textoMontoPatronal_1 = resp64.Resultado.ToString();
                        }
                        resp64 = Datos.ProductoParametros.ObtenerParametrosTexto(oPoliza.oProducto.ProductoID.ToString(), "TEXTOMONTOPATRONAL_TRAMO2");
                        if (resp64.Error == 0)
                        {
                            textoMontoPatronal_2 = resp64.Resultado.ToString();
                        }

                        string TextoMonto64 = oDistribucion.TextoMonto;
                        float MontoRC64 = oMateriaRC64.MontoRC;
                        if (montoMaximoEmpleado < MontoRC64)
                                resultado = TextoMonto64 + " " + (montoMaximoEmpleado.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "")).ToString();
                        else
                                resultado = TextoMonto64 + " " + (MontoRC64.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "")).ToString();

                        resultado += " " + textoMontoPatronal_1;

                        if (montoMaximoEvento < MontoRC64)
                            resultado += (montoMaximoEvento.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "")).ToString();
                        else
                            resultado += (MontoRC64.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "")).ToString();

                        resultado += " " + textoMontoPatronal_2;

                        if (montoMaximoVigencia < MontoRC64)
                            resultado += (montoMaximoVigencia.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "")).ToString();
                        else
                            resultado += (MontoRC64.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "")).ToString();

                    }
                    else
                    {
                        return resultado;
                    }

                    break;


                //Fin:Código: CI015

                    //CR018
                case 65:
                    /* Copia Monto Asegurado de la cobertura*/
                    resultado = cobertura.SumaAsegurada.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                    break; 

            }

            return resultado;
        }

        /// <summary>
        /// Obtiene la descripcion del monto asegurado para la agrupacion PYME,
        /// para las coberturas indicadas en jira MTRXCL-241
        /// Autor : Ricardo Nuñez (Gn-sis)
        /// Fecha : 22-05-2017
        /// </summary>
        /// <param name="riesgo">Se utilza el monto de esta Entidad</param>
        /// <param name="cobertura">Se utiliza el id de la cobertura de esta entidad</param>
        /// <returns>El texto que se debe mostrar en el cuadro de coberturas en la columna Limites</returns>
        private static string ObtenerMontoPorCobertura(Entidades.PolizaRiesgo riesgo, Entidades.PolizaRiesgoCobertura cobertura)
        {
            string resultado = string.Empty;

                switch (cobertura.oCobertura.CoberturaID)
                 {
                   case 31855: //Incendio y Daños materiales por actos terroristas
                         Entidades.MateriaPropiedad materiaCondominio = ((Entidades.MateriaPropiedad)riesgo.oMateria);

                         float montoEspaciosComunes = materiaCondominio.ValorEdificio;
                         float montoDepartamento = materiaCondominio.ValorContenido;
                         float sumaDeMontos = montoEspaciosComunes + montoEspaciosComunes;
                         float montoMaximo = 50000;
                         resultado = "Limte de ";
                         if (sumaDeMontos < montoMaximo)
                             resultado += sumaDeMontos.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                         else if (sumaDeMontos >= montoMaximo)
                             resultado += montoMaximo.ToString("N", CultureFormat.Cultura.NumberFormat).Replace(",00", "");
                         else
                             resultado += "0";
                         break;
                   case 31857: // Averia de Maquinarias
                        if (riesgo.MontoAsegurado > 250000)
                            resultado = "UF 3.000 por evento";
                        else
                            resultado = "UF 2.000 por evento y en el agregado";
                        break;
                    
                    case 31858: //Equipos e Instalaciones Electrónicas
                        if (riesgo.MontoAsegurado > 200000)
                            resultado = "Hasta UF 2.000";
                        else
                            resultado = "Hasta UF 1.000";
                        break;
                    case 31865: //Reparaciones provisorias
                        if (riesgo.MontoAsegurado > 100000)
                            resultado = "Hasta UF 2.000 por evento y agregado por la vigencia de la póliza";
                        else
                            resultado = "Hasta UF 1.000 por evento y agregado por la vigencia de la póliza";
                        break;
                    case 31866: //Gastos de obtención de permisos de reconstrucción
                        if (riesgo.MontoAsegurado > 100000)
                            resultado = "Hasta UF 2.000 por evento y agregado por la vigencia de la póliza";
                        else
                            resultado = "Hasta UF 1.000 por evento y agregado por la vigencia de la póliza";
                        break;
                    case 31867: //Bienes de trabajadores del asegurado (de la comunidad)
                        if (riesgo.MontoAsegurado > 100000)
                            resultado = "UF 20 por trabajador y máx. UF 350";
                        else
                            resultado = "UF 20 por trabajador y máx. UF 250";
                        break;
                    case 31868: //Gastos de Aceleración
                        if (riesgo.MontoAsegurado > 100000)
                            resultado = "Hasta UF 2.000.- por evento y agregado por la vigencia de la póliza";
                        else
                            resultado = "Hasta UF 1.000.- por evento y agregado por la vigencia de la póliza";
                        break;
                    case 31872: //Trabajos de construcción , reparación y ampliaciones
                        if (riesgo.MontoAsegurado > 100000)
                            resultado = "Hasta UF 2.000.- por evento y agregado por la vigencia de la póliza";
                        else
                            resultado = "Hasta UF 1.000.- por evento y agregado por la vigencia de la póliza";
                        break;
                }

            return resultado;
        }

        private static Respuesta CargarDistribucion(Entidades.PolizaRiesgo riesgo, PolizaBC oPoliza)
        {
            List<Entidades.DistribucionPrima> oDistribucionPrima = new List<Entidades.DistribucionPrima>();
            try
            {
                    Entidades.Poliza poliza = new Entidades.Poliza();
                    poliza = oPoliza.ObtenerEntidad();
    
                    int deducibleDistribucion = 0;
                    deducibleDistribucion = FuncionesGetXml.GetDeducibleDistribucion(riesgo, poliza);
            
                   

                    Respuesta oRespuesta = Datos.DistribucionPrima.ReadAll
                        (
                        new Entidades.DistribucionPrima()
                            {
                                CoberturaID = 0,
                                CompaniaID = poliza.oCompania.Id,
                                DeducibleID = deducibleDistribucion,
                                Orden = 0,
                                PlanID = riesgo.PlanID,
                                POLCAD = null,
                                PrimaAdicional = 0,
                                PrimaNeta = 0,
                                ProductoID = poliza.oProducto.ProductoID,
                                TextoDeducible = null,
                                TextoMonto = null,
                                TipoDeducible = 0,
                                TipoMonto = 0,
                                TipoPrima = 0,
                                Version = poliza.oProducto.Version
                            }
                        );

                    if (oRespuesta.Error == 0)
                    {
               

                        oDistribucionPrima = (List<Entidades.DistribucionPrima>)oRespuesta.Resultado;
                        List<Entidades.PolizaRiesgoCobertura> oCoberturas = riesgo.oCoberturas;
                        oDistribucionPrima = oDistribucionPrima.OrderBy(p => p.Orden).ToList();
                    }
            }
            catch(Exception ex)
            {
                return new Respuesta() { Error = -1};
            }

            return new Respuesta(){Error=0,Resultado=oDistribucionPrima};
        }
        //JC002
        private static DataTable CrearColumnas(int AgrupacionID, int SubAgrupacion) 
        {
            DataTable dt = new DataTable();
            DataColumn dc = new DataColumn();
            dc.ColumnName = "COBERTURA BASE";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "CODIGO POL CAD SVS";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "MONTO ASEGURADO";
            dt.Columns.Add(dc);

            //Código: CI015
            if (AgrupacionID == 100 || SubAgrupacion==13000 ||SubAgrupacion ==(int) eeSubAgrupacion.eEmpresa || SubAgrupacion == (int) eeSubAgrupacion.eContrato)
            {
                dc = new DataColumn();
                dc.ColumnName = "DEDUCIBLE";
                dt.Columns.Add(dc);
            }
            if (SubAgrupacion != 13000)
            {
                dc = new DataColumn();
                dc.ColumnName = "PRIMA NETA";
                dt.Columns.Add(dc);
            }

            

            return dt;
        }
        private static void Asegurado(Entidades.PolizaPDF pol, Entidades.PolizaRiesgo polizaRiesgo)
        {
            //Asegurado
            pol.AseguradoNombres = polizaRiesgo.oAsegurado.Nombres;
            pol.AseguradoRut = Rut.FormatRut(polizaRiesgo.oAsegurado.Identificacion);
            pol.AseguradoApellidoPaterno = polizaRiesgo.oAsegurado.ApellidoPaterno;
            pol.AseguradoApellidoMaterno = polizaRiesgo.oAsegurado.ApellidoMaterno;
            pol.AseguradoRazonSocial = polizaRiesgo.oAsegurado.RazonSocial;
            pol.AseguradoNombreCompleto = NombreCompleto(polizaRiesgo.oAsegurado);

            for (int a = 0; a < polizaRiesgo.oAsegurado.Direcciones.Count; a++)
            {
                pol.AseguradoComuna = polizaRiesgo.oAsegurado.Direcciones[a].Comuna.NombreCorto;
                pol.AseguradoDireccion = polizaRiesgo.oAsegurado.Direcciones[a].Direccion;
                pol.AseguradoRegion = polizaRiesgo.oAsegurado.Direcciones[a].Region.NombreLargo;
            }

            if (polizaRiesgo.oAsegurado.Contactos.Any(c => c.oTipoContacto.Id == 4))
            {
                pol.AseguradoEmail = polizaRiesgo.oAsegurado.Contactos.Where(c => c.oTipoContacto.Id == 4).Select(c => c.Contacto).First();
            }

            //if (polizaRiesgo.oAsegurado.Contactos.Any(c => c.oTipoContacto.Id == 2 || c.oTipoContacto.Id == 1 || c.oTipoContacto.Id == 6))
            //{
            //    if (polizaRiesgo.oAsegurado.Contactos.Any(c => c.oTipoContacto.Id == 1))
            //    {
            //        pol.AseguradoTelefono = polizaRiesgo.oAsegurado.Contactos.Where(c => c.oTipoContacto.Id == 1).Select(c => c.Contacto).First();
            //    }
            //    if (polizaRiesgo.oAsegurado.Contactos.Any(c => c.oTipoContacto.Id == 2))
            //    {
            //        pol.AseguradoTelefono += polizaRiesgo.oAsegurado.Contactos.Where(c => c.oTipoContacto.Id == 2).Select(c => c.Contacto).First();
            //    }
            //    if (polizaRiesgo.oAsegurado.Contactos.Any(c => c.oTipoContacto.Id == 6))
            //    {
            //        pol.AseguradoTelefono += polizaRiesgo.oAsegurado.Contactos.Where(c => c.oTipoContacto.Id == 6).Select(c => c.Contacto).First();
            //    }
            //}
            pol.AseguradoTelefono = string.Join(" ",polizaRiesgo.oAsegurado.Contactos.Where(c=>c.oTipoContacto.Id == 1 || c.oTipoContacto.Id == 2 || c.oTipoContacto.Id == 6).Select(c=>c.Contacto));
            
        }

        private static void Beneficiario(Entidades.PolizaPDF pol, Entidades.PolizaRiesgo polizaRiesgo)
        {
                //Beneficiario
                for (int z = 0; z < polizaRiesgo.oBeneficiarios.Count; z++)
                {
                    pol.BeneficiarioNombres = polizaRiesgo.oBeneficiarios[z].Nombres;
                    pol.BeneficiarioApellidoPaterno = polizaRiesgo.oBeneficiarios[z].ApellidoPaterno;
                    pol.BeneficiarioApellidoMaterno = polizaRiesgo.oBeneficiarios[z].ApellidoMaterno;
                    pol.BeneficiarioRazonSocial = polizaRiesgo.oBeneficiarios[z].RazonSocial;
                    pol.BeneficiarioRut = Rut.FormatRut(polizaRiesgo.oBeneficiarios[z].Identificacion);
                    pol.BeneficiarioNombreCompleto = NombreCompleto(polizaRiesgo.oBeneficiarios[z]);

                }
            
        }
        //Ini:Código: RJNV017
        private static void CuadroBeneficiarios(Entidades.PolizaPDF pol, Entidades.PolizaRiesgo polizaRiesgo,string origenId)
        {
            Respuesta resp = new Respuesta();
            resp = CrearCuadroBeneficiarios(polizaRiesgo, pol,origenId);
            if (resp.Error == 0)
            {
                pol.CuadroDeBeneficiarios =
                new
                {
                        Data = (DataTable)resp.Resultado,
                        Style = new
                        {

                            GeneralLevel = new
                            {
                                Font = new
                                {
                                    Bold = false,
                                    Italic = false,
                                    Size = 11,
                                    Color = "#333",
                                    Underline = false,
                                    Family = "Arial",
                                    TextTransform = ""
                                },

                                Border = new
                                {
                                    Color = "#888",
                                    Width = 0
                                },

                                HAlign = "Center",
                                VAlign = "Middle",
                                Width = 100,
                                BackgroundColor = "#FFFFFF"
                            },

                            HeaderLevel = new
                            {
                                Font = new
                                {
                                    Bold = false,
                                    Italic = false,
                                    Size = 11,
                                    Color = "#333",
                                    Underline = false,
                                    Family = "Arial",
                                    TextTransform = ""
                                },

                                Border = new
                                {
                                    Color = "#888",
                                    Width = 0
                                },

                                HAlign = "Center",
                                VAlign = "Middle",
                                BackgroundColor = "#CCC"

                            }

                        }
                    };
            }
        }
        

                  /*  Style = new
                    {
                        GeneralLevel = new
                        {
                            Font = new
                            {
                                Bold = true,
                                Italic = false,
                                Size = 11,
                                Color = "#333",
                                Underline = false,
                                Family = "Arial",
                                TextTransform = ""
                            },

                            Border = new
                            {
                               // Color = "#888",
                                Color="#FFFFFF",
                                Width = 0
                            },

                            //HAlign = "Center",
                            HAlign = "Left",
                            VAlign = "Middle",
                            Width = 80,
                            BackgroundColor = "#FFFFFF"
                        },
                        HeaderLevel = new
                        {
                            Font = new
                            {
                                //Bold = false,
                                Bold = false,
                                Italic = false,
                                Size = 11,
                                //Color = "#333",
                                Color="#FFFFFF",
                                Underline = false,
                                Family = "Arial",
                                TextTransform = ""
                            },

                            Border = new
                            {
                                // Color = "#888",
                                Color = "#FFFFFF",
                                Width = 0
                            },

                            //HAlign = "Center",
                            HAlign = "Left",
                            VAlign = "Middle",
                            BackgroundColor = "#FFFFFF" //BackgroundColor = "#CCC"
                        }
                    }
                };
            }
        }*/
        //Fin:Código: RJNV017

        //Ini:Código: RJNV017
        private static Respuesta CrearCuadroBeneficiarios(Entidades.PolizaRiesgo polizaRiesgo, Entidades.PolizaPDF pol,string origenId)
        {
            Respuesta resp = new Respuesta();
            DataTable dt = new DataTable();
            dt = CrearColumnasBeneficiarios();
            List<Entidades.ItemCotizacionPersonaDistribuirCapital> listaBeneficiarios = new List<Entidades.ItemCotizacionPersonaDistribuirCapital>();
            listaBeneficiarios = Datos.ItemCotizacionPersonaDistribuirCapital.Read(origenId, polizaRiesgo.ItemRiesgoID);
            if (listaBeneficiarios.Count > 1)
            {
                for (int i = 1; i < listaBeneficiarios.Count; i++)
                {
                    var beneficiario = polizaRiesgo.oBeneficiarios.Where(c => c.Identificacion == listaBeneficiarios[i].Identificacion ).FirstOrDefault();
                    if (beneficiario != null)
                    {
                        DataRow filas = dt.NewRow();
                        //Ini:Código: JC019.
                        filas["Nombre beneficiario"] = NombreCompleto(beneficiario);
                        filas["Rut"] = Rut.FormatRut(beneficiario.Identificacion);

                        string telefono = string.Empty;
                        string mails = string.Empty;
                        var contactosTelefonos = beneficiario.Contactos.Where(c => c.oTipoContacto.Id == (int)Entidades.Enum.TipoContacto.Celular || c.oTipoContacto.Id == (int)Entidades.Enum.TipoContacto.TelParticular).ToList();
                        for (int conta = 0; conta < contactosTelefonos.Count; conta++)
                        {
                            telefono += contactosTelefonos[conta].Contacto;
                            if (conta != contactosTelefonos.Count - 1)
                                telefono += "-";
                        }

                        var contactosmail = beneficiario.Contactos.Where(c => c.oTipoContacto.Id == (int)Entidades.Enum.TipoContacto.email).ToList();
                        for (int mail = 0; mail < contactosmail.Count; mail++)
                        {
                            mails += contactosmail[mail].Contacto;
                            if (mail != contactosmail.Count - 1)
                                mails += "-";
                        }
                        filas["Correo electrónico"] = mails;
                        filas["Teléfono"] = telefono;
                        filas["Porcentaje de indemnización"] = listaBeneficiarios[i].porcentaje.FormatoCulture();
                        //Fin:Código: JC019.
                        dt.Rows.Add(filas);
                    }
                }
            }
            return new Respuesta() { Resultado = dt };
        }
        //Fin:Código: RJNV017

        //Ini:Código: RJNV017
        private static DataTable CrearColumnasBeneficiarios()
        {
            DataTable dt = new DataTable();
            DataColumn dc = new DataColumn();
            //Ini:Código: JC019.
            dc.ColumnName = "Nombre beneficiario";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "Rut";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "Correo electrónico";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "Teléfono";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "Porcentaje de indemnización";
            dt.Columns.Add(dc);
            //Fin:Código: JC019.

            return dt;
        }
        //Fin:Código: RJNV017
        private static void Materia(PolizaBC oPoliza, Entidades.PolizaRiesgo polizaRiesgo, Entidades.PolizaPDF pol)
        {
           
            switch (oPoliza.oProducto.oAgrupacion.Id)
            {
                case (int)Negocio.eeAgrupacion.eVehiculos:
                    Entidades.MateriaVehiculo materia = ((Entidades.MateriaVehiculo)polizaRiesgo.oMateria);
                    pol.VehiculoAccesorios = materia.Accesorios;
                    pol.VehiculoAno = materia.Ano.ToString();
                    if (materia.Accesorios.Trim() != string.Empty)
                        pol.VehiculoTieneAccesorios = true;

                    pol.VehiculoCiudad = materia.oMateriaPropiedad.oCiudad.NombreCorto;
                    pol.VehiculoColor = materia.oColorAuto.NombreCorto;
                    pol.VehiculoComuna = materia.oMateriaPropiedad.oComuna.NombreCorto;
                    pol.VehiculoDireccion = materia.oMateriaPropiedad.Direccion;
                    pol.VehiculoMarca = materia.oMarca.NombreCorto;
                    //Falta    
                    //pol.VehiculoMateriaAsegurada = materia.oMateriaPropiedad.oMateriaExtramovil.
                    pol.VehiculoModelo = materia.oModelo.NombreCorto;
                    pol.VehiculoChasis = materia.Chasis;
                    pol.VehiculoFactura = materia.NumeroAseguramiento.ToString();
                    pol.VehiculoNumeroInspeccion = materia.NumeroAseguramiento.ToString();
                    
                    pol.VehiculoMotor = materia.Motor;
                    pol.VehiculoPatente = materia.Patente;
                    pol.VehiculoRegion = materia.oMateriaPropiedad.oRegion.NombreCorto;
                    pol.VehiculoUso = materia.oUsoVehiculo.NombreCorto;

                    //Ini - FG006
                    pol.DeducibleProvisorioSi = "";
                    pol.DeducibleProvisorioNo = "X";
                    //Fin - FG006


                    switch (materia.oFormaAseguramiento.Id)
                    {
                        case (int)eeFormaAseguramiento.eFactura:
                            pol.EsAseguramientoFactura = true;
                            break;

                        case (int)eeFormaAseguramiento.eInspeccion:
                            pol.EsAseguramientoInspeccion = true;
                            break;

                        case (int)eeFormaAseguramiento.eRenovación:
                            pol.EsAseguramientoRenovacion = true;
                            break;

                        case (int)eeFormaAseguramiento.eDeducibleProvisorio:
                            pol.EsAseguramientoDeducibleProvisorio = true;
                            pol.DeducibleProvisorio = materia.NumeroAseguramiento.ToString();

                            if (pol.EsSura)
                                pol.EsAseguramientoDeducibleProvisorioSura = true;
                            else
                                pol.EsAseguramientoDeducibleProvisorioRSA = true;

                            //Ini - FG006
                            pol.DeducibleProvisorioSi = "X";
                            pol.DeducibleProvisorioNo = "";
                            //Fin - FG006

                            break;

                        default:

                            break;
                    }
                    Respuesta resp = new Respuesta();
                    resp = Datos.PDF.BuscaTieneDeducibleAdicional(oPoliza.oProducto.ProductoID, oPoliza.oCompania.Id, materia);
                    if (resp.Error == 0)
                    {
                        string Porcentaje = (string)resp.Resultado;
                        if(Porcentaje.Trim() !=string.Empty)
                        {
                            pol.ModeloTieneDeducibleAdicional = true;
                            pol.PorcentajeMarcaModeloRobo = Porcentaje;
                        }
                    }


                    pol.AntiguedadVehiculo = DateTime.Now.Year - materia.Ano;

                    
                    if(pol.ModeloTieneDeducibleAdicional && pol.AntiguedadVehiculo <= 4)
                    {
                        if (polizaRiesgo.oDeducible.DeducibleID != 240)
                        {
                            pol.VerCondicionesParticularesSinDeducible = true;
                        }
                        else
                        {
                            pol.VerCondicionesParticularesConDeducible = true;
                        }
                    }

                    EspecialesRSA(materia,pol,oPoliza);
                    break;
                case (int)Negocio.eeAgrupacion.eHogar:
                    Entidades.MateriaPropiedad materiaPropiedad = ((Entidades.MateriaPropiedad)polizaRiesgo.oMateria);
                    pol.HogarActividad = materiaPropiedad.oActividadPropiedad.NombreCorto;
                    pol.HogarAntiguedad = materiaPropiedad.oAntiguedadConstruccion.NombreCorto;
                    pol.HogarCiudad = materiaPropiedad.oCiudad.NombreCorto;
                    pol.HogarComuna = materiaPropiedad.oComuna.NombreCorto;
                    pol.HogarDireccion = materiaPropiedad.Direccion;
                    pol.HogarMontoContenido = materiaPropiedad.ValorContenido.ToString("N", CultureFormat.Cultura).Replace(",00", "");;
                    pol.HogarMontoEdificio = materiaPropiedad.ValorEdificio.ToString("N", CultureFormat.Cultura).Replace(",00", "");;
                    pol.HogarRegion = materiaPropiedad.oRegion.NombreCorto;
                    pol.HogarTipoConstruccion = materiaPropiedad.oTipoConstruccion.NombreCorto;
                    pol.HogarTipoUbicacion = materiaPropiedad.oTipoUbicacion.NombreCorto;
                    pol.HogarTipoUso = materiaPropiedad.oUsoPropiedad.NombreCorto;
                    pol.HogarClaseConstruccion = materiaPropiedad.oClaseConstruccion.NombreCorto;
                    pol.HogarNumeroPiso = materiaPropiedad.oNumeroPisos.NombreCorto;
                    pol.MontoAseguradoRoturaDeCaneria = ((materiaPropiedad.ValorContenido + materiaPropiedad.ValorEdificio) * 0.05).ToString("N", CultureFormat.Cultura);
                    pol.HogarNumeroInspeccion = materiaPropiedad.NumeroAseguramiento.ToString();

                    //INi:Código: JC018
                    if(materiaPropiedad.ValorEdificio>0 && materiaPropiedad.ValorContenido>0)
                        pol.EsTieneContenidoEdificio = true;

                    if (materiaPropiedad.ValorContenido > 0)
                        pol.EstieneContenido = true;

                    if (materiaPropiedad.ValorEdificio > 0)
                        pol.EstieneEdificio = true;
                    //Fin:Código: JC018

                    //Ini - FG005
                    float _MontoAsegurado = materiaPropiedad.ValorEdificio + materiaPropiedad.ValorContenido;

                    pol.MontoAseguradoTotal = _MontoAsegurado.ToString("N", CultureFormat.Cultura).Replace(",00", "");
                    //Fin - FG005

                    switch (materiaPropiedad.oFormaAseguramiento.Id)
                    {
                        case (int)eeFormaAseguramiento.eFactura:
                            pol.EsAseguramientoFactura = true;
                            break;

                        case (int)eeFormaAseguramiento.eInspeccion:
                            pol.EsAseguramientoInspeccion = true;
                            break;

                        case (int)eeFormaAseguramiento.eRenovación:
                            pol.EsAseguramientoRenovacion = true;
                            break;

                        case (int)eeFormaAseguramiento.eDeducibleProvisorio:
                            pol.EsAseguramientoDeducibleProvisorio = true;
                            pol.DeducibleProvisorio = materiaPropiedad.NumeroAseguramiento.ToString();

                            if (pol.EsSura)
                                pol.EsAseguramientoDeducibleProvisorioSura = true;
                            else
                                pol.EsAseguramientoDeducibleProvisorioRSA = true;

                            break;

                        default:

                            break;
                    }
                     
                    break;

                case (int)Negocio.eeAgrupacion.ePymes:
                    switch (oPoliza.oProducto.oSubAgrupacion.Id)
	                    {
                            case (int)Negocio.eeSubAgrupacion.eCondominiosBCI:
                                Entidades.MateriaPropiedad materiaCondominio = ((Entidades.MateriaPropiedad)polizaRiesgo.oMateria);
                                bool condominioComercial = (materiaCondominio.oActividadPropiedad.Id == 1527);
                                pol.CondominioActividad = materiaCondominio.oActividadPropiedad.NombreLargo;
                            
                                //Según carga de parámetros página cotización ddlActividad
                                //no.Value = "1526";
                                //no.Text = "Condominios Habitacionales";  
                                //no.Value = "1527";
                                //no.Text = "Condominios Comerciales"; 
                                if (condominioComercial)
                                    pol.CondominioDestino = "Comercial";
                                else
                                    pol.CondominioDestino = "Habitacional";

                                pol.CondominioDireccion = materiaCondominio.Direccion;
                                pol.CondominioCiudad = materiaCondominio.oCiudad.NombreCorto;
                                pol.CondominioComuna = materiaCondominio.oComuna.NombreCorto;
                                pol.CondominioRegion = materiaCondominio.oRegion.NombreCorto;
                                pol.CondominioTipoConstruccion = materiaCondominio.oConstruccionMuro.NombreCorto;
                                pol.TipoConstruccionMuro = materiaCondominio.oConstruccionMuro.NombreCorto;
                                pol.TipoConstruccionTecho = materiaCondominio.oConstruccionTecho.NombreCorto;
                                pol.MontoEspaciosComunes = materiaCondominio.ValorEdificio.ToString("0.00").Replace(",00","");
                                pol.MontoDepartamentos = materiaCondominio.ValorContenido.ToString("0.00").Replace(",00", "");
                                pol.NumeroDepartamentos = materiaCondominio.MontoRobo.ToString();
                                pol.NumeroTrabajadores = materiaCondominio.NumeroTrabajadores.ToString();
                                pol.EsActividadHabitacional = !condominioComercial;
                                pol.EsActividadComercial = condominioComercial;

                                break;
		                    default: //Pyme normal
                                break;
	                    } 


                
                    break;
                //INi:Código: CI015
                case (int)Negocio.eeAgrupacion.eResponsabilidadCivil:
                            switch (polizaRiesgo.oTipoMateriaAsegurada.TipoMateriaID)
	                        {
                                case (int)Negocio.eeMateriaCatalog.eRCEmpresa :
                                    Entidades.MateriaRCEmpresa materiaRCEmpresa = ((Entidades.MateriaRCEmpresa)polizaRiesgo.oMateria);
                                    resp = cargarMateriaRCEmpresa(materiaRCEmpresa, pol);
                                    if (resp.Error == 0)
                                    {
                                        resp = consultarTieneCoberturtas(oPoliza , pol);
                                    }
                                   
		                        break;

                                case (int)Negocio.eeMateriaCatalog.eRCContrato :
                                Entidades.MateriaRCContrato MateriaRCContrato = ((Entidades.MateriaRCContrato)polizaRiesgo.oMateria);
                                resp = cargarMateriaRCContrato(MateriaRCContrato, pol);
                                     if (resp.Error == 0)
                                     {
                                         resp = consultarTieneCoberturtas(oPoliza, pol);
                                     }
		                        break;
	                        }

                    break;
                //Fin:Código: CI015
                //Ini:Código: JC019.
                case (int)Negocio.eeAgrupacion.eAPIndividual:
                    Entidades.MateriaAPVida MateriaAp = ((Entidades.MateriaAPVida)polizaRiesgo.oMateria);
                    pol.AseguradoNacimiento = MateriaAp.FechaNacimiento.FormatoFecha_dd_MM_yyyy();
                    
                    resp = Negocio.ParametroBC.ObtenerOcupacionPorId(MateriaAp.OcupacionId);
                    List<Entidades.Parametro> ocupacion = new List<Entidades.Parametro>();
                    if(resp.Error==0)
                    {
                             pol.VidaOcupacion = resp.Resultado.ToString();
                             resp = Negocio.ParametroBC.ObntenerClaseOcupacionPorID(MateriaAp.OcupacionId);
                             if(resp.Error==0)
                             {
                                 Entidades.Parametro entidad = new Entidades.Parametro();
                                 entidad =(Entidades.Parametro)resp.Resultado;
                                 if(entidad.Id==4)
                                    pol.TieneClaseCuatro = true;
                             }
                    }
                    break;
                //Fin:Código: JC019.
            }
        }

        //Ini:Código: CI015
        private static Respuesta cargarMateriaRCContrato(Entidades.MateriaRCContrato MateriaRCContrato, Entidades.PolizaPDF pol)
        {
            try
            {
                using (Negocio.Common.IParComunaNegocio Comuna = new Negocio.Common.ParComunaNegocio())   
                using (Negocio.Common.IParDeducibleRCContratoNegocio Deducible = new Negocio.Common.ParDeducibleRCContratoNegocio())                    
                using (Negocio.Common.IParContratorcNegocio Contrato = new Negocio.Common.ParContratorcNegocio())
                using (Negocio.Common.IParTipoContratorcNegocio tipoContrato = new Negocio.Common.ParTipoContratorcNegocio())
                {
                    tipoContrato.oEntidad.TipoContratoID = MateriaRCContrato.oTipoContrato.Id;
                        tipoContrato.Leer(tipoContrato.oEntidad);
                            if (tipoContrato.oRespuesta.Error == 0)
                            {
                                pol.TipoContrato = tipoContrato.oRespuesta.Resultado.NombreLargo;
                            }
                        Contrato.oEntidad.ContratoID = MateriaRCContrato.oContrato.Id;
                        Contrato.Leer(Contrato.oEntidad);
                            if(Contrato.oRespuesta.Error==0)
                            {
                                pol.ActividadContrato = Contrato.oRespuesta.Resultado.NombreLargo;
                            }
                        Deducible.oEntidad.DeducibleRCContratoID = MateriaRCContrato.oDeducible.Id;
                        Deducible.Leer(Deducible.oEntidad);
                            if (Deducible.oRespuesta.Error == 0)
                            {
                                pol.TextoDeducibleContrato = Deducible.oRespuesta.Resultado.NombreLargo;
                            }
                            Comuna.oEntidad.ComunaID = MateriaRCContrato.oComuna.Id;
                            Comuna.Leer(Comuna.oEntidad);
                            if (Comuna.oRespuesta.Error == 0)
                            {
                                pol.ComunaContrato = Comuna.oRespuesta.Resultado.NombreLargo;
                            }
                    pol.DireccionContrato = MateriaRCContrato.Direccion;
                    if (MateriaRCContrato.Direccion.Trim().Length > 0)
                        pol.TineDireccion = true;


                } 
                return new Respuesta() { Error = 0 };
            }
            catch (Exception ex)
            {
                return new Respuesta() { Error = -1, Mensaje = "Problemas cargar Materia RC Contrato" + "Error  : " + ex.Message + " Trace :" + ex.StackTrace };
            }
            
             
        }

        private static Respuesta consultarTieneCoberturtas(PolizaBC oPoliza, Entidades.PolizaPDF pol)
        {
            try
            {
                List<Entidades.ProductoParametros> listaParametros = new List<Entidades.ProductoParametros>();
                Respuesta resp = Negocio.ProductoParametro.ObtenerTodos(oPoliza.oProducto.ProductoID);
                listaParametros = (List<Entidades.ProductoParametros>)resp.Resultado;
                int CoberturaManufacturas = 0;
                int CoberturaAlimentoosServicios = 0;
                int COBOFICINA = 0;
                int COBOALIMENTOS = 0;

                if (listaParametros.Any(c => c.Parametro == "COBMANUFACTURAS"))
                {
                    CoberturaManufacturas = (int)listaParametros.Where(c => c.Parametro == "COBMANUFACTURAS").Select(c => c.Valor).First();
                    pol.TieneCoberturaRcAlimentos = oPoliza.oRiesgoS.Any(x => x.oCoberturas.Any(c => c.oCobertura.CoberturaID == CoberturaManufacturas));
                }
                if (listaParametros.Any(c => c.Parametro == "COBOALIMENTOSSERVICIOS"))
                {
                    CoberturaAlimentoosServicios = (int)listaParametros.Where(c => c.Parametro == "COBOALIMENTOSSERVICIOS").Select(c => c.Valor).First();
                    pol.TieneCoberturaRcAlimentos = oPoliza.oRiesgoS.Any(x => x.oCoberturas.Any(c => c.oCobertura.CoberturaID == CoberturaAlimentoosServicios));
                }

                
                if (listaParametros.Any(c => c.Parametro == "COBOFICINA"))
                {
                    COBOFICINA = (int)listaParametros.Where(c => c.Parametro == "COBOFICINA").Select(c => c.Valor).First();

                    pol.TieneCoberturaRcProductosContrato = oPoliza.oRiesgoS.Any(x => x.oCoberturas.Any(c => c.oCobertura.CoberturaID == COBOFICINA));
                    
                }
                if (listaParametros.Any(c => c.Parametro == "COBOALIMENTOS"))
                {
                    COBOALIMENTOS = (int)listaParametros.Where(c => c.Parametro == "COBOALIMENTOS").Select(c => c.Valor).First();

                    pol.TieneCoberturaRcAlimentosContrato = oPoliza.oRiesgoS.Any(x => x.oCoberturas.Any(c => c.oCobertura.CoberturaID == COBOALIMENTOS));
                    
                }
               


                return new Respuesta() { Error = 0 };
            }
            catch (Exception ex)
            {
                return new Respuesta() { Error = -1, Mensaje = "Problemas Con la Consulta consultar Tiene Coberturtas" + "Error  : " + ex.Message + " Trace :" + ex.StackTrace };

            }

        }

        private static Respuesta cargarMateriaRCEmpresa(Entidades.MateriaRCEmpresa materiaRCEmpresa, Entidades.PolizaPDF pol)
        {
            try
            {
                using (Negocio.Common.IParDeducibleRcEmpresaNegocio Deducible = new Negocio.Common.ParDeducibleRcEmpresaNegocio())                    
                using (Negocio.Common.IParActividadrcNegocio Actividad = new Negocio.Common.ParActividadrcNegocio())
                using (Negocio.Common.IParTipoActividadrcNegocio tipoActividad = new Negocio.Common.ParTipoActividadrcNegocio())
                {
                    tipoActividad.oEntidad.TipoActividadRCID = materiaRCEmpresa.oTipoActividad.Id;
                    tipoActividad.Leer(tipoActividad.oEntidad);
                        if (tipoActividad.oRespuesta.Error == 0)
                        {
                            pol.TipoActividadEmpresa = tipoActividad.oRespuesta.Resultado.NombreLargo;
                        }
                    Actividad.oEntidad.ActividadRCID = materiaRCEmpresa.oActividad.Id;
                    Actividad.Leer(Actividad.oEntidad);
                        if(Actividad.oRespuesta.Error==0)
                        {
                            pol.ActividadEmpresa = Actividad.oRespuesta.Resultado.NombreLargo;
                        }
                    Deducible.oEntidad.DeducibleRCEmpresaID = materiaRCEmpresa.DeducibleRCID;
                    Deducible.Leer(Deducible.oEntidad);
                        if (Deducible.oRespuesta.Error == 0)
                        {
                            pol.TextoDeducibleEmpresa = Deducible.oRespuesta.Resultado.NombreLargo;
                        }
                }
                return new Respuesta() { Error = 0};
            }
            catch (Exception ex)
            {
                return new Respuesta() { Error = -1, Mensaje = "Problemas Con la Consulta a Actividad" + "Error  : " + ex.Message + " Trace :" + ex.StackTrace };

            }
        }
        //fIN:Código: CI015
        private static void EspecialesRSA(Entidades.MateriaVehiculo materia, Entidades.PolizaPDF pol, PolizaBC oPoliza)
        {
            
			switch(materia.Decl_ConductorAdicional)
			{
				case 1:
					pol.DescripcionConductorAdicional ="Si";
                    pol.TieneConductorAdicional = true;
					break;
				case 2:
                case -1:
                    pol.DescripcionConductorAdicional ="No";
					break;
			}

            pol.DescripcionPropietario = materia.oPropietario.NombreCorto;
            pol.EdadAsegurado = materia.EdadAsegurado.ToString();

           if(materia.SexoAsegurado == 1)
                 pol.AseguradoEsMasculino = true;

           if (materia.oPropietario.Id == 0)
                    pol.EsPropietario = true;

           ReemplazosYRC(materia,pol); 
        }
        private static void ReemplazosYRC(Entidades.MateriaVehiculo materia, Entidades.PolizaPDF pol)
        {
            if (materia.AutoReemplazo30Dias_Classic || materia.AutoReemplazo30Dias_Full || materia.AutoReemplazo30Dias_Premium)
                    pol.TieneReemplazo30Dias = true;

            if (materia.AutoReemplazo45Dias_Classic || materia.AutoReemplazo45Dias_Full || materia.AutoReemplazo45Dias_Premium)
                    pol.TieneReemplazo45Dias = true;

            if (materia.AutoReemplazoIlimitado_Classic || materia.AutoReemplazoIlimitado_Full || materia.AutoReemplazoIlimitado_Premium)
                    pol.TieneReemplazoIlimitado= true;

            if (materia.UF2000RC_Classic || materia.UF2000RC_Full || materia.UF2000RC_Premium)
                    pol.TieneRCUF2000 = true;

            if (materia.UF1000RC_Classic || materia.UF1000RC_Full || materia.UF1000RC_Premium)
                    pol.TieneRCUF1000 = true;
        }
        private static string NombreCompleto(Entidades.Persona persona)
        {
            return (persona.RazonSocial + persona.Nombres + " " + persona.ApellidoPaterno + " " + persona.ApellidoMaterno).Trim();
        }
    }
}
