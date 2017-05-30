/*************************************************************************************************************************************
* Autor:  Ricardo Nuñez  || Tracker: MTRXCL-160 || Código: RJNV029  || Fecha: 30/07/2017 - 17:23hrs || Descripción: Se modifica interes pago contado para CHUBB Condominios
* Autor:  Ricardo Nuñez  || Tracker: MTRXCL-241 || Código: RJNV028  || Fecha: 23/05/2017 - 17:23hrs || Descripción: Se agrega logica para nueva cobertura ACCIDENTES PERSONALES PLAN A Y B
* Autor: Fernando Gutierrez || Tracker: 19360 || Código: FG027 || Fecha: 05/01/2017 - 10:23hrs || Descripción: ERROR ENVIO MAIL EVALUACION ACE no existia funcionalidad
* Autor: Fernando Gutierrez || Tracker: 18552 || Código: FG026 || Fecha: 21/12/2016 - 18:32hrs || Descripción: ERROR ENVIO MAIL EVALUACION CNS
* * * Autor: Juan Cerda || Tracker: 17313 || Código: JC025|| Fecha: 07/09/2016 - 10:24hrs || Descripción: Se Agrega Campo Para Condominio ACE.
* Autor: Juan Cerda || Tracker: 17234 || Código: JC024 || Fecha: 09/09/2016 - 10:24hrs || Descripción: Se realizan cambios pantalla y nuevos campos de formas de pago y cuotas.
* Autor: William Soza || Tracker: 13926 || Código: WS023 || Fecha: 11/05/2016 - 18:00hrs || Descripción: Se hacen correcion al envio correo Cot condominio
* Autor: Fernando Gutierrez || Tracker: 16170 || Código: FG022 || Fecha: 09/05/2016 - 16:24hrs || Descripción: Se realizan cambios pantalla y nuevos scoring para Pyme BCI
* Autor: William Soza || Tracker: 13926 || Código: WS021 || Fecha: 05/05/2016 - 18:00hrs || Descripción: Se realizan cambios a plantilla mail 
* Autor: William Soza || Tracker: 13926 || Código: WS020 || Fecha: 28/04/2016 - 18:00hrs || Descripción: Se agrega envio mail cotizacion
* Autor: Juan Cerda || Tacker: 14778  || Código: JC019 || Fecha: 26/04/2016 - 10:55hrs || Descripcion: Control de Cambio Modulo Renovaciones v10.5
* Autor: William Soza || Tracker: 13603 || Código: WS018 || Fecha: 08/04/2016 - 18:00hrs || Descripción: Quito cobertura averia
* Autor: William Soza || Tracker: 13926 || Código: WS017 || Fecha: 08/04/2016 - 18:00hrs || Descripción: 
* Autor: William Soza || Tracker: 13926 || Código: WS016 || Fecha: 28/03/2016 - 18:00hrs || Descripción: 
* Autor: William Soza || Tracker: 13926 || Código: WS015 || Fecha: 28/03/2016 - 18:00hrs || Descripción: 
* Autor: CESAR RAMIREZ || Tracker: 14783 || Código: CR014 || Fecha: 22/02/2016 - 18:00hrs || Descripción: Primera cuora generico
* Autor: Juan cerda || Tracker: 13926 || Código: JC013 || Fecha: 29/12/2015 - 18:00hrs || Descripción: nuevas versiones de configuracion
* Autor: William Soza|| Tacker: 13926 || Código: WS012 || Fecha: 25/11/2015 - 18:00hrs || Descripcion: Se agrega SubAgrupacionID 13000 para Condominio Consorcios
* Autor: William Soza|| Tacker: 13926 || Código: WS011 || Fecha: 24/11/2015 - 18:00hrs || Descripcion: 
* Autor: William Soza|| Tacker: 13926 || Código: WS010 || Fecha: 19/11/2015 - 18:00hrs || Descripcion: 
* Autor: Mauricio Estrada || Tacker: 574 - PYME ACE || Código: ME001 || Fecha: 02/11/2015 - 10:00hrs || Descripcion: Quitar coberturas cuando Equipos Electronicos es igual a cero
* Autor: Roger Nuñez || Tacker: 13176 - Agrega Emitir Poliza Ace Pyme || Código: RN008 || Fecha: 08/10/2015 - 14:00hrs || Descripcion: Se agrega procedimiento que Agrega Emitir Poliza Ace Pyme
* Autor: Felipe Fuentes|| Tacker: 13176 - Pyme ACE || Código: FF007 || Fecha: 07/10/2015 - 20:00hrs || Descripcion: Se agrega case para agregar coberturas segun plan. Se agrega la eliminacion de las coberturas segun los montos cotizados
* Autor: Víctor Sapiaín || Tacker: 11635 - Corrección Tarificación Consorcio Pyme || Código: VS006 || Fecha: 05/05/2015 - 12:00hrs || Descripcion: Corrección para la falta de tarificación compañia consorcio . Se llama parametro monto evaluación desde BD.  
* Autor: Víctor Sapiaín || Tacker: 11635 - Corrección Tarificación Consorcio Pyme || Código: VS005 || Fecha: 05/05/2015 - 11:30hrs || Descripcion: Corrección para la falta de tarificación compañia consorcio . 
* Autor: Juan  Cerda || Tacker: 9591 - Configuraciones Consorcio Pyme || Código: JC004 || Fecha: 11/02/2015 - 18:22hrs || Descripcion: Se agregan modificaciones respecto a los montos para tarificar , ésto dependiendo del tipo de exclusion de la actividad.
* Autor: Mauricio Figueroa || Tacker: Reparacion Actividad Pyme || Código: MF003 || Fecha: 20/01/2015 - 16:45hrs || Descripcion: Reparacion Actividad Pyme que al buscar y no existia aparecia por defecto
* Autor: Felipe Fuentes || Tacker: Reparaciones renovaciones || Código: FF002 || Fecha: 22/12/2014 - 12:45hrs || Descripcion: Reparacion en emision RSA para renovaciones de otras ofertas en nuevo modulo
* Autor: Cesar Ramirez || Tacker: 9591 - Hogar || Código: CR001 || Fecha: 17/11/2014 - 10:30hrs || Descripcion: Correciones ciclo 1
* Autor: Mauricio Estrada || Tacker: Tracker 14783 - NVAS FORMAS DE PAGO PARA TODAS LAS COMPANIAS  || Código09: ME001 || Fecha: 19/02/2016 - 10:47hrs || Descripcion: 30 días pasados del inicio de vigencia de la póliza.
* Autor: Mauricio Estrada || Tacker: Tracker 14783 - NVAS FORMAS DE PAGO PARA TODAS LAS COMPANIAS  || Código09: ME002 || Fecha: 19/02/2016 - 10:47hrs || Descripcion: el primer 5-15 a contar de 25 dias pasados del inicio de vigencia de la póliza.
**************************************************************************************************************************************/

using System;
using System.Collections;
using System.Data;
using Microsoft.ApplicationBlocks.UIProcess;
using Microsoft.ApplicationBlocks.ExceptionManagement;
using Hypernet.ANT.Exceptions;
using Hypernet.ANT.BusinessEntity;
using Hypernet.ANT.BusinessComponent;
using Hypernet.ANT.UIP.UIEntity;
using Hypernet.ANT.UIP.UIEntity.SegurosANS;
using Hypernet.ANT.UIP.UIEntity.SegurosANS.Pymes;
using System.Threading;
using System.Globalization;
using System.Xml;
using System.Web.Mail;
using System.Text;
using Hypernet.ANT.DALC;
using System.Web;
using System.IO;
//Seg
using ANT.Seguridad;
using ANT.Renovaciones;
using System.Data.SqlClient;


namespace Hypernet.ANT.UIP
{
	/// <summary>
	/// Summary description for VANSController.
	/// </summary>
	public class PymesANSController : ControllerBase
	{
		public PymesANSController(Navigator navigator) :	base(navigator)
		{
		}

		#region Métodos de Navegación
		
		public void Consultar()
		{
			this.Navigate("consultar");
		}

		public void VerCoberturas()
		{
			if (State["viewPath"] == null)
				State["viewPath"] = "Cotización Riesgos Comerciales >";
			string viewPath = (string) State["viewPath"];
			if (viewPath == "Cotización Riesgos Comerciales >" || viewPath == "Cotización >")
				viewPath = "Cotización Riesgos Comerciales > Coberturas";
			else
				viewPath = "Cotización Riesgos Comerciales > Póliza > Descripción de Riesgo > Coberturas";
			State["viewPath"] = viewPath;
			this.Navigate("ver");
		}

		public void EmitirPoliza()
		{
			string viewPath = (string) State["viewPath"];
			viewPath = "Cotización Riesgos Comerciales > Póliza";
			State["viewPath"] = viewPath;
			this.Navigate("emitir");
		}

		public void DescribirRiesgo()
		{
			string viewPath = (string) State["viewPath"];
			viewPath = "Cotización Riesgos Comerciales > Póliza > Descripción de Riesgo";
			State["viewPath"] = viewPath;
			this.Navigate("describir");
		}

		public void PlanDePago()
		{
			string viewPath = (string) State["viewPath"];
			viewPath = "Cotización Riesgos Comerciales > Póliza > Plan de Pago";
			State["viewPath"] = viewPath;
			this.Navigate("pago");
		}

		public void Volver()
		{
			string viewPath = (string) State["viewPath"];
			switch (viewPath)
			{
				case "Cotización Riesgos Comerciales > Coberturas":
					State["viewPath"] = "Cotización >";
					this.Navigate("volverCotizacion");
					break;
				case "Cotización Riesgos Comerciales > Póliza > Descripción de Riesgo > Coberturas":
					State["viewPath"] = "Cotización Riesgos Comerciales > Propuesta > Descripción de Riesgo";
					this.Navigate("volverDescripcionRiesgo");
					break;
				case "Cotización Riesgos Comerciales > Póliza > Descripción de Riesgo":
					State["viewPath"] = "Cotización Riesgos Comerciales > Póliza";
					this.Navigate("volver");
					break;
				case "Cotización Riesgos Comerciales > Póliza > Plan de Pago":
					State["viewPath"] = "Cotización Riesgos Comerciales > Póliza";
					this.Navigate("volver");
					break;
			}
		}

		public void Terminar(string userName)
		{
			try
			{
				
				UserTask.ClearTask(userName, ANSTasks.Pymes);
				State.Clear();
				State.Delete();
				this.CompleteTask();
				UIPManager.StartNavigationTask(	ANSTasks.Pymes, new PymesANSTask(userName));
			}
			catch(System.Threading.ThreadAbortException ex)
			{
				System.Console.Write(ex.Message);
			}
		}
		public void TerminarCondominio(string userName)
		{
			try
			{
				
				UserTask.ClearTask(userName, ANSTasks.Condominio);
				State.Clear();
				State.Delete();
				this.CompleteTask();
				UIPManager.StartNavigationTask(	ANSTasks.Condominio, new CondominioANSTask(userName));
			}
			catch(System.Threading.ThreadAbortException ex)
			{
				System.Console.Write(ex.Message);
			}
		}
		#endregion

		#region Métodos Genéricos
		public string ViewPath
		{
			get
			{
				return (string)State["viewPath"];
			}
		}

		public void InicializaDatosGenerales(DatosGenerales datosGenerales)
		{
			State["CorredorID"] = datosGenerales.CorredorID;
			
			State["IdentificacionAgente"] = datosGenerales.IdentificacionAgente;
			State["Agente"] = datosGenerales.oAgente;
			State["GroupSeparator"] = datosGenerales.GroupSeparator;
			State["DecimalDigits"] = datosGenerales.DecimalDigits;
			State["DecimalSeparator"] = datosGenerales.DecimalSeparator;

			// Configuración del Formato numérico
			CultureInfo ci = new CultureInfo("es-CL");
			NumberFormatInfo numInfo = ci.NumberFormat;
			numInfo.NumberGroupSizes = new int[]{3};
			numInfo.NumberGroupSeparator = datosGenerales.GroupSeparator;
			numInfo.NumberDecimalDigits = datosGenerales.DecimalDigits;
			numInfo.NumberDecimalSeparator = datosGenerales.DecimalSeparator;
			ci.NumberFormat = numInfo;
			State["Cultura"] = ci; //(CultureInfo)State["Cultura"]
			Thread.CurrentThread.CurrentCulture = ci;
		}
		#endregion

 		#region Métodos de soporte para Vista Cotización

		public void TarificarItemesCotizacion(CatalogoProductoSBC oCatalogoS, string userName)
		{
			// Obtiene la Cotización desde el State
			CotizacionBC oCotizacion = (CotizacionBC) State["Cotizacion"];
			
			oCotizacion.oItemeS.Tarificar(oCatalogoS, userName);
		}

		public void AgregarItem(CotizacionUIE uieCotizacion)
		{
			AgregarItem(uieCotizacion , "Estandar");
		}
		public void AgregarItem(CotizacionUIE uieCotizacion, string plan)
		{
			try
			{
				// Obtiene la Cotización desde el State
				CotizacionBC oCotizacion = (CotizacionBC) State["Cotizacion"];

				// Lee desde la UI los datos del Contrantante si este aún no se seteado
				//if (oCotizacion.oContratante.Identificacion.Trim() == "")
				//{
					// Lee datos del Contrantante desde la UI
					Utilities.SetPersona(uieCotizacion.DatosContratante, oCotizacion.oContratante,(string)State["CorredorID"]);
				//}

				oCotizacion.DescuentoComision = int.Parse(uieCotizacion.ddlComision);
				// Crea el Item a agregar
				ItemCotizacionBC oItem = new ItemCotizacionBC();
				oItem.oParent = oCotizacion;

				// Lee el ID de la Compañia desde la UI
				//oItem.oCompania.Id = int.Parse(uieCotizacion.ddlCompania);

				// Lee el Producto desde la UI
				ProductoBC mproduct = new ProductoBC();
				//mproduct.ProductoID = uieCotizacion.ddlProducto;
				//mproduct.Version = int.Parse(uieCotizacion.ddlProductoVersion);
				//mproduct.Read();
				oItem.oProducto = mproduct;
				mproduct = null;

				// Lee datos del Contratante al Asegurado del Item 
				Utilities.SetPersona(uieCotizacion.DatosContratante, oItem.oAsegurado,(string)State["CorredorID"]);

				// Lee la materia asegurada desde la UI
				MateriaPropiedadBC materia = new MateriaPropiedadBC();
				ParametroBC oParametroPropiedad = new ParametroBC(eeParameterCatalog.eActividadComercio);
				oParametroPropiedad.Id = int.Parse(uieCotizacion.ddlActividad); 

			// Ini - MF003
				if(oParametroPropiedad.Id == 1305)
				{
					throw new Exception("Favor ingresar una actividad valida para Cotizar");
				}
			// Fin - MF003

				materia.oActividadPropiedad = oParametroPropiedad;
				//materia.oActividadPropiedad.Id = int.Parse(uieCotizacion.ddlActividad); 
				materia.oRegion.Id = int.Parse(uieCotizacion.ddlRegion);
				materia.oCiudad.Id = int.Parse(uieCotizacion.ddlCiudad);
				materia.oComuna.Id = int.Parse(uieCotizacion.ddlComuna);
				materia.oOcupacionComercio.Id = int.Parse(uieCotizacion.ddlOcupacion);
				materia.Direccion = uieCotizacion.txtDireccion;
				materia.ValorContenido = float.Parse(uieCotizacion.txtValorContenido,(CultureInfo)State["Cultura"]);
				materia.ValorEdificio = float.Parse(uieCotizacion.txtValorEstructura,(CultureInfo)State["Cultura"]);
				materia.MontoMercaderias = float.Parse(uieCotizacion.txtMontoMercaderias);
				materia.MontoEquiposElectronicos = float.Parse(uieCotizacion.txtMontoEquiposElectronicos);
				materia.MontoMaquinarias = float.Parse(uieCotizacion.txtMontoMaquinarias);
				materia.Ano = uieCotizacion.txtAno;
				//materia

//				materia.IncendioSismoVolcanica = materia.ValorContenido + materia.ValorEdificio + 
//																materia.MontoMercaderias + materia.MontoMaquinarias + 
//																materia.MontoEquiposElectronicos;
//
//				materia.RoboViolencia = materia.ValorContenido + materia.MontoMaquinarias + 
//																materia.MontoMercaderias + materia.MontoEquiposElectronicos;

				materia.oConstruccionMuro.Id =  int.Parse(uieCotizacion.ddlConstruccionMuro);
				materia.oConstruccionTecho.Id =  int.Parse(uieCotizacion.ddlConstruccionTecho);

				/*tipo contruccion*/
				materia.oTipoConstruccion.Id = 110; //sólido
				oItem.MontoAsegurado = materia.ValorContenido + materia.ValorEdificio +  materia.MontoMercaderias + materia.MontoEquiposElectronicos + materia.MontoMaquinarias;

                materia.MontoPxP = int.Parse(uieCotizacion.txtPxP);
				materia.PeriodoPxP = int.Parse(uieCotizacion.ddlPeriodo);
				materia.NumeroTrabajadores = int.Parse(uieCotizacion.txtNumeroTrabajadores);
				materia.RCAlimentos	= uieCotizacion.chkRCAlimentos;	
	
				materia.Detectores	= uieCotizacion.chkDetectores;	
				materia.RedHumeda	= uieCotizacion.chkRedHumeda;	
				materia.Sprinklers	= uieCotizacion.chkSprinklers;	
				materia.MenorA50	= uieCotizacion.chkAntiguedad;	
				
				materia.oTipoUbicacion.Id = int.Parse(uieCotizacion.ddlTipoUbicacion);	
				materia.MejoraInmueble = float.Parse(uieCotizacion.txtMejoraInmueble);	
				materia.Terrorismo = uieCotizacion.chkTerrorismo;	
				materia.AveriaMaquinaria = uieCotizacion.chkAveriaMaquinaria;	
				//Ini - FG022
				materia.RiesgoBordeCostero = uieCotizacion.chkRiesgoBordeCostero;
				materia.RiesgoBordeRio = uieCotizacion.chkRiesgoBordeRio;
				//Fin - FG022

        //Ini:Código: JC024
        //Inni:Código: JC025
				if(uieCotizacion.ddlTipoFinanciamiento.Trim() =="")
				{
					uieCotizacion.ddlTipoFinanciamiento = "100";

				}
				if(uieCotizacion.ddlNumeroCuotas.Trim() =="")
				{
					uieCotizacion.ddlNumeroCuotas = "1";

				}
        //Fin:Código: JC025
				materia.FormaPagoID= int.Parse(uieCotizacion.ddlTipoFinanciamiento);
				materia.NumeroCuotas =int.Parse(uieCotizacion.ddlNumeroCuotas);
        //Fin:Código: JC024

               //Ini:Código: JC025
				if(uieCotizacion.TxtN_Reserva_ACE.Trim()=="")
				{
					uieCotizacion.TxtN_Reserva_ACE="0";
				}
				materia.N_Reserva_ACE =int.Parse(uieCotizacion.TxtN_Reserva_ACE);

				if(uieCotizacion.txtCantidadUnidades.Trim()=="")
					uieCotizacion.txtCantidadUnidades="0";

				materia.CantidadUnidades = int.Parse(uieCotizacion.txtCantidadUnidades);
				//Fin:Código: JC025

				//Campo para Condominio RSA				

				

//				materia.MontoRobo = float.Parse(uieCotizacion.txtCantidadUnidades);
				
	
				switch(plan)
				{
					case "Estandar":
						materia.MontoRC = int.Parse(uieCotizacion.ddlRCivil);
						materia.Cristales = int.Parse(uieCotizacion.ddlCristales);
						materia.CajaSeguridad = int.Parse(uieCotizacion.ddlDineroCaja);
						materia.MontoMuerte = int.Parse(uieCotizacion.ddlMontoMuerte);				
						materia.RemesaValores = int.Parse(uieCotizacion.ddlRemesa);						
						break;
					case "Oficinas":
						oItem.MontoAsegurado = materia.ValorContenido + materia.ValorEdificio;
						materia.MontoRC = int.Parse(uieCotizacion.txtRCivil);
						materia.Cristales = int.Parse(uieCotizacion.txtCristales);
						materia.CajaSeguridad = int.Parse(uieCotizacion.txtDineroCaja);
						materia.MontoMuerte = int.Parse(uieCotizacion.txtMontoMuerte);				
						materia.RemesaValores = int.Parse(uieCotizacion.txtRemesa);
						materia.MontoRobo = float.Parse(uieCotizacion.txtRobo);
						materia.MontoMercaderias = float.Parse(uieCotizacion.txtRobo);
						break;
					case "Gimnacios":
						oItem.MontoAsegurado = materia.ValorContenido + materia.ValorEdificio;
						materia.MontoRC = int.Parse(uieCotizacion.txtRCivil);
						materia.Cristales = int.Parse(uieCotizacion.txtCristales);
						materia.CajaSeguridad = int.Parse(uieCotizacion.txtDineroCaja);
						materia.MontoMuerte = int.Parse(uieCotizacion.txtMontoMuerte);				
						materia.RemesaValores = int.Parse(uieCotizacion.txtRemesa);
						materia.MontoRobo = float.Parse(uieCotizacion.txtRobo);
						materia.MontoMercaderias = float.Parse(uieCotizacion.txtRobo);
						break;
					case "Medicos":
						oItem.MontoAsegurado = materia.ValorContenido + materia.ValorEdificio;
						materia.MontoRC = int.Parse(uieCotizacion.txtRCivil);
						materia.Cristales = int.Parse(uieCotizacion.txtCristales);
						materia.CajaSeguridad = int.Parse(uieCotizacion.txtDineroCaja);
						materia.MontoMuerte = int.Parse(uieCotizacion.txtMontoMuerte);				
						materia.RemesaValores = int.Parse(uieCotizacion.txtRemesa);
						materia.MontoRobo = float.Parse(uieCotizacion.txtRobo);
						materia.MontoMercaderias = float.Parse(uieCotizacion.txtRobo);
						break;
					case "Automoviles":
						oItem.MontoAsegurado = materia.ValorContenido + materia.ValorEdificio;
						materia.MontoRC = int.Parse(uieCotizacion.txtRCivil);
						materia.Cristales = int.Parse(uieCotizacion.txtCristales);
						materia.CajaSeguridad = int.Parse(uieCotizacion.txtDineroCaja);
						materia.MontoMuerte = int.Parse(uieCotizacion.txtMontoMuerte);				
						materia.RemesaValores = int.Parse(uieCotizacion.txtRemesa);
						materia.MontoRobo = float.Parse(uieCotizacion.txtRobo);
						materia.MontoMercaderias = float.Parse(uieCotizacion.txtRobo);
						break;
					case "Educacional":
						oItem.MontoAsegurado = materia.ValorContenido + materia.ValorEdificio;
						materia.MontoRC = int.Parse(uieCotizacion.txtRCivil);
						materia.Cristales = int.Parse(uieCotizacion.txtCristales);
						materia.CajaSeguridad = int.Parse(uieCotizacion.txtDineroCaja);
						materia.MontoMuerte = int.Parse(uieCotizacion.txtMontoMuerte);				
						materia.RemesaValores = int.Parse(uieCotizacion.txtRemesa);
						materia.MontoRobo = float.Parse(uieCotizacion.txtRobo);
						materia.MontoMercaderias = float.Parse(uieCotizacion.txtRobo);
						break;
					case "Edifico":
						oItem.MontoAsegurado = materia.ValorContenido + materia.ValorEdificio;
						materia.MontoRC = int.Parse(uieCotizacion.txtRCivil);
						materia.Cristales = int.Parse(uieCotizacion.txtCristales);
						materia.CajaSeguridad = int.Parse(uieCotizacion.txtDineroCaja);
						materia.MontoMuerte = int.Parse(uieCotizacion.txtMontoMuerte);				
						materia.RemesaValores = int.Parse(uieCotizacion.txtRemesa);
						materia.MontoRobo = float.Parse(uieCotizacion.txtRobo);
						materia.MontoMercaderias = float.Parse(uieCotizacion.txtRobo);
						break;
					case "Restaurantes":
						oItem.MontoAsegurado = materia.ValorContenido + materia.ValorEdificio;
						materia.MontoRC = int.Parse(uieCotizacion.txtRCivil);
						materia.Cristales = int.Parse(uieCotizacion.txtCristales);
						materia.CajaSeguridad = int.Parse(uieCotizacion.txtDineroCaja);
						materia.MontoMuerte = int.Parse(uieCotizacion.txtMontoMuerte);				
						materia.RemesaValores = int.Parse(uieCotizacion.txtRemesa);
						materia.MontoRobo = float.Parse(uieCotizacion.txtRobo);
						materia.MontoMercaderias = float.Parse(uieCotizacion.txtRobo);						
						break;
				}

				//Se consulta si la materia es valida
				/* Se agrega si es valida, en caso contrario se envia una excepcion */
				if (materia.IsValidForAdd())
				{
					oItem.oMateria = materia;
				}
				// Setea el tipo de Materia, en este caso vehículo
				oItem.oTipoMateria.TipoMateriaID = (int)eeMateriaCatalog.ePropiedad ;

				//Se establece para seguros ANS la agrupación del producto, por cuanto, en este caso es 
				//la manera al no hjaber Producto aún
				oItem.oProducto.oAgrupacion.Id = 200;

				// Agrega el nuevo ítem a los ítems de la Cotización
				oItem.ItemCotizacionID = oCotizacion.oItemeS.Count + 1;

				oItem.RecargoDescuento = float.Parse(uieCotizacion.txtRecargo, (CultureInfo) State["Cultura"] );
				if(plan == "Estandar")
				{
					if(oItem.RecargoDescuento < -20f)
					{
						throw new Exception("Excede el descuento máximo.");
					}
				}

				//Renovaciones: para que no se pierda el valor de aumento por siniestro 
				if(State["PRODUCTODIFERENCIASINIESTRO"] != null)
				{ 
					oItem.ProductoRetarificar = State["PRODUCTODIFERENCIASINIESTRO"].ToString();
					oItem.DiferenciaAfecta = (float)State["DIFERENCIASINIESTROAFECTA"];
					oItem.DiferenciaExenta = (float)State["DIFERENCIASINIESTROEXENTA"];
					oItem.RetarificarTodasLasOfertas = (bool)State["RETARIFICARTODASLASOFERTAS"];
				}


				oCotizacion.oItemeS.Add( oItem );
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
		}

		public void EliminarItemCotizacion(int index)
		{
			try
			{
				// Obtiene la Cotización desde el State
				CotizacionBC oCotizacion = (CotizacionBC) State["Cotizacion"];

				
				//Renovaciones: para que no se pierda el valor de aumento por siniestro 
				if(((ItemCotizacionBC)oCotizacion.oItemeS[index]).ProductoRetarificar != "")
				{ 

					State["PRODUCTODIFERENCIASINIESTRO"] = ((ItemCotizacionBC)oCotizacion.oItemeS[index]).ProductoRetarificar;					 
					State["DIFERENCIASINIESTROAFECTA"] = ((ItemCotizacionBC)oCotizacion.oItemeS[index]).DiferenciaAfecta;
					State["DIFERENCIASINIESTROEXENTA"] = ((ItemCotizacionBC)oCotizacion.oItemeS[index]).DiferenciaExenta;
					State["RETARIFICARTODASLASOFERTAS"] = ((ItemCotizacionBC)oCotizacion.oItemeS[index]).RetarificarTodasLasOfertas;
				}

				oCotizacion.oItemeS.RemoveAt(index);
				//for (int i=0; i<oCotizacion.oItemeS.Count;i++)
				//	((ItemCotizacionBC) oCotizacion.oItemeS[i]).ItemCotizacionID = i + 1;
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
		}

		public CotizacionUIE DesplegarCotizacion()
		{
			CotizacionBC oCotizacion = new CotizacionBC();
			// crea un nuevo UIE
			CotizacionUIE uieCotizacion = new CotizacionUIE();

			try
			{
				if (State["Cotizacion"] == null)
				{
					// Crea una nueva Cotización si no existe
					// Setea el Corredor
					oCotizacion.oCorredor = CorredorPool.GetCorredor((string)State["CorredorID"]);;

					// Setea el Agente
					oCotizacion.oAgente = (PersonaBC) State["Agente"];

					// Setea la Fecha actual
					oCotizacion.Fecha = DateTime.Now;

					oCotizacion.AgrupacionID = 200;

					if(oCotizacion.oItemeS.Count > 0)
					{
						//Condominio
						if(((ItemCotizacionBC)oCotizacion.oItemeS[0]).oProducto.ProductoID == "00000000-0000-0000-0000-000000000266")
						{
							oCotizacion.SubAgrupacionID = 13000;
							uieCotizacion.txtAno = ((MateriaPropiedadBC) ((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).Ano;
						} //Condominio RSA
						else if(((ItemCotizacionBC)oCotizacion.oItemeS[0]).oProducto.ProductoID == "00000000-0000-0000-0000-000000000267")
						{
							oCotizacion.SubAgrupacionID = 13000;
							uieCotizacion.txtCantidadUnidades = ((MateriaPropiedadBC) ((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).CantidadUnidades.ToString();
						}
					}

					State["Cotizacion"] = oCotizacion;
				}
				// Obtiene la Cotización desde el State
				oCotizacion = (CotizacionBC) State["Cotizacion"];

				uieCotizacion.DatosContratante = Utilities.GetPersona( oCotizacion.oContratante );

				//				// Solo en el caso de MonoItem
				//				if (oCotizacion.oItemeS.Count > 0)
				//					uieCotizacion.DatosAsegurado = Utilities.GetPersona( ((ItemCotizacionBC)oCotizacion.oItemeS[0]).oAsegurado );

				uieCotizacion.txtValorContenido = float.Parse("0").ToString("N",(CultureInfo)State["Cultura"]);
				uieCotizacion.txtValorEstructura = float.Parse("0").ToString("N",(CultureInfo)State["Cultura"]);
				uieCotizacion.txtMontoEquiposElectronicos = float.Parse("0").ToString("N",(CultureInfo)State["Cultura"]);
				uieCotizacion.txtMontoMercaderias = float.Parse("0").ToString("N",(CultureInfo)State["Cultura"]);
				uieCotizacion.txtMontoMaquinarias = float.Parse("0").ToString("N",(CultureInfo)State["Cultura"]);

				//INICIO - WS015
				if (oCotizacion.SubAgrupacionID == 13000)
					if(oCotizacion.oItemeS.Count > 0)
						uieCotizacion.txtPxP = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).MontoPxP.ToString();
					else
						uieCotizacion.txtPxP = "0";
				else
					uieCotizacion.txtPxP = "0";
				//FIN - WS015
        //Código: JC025
				//uieCotizacion.txtNumeroTrabajadores = "0";

				uieCotizacion.txtRCivil = "0";
				uieCotizacion.txtCristales = "0";
				uieCotizacion.txtMontoMuerte = "0";
				uieCotizacion.txtDineroCaja = "0";
				uieCotizacion.txtRemesa = "0";


				//Se obtiene el DataTable desde los itemes
				uieCotizacion.offerItems = oCotizacion.oItemeS.GetDataTableWithTarifa();

				// Totales de la Cotización
				uieCotizacion.txtPrimaNeta = oCotizacion.PrimaNeta.ToString("N",(CultureInfo)State["Cultura"]);
				uieCotizacion.txtIva = oCotizacion.IVA.ToString("N",(CultureInfo)State["Cultura"]);
				uieCotizacion.txtPrimaBruta = oCotizacion.PrimaBruta.ToString("N",(CultureInfo)State["Cultura"]);

				uieCotizacion.txtRecargo = float.Parse("0").ToString("N",(CultureInfo)State["Cultura"]);

        //Ini:Código: JC025
				uieCotizacion.TxtN_Reserva_ACE = "0";
				uieCotizacion.ddlTipoFinanciamiento = "100";
				uieCotizacion.ddlNumeroCuotas = "1";
				if(uieCotizacion.txtCantidadUnidades.Trim()=="")
					uieCotizacion.txtCantidadUnidades = "0";
        //Fin:Código: JC025

				if(oCotizacion.oItemeS.Count > 0)
				{
					//Generico
					uieCotizacion.MensajeTarificacion = ((ItemCotizacionBC)oCotizacion.oItemeS[0]).MensajeTarificacion;

					//Condominio
					uieCotizacion.txtAno = ((MateriaPropiedadBC) ((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).Ano;
						
					//Condominio RSA
					uieCotizacion.ddlConstruccionMuro = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).oConstruccionMuro.Id.ToString();
					uieCotizacion.ddlConstruccionTecho = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).oConstruccionTecho.Id.ToString();
					uieCotizacion.ddlActividad = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).oActividadPropiedad.Id.ToString();
					uieCotizacion.txtAno = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).Ano;

					uieCotizacion.txtValorEstructura = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).ValorEdificio.ToString("N",CultureFormat.Cultura);
					uieCotizacion.txtValorContenido = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).ValorContenido.ToString("N",CultureFormat.Cultura);
					uieCotizacion.txtNumeroTrabajadores = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).NumeroTrabajadores.ToString();
					uieCotizacion.txtRecargo = ((ItemCotizacionBC)oCotizacion.oItemeS[0]).RecargoDescuento.ToString();

					uieCotizacion.txtCantidadUnidades = ((MateriaPropiedadBC) ((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).CantidadUnidades.ToString();
					//Ini:Código: JC024
					
                    uieCotizacion.ddlTipoFinanciamiento = ((MateriaPropiedadBC) ((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).FormaPagoID.ToString();
					uieCotizacion.ddlNumeroCuotas = ((MateriaPropiedadBC) ((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).NumeroCuotas.ToString();
					
          //Ini:Código: JC025
					uieCotizacion.TxtN_Reserva_ACE = ((MateriaPropiedadBC) ((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).N_Reserva_ACE.ToString();

					if( uieCotizacion.TxtN_Reserva_ACE =="-1")
					{
						uieCotizacion.TxtN_Reserva_ACE ="0";
					}
          //Fin:Código: JC025

					if( uieCotizacion.ddlTipoFinanciamiento =="-1")
					{
						uieCotizacion.ddlTipoFinanciamiento = "100";
						uieCotizacion.ddlNumeroCuotas ="1";

					}

                   //Fin:Código: JC024
				}

			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
			return uieCotizacion;
		}

		public void InstanciarItemCotizacion(int index)
		{
			try
			{
				// Obtiene la Cotización desde el State
				CotizacionBC oCotizacion = (CotizacionBC) State["Cotizacion"];

				ItemCotizacionBC oItem = (ItemCotizacionBC)oCotizacion.oItemeS[index];
				
				if (State.Contains("Item"))
					State.Remove("Item");
				State["Item"] = oItem;
				if (State.Contains("TipoItem"))
					State.Remove("TipoItem");
				State["TipoItem"] = "cotizacion";
				GC.Collect();
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
		}

		public void ActualizarCotizacion(CotizacionUIE uie)
		{
			try
			{
				DataTable dt = uie.offerItems;
				// Obtiene la Cotización desde el State
				CotizacionBC oCotizacion = (CotizacionBC) State["Cotizacion"];
				
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					ItemCotizacionBC oItem = (ItemCotizacionBC)oCotizacion.oItemeS[i];
						
					if (dt.Rows[i]["oDTarificador"] != System.DBNull.Value)
					{
						DataTable dtTarifas = (DataTable)dt.Rows[i]["oDTarificador"];
						oItem.oTarifaS = dtTarifas;
					}
					else
					{
						oItem.oTarifaS = null;
					}

					if (dt.Rows[i]["Compania"].ToString().Trim() != "")
					{
						
						
						float primaNetaAfecta = 0f;
						float primaNetaExenta = 0f;

						if (oItem.oProducto != null)
						{
							if (("{" + oItem.oProducto.ProductoID +"}") != dt.Rows[i]["ProductoID"].ToString() ||
								oItem.oCompania.Id.ToString() != dt.Rows[i]["CompaniaID"].ToString()||
								oItem.oDeducible.DeducibleID.ToString() != dt.Rows[i]["DeducibleID"].ToString())
								//|| (State["PrimaNetaAfecta"] == null && State["PrimaNetaExenta"] == null))
							{
								if (dt.Rows[i]["ValorPrimaNetaAfecta"].ToString().Trim() != "")
									primaNetaAfecta = float.Parse(dt.Rows[i]["ValorPrimaNetaAfecta"].ToString(),(CultureInfo) State["Cultura"]);
								
								if (dt.Rows[i]["ValorPrimaNetaExenta"].ToString().Trim() != "")
									primaNetaExenta = float.Parse(dt.Rows[i]["ValorPrimaNetaExenta"].ToString(),(CultureInfo) State["Cultura"]);

								State["PrimaNetaAfecta"] = primaNetaAfecta;
								State["PrimaNetaExenta"] = primaNetaExenta;

								oItem.oCompania.Id = int.Parse(dt.Rows[i]["CompaniaID"].ToString());
								//oItem.oCompania.Read();

								//Segun compania cambia la ocupacion
								
								//Si no existe compañía seleccionada se debe seleccionar la ocupacion según la actividad.
								MateriaPropiedadBC oMateria = (MateriaPropiedadBC)oItem.oMateria;
								int ocupacionid = this.GetOcupacionPyme(oItem.oCompania.Id, oMateria.oActividadPropiedad.Id);
								oMateria.oOcupacionComercio.Id = ocupacionid;
								
								
								// Es un nuevo producto
								ProductoBC oProducto = new ProductoBC();
								oProducto.ProductoID = dt.Rows[i]["ProductoID"].ToString();
								oProducto.Version = int.Parse(dt.Rows[i]["ProductoVersion"].ToString());
								if(ProductoPool.htProductos.ContainsKey(oProducto.ProductoID.Replace("{","").Replace("}","") + oProducto.Version.ToString()))
								{
									oProducto = (ProductoBC) ProductoPool.htProductos[oProducto.ProductoID.Replace("{","").Replace("}","") + oProducto.Version.ToString()];
								}
								else
								{
									oProducto.Read();
								}
								oItem.oProducto = (ProductoBC)oProducto.Clone();

								//es un nuevo deducible
								oItem.oDeducible.DeducibleID = int.Parse(dt.Rows[i]["DeducibleID"].ToString());
								oItem.oDeducible.Read();
								
								// Se setean las coberturas obligatorias del producto al ítem
								oItem.oItemCoberturaS.Clear();
								oItem.oItemCoberturaS.AddRange(oProducto.oCoberturasObligatoriaS); 
								for (int m = 0; m < oItem.oItemCoberturaS.Count ; m++)
								{
									((ItemCotizacionCoberturaBC) oItem.oItemCoberturaS[m]).Obligatoria = true;
									((ItemCotizacionCoberturaBC) oItem.oItemCoberturaS[m]).oDeducible.DeducibleID = oItem.oDeducible.DeducibleID;
									((ItemCotizacionCoberturaBC) oItem.oItemCoberturaS[m]).oDeducible.Read();
								}
								if(oItem.oProducto.ProductoID == "00000000-0000-0000-0000-000000000266"){
									if(oItem.oDeducible.DeducibleID == 290){
										ItemCotizacionCoberturaBC oCobertura = new ItemCotizacionCoberturaBC();
										oCobertura.CoberturaID = 15120;
										oCobertura.Read();
										oCobertura.Obligatoria = true;
										oCobertura.Base = true;
										oItem.oItemCoberturaS.Add(oCobertura);
									}
									oCotizacion.SubAgrupacionID = 13000;
								}
								//INICIO - WS012
                //Ini:Código: JC025
								else if(oItem.oProducto.ProductoID == "00000000-0000-0000-0000-000000000959" || oItem.oProducto.ProductoID == "00000000-0000-0000-0000-000000000969")
								{
									oCotizacion.SubAgrupacionID = 13000;

									if(oItem.oDeducible.DeducibleID == 270 && oItem.oProducto.ProductoID == "00000000-0000-0000-0000-000000000969")
									{
										oItem.oItemCoberturaS.QuitarCobertura(31839);
										oItem.oItemCoberturaS.QuitarCobertura(31840);
									}
                  //Fin:Código: JC025

									//INI RJNV028
									if (oProducto.ProductoID == "00000000-0000-0000-0000-000000000969") //Condimios ACE (SHUBB) Logica para nueva cobertura ACCIDENTES PERSONALES PLAN A Y B
									{
										if (oItem.MontoAsegurado > 250000)
										{
											oItem.oItemCoberturaS.QuitarCobertura(31878);
										}
									}
									//FIN RJNV028
								}
								//FIN - WS012
								else
								{
									System.Xml.XmlDocument xmlDeducibles = new XmlDocument();
									string rutaXml = this.State["RutaXML"].ToString();
									xmlDeducibles.Load(rutaXml);
			
									XmlElement nodeDeducible = xmlDeducibles.DocumentElement;
									//FF007
									if(oItem.oCompania.Id != 17 && oItem.oCompania.Id != 5)
									{
										XmlNodeList DeducibleItems = nodeDeducible.SelectNodes("//Deducible");								
										foreach(XmlNode deducibleItem in DeducibleItems)
										{
											if(deducibleItem.Attributes["id"].Value.Trim() == oItem.oDeducible.DeducibleID.ToString())
											{
												XmlNodeList coberturasItems = deducibleItem.ChildNodes;
												foreach(XmlNode coberturaItem in coberturasItems)
												{
													ItemCotizacionCoberturaBC oCobertura = new ItemCotizacionCoberturaBC();
													int cobID = int.Parse(coberturaItem.Attributes["text"].Value.Trim());
													//if(cobID == 1070 && (oItem.oCompania.Id == 12 || oItem.oCompania.Id == 16)) cobID = 2129;
													if(cobID == 1070 && (oItem.oCompania.Id == 12)) cobID = 2129;
													if(cobID == 2113 && oItem.oCompania.Id == 12) continue;
													if((oProducto.ProductoID == "00000000-0000-0000-0000-000000000263" ||
														oProducto.ProductoID == "00000000-0000-0000-0000-000000000264" ||												
														oProducto.ProductoID == "00000000-0000-0000-0000-000000000265") && (cobID == 1070))
													{
														cobID = 2129;
													}
													if((oProducto.ProductoID == "00000000-0000-0000-0000-000000000263" ||
														oProducto.ProductoID == "00000000-0000-0000-0000-000000000264" ||												
														oProducto.ProductoID == "00000000-0000-0000-0000-000000000265") &&
														(cobID == 2107 || cobID == 2113))
													{
														continue;
													}
													if(oProducto.ProductoID == "00000000-0000-0000-0000-000000000267")
													{
														cobID= 25874;
													}
													oCobertura.CoberturaID = cobID;
													oCobertura.Read();
													oCobertura.Obligatoria = true;
													oCobertura.Base = true;
													if(oCobertura.CoberturaID != 3443)
														oItem.oItemCoberturaS.Add(oCobertura);
												}
											}
										}
									}
										//Ini - FF007
									else if(oItem.oCompania.Id == 5)
									{
										XmlNodeList DeducibleItems = nodeDeducible.SelectNodes("//DeducibleACE");								
										foreach(XmlNode deducibleItem in DeducibleItems)
										{
											if(deducibleItem.Attributes["id"].Value.Trim() == oItem.oDeducible.DeducibleID.ToString())
											{
												XmlNodeList coberturasItems = deducibleItem.ChildNodes;
												foreach(XmlNode coberturaItem in coberturasItems)
												{
													ItemCotizacionCoberturaBC oCobertura = new ItemCotizacionCoberturaBC();
													int cobID = int.Parse(coberturaItem.Attributes["text"].Value.Trim());													
													oCobertura.CoberturaID = cobID;
													oCobertura.Read();
													oCobertura.Obligatoria = true;
													oCobertura.Base = true;
													oItem.oItemCoberturaS.Add(oCobertura);
												}
											}
										}
									}
										//Fin - FF007
									else //CONSORCIO
									{
										XmlNodeList DeducibleItems = nodeDeducible.SelectNodes("//DeducibleCNS");								
										foreach(XmlNode deducibleItem in DeducibleItems)
										{
											if(deducibleItem.Attributes["id"].Value.Trim() == oItem.oDeducible.DeducibleID.ToString())
											{
												XmlNodeList coberturasItems = deducibleItem.ChildNodes;
												foreach(XmlNode coberturaItem in coberturasItems)
												{
													ItemCotizacionCoberturaBC oCobertura = new ItemCotizacionCoberturaBC();
													int cobID = int.Parse(coberturaItem.Attributes["text"].Value.Trim());													
													oCobertura.CoberturaID = cobID;
													oCobertura.Read();
													oCobertura.Obligatoria = true;
													oCobertura.Base = true;
													oItem.oItemCoberturaS.Add(oCobertura);
												}
											}
										}
									
									}

									//INICIO - WS018
									if (oProducto.ProductoID == "00000000-0000-0000-0000-000000000275")
									{
										if(((MateriaPropiedadBC)oItem.oMateria).MontoMaquinarias == 0f || ((MateriaPropiedadBC)oItem.oMateria).AveriaMaquinaria == false)
										{
											oItem.oItemCoberturaS.QuitarCobertura(31557);
										}
									}
									//FIN - WS018



									if(((MateriaPropiedadBC)oItem.oMateria).MontoMaquinarias == 0f
										&& ((MateriaPropiedadBC)oItem.oMateria).MontoEquiposElectronicos == 0f)
									{
										oItem.oItemCoberturaS.QuitarCobertura(2100);
										oItem.oItemCoberturaS.QuitarCobertura(2101);
										oItem.oItemCoberturaS.QuitarCobertura(2105);
									}

									//								if(oProducto.ProductoID != "00000000-0000-0000-0000-000000000240" || 
									//									 oProducto.ProductoID != "00000000-0000-0000-0000-000000000241" ||
									//									 oProducto.ProductoID != "00000000-0000-0000-0000-000000000242")
									//								{
									//									oMateria.RoboViolencia = oMateria.ValorContenido + 
									//																					 oMateria.MontoMaquinarias + 
									//																					 oMateria.MontoMercaderias;
									//								}

									//Evitar validación para pyme especiales inter
									if(oProducto.ProductoID != "00000000-0000-0000-0000-000000000250" &&
										oProducto.ProductoID != "00000000-0000-0000-0000-000000000251" &&
										oProducto.ProductoID != "00000000-0000-0000-0000-000000000252" &&
										oProducto.ProductoID != "00000000-0000-0000-0000-000000000253" &&
										oProducto.ProductoID != "00000000-0000-0000-0000-000000000254" &&
										oProducto.ProductoID != "00000000-0000-0000-0000-000000000255" &&
										oProducto.ProductoID != "00000000-0000-0000-0000-000000000256" )
									{
								
										if((((MateriaPropiedadBC)oItem.oMateria).MontoMuerte * ((MateriaPropiedadBC)oItem.oMateria).NumeroTrabajadores) == 0f)
										{
											oItem.oItemCoberturaS.QuitarCobertura(2110);
											//pyme CNS
											oItem.oItemCoberturaS.QuitarCobertura(30555);
										}
									}

									// Inicio ME001
									if(((MateriaPropiedadBC)oItem.oMateria).MontoEquiposElectronicos == 0f)
									{
										oItem.oItemCoberturaS.QuitarCobertura(31133);
										oItem.oItemCoberturaS.QuitarCobertura(31134);
									}
									// Fin ME001

									if(((MateriaPropiedadBC)oItem.oMateria).MontoPxP == 0f)
									{
										//pyme Inter
										oItem.oItemCoberturaS.QuitarCobertura(701);
										oItem.oItemCoberturaS.QuitarCobertura(702);
										//pyme RSA y Nuevo Pyme BCI
										oItem.oItemCoberturaS.QuitarCobertura(2130);
										oItem.oItemCoberturaS.QuitarCobertura(2131);
										//pyme CNS
										oItem.oItemCoberturaS.QuitarCobertura(30549);
										oItem.oItemCoberturaS.QuitarCobertura(30550);
										//ini - FF007
										//pyme ace
										oItem.oItemCoberturaS.QuitarCobertura(31129);
										oItem.oItemCoberturaS.QuitarCobertura(31130);
										//Fin - FF007
									}
									if(((MateriaPropiedadBC)oItem.oMateria).CajaSeguridad == 0f)
									{
										oItem.oItemCoberturaS.QuitarCobertura(2107);
										//pyme CNS
										oItem.oItemCoberturaS.QuitarCobertura(30548);
										//Ini - FF007
										//pyme ACE
										oItem.oItemCoberturaS.QuitarCobertura(31131);
										//Fin - FF007
									}
									if(((MateriaPropiedadBC)oItem.oMateria).RemesaValores == 0f)
									{
										oItem.oItemCoberturaS.QuitarCobertura(2113);
										//pyme CNS
										oItem.oItemCoberturaS.QuitarCobertura(30554);
										//Ini - FF007
										//pyme ACE
										oItem.oItemCoberturaS.QuitarCobertura(31135);
										//Fin - FF007
									}
									if(oItem.oDeducible.DeducibleID == 270 || oItem.oDeducible.DeducibleID == 280)
										oItem.oItemCoberturaS.QuitarCobertura(702);
									if(((MateriaPropiedadBC)oItem.oMateria).Cristales == 0f)
									{
										oItem.oItemCoberturaS.QuitarCobertura(380);
										//pyme CNS
										oItem.oItemCoberturaS.QuitarCobertura(30546);
										//Ini - FF007
										//pyme ACE
										oItem.oItemCoberturaS.QuitarCobertura(31126);
										//Fin - FF007
									}
									if(((MateriaPropiedadBC)oItem.oMateria).MontoRC == 0f)
									{
										oItem.oItemCoberturaS.QuitarCobertura(2112);
									}		
									if(((MateriaPropiedadBC)oItem.oMateria).MontoEquiposElectronicos == 0f)
									{
										//Pyme RSA
										oItem.oItemCoberturaS.QuitarCobertura(3162);
										oItem.oItemCoberturaS.QuitarCobertura(3165);
										//pyme CNS
										oItem.oItemCoberturaS.QuitarCobertura(30551);
										oItem.oItemCoberturaS.QuitarCobertura(30552);

										//Ini Código: JC004 : se agrega nueva cobertura para equipos electronicos.
										oItem.oItemCoberturaS.QuitarCobertura(30560);

										//Ini - FF007
										//pyme ACE
										oItem.oItemCoberturaS.QuitarCobertura(31132);
										//Fin - FF007
									}
											
									if(((MateriaPropiedadBC)oItem.oMateria).AveriaMaquinaria == false)
									{
										oItem.oItemCoberturaS.QuitarCobertura(30557);
										oItem.oItemCoberturaS.QuitarCobertura(30558);
									}
										
									if(((MateriaPropiedadBC)oItem.oMateria).Terrorismo == false)
									{
										oItem.oItemCoberturaS.QuitarCobertura(30559);
									}

									//Si no tiene sismo quita coberturas de PXP y EE por sismo
									if(oItem.oDeducible.DeducibleID == 270 ||
										oItem.oDeducible.DeducibleID == 280 )
									{
										oItem.oItemCoberturaS.QuitarCobertura(2131);
	// TRACKER 9538 se descomenta esta cobertura para que se quite 06-10-2014 (MAURICIO)
										oItem.oItemCoberturaS.QuitarCobertura(3165);
										//Ini - FF007
										//pyme ACE
										oItem.oItemCoberturaS.QuitarCobertura(31133);//ee
										oItem.oItemCoberturaS.QuitarCobertura(31130);//pxp
										//Fin - FF007
									}
								
									//PARA RSA
									if(oProducto.ProductoID == "00000000-0000-0000-0000-000000000260")
									{
										if(((MateriaPropiedadBC)oItem.oMateria).ValorEdificio == 0f)
										{
											//quita cobertura inhabitabilidad
											oItem.oItemCoberturaS.QuitarCobertura(2126);
										}
									}

									//PARA Condominio RSA
									if(oProducto.ProductoID == "00000000-0000-0000-0000-000000000267")
									{
										//Solo incendio no tiene la cobertura de sismo
										if(oItem.oDeducible.DeducibleID == 270)
										{
											//quita cobertura inhabitabilidad
											oItem.oItemCoberturaS.QuitarCobertura(25874);
										}
										//Asigna subagrupacionid
										oCotizacion.SubAgrupacionID = 13000;
									}

									oProducto = null;
								}
							}
						}
						if (State["PrimaNetaAfecta"] != null)
							primaNetaAfecta = (float) State["PrimaNetaAfecta"];
						else
						{
							primaNetaAfecta = oItem.PrimaNetaAfecta - oItem.oItemCoberturaS.GetTotalNetoAfecto(eeTipoCobertura.eOpcionales);
							State["PrimaNetaAfecta"] = primaNetaAfecta;
						}
						if (State["PrimaNetaExenta"] != null)
							primaNetaExenta = (float) State["PrimaNetaExenta"];
						else
						{
							primaNetaExenta = oItem.PrimaNetaExenta - oItem.oItemCoberturaS.GetTotalNetoExento(eeTipoCobertura.eOpcionales);
							State["PrimaNetaExenta"] = primaNetaExenta;
						}
						// Distribución de prima
						oItem.DistribuirPrimaNeta(primaNetaAfecta,primaNetaExenta);
					}
				}
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
		}

		public string GrabarCotizacion(string username)
		{
			string folio;
			try
			{
				// Obtiene la Cotización desde el State
				CotizacionBC oCotizacion = (CotizacionBC) State["Cotizacion"];
				if(oCotizacion.UserName.Trim()=="")
					oCotizacion.UserName = username;
				oCotizacion.Create();
				folio = oCotizacion.Folio.ToString();
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
			return folio;
		}

		public void InstanciarPoliza()
		{
			InstanciarPoliza(false);
		}

		public void InstanciarPoliza(bool ActualizaVigencia)
		{
			try
			{
				// Obtiene la Cotización desde el State
				CotizacionBC oCotizacion = (CotizacionBC) State["Cotizacion"];

				// Almacenando la Póliza en es State
				if (State.Contains("Poliza"))	State.Remove("Poliza");
				PolizaBC oPoliza = oCotizacion.GetPoliza(ActualizaVigencia);
				State["Poliza"] = oPoliza;
				State["PolizaGrabada"] = false;
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
		}

		public string GetCotizacionXML()
		{
			// Obtiene la Cotización desde el State
			CotizacionBC oCotizacion = (CotizacionBC) State["Cotizacion"];

			return oCotizacion.GetXml();
		}

	

		public CotizacionUIE ObtenerItem()
		{
			CotizacionBC oCotizacion = new CotizacionBC();
			// crea un nuevo UIE
			CotizacionUIE uieCotizacion = new CotizacionUIE();
			try
			{
				if (State["Cotizacion"] == null)
				{
					// Crea una nueva Cotización si no existe
					// Setea el Corredor
					oCotizacion.oCorredor = CorredorPool.GetCorredor((string)State["CorredorID"]);;

					// Setea el Agente
					oCotizacion.oAgente = (PersonaBC) State["Agente"];

					// Setea la Fecha actual
					oCotizacion.Fecha = DateTime.Now;
					oCotizacion.AgrupacionID = 200;

					State["Cotizacion"] = oCotizacion;
				}
				// Obtiene la Cotización desde el State
				oCotizacion = (CotizacionBC) State["Cotizacion"];

				uieCotizacion.DatosContratante = Utilities.GetPersona(oCotizacion.oContratante);
				
				// Solo en el caso de MonoItem
				if (oCotizacion.oItemeS.Count > 0)
				{					
					uieCotizacion.ddlActividad = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).oActividadPropiedad.Id.ToString();
					uieCotizacion.ddlCiudad = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).oCiudad.Id.ToString();
					uieCotizacion.ddlComuna = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).oComuna.Id.ToString();				
					uieCotizacion.ddlConstruccionMuro = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).oConstruccionMuro.Id.ToString();
					uieCotizacion.ddlConstruccionTecho = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).oConstruccionTecho.Id.ToString();
					uieCotizacion.ddlOcupacion = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).oOcupacionComercio.Id.ToString();
					uieCotizacion.ddlRegion = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).oRegion.Id.ToString();

					uieCotizacion.txtPxP = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).MontoPxP.ToString();
					uieCotizacion.ddlPeriodo = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).PeriodoPxP.ToString();
					uieCotizacion.ddlRCivil = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).MontoRC.ToString();
					uieCotizacion.ddlCristales = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).Cristales.ToString();
					uieCotizacion.ddlDineroCaja = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).CajaSeguridad.ToString();
					uieCotizacion.ddlMontoMuerte = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).MontoMuerte.ToString();
					uieCotizacion.txtNumeroTrabajadores = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).NumeroTrabajadores.ToString();
					uieCotizacion.ddlRemesa = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).RemesaValores.ToString();
					uieCotizacion.chkRCAlimentos = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).RCAlimentos;

					uieCotizacion.chkDetectores = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).Detectores;
					uieCotizacion.chkRedHumeda = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).RedHumeda;
					uieCotizacion.chkSprinklers = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).Sprinklers;
					uieCotizacion.chkAntiguedad = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).MenorA50;

					
					uieCotizacion.ddlTipoUbicacion = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).oTipoUbicacion.Id.ToString();
					uieCotizacion.txtMejoraInmueble = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).MejoraInmueble.ToString("N",CultureFormat.Cultura);
					uieCotizacion.chkTerrorismo = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).Terrorismo;
					uieCotizacion.chkAveriaMaquinaria = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).AveriaMaquinaria;
					 
					//Ini - FG022
					uieCotizacion.chkRiesgoBordeCostero = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).RiesgoBordeCostero;
					uieCotizacion.chkRiesgoBordeRio = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).RiesgoBordeRio;
					//Fin - FG022

          //Ini:Código: JC024
					uieCotizacion.ddlTipoFinanciamiento =  ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).FormaPagoID.ToString();
					uieCotizacion.ddlNumeroCuotas =  ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).NumeroCuotas.ToString();
          //Fin:Código: JC024
         //Código: JC025
					uieCotizacion.TxtN_Reserva_ACE =  ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).N_Reserva_ACE.ToString();



					uieCotizacion.txtRCivil = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).MontoRC.ToString();
					uieCotizacion.txtCristales = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).Cristales.ToString();
					uieCotizacion.txtDineroCaja = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).CajaSeguridad.ToString();
					uieCotizacion.txtMontoMuerte = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).MontoMuerte.ToString();
					uieCotizacion.txtRemesa = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).RemesaValores.ToString();

					uieCotizacion.txtDireccion = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).Direccion.ToString();
					uieCotizacion.txtMontoEquiposElectronicos = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).MontoEquiposElectronicos.ToString("N",CultureFormat.Cultura);
					uieCotizacion.txtMontoMaquinarias = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).MontoMaquinarias.ToString("N",CultureFormat.Cultura);
					uieCotizacion.txtMontoMercaderias = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).MontoMercaderias.ToString("N",CultureFormat.Cultura);
					uieCotizacion.txtValorContenido = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).ValorContenido.ToString("N",CultureFormat.Cultura);
					uieCotizacion.txtValorEstructura = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).ValorEdificio.ToString("N",CultureFormat.Cultura);
					
					uieCotizacion.txtAno = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).Ano;

					uieCotizacion.txtRecargo = ((ItemCotizacionBC)oCotizacion.oItemeS[0]).RecargoDescuento.ToString();					
					
					uieCotizacion.ddlComision = oCotizacion.DescuentoComision.ToString();

					//Agregado para Condominio RSA
					uieCotizacion.txtCantidadUnidades = ((MateriaPropiedadBC)((ItemCotizacionBC)oCotizacion.oItemeS[0]).oMateria).CantidadUnidades.ToString();
				}
				else
				{					
					uieCotizacion.txtRecargo = float.Parse("0").ToString("N",(CultureInfo)State["Cultura"]);
					//Se obtiene el DataTable desde los itemes
					uieCotizacion.offerItems = oCotizacion.oItemeS.GetDataTableWithTarifa();
				}
				// Totales de la Cotización
				uieCotizacion.txtPrimaNeta = oCotizacion.PrimaNeta.ToString("N",(CultureInfo)State["Cultura"]);
				uieCotizacion.txtIva = oCotizacion.IVA.ToString("N",(CultureInfo)State["Cultura"]);
				uieCotizacion.txtPrimaBruta = oCotizacion.PrimaBruta.ToString("N",(CultureInfo)State["Cultura"]);
				
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
			return uieCotizacion;

		}

		#endregion

		#region Métodos de soporte para vista Coberturas
		public CoberturasUIE DesplegarCoberturas()
		{
			CoberturasUIE uieCoberturas = new CoberturasUIE();
			try
			{
				string sTipoItem = (string)State["TipoItem"];
				if (sTipoItem == "cotizacion")
				{
					// Obtener el item actual de Cotizacion
					ItemCotizacionBC oItem = (ItemCotizacionBC) State["Item"];
					if (State["PrimaNetaAfecta"] != null && State["PrimaNetaExenta"] != null)
						oItem.DistribuirPrimaNeta( (float) State["PrimaNetaAfecta"], (float) State["PrimaNetaExenta"] );

					DataView dvSeleccionadas = (DataView)oItem.oItemCoberturaS.GetDataView();
					
					// genera un DataView con solo las coberturas adicionales
					DataTable dtSel = dvSeleccionadas.Table.Copy();
					ArrayList indexes = new ArrayList();
					for (int i = 0; i < dtSel.Rows.Count; i++ )
					{
						DataRow dr = dtSel.Rows[i];
						if (((bool)dr["Base"]) == true)
							indexes.Add(i);
					}
					indexes.Sort();
					for (int i = (indexes.Count - 1); i >= 0; i--)
						dtSel.Rows[(int)indexes[i]].Delete();
					dvSeleccionadas = new DataView(dtSel);

					uieCoberturas.dgSeleccionadas = dvSeleccionadas;
					DataTable dtSeleccionadas = dvSeleccionadas.Table;

					DataView dvAdicionales = (DataView)oItem.oProducto.oCoberturasAdicionaleS.GetDataView();
					

					/*
					 * Eliminar de la lista de coberturas adicionales las coberturas opcionales según
					 * el deducible elegido 
					 */
					// genera un DataView con solo las coberturas adicionales
					DataTable dtAd = dvAdicionales.Table.Copy();
					ArrayList indexesAd = new ArrayList();					

					System.Xml.XmlDocument xmlDeducibles = new XmlDocument();
					string rutaXml = this.State["RutaXML"].ToString();
					xmlDeducibles.Load(rutaXml);
			
					XmlElement nodeDeducible = xmlDeducibles.DocumentElement;
					XmlNodeList DeducibleItems = nodeDeducible.SelectNodes("//Deducible");
								
					//foreach(XmlNode deducibleItem in DeducibleItems)
					for(int indice = 0; indice < DeducibleItems.Count; indice++)
					{
						XmlNode deducibleItem = (XmlNode)DeducibleItems[indice];

						if(deducibleItem.Attributes["id"].Value.Trim() == oItem.oDeducible.DeducibleID.ToString())
						{
							XmlNodeList coberturasItems = deducibleItem.ChildNodes;
							foreach(XmlNode coberturaItem in coberturasItems)
							{
								int CobAd = int.Parse(coberturaItem.Attributes["text"].Value.Trim());
								for (int i = 0; i < dtAd.Rows.Count; i++ )
								{
									//si la cobertura esta asociada al deducible
									DataRow dr = dtAd.Rows[i];
									if (((int)dr["CoberturaID"]) == CobAd)
										indexesAd.Add(i);
								}							
							}
						}
								
					}
					indexesAd.Sort();

					//elimina las coberturas
					for (int i = (indexesAd.Count - 1); i >= 0; i--)
						dtAd.Rows[(int)indexesAd[i]].Delete();
					dvAdicionales = new DataView(dtAd);

					DataTable dtAdicionales = dvAdicionales.Table;

					// Recorriendo las coberturas Adicionales
					ArrayList indices = new ArrayList();
					for (int iAdicional = 0; iAdicional < dtAdicionales.Rows.Count; iAdicional++ )
					{
						//verifica si no tiene oferta
						if(! ExisteOfertaCobertura(oItem.oProducto.ProductoID,oItem.oCompania.Id,int.Parse(dtAdicionales.Rows[iAdicional]["CoberturaID"].ToString())))
						{
							indices.Add(iAdicional);
						}
						else
							for (int iSeleccionada = 0; iSeleccionada < dtSeleccionadas.Rows.Count; iSeleccionada++ )
							{
								// Verifica si esta cobertura ya ha sido seleccionada 
								if (dtAdicionales.Rows[iAdicional]["CoberturaID"].ToString() == dtSeleccionadas.Rows[iSeleccionada]["CoberturaID"].ToString())
									indices.Add(iAdicional);
							}
					}
					indices.Sort();
					// Elimina las coberturas ya seleccionadas
					for (int i = (indices.Count - 1); i >= 0; i--)
						dtAdicionales.Rows[(int)indices[i]].Delete();

					uieCoberturas.dgDisponibles = new DataView(dtAdicionales);

					uieCoberturas.txtTotalPrimaNeta =  oItem.oItemCoberturaS.GetTotalNeto(eeTipoCobertura.eOpcionales).ToString("N",(CultureInfo)State["Cultura"]);
					uieCoberturas.txtImpuesto = oItem.oItemCoberturaS.GetTotalIVA(eeTipoCobertura.eOpcionales).ToString("N",(CultureInfo)State["Cultura"]);
					uieCoberturas.txtTotalPrimaBruta = oItem.oItemCoberturaS.GetTotalBruto(eeTipoCobertura.eOpcionales).ToString("N",(CultureInfo)State["Cultura"]);					
				}
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
			return uieCoberturas;

		}

		private bool ExisteOfertaCobertura(string productoID, int companiaID, int coberturaID)
		{
			DistribucionPrimaDALC oDP = new DistribucionPrimaDALC();
			oDP.Filtro.Add("ProductoID",productoID);
			oDP.Filtro.Add("CompaniaID",companiaID);
			oDP.Filtro.Add("CoberturaID",coberturaID);
			DataTable dt = oDP.ReadAll();
			if(dt.Rows.Count > 0)
				return true;
			else
				return false;
			
		}

		//		public DataView ListarCoberturasAdicionales()
		//		{
		//			DataView dv = new DataView();
		//			try
		//			{
		//				//Obtener el item actual de Poliza
		//				PolizaRiesgoBC oItem = (PolizaRiesgoBC) State["Item"];
		//				
		//				dv = (DataView)oItem.oCoberturas.GetDataView();
		//				dv.RowFilter = "Obligatoria = false";
		//			}
		//			catch(BusinessFunctionalException bfe)
		//			{
		//				ExceptionManager.Publish(bfe);
		//				throw bfe;
		//			}
		//			catch(BusinessTechException bte)
		//			{
		//				ExceptionManager.Publish(bte);
		//				throw bte;
		//			}
		//			catch(Exception e)
		//			{
		//				ExceptionManager.Publish(e);
		//				throw e;
		//			}
		//			return dv;
		//		}

		public void AgregarCoberturaASeleccionadas(int index)
		{
			try
			{
				string sTipoItem = (string)State["TipoItem"];
				if (sTipoItem == "cotizacion")
				{
					// Obtener el item actual de Cotizacion
					ItemCotizacionBC oItem = (ItemCotizacionBC) State["Item"];

					ItemCotizacionCoberturaBC oCoberturaDisponible = (ItemCotizacionCoberturaBC)
						oItem.oProducto.oCoberturasAdicionaleS[index];

					//					ItemCotizacionCoberturaBC oCoberturaItem = new ItemCotizacionCoberturaBC();
					//					oCoberturaItem.CoberturaID = oCoberturaDisponible.CoberturaID;
					//					oCoberturaItem.Read();
					//					oCoberturaItem.oDeducible.DeducibleID = 100;


					oItem.oItemCoberturaS.Add(oCoberturaDisponible);
					oItem.oProducto.oCoberturasAdicionaleS.RemoveAt(index);
				}
				else
				{
					//					// Obtener el item actual de Poliza
					//					PolizaRiesgoBC oItem = (PolizaRiesgoBC) State["Item"];
					//					
					//					ItemCotizacionCoberturaBC oCoberturaDisponible = (ItemCotizacionCoberturaBC)
					//						oItem.oParent.oProducto.oCoberturasAdicionaleS[index];
					//
					//					PolizaRiesgoCoberturaBC oCoberturaItem = new PolizaRiesgoCoberturaBC();
					//					oCoberturaItem.CoberturaID = oCoberturaDisponible.CoberturaID;
					//					oCoberturaItem.Read();
					//
					//					oItem.oCoberturas.Add(oCoberturaItem);
					//					oItem.oParent.oProducto.oCoberturasAdicionaleS.RemoveAt(index);
				}
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
		}

		public void EliminarCoberturaSeleccionada(int index)
		{
			try
			{
				string sTipoItem = (string)State["TipoItem"];
				if (sTipoItem == "cotizacion")
				{
					// Obtener el item actual de Cotizacion
					ItemCotizacionBC oItem = (ItemCotizacionBC) State["Item"];

					// Instancia la cobertura a quitar
					ItemCotizacionCoberturaBC oCoberturaItem = (ItemCotizacionCoberturaBC)
						oItem.oItemCoberturaS[index];

					if (!oCoberturaItem.Obligatoria)
					{
						// Agrega la Cobertura de vuelta al producto
						//						ItemCotizacionCoberturaBC oCoberturaDisponible = new ItemCotizacionCoberturaBC();
						//						oCoberturaDisponible.CoberturaID = oCoberturaItem.CoberturaID;
						//						oCoberturaDisponible.Read();
						//						oCoberturaDisponible.oDeducible = oCoberturaItem.oDeducible;

						oItem.oProducto.oCoberturasAdicionaleS.Add(oCoberturaItem);
						oItem.oItemCoberturaS.RemoveAt(index);
					}
				}
				else
				{
					//					// Obtener el item actual de Propuesta
					//					PolizaRiesgoBC oItem = (PolizaRiesgoBC) State["Item"];
					//					
					//					// Instancia la cobertura a quitar
					//					PolizaRiesgoCoberturaBC oCoberturaItem = (PolizaRiesgoCoberturaBC)
					//						oItem.oCoberturas[index];
					//
					//					// Agrega la Cobertura de vuelta al producto
					//					ProductoSeccionCoberturaBC oCoberturaDisponible = new ProductoSeccionCoberturaBC();
					//					oCoberturaDisponible.CoberturaID = oCoberturaItem.CoberturaID;
					//					oCoberturaDisponible.Read();
					//
					//					oItem.oParent.oProducto.oCoberturasAdicionaleS.Add(oCoberturaDisponible);
				}
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
		}

		public void ActualizarCoberturaSeleccionada(CoberturasUIE uieCobertura)
		{
			try
			{
				string sTipoItem = (string)State["TipoItem"];
				if (sTipoItem == "cotizacion")
				{
					// Obtener el item actual de Cotizacion
					ItemCotizacionBC oItem = (ItemCotizacionBC) State["Item"];

					ItemCotizacionCoberturaBC oCoberturaItem = (ItemCotizacionCoberturaBC)
						oItem.oItemCoberturaS[int.Parse(uieCobertura.txtIdCobertura)];
					oCoberturaItem.SumaAsegurada = float.Parse(uieCobertura.txtSumaAsegurada,(CultureInfo)State["Cultura"]);
					oCoberturaItem.Tasa = float.Parse(uieCobertura.txtTasa,(CultureInfo)State["Cultura"]);
					//					oCoberturaItem.PrimaNeta = float.Parse(uieCobertura.txtPrimaNeta,(CultureInfo)State["Cultura"]);
					oCoberturaItem.oDeducible.DeducibleID = int.Parse(uieCobertura.ddlDeducible);
				}
				else
				{
					//					// Obtener el item actual de Propuesta
					//					PropuestaRiesgoBC oItem = (PropuestaRiesgoBC) State["Item"];
					//					
					//					PropuestaRiesgoCoberturaBC oCoberturaItem = (PropuestaRiesgoCoberturaBC)
					//						oItem.oCoberturas[int.Parse(uieCobertura.txtIdCobertura)];
					//					oCoberturaItem.SumaAsegurada = float.Parse(uieCobertura.txtSumaAsegurada,(CultureInfo)State["Cultura"]);
					//					oCoberturaItem.Tasa = float.Parse(uieCobertura.txtTasa,(CultureInfo)State["Cultura"]);
					//					oCoberturaItem.PrimaNeta = float.Parse(uieCobertura.txtPrimaNeta,(CultureInfo)State["Cultura"]);
					//					oCoberturaItem.oDeducible.DeducibleID = int.Parse(uieCobertura.ddlDeducible);
				}
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
		}

		public CoberturasUIE EditarCoberturaSeleccionada(CoberturasUIE uieCoberturas, int indexCobertura)
		{
			try
			{
				string sTipoItem = (string)State["TipoItem"];
				if (sTipoItem == "cotizacion")
				{
					// Obtener el item actual de Cotizacion
					ItemCotizacionBC oItem = (ItemCotizacionBC) State["Item"];

					ItemCotizacionCoberturaBC oCoberturaItem = (ItemCotizacionCoberturaBC)
						oItem.oItemCoberturaS[indexCobertura];

					uieCoberturas.txtIdCobertura = indexCobertura.ToString();
					//Se quitan los puntos
					uieCoberturas.txtSumaAsegurada = oCoberturaItem.SumaAsegurada.ToString("N",(CultureInfo)State["Cultura"]).Replace((string)State["GroupSeparator"],"");
					uieCoberturas.txtTasa  = oCoberturaItem.Tasa.ToString("N",(CultureInfo)State["Cultura"]).Replace((string)State["GroupSeparator"],"");
					uieCoberturas.txtPrimaNeta =oCoberturaItem.PrimaNeta.ToString("N",(CultureInfo)State["Cultura"]).Replace((string)State["GroupSeparator"],"");
				}
				else
				{
					//					// Obtener el item actual de Propuesta
					//					PropuestaRiesgoBC oItem = (PropuestaRiesgoBC) State["Item"];
					//					
					//					PropuestaRiesgoCoberturaBC oCoberturaItem = (PropuestaRiesgoCoberturaBC)
					//						oItem.oCoberturas[indexCobertura];
					//
					//					uieCoberturas.txtIdCobertura = indexCobertura.ToString();
					//					uieCoberturas.txtSumaAsegurada = oCoberturaItem.SumaAsegurada.ToString("N",(CultureInfo)State["Cultura"]).Replace((string)State["GroupSeparator"],"");
					//					uieCoberturas.txtTasa = oCoberturaItem.Tasa.ToString("N",(CultureInfo)State["Cultura"]).Replace((string)State["GroupSeparator"],"");
					//					uieCoberturas.txtPrimaNeta = oCoberturaItem.PrimaNeta.ToString("N",(CultureInfo)State["Cultura"]).Replace((string)State["GroupSeparator"],"");
					//					uieCoberturas.ddlDeducible = oCoberturaItem.oDeducible.DeducibleID.ToString();
				}				
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}

			return uieCoberturas;
		}

		public System.Data.DataView GetDeduciblesDeCobertura(int indexCobertura)
		{
			System.Data.DataView dv = new DataView();
			try
			{
				string sTipoItem = (string)State["TipoItem"];
				if (sTipoItem == "cotizacion")
				{
					// Obtener el item actual de Cotizacion
					ItemCotizacionBC oItem = (ItemCotizacionBC) State["Item"];

					ItemCotizacionCoberturaBC oCoberturaItem = (ItemCotizacionCoberturaBC)
						oItem.oItemCoberturaS[indexCobertura];

					dv = (System.Data.DataView)oCoberturaItem.oDeducibleS.GetDataView();
				}
				else
				{
					//					// Obtener el item actual de Propuesta
					//					PropuestaRiesgoBC oItem = (PropuestaRiesgoBC) State["Item"];
					//					
					//					PropuestaRiesgoCoberturaBC oCoberturaItem = (PropuestaRiesgoCoberturaBC)
					//						oItem.oCoberturas[indexCobertura];
					//
					//					dv = (System.Data.DataView)oCoberturaItem.oDeducibleS.GetDataView();
				}	
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
			return dv;
		}
		#endregion

		#region Métodos de soporte para vista Póliza

		public string CambiarAgente(string AgenteID)
		{
			
			try
			{
				// Obtener la propuesta actual
				PolizaBC oPoliza = (PolizaBC) State["Poliza"];
				oPoliza.oAgente.Identificacion = AgenteID;
				oPoliza.oAgente.Read();				
				
				float porcentaje = oPoliza.GetPorcentajeComision(eeRolesCatalog.eAgente) * 100;
				return porcentaje.ToString("N",CultureFormat.Cultura);
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
			
		}


		public PolizaUIE DesplegarPoliza()
		{
			PolizaUIE uie = new PolizaUIE();
			try
			{
				// Elimina la Cotizacion desde el State (Si es que existe)
				if (State.Contains("Cotizacion"))
					State.Remove("Cotizacion");

				if (State["PolizaGrabada"] == null)
					State["PolizaGrabada"] = true;

				// Obtener la Poliza desde el Sate
				PolizaBC oPoliza = (PolizaBC) State["Poliza"];

				uie.DatosContratante = Utilities.GetPersona(oPoliza.oContratante);

				//uie.idInicioVigencia = oPoliza.InicioVigencia;
				//uie.idTerminoVigencia = oPoliza.FinVigencia;
				/****Solo creado para satisfacer momentaneamente la necesidad de cambio por parte de ANS, posteriormente debe ser eliminado*****/
				/*Las fechas de Vigencia del Item pasan a ser las Fechas de Vigencia de la poliza*/
				/*************************************************************************/
				uie.idInicioVigencia = ((PolizaRiesgoBC)oPoliza.oRiesgoS[0]).InicioVigencia;
				uie.idTerminoVigencia = ((PolizaRiesgoBC)oPoliza.oRiesgoS[0]).FinVigencia;
				/*************************************************************************/
				/*************************************************************************/

				uie.lblFechaPoliza = oPoliza.Creacion.ToString("d",(CultureInfo)State["Cultura"]);
				uie.txtCompañia = oPoliza.oCompania.NombreLargo;
				uie.txtMinuta = oPoliza.Minuta;

				
				//	float comisionAgente = oPoliza.GetMontoComision(eeRolesCatalog.eAgente);
				float comisionAgente = oPoliza.oAgente.PorcentajeComision;
				//if(comisionAgente > 0f)
				uie.txtPorcentajeComisionAgente = comisionAgente.ToString("N",(CultureInfo)State["Cultura"]);
				//uie.txtMontoComisionAgente = comisionAgente.ToString("N",(CultureInfo)State["Cultura"]);
				//uie.txtPorcentajeComisionAgente = ((float)(oPoliza.GetPorcentajeComision(eeRolesCatalog.eAgente)*100)).ToString("N",(CultureInfo)State["Cultura"]);

				uie.txtMontoComisionCorredor = oPoliza.GetMontoComision(eeRolesCatalog.eCorredor).ToString("N",(CultureInfo)State["Cultura"]);
				uie.txtPorcentajeComisioCorredor = ((float)(oPoliza.GetPorcentajeComision(eeRolesCatalog.eCorredor)*100)).ToString("N",(CultureInfo)State["Cultura"]);

				uie.dgListaItems = (DataView)oPoliza.oRiesgoS.GetDataView();

				uie.txtPrimaBruta = oPoliza.PrimaBruta.ToString("N",(CultureInfo)State["Cultura"]);
				uie.txtPrimaNeta = oPoliza.PrimaNeta.ToString("N",(CultureInfo)State["Cultura"]);
				uie.txtIVA = oPoliza.IVA.ToString("N",(CultureInfo)State["Cultura"]);
				uie.txtPolizaMadre = oPoliza.PolizaMadre;
				uie.txtCertificado = oPoliza.Certificado;
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
			return uie;
		}

		public void ActualizarPoliza(PolizaUIE uie)
		{
			try
			{
				// Instanciar la Póliza
				PolizaBC oPoliza = (PolizaBC) State["Poliza"];

				oPoliza.oMoneda.Id = oPoliza.oProducto.oMoneda.Id;
				oPoliza.oPlanPago.oMoneda = oPoliza.oMoneda;
				Utilities.SetPersona(uie.DatosContratante, oPoliza.oContratante, (string) State["CorredorID"]);
				oPoliza.InicioVigencia = uie.idInicioVigencia;
				oPoliza.FinVigencia = uie.idTerminoVigencia;
				oPoliza.Minuta = uie.txtMinuta;
				oPoliza.oAgente.PorcentajeComision = float.Parse(uie.txtPorcentajeComisionAgente,(CultureInfo)State["Cultura"]);
				//oPoliza.oCorredor.PorcentajeComision = float.Parse(uie.txtPorcentajeComisioCorredor, (CultureInfo)State["Cultura"]);
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
		}

		public void InstanciarItemPoliza(int index)
		{
			try
			{
				// Obtener la propuesta actual
				PolizaBC oPoliza = (PolizaBC) State["Poliza"];

				if (State.Contains("Item"))	State.Remove("Item");
				PolizaRiesgoBC oItem = (PolizaRiesgoBC) oPoliza.oRiesgoS[index];
				State["Item"] = oItem;
				if (State.Contains("TipoItem"))	State.Remove("TipoItem");
				State["TipoItem"] = "poliza";

				if (oPoliza.oContratante.Identificacion == oItem.oAsegurado.Identificacion)
				{
					oItem.oAsegurado.oTipoIdentificacion.Id = oPoliza.oContratante.oTipoIdentificacion.Id;
					oItem.oAsegurado.Nombres = oPoliza.oContratante.Nombres;
					oItem.oAsegurado.ApellidoMaterno = oPoliza.oContratante.ApellidoMaterno;
					oItem.oAsegurado.ApellidoPaterno = oPoliza.oContratante.ApellidoPaterno;
					oItem.oAsegurado.RazonSocial = oPoliza.oContratante.RazonSocial;
					
					oItem.oAsegurado.oDireccioneS.Clear();
					foreach(PersonaDireccionBC oDireccion in oPoliza.oContratante.oDireccioneS)
					{
						oItem.oAsegurado.oDireccioneS.Add(oDireccion);
					}
					//oItem.oAsegurado.oDireccioneS = oPoliza.oContratante.oDireccioneS;
					oItem.oAsegurado.oContactoS.Clear();
					foreach(PersonaContactoBC oContacto in oPoliza.oContratante.oContactoS)
					{
						oItem.oAsegurado.oContactoS.Add(oContacto);
					}
					//oItem.oAsegurado.oContactoS = oPoliza.oContratante.oContactoS;

					//oItem.oAsegurado = oPoliza.oContratante;
					//oItem.oAsegurado.eRolCatalog = eeRolesCatalog.eAsegurado;
				}
				GC.Collect();
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
		}

		public void EliminarItemPoliza(int index)
		{
			try
			{
				// Instanciar la Póliza
				PolizaBC oPoliza = (PolizaBC) State["Poliza"];
				
				PolizaRiesgoBC oRiesgo = (PolizaRiesgoBC) oPoliza.oRiesgoS[index];
				oRiesgo.ForDelete = true;
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
		}
		
		public void InstanciarPlanDePago()
		{
			try
			{
				// Obtener la Póliza actual
				PolizaBC oPoliza = (PolizaBC) State["Poliza"];
				
				if (State.Contains("PlanDePago"))	State.Remove("PlanDePago");
				State["PlanDePago"] = oPoliza.oPlanPago;

				if (State.Contains("Producto"))	State.Remove("Producto");
				State["Producto"] = oPoliza.oProducto;

				if (State.Contains("CompañiaID"))	State.Remove("CompañiaID");
				State["CompañiaID"] = oPoliza.oCompania.Id;

				if (State.Contains("PrimaNetaTarifa"))	State.Remove("PrimaNetaTarifa");
				State["PrimaNetaTarifa"] = oPoliza.PrimaNeta;

				if (State.Contains("DescuentoRecargo"))	State.Remove("DescuentoRecargo");
				State["DescuentoRecargo"] = 0f;
				
				if (State.Contains("PrimaNeta"))	State.Remove("PrimaNeta");
				State["PrimaNeta"] = oPoliza.PrimaNetaTotal;

				if (State.Contains("IVA"))	State.Remove("IVA");
				State["IVA"] = oPoliza.IVATotal;

				if (State.Contains("MontoAPagar"))	State.Remove("MontoAPagar");
				State["MontoAPagar"] = oPoliza.PrimaBrutaTotal;

				if (State.Contains("InicioVigencia"))	State.Remove("InicioVigencia");
				State["InicioVigencia"] = oPoliza.InicioVigencia;

				if (State.Contains("FinVigencia"))	State.Remove("FinVigencia");
				State["FinVigencia"] = oPoliza.FinVigencia;

				GC.Collect();
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
		}

		
		public void InstanciarRiesgo(int index)
		{
			try
			{
				// Obtener la Póliza actual
				PolizaBC oPoliza = (PolizaBC) State["Poliza"];

				State["Item"] = (PolizaRiesgoBC) oPoliza.oRiesgoS[index];
				State["TipoItem"] = "poliza";
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
		}

		public string GrabarPoliza(string username)
		{
			string sFolio = "";
			try
			{
				// Instanciar la Póliza
				PolizaBC oPoliza = (PolizaBC) State["Poliza"];
				// Sincroniza los datos del contratante con los asegurados
				foreach(PolizaRiesgoBC oItem in oPoliza.oRiesgoS)
				{
					if (oPoliza.oContratante.Identificacion == oItem.oAsegurado.Identificacion)
					{
						oItem.oAsegurado.oTipoIdentificacion.Id = oPoliza.oContratante.oTipoIdentificacion.Id;
						oItem.oAsegurado.Nombres = oPoliza.oContratante.Nombres;
						oItem.oAsegurado.ApellidoMaterno = oPoliza.oContratante.ApellidoMaterno;
						oItem.oAsegurado.ApellidoPaterno = oPoliza.oContratante.ApellidoPaterno;
						oItem.oAsegurado.RazonSocial = oPoliza.oContratante.RazonSocial;
						//oItem.oAsegurado.oDireccioneS = oPoliza.oContratante.oDireccioneS;
						//oItem.oAsegurado.oContactoS = oPoliza.oContratante.oContactoS;
						oItem.oAsegurado.oDireccioneS.Clear();
						foreach(PersonaDireccionBC oDireccion in oPoliza.oContratante.oDireccioneS)
						{
							oItem.oAsegurado.oDireccioneS.Add(oDireccion);
						}						
						oItem.oAsegurado.oContactoS.Clear();
						foreach(PersonaContactoBC oContacto in oPoliza.oContratante.oContactoS)
						{
							oItem.oAsegurado.oContactoS.Add(oContacto);
						}

						oItem.oAsegurado.LlenarPersistente();
						oPoliza.oContratante.LlenarPersistente();

						//						oItem.oAsegurado = oPoliza.oContratante;
						//						oItem.oAsegurado.eRolCatalog = eeRolesCatalog.eAsegurado;
						//						oPoliza.oContratante.eRolCatalog = eeRolesCatalog.eContratante;
					}
					if(oItem.oBeneficiarios.Count > 0)
					{
						if (((PersonaBC)oItem.oBeneficiarios[0]).Identificacion == oItem.oAsegurado.Identificacion)
						{
							((PersonaBC)oItem.oBeneficiarios[0]).oTipoIdentificacion.Id= oItem.oAsegurado.oTipoIdentificacion.Id;
							((PersonaBC)oItem.oBeneficiarios[0]).oTipoPersonalidadJuridica.Id = oItem.oAsegurado.oTipoPersonalidadJuridica.Id;
							((PersonaBC)oItem.oBeneficiarios[0]).Nombres= oItem.oAsegurado.Nombres;
							((PersonaBC)oItem.oBeneficiarios[0]).ApellidoMaterno = oItem.oAsegurado.ApellidoMaterno;
							((PersonaBC)oItem.oBeneficiarios[0]).ApellidoPaterno = oItem.oAsegurado.ApellidoPaterno;
							((PersonaBC)oItem.oBeneficiarios[0]).RazonSocial = oItem.oAsegurado.RazonSocial;
							((PersonaBC)oItem.oBeneficiarios[0]).Nacimiento = oItem.oAsegurado.Nacimiento;
							((PersonaBC)oItem.oBeneficiarios[0]).LlenarPersistente();
						}
					}	
					else
					{
						PersonaBC oBeneficiario = new PersonaBC(eeRolesCatalog.eBeneficiario);
						oBeneficiario.Identificacion = oItem.oAsegurado.Identificacion;
						oBeneficiario.oTipoIdentificacion.Id= oItem.oAsegurado.oTipoIdentificacion.Id;
						oBeneficiario.Nombres= oItem.oAsegurado.Nombres;
						oBeneficiario.ApellidoMaterno = oItem.oAsegurado.ApellidoMaterno;
						oBeneficiario.ApellidoPaterno = oItem.oAsegurado.ApellidoPaterno;
						oBeneficiario.RazonSocial = oItem.oAsegurado.RazonSocial;
						oItem.oBeneficiarios.Add(oBeneficiario);
						((PersonaBC)oItem.oBeneficiarios[0]).LlenarPersistente();
					}
					#region Validación clausula inalterabilidad planes especiales inter
					if(oPoliza.oProducto.ProductoID == "00000000-0000-0000-0000-000000000250" ||
						oPoliza.oProducto.ProductoID == "00000000-0000-0000-0000-000000000251" ||
						oPoliza.oProducto.ProductoID == "00000000-0000-0000-0000-000000000252" ||
						oPoliza.oProducto.ProductoID == "00000000-0000-0000-0000-000000000253" ||
						oPoliza.oProducto.ProductoID == "00000000-0000-0000-0000-000000000254" ||
						oPoliza.oProducto.ProductoID == "00000000-0000-0000-0000-000000000255" ||
						oPoliza.oProducto.ProductoID == "00000000-0000-0000-0000-000000000256")
					{
						if(oItem.oBeneficiarios.Count > 0)
						{				
							bool existe = RutBancos.getExisteRutBanco(((PersonaBC)oItem.oBeneficiarios[0]).Identificacion);
							//100 = Contado
							if(existe == true && oPoliza.oPlanPago.oFormaPago.Id != 100)
								throw new Exception("Para hacer efectiva la inclusión de Cláusula de Inalterabilidad, debe seleccionar forma de pago Contado, de lo contrario debe modificar el beneficiario.");
						}
					}
					#endregion

					#region Validación clausula inalterabilidad planes  rsa
					if(oPoliza.oProducto.ProductoID == "00000000-0000-0000-0000-000000000260" ||
						oPoliza.oProducto.ProductoID == "00000000-0000-0000-0000-000000000261")
					{
						if(oItem.oBeneficiarios.Count > 0)
						{				
							bool existe = RutBancos.getExisteRutBanco(((PersonaBC)oItem.oBeneficiarios[0]).Identificacion);
							//100 = Contado
							if(existe == true && oPoliza.oPlanPago.oFormaPago.Id != 100)
								throw new Exception("Para hacer efectiva la inclusión de Cláusula de Inalterabilidad, debe seleccionar forma de pago Contado, de lo contrario debe modificar el beneficiario.");
						}
					}
					#endregion
					#region Validación clausula inalterabilidad planes  rsa
					if(oPoliza.oProducto.ProductoID == "00000000-0000-0000-0000-000000000263" ||
						oPoliza.oProducto.ProductoID == "00000000-0000-0000-0000-000000000264" ||
						oPoliza.oProducto.ProductoID == "00000000-0000-0000-0000-000000000265")
					{
						if(oItem.oBeneficiarios.Count > 0)
						{				
							bool existe = RutBancos.getExisteRutBanco(((PersonaBC)oItem.oBeneficiarios[0]).Identificacion);
							//100 = Contado
							if(existe == true && oPoliza.oPlanPago.oFormaPago.Id != 100)
								throw new Exception("Para hacer efectiva la inclusión de Cláusula de Inalterabilidad, debe seleccionar forma de pago Contado, de lo contrario debe modificar el beneficiario.");
						}
					}
					#endregion
					#region Validación clausula inaltebilidad planes BCI
					if(oPoliza.oProducto.ProductoID == "00000000-0000-0000-0000-000000000266" || oPoliza.oProducto.ProductoID == "00000000-0000-0000-0000-000000000959" )
					{
						if(oItem.oBeneficiarios.Count > 0)
						{				
							bool existe = RutBancos.getExisteRutBanco(((PersonaBC)oItem.oBeneficiarios[0]).Identificacion);
							//100 = Contado
							if(existe == true && oPoliza.oPlanPago.oFormaPago.Id != 100)
								throw new Exception("Para hacer efectiva la inclusión de Cláusula de Inalterabilidad, debe seleccionar forma de pago Contado, de lo contrario debe modificar el beneficiario.");
						}
					}
					#endregion
										
//					//pyme - condominios
//					if(oPoliza.oProducto.oAgrupacion.Id == 200
//						&& oPoliza.oProducto.CanalID == 0				
//						)
//					{
//						DateTime Digitacion = new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.Day);						
//						DateTime IVigencia = new DateTime(oItem.InicioVigencia.Year,oItem.InicioVigencia.Month,oItem.InicioVigencia.Day);
//						int maxDiaVigencia = 45;
//
//						DateTime MaxVigencia = 	Digitacion.AddDays(maxDiaVigencia);
//						if(IVigencia > MaxVigencia )
//							throw new Exception("La vigencia futura máxima es de "+ maxDiaVigencia + " días.");
//					}
				
				}

				

				if(oPoliza.UserName.Trim()=="")
					oPoliza.UserName = username;		
				oPoliza.Create();
				State["PolizaGrabada"] = true;
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
			return sFolio;
		}

		public bool PolizaValidaParaEmitir()
		{
			bool returnvalue = true;
			try
			{
				string mensaje = "";
				returnvalue = this.ValidaPoliza(ref mensaje);
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
			return returnvalue;
		}

		public string Emitir(bool bCorredor, bool bHabilitadoInter)
		{
			string mensaje = "";
			try
			{
				// Instanciar la Póliza
				PolizaBC oPoliza = (PolizaBC) State["Poliza"];

				
				//Usuario Corredor
				if(bCorredor)
				{
					//si cumple con los siguientes requisitos:
					/* es de emision automatica
					 * Oficina: 
					 *	Edificio < 6000; Contenido < 2000; Mercaderias < 2000
					 * Comercio e Industria:
					 *	Edificio < 5000; Contenido < 1000; Mercaderias < 1000
					 * 
					 * */

					/*
					 * TODO:	esto es solo para royal, incorporar requerimentos interamericana
					 *			sacar el valor de emision automatica de la tabla nueva
					 * */


					MateriaPropiedadBC oProp = (MateriaPropiedadBC)((PolizaRiesgoBC)oPoliza.oRiesgoS[0]).oMateria;
					ProductoCompaniaExclusionBC oExclucion = new ProductoCompaniaExclusionBC();
					oExclucion.CompaniaID = oPoliza.oCompania.Id;
					oExclucion.ProductoID = oPoliza.oProducto.ProductoID;
					oExclucion.Version = oPoliza.oProducto.Version;
					oExclucion.oActividadComercio.Id = oProp.oActividadPropiedad.Id;
					oExclucion.Read();


					if(oPoliza.oCompania.Id == 16)
					{
						//Ini - FG022
						if (oPoliza.oProducto.ProductoID.Replace("{","").Replace("}","") =="00000000-0000-0000-0000-000000000263"  || 
							oPoliza.oProducto.ProductoID.Replace("{","").Replace("}","") =="00000000-0000-0000-0000-000000000264"  || 
							oPoliza.oProducto.ProductoID.Replace("{","").Replace("}","") =="00000000-0000-0000-0000-000000000265")
						{
							if(oProp.RiesgoBordeCostero == true || oProp.RiesgoBordeRio == true)
							{
								mensaje = "-1";
								this.State["Imprimir"] = false;		
								return mensaje;
							}
						}
						//Fin - FG022
						//Inicio Req 3547
						if (oPoliza.oProducto.ProductoID.Replace("{","").Replace("}","") =="00000000-0000-0000-0000-000000000266" )
						{
							float montoSiniestro = 0;
							SisgenBC oSisgen13 = new SisgenBC();
							DataTable dt = oSisgen13.WSGetSiniestralidadPropiedades("16",((PolizaRiesgoBC)oPoliza.oRiesgoS[0]).oAsegurado.Identificacion);
							if(dt.Rows.Count > 0)
							{	
								montoSiniestro = float.Parse(dt.Rows[0]["Monto"].ToString());
								float montoMitad = montoSiniestro/2;
								float montoPrima = 0.5f*(oPoliza.PrimaNeta);
								float montoPrima2= 0.7f*(oPoliza.PrimaNeta);
								if(montoMitad > montoPrima && montoMitad < montoPrima2)
								{
									mensaje = "Se informa que ante una eventual emisión de pólizas del riesgo cotizado, este quedará sujeto a evaluación";
									this.State["Imprimir"] = false;	
								}
							}				
						}
						//Fin Req 3547
						if( ((PolizaRiesgoBC)oPoliza.oRiesgoS[0]).Minuta.Trim() == "" 
							&&
							oExclucion.TipoExclusion == 2 //Estado de emision automatica
							&&
							(oProp.ValorEdificio + oProp.ValorContenido + oProp.MontoEquiposElectronicos + oProp.MontoMaquinarias + oProp.MontoMercaderias + oProp.MontoPxP <= 80000f)
							&&
							(oProp.oConstruccionMuro.Id ==1
							|| oProp.oConstruccionMuro.Id ==2
							|| oProp.oConstruccionMuro.Id ==3
							|| oProp.oConstruccionMuro.Id ==4
							|| oProp.oConstruccionMuro.Id ==5
							|| oProp.oConstruccionMuro.Id ==6
							|| oProp.oConstruccionMuro.Id ==7)
							&&
							oProp.oRegion.Id != 5
							&&
							oPoliza.oProducto.ProductoID.Replace("{","").Replace("}","") !="00000000-0000-0000-0000-000000000266" 
							)
						 
						{
							oPoliza.Emitir();

							//							if(((MateriaPropiedadBC)((PolizaRiesgoBC)oPoliza.oRiesgoS[0]).oMateria).oFormaAseguramiento.Id == 3)
							//								this.State["Renovando"] = true;
							//							else
							//								this.State["Renovando"] = null;
							//
							//							if(this.State["Renovando"] != null)
							//							{
							//								if((bool)this.State["Renovando"] == true )
							//									RenovacionREN.CambiaEstadoRenovacionDocumentoPadre(oPoliza.DocumentoID, BusinessComponent.eeEstadoRenovacion.eRenovado);
							//							}

							
							//Si la póliza fue renovada a través del proceso de renovación
							if(oPoliza.Recibida)
							{
								//Si viene del módulo nuevo se renovación entonces 
								if(State["ParametrosRenovando"] != null)
								{
									ParametrosRecotizarPoliza parametros = (ParametrosRecotizarPoliza)State["ParametrosRenovando"];
									/*Juan , Comentado Para  renovaciones*/
									//RenovacionREN.Cambia_Version_Propuesta_Renovacion(parametros.DocumentoID, parametros.DocumentoAlternativa);
									RenovacionREN.Cambia_Version_Propuesta_Renovacion(parametros.DocumentoID, oPoliza.DocumentoID);

									RenovacionREN.CambiaEstadoRenovacionDocumentoPadre(oPoliza.DocumentoID, BusinessComponent.eeEstadoRenovacion.eRenovado);
							
									RenovacionREN.Update_Detalle_Renovacion( oPoliza.DocumentoID, oPoliza.PolizaMadre, oPoliza.Certificado );

									//Ini:Código: JC019
									int CompaniaNoCotiza =-1;
									if(System.Web.HttpContext.Current.Session["CompaniaNoCotiza"]!= null)
									{
										CompaniaNoCotiza = int.Parse(System.Web.HttpContext.Current.Session["CompaniaNoCotiza"].ToString());

										string PolizaAnterior = string.Empty;
										int CompaniaAnterior = -1;
										string DocumentoIdNew = string.Empty;
										string PolizaNueva = string.Empty;

										PolizaAnterior = ((PolizaRiesgoBC) oPoliza.oRiesgoS[0]).PolizaAnterior;
										CompaniaAnterior = ((PolizaRiesgoBC) oPoliza.oRiesgoS[0]).oCompaniaAnterior.Id;
										DocumentoIdNew = oPoliza.DocumentoID;
										PolizaNueva = oPoliza.PolizaMadre;

										RenovacionREN.ActualizarPolizasMarcadasComoNoRenovarPorCompania(PolizaAnterior,CompaniaAnterior,DocumentoIdNew,PolizaNueva);
										System.Web.HttpContext.Current.Session.Remove("CompaniaNoCotiza");
									}
									//Fin:Código: JC019
						
								}
								else
								{
									RenovacionREN.CambiaEstadoRenovacionDocumentoPadre(oPoliza.DocumentoID, BusinessComponent.eeEstadoRenovacion.eRenovado);
								}
							}

						}
						else if(((PolizaRiesgoBC)oPoliza.oRiesgoS[0]).Minuta.Trim() == "" 
							&&
							oExclucion.TipoExclusion == 2 //Estado de emision automatica
							&&
							(oProp.oConstruccionMuro.Id ==1
							|| oProp.oConstruccionMuro.Id ==2
							|| oProp.oConstruccionMuro.Id ==3
							|| oProp.oConstruccionMuro.Id ==4
							|| oProp.oConstruccionMuro.Id ==5
							|| oProp.oConstruccionMuro.Id ==6
							|| oProp.oConstruccionMuro.Id ==7)
							&& //CondominioBCI 
							oPoliza.oProducto.ProductoID.Replace("{","").Replace("}","") =="00000000-0000-0000-0000-000000000266" 
							)
						{
							
							oPoliza.Emitir();
						}
						else
						{
							mensaje = "Por las características del riesgo ingresado, se ha generado una solicitud de póliza la cual ha sido enviada a la compañía para su evaluación y posterior emisión";
							this.State["Imprimir"] = false;						
						}

						//inspeccion de riesgo al ser de 5ta region
						if(((MateriaPropiedadBC)((PolizaRiesgoBC)oPoliza.oRiesgoS[0]).oMateria).oRegion.Id == 5)
						{
							mensaje = "Por las características del riesgo ingresado, se ha generado una solicitud de póliza la cual ha sido enviada a la compañía para su inspección, evaluación y posterior emisión";
							this.State["Imprimir"] = false;	
						}
					}
						
					else if(oPoliza.oCompania.Id == 17)
					{
						//Ini -- VS005
						/*
						if( ((PolizaRiesgoBC)oPoliza.oRiesgoS[0]).Minuta.Trim() == "" 
							&&
							(oProp.ValorEdificio + oProp.ValorContenido + oProp.MontoMercaderias +
							oProp.MejoraInmueble + oProp.MontoMaquinarias <= 80000f)												
							)
						{
							oPoliza.Emitir();
						}
						else
						{
							mensaje = "Por las características del riesgo ingresado, se ha generado una solicitud de póliza la cual ha sido enviada a la compañía para su evaluación y posterior emisión";
							this.State["Imprimir"] = false;						
						}*/
						//Fin -- VS005

						//Ini -- VS006
						DALC.LectorDatos oLector = new Hypernet.ANT.DALC.LectorDatos();
						SqlParameter pProductoid = new SqlParameter("@PRODUCTOID", SqlDbType.UniqueIdentifier);
						pProductoid.Value = new Guid(oPoliza.oProducto.ProductoID);
						oLector.Parametros.Add(pProductoid);
						DataTable dtParametros = oLector.EjecutarProcedimientoAlmacenado("PROC_GET_ProductoParametros");	


						if (oExclucion.TipoExclusion == 3)
						{						 
							mensaje = "Por las características del riesgo ingresado, se ha generado una solicitud de póliza la cual ha sido enviada a la compañía para su evaluación y posterior emisión";
							this.State["Imprimir"] = false;			
						}
						else if(oExclucion.TipoExclusion == 2)
						{
							//INICIO - WS010
							if (oPoliza.oProducto.ProductoID == "00000000-0000-0000-0000-000000000959")
							{ 
							//Código: JC013
								if(((PolizaRiesgoBC)oPoliza.oRiesgoS[0]).Minuta.Trim() == "" )
//									(oProp.oConstruccionMuro.Id ==1 || oProp.oConstruccionMuro.Id ==2 || oProp.oConstruccionMuro.Id ==3 || oProp.oConstruccionMuro.Id ==4
//									|| oProp.oConstruccionMuro.Id ==5 || oProp.oConstruccionMuro.Id ==6 || oProp.oConstruccionMuro.Id ==7)
								{
							
									oPoliza.Emitir();
								}
								else
								{
									mensaje = "Por las características del riesgo ingresado, se ha generado una solicitud de póliza la cual ha sido enviada a la compañía para su evaluación y posterior emisión";
									this.State["Imprimir"] = false;						
								}
								//oPoliza.Emitir();
							}
							else
							{
							//FIN - WS010
								if( ((PolizaRiesgoBC)oPoliza.oRiesgoS[0]).Minuta.Trim() == "" 
									&&
									(oProp.ValorEdificio + oProp.ValorContenido + oProp.MontoMercaderias +
									oProp.MejoraInmueble + oProp.MontoMaquinarias < ObtenerValorParametro(dtParametros,"MONTOMINIMOEVALUACION"))												
									)
								{
									oPoliza.Emitir();
								}
								else
								{
									mensaje = "Por las características del riesgo ingresado, se ha generado una solicitud de póliza la cual ha sido enviada a la compañía para su evaluación y posterior emisión";
									this.State["Imprimir"] = false;						
								}
							//WS010
							}
						}

						//Fin -- VS005
					}
	
					else if(oPoliza.oCompania.Id == 12)
					{
						if( ((PolizaRiesgoBC)oPoliza.oRiesgoS[0]).Minuta.Trim() == "" 
							//							&&
							//							oExclucion.TipoExclusion == 2 //Estado de emision automatica
							&&
							(oProp.ValorEdificio + oProp.ValorContenido + oProp.MontoMercaderias +
							oProp.MontoEquiposElectronicos + oProp.MontoMaquinarias <= 50000f)//75000f)												
							)
						{
							oPoliza.Emitir();

							//							if(this.State["Renovando"] != null)
							//							{
							//								if((bool)this.State["Renovando"] == true )
							//									RenovacionREN.CambiaEstadoRenovacionDocumentoPadre(oPoliza.DocumentoID, BusinessComponent.eeEstadoRenovacion.eRenovado);
							//							}
							//Si la póliza fue renovada a través del proceso de renovación
							if(oPoliza.Recibida)
							{
								//Ini - FF002
								//Si viene del módulo nuevo se renovación entonces 
								if(State["ParametrosRenovando"] != null)
								{
									ParametrosRecotizarPoliza parametros = (ParametrosRecotizarPoliza)State["ParametrosRenovando"];
									
									RenovacionREN.Cambia_Version_Propuesta_Renovacion(parametros.DocumentoID, oPoliza.DocumentoID);

									RenovacionREN.CambiaEstadoRenovacionDocumentoPadre(oPoliza.DocumentoID, BusinessComponent.eeEstadoRenovacion.eRenovado);
							
									RenovacionREN.Update_Detalle_Renovacion( oPoliza.DocumentoID, oPoliza.PolizaMadre, oPoliza.Certificado );
						
								}
								else
								{
									RenovacionREN.CambiaEstadoRenovacionDocumentoPadre(oPoliza.DocumentoID, BusinessComponent.eeEstadoRenovacion.eRenovado);
								}
								//Fin - FF002
							}
						}
						else
						{
							mensaje = "Por las características del riesgo ingresado, se ha generado una solicitud de póliza la cual ha sido enviada a la compañía para su evaluación y posterior emisión";
							this.State["Imprimir"] = false;						
						}
					}
					else if(oPoliza.oCompania.Id == 7)
					{
						//Si es plan especial
						if(((MateriaPropiedadBC)((PolizaRiesgoBC)(oPoliza.oRiesgoS[0])).oMateria).oOcupacionComercio.Id != 100
							&& ((MateriaPropiedadBC)((PolizaRiesgoBC)(oPoliza.oRiesgoS[0])).oMateria).oOcupacionComercio.Id != 110
							&& ((MateriaPropiedadBC)((PolizaRiesgoBC)(oPoliza.oRiesgoS[0])).oMateria).oOcupacionComercio.Id != 120)
						{
							if( ((PolizaRiesgoBC)oPoliza.oRiesgoS[0]).Minuta.Trim() == "" )
							{
								oPoliza.Emitir();

								//								if(this.State["Renovando"] != null)
								//								{
								//									if((bool)this.State["Renovando"] == true )
								//										RenovacionREN.CambiaEstadoRenovacionDocumentoPadre(oPoliza.DocumentoID, BusinessComponent.eeEstadoRenovacion.eRenovado);
								//								}
								//Si la póliza fue renovada a través del proceso de renovación
								if(oPoliza.Recibida)
								{
									RenovacionREN.CambiaEstadoRenovacionDocumentoPadre(oPoliza.DocumentoID, BusinessComponent.eeEstadoRenovacion.eRenovado);
								}
							}
							else
							{
								mensaje = "Por las características del riesgo ingresado, se ha generado una solicitud de póliza la cual ha sido enviada a la compañía para su evaluación y posterior emisión";
								this.State["Imprimir"] = false;								
							}
						}
						else if(bHabilitadoInter)
						{
							if( ((PolizaRiesgoBC)oPoliza.oRiesgoS[0]).Minuta.Trim() == "" 
								&&
								oExclucion.TipoExclusion == 2 //Estado de emision automatica
								&&
								(oProp.ValorContenido + oProp.ValorEdificio + oProp.MontoMaquinarias + oProp.MontoMercaderias + oProp.MontoEquiposElectronicos ) <= 50000f//Req 3447
								)
							{
								oPoliza.Emitir();

								//								if(this.State["Renovando"] != null)
								//								{
								//									if((bool)this.State["Renovando"] == true )
								//										RenovacionREN.CambiaEstadoRenovacionDocumentoPadre(oPoliza.DocumentoID, BusinessComponent.eeEstadoRenovacion.eRenovado);
								//								}
								//Si la póliza fue renovada a través del proceso de renovación
								if(oPoliza.Recibida)
								{
									RenovacionREN.CambiaEstadoRenovacionDocumentoPadre(oPoliza.DocumentoID, BusinessComponent.eeEstadoRenovacion.eRenovado);
								}
							}
							else
							{
								mensaje = "Por las características del riesgo ingresado, se ha generado una solicitud de póliza la cual ha sido enviada a la compañía para su evaluación y posterior emisión";
								this.State["Imprimir"] = false;						
							}
						}
						else
						{
							mensaje = "Póliza sujeta a evaluación. Contactarse con su ejecutivo";
							this.State["Imprimir"] = false;						
						}
					}
					//ini - RN007
					else if(oPoliza.oCompania.Id == 5)
					{
						DALC.LectorDatos oLector = new Hypernet.ANT.DALC.LectorDatos();
						SqlParameter pProductoid = new SqlParameter("@PRODUCTOID", SqlDbType.UniqueIdentifier);
						pProductoid.Value = new Guid(oPoliza.oProducto.ProductoID);
						oLector.Parametros.Add(pProductoid);
						//DataTable dtParametros = oLector.EjecutarProcedimientoAlmacenado("PROC_GET_metros");	

						float MontoMinimo=0; 

						float MontoTotal =oProp.ValorEdificio + oProp.ValorContenido + oProp.MontoMercaderias +oProp.MontoMaquinarias;

						UtilTarificacion.GetTasaPymeMontoACE(oPoliza.oProducto.ProductoID,oPoliza.oProducto.Version,oPoliza.oCompania.Id,-1,-1,-1,"MONTOMINIMOEVALUACION",MontoTotal, ref MontoMinimo);

						if (oExclucion.TipoExclusion == 3)
						{						 
							mensaje = "Por las características del riesgo ingresado, se ha generado una solicitud de póliza la cual ha sido enviada a la compañía para su evaluación y posterior emisión";
							this.State["Imprimir"] = false;			
						}
						else if(oExclucion.TipoExclusion == 2)
						{
							//WS017
							if( ((PolizaRiesgoBC)oPoliza.oRiesgoS[0]).Minuta.Trim() == "" 	)
							{
								oPoliza.Emitir();
							}
							else
							{
								mensaje = "Por las características del riesgo ingresado, se ha generado una solicitud de póliza la cual ha sido enviada a la compañía para su evaluación y posterior emisión";
								this.State["Imprimir"] = false;						
							}
						}
						//Ini:Código: JC025
						if(oPoliza.oProducto.ProductoID=="00000000-0000-0000-0000-000000000969" && oExclucion.TipoExclusion == 1 )
						{
							oPoliza.Emitir();
						}
						//Fin:Código: JC025

					}

					//fin - RN007

				}
				else
				{
					oPoliza.Emitir();

					if(oPoliza.Recibida)
					{
						RenovacionREN.CambiaEstadoRenovacionDocumentoPadre(oPoliza.DocumentoID, BusinessComponent.eeEstadoRenovacion.eRenovado);
					}
				}				
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
			return mensaje;
		}

	 	/// <summary>
		/// Obtiene valor del parametro "parametro" en la BD
		/// VS006
		/// </summary>
		/// <param name="dt">Conjunto de datos entregado por el procedimiento PROC_GET_ProductoParametros.</param>
		/// <param name="parametro">Parametro seleccionado del conjunto de datos.</param>
		/// <returns>Valor del parametro</returns>
		public float ObtenerValorParametro(DataTable dt, string parametro)
		{
			float valor = 0;
			DataRow[] filas = dt.Select("Parametro = '" + parametro + "'");
			if(filas.Length > 0)
				valor = float.Parse(filas[0]["Valor"].ToString());
			return valor;
		}
		

		public string GetPolizaXML()
		{
			// Obtiene la Cotización desde el State
			PolizaBC oPoliza = (PolizaBC) State["Poliza"];

			return oPoliza.GetXml();
		}

		public void SetEstadoPoliza(int estado)
		{
			try
			{
				// Obtiene la Cotización desde el State
				PolizaBC oPoliza = (PolizaBC) State["Poliza"];

				oPoliza.oEstadoPoliza.Id = estado;
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
		}

		public void SetFechaEmision()
		{
			try
			{
				// Obtiene la Cotización desde el State
				PolizaBC oPoliza = (PolizaBC) State["Poliza"];

				oPoliza.Emision = DateTime.Now;
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
		}

		/// <summary>
		/// DocumentoID de la poliza
		/// </summary>
		public string GetDocumentoID()
		{
			PolizaBC oPoliza = (PolizaBC) State["Poliza"];
			return oPoliza.DocumentoID;		
		}

		//INICIO - WS020
		public void EnviarCorreoCot()
		{
			CotizacionBC oCot = (CotizacionBC) State["Cotizacion"];
				
			ItemCotizacionBC oItem = (ItemCotizacionBC)(oCot.oItemeS[0]);			
			MateriaPropiedadBC oMateria = (MateriaPropiedadBC)((ItemCotizacionBC)(oCot.oItemeS[0])).oMateria;
			StringBuilder sb = new StringBuilder();

			sb.Append("Existe una póliza pendiente para evaluar el producto Condominio ANS, con fecha de emisión el día "+ oCot.Fecha.ToShortDateString() +". ");
			sb.Append("Los datos de la póliza son los siguientes:\n");
			sb.Append("\nNombre Corredor: " + oCot.oCorredor.oPersistente.Nombres 
				+ " " + oCot.oCorredor.oPersistente.ApellidoPaterno + " " + oCot.oCorredor.oPersistente.ApellidoMaterno + " " + oCot.oCorredor.oPersistente.RazonSocial 
				+ "\nRut Corredor: " + oCot.oCorredor.Identificacion + "\n");
			sb.Append("Nombre Contratante: " + oCot.oContratante.oPersistente.Nombres 
				+ " " + oCot.oContratante.oPersistente.ApellidoPaterno + " " + oCot.oContratante.oPersistente.ApellidoMaterno + " " + oCot.oContratante.oPersistente.RazonSocial
				+ "\nRut Contratante: " + oCot.oContratante.Identificacion);
			sb.Append("\nAsegurado: "+ oItem.oAsegurado.Nombres + " " + oItem.oAsegurado.ApellidoPaterno + " " + oItem.oAsegurado.ApellidoMaterno + " " +oItem.oAsegurado.RazonSocial);
			sb.Append("\nTeléfono:" + oItem.oAsegurado.oPersistente.TelefonoParticular + " " + oItem.oAsegurado.oPersistente.TelefonoComercial + " " + oItem.oAsegurado.oPersistente.TelefonoCelular);
			sb.Append("\nDirección Riesgo: " + oMateria.Direccion + "\nComuna: "+ oMateria.oComuna.NombreCorto + "	Región: "+ oMateria.oRegion.NombreCorto + ".\n");
			sb.Append("\nCódigo de Reserva: "+ oMateria.MontoPxP);

			//INICIO - WS021
			string Plan = "";
			
			for (int i=0; i < oItem.oTarifaS.Rows.Count; i++)
			{
				for (int col = 0; col < oItem.oTarifaS.Columns.Count; col++)
				{
					if (oItem.oTarifaS.Columns[col].ColumnName != "Impresion")
					{
						string sTarifa = oItem.oTarifaS.Rows[i][col].ToString();
						if (sTarifa.IndexOf('|') != -1)
						{
							string[] aTarifa = sTarifa.Split('|');
							string deducible = aTarifa[5];
							string deducibleID = aTarifa[6];
							string sprimaBruta = aTarifa[7];
							//INICIO - WS023
							string productoID = aTarifa[3];
							if (productoID == "{00000000-0000-0000-0000-000000000959}")
								if (float.Parse(sprimaBruta) > 0)
							//FIN - WS023
									Plan += "UF " + deducible + ": " + float.Parse(sprimaBruta).ToString("N0",CultureFormat.Cultura) + " \n";
						}
					}
				}
			}
			//FIN - WS021

			sb.Append("\n\nPlan: \n" + Plan);
			sb.Append("\n\nActividad: " + oMateria.oActividadPropiedad.NombreLargo);			
			sb.Append("\nConstrucción Muro: " + oMateria.oConstruccionMuro.NombreLargo);
			sb.Append("\nConstrucción Techo: " + oMateria.oConstruccionTecho.NombreLargo);
			sb.Append("\n\nMontos Asegurados");
			//INICIO - WS023
			sb.Append("\nMonto Bienes y Espacios Comunes: " + oMateria.ValorEdificio.ToString("N0",CultureFormat.Cultura));
			sb.Append("\nMonto en Departamentos: " + oMateria.ValorContenido.ToString("N0",CultureFormat.Cultura));
			sb.Append("\nNúmero de Trabajadores: " + oMateria.NumeroTrabajadores.ToString("N0",CultureFormat.Cultura));
			//FIN - WS023
			sb.Append("\n\nMinuta: " + oItem.Minuta);

				string bodyMail = sb.ToString();
				string correoTo = "";
				XmlDocument CorreosXml = new XmlDocument();
				CorreosXml.Load(FoliacionDALC.RutaXMLCorreos);
				XmlElement root = CorreosXml.DocumentElement;

				XmlNodeList nodoCorreos;
				nodoCorreos = root.SelectNodes("//EmisionPymes/Consorcio/Correos/Correo");
					foreach(XmlNode nodoCorreo in nodoCorreos)
					{
						correoTo = correoTo + "; " + nodoCorreo.Attributes["name"].Value;
					}

				if (correoTo.Length != 0)
					correoTo = correoTo.Substring(1,correoTo.Length - 1);
		
				XmlNode nodoFrom = root.SelectSingleNode("//From");
				string correoFrom = nodoFrom.Attributes["name"].Value;
				XmlNode nodoServidor = root.SelectSingleNode("//Servidor");
				string correoServidor = nodoServidor.Attributes["name"].Value;

				string emailEjecutivo = EjecutivoEmail.getEmail(oCot.oCorredor.CorredorID);
				string asunto = "Solicitud Póliza Condominio";

					       
				MailMessage oMensaje = new MailMessage();
				oMensaje.To = correoTo;
				oMensaje.From = correoFrom;
				oMensaje.Subject = asunto;
				oMensaje.Body = bodyMail;

				XmlNode nodoContrasena = root.SelectSingleNode("//Contrasena");
				string contrasena = nodoContrasena.Attributes["name"].Value;
			
				string ConfigNamespace =  @"http://schemas.microsoft.com/cdo/configuration/";
				oMensaje.Fields.Add(ConfigNamespace + "smtpserver", correoServidor);
				oMensaje.Fields.Add(ConfigNamespace + "smtpserverport", 25);       
				oMensaje.Fields.Add(ConfigNamespace + "sendusing", 2);       
				oMensaje.Fields.Add(ConfigNamespace + "sendusername", correoFrom);
				oMensaje.Fields.Add(ConfigNamespace + "sendpassword", contrasena);
				oMensaje.Fields.Add(ConfigNamespace + "smtpauthenticate", 1) ;

				try
				{
					//SmtpMail.SmtpServer = correoServidor;
					SmtpMail.Send(oMensaje);

					Log.GuardarLog(
						eeTipoLog.eEnvioEmail,
						oCot.UserName,
						"Se Envió Email Condominio a Consorcio, Enviado a: " + correoTo,
						oCot.oCorredor.CorredorID,
						oCot.CotizacionID,
						"",
						"",
						"");
				}
				catch(System.Web.HttpException ehttp)
				{
					Console.WriteLine("{0}", ehttp.Message);

					Log.GuardarLog(
						eeTipoLog.eNoEnvioEmail,
						oCot.UserName,
						"No Envió Email Condominio a Consorcio, Enviado a: " + correoTo,
						oCot.oCorredor.CorredorID,
						oCot.CotizacionID,
						"Error: " + ehttp.Message,
						"",
						"");
				}			
		}
		//FIN - WS020

		public void EnviarCorreo(bool bHabilitadoInter)
		{
			PolizaBC oPoliza = (PolizaBC) State["Poliza"];
			int companiaid = oPoliza.oCompania.Id;
			//3547
			//WS011
			if ((oPoliza.oProducto.ProductoID.Replace("{","").Replace("}","") =="00000000-0000-0000-0000-000000000266" && oPoliza.oCompania.Id == 16) || (oPoliza.oProducto.ProductoID.Replace("{","").Replace("}","") =="00000000-0000-0000-0000-000000000959" && oPoliza.oCompania.Id == 17))
			{	
				PolizaRiesgoBC oRiesgo = (PolizaRiesgoBC)(oPoliza.oRiesgoS[0]);			
				MateriaPropiedadBC oMateria = (MateriaPropiedadBC)((PolizaRiesgoBC)(oPoliza.oRiesgoS[0])).oMateria;
				StringBuilder sb = new StringBuilder();

				sb.Append("Existe una propuesta pendiente para evaluar el producto Condominio ANS, con fecha de emisión el día "+ oPoliza.Emision.ToShortDateString() +". ");
				sb.Append("Los datos de la póliza son los siguientes:\n");
				sb.Append("\nNombre Corredor: " + oPoliza.oCorredor.oPersistente.Nombres 
					+ " " + oPoliza.oCorredor.oPersistente.ApellidoPaterno + " " + oPoliza.oCorredor.oPersistente.ApellidoMaterno + " " + oPoliza.oCorredor.oPersistente.RazonSocial 
					+ "\nRut Corredor: " + oPoliza.oCorredor.Identificacion + "\n");
				sb.Append("Nombre Contratante: " + oPoliza.oContratante.oPersistente.Nombres 
					+ " " + oPoliza.oContratante.oPersistente.ApellidoPaterno + " " + oPoliza.oContratante.oPersistente.ApellidoMaterno + " " + oPoliza.oContratante.oPersistente.RazonSocial
					+ "\nRut Contratante: " + oPoliza.oContratante.Identificacion);
				sb.Append("\nAsegurado: "+ oRiesgo.oAsegurado.Nombres + " " + oRiesgo.oAsegurado.ApellidoPaterno + " " + oRiesgo.oAsegurado.ApellidoMaterno + " " +oRiesgo.oAsegurado.RazonSocial);
				sb.Append("\nTelefono:" + oRiesgo.oAsegurado.oPersistente.TelefonoParticular + " " + oRiesgo.oAsegurado.oPersistente.TelefonoComercial + " " + oRiesgo.oAsegurado.oPersistente.TelefonoCelular);
				sb.Append("\nDireccion Riesgo: " + oMateria.Direccion + "\nComuna: "+ oMateria.oComuna.NombreCorto + "	Region: "+ oMateria.oRegion.NombreCorto + ".\n");

				//Ini - FG026
				if(oPoliza.oCompania.Id == 17)
					sb.Append("\nCodigo de Reserva: "+ oMateria.MontoPxP);
				else if(oPoliza.oCompania.Id == 16)
					sb.Append("\nCodigo de Reserva: "+ oMateria.Ano);
				//Fin - FG026

				sb.Append("\n\nPlan: " + oRiesgo.oDeducible.Texto);
				sb.Append("\n\nActividad: " + oMateria.oActividadPropiedad.NombreLargo);			
				sb.Append("\nConstrucción Muro: " + oMateria.oConstruccionMuro.NombreLargo);
				sb.Append("\nConstrucción Techo: " + oMateria.oConstruccionTecho.NombreLargo);
				sb.Append("\n\nMontos Asegurados");
				sb.Append("\nMonto Bienes y Espacios Comunes: " + oMateria.ValorEdificio.ToString("N",CultureFormat.Cultura));
				sb.Append("\nMonto en Departamentos: " + oMateria.ValorContenido.ToString("N",CultureFormat.Cultura));
				sb.Append("\nNúmero de Trabajadores: " + oMateria.NumeroTrabajadores.ToString("N",CultureFormat.Cultura));
				sb.Append("\n\nMinuta: " + oRiesgo.Minuta);

				string bodyMail = sb.ToString();
				string correoTo = "";
				XmlDocument CorreosXml = new XmlDocument();
				CorreosXml.Load(FoliacionDALC.RutaXMLCorreos);
				XmlElement root = CorreosXml.DocumentElement;

				XmlNodeList nodoCorreos;

				if (oPoliza.oProducto.ProductoID.Replace("{","").Replace("}","") =="00000000-0000-0000-0000-000000000266" && oPoliza.oCompania.Id == 16)//BCI Condominios
				{
					nodoCorreos = root.SelectNodes ("//EmisionCondominio/BCI/Correos/Correo");
					foreach(XmlNode nodoCorreo in nodoCorreos)
					{
						correoTo = correoTo + "; " + nodoCorreo.Attributes["name"].Value;
					}
				}
				//INICIO - WS011
				else if(oPoliza.oCompania.Id == 17) //CONSORCIO
				{
					nodoCorreos = root.SelectNodes("//EmisionPymes/Consorcio/Correos/Correo");
					foreach(XmlNode nodoCorreo in nodoCorreos)
					{
						correoTo = correoTo + "; " + nodoCorreo.Attributes["name"].Value;
					}
				}
				//FIN - WS011

				//correoTo = correoTo.Substring(1,correoTo.Length);
		        //WS011
				if (correoTo.Length != 0)
					correoTo = correoTo.Substring(1,correoTo.Length - 1);
		
				XmlNode nodoFrom = root.SelectSingleNode("//From");
				string correoFrom = nodoFrom.Attributes["name"].Value;
				XmlNode nodoServidor = root.SelectSingleNode("//Servidor");
				string correoServidor = nodoServidor.Attributes["name"].Value;

				string emailEjecutivo = EjecutivoEmail.getEmail(oPoliza.oCorredor.CorredorID);
				string asunto = "Solicitud Póliza Condominio";

				if(EjecutivoEmail.getProduccion() == false)
				{  //pruebas
					asunto = "Prueba (El email del ejecutivo a quien se enviaria sería: " + emailEjecutivo + ")";
					//envia email al ejectutivo y al tester
					correoTo = EjecutivoEmail.getEmailWebConfig();
				}
				else //produccion
					correoTo += ";" + emailEjecutivo;

				//if(oPoliza.oCompania.Id == 16 && oMateria.oRegion.Id == 5)
				//	asunto = asunto + " (INSPECCION)";
			       
				MailMessage oMensaje = new MailMessage();
				oMensaje.To = correoTo;
				oMensaje.From = correoFrom;
				oMensaje.Subject = asunto;
				oMensaje.Body = bodyMail;			

				XmlNode nodoContrasena = root.SelectSingleNode("//Contrasena");
				string contrasena = nodoContrasena.Attributes["name"].Value;
			
				string ConfigNamespace =  @"http://schemas.microsoft.com/cdo/configuration/";
				oMensaje.Fields.Add(ConfigNamespace + "smtpserver", correoServidor);
				oMensaje.Fields.Add(ConfigNamespace + "smtpserverport", 25);       
				oMensaje.Fields.Add(ConfigNamespace + "sendusing", 2);       
				oMensaje.Fields.Add(ConfigNamespace + "sendusername", correoFrom);
				oMensaje.Fields.Add(ConfigNamespace + "sendpassword", contrasena);
				oMensaje.Fields.Add(ConfigNamespace + "smtpauthenticate", 1) ;


				try
				{
					//SmtpMail.SmtpServer = correoServidor;
					SmtpMail.Send(oMensaje);

					Log.GuardarLog(
						eeTipoLog.eEnvioEmail,
						oPoliza.UserName,
						"Se Envió Email Condominio CompaniaID =" + companiaid  + ", Enviado a: " + correoTo,
						oPoliza.oCorredor.CorredorID,
						oPoliza.DocumentoID,
						"",
						"",
						"");
				}
				catch(System.Web.HttpException ehttp)
				{
					Console.WriteLine("{0}", ehttp.Message);

					Log.GuardarLog(
						eeTipoLog.eNoEnvioEmail,
						oPoliza.UserName,
						"No Envió Email Condominio CompaniaID =" + companiaid  + ", Enviado a: " + correoTo,
						oPoliza.oCorredor.CorredorID,
						oPoliza.DocumentoID,
						"Error: " + ehttp.Message,
						"",
						"");
				}
			}//3547
			//Ini - FG027
			else if((companiaid == 17) || (companiaid == 16) ||(companiaid == 12) || ((companiaid == 7) && (bHabilitadoInter)) ||(companiaid == 5))
			{
				//Fin - FG027
				PolizaRiesgoBC oRiesgo = (PolizaRiesgoBC)(oPoliza.oRiesgoS[0]);			
				MateriaPropiedadBC oMateria = (MateriaPropiedadBC)((PolizaRiesgoBC)(oPoliza.oRiesgoS[0])).oMateria;
				//
				StringBuilder sb = new StringBuilder();
				sb.Append("Existe una propuesta pendiente para evaluar el producto Pyme ANS, con fecha de emisión el día "+ oPoliza.Emision.ToShortDateString() +". ");
				sb.Append("Los datos de la póliza son los siguientes:\n");
				sb.Append("\nNombre Corredor: " + oPoliza.oCorredor.oPersistente.Nombres + " " + oPoliza.oCorredor.oPersistente.ApellidoPaterno + " " + oPoliza.oCorredor.oPersistente.ApellidoMaterno + " " + oPoliza.oCorredor.oPersistente.RazonSocial 
					+ "\nRut Corredor: " + oPoliza.oCorredor.Identificacion + "\n");
				sb.Append("Nombre Contratante: " + oPoliza.oContratante.oPersistente.Nombres 
					+ " " + oPoliza.oContratante.oPersistente.ApellidoPaterno + " " + oPoliza.oContratante.oPersistente.ApellidoMaterno + " " + oPoliza.oContratante.oPersistente.RazonSocial
					+ "\nRut Contratante: " + oPoliza.oContratante.Identificacion);
				sb.Append("\nAsegurado: "+ oRiesgo.oAsegurado.Nombres + " " + oRiesgo.oAsegurado.ApellidoPaterno + " " + oRiesgo.oAsegurado.ApellidoMaterno + " " +oRiesgo.oAsegurado.RazonSocial);
				sb.Append("\nTelefono:" + oRiesgo.oAsegurado.oPersistente.TelefonoParticular + " " + oRiesgo.oAsegurado.oPersistente.TelefonoComercial + " " + oRiesgo.oAsegurado.oPersistente.TelefonoCelular);
				sb.Append("\nDireccion Riesgo: " + oMateria.Direccion + "	Comuna: "+ oMateria.oComuna.NombreCorto + "	Region: "+ oMateria.oRegion.NombreCorto + ".\n");
				
				
				if(oPoliza.oCompania.Id == 16 && oMateria.oRegion.Id == 5)
					sb.Append(" (INSPECCION)");

				sb.Append("\n\nPlan: " + oRiesgo.oDeducible.Texto);
				sb.Append("\nOcupación: " + oMateria.oOcupacionComercio.NombreLargo);
				sb.Append("\nActividad: " + oMateria.oActividadPropiedad.NombreLargo);			
				sb.Append("\nConstrucción Muro: " + oMateria.oConstruccionMuro.NombreLargo);
				sb.Append("\nConstrucción Techo: " + oMateria.oConstruccionTecho.NombreLargo);
		
				sb.Append("\n\nMontos Asegurados");
				sb.Append("\nEdificio: " + oMateria.ValorEdificio.ToString("N",CultureFormat.Cultura));
				sb.Append("\nContenido: " + oMateria.ValorContenido.ToString("N",CultureFormat.Cultura));
				sb.Append("\nMercadería: " + oMateria.MontoMercaderias.ToString("N",CultureFormat.Cultura));
				sb.Append("\nEquipo Electrónico: " + oMateria.MontoEquiposElectronicos.ToString("N",CultureFormat.Cultura));
				sb.Append("\nMaquinaria: " + oMateria.MontoMaquinarias.ToString("N",CultureFormat.Cultura));
				sb.Append("\nPerjuicio por Paralización: " + oMateria.MontoPxP.ToString("N",CultureFormat.Cultura)); 
				
				//Coberturas  adicionales
				//				sb.Append("\nResponsabilidad Civil: " + oMateria.MontoRC.ToString("N",CultureFormat.Cultura));
				//				sb.Append("\nCristales: " + oMateria.Cristales.ToString("N",CultureFormat.Cultura));
				//				sb.Append("\nPerjuicio por Paralización: " + oMateria.PeriodoPxP.ToString("N",CultureFormat.Cultura));
				//				sb.Append("\nDinero en Caja de Seguridad: " + oMateria.CajaSeguridad.ToString("N",CultureFormat.Cultura));
				//				sb.Append("\nRemesa de Valores:  " + oMateria.RemesaValores.ToString("N",CultureFormat.Cultura));
				//
				//				if(oMateria.RCAlimentos)
				//					sb.Append("\nRC Alimentos: SI");
				//				else
				//					sb.Append("\nRC Alimentos: NO");
				//
				//				if(companiaid == 7)
				//				{
				//					sb.Append("\nScoring Chartis: ");
				//					sb.Append("\nMuerte e Invalidez Accidental: " + oMateria.MontoMuerte.ToString("N",CultureFormat.Cultura));
				//					sb.Append("\nNumero de Trabajadores: " + oMateria.NumeroTrabajadores.ToString("N",CultureFormat.Cultura));
				//				}
				//				else if(companiaid == 12)
				//				{
				//					sb.Append("\nScoring RSA: ");
				//
				//					if(oMateria.Detectores)
				//						sb.Append("\nDetectores de Humo: SI");
				//					else
				//						sb.Append("\nDetectores de Humo: NO");
				//
				//					if(oMateria.RedHumeda)
				//						sb.Append("\nRed Húmeda: SI");
				//					else
				//						sb.Append("\nRed Húmeda: NO");
				//
				//					if(oMateria.Sprinklers)
				//						sb.Append("\nSprinklers: SI");
				//					else
				//						sb.Append("\nSprinklers: NO");
				//				}

				//end Coberturas  adicionales
			
				if(oRiesgo.Minuta.Trim().Length > 0)
					sb.Append("\n\nMinuta: " + oRiesgo.Minuta);



				string bodyMail = sb.ToString();
				string correoTo = "";
				XmlDocument CorreosXml = new XmlDocument();
				CorreosXml.Load(FoliacionDALC.RutaXMLCorreos);
				XmlElement root = CorreosXml.DocumentElement;

				XmlNodeList nodoCorreos;
				
				if(oPoliza.oCompania.Id == 16) //BCI
				{
					nodoCorreos = root.SelectNodes("//EmisionPymes/BCI/Correos/Correo");
					foreach(XmlNode nodoCorreo in nodoCorreos)
					{
						correoTo = correoTo + "; " + nodoCorreo.Attributes["name"].Value;
					}
				}
				else if(oPoliza.oCompania.Id == 12) //royal
				{
					nodoCorreos = root.SelectNodes("//EmisionPymes/Royal/Correos/Correo");

					foreach(XmlNode nodoCorreo in nodoCorreos)
					{
						correoTo = correoTo + "; " + nodoCorreo.Attributes["name"].Value;
					}
					//Cambia segun distribucion de corredores enviada por ANS
					//					int regionCorredor = -1;
					//					if(oPoliza.oCorredor.oDireccioneS.Count > 0)
					//						regionCorredor = ((PersonaDireccionBC)oPoliza.oCorredor.oDireccioneS[0]).oRegion.Id;
					//
					//					ArrayList alCorred = new ArrayList();
					//					alCorred.Add("995631601");
					//					alCorred.Add("856917002");
					//					if(alCorred.Contains(oPoliza.oCorredor.CorredorID))
					//						nodoCorreos = root.SelectNodes("//EmisionPymes/Royal/Correos/Correo");
					//					else if(regionCorredor == 13)
					//						nodoCorreos = root.SelectNodes("//EmisionPymes/Royal/Correos/CorreoMetropolitana");
					//					else
					//						nodoCorreos = root.SelectNodes("//EmisionPymes/Royal/Correos/CorreoRegiones");

//					LectorDatos oLector = new LectorDatos();
//					System.Data.SqlClient.SqlParameter oParam = 
//						new System.Data.SqlClient.SqlParameter("@CORREDORID", SqlDbType.NVarChar , 15);
//					oParam.Value = oPoliza.oCorredor.CorredorID;
//					oLector.Parametros.Add(oParam);
//					DataTable dtCorreos = oLector.EjecutarProcedimientoAlmacenado("PROC_GET_SUCURSALCORREDORRSA");
//					if(dtCorreos.Rows.Count > 0)
//						correoTo = ";" + dtCorreos.Rows[0]["Email"].ToString();
//					oLector.Dispose();
				}
				else if(oPoliza.oCompania.Id == 17) //Consorcio
				{
					nodoCorreos = root.SelectNodes("//EmisionPymes/Consorcio/Correos/Correo");
					foreach(XmlNode nodoCorreo in nodoCorreos)
					{
						correoTo = correoTo + "; " + nodoCorreo.Attributes["name"].Value;
					}
				}//Ini - FG027
				else if(oPoliza.oCompania.Id == 7) //interamericana
				{
					nodoCorreos = root.SelectNodes("//EmisionPymes/Interamericana/Correos/Correo");

					foreach(XmlNode nodoCorreo in nodoCorreos)
					{
						correoTo = correoTo + "; " + nodoCorreo.Attributes["name"].Value;
					}
				}
				else if(oPoliza.oCompania.Id == 5) //ACE
				{
					nodoCorreos = root.SelectNodes("//EmisionPymes/ACE/Correos/Correo");

					foreach(XmlNode nodoCorreo in nodoCorreos)
					{
						correoTo = correoTo + "; " + nodoCorreo.Attributes["name"].Value;
					}
				}
				//Fin - FG027

				correoTo = correoTo.Substring(1,correoTo.Length - 1);
			
				XmlNode nodoFrom = root.SelectSingleNode("//From");
				string correoFrom = nodoFrom.Attributes["name"].Value;
				XmlNode nodoServidor = root.SelectSingleNode("//Servidor");
				string correoServidor = nodoServidor.Attributes["name"].Value;

				string emailEjecutivo = EjecutivoEmail.getEmail(oPoliza.oCorredor.CorredorID);
				string asunto = "Solicitud Póliza Pymes";

				if(EjecutivoEmail.getProduccion() == false)
				{  //pruebas
					asunto = "Prueba (El email del ejecutivo a quien se enviaria sería: " + emailEjecutivo + ")";
					//envia email al ejectutivo y al tester
					correoTo = EjecutivoEmail.getEmailWebConfig();
				}
				else //produccion
					correoTo += ";" + emailEjecutivo;

				if(oPoliza.oCompania.Id == 16 && oMateria.oRegion.Id == 5)
					asunto = asunto + " (INSPECCION)";
			       
				MailMessage oMensaje = new MailMessage();
				oMensaje.To = correoTo;
				oMensaje.From = correoFrom;
				oMensaje.Subject = asunto;
				oMensaje.Body = bodyMail;			

				XmlNode nodoContrasena = root.SelectSingleNode("//Contrasena");
				string contrasena = nodoContrasena.Attributes["name"].Value;
			
				string ConfigNamespace =  @"http://schemas.microsoft.com/cdo/configuration/";
				oMensaje.Fields.Add(ConfigNamespace + "smtpserver", correoServidor);
				oMensaje.Fields.Add(ConfigNamespace + "smtpserverport", 25);       
				oMensaje.Fields.Add(ConfigNamespace + "sendusing", 2);       
				oMensaje.Fields.Add(ConfigNamespace + "sendusername", correoFrom);
				oMensaje.Fields.Add(ConfigNamespace + "sendpassword", contrasena);
				oMensaje.Fields.Add(ConfigNamespace + "smtpauthenticate", 1) ;


				try
				{
					//SmtpMail.SmtpServer = correoServidor;
					SmtpMail.Send(oMensaje);

					Log.GuardarLog(
						eeTipoLog.eEnvioEmail,
						oPoliza.UserName,
						"Se Envió Email Pyme CompaniaID =" + companiaid  + ", Enviado a: " + correoTo,
						oPoliza.oCorredor.CorredorID,
						oPoliza.DocumentoID,
						"",
						"",
						"");
				}
				catch(System.Web.HttpException ehttp)
				{
					Console.WriteLine("{0}", ehttp.Message);

					Log.GuardarLog(
						eeTipoLog.eNoEnvioEmail,
						oPoliza.UserName,
						"No Envió Email Pyme CompaniaID =" + companiaid  + ", Enviado a: " + correoTo,
						oPoliza.oCorredor.CorredorID,
						oPoliza.DocumentoID,
						"Error: " + ehttp.Message,
						"",
						"");
				}
			}
		}


		//Ini - FG022
		public void EnviarCorreoEvaluacion()
		{
			PolizaBC oPoliza = (PolizaBC) State["Poliza"];
			int companiaid = oPoliza.oCompania.Id;
			if(companiaid == 16)
			{
				PolizaRiesgoBC oRiesgo = (PolizaRiesgoBC)(oPoliza.oRiesgoS[0]);			
				MateriaPropiedadBC oMateria = (MateriaPropiedadBC)((PolizaRiesgoBC)(oPoliza.oRiesgoS[0])).oMateria;
				//
				StringBuilder sb = new StringBuilder();
				sb.Append("Existe una propuesta pendiente para evaluar el producto Pyme ANS, con fecha de emisión el día "+ oPoliza.Emision.ToShortDateString() +". ");
				sb.Append("Los datos de la póliza son los siguientes:\n");
				sb.Append("\nNombre Corredor: " + oPoliza.oCorredor.oPersistente.Nombres + " " + oPoliza.oCorredor.oPersistente.ApellidoPaterno + " " + oPoliza.oCorredor.oPersistente.ApellidoMaterno + " " + oPoliza.oCorredor.oPersistente.RazonSocial 
					+ "\nRut Corredor: " + oPoliza.oCorredor.Identificacion + "\n");
				sb.Append("Nombre Contratante: " + oPoliza.oContratante.oPersistente.Nombres 
					+ " " + oPoliza.oContratante.oPersistente.ApellidoPaterno + " " + oPoliza.oContratante.oPersistente.ApellidoMaterno + " " + oPoliza.oContratante.oPersistente.RazonSocial
					+ "\nRut Contratante: " + oPoliza.oContratante.Identificacion);
				sb.Append("\nAsegurado: "+ oRiesgo.oAsegurado.Nombres + " " + oRiesgo.oAsegurado.ApellidoPaterno + " " + oRiesgo.oAsegurado.ApellidoMaterno + " " +oRiesgo.oAsegurado.RazonSocial);
				sb.Append("\nTelefono:" + oRiesgo.oAsegurado.oPersistente.TelefonoParticular + " " + oRiesgo.oAsegurado.oPersistente.TelefonoComercial + " " + oRiesgo.oAsegurado.oPersistente.TelefonoCelular);
				sb.Append("\nDireccion Riesgo: " + oMateria.Direccion + "	Comuna: "+ oMateria.oComuna.NombreCorto + "	Region: "+ oMateria.oRegion.NombreCorto + ".\n");				

				sb.Append("\n\nPlan: " + oRiesgo.oDeducible.Texto);
				sb.Append("\nOcupación: " + oMateria.oOcupacionComercio.NombreLargo);
				sb.Append("\nActividad: " + oMateria.oActividadPropiedad.NombreLargo);
				sb.Append("\nConstrucción Muro: " + oMateria.oConstruccionMuro.NombreLargo);
				sb.Append("\nConstrucción Techo: " + oMateria.oConstruccionTecho.NombreLargo);
		
				sb.Append("\n\nMontos Asegurados");
				sb.Append("\nEdificio: " + oMateria.ValorEdificio.ToString("N",CultureFormat.Cultura));
				sb.Append("\nContenido: " + oMateria.ValorContenido.ToString("N",CultureFormat.Cultura));
				sb.Append("\nMercadería: " + oMateria.MontoMercaderias.ToString("N",CultureFormat.Cultura));
				sb.Append("\nEquipo Electrónico: " + oMateria.MontoEquiposElectronicos.ToString("N",CultureFormat.Cultura));
				sb.Append("\nMaquinaria: " + oMateria.MontoMaquinarias.ToString("N",CultureFormat.Cultura));
				sb.Append("\nR.Civil: " + oMateria.MontoRC.ToString("N",CultureFormat.Cultura)); 
				sb.Append("\nCristales: UF " + oMateria.Cristales.ToString("N",CultureFormat.Cultura)); 
				
				sb.Append("\n\nOpcionales");
				sb.Append("\nNº Trabaj.: UF " + oMateria.NumeroTrabajadores.ToString("N",CultureFormat.Cultura));
				sb.Append("\nDinero en caja Segur: " + oMateria.CajaSeguridad.ToString("N",CultureFormat.Cultura)); 
				sb.Append("\nMuerte e inval. Acc.: " + oMateria.MontoMuerte.ToString("N",CultureFormat.Cultura)); 
				sb.Append("\nPerjuicio por Paralización: " + oMateria.MontoPxP.ToString("N",CultureFormat.Cultura)); 
				sb.Append("\nPeríodo indemnizable PxP: " + oMateria.PeriodoPxP.ToString("N",CultureFormat.Cultura) + " meses"); 
				sb.Append("\nRemesa Valores: " + oMateria.RemesaValores.ToString("N",CultureFormat.Cultura));
				
				if(oMateria.RCAlimentos)
					sb.Append("\nR.Civil Alimentos: Si");
				else
					sb.Append("\nR.Civil Alimentos: No");
				
				if(oMateria.AveriaMaquinaria)
					sb.Append("\nAvería de Maquinaria: Si");
				else
					sb.Append("\nAvería de Maquinaria: No");

				if(oMateria.MenorA50)
					sb.Append("\nAntigüedad Construcción: Si");
				else
					sb.Append("\nAntigüedad Construcción: No");

				sb.Append("\n\nScoring");
				if(oMateria.Detectores)
					sb.Append("\nDetectores: Si");
				else
					sb.Append("\nDetectores: No");

				if(oMateria.RedHumeda)
					sb.Append("\nRed Húmeda: Si");
				else
					sb.Append("\nRed Húmeda: No");

				if(oMateria.Sprinklers)
					sb.Append("\nSprinklers: Si");
				else
					sb.Append("\nSprinklers: No");

				if(oMateria.RiesgoBordeCostero)
					sb.Append("\nRiesgo Borde Costero: Si");
				else
					sb.Append("\nRiesgo Borde Costero: No");

				if(oMateria.RiesgoBordeRio)
					sb.Append("\nRiesgo Borde Río: Si");
				else
					sb.Append("\nRiesgo Borde Río: No");


				if(oRiesgo.Minuta.Trim().Length > 0)
					sb.Append("\n\nMinuta: " + oRiesgo.Minuta);

				string bodyMail = sb.ToString();
				string correoTo = "";
				XmlDocument CorreosXml = new XmlDocument();
				CorreosXml.Load(FoliacionDALC.RutaXMLCorreos);
				XmlElement root = CorreosXml.DocumentElement;

				XmlNodeList nodoCorreos;

				string correoConCopia = "";
				string correoConCopiaOculta = "";

				if(oPoliza.oCompania.Id == 16) //BCI
				{
					nodoCorreos = root.SelectNodes("//EmisionPymesRiesgos/BCI/Correos/Correo");
					foreach(XmlNode nodoCorreo in nodoCorreos)
					{
						correoTo = correoTo + "; " + nodoCorreo.Attributes["name"].Value;
					}

					nodoCorreos = root.SelectNodes("//EmisionPymesRiesgos/BCI/CorreoCC/Correo");
					foreach(XmlNode nodoCorreo in nodoCorreos)
					{
						correoConCopia = correoConCopia + "; " + nodoCorreo.Attributes["name"].Value;
					}

					nodoCorreos = root.SelectNodes("//EmisionPymesRiesgos/BCI/CorreoCCO/Correo");
					foreach(XmlNode nodoCorreo in nodoCorreos)
					{
						correoConCopiaOculta = correoConCopiaOculta + "; " + nodoCorreo.Attributes["name"].Value;
					}
				}
				correoTo = correoTo.Substring(1,correoTo.Length - 1);

				if(correoConCopia != "")
					correoConCopia = correoConCopia.Substring(1,correoConCopia.Length - 1);
				if(correoConCopiaOculta != "")
					correoConCopiaOculta = correoConCopiaOculta.Substring(1,correoConCopiaOculta.Length - 1);

			
				XmlNode nodoFrom = root.SelectSingleNode("//From");
				string correoFrom = nodoFrom.Attributes["name"].Value;
				XmlNode nodoServidor = root.SelectSingleNode("//Servidor");
				string correoServidor = nodoServidor.Attributes["name"].Value;

				string emailEjecutivo = EjecutivoEmail.getEmail(oPoliza.oCorredor.CorredorID);
				string asunto = "Solicitud Póliza Pymes";

				//else //produccion
				if(!EjecutivoEmail.getProduccion())
					correoTo += ";" + emailEjecutivo;
			       
				MailMessage oMensaje = new MailMessage();
				oMensaje.To = correoTo;
				oMensaje.Cc = correoConCopia;
				oMensaje.Bcc = correoConCopiaOculta;
				oMensaje.From = correoFrom;
				oMensaje.Subject = asunto;
				oMensaje.Body = bodyMail;			

				XmlNode nodoContrasena = root.SelectSingleNode("//Contrasena");
				string contrasena = nodoContrasena.Attributes["name"].Value;
			
				string ConfigNamespace =  @"http://schemas.microsoft.com/cdo/configuration/";
				oMensaje.Fields.Add(ConfigNamespace + "smtpserver", correoServidor);
				oMensaje.Fields.Add(ConfigNamespace + "smtpserverport", 25);       
				oMensaje.Fields.Add(ConfigNamespace + "sendusing", 2);       
				oMensaje.Fields.Add(ConfigNamespace + "sendusername", correoFrom);
				oMensaje.Fields.Add(ConfigNamespace + "sendpassword", contrasena);
				oMensaje.Fields.Add(ConfigNamespace + "smtpauthenticate", 1) ;


				try
				{
					//SmtpMail.SmtpServer = correoServidor;
					SmtpMail.Send(oMensaje);

					Log.GuardarLog(
						eeTipoLog.eEnvioEmail,
						oPoliza.UserName,
						"Se Envió Email Pyme CompaniaID =" + companiaid  + ", Enviado a: " + correoTo,
						oPoliza.oCorredor.CorredorID,
						oPoliza.DocumentoID,
						"",
						"",
						"");
				}
				catch(System.Web.HttpException ehttp)
				{
					Console.WriteLine("{0}", ehttp.Message);

					Log.GuardarLog(
						eeTipoLog.eNoEnvioEmail,
						oPoliza.UserName,
						"No Envió Email Pyme CompaniaID =" + companiaid  + ", Enviado a: " + correoTo,
						oPoliza.oCorredor.CorredorID,
						oPoliza.DocumentoID,
						"Error: " + ehttp.Message,
						"",
						"");
				}
			}
		}
		//Fin - FG022

		#endregion

		#region Métodos de soporte para vista Descripcion de Riesgo

		public int GetCantidadItemRiesgos()
		{
			int cantidad = 0;
			try
			{
				// Obtiene el ItemRiesgo seleccionado en la propuesta
				PolizaBC oPoliza = (PolizaBC) State["Poliza"];
				cantidad = oPoliza.oRiesgoS.Count;
				
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
			return cantidad;
		}

		public int GetCantidadItemRiesgosCotizacion()
		{
			int cantidad = 0;
			try
			{
				// Obtiene el ItemRiesgo seleccionado en la propuesta
				CotizacionBC oCotizacion = (CotizacionBC) State["Cotizacion"];
				cantidad = oCotizacion.oItemeS.Count;
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
			return cantidad;
		}

		public int GetCompania()
		{
			int companiaid = -1;
			try
			{
				// Obtiene el ItemRiesgo seleccionado en la propuesta
				CotizacionBC oCotizacion = (CotizacionBC) State["Cotizacion"];
				if(oCotizacion.oItemeS.Count == 0) return companiaid;
				companiaid = ((ItemCotizacionBC)oCotizacion.oItemeS[0]).oCompania.Id;
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
			return companiaid;
		}

		public int GetOcupacionPyme(int companiaid, int actividadid)
		{
			int ocupacion = -1;
			try
			{
				LectorDatos oLector = new LectorDatos();
				System.Data.SqlClient.SqlParameter oParam;
				oParam = new System.Data.SqlClient.SqlParameter("@COMPANIAID", SqlDbType.Int);
				oParam.Value = companiaid;
				oLector.Parametros.Add(oParam);
				oParam = new System.Data.SqlClient.SqlParameter("@ACTIVIDADID", SqlDbType.Int);
				oParam.Value = actividadid;
				oLector.Parametros.Add(oParam);
				DataTable dt = oLector.EjecutarProcedimientoAlmacenado("PROC_GET_OCUPACIONPYME");
				if(dt.Rows.Count > 0)
				{
					ocupacion = int.Parse(dt.Rows[0][0].ToString());
				}
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}

			return ocupacion;
		}

		public DetalleRiesgoUIE DesplegarDescripcionRiesgo()
		{
			DetalleRiesgoUIE uie = new DetalleRiesgoUIE();
			try
			{
				// Obtiene el item de póliza desde el State
				PolizaRiesgoBC oItemRiesgo = (PolizaRiesgoBC) State["Item"];

				uie.DatosAsegurado = Utilities.GetPersona( oItemRiesgo.oAsegurado );
				if (oItemRiesgo.oBeneficiarios.Count > 0)
					uie.DatosBeneficiario = Utilities.GetPersona( (PersonaBC)oItemRiesgo.oBeneficiarios[0] );
				else
					uie.DatosBeneficiario = new DatosPersonaUIE();
				uie.idVigenciaInicio = oItemRiesgo.InicioVigencia;
				uie.idVigenciaTermino = oItemRiesgo.FinVigencia;

				// Materia Asegurada (en este caso Pymes)
				MateriaPropiedadBC materia = (MateriaPropiedadBC) oItemRiesgo.oMateria;
				uie.txtValorEstructura = materia.ValorEdificio.ToString();
				uie.txtValorContenido = materia.ValorContenido.ToString();
				uie.txtMontoMercaderias = materia.MontoMercaderias.ToString();
				uie.txtMontoEquiposElectronicos = materia.MontoEquiposElectronicos.ToString();
				uie.ddlOcupacion = materia.oOcupacionComercio.Id.ToString();
				uie.ddlActividad = materia.oActividadPropiedad.Id.ToString();
				uie.ddlCiudad = materia.oCiudad.Id.ToString();
				uie.ddlClaseConstruccion = materia.oTipoConstruccion.Id.ToString();
				uie.ddlComuna = materia.oComuna.Id.ToString();
				uie.ddlRegion = materia.oRegion.Id.ToString();
				uie.ddlUso = materia.oUsoPropiedad.Id.ToString();
				uie.txtProtecciones = materia.Protecciones;
				uie.txtAnioConstruccion = materia.Ano.ToString();
				uie.txtDireccion = materia.Direccion;

				uie.txtMontoMaquinarias = materia.MontoMaquinarias.ToString();
				uie.ddlConstruccionMuro = materia.oConstruccionMuro.Id.ToString();
				uie.ddlConstruccionTecho = materia.oConstruccionTecho.Id.ToString();

				
				uie.ddlFormaAseguramiento = materia.oFormaAseguramiento.Id.ToString();
				//uie.txtNumeroAseguramiento = materia.NumeroAseguramiento.ToString();

				// Valores de Item
				uie.txtPrimaNetaTarifa = oItemRiesgo.PrimaNetaTarifa.ToString("N",(CultureInfo)State["Cultura"]);
				if (oItemRiesgo.TipoRecargoDescuento)
					uie.ddlTipoRecDesc = "1";
				else
					uie.ddlTipoRecDesc = "0";
				uie.txtMontoRecDesc = oItemRiesgo.MontoRecargoDescuento.ToString("N",(CultureInfo)State["Cultura"]);
				uie.txtPrimaNeta = oItemRiesgo.PrimaNeta.ToString("N",(CultureInfo)State["Cultura"]);
				uie.txtIva = oItemRiesgo.IVA.ToString("N",(CultureInfo)State["Cultura"]);
				uie.txtPrimaBruta = oItemRiesgo.PrimaBruta.ToString("N",(CultureInfo)State["Cultura"]);
				uie.txtMinuta = oItemRiesgo.Minuta;

				/*********************************/
				//				if (oItemRiesgo.Renovacion)
				//				{
				//					uie.rbRenovacionSi = true;
				//					uie.rbRenovasionNo = false;
				//				}
				//				else
				//				{
				//					uie.rbRenovacionSi = false;
				//					uie.rbRenovasionNo = true;
				//				}
				/************************************/

				//uie.txtPolizaAnterior = oItemRiesgo.PolizaAnterior;
				uie.txtCompaniaAnterior = oItemRiesgo.oCompaniaAnterior.Id.ToString();

				if(materia.oFormaAseguramiento.Id == 1 || materia.oFormaAseguramiento.Id == 2 || materia.oFormaAseguramiento.Id == -1)// Factura e Inspección
					uie.txtNumeroAseguramiento = materia.NumeroAseguramiento.ToString();
				else if (materia.oFormaAseguramiento.Id == 3) //Factura
				{
					uie.txtNumeroAseguramiento = oItemRiesgo.PolizaAnterior;
					uie.txtCertificadoAnterior = oItemRiesgo.CertificadoAnterior;
				}

				DataView dv = (DataView)oItemRiesgo.oCoberturas.GetDataView();
				dv.RowFilter = "Obligatoria = false";
				uie.dgCoberturasAdicionales = dv;

				uie.chkClausulaBancos = materia.ClausulaBancos;
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
			return uie;
		}

		public void ActualizarDescripcionRiesgo(DetalleRiesgoUIE uie)
		{
			try
			{
				// Obtiene el item de póliza desde el State
				PolizaRiesgoBC oItemRiesgo = (PolizaRiesgoBC) State["Item"];

				Utilities.SetPersona(uie.DatosAsegurado, oItemRiesgo.oAsegurado,(string) State["CorredorID"] );
				// Lee datos del Beneficiario desde la UI
				PersonaBC oBeneficiario = new PersonaBC(eeRolesCatalog.eBeneficiario);
				Utilities.SetPersona(uie.DatosBeneficiario,oBeneficiario,(string)State["CorredorID"]);

				// Agrega el Beneficiario (En este caso solo 1 beneficiario)
				if (oItemRiesgo.oBeneficiarios.Count == 0)
				{
					// Si no hay beneficiario lo agrega
					oItemRiesgo.oBeneficiarios.Add( oBeneficiario );
				}
				else 
				{
					// Si ya existen, modifica el primero
					oItemRiesgo.oBeneficiarios[0] = oBeneficiario;
				}
				oItemRiesgo.InicioVigencia = uie.idVigenciaInicio;
				oItemRiesgo.FinVigencia = uie.idVigenciaTermino;
				oItemRiesgo.Minuta = uie.txtMinuta;

				if (uie.rbRenovacionSi)
					oItemRiesgo.Renovacion = true;
				else
					oItemRiesgo.Renovacion = false;

				//oItemRiesgo.PolizaAnterior = uie.txtPolizaAnterior;
				oItemRiesgo.oCompaniaAnterior.Id = int.Parse(uie.txtCompaniaAnterior);

				// Materia Asegurada (en este caso Propiedad)
				MateriaPropiedadBC materia = (MateriaPropiedadBC) oItemRiesgo.oMateria;

				materia.oActividadPropiedad.Id = int.Parse(uie.ddlActividad); 
				materia.oRegion.Id = int.Parse(uie.ddlRegion);
				materia.oCiudad.Id = int.Parse(uie.ddlCiudad);
				materia.oComuna.Id = int.Parse(uie.ddlComuna);
				materia.oTipoConstruccion.Id = int.Parse(uie.ddlClaseConstruccion);
				materia.Direccion = uie.txtDireccion;
				materia.Protecciones = uie.txtProtecciones;
				materia.Ano = int.Parse(uie.txtAnioConstruccion);
				materia.ValorContenido = float.Parse(uie.txtValorContenido,(CultureInfo)State["Cultura"]);
				materia.ValorEdificio = float.Parse(uie.txtValorEstructura,(CultureInfo)State["Cultura"]);
				materia.MontoMercaderias = float.Parse(uie.txtMontoMercaderias,(CultureInfo)State["Cultura"]);
				materia.MontoEquiposElectronicos = float.Parse(uie.txtMontoEquiposElectronicos,(CultureInfo)State["Cultura"]);
				materia.MontoMaquinarias = float.Parse(uie.txtMontoMaquinarias,(CultureInfo)State["Cultura"]);
				materia.oOcupacionComercio.Id = int.Parse(uie.ddlOcupacion);
				materia.oUsoPropiedad.Id = int.Parse(uie.ddlUso);
				materia.oConstruccionMuro.Id = int.Parse(uie.ddlConstruccionMuro);
				materia.oConstruccionTecho.Id = int.Parse(uie.ddlConstruccionTecho);

				materia.oFormaAseguramiento.Id = int.Parse(uie.ddlFormaAseguramiento);
				//materia.NumeroAseguramiento = int.Parse(uie.txtNumeroAseguramiento);

				if(((PolizaBC)State["Poliza"]).oCompania.Id == 16)
					materia.ClausulaBancos = uie.chkClausulaBancos;

				if(uie.ddlFormaAseguramiento == "1" || uie.ddlFormaAseguramiento == "2" || uie.ddlFormaAseguramiento == "-1") //Factura e inspección
					materia.NumeroAseguramiento = int.Parse(uie.txtNumeroAseguramiento);
				else if (uie.ddlFormaAseguramiento == "3")//Renovación
				{
					oItemRiesgo.PolizaAnterior = uie.txtNumeroAseguramiento;
					oItemRiesgo.CertificadoAnterior = uie.txtCertificadoAnterior;
				}
				
				// Valores de Item
				//oRiesgo.PrimaNetaTarifa = float.Parse(uieDetalleRiesgo.txtPrimaNetaTarifa);
				if (uie.ddlTipoRecDesc == "1") 
					oItemRiesgo.TipoRecargoDescuento = true; // Monto
				else
					oItemRiesgo.TipoRecargoDescuento = false; // Porcentaje
				//oItemRiesgo.MontoRecargoDescuento = float.Parse(uie.txtMontoRecDesc,(CultureInfo)State["Cultura"]);

				// Sincronización de Asegurado y Contratante
				PolizaBC oPoliza = (PolizaBC) State["Poliza"];

				if (oPoliza.oContratante.Identificacion == oItemRiesgo.oAsegurado.Identificacion)
				{
					oPoliza.oContratante.oTipoIdentificacion.Id = oItemRiesgo.oAsegurado.oTipoIdentificacion.Id;
					oPoliza.oContratante.Nombres = oItemRiesgo.oAsegurado.Nombres;
					oPoliza.oContratante.ApellidoMaterno = oItemRiesgo.oAsegurado.ApellidoMaterno;
					oPoliza.oContratante.ApellidoPaterno = oItemRiesgo.oAsegurado.ApellidoPaterno;
					oPoliza.oContratante.RazonSocial = oItemRiesgo.oAsegurado.RazonSocial;
					//oPoliza.oContratante.oDireccioneS = oItemRiesgo.oAsegurado.oDireccioneS;
					//oPoliza.oContratante.oContactoS = oItemRiesgo.oAsegurado.oContactoS;
					
					oPoliza.oContratante.oDireccioneS.Clear();
					foreach(PersonaDireccionBC oDireccion in oItemRiesgo.oAsegurado.oDireccioneS)
					{
						oPoliza.oContratante.oDireccioneS.Add(oDireccion);
					}						
					oPoliza.oContratante.oContactoS.Clear();
					foreach(PersonaContactoBC oContacto in oItemRiesgo.oAsegurado.oContactoS)
					{
						oPoliza.oContratante.oContactoS.Add(oContacto);
					}

					//oPoliza.oContratante = oItemRiesgo.oAsegurado;
					//oPoliza.oContratante.eRolCatalog = eeRolesCatalog.eContratante;
				}
				oPoliza.InicioVigencia = uie.idVigenciaInicio;
				oPoliza.FinVigencia = uie.idVigenciaTermino;

				// Actualiza fechas del plan de pago
				State["InicioVigencia"] = oPoliza.InicioVigencia;
				if(oPoliza.oPlanPago.oCuotas.Count > 0)
				{
					this.State["CompañiaID"] = oPoliza.oCompania.Id;
					DateTime dtFecha = GetPrimeraCuota(oPoliza.oPlanPago);
					oPoliza.oPlanPago.ActualizarFechaCuotas(dtFecha);
				}

				State["Poliza"] = oPoliza;
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
		}
		
		#endregion

		#region Métodos de soporte para vista Plan de Pago

		public PlanDePagoUIE DesplegarPlanDePago()
		{
			PlanDePagoUIE uiePlanDePago = new PlanDePagoUIE();
			try
			{
				// Obetner el plan de pago actual
				PlanPagoBC oPlanPago = (PlanPagoBC)State["PlanDePago"];

				uiePlanDePago.lblMoneda = oPlanPago.oMoneda.NombreLargo;
				uiePlanDePago.idInicioVigencia = (DateTime) State["InicioVigencia"];
				uiePlanDePago.idTerminoVigencia = (DateTime) State["FinVigencia"];
				uiePlanDePago.ddlViaPago = oPlanPago.oFormaPago.Id.ToString();
				uiePlanDePago.ddlCuotas = oPlanPago.oCuotas.Count.ToString();
				uiePlanDePago.ddlTarjetaDeCredito = oPlanPago.oTipoTarjeta.Id.ToString();
				uiePlanDePago.txtNumTarjetaCredito = oPlanPago.NumeroMedioPago;
				uiePlanDePago.txtNumCuenta = oPlanPago.NumeroMedioPago;
				uiePlanDePago.ddlEmisorTarjetaCredito = oPlanPago.oEntidadFinanciera.Id.ToString();
				uiePlanDePago.ddlExpiracionMes = oPlanPago.Expiracion.Month.ToString();
				uiePlanDePago.ddlExpiracionAno = oPlanPago.Expiracion.Year.ToString();
				uiePlanDePago.ddlBanco = oPlanPago.oEntidadFinanciera.Id.ToString();
				uiePlanDePago.ddlDiaPago = oPlanPago.DiaPago.ToString();

				float fPrimaNetaTarifa = (float)State["PrimaNetaTarifa"];
				float fDescuentoRecoargo = (float)State["DescuentoRecargo"];
				float fPrimaNeta = (float)State["PrimaNeta"];
				float fIva = (float)State["IVA"];
				float fMontoAPagar = (float)State["MontoAPagar"];
				float fFinanciamiento = fMontoAPagar - oPlanPago.MontoContado;

				uiePlanDePago.lblPrima = fPrimaNetaTarifa.ToString("N",(CultureInfo)State["Cultura"]);
				uiePlanDePago.lblDescRec = fDescuentoRecoargo.ToString("N",(CultureInfo)State["Cultura"]);
				uiePlanDePago.lblSubTotal = fPrimaNeta.ToString("N",(CultureInfo)State["Cultura"]);
				uiePlanDePago.lblImpuesto = fIva.ToString("N",(CultureInfo)State["Cultura"]);
				uiePlanDePago.lblTotalUF = fMontoAPagar.ToString("N",(CultureInfo)State["Cultura"]);
				uiePlanDePago.txtContado = oPlanPago.MontoContado.ToString("N",(CultureInfo)State["Cultura"]);
				uiePlanDePago.lblFinanciamineto = fFinanciamiento.ToString("N",(CultureInfo)State["Cultura"]);
				uiePlanDePago.lblTotalCuotas = oPlanPago.MontoTotalCuotas.ToString("N",(CultureInfo)State["Cultura"]);

				// Desplegando las cuotas
				uiePlanDePago.dgListaCuotas = (DataView)oPlanPago.oCuotas.GetDataView();

				
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
			return uiePlanDePago;
		}

		public int GetMaximoCuotas(int indexFormaPago)
		{
			int iMaximoCuotas = 0;
			try
			{
				// Obetner el Producto para la Propuesta 
				ProductoBC oProducto = (ProductoBC) State["Producto"];
				// Obtener la Compañia para la Propuesta
				int iCompaniaID = (int) State["CompañiaID"];
				ProductoCompaniaBC oProductoCompania = oProducto.oCompaniaS.GetProductoCompania(iCompaniaID);
				ProductoCompaniaFormaPagoBC oFormaPago = 
					(ProductoCompaniaFormaPagoBC)oProductoCompania.oFormaPagoS[indexFormaPago];
				iMaximoCuotas = oFormaPago.MaximoCuotas;
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
			return iMaximoCuotas;
		}

		public ArrayList GetDias(int indexFormaPago)
		{
			ArrayList dias = new ArrayList();
			try
			{
				// Obetner el Producto para la Propuesta 
				ProductoBC oProducto = (ProductoBC) State["Producto"];
				// Obtener la Compañia para la Propuesta
				int iCompaniaID = (int) State["CompañiaID"];
				ProductoCompaniaBC oProductoCompania = oProducto.oCompaniaS.GetProductoCompania(iCompaniaID);
				ProductoCompaniaFormaPagoBC oFormaPago = 
					(ProductoCompaniaFormaPagoBC)oProductoCompania.oFormaPagoS[indexFormaPago];
				if(oFormaPago.FiltraDias)
				{
					dias = oFormaPago.oDiaS;
				}
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
			return dias;
		}

		public DataView GetBancos(int indexFormaPago)
		{
			DataView bancos = new DataView();
			try
			{
				// Obetner el Producto para la Propuesta 
				ProductoBC oProducto = (ProductoBC) State["Producto"];
				// Obtener la Compañia para la Propuesta
				int iCompaniaID = (int) State["CompañiaID"];
				ProductoCompaniaBC oProductoCompania = oProducto.oCompaniaS.GetProductoCompania(iCompaniaID);
				ProductoCompaniaFormaPagoBC oFormaPago = 
					(ProductoCompaniaFormaPagoBC)oProductoCompania.oFormaPagoS[indexFormaPago];
				bancos = (DataView)oFormaPago.oBancoS.GetDataView();
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
			return bancos;
		}

		public DataView GetTarjetas(int indexFormaPago)
		{
			DataView tarjetas = new DataView();
			try
			{
				// Obetner el Producto para la Propuesta 
				ProductoBC oProducto = (ProductoBC) State["Producto"];
				// Obtener la Compañia para la Propuesta
				int iCompaniaID = (int) State["CompañiaID"];
				ProductoCompaniaBC oProductoCompania = oProducto.oCompaniaS.GetProductoCompania(iCompaniaID);
				ProductoCompaniaFormaPagoBC oFormaPago = 
					(ProductoCompaniaFormaPagoBC)oProductoCompania.oFormaPagoS[indexFormaPago];
				tarjetas = (DataView)oFormaPago.oTarjetaS.GetDataView();
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
			return tarjetas;
		}

		public DataView GetPeriodicidad(int indexFormaPago)
		{
			DataView per = new DataView();
			try
			{
				// Obetner el Producto para la Propuesta 
				ProductoBC oProducto = (ProductoBC) State["Producto"];
				// Obtener la Compañia para la Propuesta
				int iCompaniaID = (int) State["CompañiaID"];
				ProductoCompaniaBC oProductoCompania = oProducto.oCompaniaS.GetProductoCompania(iCompaniaID);
				ProductoCompaniaFormaPagoBC oFormaPago = 
					(ProductoCompaniaFormaPagoBC)oProductoCompania.oFormaPagoS[indexFormaPago];

				per = (DataView)oFormaPago.oPeriodicidadeS.GetDataView();
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
			return per;
		}

		public TablaInteresBC GetTablaIntereses(int indexFormaPago)
		{
			TablaInteresBC tabla = new TablaInteresBC();
			try
			{
				// Obetner el Producto para la Propuesta 
				ProductoBC oProducto = (ProductoBC) State["Producto"];
				// Obtener la Compañia para la Propuesta
				int iCompaniaID = (int) State["CompañiaID"];
				ProductoCompaniaBC oProductoCompania = oProducto.oCompaniaS.GetProductoCompania(iCompaniaID);
				ProductoCompaniaFormaPagoBC oFormaPago = 
					(ProductoCompaniaFormaPagoBC)oProductoCompania.oFormaPagoS[indexFormaPago];
				tabla = oFormaPago.oTablaInteres;
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
			return tabla;
		}

		public DataView GetFormasDePago()
		{
			DataView dv = new DataView();
			try
			{
				// Obetner el Producto para la Propuesta 
				ProductoBC oProducto = (ProductoBC) State["Producto"];
				// Obtener la Compañia para la Propuesta
				int iCompaniaID = (int) State["CompañiaID"];
				ProductoCompaniaBC oProductoCompania = oProducto.oCompaniaS.GetProductoCompania(iCompaniaID);
				dv = (DataView) oProductoCompania.oFormaPagoS.GetDataView();
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
			return dv;
		}
		//Ini:Código: JC024
		/*Plan de pago Cotizacion*/
		public void ActualizarPlanPagoCotizacion(int numeroCuotas, string numeroMedioPago, int entidadFinancieraID,	int formaPagoID, int tipoTarjetaID, DateTime primeraCuota)
		{
			CotizacionBC oCotizacion = (CotizacionBC)State["Cotizacion"];
			if (oCotizacion.oPlanPago.PlanPagoID.Replace("}","").Replace("{","")== "00000000-0000-0000-0000-000000000000" )
			{
				oCotizacion.oPlanPago.PlanPagoID = Guid.NewGuid().ToString();
			}
			oCotizacion.oPlanPago.NumeroCuotas = numeroCuotas;

			oCotizacion.oPlanPago.NumeroMedioPago = numeroMedioPago;
			oCotizacion.oPlanPago.oEntidadFinanciera.Id = entidadFinancieraID;
			oCotizacion.oPlanPago.oFormaPago.Id = formaPagoID;
			oCotizacion.oPlanPago.oTipoTarjeta.Id = tipoTarjetaID;
			oCotizacion.oPlanPago.PrimeraCuota = primeraCuota;

			if(oCotizacion.oItemeS.Count > 0)
				oCotizacion.oPlanPago.CalcularCuota
					(	((ItemCotizacionBC)oCotizacion.oItemeS[0]).oCompania.Id,
					((ItemCotizacionBC)oCotizacion.oItemeS[0]).oProducto.ProductoID,
					((ItemCotizacionBC)oCotizacion.oItemeS[0]).oProducto.Version,
					((ItemCotizacionBC)oCotizacion.oItemeS[0]).PrimaBruta,
					numeroCuotas);

		}
    // Fin:Código: JC024

		public void ActualizarPlanDePago(PlanDePagoUIE uiePlanDePago)
		{
			try
			{
				// Obetner el plan de pago actual
				PlanPagoBC oPlanPago = (PlanPagoBC)State["PlanDePago"];
				float fMonto = (float) State["MontoAPagar"];
				
				oPlanPago.oFormaPago.Id = int.Parse( uiePlanDePago.ddlViaPago );
				oPlanPago.oTipoTarjeta.Id = int.Parse(uiePlanDePago.ddlTarjetaDeCredito);
				if (oPlanPago.oFormaPago.Id == 130) // Tarjeta de credito
				{
					oPlanPago.NumeroMedioPago = uiePlanDePago.txtNumTarjetaCredito;
					oPlanPago.oEntidadFinanciera.Id = int.Parse(uiePlanDePago.ddlEmisorTarjetaCredito);
				}
				else
				{
					oPlanPago.NumeroMedioPago = uiePlanDePago.txtNumCuenta;
					oPlanPago.oEntidadFinanciera.Id = int.Parse(uiePlanDePago.ddlBanco);
				}

				DateTime oExpiracion = new DateTime(
					int.Parse(uiePlanDePago.ddlExpiracionAno),
					int.Parse(uiePlanDePago.ddlExpiracionMes),
					DateTime.DaysInMonth(int.Parse(uiePlanDePago.ddlExpiracionAno),int.Parse(uiePlanDePago.ddlExpiracionMes)));
				oPlanPago.Expiracion = oExpiracion;
				
				if(uiePlanDePago.ddlDiaPago.Trim()=="")
					oPlanPago.DiaPago = ((DateTime) State["InicioVigencia"]).Day;
				else
					oPlanPago.DiaPago = int.Parse(uiePlanDePago.ddlDiaPago);

				oPlanPago.oTablaInteres = GetTablaIntereses( (int) State["IndiceFormaPago"] );

				// Calculo de la fecha de la primera cuota
				//DateTime dtFecha = (DateTime) State["InicioVigencia"];
				DateTime dtFecha = GetPrimeraCuota(oPlanPago);
				// Calculo de Cuotas
				oPlanPago.MontoContado = float.Parse(uiePlanDePago.txtContado,(CultureInfo)State["Cultura"]);
				//Monto contado no puede ser negativo o mayor que la prima bruta
				if(oPlanPago.MontoContado < 0 || oPlanPago.MontoContado > float.Parse(uiePlanDePago.lblTotalUF))
				{
					throw new BusinessFunctionalException(eeTipoException.eMontoContadoIncorrecto, "Monto Contado", this.GetType().ToString());
				}

				oPlanPago.MontoFinanciamiento = fMonto - float.Parse(uiePlanDePago.txtContado,(CultureInfo)State["Cultura"]);
				oPlanPago.CompaniaID = (int) State["CompañiaID"];

				PolizaBC oPoliza = (PolizaBC)State["Poliza"];	
			
				//Validacion Condominio RSA
				//a.	Si es pago contado, sistema debe aplicar el 0.5% de descuento sobre la prima neta.
				if(oPoliza.oProducto.ProductoID.Replace("{","").Replace("}","") == "00000000-0000-0000-0000-000000000267" 
					&& oPlanPago.oFormaPago.Id == 100)
				{
					oPlanPago.MontoFinanciamiento = oPlanPago.MontoFinanciamiento * 0.995f;
				}

//Ini:Código: JC025
				if(oPoliza.oProducto.ProductoID.Replace("{","").Replace("}","") == "00000000-0000-0000-0000-000000000969" 
					&& oPlanPago.oFormaPago.Id == 100)
				{
					//INI RJNV029
					//oPlanPago.MontoFinanciamiento = oPlanPago.MontoFinanciamiento * 0.99f;
					//Descuento 1.5% por Pago Contado
					oPlanPago.MontoFinanciamiento = oPlanPago.MontoFinanciamiento - (oPlanPago.MontoFinanciamiento* 0.015f); 
					//INI RJNV029
				}
        //Fin:Código: JC025

 			PeriodicidadFormaPagoDALC oPeriodicidadeS = new PeriodicidadFormaPagoDALC();

				oPeriodicidadeS.Filtro.Add("ProductoID",oPoliza.oProducto.ProductoID);
				oPeriodicidadeS.Filtro.Add("Version",oPoliza.oProducto.Version);
				oPeriodicidadeS.Filtro.Add("CompaniaID",oPoliza.oCompania.Id);
				oPeriodicidadeS.Filtro.Add("FomaPagoID",oPlanPago.oFormaPago.Id);

				DataTable dtPeriodicidadeS = oPeriodicidadeS.ReadAll();

				/* Carga los Periodicidades para la Forma de Pago */
				foreach(DataRow oDR in dtPeriodicidadeS.Rows)
				{			
					oPlanPago.oPeriodicidad.Id = (int) oDR["PeriodicidadID"];
				}
				
				//				if(oPlanPago.CompaniaID == 7 && oPlanPago.oFormaPago.Id == 110)
				//				{
				//
				// Obetner el Producto 
				ProductoBC oProducto = (ProductoBC) State["Producto"];
				// Obtener la Compañia 
				int iCompaniaID = (int) State["CompañiaID"];
				ProductoCompaniaBC oProductoCompania = oProducto.oCompaniaS.GetProductoCompania(iCompaniaID);
				ProductoCompaniaFormaPagoBC oFormaPago = 
					(ProductoCompaniaFormaPagoBC)oProductoCompania.oFormaPagoS[ (int) State["IndiceFormaPago"]];
				
				if(oFormaPago.TieneInteres)
				{
					oPlanPago.GenerarCuotas(
						oFormaPago.TasaInteres,
						oPoliza.PrimaNeta,
						oPoliza.PrimaNetaExenta,
						int.Parse(uiePlanDePago.ddlCuotas), 						 
						dtFecha.Day, 
						dtFecha.Month, 
						dtFecha.Year ,
						oFormaPago.CuotaInicialInteres);
				}
				else
				{
					oPlanPago.GenerarCuotas(
						int.Parse(uiePlanDePago.ddlCuotas), 
						oPlanPago.MontoFinanciamiento, 
						dtFecha.Day, 
						dtFecha.Month, 
						dtFecha.Year );
				}
				//				}
				//				else
				//				{
				//					DateTime dtPrimeraCuota = new DateTime(dtFecha.Year, dtFecha.Month, oPlanPago.DiaPago);
				//					oPlanPago.GenerarCuotas(
				//						int.Parse(uiePlanDePago.ddlCuotas), 
				//						oPlanPago.MontoFinanciamiento, 
				//						dtPrimeraCuota.Day, 
				//						dtPrimeraCuota.Month, 
				//						dtPrimeraCuota.Year );
				//				}
				//	oPlanPago.oPeriodicidad.Id =120;
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
		}

		
		public void ActualizarPlanDePago()
		{
			try
			{
				// Obetner el plan de pago actual
				PolizaBC oPoliza = (PolizaBC)State["Poliza"];				
				PlanPagoBC oPlanPago = oPoliza.oPlanPago;				
				
				DateTime dtPrimeraCuota;
				if(oPlanPago.oCuotas.Count > 0)
					dtPrimeraCuota = ((CuotaBC)oPlanPago.oCuotas[0]).Vencimiento ;
				else
					dtPrimeraCuota = DateTime.Now;
				

				oPlanPago.MontoFinanciamiento = oPoliza.PrimaBrutaTotal - oPlanPago.MontoContado;
				// Calculo de Cuotas
				oPlanPago.GenerarCuotas(
					oPlanPago.oCuotas.Count, 
					oPlanPago.MontoFinanciamiento, 
					dtPrimeraCuota.Day, 
					dtPrimeraCuota.Month, 
					dtPrimeraCuota.Year );		

			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
		}

		private DateTime GetPrimeraCuota(PlanPagoBC oPlanPago)
		{
			//Valor por Defecto
			DateTime dtFecha = (DateTime) State["InicioVigencia"];
			DateTime dtPrimeraCuota = new DateTime(dtFecha.Year, dtFecha.Month, oPlanPago.DiaPago);
//CR000
			int cantidadcuotas= 1;
			try
			{
				cantidadcuotas = (int)this.State["NumeroCuotas"];
			}
			catch
			{
				cantidadcuotas = oPlanPago.oCuotas.Count;
			}
			
			int iCompaniaID = (int) State["CompañiaID"];
			switch(iCompaniaID)
			{
				case 7://INTERAMERICANA
				switch(oPlanPago.oFormaPago.Id)
				{
					case 120: //PAC
						//						while(dtFecha.Day != 10)
						//							dtFecha = dtFecha.AddDays(1);
						//						dtFecha = dtFecha.AddMonths(1);
						if(dtFecha.Day > 10)
							while(dtFecha.Day != 10)
								dtFecha = dtFecha.AddDays(-1);
						else
							while(dtFecha.Day != 10)
								dtFecha = dtFecha.AddDays(1);
						dtFecha = dtFecha.AddMonths(2);
						break;
					case 130: //PAT
						if(dtFecha.Day > 10)
							while(dtFecha.Day != 10)
								dtFecha = dtFecha.AddDays(-1);
						else
							while(dtFecha.Day != 10)
								dtFecha = dtFecha.AddDays(1);


						
						dtFecha = dtFecha.AddMonths(2);
						break;
					case 110: //CUPONERA
						dtFecha = dtFecha.AddMonths(1);
						break;
				}
					dtPrimeraCuota = dtFecha;
					break;	
				case 16://BCI
					dtFecha = dtFecha.AddDays(16);
				switch(oPlanPago.oFormaPago.Id)
				{
					case 120: //PAC
						//primer 2 o 18 a contar de 16 pasados del inicio de vigencia
						while(dtFecha.Day!= oPlanPago.DiaPago)
							dtFecha = dtFecha.AddDays(1);
						break;
					case 130: //PAT
						//primer 2 o 18 a contar de 16 pasados del inicio de vigencia
						while(dtFecha.Day!= oPlanPago.DiaPago)
							dtFecha = dtFecha.AddDays(1);
						break;
					case 160: //AVISO DE VENCIMIENTO
						//primer 2,10,18 o 25 a contar de 16 pasados del inicio de vigencia
						while(dtFecha.Day!= oPlanPago.DiaPago)
							dtFecha = dtFecha.AddDays(1);
						break;
				}
					dtPrimeraCuota = dtFecha;
					break;
				case 12://ROYAL
					//CR006
					dtPrimeraCuota = Utilities.GetPrimeraCuotaRSA(dtFecha, cantidadcuotas, oPlanPago.oFormaPago.Id);
//					// inicio ME001
//					switch(oPlanPago.oFormaPago.Id)
//					{
//						case 100: //CONTADO
//							dtFecha = dtFecha.AddDays(30);
//							break;
//						case 130: //PAT
//							dtFecha = dtFecha.AddDays(25);
//							break;
//						default: 
//							dtFecha = dtFecha.AddDays(16);
//							break;
//					}
//					// fin ME001
//
//					//primer 5 o 20 a contar de 16 pasados del inicio de vigencia
//					while(dtFecha.Day!= oPlanPago.DiaPago)
//						dtFecha = dtFecha.AddDays(1);
//					//				switch(oPlanPago.oFormaPago.Id)
//					//				{
//					//					case 120: //PAC
//					//						break;
//					//					case 130: //PAT
//					//						break;
//					//					case 110: //CUPONERA
//					//						break;
//					//				}
//					dtPrimeraCuota = dtFecha;
					break;
				
					//CR001
				case 17://CONSORCIO
					
					if(oPlanPago.oFormaPago.Id == 100)
					{
						dtFecha = dtFecha.AddMonths(1); 
						while(dtFecha.Day!= 5 && dtFecha.Day!= 20)
							dtFecha = dtFecha.AddDays(1); 
						dtPrimeraCuota = dtFecha;
						break;

					}
					else
					{
						dtFecha = dtFecha.AddMonths(1); 
						while(dtFecha.Day!= oPlanPago.DiaPago)
							dtFecha = dtFecha.AddDays(1); 
						dtPrimeraCuota = dtFecha;
						break;
					}
					//Fin - CR001
					//ini - RN008
					case 5://ACE 
						dtFecha = dtFecha.AddDays(30);
					switch(oPlanPago.oFormaPago.Id)
					{
						case 100: //contado
							//primer 5 o 20 a contar de 30 dias despues del inicio de vigencia
							while(dtFecha.Day!= oPlanPago.DiaPago)
								dtFecha = dtFecha.AddDays(1);
							break;
						case 120: //PAC
							//primer 5 o 20 a contar de 30 dias despues del inicio de vigencia
							while(dtFecha.Day!= oPlanPago.DiaPago)
								dtFecha = dtFecha.AddDays(1);
							break;
						case 130: //PAT
							//primer 5 o 20 a contar de 30 dias despues del inicio de vigencia
							while(dtFecha.Day!= oPlanPago.DiaPago)
								dtFecha = dtFecha.AddDays(1);
							break;
						case 160: //AVISO DE VENCIMIENTO
							//primer 5 o 20 a contar de 30 dias despues del inicio de vigencia
							while(dtFecha.Day!= oPlanPago.DiaPago)
								dtFecha = dtFecha.AddDays(1);
							break;
					}
						dtPrimeraCuota = dtFecha;
						break;
					//fin - RN008
			}
			return dtPrimeraCuota;
			
		}

		

		public void GrabarPlanDePago()
		{
			try
			{
				// Obetner el plan de pago actual
				PlanPagoBC oPlanPago = (PlanPagoBC)State["PlanDePago"];

				//oPlanPago.Create();
			}
			catch(BusinessFunctionalException bfe)
			{
				ExceptionManager.Publish(bfe);
				throw bfe;
			}
			catch(BusinessTechException bte)
			{
				ExceptionManager.Publish(bte);
				throw bte;
			}
			catch(Exception e)
			{
				ExceptionManager.Publish(e);
				throw e;
			}
		}
		#endregion

    //Ini:Código: JC024
		public  DataTable BuscarMensajeEvaluacion(int ActividadID)
		{

			DALC.LectorDatos oLector = new Hypernet.ANT.DALC.LectorDatos();	
			SqlParameter pActividadID = new SqlParameter("@ActividadID", SqlDbType.Int);
			pActividadID.Value = ActividadID;
			oLector.Parametros.Add(pActividadID);

			DataTable dtParametros = oLector.EjecutarProcedimientoAlmacenado("PROC_SEL_BUSCARMENSAJEEVALUACION");	
			
			return dtParametros; 
		}
    //Fin:Código: JC024

		#region Validaciones de Negocio
		public bool ValidaCotizacion(ref string mensaje)
		{
			bool valido = true;
			try
			{
				CotizacionBC oCotizacion = (CotizacionBC) State["Cotizacion"];
				


				// Recorre los items de la cotizacion realizando la validación
				foreach (ItemCotizacionBC oItem in oCotizacion.oItemeS)
				{
					//INICIO - WS016
					if(oItem.oCompania.Id == -1)
					{
						valido = false;
						mensaje = "Debe seleccionar algún plan para poder Grabar.";
						break;
					}
					//FIN - WS016
					if(oItem.oCompania.Id == 12)
					{
//						MateriaPropiedadBC propiedad = (MateriaPropiedadBC)oItem.oMateria;
//						//Monto Máximo Edificio UF 25.000
//						if ((propiedad.ValorEdificio) > 25000)
//						{
//							valido = false;
//							mensaje = "El valor del Edificio no puede superar las UF 25.000.-";
//							break;
//						}
//						//Monto Máximo Contenido UF 5000
//						if(propiedad.ValorContenido > 5000)
//						{
//							valido = false;
//							mensaje = "El valor del Contenido no puede superar las UF 5.000.-";
//							break;
//						}
//						//Monto Máximo Mercaderias UF 5000
//						if(propiedad.MontoMercaderias > 5000)
//						{
//							valido = false;
//							mensaje = "El Monto de Mercaderías no puede superar las UF 5.000.-";
//							break;
//						}
//						//Monto Máximo Equipos Electronicos UF 2000
//						if(propiedad.MontoEquiposElectronicos > 2000)
//						{
//							valido = false;
//							mensaje = "El Monto de Equipos Electrónicos no puede superar las UF 2.000.-";
//							break;
//						}
					} 
					else if(oItem.oCompania.Id == 7)
					{
						if(oItem.oProducto.ProductoID != "00000000-0000-0000-0000-000000000250" && 
							oItem.oProducto.ProductoID != "00000000-0000-0000-0000-000000000251" && 
							oItem.oProducto.ProductoID != "00000000-0000-0000-0000-000000000252" &&
							oItem.oProducto.ProductoID != "00000000-0000-0000-0000-000000000253" &&
							oItem.oProducto.ProductoID != "00000000-0000-0000-0000-000000000254" &&
							oItem.oProducto.ProductoID != "00000000-0000-0000-0000-000000000255" &&
							oItem.oProducto.ProductoID != "00000000-0000-0000-0000-000000000256" )
						{
							if(oItem.RecargoDescuento < -20f)
							{
								valido = false;
								mensaje = "Excede el descuento máximo.";
								break;
							}
						}
//						MateriaPropiedadBC oPropiedad = (MateriaPropiedadBC)oItem.oMateria;
//						if((oPropiedad.ValorEdificio + oPropiedad.ValorContenido + 
//							oPropiedad.MontoMaquinarias + oPropiedad.MontoMercaderias +	
//							oPropiedad.MontoEquiposElectronicos ) > 110000)
//						{
//							valido = false;
//							mensaje = "El Total del Monto Asegurado no puede superar las UF 110.000.-";
//							break;
//						}
					}
//					foreach(ItemCotizacionCoberturaBC oCob in oItem.oItemCoberturaS)
//					{
//						if(oCob.PrimaNeta == 0)
//						{							
//							valido = false;
//							mensaje = "Cobertura con prima en 0";
//							break;							
//						}
//					}
				}
			}
			catch(Exception ex)
			{
				throw ex;
			}
			return valido;
		}

		public bool ValidaPoliza(ref string mensaje)
		{
			bool valido = true;
			try
			{
				PolizaBC oPoliza = (PolizaBC) State["Poliza"];
				PymesANSValidacion val = new PymesANSValidacion();
				valido = val.ValidaPoliza(oPoliza, ref mensaje);
			}
			catch(Exception ex)
			{
				throw ex;
			}
			return valido;
		}
		#endregion

//		private UsuarioSEG oUsuarioSeg
//		{
//			get{return (UsuarioSEG)this.State["UsuarioSeg"];}
//		}
	}
}
