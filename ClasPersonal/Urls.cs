using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portal_pets.ClasPersonal
{
    public static class Urls
    {
        //Desarrollo Contabo Eureka
        //public static String urlbase { get; set; } = "http://207.244.241.93:83/api/";

        //Produccion Contabo MiamiNautical
        public static String urlbase { get; set; } = "http://209.145.50.134:83/api/";

        #region Login - Permisos
        public static String urllogin { get { return urlbase + "Account/Login"; } } //ok
        public static String urlsentemail { get { return urlbase + "sentemail"; } } //ok
        public static String urlchange_Pass { get { return urlbase + "changePassword"; } } //ok
        public static String urlmenu { get { return urlbase + "permission/getbyuser"; } } //ok
        public static String urlforgotpassword { get { return urlbase + "forgotpassword"; } } //ok
        public static String urluser_getall { get { return urlbase + "users/getusers"; } }
        public static String urluser_insert { get { return urlbase + "Account/create"; } }
        public static String urluser_update { get { return urlbase + "Account/create"; } }
        public static String urluser_inactive { get { return urlbase + "users/inactive"; } }


        public static String urlopcion_getall { get { return urlbase + "opcion/getall"; } }
        public static String urlopcion_insert { get { return urlbase + "opcion/insert"; } }
        public static String urlopcion_update { get { return urlbase + "opcion/update"; } }
        public static String urlopcion_inactive { get { return urlbase + "opcion/inactive"; } }
        public static String urlopcion_getbycode { get { return urlbase + "opcion/getbycode"; } }

        #endregion

        #region Parametro
        public static String urlparametro_getall { get { return urlbase + "parametro/getall"; } } //GET
        public static String urlparametro_getbyid { get { return urlbase + "parametro/getbyid"; } } //POST
        public static String urlparametro_getbycode { get { return urlbase + "parametro/getbycode"; } } //POST
        public static String urlparametro_insert { get { return urlbase + "parametro/insert"; } } //POST
        public static String urlparametro_update { get { return urlbase + "parametro/update"; } } //POST
        public static String urlparametro_inactive { get { return urlbase + "parametro/inactive"; } } //POST
        #endregion


        #region Rol
        public static String urlrol_getall { get { return urlbase + "rol/getall"; } } //GET
        public static String urlrol_getbyid { get { return urlbase + "rol/getbyid"; } } //POST        
        public static String urlrol_insert { get { return urlbase + "rol/insert"; } } //POST
        public static String urlrol_update { get { return urlbase + "rol/update"; } } //POST    
        public static String urlrol_getbycode { get { return urlbase + "rol/getbycode"; } } //POST

        #endregion


        #region Rol Usuarios
        public static String urlrolusuario_getall { get { return urlbase + "roluser/getrolesbyuser"; } } //GET
        public static String urlrolusuario_insert { get { return urlbase + "roluser/insert"; } } //POST
        public static String urlrolusuario_delete { get { return urlbase + "roluser/delete"; } } //POST        
        public static String urlrolusuario_byrol { get { return urlbase + "roluser/getUsersbyrol"; } } //POST        
        #endregion

        #region Rol Opcion
        public static String urlrolopcion_insert { get { return urlbase + "rolopcion/insert"; } } //POST
        public static String urlrolopcion_update { get { return urlbase + "rolopcion/update"; } } //POST        
        #endregion


        #region Parametro Detalle
        public static String urlparametrodetalle_getall { get { return urlbase + "parametrodetalle/getall"; } } //GET
        public static String urlparametrodetalle_getbyid { get { return urlbase + "parametrodetalle/getbyid"; } } //POST
        public static String urlparametrodetalle_getbycode { get { return urlbase + "parametrodetalle/getbycode"; } } //POST
        public static String urlparametrodetalle_gebydateparam { get { return urlbase + "parametrodetalle/getbydateparam"; } } //POST
        public static String urlparametrodetalle_insert { get { return urlbase + "parametrodetalle/insert"; } } //POST
        public static String urlparametrodetalle_update { get { return urlbase + "parametrodetalle/update"; } } //POST
        public static String urlparametrodetalle_inactive { get { return urlbase + "parametrodetalle/inactive"; } } //POST        
        #endregion


        #region Documento
        public static String urldocumento_getall { get { return urlbase + "documento/getall"; } } //GET
        public static String urldocumento_getbyid { get { return urlbase + "documento/getbyid"; } } //POST
        public static String urldocumento_getbycode { get { return urlbase + "documento/getbycode"; } } //POST
        public static String urldocumento_insert { get { return urlbase + "documento/insert"; } } //POST
        public static String urldocumento_update { get { return urlbase + "documento/update"; } } //POST
        public static String urldocumento_inactive { get { return urlbase + "documento/inactive"; } } //POST
        #endregion


        #region Paquete
        public static String urlpaquete_getall { get { return urlbase + "paquete/getall"; } } //GET
        public static String urlpaquete_getbyid { get { return urlbase + "paquete/getbyid"; } } //POST
        public static String urlpaquete_getbycode { get { return urlbase + "paquete/getbycode"; } } //POST
        public static String urlpaquete_insert { get { return urlbase + "paquete/insert"; } } //POST
        public static String urlpaquete_update { get { return urlbase + "paquete/update"; } } //POST
        public static String urlpaquete_inactive { get { return urlbase + "paquete/inactive"; } } //POST
        #endregion


        #region Barco
        public static String urlbarco_getall { get { return urlbase + "barco/getall"; } } //GET
        public static String urlbarco_getbyid { get { return urlbase + "barco/getbyid"; } } //POST
        public static String urlbarco_getbyidmarina { get { return urlbase + "barco/getbyidmarina"; } } //POST
        public static String urlbarco_getbycode { get { return urlbase + "barco/getbycode"; } } //POST
        public static String urlbarco_insert { get { return urlbase + "barco/insert"; } } //POST
        public static String urlbarco_update { get { return urlbase + "barco/update"; } } //POST
        public static String urlbarco_inactive { get { return urlbase + "barco/inactive"; } } //POST
        #endregion


        #region Marina
        public static String urlmarina_getall { get { return urlbase + "marina/getall"; } } //GET
        public static String urlmarina_getbyid { get { return urlbase + "marina/getbyid"; } } //POST
        public static String urlmarina_getbycode { get { return urlbase + "marina/getbycode"; } } //POST
        public static String urlmarina_insert { get { return urlbase + "marina/insert"; } } //POST
        public static String urlmarina_update { get { return urlbase + "marina/update"; } } //POST
        public static String urlmarina_inactive { get { return urlbase + "marina/inactive"; } } //POST
        #endregion



        #region Barco Destino Marina
        public static String urldestinomarina_getall { get { return urlbase + "barcodestinomarina/getall"; } } //GET
        public static String urldestinomarina_getbyid { get { return urlbase + "barcodestinomarina/getbyid"; } } //POST
        public static String urldestinomarina_getbycode { get { return urlbase + "barcodestinomarina/getbycode"; } } //POST
        public static String urldestinomarina_insert { get { return urlbase + "barcodestinomarina/insert"; } } //POST
        public static String urldestinomarina_update { get { return urlbase + "barcodestinomarina/update"; } } //POST
        public static String urldestinomarina_inactive { get { return urlbase + "barcodestinomarina/inactive"; } } //POST
        #endregion


        #region Propietarios
        public static String urlpropietario_getall { get { return urlbase + "duenobarco/getall"; } } //GET
        public static String urlpropietario_getbyid { get { return urlbase + "duenobarco/getbyid"; } } //POST
        public static String urlpropietario_getbycode { get { return urlbase + "duenobarco/getbycode"; } } //POST
        public static String urlpropietario_insert { get { return urlbase + "duenobarco/insert"; } } //POST
        public static String urlpropietario_update { get { return urlbase + "duenobarco/update"; } } //POST
        public static String urlpropietario_inactive { get { return urlbase + "duenobarco/inactive"; } } //POST
        #endregion


        #region Paquete Precios
        public static String urlpaqueteprecio_getall { get { return urlbase + "preciopaquete/getall"; } } //GET
        public static String urlpaqueteprecio_getbyid { get { return urlbase + "preciopaquete/getbyid"; } } //POST
        public static String urlpaqueteprecio_getbycode { get { return urlbase + "preciopaquete/getbycode"; } } //POST
        public static String urlpaqueteprecio_getbybarcoid { get { return urlbase + "preciopaquete/getbybarcoid"; } } //POST
        public static String urlpaqueteprecio_insert { get { return urlbase + "preciopaquete/insert"; } } //POST
        public static String urlpaqueteprecio_update { get { return urlbase + "preciopaquete/update"; } } //POST
        public static String urlpaqueteprecio_inactive { get { return urlbase + "preciopaquete/inactive"; } } //POST
        #endregion

        #region Concepto
        public static String urlconcepto_getall { get { return urlbase + "concepto/getall"; } } //GET
        public static String urlconccepto_getbyid { get { return urlbase + "concepto/getbyid"; } } //POST
        public static String urlconcepto_getbycode { get { return urlbase + "concepto/getbycode"; } } //POST
        public static String urlconcepto_insert { get { return urlbase + "concepto/insert"; } } //POST
        public static String urlconcepto_update { get { return urlbase + "concepto/update"; } } //POST
        public static String urlconcepto_inactive { get { return urlbase + "concepto/inactive"; } } //POST
        #endregion


        #region Persona Tipo
        public static String urlpersonatipo_getall { get { return urlbase + "personatipo/getall"; } } //GET
        public static String urlpersonatipo_getbyid { get { return urlbase + "personatipo/getbyid"; } } //POST
        public static String urlpersonatipo_getbycode { get { return urlbase + "personatipo/getbycode"; } } //POST
        public static String urlpersonatipo_insert { get { return urlbase + "personatipo/insert"; } } //POST
        public static String urlpersonatipo_update { get { return urlbase + "personatipo/update"; } } //POST
        public static String urlpersonatipo_inactive { get { return urlbase + "personatipo/inactive"; } } //POST
        #endregion


        #region Persona 
        public static String urlpersona_getall { get { return urlbase + "persona/getall"; } } //GET
        public static String urlpersona_getbyid { get { return urlbase + "persona/getbyid"; } } //POST
        public static String urlpersona_getbycode { get { return urlbase + "persona/getbycode"; } } //POST
        public static String urlpersona_getbycellphone { get { return urlbase + "persona/getbycellphone"; } } //POST
        public static String urlpersona_insert { get { return urlbase + "persona/insert"; } } //POST
        public static String urlpersona_update { get { return urlbase + "persona/update"; } } //POST
        public static String urlpersona_inactive { get { return urlbase + "persona/inactive"; } } //POST
        #endregion


        #region Ocupacion
        public static String urlocupacion_getdisponibilidad { get { return urlbase + "ocupacion/getdisponibilidad"; } } //GET
        public static String urlocupacion_insert { get { return urlbase + "ocupacion/insert"; } } //GET
        public static String urlocupacion_getbybarco { get { return urlbase + "ocupacion/getbybarco"; } } //GET
        public static String urlocupacion_getbybarcofecha { get { return urlbase + "ocupacion/getbybarcofecha"; } } //GET
        #endregion



        #region FormaPago 
        public static String urlformapago_getall { get { return urlbase + "formapago/getall"; } } //GET
        public static String urlformapago_getbyid { get { return urlbase + "formapago/getbyid"; } } //POST
        public static String urlformapago_getbycode { get { return urlbase + "formapago/getbycode"; } } //POST
        public static String urlformapago_insert { get { return urlbase + "formapago/insert"; } } //POST
        public static String urlformapago_update { get { return urlbase + "formapago/update"; } } //POST
        public static String urlformapago_inactive { get { return urlbase + "formapago/inactive"; } } //POST
        #endregion

        #region Solicitud
        public static String urlsolicitud_getall { get { return urlbase + "solicitud/getall"; } } //GET
        public static String urlsolicitud_getcountstate2 { get { return urlbase + "solicitud/getcountstate2"; } } //GET
        public static String urlsolicitud_getbyid { get { return urlbase + "solicitud/getbyid"; } } //POST
        public static String urlsolicitud_getbycode { get { return urlbase + "solicitud/getbycode"; } } //POST
        public static String urlsolicitud_insert { get { return urlbase + "solicitud/insert"; } } //POST
        public static String urlsolicitud_update { get { return urlbase + "solicitud/update"; } } //POST
        public static String urlsolicitud_inactive { get { return urlbase + "solicitud/inactive"; } } //POST

        public static String urlsolicitud_getbystate { get { return urlbase + "solicitud/getbystate"; } } //POST
        public static String urlsolicitud_getbydate { get { return urlbase + "solicitud/getbydate"; } } //POST
        public static String urlsolicitud_getbydateclient { get { return urlbase + "solicitud/getbydateclient"; } } //POST
        public static String urlsolicitud_getbybarco { get { return urlbase + "solicitud/getbybarco"; } } //POST
        public static String urlsolicitud_getbyclient { get { return urlbase + "solicitud/getbyclient"; } } //POST
        public static String urlsolicitud_getbyclientall { get { return urlbase + "solicitud/getbyclientall"; } } //POST
        public static String urlsolicitud_getbydatestate { get { return urlbase + "solicitud/getbydatestate"; } } //POST

        #endregion


        #region SolicitudPago
        public static String urlsolicitudpago_getall { get { return urlbase + "solicitudpago/getall"; } } //GET
        public static String urlsolicitudpago_getbyid { get { return urlbase + "solicitudpago/getbyid"; } } //POST
        public static String urlsolicitudpago_getbyidsolicitud { get { return urlbase + "solicitudpago/getbyidsolicitud"; } } //POST
        public static String urlsolicitudpago_getbycode { get { return urlbase + "solicitudpago/getbycode"; } } //POST
        public static String urlsolicitudpago_insert { get { return urlbase + "solicitudpago/insert"; } } //POST
        public static String urlsolicitudpago_update { get { return urlbase + "solicitudpago/update"; } } //POST
        public static String urlsolicitudpago_inactive { get { return urlbase + "solicitudpago/inactive"; } } //POST
        public static String urlsolicitudpago_cancelpaymentid { get { return urlbase + "solicitudpago/cancelpaymentid"; } } //POST
        public static String urlsolicitudpago_cancelpayments { get { return urlbase + "solicitudpago/cancelpayments"; } } //POST
        #endregion



        #region DescuentoCallCenter
        public static String urldescuentocallc_getall { get { return urlbase + "descuentocallcenter/getall"; } } //GET
        public static String urldescuentocallc_getbyid { get { return urlbase + "descuentocallcenter/getbyid"; } } //POST
        public static String urldescuentocallc_getbycode { get { return urlbase + "descuentocallcenter/getbycode"; } } //POST
        public static String urldescuentocallc_insert { get { return urlbase + "descuentocallcenter/insert"; } } //POST
        public static String urldescuentocallc_update { get { return urlbase + "descuentocallcenter/update"; } } //POST
        public static String urldescuentocallc_inactive { get { return urlbase + "descuentocallcenter/inactive"; } } //POST
        #endregion


        #region Descuento Cliente
        public static String urldescuentocliente_getall { get { return urlbase + "descuentocliente/getall"; } } //GET
        public static String urldescuentocliente_getbyid { get { return urlbase + "descuentocliente/getbyid"; } } //POST
        public static String urldescuentocliente_insert { get { return urlbase + "descuentocliente/insert"; } } //POST
        public static String urldescuentocliente_update { get { return urlbase + "descuentocliente/update"; } } //POST
        public static String urldescuentocliente_inactive { get { return urlbase + "descuentocliente/inactive"; } } //POST
        #endregion

         
        #region ObservacionPersona
        public static String urlobservacionpersona_getall { get { return urlbase + "observacionpersona/getall"; } } //GET
        public static String urlobservacionpersona_getbyid { get { return urlbase + "observacionpersona/getbyid"; } } //GET
        public static String urlobservacionpersona_getblistyid { get { return urlbase + "observacionpersona/getbylistid"; } } //POST
        public static String urlobservacionpersona_insert { get { return urlbase + "observacionpersona/insert"; } } //POST
        public static String urlobservacionpersona_update { get { return urlbase + "observacionpersona/update"; } } //POST
        public static String urlobservacionpersona_inactive { get { return urlbase + "observacionpersona/inactive"; } } //POST

        #endregion

        #region Reportes
        public static String urlreportebarcoperiodo_getall { get { return urlbase + "indicadores/getBarcoPeriodo";} } //GET
        public static String urlreportechartersbyagent_getall { get { return urlbase + "indicadores/getchartesallagent";  } } //POST
        public static String urlreportechartersbyclient_getall { get { return urlbase + "indicadores/getchartesbyclient";  } } //POST
        public static String urlreportecharterbyagent { get { return urlbase + "indicadores/getchartesbyagent";  } } //POST
        public static String urlreportechartersbyweek { get { return urlbase + "indicadores/getfeebyweek";  } } //POST
        #endregion


        //#region Detalle Movimiento
        //public static String urldetallemovimiento_getall { get { return urlbase + "detallemovimiento/getall"; } } //GET
        //public static String urldetallemovimiento_getbyid { get { return urlbase + "detallemovimiento/getbyid"; } } //POST
        //public static String urldetallemovimiento_insert { get { return urlbase + "detallemovimiento/insert"; } } //POST
        //public static String urldetallemovimiento_update { get { return urlbase + "detallemovimiento/update"; } } //POST
        //public static String urldetallemovimiento_inactive { get { return urlbase + "detallemovimiento/inactive"; } } //POST
        //public static String urlcreatetransacc { get { return urlbase + "detallemovimiento/createtransacc"; } } //POST

        //#endregion


        //#region Encabezado Movimiento
        //public static String urlencabezadomovimiento_getall { get { return urlbase + "encabezadomovimiento/getall"; } } //GET
        //public static String urlencabezadomovimiento_getbyid { get { return urlbase + "encabezadomovimiento/getbyid"; } } //POST
        //public static String urlencabezadomovimiento_insert { get { return urlbase + "encabezadomovimiento/insert"; } } //POST
        //public static String urlencabezadomovimiento_update { get { return urlbase + "encabezadomovimiento/update"; } } //POST
        //public static String urlencabezadomovimiento_inactive { get { return urlbase + "encabezadomovimiento/inactive"; } } //POST
        //#endregion

        //#region GeneralIva
        //public static String urlgeneraliva_getall { get { return urlbase + "generaliva/getall"; } } //GET
        //public static String urlgeneraliva_getbyid { get { return urlbase + "generaliva/getbyid"; } } //POST
        //public static String urlgeneraliva_insert { get { return urlbase + "generaliva/insert"; } } //POST
        //public static String urlgeneraliva_update { get { return urlbase + "generaliva/update"; } } //POST
        //public static String urlgeneraliva_inactive { get { return urlbase + "generaliva/inactive"; } } //POST
        //#endregion

        //#region Lista
        //public static String urllista_getall { get { return urlbase + "lista/getall"; } } //GET
        //public static String urllista_getbyid { get { return urlbase + "lista/getbyid"; } } //POST
        //public static String urllista_insert { get { return urlbase + "lista/insert"; } } //POST
        //public static String urllista_update { get { return urlbase + "lista/update"; } } //POST
        //public static String urllista_inactive { get { return urlbase + "lista/inactive"; } } //POST
        //#endregion

        //#region Lista Detalle
        //public static String urllistadetalle_getall { get { return urlbase + "listadetalle/getall"; } } //GET
        //public static String urllistadetalle_getbyid { get { return urlbase + "listadetalle/getbyid"; } } //POST
        //public static String urllistadetalle_getbycode { get { return urlbase + "listadetalle/getbycode"; } } //POST
        //public static String urllistadetalle_getbylistid { get { return urlbase + "listadetalle/getbylist"; } } //POST
        //public static String urllistadetalle_insert { get { return urlbase + "listadetalle/insert"; } } //POST
        //public static String urllistadetalle_update { get { return urlbase + "listadetalle/update"; } } //POST
        //public static String urllistadetalle_inactive { get { return urlbase + "listadetalle/inactive"; } } //POST
        //#endregion

        //#region Observacion Movimiento
        //public static String urlobservacionmovimiento_getall { get { return urlbase + "observacionmovimiento/getall"; } } //GET
        //public static String urlobservacionmovimiento_getbyid { get { return urlbase + "observacionmovimiento/getbyid"; } } //POST
        //public static String urlobservacionmovimiento_insert { get { return urlbase + "observacionmovimiento/insert"; } } //POST
        //public static String urlobservacionmovimiento_update { get { return urlbase + "observacionmovimiento/update"; } } //POST
        //public static String urlobservacionmovimiento_inactive { get { return urlbase + "observacionmovimiento/inactive"; } } //POST
        //#endregion



        //#region Presentacion
        //public static String urlpresentacion_getall { get { return urlbase + "presentacion/getall"; } } //GET
        //public static String urlpresentacion_getbyid { get { return urlbase + "presentacion/getbyid"; } } //POST
        //public static String urlpresentacion_getbycode { get { return urlbase + "presentacion/getbycode"; } } //POST
        //public static String urlpresentacion_insert { get { return urlbase + "presentacion/insert"; } } //POST
        //public static String urlpresentacion_update { get { return urlbase + "presentacion/update"; } } //POST
        //public static String urlpresentacion_inactive { get { return urlbase + "presentacion/inactive"; } } //POST
        //#endregion

        //#region Producto
        //public static String urlproducto_getall { get { return urlbase + "producto/getall"; } } //GET
        //public static String urlproducto_getbyid { get { return urlbase + "producto/getbyid"; } } //POST
        //public static String urlproducto_insert { get { return urlbase + "producto/insert"; } } //POST
        //public static String urlproducto_update { get { return urlbase + "producto/update"; } } //POST
        //public static String urlproducto_inactive { get { return urlbase + "producto/inactive"; } } //POST
        //public static String urlproducto_getbycode { get { return urlbase + "producto/getbycode"; } } //POST
        //#endregion

        //#region Producto Categoria
        //public static String urlproductocategoria_getall { get { return urlbase + "productocategoria/getall"; } } //GET
        //public static String urlproductocategoria_getbyid { get { return urlbase + "productocategoria/getbyid"; } } //POST
        //public static String urlproductocategoria_insert { get { return urlbase + "productocategoria/insert"; } } //POST
        //public static String urlproductocategoria_update { get { return urlbase + "productocategoria/update"; } } //POST
        //public static String urlproductocategoria_inactive { get { return urlbase + "productocategoria/inactive"; } } //POST
        //public static String urlproductocategoria_getbycode { get { return urlbase + "productocategoria/getbycode"; } } //POST
        //#endregion






        //#region Saldos

        //public static String urlsaldos_getbyprodid { get { return urlbase + "saldos/getbyprodid"; } } //POST Reibe Saldos_data
        //public static String urlsaldos_getbyprodperiod { get { return urlbase + "saldos/getbyprodperiod"; } } //Post  Reibe Saldos_data

        //#endregion

        //#region Saldo Producto
        //public static String urlsaldoproducto_getall { get { return urlbase + "saldos/getall"; } } //GET
        //public static String urlsaldoproducto_getbyid { get { return urlbase + "saldos/getbyid"; } } //POST
        //public static String urlsaldoproducto_getbycellar { get { return urlbase + "saldos/getbycellar"; } } //POST
        //public static String urlsaldoproducto_getbyprodperiod { get { return urlbase + "saldos/getbyprodperiod"; } } //POST
        //public static String urlsaldoproducto_getbyprodidcellar { get { return urlbase + "saldos/getbyprodidcellar"; } } //POST
        //public static String urlsaldoproducto_insert { get { return urlbase + "saldos/insert"; } } //POST
        //public static String urlsaldoproducto_update { get { return urlbase + "saldos/update"; } } //POST
        //public static String urlsaldoproducto_inactive { get { return urlbase + "saldos/inactive"; } } //POST
        //#endregion

        //#region Tercero
        //public static String urltercero_getall { get { return urlbase + "tercero/getall"; } } //GET
        //public static String urltercero_getbyid { get { return urlbase + "tercero/getbyid"; } } //POST
        //public static String urltercero_getbycode { get { return urlbase + "tercero/getbycode"; } } //POST
        //public static String urltercero_insert { get { return urlbase + "tercero/insert"; } } //POST
        //public static String urltercero_update { get { return urlbase + "tercero/update"; } } //POST
        //public static String urltercero_inactive { get { return urlbase + "tercero/inactive"; } } //POST
        //#endregion

        //#region Tercero Punto
        //public static String urlterceropunto_getall { get { return urlbase + "terceropunto/getall"; } } //GET
        //public static String urlterceropunto_getbyid { get { return urlbase + "terceropunto/getbyid"; } } //POST
        //public static String urlterceropunto_getbytercid { get { return urlbase + "terceropunto/getbytercid"; } } //POST
        //public static String urlterceropunto_getbycode { get { return urlbase + "terceropunto/getbycode"; } } //POST
        //public static String urlterceropunto_insert { get { return urlbase + "terceropunto/insert"; } } //POST
        //public static String urlterceropunto_update { get { return urlbase + "terceropunto/update"; } } //POST
        //public static String urlterceropunto_inactive { get { return urlbase + "terceropunto/inactive"; } } //POST
        //#endregion


        //#region TipoProducto
        //public static String urltipoproducto_getall { get { return urlbase + "tipoproducto/getall"; } } //GET
        //public static String urltipoproducto_getbyid { get { return urlbase + "tipoproducto/getbyid"; } } //POST
        //public static String urltipoproducto_insert { get { return urlbase + "tipoproducto/insert"; } } //POST
        //public static String urltipoproducto_update { get { return urlbase + "tipoproducto/update"; } } //POST
        //public static String urltipoproducto_inactive { get { return urlbase + "tipoproducto/inactive"; } } //POST
        //public static String urltipoproducto_getbycode { get { return urlbase + "tipoproducto/getbycode"; } } //POST
        //#endregion    

        //#region Transaccion
        //public static String urltransaccion_gettransacc { get { return urlbase + "detallemovimiento/gettransaccc"; } } //GET
        //public static String urltransaccion_gettransaccbyitem { get { return urlbase + "detallemovimiento/gettransaccbyitem"; } } //POST
        //public static String urltransaccion_gettransaccprodiddatecellar { get { return urlbase + "detallemovimiento/gettransaccprodiddatecellar"; } } //POST
        //public static String urltransaccion_getbyfecha { get { return urlbase + "detallemovimiento/gettransaccbyfecha"; } } //POST
        //#endregion

        //#region Ubicacion
        //public static String urlubicacion_getall { get { return urlbase + "ubicacion/getall"; } } //GET
        //public static String urlubicacion_getbyid { get { return urlbase + "ubicacion/getbyid"; } } //POST
        //public static String urlubicacion_getbycode { get { return urlbase + "ubicacion/getbycode"; } } //POST
        //public static String urlubicacion_insert { get { return urlbase + "ubicacion/insert"; } } //POST
        //public static String urlubicacion_update { get { return urlbase + "ubicacion/update"; } } //POST
        //public static String urlubicacion_inactive { get { return urlbase + "ubicacion/inactive"; } } //POST
        //#endregion

        //#region Usuario
        //public static String urlusuario_getall { get { return urlbase + "users/getusers"; } } //GET
        //public static String urlusuario_getbycode { get { return urlbase + "users/getbyusername"; } } //POST
        //public static String urlusuario_insert { get { return urlbase + "account/create"; } } //POST
        //public static String urlusuario_update { get { return urlbase + "account/create"; } } //POST
        //public static String urlusuario_inactive { get { return urlbase + "users/inactive"; } } //POST
        //#endregion

        //#region Transportadora
        //public static String urltransportadora_getall { get { return urlbase + "transportadora/getall"; } } //GET
        //public static String urltransportadora_getbycode { get { return urlbase + "transportadora/getbycode"; } } //POST
        //public static String urltransportadora_getbyid { get { return urlbase + "transportadora/getbyid"; } } //POST
        //public static String urltransportadora_insert { get { return urlbase + "transportadora/insert"; } } //POST
        //public static String urltransportadora_update { get { return urlbase + "transportadora/update"; } } //POST
        //public static String urltransportadora_inactive { get { return urlbase + "transportadora/inactive"; } } //POST
        //#endregion









    }
}
