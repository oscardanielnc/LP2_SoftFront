﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LP2Soft.UsuarioWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.LP2Soft.pucp.edu.pe/", ConfigurationName="UsuarioWS.UsuariosWS")]
    public interface UsuariosWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.LP2Soft.pucp.edu.pe/UsuariosWS/mostrarUsuarioRequest", ReplyAction="http://services.LP2Soft.pucp.edu.pe/UsuariosWS/mostrarUsuarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2Soft.UsuarioWS.mostrarUsuarioResponse mostrarUsuario(LP2Soft.UsuarioWS.mostrarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.LP2Soft.pucp.edu.pe/UsuariosWS/mostrarUsuarioRequest", ReplyAction="http://services.LP2Soft.pucp.edu.pe/UsuariosWS/mostrarUsuarioResponse")]
        System.Threading.Tasks.Task<LP2Soft.UsuarioWS.mostrarUsuarioResponse> mostrarUsuarioAsync(LP2Soft.UsuarioWS.mostrarUsuarioRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.LP2Soft.pucp.edu.pe/UsuariosWS/insertarUsuarioRequest", ReplyAction="http://services.LP2Soft.pucp.edu.pe/UsuariosWS/insertarUsuarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2Soft.UsuarioWS.insertarUsuarioResponse insertarUsuario(LP2Soft.UsuarioWS.insertarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.LP2Soft.pucp.edu.pe/UsuariosWS/insertarUsuarioRequest", ReplyAction="http://services.LP2Soft.pucp.edu.pe/UsuariosWS/insertarUsuarioResponse")]
        System.Threading.Tasks.Task<LP2Soft.UsuarioWS.insertarUsuarioResponse> insertarUsuarioAsync(LP2Soft.UsuarioWS.insertarUsuarioRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.LP2Soft.pucp.edu.pe/")]
    public partial class usuario : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool activoField;
        
        private usuario[] amigosField;
        
        private string apellidoField;
        
        private asesor asesorField;
        
        private string codigoPUCPField;
        
        private string contraseniaField;
        
        private string correoField;
        
        private float creditosTotalesField;
        
        private curso[] cursosField;
        
        private string descripcionField;
        
        private bool esAdminField;
        
        private bool esAsesorField;
        
        private string especialidadField;
        
        private evento[] eventosAgendadosField;
        
        private System.DateTime fechaNacimientoField;
        
        private bool fechaNacimientoFieldSpecified;
        
        private byte[] fotoField;
        
        private int idUsuarioField;
        
        private string nombreField;
        
        private byte[] portadaField;
        
        private post[] postsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool activo {
            get {
                return this.activoField;
            }
            set {
                this.activoField = value;
                this.RaisePropertyChanged("activo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("amigos", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=1)]
        public usuario[] amigos {
            get {
                return this.amigosField;
            }
            set {
                this.amigosField = value;
                this.RaisePropertyChanged("amigos");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string apellido {
            get {
                return this.apellidoField;
            }
            set {
                this.apellidoField = value;
                this.RaisePropertyChanged("apellido");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public asesor asesor {
            get {
                return this.asesorField;
            }
            set {
                this.asesorField = value;
                this.RaisePropertyChanged("asesor");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string codigoPUCP {
            get {
                return this.codigoPUCPField;
            }
            set {
                this.codigoPUCPField = value;
                this.RaisePropertyChanged("codigoPUCP");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string contrasenia {
            get {
                return this.contraseniaField;
            }
            set {
                this.contraseniaField = value;
                this.RaisePropertyChanged("contrasenia");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string correo {
            get {
                return this.correoField;
            }
            set {
                this.correoField = value;
                this.RaisePropertyChanged("correo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public float creditosTotales {
            get {
                return this.creditosTotalesField;
            }
            set {
                this.creditosTotalesField = value;
                this.RaisePropertyChanged("creditosTotales");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cursos", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=8)]
        public curso[] cursos {
            get {
                return this.cursosField;
            }
            set {
                this.cursosField = value;
                this.RaisePropertyChanged("cursos");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("descripcion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public bool esAdmin {
            get {
                return this.esAdminField;
            }
            set {
                this.esAdminField = value;
                this.RaisePropertyChanged("esAdmin");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public bool esAsesor {
            get {
                return this.esAsesorField;
            }
            set {
                this.esAsesorField = value;
                this.RaisePropertyChanged("esAsesor");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public string especialidad {
            get {
                return this.especialidadField;
            }
            set {
                this.especialidadField = value;
                this.RaisePropertyChanged("especialidad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("eventosAgendados", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=13)]
        public evento[] eventosAgendados {
            get {
                return this.eventosAgendadosField;
            }
            set {
                this.eventosAgendadosField = value;
                this.RaisePropertyChanged("eventosAgendados");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public System.DateTime fechaNacimiento {
            get {
                return this.fechaNacimientoField;
            }
            set {
                this.fechaNacimientoField = value;
                this.RaisePropertyChanged("fechaNacimiento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaNacimientoSpecified {
            get {
                return this.fechaNacimientoFieldSpecified;
            }
            set {
                this.fechaNacimientoFieldSpecified = value;
                this.RaisePropertyChanged("fechaNacimientoSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=15)]
        public byte[] foto {
            get {
                return this.fotoField;
            }
            set {
                this.fotoField = value;
                this.RaisePropertyChanged("foto");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public int idUsuario {
            get {
                return this.idUsuarioField;
            }
            set {
                this.idUsuarioField = value;
                this.RaisePropertyChanged("idUsuario");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=18)]
        public byte[] portada {
            get {
                return this.portadaField;
            }
            set {
                this.portadaField = value;
                this.RaisePropertyChanged("portada");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("posts", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=19)]
        public post[] posts {
            get {
                return this.postsField;
            }
            set {
                this.postsField = value;
                this.RaisePropertyChanged("posts");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.LP2Soft.pucp.edu.pe/")]
    public partial class asesor : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool activoField;
        
        private float calificacionField;
        
        private int idAsesorField;
        
        private float precioPorHoraField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool activo {
            get {
                return this.activoField;
            }
            set {
                this.activoField = value;
                this.RaisePropertyChanged("activo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public float calificacion {
            get {
                return this.calificacionField;
            }
            set {
                this.calificacionField = value;
                this.RaisePropertyChanged("calificacion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int idAsesor {
            get {
                return this.idAsesorField;
            }
            set {
                this.idAsesorField = value;
                this.RaisePropertyChanged("idAsesor");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public float precioPorHora {
            get {
                return this.precioPorHoraField;
            }
            set {
                this.precioPorHoraField = value;
                this.RaisePropertyChanged("precioPorHora");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(evento))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.LP2Soft.pucp.edu.pe/")]
    public abstract partial class post : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool activoField;
        
        private bool bloqueadoField;
        
        private string contenidoField;
        
        private System.DateTime fechaRegistroField;
        
        private bool fechaRegistroFieldSpecified;
        
        private int idPostField;
        
        private int likesField;
        
        private int prioridadField;
        
        private int tipoField;
        
        private usuario usuarioField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool activo {
            get {
                return this.activoField;
            }
            set {
                this.activoField = value;
                this.RaisePropertyChanged("activo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public bool bloqueado {
            get {
                return this.bloqueadoField;
            }
            set {
                this.bloqueadoField = value;
                this.RaisePropertyChanged("bloqueado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string contenido {
            get {
                return this.contenidoField;
            }
            set {
                this.contenidoField = value;
                this.RaisePropertyChanged("contenido");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public System.DateTime fechaRegistro {
            get {
                return this.fechaRegistroField;
            }
            set {
                this.fechaRegistroField = value;
                this.RaisePropertyChanged("fechaRegistro");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaRegistroSpecified {
            get {
                return this.fechaRegistroFieldSpecified;
            }
            set {
                this.fechaRegistroFieldSpecified = value;
                this.RaisePropertyChanged("fechaRegistroSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int idPost {
            get {
                return this.idPostField;
            }
            set {
                this.idPostField = value;
                this.RaisePropertyChanged("idPost");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int likes {
            get {
                return this.likesField;
            }
            set {
                this.likesField = value;
                this.RaisePropertyChanged("likes");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int prioridad {
            get {
                return this.prioridadField;
            }
            set {
                this.prioridadField = value;
                this.RaisePropertyChanged("prioridad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int tipo {
            get {
                return this.tipoField;
            }
            set {
                this.tipoField = value;
                this.RaisePropertyChanged("tipo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public usuario usuario {
            get {
                return this.usuarioField;
            }
            set {
                this.usuarioField = value;
                this.RaisePropertyChanged("usuario");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.LP2Soft.pucp.edu.pe/")]
    public partial class evento : post {
        
        private byte[] archivoField;
        
        private System.DateTime fechaDelEventoField;
        
        private bool fechaDelEventoFieldSpecified;
        
        private string nombreArchivoField;
        
        private string nombreDelEventoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=0)]
        public byte[] archivo {
            get {
                return this.archivoField;
            }
            set {
                this.archivoField = value;
                this.RaisePropertyChanged("archivo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public System.DateTime fechaDelEvento {
            get {
                return this.fechaDelEventoField;
            }
            set {
                this.fechaDelEventoField = value;
                this.RaisePropertyChanged("fechaDelEvento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaDelEventoSpecified {
            get {
                return this.fechaDelEventoFieldSpecified;
            }
            set {
                this.fechaDelEventoFieldSpecified = value;
                this.RaisePropertyChanged("fechaDelEventoSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string nombreArchivo {
            get {
                return this.nombreArchivoField;
            }
            set {
                this.nombreArchivoField = value;
                this.RaisePropertyChanged("nombreArchivo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string nombreDelEvento {
            get {
                return this.nombreDelEventoField;
            }
            set {
                this.nombreDelEventoField = value;
                this.RaisePropertyChanged("nombreDelEvento");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.LP2Soft.pucp.edu.pe/")]
    public partial class curso : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool activoField;
        
        private string codigoField;
        
        private string descripcionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool activo {
            get {
                return this.activoField;
            }
            set {
                this.activoField = value;
                this.RaisePropertyChanged("activo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
                this.RaisePropertyChanged("codigo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("descripcion");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="mostrarUsuario", WrapperNamespace="http://services.LP2Soft.pucp.edu.pe/", IsWrapped=true)]
    public partial class mostrarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.LP2Soft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string correoCodigo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.LP2Soft.pucp.edu.pe/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int isCode;
        
        public mostrarUsuarioRequest() {
        }
        
        public mostrarUsuarioRequest(string correoCodigo, int isCode) {
            this.correoCodigo = correoCodigo;
            this.isCode = isCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="mostrarUsuarioResponse", WrapperNamespace="http://services.LP2Soft.pucp.edu.pe/", IsWrapped=true)]
    public partial class mostrarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.LP2Soft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2Soft.UsuarioWS.usuario @return;
        
        public mostrarUsuarioResponse() {
        }
        
        public mostrarUsuarioResponse(LP2Soft.UsuarioWS.usuario @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarUsuario", WrapperNamespace="http://services.LP2Soft.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.LP2Soft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2Soft.UsuarioWS.usuario usuario;
        
        public insertarUsuarioRequest() {
        }
        
        public insertarUsuarioRequest(LP2Soft.UsuarioWS.usuario usuario) {
            this.usuario = usuario;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarUsuarioResponse", WrapperNamespace="http://services.LP2Soft.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.LP2Soft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarUsuarioResponse() {
        }
        
        public insertarUsuarioResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UsuariosWSChannel : LP2Soft.UsuarioWS.UsuariosWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsuariosWSClient : System.ServiceModel.ClientBase<LP2Soft.UsuarioWS.UsuariosWS>, LP2Soft.UsuarioWS.UsuariosWS {
        
        public UsuariosWSClient() {
        }
        
        public UsuariosWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsuariosWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuariosWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuariosWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2Soft.UsuarioWS.mostrarUsuarioResponse LP2Soft.UsuarioWS.UsuariosWS.mostrarUsuario(LP2Soft.UsuarioWS.mostrarUsuarioRequest request) {
            return base.Channel.mostrarUsuario(request);
        }
        
        public LP2Soft.UsuarioWS.usuario mostrarUsuario(string correoCodigo, int isCode) {
            LP2Soft.UsuarioWS.mostrarUsuarioRequest inValue = new LP2Soft.UsuarioWS.mostrarUsuarioRequest();
            inValue.correoCodigo = correoCodigo;
            inValue.isCode = isCode;
            LP2Soft.UsuarioWS.mostrarUsuarioResponse retVal = ((LP2Soft.UsuarioWS.UsuariosWS)(this)).mostrarUsuario(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2Soft.UsuarioWS.mostrarUsuarioResponse> LP2Soft.UsuarioWS.UsuariosWS.mostrarUsuarioAsync(LP2Soft.UsuarioWS.mostrarUsuarioRequest request) {
            return base.Channel.mostrarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2Soft.UsuarioWS.mostrarUsuarioResponse> mostrarUsuarioAsync(string correoCodigo, int isCode) {
            LP2Soft.UsuarioWS.mostrarUsuarioRequest inValue = new LP2Soft.UsuarioWS.mostrarUsuarioRequest();
            inValue.correoCodigo = correoCodigo;
            inValue.isCode = isCode;
            return ((LP2Soft.UsuarioWS.UsuariosWS)(this)).mostrarUsuarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2Soft.UsuarioWS.insertarUsuarioResponse LP2Soft.UsuarioWS.UsuariosWS.insertarUsuario(LP2Soft.UsuarioWS.insertarUsuarioRequest request) {
            return base.Channel.insertarUsuario(request);
        }
        
        public int insertarUsuario(LP2Soft.UsuarioWS.usuario usuario) {
            LP2Soft.UsuarioWS.insertarUsuarioRequest inValue = new LP2Soft.UsuarioWS.insertarUsuarioRequest();
            inValue.usuario = usuario;
            LP2Soft.UsuarioWS.insertarUsuarioResponse retVal = ((LP2Soft.UsuarioWS.UsuariosWS)(this)).insertarUsuario(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2Soft.UsuarioWS.insertarUsuarioResponse> LP2Soft.UsuarioWS.UsuariosWS.insertarUsuarioAsync(LP2Soft.UsuarioWS.insertarUsuarioRequest request) {
            return base.Channel.insertarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2Soft.UsuarioWS.insertarUsuarioResponse> insertarUsuarioAsync(LP2Soft.UsuarioWS.usuario usuario) {
            LP2Soft.UsuarioWS.insertarUsuarioRequest inValue = new LP2Soft.UsuarioWS.insertarUsuarioRequest();
            inValue.usuario = usuario;
            return ((LP2Soft.UsuarioWS.UsuariosWS)(this)).insertarUsuarioAsync(inValue);
        }
    }
}
