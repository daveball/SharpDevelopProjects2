//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace wse{
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.42.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="SubmitMessageSoapHttp", Namespace="http://www.scottishcitizen.gov.uk/service")]
public partial class CASEndpointBean : Microsoft.Web.Services3.WebServicesClientProtocol {
    
    private System.Threading.SendOrPostCallback sendCitizenAccountMessageOperationCompleted;
    
    /// <remarks/>
    public CASEndpointBean() {
        this.Url = "http://la1.scottishcitizen.gov.uk/CASWebService/CASEndpointBean";
         //this.Url = "https://uatla.scottishcitizen.gov.uk/CASWebService/CASEndpointBean";
    }
    
    /// <remarks/>
    public event sendCitizenAccountMessageCompletedEventHandler sendCitizenAccountMessageCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.scottishcitizen.gov.uk/service/sendCitizenAccountMessage", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
    [return: System.Xml.Serialization.XmlElementAttribute("CitizenAccountResponseMessage", Namespace="http://www.scottishcitizen.gov.uk/service")]
    public CitizenAccountResponseMessage sendCitizenAccountMessage([System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.scottishcitizen.gov.uk/service")] CitizenAccountRequestMessage CitizenAccountRequestMessage) {
        object[] results = this.Invoke("sendCitizenAccountMessage", new object[] {
                    CitizenAccountRequestMessage});
        return ((CitizenAccountResponseMessage)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginsendCitizenAccountMessage(CitizenAccountRequestMessage CitizenAccountRequestMessage, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("sendCitizenAccountMessage", new object[] {
                    CitizenAccountRequestMessage}, callback, asyncState);
    }
    
    /// <remarks/>
    public CitizenAccountResponseMessage EndsendCitizenAccountMessage(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((CitizenAccountResponseMessage)(results[0]));
    }
    
    /// <remarks/>
    public void sendCitizenAccountMessageAsync(CitizenAccountRequestMessage CitizenAccountRequestMessage) {
        this.sendCitizenAccountMessageAsync(CitizenAccountRequestMessage, null);
    }
    
    /// <remarks/>
    public void sendCitizenAccountMessageAsync(CitizenAccountRequestMessage CitizenAccountRequestMessage, object userState) {
        if ((this.sendCitizenAccountMessageOperationCompleted == null)) {
            this.sendCitizenAccountMessageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsendCitizenAccountMessageOperationCompleted);
        }
        this.InvokeAsync("sendCitizenAccountMessage", new object[] {
                    CitizenAccountRequestMessage}, this.sendCitizenAccountMessageOperationCompleted, userState);
    }
    
    private void OnsendCitizenAccountMessageOperationCompleted(object arg) {
        if ((this.sendCitizenAccountMessageCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.sendCitizenAccountMessageCompleted(this, new sendCitizenAccountMessageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.scottishcitizen.gov.uk/service")]
public partial class CitizenAccountRequestMessage {
    
    private CitizenAccountRequestType cASRequestDataField;
    
    /// <remarks/>
    public CitizenAccountRequestType CASRequestData {
        get {
            return this.cASRequestDataField;
        }
        set {
            this.cASRequestDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.scottishcitizen.gov.uk/service")]
public partial class CitizenAccountRequestType {
    
    private CitizenAccountRequestHeaderType headerField;
    
    private System.Xml.XmlElement anyField;
    
    /// <remarks/>
    public CitizenAccountRequestHeaderType Header {
        get {
            return this.headerField;
        }
        set {
            this.headerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement Any {
        get {
            return this.anyField;
        }
        set {
            this.anyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.scottishcitizen.gov.uk/service")]
public partial class CitizenAccountRequestHeaderType {
    
    private string partnerIDField;
    
    private string userIDField;
    
    private string correlationIDField;
    
    private System.DateTime timestampField;
    
    /// <remarks/>
    public string PartnerID {
        get {
            return this.partnerIDField;
        }
        set {
            this.partnerIDField = value;
        }
    }
    
    /// <remarks/>
    public string UserID {
        get {
            return this.userIDField;
        }
        set {
            this.userIDField = value;
        }
    }
    
    /// <remarks/>
    public string CorrelationID {
        get {
            return this.correlationIDField;
        }
        set {
            this.correlationIDField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime Timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.scottishcitizen.gov.uk/service")]
public partial class CitizenAccountResponseHeaderType {
    
    private CitizenAccountRequestHeaderType requestHeaderField;
    
    private System.DateTime timestampField;
    
    private string statusField;
    
    /// <remarks/>
    public CitizenAccountRequestHeaderType RequestHeader {
        get {
            return this.requestHeaderField;
        }
        set {
            this.requestHeaderField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime Timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public string Status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.scottishcitizen.gov.uk/service")]
public partial class CitizenAccountResponseType {
    
    private CitizenAccountResponseHeaderType headerField;
    
    private System.Xml.XmlElement anyField;
    
    /// <remarks/>
    public CitizenAccountResponseHeaderType Header {
        get {
            return this.headerField;
        }
        set {
            this.headerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement Any {
        get {
            return this.anyField;
        }
        set {
            this.anyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.scottishcitizen.gov.uk/service")]
public partial class CitizenAccountResponseMessage {
    
    private CitizenAccountResponseType cASResponseDataField;
    
    /// <remarks/>
    public CitizenAccountResponseType CASResponseData {
        get {
            return this.cASResponseDataField;
        }
        set {
            this.cASResponseDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
public delegate void sendCitizenAccountMessageCompletedEventHandler(object sender, sendCitizenAccountMessageCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class sendCitizenAccountMessageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal sendCitizenAccountMessageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public CitizenAccountResponseMessage Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((CitizenAccountResponseMessage)(this.results[0]));
        }
    }
}
}

