﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18444
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookSellerCS.BookSellerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/BookSellerWCF")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StockField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Genre {
            get {
                return this.GenreField;
            }
            set {
                if ((object.ReferenceEquals(this.GenreField, value) != true)) {
                    this.GenreField = value;
                    this.RaisePropertyChanged("Genre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Stock {
            get {
                return this.StockField;
            }
            set {
                if ((this.StockField.Equals(value) != true)) {
                    this.StockField = value;
                    this.RaisePropertyChanged("Stock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BookSellerService.IBookSellerService")]
    public interface IBookSellerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookSellerService/getBookById", ReplyAction="http://tempuri.org/IBookSellerService/getBookByIdResponse")]
        BookSellerCS.BookSellerService.Book getBookById(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookSellerService/getBookById", ReplyAction="http://tempuri.org/IBookSellerService/getBookByIdResponse")]
        System.Threading.Tasks.Task<BookSellerCS.BookSellerService.Book> getBookByIdAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookSellerService/getAllBooks", ReplyAction="http://tempuri.org/IBookSellerService/getAllBooksResponse")]
        BookSellerCS.BookSellerService.Book[] getAllBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookSellerService/getAllBooks", ReplyAction="http://tempuri.org/IBookSellerService/getAllBooksResponse")]
        System.Threading.Tasks.Task<BookSellerCS.BookSellerService.Book[]> getAllBooksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookSellerService/getBooksByAuthor", ReplyAction="http://tempuri.org/IBookSellerService/getBooksByAuthorResponse")]
        BookSellerCS.BookSellerService.Book[] getBooksByAuthor(string author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookSellerService/getBooksByAuthor", ReplyAction="http://tempuri.org/IBookSellerService/getBooksByAuthorResponse")]
        System.Threading.Tasks.Task<BookSellerCS.BookSellerService.Book[]> getBooksByAuthorAsync(string author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookSellerService/getBookByGenre", ReplyAction="http://tempuri.org/IBookSellerService/getBookByGenreResponse")]
        BookSellerCS.BookSellerService.Book[] getBookByGenre(string genre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookSellerService/getBookByGenre", ReplyAction="http://tempuri.org/IBookSellerService/getBookByGenreResponse")]
        System.Threading.Tasks.Task<BookSellerCS.BookSellerService.Book[]> getBookByGenreAsync(string genre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookSellerService/takeBooks", ReplyAction="http://tempuri.org/IBookSellerService/takeBooksResponse")]
        int takeBooks(string theBook, int nb);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookSellerService/takeBooks", ReplyAction="http://tempuri.org/IBookSellerService/takeBooksResponse")]
        System.Threading.Tasks.Task<int> takeBooksAsync(string theBook, int nb);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookSellerServiceChannel : BookSellerCS.BookSellerService.IBookSellerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookSellerServiceClient : System.ServiceModel.ClientBase<BookSellerCS.BookSellerService.IBookSellerService>, BookSellerCS.BookSellerService.IBookSellerService {
        
        public BookSellerServiceClient() {
        }
        
        public BookSellerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookSellerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookSellerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookSellerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BookSellerCS.BookSellerService.Book getBookById(string id) {
            return base.Channel.getBookById(id);
        }
        
        public System.Threading.Tasks.Task<BookSellerCS.BookSellerService.Book> getBookByIdAsync(string id) {
            return base.Channel.getBookByIdAsync(id);
        }
        
        public BookSellerCS.BookSellerService.Book[] getAllBooks() {
            return base.Channel.getAllBooks();
        }
        
        public System.Threading.Tasks.Task<BookSellerCS.BookSellerService.Book[]> getAllBooksAsync() {
            return base.Channel.getAllBooksAsync();
        }
        
        public BookSellerCS.BookSellerService.Book[] getBooksByAuthor(string author) {
            return base.Channel.getBooksByAuthor(author);
        }
        
        public System.Threading.Tasks.Task<BookSellerCS.BookSellerService.Book[]> getBooksByAuthorAsync(string author) {
            return base.Channel.getBooksByAuthorAsync(author);
        }
        
        public BookSellerCS.BookSellerService.Book[] getBookByGenre(string genre) {
            return base.Channel.getBookByGenre(genre);
        }
        
        public System.Threading.Tasks.Task<BookSellerCS.BookSellerService.Book[]> getBookByGenreAsync(string genre) {
            return base.Channel.getBookByGenreAsync(genre);
        }
        
        public int takeBooks(string theBook, int nb) {
            return base.Channel.takeBooks(theBook, nb);
        }
        
        public System.Threading.Tasks.Task<int> takeBooksAsync(string theBook, int nb) {
            return base.Channel.takeBooksAsync(theBook, nb);
        }
    }
}
