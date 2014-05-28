//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NotificationRetevalDemo.casgway.stirling.gov.uk
{
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("SharpDevelop", "2.2.1.2648")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CasGatewayBinding", Namespace="http://www.scottishcitizen.gov.uk/localgateway")]
    public partial class CasGatewayService : System.Web.Services.Protocols.SoapHttpClientProtocol
    {
        
        /// <remarks/>
        public CasGatewayService()
        {
            this.Url = "http://casgway.stirling.gov.uk:8080/cas-gateway/service/GatewayEndpoint";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("LocalCASResponseMessage", Namespace="http://www.scottishcitizen.gov.uk/localgateway")]
        public LocalCASResponseMessage LocalCAS([System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.scottishcitizen.gov.uk/localgateway")] LocalCASRequestMessage LocalCASRequestMessage)
        {
            object[] results = this.Invoke("LocalCAS", new object[] {
                        LocalCASRequestMessage});
            return ((LocalCASResponseMessage)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginLocalCAS(LocalCASRequestMessage LocalCASRequestMessage, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("LocalCAS", new object[] {
                        LocalCASRequestMessage}, callback, asyncState);
        }
        
        /// <remarks/>
        public LocalCASResponseMessage EndLocalCAS(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((LocalCASResponseMessage)(results[0]));
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("SharpDevelop", "2.2.1.2648")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.scottishcitizen.gov.uk/localgateway")]
    public partial class LocalCASRequestMessage
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RequestHeaderType Header;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement Any;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("SharpDevelop", "2.2.1.2648")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.scottishcitizen.gov.uk/localgateway")]
    public partial class RequestHeaderType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UserID;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CorrelationID;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime Timestamp;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("SharpDevelop", "2.2.1.2648")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.scottishcitizen.gov.uk/localgateway")]
    public partial class ResponseHeaderType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CorrelationID;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime Timestamp;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Status Status;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("SharpDevelop", "2.2.1.2648")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.scottishcitizen.gov.uk/localgateway/core/1.0")]
    public enum Status
    {
        
        /// <remarks/>
        OK,
        
        /// <remarks/>
        Failed,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("SharpDevelop", "2.2.1.2648")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.scottishcitizen.gov.uk/localgateway")]
    public partial class LocalCASResponseMessage
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ResponseHeaderType Header;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement Any;
    }
}