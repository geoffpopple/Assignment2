﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://example.com/", ConfigurationName="ServiceReference2.ZodiacDateSoap")]
    public interface ZodiacDateSoap {
        
        // CODEGEN: Generating message contract since element name month from namespace http://example.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://example.com/GetSign", ReplyAction="*")]
        Client.ServiceReference2.GetSignResponse GetSign(Client.ServiceReference2.GetSignRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://example.com/GetSign", ReplyAction="*")]
        System.Threading.Tasks.Task<Client.ServiceReference2.GetSignResponse> GetSignAsync(Client.ServiceReference2.GetSignRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSignRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSign", Namespace="http://example.com/", Order=0)]
        public Client.ServiceReference2.GetSignRequestBody Body;
        
        public GetSignRequest() {
        }
        
        public GetSignRequest(Client.ServiceReference2.GetSignRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://example.com/")]
    public partial class GetSignRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string month;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string day;
        
        public GetSignRequestBody() {
        }
        
        public GetSignRequestBody(string month, string day) {
            this.month = month;
            this.day = day;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSignResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSignResponse", Namespace="http://example.com/", Order=0)]
        public Client.ServiceReference2.GetSignResponseBody Body;
        
        public GetSignResponse() {
        }
        
        public GetSignResponse(Client.ServiceReference2.GetSignResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://example.com/")]
    public partial class GetSignResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetSignResult;
        
        public GetSignResponseBody() {
        }
        
        public GetSignResponseBody(string GetSignResult) {
            this.GetSignResult = GetSignResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ZodiacDateSoapChannel : Client.ServiceReference2.ZodiacDateSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ZodiacDateSoapClient : System.ServiceModel.ClientBase<Client.ServiceReference2.ZodiacDateSoap>, Client.ServiceReference2.ZodiacDateSoap {
        
        public ZodiacDateSoapClient() {
        }
        
        public ZodiacDateSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ZodiacDateSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ZodiacDateSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ZodiacDateSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.ServiceReference2.GetSignResponse Client.ServiceReference2.ZodiacDateSoap.GetSign(Client.ServiceReference2.GetSignRequest request) {
            return base.Channel.GetSign(request);
        }
        
        public string GetSign(string month, string day) {
            Client.ServiceReference2.GetSignRequest inValue = new Client.ServiceReference2.GetSignRequest();
            inValue.Body = new Client.ServiceReference2.GetSignRequestBody();
            inValue.Body.month = month;
            inValue.Body.day = day;
            Client.ServiceReference2.GetSignResponse retVal = ((Client.ServiceReference2.ZodiacDateSoap)(this)).GetSign(inValue);
            return retVal.Body.GetSignResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Client.ServiceReference2.GetSignResponse> Client.ServiceReference2.ZodiacDateSoap.GetSignAsync(Client.ServiceReference2.GetSignRequest request) {
            return base.Channel.GetSignAsync(request);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference2.GetSignResponse> GetSignAsync(string month, string day) {
            Client.ServiceReference2.GetSignRequest inValue = new Client.ServiceReference2.GetSignRequest();
            inValue.Body = new Client.ServiceReference2.GetSignRequestBody();
            inValue.Body.month = month;
            inValue.Body.day = day;
            return ((Client.ServiceReference2.ZodiacDateSoap)(this)).GetSignAsync(inValue);
        }
    }
}
