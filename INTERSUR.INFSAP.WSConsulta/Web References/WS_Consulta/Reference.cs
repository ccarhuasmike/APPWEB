﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace INTERSUR.INFSAP.WSConsulta.WS_Consulta {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SI_ConsulComprPagoSapSyncOutBinding", Namespace="urn:cccc.telectronica.consulcompropagosap")]
    public partial class SI_ConsulComprPagoSapSyncOutService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SI_ConsulComprPagoSapSyncOutOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SI_ConsulComprPagoSapSyncOutService() {
            this.Url = global::INTERSUR.INFSAP.WSConsulta.Properties.Settings.Default.INTERSUR_INFSAP_WSConsulta_WS_Consulta_SI_ConsulComprPagoSapSyncOutService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event SI_ConsulComprPagoSapSyncOutCompletedEventHandler SI_ConsulComprPagoSapSyncOutCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://sap.com/xi/WebService/soap1.1", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("MT_ConsulComproPagoSap_response", Namespace="urn:cccc.telectronica.consulcompropagosap")]
        public DT_ConsulComproPagoSap_response SI_ConsulComprPagoSapSyncOut([System.Xml.Serialization.XmlElementAttribute(Namespace="urn:cccc.telectronica.consulcompropagosap")] DT_ConsulComproPagoSap MT_ConsulComproPagoSap) {
            object[] results = this.Invoke("SI_ConsulComprPagoSapSyncOut", new object[] {
                        MT_ConsulComproPagoSap});
            return ((DT_ConsulComproPagoSap_response)(results[0]));
        }
        
        /// <remarks/>
        public void SI_ConsulComprPagoSapSyncOutAsync(DT_ConsulComproPagoSap MT_ConsulComproPagoSap) {
            this.SI_ConsulComprPagoSapSyncOutAsync(MT_ConsulComproPagoSap, null);
        }
        
        /// <remarks/>
        public void SI_ConsulComprPagoSapSyncOutAsync(DT_ConsulComproPagoSap MT_ConsulComproPagoSap, object userState) {
            if ((this.SI_ConsulComprPagoSapSyncOutOperationCompleted == null)) {
                this.SI_ConsulComprPagoSapSyncOutOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSI_ConsulComprPagoSapSyncOutOperationCompleted);
            }
            this.InvokeAsync("SI_ConsulComprPagoSapSyncOut", new object[] {
                        MT_ConsulComproPagoSap}, this.SI_ConsulComprPagoSapSyncOutOperationCompleted, userState);
        }
        
        private void OnSI_ConsulComprPagoSapSyncOutOperationCompleted(object arg) {
            if ((this.SI_ConsulComprPagoSapSyncOutCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SI_ConsulComprPagoSapSyncOutCompleted(this, new SI_ConsulComprPagoSapSyncOutCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:cccc.telectronica.consulcompropagosap")]
    public partial class DT_ConsulComproPagoSap {
        
        private string nUM_DOCField;
        
        private string tIP_DOCField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NUM_DOC {
            get {
                return this.nUM_DOCField;
            }
            set {
                this.nUM_DOCField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TIP_DOC {
            get {
                return this.tIP_DOCField;
            }
            set {
                this.tIP_DOCField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:cccc.telectronica.consulcompropagosap")]
    public partial class DT_ConsulComproPagoSap_response {
        
        private string nUM_DOCField;
        
        private string tIP_DOCField;
        
        private string cOD_STAField;
        
        private string dES_STAField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NUM_DOC {
            get {
                return this.nUM_DOCField;
            }
            set {
                this.nUM_DOCField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TIP_DOC {
            get {
                return this.tIP_DOCField;
            }
            set {
                this.tIP_DOCField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string COD_STA {
            get {
                return this.cOD_STAField;
            }
            set {
                this.cOD_STAField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DES_STA {
            get {
                return this.dES_STAField;
            }
            set {
                this.dES_STAField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void SI_ConsulComprPagoSapSyncOutCompletedEventHandler(object sender, SI_ConsulComprPagoSapSyncOutCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SI_ConsulComprPagoSapSyncOutCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SI_ConsulComprPagoSapSyncOutCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DT_ConsulComproPagoSap_response Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DT_ConsulComproPagoSap_response)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591