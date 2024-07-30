namespace Core.Configuraciones
{
    public class TextoConfig
    {
        public string VersionSistema { get; set; }
        public string InformacionDB { get; set; }

        #region MoHerramienta
        public string MoHerramienta { get; set; }
        #endregion

        #region MoBitacora
        public string MoBitacora { get; set; }
        public string Bitacora { get; set; }
        public string BitacoraMensajePredeterminado { get; set; }
        #endregion

        #region MoArchivo
        public string MoArchivo { get; set; }
        public string ArchivoNoEncontrado { get; set; }
        public string ArchivoExtensionNoPermitida { get; set; }
        public string ArchivoContentTypeNoPermitido { get; set; }
        public string ArchivoNoCreado { get; set; }
        public string ArchivoError { get; set; }
        public string ArchivoVacio { get; set; }
        public string ArchivoCreacionCorrecta { get; set; }
        #endregion

        #region MoEmail
        public string MoEmail { get; set; }
        public string EmailTituloBienvenida { get; set; }
        public string EmailTituloRecuperarPassword { get; set; }
        public string EmailTituloCambiarPassword { get; set; }
        public string EmailTituloRestablecerPassword { get; set; }
        #endregion

        #region MoFecha
        public string MoFecha { get; set; }
        #endregion

        #region MoPassword
        public string MoPassword { get; set; }
        #endregion

        #region MoRespuestaHttp
        public string MoRespuestaHttp { get; set; }
        #endregion

        #region MoTokenJwt
        public string MoTokenJwt { get; set; }
        #endregion

        #region MoStdProc
        public string MoStdProc { get; set; }
        public string SpInicioEjecucion { get; set; }
        public string SpFinEjecucion { get; set; }
        #endregion

        #region Mensajes
        public string Identerminado { get; set; }
        public string FuncionNoPermitida { get; set; }
        public string TokenInvalido { get; set; }
        public string TokenActualizado { get; set; }
        public string AccesoDatabaseDenegado { get; set; }

        public string EmpresaDesconocida { get; set; }
        public string UsuarioDesconocido { get; set; }
        public string UsuarioInactivo { get; set; }
        public string UsuarioPendiente { get; set; }
        public string UsuarioBloqueado { get; set; }
        public string UsuarioIntentosSuperados { get; set; }
        public string UsuarioPasswordIncorrecto { get; set; }
        public string ImposibleIniciarSesion { get; set; }

        public string ImposibleObtenerMenu { get; set; }
        public string ImposibleObtenerPermisos { get; set; }
        public string ImposibleObtenerParametros { get; set; }
        public string RegistroInexistente { get; set; }
        public string RegistroEnUso { get; set; }
        public string Exception { get; set; }
        public string FuncionConsultaCorrecto { get; set; }
        public string FuncionConsultaVacia { get; set; }
        public string FuncionDetalleCorrecto { get; set; }
        public string FuncionDetalleIncorrecto { get; set; }
        public string FuncionCreacionCorrecto { get; set; }
        public string FuncionCreacionIncorrecto { get; set; }
        public string FuncionEdicionCorrecto { get; set; }
        public string FuncionEdicionIncorrecto { get; set; }
        public string FuncionCambioEstatusCorrecto { get; set; }
        public string FuncionCambioEstatusIncorrecto { get; set; }
        public string FuncionEliminacionCorrecto { get; set; }
        public string FuncionEliminacionIncorrecto { get; set; }
        public string FuncionExportacionCorrecto { get; set; }
        public string FuncionCargaMasiva { get; set; }
        public string FuncionDesbloquearUsuarioCorrecto { get; set; }
        public string FuncionDesbloquearUsuarioIncorrecto { get; set; }
        public string PasswordCorreo { get; set; }
        public string PasswordInvalido { get; set; }
        public string PasswordPreviamenteUtilizado { get; set; }
        public string RecuperarPasswordCorrecto { get; set; }
        public string RecuperarPasswordIncorrecto { get; set; }
        public string CambiarPasswordCorrecto { get; set; }
        public string CambiarPasswordIncorrecto { get; set; }
        public string RestablecerPasswordCorrecto { get; set; }
        public string RestablecerPasswordIncorrecto { get; set; }
        public string ParametroNoEncontrado { get; set; }
        public string ParametroValorIncorrecto { get; set; }
        public string SesionIniciada { get; set; }
        public string SucursalConSaldo { get; set; }
        public string CuentaConSaldo { get; set; }
        public string PeriodoNoHistorico { get; set; }
        public string PeriodoExcedido { get; set; }
        public string AutoEliminacionUsuario { get; set; }
        public string AutoCambiarEstatusUsuario { get; set; }
        public string AutoDesbloquearUsuario { get; set; }
        public string AutoEliminacionPerfil { get; set; }
        public string AutoCambiarEstatusPerfil { get; set; }
        public string AutoEliminacionEmpresa { get; set; }
        public string AutoCambiarEstatusEmpresa { get; set; }
        public string RegistroNoInactivo { get; set; }
        public string EstatusInvalido { get; set; }
        public string CMRegistrosProcesados { get; set; }
        public string CMErroresEncontrados { get; set; }
        public string SalarioIncorrecto { get; set; }
        public string NivelIncorrecto { get; set; }
        public string SinSaldoDisponible { get; set; }
        public string ViolacionDeAsignacion { get; set; }
        public string AutoEliminacionGrupo { get; set; }
        public string RelacionPadreInexistente { get; set; }
        public string LimiteUsuariosSuperado { get; set; }
        public string TipoUsuarioInvalido { get; set; }
        public string CantidadEnInventarioInsuficiente { get; set; }
        public string CheckInActivo { get; set; }
        public string CheckOutRealizado { get; set; }
		public string SinStock { get; set; }
		#endregion

		public TextoConfig()
        {
            VersionSistema = string.Empty;
            InformacionDB = string.Empty;
            MoHerramienta = string.Empty;
            MoBitacora = string.Empty;
            Bitacora = string.Empty;
            BitacoraMensajePredeterminado = string.Empty;
            MoArchivo = string.Empty;
            ArchivoNoEncontrado = string.Empty;
            ArchivoExtensionNoPermitida = string.Empty;
            ArchivoContentTypeNoPermitido = string.Empty;
            ArchivoNoCreado = string.Empty;
            ArchivoError = string.Empty;
            ArchivoVacio = string.Empty;
            ArchivoCreacionCorrecta = string.Empty;
            MoEmail = string.Empty;
            EmailTituloBienvenida = string.Empty;
            EmailTituloRecuperarPassword = string.Empty;
            EmailTituloCambiarPassword = string.Empty;
            EmailTituloRestablecerPassword = string.Empty;
            MoFecha = string.Empty;
            MoPassword = string.Empty;
            MoRespuestaHttp = string.Empty;
            MoTokenJwt = string.Empty;
            MoStdProc = string.Empty;
            SpInicioEjecucion = string.Empty;
            SpFinEjecucion = string.Empty;
            Identerminado = string.Empty;
            FuncionNoPermitida = string.Empty;
            TokenInvalido = string.Empty;
            TokenActualizado = string.Empty;
            AccesoDatabaseDenegado = string.Empty;
            EmpresaDesconocida = string.Empty;
            UsuarioDesconocido = string.Empty;
            UsuarioInactivo = string.Empty;
            UsuarioPendiente = string.Empty;
            UsuarioBloqueado = string.Empty;
            UsuarioIntentosSuperados = string.Empty;
            UsuarioPasswordIncorrecto = string.Empty;
            ImposibleIniciarSesion = string.Empty;
            ImposibleObtenerMenu = string.Empty;
            ImposibleObtenerPermisos = string.Empty;
            ImposibleObtenerParametros = string.Empty;
            RegistroInexistente = string.Empty;
            RegistroEnUso = string.Empty;
            Exception = string.Empty;
            FuncionConsultaCorrecto = string.Empty;
            FuncionConsultaVacia = string.Empty;
            FuncionDetalleCorrecto = string.Empty;
            FuncionDetalleIncorrecto = string.Empty;
            FuncionCreacionCorrecto = string.Empty;
            FuncionCreacionIncorrecto = string.Empty;
            FuncionEdicionCorrecto = string.Empty;
            FuncionEdicionIncorrecto = string.Empty;
            FuncionCambioEstatusCorrecto = string.Empty;
            FuncionCambioEstatusIncorrecto = string.Empty;
            FuncionEliminacionCorrecto = string.Empty;
            FuncionEliminacionIncorrecto = string.Empty;
            FuncionExportacionCorrecto = string.Empty;
            FuncionCargaMasiva = string.Empty;
            FuncionDesbloquearUsuarioCorrecto = string.Empty;
            FuncionDesbloquearUsuarioIncorrecto = string.Empty;
            PasswordCorreo = string.Empty;
            PasswordInvalido = string.Empty;
            PasswordPreviamenteUtilizado = string.Empty;
            RecuperarPasswordCorrecto = string.Empty;
            RecuperarPasswordIncorrecto = string.Empty;
            CambiarPasswordCorrecto = string.Empty;
            CambiarPasswordIncorrecto = string.Empty;
            RestablecerPasswordCorrecto = string.Empty;
            RestablecerPasswordIncorrecto = string.Empty;
            ParametroNoEncontrado = string.Empty;
            ParametroValorIncorrecto = string.Empty;
            SesionIniciada = string.Empty;
            SucursalConSaldo = string.Empty;
            CuentaConSaldo = string.Empty;
            PeriodoNoHistorico = string.Empty;
            PeriodoExcedido = string.Empty;
            AutoEliminacionUsuario = string.Empty;
            AutoCambiarEstatusUsuario = string.Empty;
            AutoDesbloquearUsuario = string.Empty;
            AutoEliminacionPerfil = string.Empty;
            AutoCambiarEstatusPerfil = string.Empty;
            AutoEliminacionEmpresa = string.Empty;
            AutoCambiarEstatusEmpresa = string.Empty;
            RegistroNoInactivo = string.Empty;
            EstatusInvalido = string.Empty;
            CMRegistrosProcesados = string.Empty;
            CMErroresEncontrados = string.Empty;
            SalarioIncorrecto = string.Empty;
            NivelIncorrecto = string.Empty;
            SinSaldoDisponible = string.Empty;
            ViolacionDeAsignacion = string.Empty;
            AutoEliminacionGrupo = string.Empty;
            RelacionPadreInexistente = string.Empty;
            LimiteUsuariosSuperado = string.Empty;
            TipoUsuarioInvalido = string.Empty;
            CantidadEnInventarioInsuficiente = string.Empty;
            CheckInActivo = string.Empty;
            CheckOutRealizado = string.Empty;
			SinStock = string.Empty;

		}
    }
}
