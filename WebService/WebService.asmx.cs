using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
//using MySql.Data.MySqlClient;
using System.Xml;
using System.Xml.Serialization;

namespace WebService
{
    [WebService(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", Name = "OperacionEntradaService", Description = "Servicio Web para VUCEM")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        private const string Conexion = "server=localhost;uid=root;password=mSQL#18.;database=vucem;SslMode = none;";
        //private const string Conexion = "server=localhost;uid=root;password=;database=vucem;SslMode = none;";

        notificacionIngresoMercancia ObjNotificacionIngresoMercancia = new notificacionIngresoMercancia();
        ceAgregacionMercancia ObjCeAgregacionMercancia = new ceAgregacionMercancia();
        ceDesagregacionMercancia ObjCeDesagregacionMercancia = new ceDesagregacionMercancia();
        consolidacionMaster ObjConsolidacionMaster = new consolidacionMaster();
        desconsolidacionMaster ObjDesconsolidacionMaster = new desconsolidacionMaster();
        incidenciaMercancia ObjIncidenciaMercancia = new incidenciaMercancia();
        ingresoFlujoAlterno ObjIngresoFlujoAlterno = new ingresoFlujoAlterno();
        ingresoParcial ObjIngresoParcial = new ingresoParcial();
        ingresoSimple ObjIngresoSimple = new ingresoSimple();
        ingresoSinID ObjIngresoSinID = new ingresoSinID();
        rechazo ObjRechazo = new rechazo();
        salidaPedimento ObjSalidaPedimento = new salidaPedimento();
        salidaTransferencia ObjSalidaTransferencia = new salidaTransferencia();
        subdivisionMercancia ObjSubdivisionMercancia = new subdivisionMercancia();
        traspaleoContenedor ObjTraspaleoContenedor = new traspaleoContenedor();

        /*[WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }*/
        [WebMethod]
        public string miaw()
        {
            return "Hola a todos";
        }
    }
}
