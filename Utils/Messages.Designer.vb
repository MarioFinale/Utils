﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System


'StronglyTypedResourceBuilder generó automáticamente esta clase
'a través de una herramienta como ResGen o Visual Studio.
'Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
'con la opción /str o recompile su proyecto de VS.
'''<summary>
'''  Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
 Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
 Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
Friend Class Messages
    
    Private Shared resourceMan As Global.System.Resources.ResourceManager
    
    Private Shared resourceCulture As Global.System.Globalization.CultureInfo
    
    <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
    Friend Sub New()
        MyBase.New
    End Sub
    
    '''<summary>
    '''  Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
    '''</summary>
    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
        Get
            If Object.ReferenceEquals(resourceMan, Nothing) Then
                Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Utils.Messages", GetType(Messages).Assembly)
                resourceMan = temp
            End If
            Return resourceMan
        End Get
    End Property
    
    '''<summary>
    '''  Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
    '''  búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
    '''</summary>
    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
        Get
            Return resourceCulture
        End Get
        Set
            resourceCulture = value
        End Set
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Filtro de abusos desencadenado en &apos;{0}&apos;..
    '''</summary>
    Friend Shared ReadOnly Property AbuseFilter() As String
        Get
            Return ResourceManager.GetString("AbuseFilter", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a MWBot.net.
    '''</summary>
    Friend Shared ReadOnly Property BotEngine() As String
        Get
            Return ResourceManager.GetString("BotEngine", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Verificando al usuario &apos;{0}&apos;..
    '''</summary>
    Friend Shared ReadOnly Property CheckingUser() As String
        Get
            Return ResourceManager.GetString("CheckingUser", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Comprobando usuarios..
    '''</summary>
    Friend Shared ReadOnly Property CheckingUsers() As String
        Get
            Return ResourceManager.GetString("CheckingUsers", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Archivo de configuraciones corrupto..
    '''</summary>
    Friend Shared ReadOnly Property ConfigError() As String
        Get
            Return ResourceManager.GetString("ConfigError", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Edición de bot..
    '''</summary>
    Friend Shared ReadOnly Property DefaultSumm() As String
        Get
            Return ResourceManager.GetString("DefaultSumm", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Hecho, retornando {0} páginas..
    '''</summary>
    Friend Shared ReadOnly Property DoneXPagesReturned() As String
        Get
            Return ResourceManager.GetString("DoneXPagesReturned", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Conflicto de edición en &apos;{0}&apos;..
    '''</summary>
    Friend Shared ReadOnly Property EditConflict() As String
        Get
            Return ResourceManager.GetString("EditConflict", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Error al crear el archivo &apos;{0}&apos;..
    '''</summary>
    Friend Shared ReadOnly Property FileCreateErr() As String
        Get
            Return ResourceManager.GetString("FileCreateErr", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Error al guardar el archivo &apos;{0}&apos;..
    '''</summary>
    Friend Shared ReadOnly Property FileSaveErr() As String
        Get
            Return ResourceManager.GetString("FileSaveErr", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Obteniendo el ultimo revid de {0} páginas..
    '''</summary>
    Friend Shared ReadOnly Property GetLastrevIDs() As String
        Get
            Return ResourceManager.GetString("GetLastrevIDs", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Cargando el extracto de la página &apos;{0}&apos;..
    '''</summary>
    Friend Shared ReadOnly Property GetPageExtract() As String
        Get
            Return ResourceManager.GetString("GetPageExtract", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Cargando {0} extractos de páginas..
    '''</summary>
    Friend Shared ReadOnly Property GetPagesExtract() As String
        Get
            Return ResourceManager.GetString("GetPagesExtract", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a ==================== MWBot.net {0} ====================.
    '''</summary>
    Friend Shared ReadOnly Property GreetingMsg() As String
        Get
            Return ResourceManager.GetString("GreetingMsg", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a La url ingresada es inválida.
    '''</summary>
    Friend Shared ReadOnly Property InvalidUrl() As String
        Get
            Return ResourceManager.GetString("InvalidUrl", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a El usuario &apos;{0}&apos; es inválido..
    '''</summary>
    Friend Shared ReadOnly Property InvalidUser() As String
        Get
            Return ResourceManager.GetString("InvalidUser", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Cargando configuraciones.
    '''</summary>
    Friend Shared ReadOnly Property LoadingConfig() As String
        Get
            Return ResourceManager.GetString("LoadingConfig", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Cargando puntaje ORES del revid {0}..
    '''</summary>
    Friend Shared ReadOnly Property LoadingOres() As String
        Get
            Return ResourceManager.GetString("LoadingOres", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Falló el inicio de sesión.
    '''</summary>
    Friend Shared ReadOnly Property LoginError() As String
        Get
            Return ResourceManager.GetString("LoginError", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a ID de usuario: .
    '''</summary>
    Friend Shared ReadOnly Property LoginID() As String
        Get
            Return ResourceManager.GetString("LoginID", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Resultado: .
    '''</summary>
    Friend Shared ReadOnly Property LoginResult() As String
        Get
            Return ResourceManager.GetString("LoginResult", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Máximo número de reintentos alcanzado en &apos;{0}&apos;..
    '''</summary>
    Friend Shared ReadOnly Property MaxRetryCount() As String
        Get
            Return ResourceManager.GetString("MaxRetryCount", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Error de conexión: .
    '''</summary>
    Friend Shared ReadOnly Property NetworkError() As String
        Get
            Return ResourceManager.GetString("NetworkError", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Nombre de la página de la plantilla de &apos;caja de archivos&apos; (con el espacio de nombres):.
    '''</summary>
    Friend Shared ReadOnly Property NewArchiveBoxTemplate() As String
        Get
            Return ResourceManager.GetString("NewArchiveBoxTemplate", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Nombre de la página de aviso de archivo (con el espacio de nombres):.
    '''</summary>
    Friend Shared ReadOnly Property NewArchiveMessageTemplate() As String
        Get
            Return ResourceManager.GetString("NewArchiveMessageTemplate", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Nombre de la página de la plantilla &apos;no archivar&apos; (con el espacio de nombres):.
    '''</summary>
    Friend Shared ReadOnly Property NewAutoArchiveDoNotArchivePageName() As String
        Get
            Return ResourceManager.GetString("NewAutoArchiveDoNotArchivePageName", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Nombre de la página de la plantilla de autoarchivado programado (con el espacio de nombres):.
    '''</summary>
    Friend Shared ReadOnly Property NewAutoArchiveProgrammedArchivePageName() As String
        Get
            Return ResourceManager.GetString("NewAutoArchiveProgrammedArchivePageName", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Nombre de la página de la plantilla de autoarchivado (con el espacio de nombres):.
    '''</summary>
    Friend Shared ReadOnly Property NewAutoArchiveTemplatePagename() As String
        Get
            Return ResourceManager.GetString("NewAutoArchiveTemplatePagename", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Nombre de la página de la plantilla de autofirmado (con el espacio de nombres):.
    '''</summary>
    Friend Shared ReadOnly Property NewAutoSignatureTemplatePageName() As String
        Get
            Return ResourceManager.GetString("NewAutoSignatureTemplatePageName", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Nombre del bot: .
    '''</summary>
    Friend Shared ReadOnly Property NewBotName() As String
        Get
            Return ResourceManager.GetString("NewBotName", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Contraseña de BOT en la Wiki: .
    '''</summary>
    Friend Shared ReadOnly Property NewBotPassword() As String
        Get
            Return ResourceManager.GetString("NewBotPassword", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Error al crear un nuevo archivo de configuraciones.
    '''</summary>
    Friend Shared ReadOnly Property NewConfigFileError() As String
        Get
            Return ResourceManager.GetString("NewConfigFileError", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a El archivo de configuraciones no existe, por favor completa los siguientes campos o cierra el programa y crea el archivo manualmente..
    '''</summary>
    Friend Shared ReadOnly Property NewConfigMessage() As String
        Get
            Return ResourceManager.GetString("NewConfigMessage", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Nombre de usuario en la Wiki: .
    '''</summary>
    Friend Shared ReadOnly Property NewUserName() As String
        Get
            Return ResourceManager.GetString("NewUserName", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a URL de la API de la Wiki: .
    '''</summary>
    Friend Shared ReadOnly Property NewWikiMainApiUrl() As String
        Get
            Return ResourceManager.GetString("NewWikiMainApiUrl", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a URL principal de la Wiki: .
    '''</summary>
    Friend Shared ReadOnly Property NewWikiMainUrl() As String
        Get
            Return ResourceManager.GetString("NewWikiMainUrl", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Este bot no puede editar en &apos;{0}&apos;..
    '''</summary>
    Friend Shared ReadOnly Property NoBots() As String
        Get
            Return ResourceManager.GetString("NoBots", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a No hay cambios por guardar en &apos;{0}&apos;..
    '''</summary>
    Friend Shared ReadOnly Property NoChanges() As String
        Get
            Return ResourceManager.GetString("NoChanges", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a El archivo de configuraciones no existe.
    '''</summary>
    Friend Shared ReadOnly Property NoConfigFile() As String
        Get
            Return ResourceManager.GetString("NoConfigFile", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a No se ha encontrado texto con formato de fecha..
    '''</summary>
    Friend Shared ReadOnly Property NoDateMatch() As String
        Get
            Return ResourceManager.GetString("NoDateMatch", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a No se pudo obtener el puntaje ORES del revid {0}. EX: {1}.
    '''</summary>
    Friend Shared ReadOnly Property OresFailed() As String
        Get
            Return ResourceManager.GetString("OresFailed", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Puntaje ORES del revid {0}:  DMG:{1} /GF:{2}.
    '''</summary>
    Friend Shared ReadOnly Property OresLoaded() As String
        Get
            Return ResourceManager.GetString("OresLoaded", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Error de servidor en la query del puntaje ORES desde el revid {0} (diff inválido?).
    '''</summary>
    Friend Shared ReadOnly Property OresQueryError() As String
        Get
            Return ResourceManager.GetString("OresQueryError", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Excepción al obtener el puntaje ORES del revid {0}. EX: {1}.
    '''</summary>
    Friend Shared ReadOnly Property OresQueryEx() As String
        Get
            Return ResourceManager.GetString("OresQueryEx", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Query del puntaje ORES del revid {0} completada. GF: {1} DMG: {2}.
    '''</summary>
    Friend Shared ReadOnly Property OresQueryResult() As String
        Get
            Return ResourceManager.GetString("OresQueryResult", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Cuidado: La página &apos;{0}&apos; no existe aún..
    '''</summary>
    Friend Shared ReadOnly Property PageDoesNotExist() As String
        Get
            Return ResourceManager.GetString("PageDoesNotExist", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Página &apos;{0}&apos; cargada..
    '''</summary>
    Friend Shared ReadOnly Property PageLoaded() As String
        Get
            Return ResourceManager.GetString("PageLoaded", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Aviso: La página &apos;{0}&apos; no posee una imagen de previsualización..
    '''</summary>
    Friend Shared ReadOnly Property PageNoThumb() As String
        Get
            Return ResourceManager.GetString("PageNoThumb", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Error en la solicitud POST en &apos;{0}&apos;. EX: {1}.
    '''</summary>
    Friend Shared ReadOnly Property POSTEX() As String
        Get
            Return ResourceManager.GetString("POSTEX", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Presione cualquier tecla para salir.
    '''</summary>
    Friend Shared ReadOnly Property PressKey() As String
        Get
            Return ResourceManager.GetString("PressKey", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Página con el revid {0} cargada..
    '''</summary>
    Friend Shared ReadOnly Property PRevLoaded() As String
        Get
            Return ResourceManager.GetString("PRevLoaded", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Motivo: .
    '''</summary>
    Friend Shared ReadOnly Property Reason() As String
        Get
            Return ResourceManager.GetString("Reason", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Eliminando todas las referencias que contengan &apos;{0}&apos;..
    '''</summary>
    Friend Shared ReadOnly Property RemovingRefs() As String
        Get
            Return ResourceManager.GetString("RemovingRefs", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Obteniendo token.
    '''</summary>
    Friend Shared ReadOnly Property RequestingToken() As String
        Get
            Return ResourceManager.GetString("RequestingToken", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Error al guardar las configuraciones..
    '''</summary>
    Friend Shared ReadOnly Property SaveConfigError() As String
        Get
            Return ResourceManager.GetString("SaveConfigError", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Iniciando sesión.
    '''</summary>
    Friend Shared ReadOnly Property SigninIn() As String
        Get
            Return ResourceManager.GetString("SigninIn", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Filtro de abusos anti spam desencadenado en &apos;{0}&apos;..
    '''</summary>
    Friend Shared ReadOnly Property SpamBlackList() As String
        Get
            Return ResourceManager.GetString("SpamBlackList", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Edición en &apos;{0}&apos; exitosa..
    '''</summary>
    Friend Shared ReadOnly Property SuccessfulEdit() As String
        Get
            Return ResourceManager.GetString("SuccessfulEdit", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Operación exitosa..
    '''</summary>
    Friend Shared ReadOnly Property SuccessfulOperation() As String
        Get
            Return ResourceManager.GetString("SuccessfulOperation", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Bot: Reemplazando &apos;{0}&apos; con &apos;{1}&apos; {2}..
    '''</summary>
    Friend Shared ReadOnly Property TextReplaced() As String
        Get
            Return ResourceManager.GetString("TextReplaced", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Token obtenido.
    '''</summary>
    Friend Shared ReadOnly Property TokenObtained() As String
        Get
            Return ResourceManager.GetString("TokenObtained", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Intentando guardar &apos;{0}&apos;..
    '''</summary>
    Friend Shared ReadOnly Property TryingToSave() As String
        Get
            Return ResourceManager.GetString("TryingToSave", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Excepción inesperada: {0}.
    '''</summary>
    Friend Shared ReadOnly Property UnexpectedEX() As String
        Get
            Return ResourceManager.GetString("UnexpectedEX", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a La operación ha fallado..
    '''</summary>
    Friend Shared ReadOnly Property UnsuccessfulOperation() As String
        Get
            Return ResourceManager.GetString("UnsuccessfulOperation", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a El usuario {0} está bloqueado..
    '''</summary>
    Friend Shared ReadOnly Property UserBlocked() As String
        Get
            Return ResourceManager.GetString("UserBlocked", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a El usuario {0} está inactivo..
    '''</summary>
    Friend Shared ReadOnly Property UserInactive() As String
        Get
            Return ResourceManager.GetString("UserInactive", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a El usuario {0} no existe..
    '''</summary>
    Friend Shared ReadOnly Property UserInexistent() As String
        Get
            Return ResourceManager.GetString("UserInexistent", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a {0} acaba de editar..
    '''</summary>
    Friend Shared ReadOnly Property UserJustEdited() As String
        Get
            Return ResourceManager.GetString("UserJustEdited", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Busca una cadena traducida similar a Nombre de usuario: .
    '''</summary>
    Friend Shared ReadOnly Property UserName() As String
        Get
            Return ResourceManager.GetString("UserName", resourceCulture)
        End Get
    End Property
End Class
