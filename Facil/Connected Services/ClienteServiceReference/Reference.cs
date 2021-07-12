﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Facil.ClienteServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Clientes", Namespace="http://schemas.datacontract.org/2004/07/Facil.Objetos")]
    [System.SerializableAttribute()]
    public partial class Clientes : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CPFField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdSituacaoClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdTipoClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexoField;
        
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
        public string CPF {
            get {
                return this.CPFField;
            }
            set {
                if ((object.ReferenceEquals(this.CPFField, value) != true)) {
                    this.CPFField = value;
                    this.RaisePropertyChanged("CPF");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdCliente {
            get {
                return this.IdClienteField;
            }
            set {
                if ((this.IdClienteField.Equals(value) != true)) {
                    this.IdClienteField = value;
                    this.RaisePropertyChanged("IdCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdSituacaoCliente {
            get {
                return this.IdSituacaoClienteField;
            }
            set {
                if ((this.IdSituacaoClienteField.Equals(value) != true)) {
                    this.IdSituacaoClienteField = value;
                    this.RaisePropertyChanged("IdSituacaoCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdTipoCliente {
            get {
                return this.IdTipoClienteField;
            }
            set {
                if ((this.IdTipoClienteField.Equals(value) != true)) {
                    this.IdTipoClienteField = value;
                    this.RaisePropertyChanged("IdTipoCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sexo {
            get {
                return this.SexoField;
            }
            set {
                if ((object.ReferenceEquals(this.SexoField, value) != true)) {
                    this.SexoField = value;
                    this.RaisePropertyChanged("Sexo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClienteServiceReference.ICliente_Service")]
    public interface ICliente_Service {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente_Service/ListarClientes", ReplyAction="http://tempuri.org/ICliente_Service/ListarClientesResponse")]
        Facil.ClienteServiceReference.Clientes[] ListarClientes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente_Service/ListarClientes", ReplyAction="http://tempuri.org/ICliente_Service/ListarClientesResponse")]
        System.Threading.Tasks.Task<Facil.ClienteServiceReference.Clientes[]> ListarClientesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente_Service/BuscarCliente", ReplyAction="http://tempuri.org/ICliente_Service/BuscarClienteResponse")]
        Facil.ClienteServiceReference.Clientes BuscarCliente(string nome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente_Service/BuscarCliente", ReplyAction="http://tempuri.org/ICliente_Service/BuscarClienteResponse")]
        System.Threading.Tasks.Task<Facil.ClienteServiceReference.Clientes> BuscarClienteAsync(string nome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente_Service/InserirCliente", ReplyAction="http://tempuri.org/ICliente_Service/InserirClienteResponse")]
        void InserirCliente(string nome, string cpf, int idTipoCliente, string sexo, int idSituacaoCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente_Service/InserirCliente", ReplyAction="http://tempuri.org/ICliente_Service/InserirClienteResponse")]
        System.Threading.Tasks.Task InserirClienteAsync(string nome, string cpf, int idTipoCliente, string sexo, int idSituacaoCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente_Service/RemoverCliente", ReplyAction="http://tempuri.org/ICliente_Service/RemoverClienteResponse")]
        void RemoverCliente(int idCliente, int idTipoCliente, int idSituacaoCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente_Service/RemoverCliente", ReplyAction="http://tempuri.org/ICliente_Service/RemoverClienteResponse")]
        System.Threading.Tasks.Task RemoverClienteAsync(int idCliente, int idTipoCliente, int idSituacaoCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente_Service/AlterarCliente", ReplyAction="http://tempuri.org/ICliente_Service/AlterarClienteResponse")]
        string AlterarCliente(int idCliente, string nome, string cpf, string sexo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente_Service/AlterarCliente", ReplyAction="http://tempuri.org/ICliente_Service/AlterarClienteResponse")]
        System.Threading.Tasks.Task<string> AlterarClienteAsync(int idCliente, string nome, string cpf, string sexo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICliente_ServiceChannel : Facil.ClienteServiceReference.ICliente_Service, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Cliente_ServiceClient : System.ServiceModel.ClientBase<Facil.ClienteServiceReference.ICliente_Service>, Facil.ClienteServiceReference.ICliente_Service {
        
        public Cliente_ServiceClient() {
        }
        
        public Cliente_ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Cliente_ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Cliente_ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Cliente_ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Facil.ClienteServiceReference.Clientes[] ListarClientes() {
            return base.Channel.ListarClientes();
        }
        
        public System.Threading.Tasks.Task<Facil.ClienteServiceReference.Clientes[]> ListarClientesAsync() {
            return base.Channel.ListarClientesAsync();
        }
        
        public Facil.ClienteServiceReference.Clientes BuscarCliente(string nome) {
            return base.Channel.BuscarCliente(nome);
        }
        
        public System.Threading.Tasks.Task<Facil.ClienteServiceReference.Clientes> BuscarClienteAsync(string nome) {
            return base.Channel.BuscarClienteAsync(nome);
        }
        
        public void InserirCliente(string nome, string cpf, int idTipoCliente, string sexo, int idSituacaoCliente) {
            base.Channel.InserirCliente(nome, cpf, idTipoCliente, sexo, idSituacaoCliente);
        }
        
        public System.Threading.Tasks.Task InserirClienteAsync(string nome, string cpf, int idTipoCliente, string sexo, int idSituacaoCliente) {
            return base.Channel.InserirClienteAsync(nome, cpf, idTipoCliente, sexo, idSituacaoCliente);
        }
        
        public void RemoverCliente(int idCliente, int idTipoCliente, int idSituacaoCliente) {
            base.Channel.RemoverCliente(idCliente, idTipoCliente, idSituacaoCliente);
        }
        
        public System.Threading.Tasks.Task RemoverClienteAsync(int idCliente, int idTipoCliente, int idSituacaoCliente) {
            return base.Channel.RemoverClienteAsync(idCliente, idTipoCliente, idSituacaoCliente);
        }
        
        public string AlterarCliente(int idCliente, string nome, string cpf, string sexo) {
            return base.Channel.AlterarCliente(idCliente, nome, cpf, sexo);
        }
        
        public System.Threading.Tasks.Task<string> AlterarClienteAsync(int idCliente, string nome, string cpf, string sexo) {
            return base.Channel.AlterarClienteAsync(idCliente, nome, cpf, sexo);
        }
    }
}