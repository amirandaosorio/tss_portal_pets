//using Blazored.Modal;
//using Blazored.Modal.Services;
//using miami_nautical_portal.Data.Request;
//using miami_nautical_portal.Pages.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http.Json;
//using miami_nautical_portal.Data.Personal;
using Microsoft.AspNetCore.Components;
//using miami_nautical_portal.Data.Personal;
//using Newtonsoft.Json;
//using miami_nautical_portal.Data.Send;
//using static miami_nautical_portal.Pages.Seguimiento.SeguimientoIndex;
using portal_pets.Data.Personal;

namespace portal_pets.ClasPersonal
{
    public static class General
    {

        public static infoBrowser userLogueado { get; set; }
        public static List<infoMenu> _retMenu { get; set; }
        public static List<infoRoles> _retRol { get; set; }
        public static String _mensajeIsDanger { get; set; } = "alert-danger";

        ///// <summary>
        ///// Metodo que muestra una ventana emergente para mostrar mensajes o confirmaciones
        ///// </summary>
        ///// <param name="_titulo">Es el titulo que se muestra en la ventana</param>
        ///// <param name="_mensaje">Es el contenido de la ventana. Si son varias lineas se debe escribir &s para que 
        /////                        realice un saldo de linea.
        ///// </param>
        ///// <param name="_modal"> Es el servicio ImodalService que se necesita para que la ventana sea emergente</param>
        ///// <returns></returns>
        //public static async Task MensajeModal(String _titulo, String _mensaje, IModalService _modal, NavigationManager _nav, String url = "")
        //{
        //    var parameters = new ModalParameters();
        //    parameters.Add(nameof(ModalMensaje.titulo), _titulo);
        //    parameters.Add(nameof(ModalMensaje.contenido), _mensaje);
        //    var formModal = _modal.Show<ModalMensaje>("", parameters);
        //    var result = await formModal.Result;
        //    if (!result.Cancelled &&  url.Trim().Length>0)
        //    {
        //        if(url.Trim().Length>0)
        //            _nav.NavigateTo(url, true);
        //    }
        //}

        //public static async Task<List<Rol_data>> cargaRoles(RolesRequest _request, infoBrowser _dataStorage, String _urlgetall)
        //{
        //    List<Rol_data> _lista = new List<Rol_data>();
        //    var resultado = await General.solicitudUrl<String>(_dataStorage.user.token, "POST", _urlgetall, "");
        //    _request = JsonConvert.DeserializeObject<RolesRequest>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //    if (_request != null && _request.entities != null && _request.entities.Count > 0)
        //        _lista = _request.entities;
        //    return _lista;
        //}

        //public static async Task<List<GraficoCharterByAgent_data>> graficoAgenteCharters(DateTime? startDate, DateTime? endDate, infoBrowser _dataStorage, String _urlgetall)
        //{
        //    GraficoChartersAgent _request = new GraficoChartersAgent();
        //    GraficoSend _registro = new GraficoSend();

        //    _registro.initialdate = startDate;
        //    _registro.enddate = endDate;
        //    _registro.idinput = "";

        //    List<GraficoCharterByAgent_data> _lista = new List<GraficoCharterByAgent_data>();
        //    var resultado = await General.solicitudUrl<GraficoSend>(_dataStorage.user.token, "POST", _urlgetall, _registro);
        //    _request = JsonConvert.DeserializeObject<GraficoChartersAgent>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //    if (_request != null && _request.entities != null && _request.entities.Count > 0)
        //        _lista = _request.entities;
        //    return _lista;
        //}

        //public static async Task<List<Documento_data>> cargaDocumentos(DocumentosRequest _request, infoBrowser _dataStorage, String _urlgetall)
        //{
        //    List<Documento_data> _lista = new List<Documento_data>();
        //    var resultado = await General.solicitudUrl<String>(_dataStorage.user.token, "GET", _urlgetall, "");
        //    _request = JsonConvert.DeserializeObject<DocumentosRequest>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //    if (_request != null && _request.entities != null && _request.entities.Count > 0)
        //        _lista = _request.entities;
        //    return _lista;
        //}


        //public static async Task<List<Concepto_data>> cargaConceptos(ConceptosRequest _request, infoBrowser _dataStorage, String _urlgetall)
        //{
        //    List<Concepto_data> _lista = new List<Concepto_data>();
        //    var resultado = await General.solicitudUrl<String>(_dataStorage.user.token, "GET", _urlgetall, "");
        //    _request = JsonConvert.DeserializeObject<ConceptosRequest>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //    if (_request != null && _request.entities != null && _request.entities.Count > 0)
        //        _lista = _request.entities;
        //    return _lista;
        //}



        //public static async Task<List<vBarco_data>> cargaBarcos(BarcosRequest _request, infoBrowser _dataStorage, String _urlgetall)
        //{
        //    List<vBarco_data> _lista = new List<vBarco_data>();
        //    var resultado = await General.solicitudUrl<String>(_dataStorage.user.token, "GET", _urlgetall, "");
        //    _request = JsonConvert.DeserializeObject<BarcosRequest>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //    if (_request != null && _request.entities != null && _request.entities.Count > 0)
        //        _lista = _request.entities;
        //    return _lista;
        //} 


        //public static async Task<List<Marina_data>> cargaMarinas(MarinasRequest _request, infoBrowser _dataStorage, String _urlgetall)
        //{
        //    List<Marina_data> _lista = new List<Marina_data>();
        //    var resultado = await General.solicitudUrl<String>(_dataStorage.user.token, "GET", _urlgetall, "");
        //    _request = JsonConvert.DeserializeObject<MarinasRequest>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //    if (_request != null && _request.entities != null && _request.entities.Count > 0)
        //        _lista = _request.entities;
        //    return _lista;
        //}

        //public static async Task<List<DestinoMarina_data>> cargaDestinosMarina(DestinosMarinaRequest _request, infoBrowser _dataStorage, String _urlgetall)
        //{
        //    List<DestinoMarina_data> _lista = new List<DestinoMarina_data>();
        //    var resultado = await General.solicitudUrl<String>(_dataStorage.user.token, "GET", _urlgetall, "");
        //    _request = JsonConvert.DeserializeObject<DestinosMarinaRequest>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //    if (_request != null && _request.entities != null && _request.entities.Count > 0)
        //        _lista = _request.entities;
        //    return _lista;
        //}


        //public static async Task<List<Propietario_data>> cargaPropietarios(PropietariosRequest _request, infoBrowser _dataStorage, String _urlgetall)
        //{
        //    List<Propietario_data> _lista = new List<Propietario_data>();
        //    var resultado = await General.solicitudUrl<String>(_dataStorage.user.token, "GET", _urlgetall, "");
        //    _request = JsonConvert.DeserializeObject<PropietariosRequest>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //    if (_request != null && _request.entities != null && _request.entities.Count > 0)
        //        _lista = _request.entities;
        //    return _lista;
        //}



        //public static async Task<List<Paquete_data>> cargaPaquetes(PaquetesRequest _request, infoBrowser _dataStorage, String _urlgetall)
        //{
        //    List<Paquete_data> _lista = new List<Paquete_data>();
        //    var resultado = await General.solicitudUrl<String>(_dataStorage.user.token, "GET", _urlgetall, "");
        //    _request = JsonConvert.DeserializeObject<PaquetesRequest>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //    if (_request != null && _request.entities != null && _request.entities.Count > 0)
        //        _lista = _request.entities;
        //    return _lista;
        //}


        //public static async Task<List<PaquetePrecio_data>> cargaPaquetesPrecio(PaquetesPrecioRequest _request, infoBrowser _dataStorage, String _urlgetall)
        //{
        //    List<PaquetePrecio_data> _lista = new List<PaquetePrecio_data>();
        //    try
        //    {
        //        var resultado = await General.solicitudUrl<String>(_dataStorage.user.token, "GET", _urlgetall, "");
        //        _request = JsonConvert.DeserializeObject<PaquetesPrecioRequest>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //        if (_request != null && _request.entities != null && _request.entities.Count > 0)
        //            _lista = _request.entities;
        //    }
        //    catch (Exception ex) { }
        //    return _lista;
        //}

        //public class paquetepreciobarco
        //{
        //    public Int64 barcoid { get; set; }
        //}
        //public static async Task<List<PaquetePrecio_data>> cargaPaquetesPrecioBarco(PaquetesPrecioRequest _request, infoBrowser _dataStorage, String _urlgetall, Int64 _id)
        //{
        //    List<PaquetePrecio_data> _lista = new List<PaquetePrecio_data>();
        //    try
        //    {
        //        paquetepreciobarco dato = new paquetepreciobarco();
        //        dato.barcoid = _id;
        //        var resultado = await General.solicitudUrl<paquetepreciobarco>(_dataStorage.user.token, "POST", _urlgetall, dato);
        //        _request = JsonConvert.DeserializeObject<PaquetesPrecioRequest>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //        if (_request != null && _request.entities != null && _request.entities.Count > 0)
        //            _lista = _request.entities;
        //    }
        //    catch (Exception ex) { }
        //    return _lista;
        //}

        //public static async Task<List<Persona_data>> cargaPersonas(PersonasRequest _request, infoBrowser _dataStorage, String _urlgetall)
        //{
        //    List<Persona_data> _lista = new List<Persona_data>();
        //    var resultado = await General.solicitudUrl<String>(_dataStorage.user.token, "GET", _urlgetall, "");
        //    _request = JsonConvert.DeserializeObject<PersonasRequest>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //    if (_request != null && _request.entities != null && _request.entities.Count > 0)
        //        _lista = _request.entities;
        //    if (_lista.Count > 0)
        //    {
        //        PersonasTipoRequest _reqTipo = new PersonasTipoRequest();
        //        List<PersonaTipo_data> _listaTipo = await cargaPersonasTipo(_reqTipo, _dataStorage, Urls.urlpersonatipo_getall);
        //        foreach(var reg in _lista)
        //        {
        //            reg.tipoPersona = "";
        //            if (_listaTipo != null && _listaTipo.Count > 0) 
        //            {
        //                foreach (var tipo in _listaTipo.Where(w=>w.personaid==reg.id))
        //                {
        //                    reg.tipoPersona += tipo.persontype.Trim() + ",";
        //                }
        //            }
        //        }
        //    }
        //    return _lista;
        //}
         
        //public static async Task<List<PersonaTipo_data>> cargaPersonasTipo(PersonasTipoRequest _request, infoBrowser _dataStorage, String _urlgetall)
        //{
        //    List<PersonaTipo_data> _lista = new List<PersonaTipo_data>();
        //    var resultado = await General.solicitudUrl<String>(_dataStorage.user.token, "GET", _urlgetall, "");
        //    _request = JsonConvert.DeserializeObject<PersonasTipoRequest>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //    if (_request != null && _request.entities != null && _request.entities.Count > 0)
        //        _lista = _request.entities;
        //    return _lista;
        //}

        //public static async Task<List<FormaPago_data>> cargaFormaPago(FormasPagoRequest _request, infoBrowser _dataStorage, String _urlgetall)
        //{
        //    List<FormaPago_data> _lista = new List<FormaPago_data>();
        //    var resultado = await General.solicitudUrl<String>(_dataStorage.user.token, "GET", _urlgetall, "");
        //    _request = JsonConvert.DeserializeObject<FormasPagoRequest>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //    if (_request != null && _request.entities != null && _request.entities.Count > 0)
        //        _lista = _request.entities;
        //    return _lista;
        //}
        //public static async Task<List<Solicitud_data>> cargaSolicitudAll(SolicitudesRequest _request, infoBrowser _dataStorage, String _urlgetall)
        //{
        //    List<Solicitud_data> _lista = new List<Solicitud_data>();
        //    var resultado = await General.solicitudUrl<String>(_dataStorage.user.token, "GET", _urlgetall, "");
        //    _request = JsonConvert.DeserializeObject<SolicitudesRequest>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //    if (_request != null && _request.entities != null && _request.entities.Count > 0)
        //        _lista = _request.entities;
        //    return _lista;
        //} 

        //public static async Task<List<Solicitud_data>> cargaSolicitudbyDato(SolicitudesRequest _request, infoBrowser _dataStorage, String _urlgetall, SolicitudBarcoFecha _reg = null, SolicitudFechaState _regState = null, SolicitudFechaClient _regClient = null )
        //{            
        //    //List<Solicitud_data> _lista = new List<Solicitud_data>();
        //    //var resultado = await General.solicitudUrl<Solicitud_data>(_dataStorage.user.token, "POST", _urlgetall, _reg);
        //    List<Solicitud_data> _lista = new List<Solicitud_data>();
        //    if (_reg != null)
        //    {
        //        var resultado = await General.solicitudUrl<SolicitudBarcoFecha>(_dataStorage.user.token, "POST", _urlgetall, _reg);
        //        _request = JsonConvert.DeserializeObject<SolicitudesRequest>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //    } else if (_regState != null)
        //    {
        //        var resultado = await General.solicitudUrl<SolicitudFechaState>(_dataStorage.user.token, "POST", _urlgetall, _regState);
        //        _request = JsonConvert.DeserializeObject<SolicitudesRequest>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //    } else if (_regClient != null)
        //    {
        //        var resultado = await General.solicitudUrl<SolicitudFechaClient>(_dataStorage.user.token, "POST", _urlgetall, _regClient);
        //        _request = JsonConvert.DeserializeObject<SolicitudesRequest>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //    }

        //    if (_request != null && _request.entities != null && _request.entities.Count > 0)
        //        _lista = _request.entities;
        //    return _lista;
        //}



        //public static async Task<List<ParametroDetalle_data>> cargaParametroDetalle(ParametroDetallesRequest _request, infoBrowser _dataStorage, String _urlgetall)
        //{
        //    List<ParametroDetalle_data> _lista = new List<ParametroDetalle_data>();
        //    var resultado = await General.solicitudUrl<String>(_dataStorage.user.token, "GET", _urlgetall, "");
        //    _request = JsonConvert.DeserializeObject<ParametroDetallesRequest>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //    if (_request != null && _request.entities != null && _request.entities.Count > 0)
        //        _lista = _request.entities;
        //    return _lista;
        //}

        //public static async Task<String> getParamUrlContrato(infoBrowser _dataStorage)
        //{
        //    String retorno = "";
        //    ParametroDetalle_data registro = new ParametroDetalle_data();
        //    try{
        //        registro.nameparam = "URLCONTRATO";
        //        registro.initialdate = registro.enddate = DateTime.Now.Date;
        //        ResponsRequestString _reqResp = new ResponsRequestString();

        //        var resultado = await General.solicitudUrl<ParametroDetalle_data>(_dataStorage.user.token, "POST", Urls.urlparametrodetalle_gebydateparam, registro);
        //        _reqResp = JsonConvert.DeserializeObject<ResponsRequestString>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //        if (_reqResp != null && _reqResp.entity.Trim().Length > 0)
        //            retorno = _reqResp.entity.Trim();
        //    }
        //    catch(Exception ex) { }
        //    return retorno;
        //}

        ////
        //public static async Task<List<rBarcoPeriodo>> cargaBarcoPeriodo(vGetBarcoPeriodoRequest _request, infoBrowser _dataStorage, String _urlgetall)
        //{
        //    List<rBarcoPeriodo> _lista = new List<rBarcoPeriodo>();

        //    var resultado = await General.solicitudUrl<List<rBarcoPeriodo>>(_dataStorage.user.token, "GET", _urlgetall, _lista);
        //    _request = JsonConvert.DeserializeObject<vGetBarcoPeriodoRequest>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //    if (_request != null && _request.entities != null && _request.entities.Count > 0)
        //        _lista = _request.entities;
        //    return _lista;
        //}



        ////urlrolusuaio_byrol
        //public static async Task<String> getParamPies(infoBrowser _dataStorage, String _name)
        //{
        //    String retorno = "0";
        //    ParametroDetalle_data registro = new ParametroDetalle_data();
        //    try
        //    {
        //        registro.nameparam = _name;
        //        registro.initialdate = registro.enddate = DateTime.Now.Date;
        //        ResponsRequestString _reqResp = new ResponsRequestString();

        //        var resultado = await General.solicitudUrl<ParametroDetalle_data>(_dataStorage.user.token, "POST", Urls.urlparametrodetalle_gebydateparam, registro);
        //        _reqResp = JsonConvert.DeserializeObject<ResponsRequestString>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //        if (_reqResp != null && _reqResp.entity.Trim().Length > 0)
        //            retorno = _reqResp.entity.Trim();
        //    }
        //    catch (Exception ex) { }
        //    return retorno;
        //}


        ////urlrolusuario_byrol
        //public static async Task<List<DescuentoCallCenter_data>> cargaDescuentoCall(DescuentosCallCenterRequest _request, infoBrowser _dataStorage, String _urlgetall)
        //{
        //    List<DescuentoCallCenter_data> _lista = new List<DescuentoCallCenter_data>();
        //    var resultado = await General.solicitudUrl<String>(_dataStorage.user.token, "GET", _urlgetall, "");
        //    _request = JsonConvert.DeserializeObject<DescuentosCallCenterRequest>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //    if (_request != null && _request.entities != null && _request.entities.Count > 0)
        //        _lista = _request.entities;
        //    return _lista;
        //}

        //public static async Task<List<Usuario_data>> getUsuariosbyRol(UsuariosRequest _request, infoBrowser _dataStorage, String _urlgetall, String _nameRol)
        //{
        //    List<Usuario_data> _lista = new List<Usuario_data>();
        //    Rol_data _registro = new Rol_data();
        //    _registro.name = _nameRol;
        //    var resultado = await General.solicitudUrl<Rol_data>(_dataStorage.user.token, "POST", _urlgetall, _registro);
        //    _request = JsonConvert.DeserializeObject<UsuariosRequest>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //    if (_request != null && _request.entities != null && _request.entities.Count > 0)
        //        _lista = _request.entities;
        //    return _lista;
        //}

        //public static async Task<Int32> getParamPorcTax(infoBrowser _dataStorage)
        //{
        //    Int32 retorno = 0;
        //    ParametroDetalle_data registro = new ParametroDetalle_data();
        //    try
        //    {
        //        registro.nameparam = "IMPUESTO";
        //        registro.initialdate = registro.enddate = DateTime.Now;
        //        String _req = "";
        //        var resultado = await General.solicitudUrl<ParametroDetalle_data>(_dataStorage.user.token, "POST", Urls.urlparametrodetalle_gebydateparam, registro);
        //        _req = JsonConvert.DeserializeObject<String>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //        if (_req != null && _req.Trim().Length > 0)
        //            retorno = Convert.ToInt32(_req);
        //    }
        //    catch { retorno = 0; }
        //    return retorno;
        //}


        //public static Int32 getEstadoValue(String _name)
        //{
        //    Int32 retorno = 0;
        //    foreach (int i in Enum.GetValues(typeof(EnumEstados)))
        //    {
        //        if (_name.Trim().ToUpper() == Enum.GetName(typeof(EnumEstados), i))
        //            retorno = i;
        //    }
        //    return retorno;
        //}



        //public static async Task<Boolean> validaHoras(Int64 _barco, DateTime _fecha, Int32 _horaini, Int32 _tiempo, infoBrowser _userLogueado)
        //{
        //    Boolean retorno = true;
        //    try
        //    {
        //        //Obtenemos la Ocupacion
        //        List<Disponibilidad_data> _listDisponible = new List<Disponibilidad_data>();
        //        Ocupacion_data _registro = new Ocupacion_data();
        //        _registro.date = _fecha;
        //        _registro.idbarco = _registro.barcoid = _barco;
        //        DisponibilidadRequest _request = new DisponibilidadRequest();
        //        var resultado = await General.solicitudUrl<Ocupacion_data>(_userLogueado.user.token, "POST", Urls.urlocupacion_getbybarcofecha, _registro);
        //        _request = JsonConvert.DeserializeObject<DisponibilidadRequest>(resultado.Content.ReadAsStringAsync().Result.ToString());
        //        if (_request != null && _request.entities != null && _request.entities.Count > 0)
        //            _listDisponible = _request.entities;
        //        if (_listDisponible != null && _listDisponible.Count > 0)
        //        {
        //            _listDisponible = _listDisponible.Where(w => w.id == _barco).ToList();
        //            if (_listDisponible != null && _listDisponible.Count > 0)
        //            {
        //                Int32 p = _horaini;
        //                Int32 contador = 1;
        //                do
        //                {
        //                    retorno = _listDisponible[p].ocupado;
        //                    p++;
        //                    contador++;
        //                } while (!retorno && contador<=_tiempo);
        //                retorno = !retorno;
        //            }
        //        }
        //    }
        //    catch (Exception ex) { retorno = false; }
        //    return retorno;
        //}

        //public static bool ValidatePassword(string password)
        //{
        //    const int MIN_LENGTH = 8;
        //    const int MAX_LENGTH = 15;
        //    String symbol = "*+-/.=(){}[]&$";

        //    if (password == null) throw new ArgumentNullException();

        //    bool meetsLengthRequirements = password.Length >= MIN_LENGTH && password.Length <= MAX_LENGTH;
        //    bool hasUpperCaseLetter = false;
        //    bool hasLowerCaseLetter = false;
        //    bool hasDecimalDigit = false;
        //    bool hasSigno = false;

        //    if (meetsLengthRequirements)
        //    {
        //        foreach (char c in password)
        //        {
        //            if (char.IsUpper(c)) hasUpperCaseLetter = true;
        //            else if (char.IsLower(c)) hasLowerCaseLetter = true;
        //            else if (char.IsDigit(c)) hasDecimalDigit = true;
        //            else if (symbol.Contains(c)) hasSigno = true;
        //        }
        //    }

        //    bool isValid = meetsLengthRequirements && hasUpperCaseLetter && hasLowerCaseLetter && hasDecimalDigit  && hasSigno ;
        //    return isValid;
        //}


        //public static async Task<HttpResponseMessage> solicitudUrl<T>(String _token, String _metodo, String _url, T _datos)
        //{
        //    HttpResponseMessage response = new HttpResponseMessage();
        //    try
        //    {
        //        using (var solicitud = new HttpClient())
        //        {
        //            if (_token.Trim().Length > 0)
        //                solicitud.DefaultRequestHeaders.Add("Authorization", $"Bearer {_token}");
        //            solicitud.BaseAddress = new Uri(_url);
        //            switch (_metodo)
        //            {
        //                case "POST":
        //                    if (_datos == null)
        //                        response = await solicitud.PostAsync("", null);
        //                    else
        //                        response = await solicitud.PostAsJsonAsync("", _datos);
        //                    break;
        //                case "GET":
        //                    response = await solicitud.GetAsync("");
        //                    break;
        //                case "PATCH":
        //                    response = await solicitud.PatchAsync("", null);
        //                    break;
        //            }

        //        }
        //    }catch(Exception ex)
        //    {
        //    }
        //    return response;
        //}


        //public static async Task organizaMenu(List<Permission> _menu)
        //{
        //    if(_menu!=null && _menu.Count > 0)
        //    {
        //        _retMenu = new List<infoMenu>();
        //        _retRol = new List<infoRoles>();
        //        foreach( var reg in _menu.Where(w=>w.option.Trim().Length>0).GroupBy(g=> g.code))
        //        {
        //            infoMenu nuevo = new infoMenu();
        //            nuevo.code = reg.Key;
        //            nuevo.icono = reg.FirstOrDefault().icono;
        //            nuevo.id = reg.FirstOrDefault().id;
        //            nuevo.idparent = reg.FirstOrDefault().idparent;
        //            nuevo.type = reg.FirstOrDefault().type;
        //            nuevo.url = reg.FirstOrDefault().url;
        //            nuevo.option = reg.FirstOrDefault().option;
        //            nuevo.state = _menu.Any(w => w.code == reg.Key && w.state == 1) ? 1 : 0;
        //            nuevo.permission = _menu.Any(w => w.code == reg.Key && w.permission.Substring(0, 1) == "1") ? "1" : "0";
        //            nuevo.permission += _menu.Any(w => w.code == reg.Key && w.permission.Substring(1, 1) == "1") ? "1" : "0";
        //            nuevo.permission += _menu.Any(w => w.code == reg.Key && w.permission.Substring(2, 1) == "1") ? "1" : "0";
        //            nuevo.permission += _menu.Any(w => w.code == reg.Key && w.permission.Substring(3, 1) == "1") ? "1" : "0";                    
        //            _retMenu.Add(nuevo);
        //        }
        //        foreach (var reg in _menu.GroupBy(g => new { rol = g.rol, user = g.user }))
        //        {
        //            infoRoles nuevo = new infoRoles();
        //            nuevo.user = reg.Key.user;
        //            nuevo.rol = reg.Key.rol;
        //            _retRol.Add(nuevo);
        //        }
        //    }
        //}


    }
}
