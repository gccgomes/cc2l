﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.ImageViewer.StudyManagement.Core.Configuration
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="configuration")]
	public partial class ConfigurationDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertConfigurationDocument(ConfigurationDocument instance);
    partial void UpdateConfigurationDocument(ConfigurationDocument instance);
    partial void DeleteConfigurationDocument(ConfigurationDocument instance);
    #endregion
		
		public ConfigurationDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConfigurationDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConfigurationDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConfigurationDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ConfigurationDocument> ConfigurationDocuments
		{
			get
			{
				return this.GetTable<ConfigurationDocument>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute()]
	public partial class ConfigurationDocument : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Oid;
		
		private string _DocumentName;
		
		private string _DocumentVersionString;
		
		private string _User;
		
		private string _InstanceKey;
		
		private System.DateTime _CreationTime;
		
		private string _DocumentText;
		
		private System.Data.Linq.Binary _Version;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOidChanging(long value);
    partial void OnOidChanged();
    partial void OnDocumentNameChanging(string value);
    partial void OnDocumentNameChanged();
    partial void OnDocumentVersionStringChanging(string value);
    partial void OnDocumentVersionStringChanged();
    partial void OnUserChanging(string value);
    partial void OnUserChanged();
    partial void OnInstanceKeyChanging(string value);
    partial void OnInstanceKeyChanged();
    partial void OnCreationTimeChanging(System.DateTime value);
    partial void OnCreationTimeChanged();
    partial void OnDocumentTextChanging(string value);
    partial void OnDocumentTextChanged();
    partial void OnVersionChanging(System.Data.Linq.Binary value);
    partial void OnVersionChanged();
    #endregion
		
		public ConfigurationDocument()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Oid", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public long Oid
		{
			get
			{
				return this._Oid;
			}
			set
			{
				if ((this._Oid != value))
				{
					this.OnOidChanging(value);
					this.SendPropertyChanging();
					this._Oid = value;
					this.SendPropertyChanged("Oid");
					this.OnOidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DocumentName", DbType="NVarChar(255) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string DocumentName
		{
			get
			{
				return this._DocumentName;
			}
			set
			{
				if ((this._DocumentName != value))
				{
					this.OnDocumentNameChanging(value);
					this.SendPropertyChanging();
					this._DocumentName = value;
					this.SendPropertyChanged("DocumentName");
					this.OnDocumentNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DocumentVersionString", DbType="NVarChar(30) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string DocumentVersionString
		{
			get
			{
				return this._DocumentVersionString;
			}
			set
			{
				if ((this._DocumentVersionString != value))
				{
					this.OnDocumentVersionStringChanging(value);
					this.SendPropertyChanging();
					this._DocumentVersionString = value;
					this.SendPropertyChanged("DocumentVersionString");
					this.OnDocumentVersionStringChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User", DbType="NVarChar(50) NULL", UpdateCheck=UpdateCheck.Never)]
		public string User
		{
			get
			{
				return this._User;
			}
			set
			{
				if ((this._User != value))
				{
					this.OnUserChanging(value);
					this.SendPropertyChanging();
					this._User = value;
					this.SendPropertyChanged("User");
					this.OnUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InstanceKey", DbType="NVarChar(100) NULL", UpdateCheck=UpdateCheck.Never)]
		public string InstanceKey
		{
			get
			{
				return this._InstanceKey;
			}
			set
			{
				if ((this._InstanceKey != value))
				{
					this.OnInstanceKeyChanging(value);
					this.SendPropertyChanging();
					this._InstanceKey = value;
					this.SendPropertyChanged("InstanceKey");
					this.OnInstanceKeyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreationTime", DbType="DateTime NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public System.DateTime CreationTime
		{
			get
			{
				return this._CreationTime;
			}
			set
			{
				if ((this._CreationTime != value))
				{
					this.OnCreationTimeChanging(value);
					this.SendPropertyChanging();
					this._CreationTime = value;
					this.SendPropertyChanged("CreationTime");
					this.OnCreationTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DocumentText", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string DocumentText
		{
			get
			{
				return this._DocumentText;
			}
			set
			{
				if ((this._DocumentText != value))
				{
					this.OnDocumentTextChanging(value);
					this.SendPropertyChanging();
					this._DocumentText = value;
					this.SendPropertyChanged("DocumentText");
					this.OnDocumentTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Version", AutoSync=AutoSync.Always, DbType="rowversion", CanBeNull=false, IsDbGenerated=true, IsVersion=true, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Version
		{
			get
			{
				return this._Version;
			}
			set
			{
				if ((this._Version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._Version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
