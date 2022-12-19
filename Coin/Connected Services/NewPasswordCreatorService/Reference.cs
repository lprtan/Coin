﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPasswordCreatorService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NewPasswordCreatorService.NewPasswordCreatorServiceSoap")]
    public interface NewPasswordCreatorServiceSoap
    {
        
        // CODEGEN: Generating message contract since element name NewPasswordCreatorResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NewPasswordCreator", ReplyAction="*")]
        NewPasswordCreatorService.NewPasswordCreatorResponse NewPasswordCreator(NewPasswordCreatorService.NewPasswordCreatorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NewPasswordCreator", ReplyAction="*")]
        System.Threading.Tasks.Task<NewPasswordCreatorService.NewPasswordCreatorResponse> NewPasswordCreatorAsync(NewPasswordCreatorService.NewPasswordCreatorRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NewPasswordCreatorRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NewPasswordCreator", Namespace="http://tempuri.org/", Order=0)]
        public NewPasswordCreatorService.NewPasswordCreatorRequestBody Body;
        
        public NewPasswordCreatorRequest()
        {
        }
        
        public NewPasswordCreatorRequest(NewPasswordCreatorService.NewPasswordCreatorRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class NewPasswordCreatorRequestBody
    {
        
        public NewPasswordCreatorRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NewPasswordCreatorResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NewPasswordCreatorResponse", Namespace="http://tempuri.org/", Order=0)]
        public NewPasswordCreatorService.NewPasswordCreatorResponseBody Body;
        
        public NewPasswordCreatorResponse()
        {
        }
        
        public NewPasswordCreatorResponse(NewPasswordCreatorService.NewPasswordCreatorResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class NewPasswordCreatorResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string NewPasswordCreatorResult;
        
        public NewPasswordCreatorResponseBody()
        {
        }
        
        public NewPasswordCreatorResponseBody(string NewPasswordCreatorResult)
        {
            this.NewPasswordCreatorResult = NewPasswordCreatorResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface NewPasswordCreatorServiceSoapChannel : NewPasswordCreatorService.NewPasswordCreatorServiceSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class NewPasswordCreatorServiceSoapClient : System.ServiceModel.ClientBase<NewPasswordCreatorService.NewPasswordCreatorServiceSoap>, NewPasswordCreatorService.NewPasswordCreatorServiceSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public NewPasswordCreatorServiceSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(NewPasswordCreatorServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), NewPasswordCreatorServiceSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NewPasswordCreatorServiceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(NewPasswordCreatorServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NewPasswordCreatorServiceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(NewPasswordCreatorServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NewPasswordCreatorServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NewPasswordCreatorService.NewPasswordCreatorResponse NewPasswordCreatorService.NewPasswordCreatorServiceSoap.NewPasswordCreator(NewPasswordCreatorService.NewPasswordCreatorRequest request)
        {
            return base.Channel.NewPasswordCreator(request);
        }
        
        public string NewPasswordCreator()
        {
            NewPasswordCreatorService.NewPasswordCreatorRequest inValue = new NewPasswordCreatorService.NewPasswordCreatorRequest();
            inValue.Body = new NewPasswordCreatorService.NewPasswordCreatorRequestBody();
            NewPasswordCreatorService.NewPasswordCreatorResponse retVal = ((NewPasswordCreatorService.NewPasswordCreatorServiceSoap)(this)).NewPasswordCreator(inValue);
            return retVal.Body.NewPasswordCreatorResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NewPasswordCreatorService.NewPasswordCreatorResponse> NewPasswordCreatorService.NewPasswordCreatorServiceSoap.NewPasswordCreatorAsync(NewPasswordCreatorService.NewPasswordCreatorRequest request)
        {
            return base.Channel.NewPasswordCreatorAsync(request);
        }
        
        public System.Threading.Tasks.Task<NewPasswordCreatorService.NewPasswordCreatorResponse> NewPasswordCreatorAsync()
        {
            NewPasswordCreatorService.NewPasswordCreatorRequest inValue = new NewPasswordCreatorService.NewPasswordCreatorRequest();
            inValue.Body = new NewPasswordCreatorService.NewPasswordCreatorRequestBody();
            return ((NewPasswordCreatorService.NewPasswordCreatorServiceSoap)(this)).NewPasswordCreatorAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NewPasswordCreatorServiceSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.NewPasswordCreatorServiceSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NewPasswordCreatorServiceSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:44333/NewPasswordCreatorService.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.NewPasswordCreatorServiceSoap12))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:44333/NewPasswordCreatorService.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            NewPasswordCreatorServiceSoap,
            
            NewPasswordCreatorServiceSoap12,
        }
    }
}
