﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ORMandLINQ
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="IN700001_201601_HORNERB1")]
	public partial class LightningStriksDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblFire(tblFire instance);
    partial void UpdatetblFire(tblFire instance);
    partial void DeletetblFire(tblFire instance);
    partial void InserttblStrike(tblStrike instance);
    partial void UpdatetblStrike(tblStrike instance);
    partial void DeletetblStrike(tblStrike instance);
    partial void InserttblPicture(tblPicture instance);
    partial void UpdatetblPicture(tblPicture instance);
    partial void DeletetblPicture(tblPicture instance);
    #endregion
		
		public LightningStriksDBDataContext() : 
				base(global::ORMandLINQ.Properties.Settings.Default.IN700001_201601_HORNERB1ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LightningStriksDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LightningStriksDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LightningStriksDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LightningStriksDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblFire> tblFires
		{
			get
			{
				return this.GetTable<tblFire>();
			}
		}
		
		public System.Data.Linq.Table<tblStrike> tblStrikes
		{
			get
			{
				return this.GetTable<tblStrike>();
			}
		}
		
		public System.Data.Linq.Table<tblPicture> tblPictures
		{
			get
			{
				return this.GetTable<tblPicture>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblFire")]
	public partial class tblFire : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _fireID;
		
		private System.DateTime _fireDate;
		
		private decimal _fireLatitude;
		
		private decimal _fireLongitude;
		
		private decimal _fireArea;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnfireIDChanging(int value);
    partial void OnfireIDChanged();
    partial void OnfireDateChanging(System.DateTime value);
    partial void OnfireDateChanged();
    partial void OnfireLatitudeChanging(decimal value);
    partial void OnfireLatitudeChanged();
    partial void OnfireLongitudeChanging(decimal value);
    partial void OnfireLongitudeChanged();
    partial void OnfireAreaChanging(decimal value);
    partial void OnfireAreaChanged();
    #endregion
		
		public tblFire()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fireID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int fireID
		{
			get
			{
				return this._fireID;
			}
			set
			{
				if ((this._fireID != value))
				{
					this.OnfireIDChanging(value);
					this.SendPropertyChanging();
					this._fireID = value;
					this.SendPropertyChanged("fireID");
					this.OnfireIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fireDate", DbType="Date NOT NULL")]
		public System.DateTime fireDate
		{
			get
			{
				return this._fireDate;
			}
			set
			{
				if ((this._fireDate != value))
				{
					this.OnfireDateChanging(value);
					this.SendPropertyChanging();
					this._fireDate = value;
					this.SendPropertyChanged("fireDate");
					this.OnfireDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fireLatitude", DbType="Decimal(5,2) NOT NULL")]
		public decimal fireLatitude
		{
			get
			{
				return this._fireLatitude;
			}
			set
			{
				if ((this._fireLatitude != value))
				{
					this.OnfireLatitudeChanging(value);
					this.SendPropertyChanging();
					this._fireLatitude = value;
					this.SendPropertyChanged("fireLatitude");
					this.OnfireLatitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fireLongitude", DbType="Decimal(5,2) NOT NULL")]
		public decimal fireLongitude
		{
			get
			{
				return this._fireLongitude;
			}
			set
			{
				if ((this._fireLongitude != value))
				{
					this.OnfireLongitudeChanging(value);
					this.SendPropertyChanging();
					this._fireLongitude = value;
					this.SendPropertyChanged("fireLongitude");
					this.OnfireLongitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fireArea", DbType="Decimal(6,2) NOT NULL")]
		public decimal fireArea
		{
			get
			{
				return this._fireArea;
			}
			set
			{
				if ((this._fireArea != value))
				{
					this.OnfireAreaChanging(value);
					this.SendPropertyChanging();
					this._fireArea = value;
					this.SendPropertyChanged("fireArea");
					this.OnfireAreaChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblStrike")]
	public partial class tblStrike : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _strikeID;
		
		private System.DateTime _strikeDate;
		
		private System.TimeSpan _strikeTime;
		
		private decimal _strikeLatitude;
		
		private decimal _strikeLongitude;
		
		private int _strikeIntensity;
		
		private EntitySet<tblPicture> _tblPictures;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnstrikeIDChanging(int value);
    partial void OnstrikeIDChanged();
    partial void OnstrikeDateChanging(System.DateTime value);
    partial void OnstrikeDateChanged();
    partial void OnstrikeTimeChanging(System.TimeSpan value);
    partial void OnstrikeTimeChanged();
    partial void OnstrikeLatitudeChanging(decimal value);
    partial void OnstrikeLatitudeChanged();
    partial void OnstrikeLongitudeChanging(decimal value);
    partial void OnstrikeLongitudeChanged();
    partial void OnstrikeIntensityChanging(int value);
    partial void OnstrikeIntensityChanged();
    #endregion
		
		public tblStrike()
		{
			this._tblPictures = new EntitySet<tblPicture>(new Action<tblPicture>(this.attach_tblPictures), new Action<tblPicture>(this.detach_tblPictures));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_strikeID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int strikeID
		{
			get
			{
				return this._strikeID;
			}
			set
			{
				if ((this._strikeID != value))
				{
					this.OnstrikeIDChanging(value);
					this.SendPropertyChanging();
					this._strikeID = value;
					this.SendPropertyChanged("strikeID");
					this.OnstrikeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_strikeDate", DbType="Date NOT NULL")]
		public System.DateTime strikeDate
		{
			get
			{
				return this._strikeDate;
			}
			set
			{
				if ((this._strikeDate != value))
				{
					this.OnstrikeDateChanging(value);
					this.SendPropertyChanging();
					this._strikeDate = value;
					this.SendPropertyChanged("strikeDate");
					this.OnstrikeDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_strikeTime", DbType="Time NOT NULL")]
		public System.TimeSpan strikeTime
		{
			get
			{
				return this._strikeTime;
			}
			set
			{
				if ((this._strikeTime != value))
				{
					this.OnstrikeTimeChanging(value);
					this.SendPropertyChanging();
					this._strikeTime = value;
					this.SendPropertyChanged("strikeTime");
					this.OnstrikeTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_strikeLatitude", DbType="Decimal(5,2) NOT NULL")]
		public decimal strikeLatitude
		{
			get
			{
				return this._strikeLatitude;
			}
			set
			{
				if ((this._strikeLatitude != value))
				{
					this.OnstrikeLatitudeChanging(value);
					this.SendPropertyChanging();
					this._strikeLatitude = value;
					this.SendPropertyChanged("strikeLatitude");
					this.OnstrikeLatitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_strikeLongitude", DbType="Decimal(5,2) NOT NULL")]
		public decimal strikeLongitude
		{
			get
			{
				return this._strikeLongitude;
			}
			set
			{
				if ((this._strikeLongitude != value))
				{
					this.OnstrikeLongitudeChanging(value);
					this.SendPropertyChanging();
					this._strikeLongitude = value;
					this.SendPropertyChanged("strikeLongitude");
					this.OnstrikeLongitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_strikeIntensity", DbType="Int NOT NULL")]
		public int strikeIntensity
		{
			get
			{
				return this._strikeIntensity;
			}
			set
			{
				if ((this._strikeIntensity != value))
				{
					this.OnstrikeIntensityChanging(value);
					this.SendPropertyChanging();
					this._strikeIntensity = value;
					this.SendPropertyChanged("strikeIntensity");
					this.OnstrikeIntensityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblStrike_tblPicture", Storage="_tblPictures", ThisKey="strikeID", OtherKey="strikeID")]
		public EntitySet<tblPicture> tblPictures
		{
			get
			{
				return this._tblPictures;
			}
			set
			{
				this._tblPictures.Assign(value);
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
		
		private void attach_tblPictures(tblPicture entity)
		{
			this.SendPropertyChanging();
			entity.tblStrike = this;
		}
		
		private void detach_tblPictures(tblPicture entity)
		{
			this.SendPropertyChanging();
			entity.tblStrike = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblPicture")]
	public partial class tblPicture : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _pictureID;
		
		private int _strikeID;
		
		private System.DateTime _pictureDate;
		
		private string _pictureFileName;
		
		private EntityRef<tblStrike> _tblStrike;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnpictureIDChanging(int value);
    partial void OnpictureIDChanged();
    partial void OnstrikeIDChanging(int value);
    partial void OnstrikeIDChanged();
    partial void OnpictureDateChanging(System.DateTime value);
    partial void OnpictureDateChanged();
    partial void OnpictureFileNameChanging(string value);
    partial void OnpictureFileNameChanged();
    #endregion
		
		public tblPicture()
		{
			this._tblStrike = default(EntityRef<tblStrike>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pictureID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int pictureID
		{
			get
			{
				return this._pictureID;
			}
			set
			{
				if ((this._pictureID != value))
				{
					this.OnpictureIDChanging(value);
					this.SendPropertyChanging();
					this._pictureID = value;
					this.SendPropertyChanged("pictureID");
					this.OnpictureIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_strikeID", DbType="Int NOT NULL")]
		public int strikeID
		{
			get
			{
				return this._strikeID;
			}
			set
			{
				if ((this._strikeID != value))
				{
					if (this._tblStrike.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnstrikeIDChanging(value);
					this.SendPropertyChanging();
					this._strikeID = value;
					this.SendPropertyChanged("strikeID");
					this.OnstrikeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pictureDate", DbType="Date NOT NULL")]
		public System.DateTime pictureDate
		{
			get
			{
				return this._pictureDate;
			}
			set
			{
				if ((this._pictureDate != value))
				{
					this.OnpictureDateChanging(value);
					this.SendPropertyChanging();
					this._pictureDate = value;
					this.SendPropertyChanged("pictureDate");
					this.OnpictureDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pictureFileName", DbType="Char(15)")]
		public string pictureFileName
		{
			get
			{
				return this._pictureFileName;
			}
			set
			{
				if ((this._pictureFileName != value))
				{
					this.OnpictureFileNameChanging(value);
					this.SendPropertyChanging();
					this._pictureFileName = value;
					this.SendPropertyChanged("pictureFileName");
					this.OnpictureFileNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblStrike_tblPicture", Storage="_tblStrike", ThisKey="strikeID", OtherKey="strikeID", IsForeignKey=true)]
		public tblStrike tblStrike
		{
			get
			{
				return this._tblStrike.Entity;
			}
			set
			{
				tblStrike previousValue = this._tblStrike.Entity;
				if (((previousValue != value) 
							|| (this._tblStrike.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblStrike.Entity = null;
						previousValue.tblPictures.Remove(this);
					}
					this._tblStrike.Entity = value;
					if ((value != null))
					{
						value.tblPictures.Add(this);
						this._strikeID = value.strikeID;
					}
					else
					{
						this._strikeID = default(int);
					}
					this.SendPropertyChanged("tblStrike");
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
