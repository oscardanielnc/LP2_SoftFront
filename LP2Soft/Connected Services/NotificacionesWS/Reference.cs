﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LP2Soft.NotificacionesWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.LP2Soft.pucp.edu.pe/", ConfigurationName="NotificacionesWS.NotificacionesWS")]
    public interface NotificacionesWS {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento name del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.LP2Soft.pucp.edu.pe/NotificacionesWS/helloRequest", ReplyAction="http://services.LP2Soft.pucp.edu.pe/NotificacionesWS/helloResponse")]
        LP2Soft.NotificacionesWS.helloResponse hello(LP2Soft.NotificacionesWS.helloRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.LP2Soft.pucp.edu.pe/NotificacionesWS/helloRequest", ReplyAction="http://services.LP2Soft.pucp.edu.pe/NotificacionesWS/helloResponse")]
        System.Threading.Tasks.Task<LP2Soft.NotificacionesWS.helloResponse> helloAsync(LP2Soft.NotificacionesWS.helloRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class helloRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="hello", Namespace="http://services.LP2Soft.pucp.edu.pe/", Order=0)]
        public LP2Soft.NotificacionesWS.helloRequestBody Body;
        
        public helloRequest() {
        }
        
        public helloRequest(LP2Soft.NotificacionesWS.helloRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class helloRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        public helloRequestBody() {
        }
        
        public helloRequestBody(string name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class helloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="helloResponse", Namespace="http://services.LP2Soft.pucp.edu.pe/", Order=0)]
        public LP2Soft.NotificacionesWS.helloResponseBody Body;
        
        public helloResponse() {
        }
        
        public helloResponse(LP2Soft.NotificacionesWS.helloResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class helloResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public helloResponseBody() {
        }
        
        public helloResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface NotificacionesWSChannel : LP2Soft.NotificacionesWS.NotificacionesWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NotificacionesWSClient : System.ServiceModel.ClientBase<LP2Soft.NotificacionesWS.NotificacionesWS>, LP2Soft.NotificacionesWS.NotificacionesWS {
        
        public NotificacionesWSClient() {
        }
        
        public NotificacionesWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NotificacionesWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NotificacionesWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NotificacionesWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2Soft.NotificacionesWS.helloResponse LP2Soft.NotificacionesWS.NotificacionesWS.hello(LP2Soft.NotificacionesWS.helloRequest request) {
            return base.Channel.hello(request);
        }
        
        public string hello(string name) {
            LP2Soft.NotificacionesWS.helloRequest inValue = new LP2Soft.NotificacionesWS.helloRequest();
            inValue.Body = new LP2Soft.NotificacionesWS.helloRequestBody();
            inValue.Body.name = name;
            LP2Soft.NotificacionesWS.helloResponse retVal = ((LP2Soft.NotificacionesWS.NotificacionesWS)(this)).hello(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2Soft.NotificacionesWS.helloResponse> LP2Soft.NotificacionesWS.NotificacionesWS.helloAsync(LP2Soft.NotificacionesWS.helloRequest request) {
            return base.Channel.helloAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2Soft.NotificacionesWS.helloResponse> helloAsync(string name) {
            LP2Soft.NotificacionesWS.helloRequest inValue = new LP2Soft.NotificacionesWS.helloRequest();
            inValue.Body = new LP2Soft.NotificacionesWS.helloRequestBody();
            inValue.Body.name = name;
            return ((LP2Soft.NotificacionesWS.NotificacionesWS)(this)).helloAsync(inValue);
        }
    }
}
