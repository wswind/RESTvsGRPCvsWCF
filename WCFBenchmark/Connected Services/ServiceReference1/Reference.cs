﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFBenchmark.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MeteoriteLanding", Namespace="http://schemas.datacontract.org/2004/07/ModelLibraryWCF.WCF")]
    [System.SerializableAttribute()]
    public partial class MeteoriteLanding : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FallField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFBenchmark.ServiceReference1.GeoLocation GeoLocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double MassField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RecClassField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double RecLATField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double RecLONGField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime YearField;
        
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
        public string Fall {
            get {
                return this.FallField;
            }
            set {
                if ((object.ReferenceEquals(this.FallField, value) != true)) {
                    this.FallField = value;
                    this.RaisePropertyChanged("Fall");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WCFBenchmark.ServiceReference1.GeoLocation GeoLocation {
            get {
                return this.GeoLocationField;
            }
            set {
                if ((object.ReferenceEquals(this.GeoLocationField, value) != true)) {
                    this.GeoLocationField = value;
                    this.RaisePropertyChanged("GeoLocation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Mass {
            get {
                return this.MassField;
            }
            set {
                if ((this.MassField.Equals(value) != true)) {
                    this.MassField = value;
                    this.RaisePropertyChanged("Mass");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameType {
            get {
                return this.NameTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.NameTypeField, value) != true)) {
                    this.NameTypeField = value;
                    this.RaisePropertyChanged("NameType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RecClass {
            get {
                return this.RecClassField;
            }
            set {
                if ((object.ReferenceEquals(this.RecClassField, value) != true)) {
                    this.RecClassField = value;
                    this.RaisePropertyChanged("RecClass");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double RecLAT {
            get {
                return this.RecLATField;
            }
            set {
                if ((this.RecLATField.Equals(value) != true)) {
                    this.RecLATField = value;
                    this.RaisePropertyChanged("RecLAT");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double RecLONG {
            get {
                return this.RecLONGField;
            }
            set {
                if ((this.RecLONGField.Equals(value) != true)) {
                    this.RecLONGField = value;
                    this.RaisePropertyChanged("RecLONG");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="GeoLocation", Namespace="http://schemas.datacontract.org/2004/07/ModelLibraryWCF.WCF")]
    [System.SerializableAttribute()]
    public partial class GeoLocation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double[] CoordinatesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
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
        public double[] Coordinates {
            get {
                return this.CoordinatesField;
            }
            set {
                if ((object.ReferenceEquals(this.CoordinatesField, value) != true)) {
                    this.CoordinatesField = value;
                    this.RaisePropertyChanged("Coordinates");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMeteoriteLandingsService")]
    public interface IMeteoriteLandingsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeteoriteLandingsService/GetSmallPayload", ReplyAction="http://tempuri.org/IMeteoriteLandingsService/GetSmallPayloadResponse")]
        string GetSmallPayload();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeteoriteLandingsService/GetSmallPayload", ReplyAction="http://tempuri.org/IMeteoriteLandingsService/GetSmallPayloadResponse")]
        System.Threading.Tasks.Task<string> GetSmallPayloadAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeteoriteLandingsService/GetLargePayload", ReplyAction="http://tempuri.org/IMeteoriteLandingsService/GetLargePayloadResponse")]
        WCFBenchmark.ServiceReference1.MeteoriteLanding[] GetLargePayload();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeteoriteLandingsService/GetLargePayload", ReplyAction="http://tempuri.org/IMeteoriteLandingsService/GetLargePayloadResponse")]
        System.Threading.Tasks.Task<WCFBenchmark.ServiceReference1.MeteoriteLanding[]> GetLargePayloadAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeteoriteLandingsService/PostLargePayload", ReplyAction="http://tempuri.org/IMeteoriteLandingsService/PostLargePayloadResponse")]
        string PostLargePayload(WCFBenchmark.ServiceReference1.MeteoriteLanding[] meteoriteLandings);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeteoriteLandingsService/PostLargePayload", ReplyAction="http://tempuri.org/IMeteoriteLandingsService/PostLargePayloadResponse")]
        System.Threading.Tasks.Task<string> PostLargePayloadAsync(WCFBenchmark.ServiceReference1.MeteoriteLanding[] meteoriteLandings);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMeteoriteLandingsServiceChannel : WCFBenchmark.ServiceReference1.IMeteoriteLandingsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MeteoriteLandingsServiceClient : System.ServiceModel.ClientBase<WCFBenchmark.ServiceReference1.IMeteoriteLandingsService>, WCFBenchmark.ServiceReference1.IMeteoriteLandingsService {
        
        public MeteoriteLandingsServiceClient() {
        }
        
        public MeteoriteLandingsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MeteoriteLandingsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MeteoriteLandingsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MeteoriteLandingsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetSmallPayload() {
            return base.Channel.GetSmallPayload();
        }
        
        public System.Threading.Tasks.Task<string> GetSmallPayloadAsync() {
            return base.Channel.GetSmallPayloadAsync();
        }
        
        public WCFBenchmark.ServiceReference1.MeteoriteLanding[] GetLargePayload() {
            return base.Channel.GetLargePayload();
        }
        
        public System.Threading.Tasks.Task<WCFBenchmark.ServiceReference1.MeteoriteLanding[]> GetLargePayloadAsync() {
            return base.Channel.GetLargePayloadAsync();
        }
        
        public string PostLargePayload(WCFBenchmark.ServiceReference1.MeteoriteLanding[] meteoriteLandings) {
            return base.Channel.PostLargePayload(meteoriteLandings);
        }
        
        public System.Threading.Tasks.Task<string> PostLargePayloadAsync(WCFBenchmark.ServiceReference1.MeteoriteLanding[] meteoriteLandings) {
            return base.Channel.PostLargePayloadAsync(meteoriteLandings);
        }
    }
}