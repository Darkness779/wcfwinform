﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLSV_1911060974_Hai.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/QLVS_1911060974_Hai")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Class1", Namespace="http://schemas.datacontract.org/2004/07/QLVS_1911060974_Hai")]
    [System.SerializableAttribute()]
    public partial class Class1 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HocphanField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MakhoaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MalopField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MasvField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TensvField;
        
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
        public string Hocphan {
            get {
                return this.HocphanField;
            }
            set {
                if ((object.ReferenceEquals(this.HocphanField, value) != true)) {
                    this.HocphanField = value;
                    this.RaisePropertyChanged("Hocphan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Makhoa {
            get {
                return this.MakhoaField;
            }
            set {
                if ((this.MakhoaField.Equals(value) != true)) {
                    this.MakhoaField = value;
                    this.RaisePropertyChanged("Makhoa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Malop {
            get {
                return this.MalopField;
            }
            set {
                if ((this.MalopField.Equals(value) != true)) {
                    this.MalopField = value;
                    this.RaisePropertyChanged("Malop");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Masv {
            get {
                return this.MasvField;
            }
            set {
                if ((this.MasvField.Equals(value) != true)) {
                    this.MasvField = value;
                    this.RaisePropertyChanged("Masv");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tensv {
            get {
                return this.TensvField;
            }
            set {
                if ((object.ReferenceEquals(this.TensvField, value) != true)) {
                    this.TensvField = value;
                    this.RaisePropertyChanged("Tensv");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        QLSV_1911060974_Hai.ServiceReference1.CompositeType GetDataUsingDataContract(QLSV_1911060974_Hai.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<QLSV_1911060974_Hai.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(QLSV_1911060974_Hai.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertClass1", ReplyAction="http://tempuri.org/IService1/InsertClass1Response")]
        int InsertClass1(QLSV_1911060974_Hai.ServiceReference1.Class1 p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertClass1", ReplyAction="http://tempuri.org/IService1/InsertClass1Response")]
        System.Threading.Tasks.Task<int> InsertClass1Async(QLSV_1911060974_Hai.ServiceReference1.Class1 p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateClass1", ReplyAction="http://tempuri.org/IService1/UpdateClass1Response")]
        int UpdateClass1(QLSV_1911060974_Hai.ServiceReference1.Class1 p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateClass1", ReplyAction="http://tempuri.org/IService1/UpdateClass1Response")]
        System.Threading.Tasks.Task<int> UpdateClass1Async(QLSV_1911060974_Hai.ServiceReference1.Class1 p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteClass1", ReplyAction="http://tempuri.org/IService1/DeleteClass1Response")]
        int DeleteClass1(QLSV_1911060974_Hai.ServiceReference1.Class1 p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteClass1", ReplyAction="http://tempuri.org/IService1/DeleteClass1Response")]
        System.Threading.Tasks.Task<int> DeleteClass1Async(QLSV_1911060974_Hai.ServiceReference1.Class1 p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClass1", ReplyAction="http://tempuri.org/IService1/GetClass1Response")]
        QLSV_1911060974_Hai.ServiceReference1.Class1 GetClass1(QLSV_1911060974_Hai.ServiceReference1.Class1 p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClass1", ReplyAction="http://tempuri.org/IService1/GetClass1Response")]
        System.Threading.Tasks.Task<QLSV_1911060974_Hai.ServiceReference1.Class1> GetClass1Async(QLSV_1911060974_Hai.ServiceReference1.Class1 p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllClass1s", ReplyAction="http://tempuri.org/IService1/GetAllClass1sResponse")]
        QLSV_1911060974_Hai.ServiceReference1.Class1[] GetAllClass1s();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllClass1s", ReplyAction="http://tempuri.org/IService1/GetAllClass1sResponse")]
        System.Threading.Tasks.Task<QLSV_1911060974_Hai.ServiceReference1.Class1[]> GetAllClass1sAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : QLSV_1911060974_Hai.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<QLSV_1911060974_Hai.ServiceReference1.IService1>, QLSV_1911060974_Hai.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public QLSV_1911060974_Hai.ServiceReference1.CompositeType GetDataUsingDataContract(QLSV_1911060974_Hai.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<QLSV_1911060974_Hai.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(QLSV_1911060974_Hai.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public int InsertClass1(QLSV_1911060974_Hai.ServiceReference1.Class1 p) {
            return base.Channel.InsertClass1(p);
        }
        
        public System.Threading.Tasks.Task<int> InsertClass1Async(QLSV_1911060974_Hai.ServiceReference1.Class1 p) {
            return base.Channel.InsertClass1Async(p);
        }
        
        public int UpdateClass1(QLSV_1911060974_Hai.ServiceReference1.Class1 p) {
            return base.Channel.UpdateClass1(p);
        }
        
        public System.Threading.Tasks.Task<int> UpdateClass1Async(QLSV_1911060974_Hai.ServiceReference1.Class1 p) {
            return base.Channel.UpdateClass1Async(p);
        }
        
        public int DeleteClass1(QLSV_1911060974_Hai.ServiceReference1.Class1 p) {
            return base.Channel.DeleteClass1(p);
        }
        
        public System.Threading.Tasks.Task<int> DeleteClass1Async(QLSV_1911060974_Hai.ServiceReference1.Class1 p) {
            return base.Channel.DeleteClass1Async(p);
        }
        
        public QLSV_1911060974_Hai.ServiceReference1.Class1 GetClass1(QLSV_1911060974_Hai.ServiceReference1.Class1 p) {
            return base.Channel.GetClass1(p);
        }
        
        public System.Threading.Tasks.Task<QLSV_1911060974_Hai.ServiceReference1.Class1> GetClass1Async(QLSV_1911060974_Hai.ServiceReference1.Class1 p) {
            return base.Channel.GetClass1Async(p);
        }
        
        public QLSV_1911060974_Hai.ServiceReference1.Class1[] GetAllClass1s() {
            return base.Channel.GetAllClass1s();
        }
        
        public System.Threading.Tasks.Task<QLSV_1911060974_Hai.ServiceReference1.Class1[]> GetAllClass1sAsync() {
            return base.Channel.GetAllClass1sAsync();
        }
    }
}