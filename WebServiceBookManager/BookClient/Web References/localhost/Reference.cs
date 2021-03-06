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

namespace BookClient.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BookServiceSoap", Namespace="http://tempuri.org/")]
    public partial class BookService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getBooksOperationCompleted;
        
        private System.Threading.SendOrPostCallback addBookOperationCompleted;
        
        private System.Threading.SendOrPostCallback updateBookOperationCompleted;
        
        private System.Threading.SendOrPostCallback deleteBookOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public BookService() {
            this.Url = global::BookClient.Properties.Settings.Default.BookClient_BookService_BookService;
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
        public event getBooksCompletedEventHandler getBooksCompleted;
        
        /// <remarks/>
        public event addBookCompletedEventHandler addBookCompleted;
        
        /// <remarks/>
        public event updateBookCompletedEventHandler updateBookCompleted;
        
        /// <remarks/>
        public event deleteBookCompletedEventHandler deleteBookCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getBooks", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getBooks() {
            object[] results = this.Invoke("getBooks", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getBooksAsync() {
            this.getBooksAsync(null);
        }
        
        /// <remarks/>
        public void getBooksAsync(object userState) {
            if ((this.getBooksOperationCompleted == null)) {
                this.getBooksOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetBooksOperationCompleted);
            }
            this.InvokeAsync("getBooks", new object[0], this.getBooksOperationCompleted, userState);
        }
        
        private void OngetBooksOperationCompleted(object arg) {
            if ((this.getBooksCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getBooksCompleted(this, new getBooksCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/addBook", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool addBook(int bookID, string bookName, float bookPrice) {
            object[] results = this.Invoke("addBook", new object[] {
                        bookID,
                        bookName,
                        bookPrice});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void addBookAsync(int bookID, string bookName, float bookPrice) {
            this.addBookAsync(bookID, bookName, bookPrice, null);
        }
        
        /// <remarks/>
        public void addBookAsync(int bookID, string bookName, float bookPrice, object userState) {
            if ((this.addBookOperationCompleted == null)) {
                this.addBookOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaddBookOperationCompleted);
            }
            this.InvokeAsync("addBook", new object[] {
                        bookID,
                        bookName,
                        bookPrice}, this.addBookOperationCompleted, userState);
        }
        
        private void OnaddBookOperationCompleted(object arg) {
            if ((this.addBookCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.addBookCompleted(this, new addBookCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/updateBook", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool updateBook(int bookID, string bookName, float bookPrice) {
            object[] results = this.Invoke("updateBook", new object[] {
                        bookID,
                        bookName,
                        bookPrice});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void updateBookAsync(int bookID, string bookName, float bookPrice) {
            this.updateBookAsync(bookID, bookName, bookPrice, null);
        }
        
        /// <remarks/>
        public void updateBookAsync(int bookID, string bookName, float bookPrice, object userState) {
            if ((this.updateBookOperationCompleted == null)) {
                this.updateBookOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateBookOperationCompleted);
            }
            this.InvokeAsync("updateBook", new object[] {
                        bookID,
                        bookName,
                        bookPrice}, this.updateBookOperationCompleted, userState);
        }
        
        private void OnupdateBookOperationCompleted(object arg) {
            if ((this.updateBookCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updateBookCompleted(this, new updateBookCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/deleteBook", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool deleteBook(int bookID) {
            object[] results = this.Invoke("deleteBook", new object[] {
                        bookID});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void deleteBookAsync(int bookID) {
            this.deleteBookAsync(bookID, null);
        }
        
        /// <remarks/>
        public void deleteBookAsync(int bookID, object userState) {
            if ((this.deleteBookOperationCompleted == null)) {
                this.deleteBookOperationCompleted = new System.Threading.SendOrPostCallback(this.OndeleteBookOperationCompleted);
            }
            this.InvokeAsync("deleteBook", new object[] {
                        bookID}, this.deleteBookOperationCompleted, userState);
        }
        
        private void OndeleteBookOperationCompleted(object arg) {
            if ((this.deleteBookCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.deleteBookCompleted(this, new deleteBookCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void getBooksCompletedEventHandler(object sender, getBooksCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getBooksCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getBooksCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void addBookCompletedEventHandler(object sender, addBookCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class addBookCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal addBookCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void updateBookCompletedEventHandler(object sender, updateBookCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class updateBookCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal updateBookCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void deleteBookCompletedEventHandler(object sender, deleteBookCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class deleteBookCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal deleteBookCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591