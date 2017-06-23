﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BangDia
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MuonDia")]
	public partial class DBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBangDia(BangDia instance);
    partial void UpdateBangDia(BangDia instance);
    partial void DeleteBangDia(BangDia instance);
    partial void InsertDoanhThu(DoanhThu instance);
    partial void UpdateDoanhThu(DoanhThu instance);
    partial void DeleteDoanhThu(DoanhThu instance);
    partial void InsertHSMuon(HSMuon instance);
    partial void UpdateHSMuon(HSMuon instance);
    partial void DeleteHSMuon(HSMuon instance);
    partial void InsertKhachHang(KhachHang instance);
    partial void UpdateKhachHang(KhachHang instance);
    partial void DeleteKhachHang(KhachHang instance);
    partial void InsertTaiKhoan(TaiKhoan instance);
    partial void UpdateTaiKhoan(TaiKhoan instance);
    partial void DeleteTaiKhoan(TaiKhoan instance);
    #endregion
		
		public DBDataContext() : 
				base(global::BangDia.Properties.Settings.Default.MuonDiaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BangDia> BangDias
		{
			get
			{
				return this.GetTable<BangDia>();
			}
		}
		
		public System.Data.Linq.Table<DoanhThu> DoanhThus
		{
			get
			{
				return this.GetTable<DoanhThu>();
			}
		}
		
		public System.Data.Linq.Table<HSMuon> HSMuons
		{
			get
			{
				return this.GetTable<HSMuon>();
			}
		}
		
		public System.Data.Linq.Table<HSMuon_BangDia> HSMuon_BangDias
		{
			get
			{
				return this.GetTable<HSMuon_BangDia>();
			}
		}
		
		public System.Data.Linq.Table<KhachHang> KhachHangs
		{
			get
			{
				return this.GetTable<KhachHang>();
			}
		}
		
		public System.Data.Linq.Table<TaiKhoan> TaiKhoans
		{
			get
			{
				return this.GetTable<TaiKhoan>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BangDia")]
	public partial class BangDia : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaBang;
		
		private string _TuaDe;
		
		private string _ChuDe;
		
		private string _TacGia;
		
		private int _SoLuong;
		
		private decimal _DonGia;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaBangChanging(int value);
    partial void OnMaBangChanged();
    partial void OnTuaDeChanging(string value);
    partial void OnTuaDeChanged();
    partial void OnChuDeChanging(string value);
    partial void OnChuDeChanged();
    partial void OnTacGiaChanging(string value);
    partial void OnTacGiaChanged();
    partial void OnSoLuongChanging(int value);
    partial void OnSoLuongChanged();
    partial void OnDonGiaChanging(decimal value);
    partial void OnDonGiaChanged();
    #endregion
		
		public BangDia()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBang", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaBang
		{
			get
			{
				return this._MaBang;
			}
			set
			{
				if ((this._MaBang != value))
				{
					this.OnMaBangChanging(value);
					this.SendPropertyChanging();
					this._MaBang = value;
					this.SendPropertyChanged("MaBang");
					this.OnMaBangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TuaDe", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TuaDe
		{
			get
			{
				return this._TuaDe;
			}
			set
			{
				if ((this._TuaDe != value))
				{
					this.OnTuaDeChanging(value);
					this.SendPropertyChanging();
					this._TuaDe = value;
					this.SendPropertyChanged("TuaDe");
					this.OnTuaDeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChuDe", DbType="NVarChar(100)")]
		public string ChuDe
		{
			get
			{
				return this._ChuDe;
			}
			set
			{
				if ((this._ChuDe != value))
				{
					this.OnChuDeChanging(value);
					this.SendPropertyChanging();
					this._ChuDe = value;
					this.SendPropertyChanged("ChuDe");
					this.OnChuDeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TacGia", DbType="NVarChar(100)")]
		public string TacGia
		{
			get
			{
				return this._TacGia;
			}
			set
			{
				if ((this._TacGia != value))
				{
					this.OnTacGiaChanging(value);
					this.SendPropertyChanging();
					this._TacGia = value;
					this.SendPropertyChanged("TacGia");
					this.OnTacGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int NOT NULL")]
		public int SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Money NOT NULL")]
		public decimal DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this.OnDonGiaChanging(value);
					this.SendPropertyChanging();
					this._DonGia = value;
					this.SendPropertyChanged("DonGia");
					this.OnDonGiaChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DoanhThu")]
	public partial class DoanhThu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDT;
		
		private System.DateTime _NgayTra;
		
		private decimal _TongTien;
		
		private System.Nullable<int> _MaHSMuon;
		
		private EntityRef<HSMuon> _HSMuon;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDTChanging(int value);
    partial void OnMaDTChanged();
    partial void OnNgayTraChanging(System.DateTime value);
    partial void OnNgayTraChanged();
    partial void OnTongTienChanging(decimal value);
    partial void OnTongTienChanged();
    partial void OnMaHSMuonChanging(System.Nullable<int> value);
    partial void OnMaHSMuonChanged();
    #endregion
		
		public DoanhThu()
		{
			this._HSMuon = default(EntityRef<HSMuon>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDT", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaDT
		{
			get
			{
				return this._MaDT;
			}
			set
			{
				if ((this._MaDT != value))
				{
					this.OnMaDTChanging(value);
					this.SendPropertyChanging();
					this._MaDT = value;
					this.SendPropertyChanged("MaDT");
					this.OnMaDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayTra", DbType="Date NOT NULL")]
		public System.DateTime NgayTra
		{
			get
			{
				return this._NgayTra;
			}
			set
			{
				if ((this._NgayTra != value))
				{
					this.OnNgayTraChanging(value);
					this.SendPropertyChanging();
					this._NgayTra = value;
					this.SendPropertyChanged("NgayTra");
					this.OnNgayTraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongTien", DbType="Money NOT NULL")]
		public decimal TongTien
		{
			get
			{
				return this._TongTien;
			}
			set
			{
				if ((this._TongTien != value))
				{
					this.OnTongTienChanging(value);
					this.SendPropertyChanging();
					this._TongTien = value;
					this.SendPropertyChanged("TongTien");
					this.OnTongTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHSMuon", DbType="Int")]
		public System.Nullable<int> MaHSMuon
		{
			get
			{
				return this._MaHSMuon;
			}
			set
			{
				if ((this._MaHSMuon != value))
				{
					if (this._HSMuon.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaHSMuonChanging(value);
					this.SendPropertyChanging();
					this._MaHSMuon = value;
					this.SendPropertyChanged("MaHSMuon");
					this.OnMaHSMuonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HSMuon_DoanhThu", Storage="_HSMuon", ThisKey="MaHSMuon", OtherKey="MaHSMuon", IsForeignKey=true)]
		public HSMuon HSMuon
		{
			get
			{
				return this._HSMuon.Entity;
			}
			set
			{
				HSMuon previousValue = this._HSMuon.Entity;
				if (((previousValue != value) 
							|| (this._HSMuon.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HSMuon.Entity = null;
						previousValue.DoanhThus.Remove(this);
					}
					this._HSMuon.Entity = value;
					if ((value != null))
					{
						value.DoanhThus.Add(this);
						this._MaHSMuon = value.MaHSMuon;
					}
					else
					{
						this._MaHSMuon = default(Nullable<int>);
					}
					this.SendPropertyChanged("HSMuon");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HSMuon")]
	public partial class HSMuon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHSMuon;
		
		private System.DateTime _NgayMuon;
		
		private System.DateTime _NgayDuKien;
		
		private System.Nullable<int> _MaKH;
		
		private System.Nullable<bool> _DaTra;
		
		private EntitySet<DoanhThu> _DoanhThus;
		
		private EntityRef<KhachHang> _KhachHang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHSMuonChanging(int value);
    partial void OnMaHSMuonChanged();
    partial void OnNgayMuonChanging(System.DateTime value);
    partial void OnNgayMuonChanged();
    partial void OnNgayDuKienChanging(System.DateTime value);
    partial void OnNgayDuKienChanged();
    partial void OnMaKHChanging(System.Nullable<int> value);
    partial void OnMaKHChanged();
    partial void OnDaTraChanging(System.Nullable<bool> value);
    partial void OnDaTraChanged();
    #endregion
		
		public HSMuon()
		{
			this._DoanhThus = new EntitySet<DoanhThu>(new Action<DoanhThu>(this.attach_DoanhThus), new Action<DoanhThu>(this.detach_DoanhThus));
			this._KhachHang = default(EntityRef<KhachHang>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHSMuon", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaHSMuon
		{
			get
			{
				return this._MaHSMuon;
			}
			set
			{
				if ((this._MaHSMuon != value))
				{
					this.OnMaHSMuonChanging(value);
					this.SendPropertyChanging();
					this._MaHSMuon = value;
					this.SendPropertyChanged("MaHSMuon");
					this.OnMaHSMuonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayMuon", DbType="Date NOT NULL")]
		public System.DateTime NgayMuon
		{
			get
			{
				return this._NgayMuon;
			}
			set
			{
				if ((this._NgayMuon != value))
				{
					this.OnNgayMuonChanging(value);
					this.SendPropertyChanging();
					this._NgayMuon = value;
					this.SendPropertyChanged("NgayMuon");
					this.OnNgayMuonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDuKien", DbType="Date NOT NULL")]
		public System.DateTime NgayDuKien
		{
			get
			{
				return this._NgayDuKien;
			}
			set
			{
				if ((this._NgayDuKien != value))
				{
					this.OnNgayDuKienChanging(value);
					this.SendPropertyChanging();
					this._NgayDuKien = value;
					this.SendPropertyChanged("NgayDuKien");
					this.OnNgayDuKienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="Int")]
		public System.Nullable<int> MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					if (this._KhachHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DaTra", DbType="Bit")]
		public System.Nullable<bool> DaTra
		{
			get
			{
				return this._DaTra;
			}
			set
			{
				if ((this._DaTra != value))
				{
					this.OnDaTraChanging(value);
					this.SendPropertyChanging();
					this._DaTra = value;
					this.SendPropertyChanged("DaTra");
					this.OnDaTraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HSMuon_DoanhThu", Storage="_DoanhThus", ThisKey="MaHSMuon", OtherKey="MaHSMuon")]
		public EntitySet<DoanhThu> DoanhThus
		{
			get
			{
				return this._DoanhThus;
			}
			set
			{
				this._DoanhThus.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_HSMuon", Storage="_KhachHang", ThisKey="MaKH", OtherKey="MaKH", IsForeignKey=true)]
		public KhachHang KhachHang
		{
			get
			{
				return this._KhachHang.Entity;
			}
			set
			{
				KhachHang previousValue = this._KhachHang.Entity;
				if (((previousValue != value) 
							|| (this._KhachHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KhachHang.Entity = null;
						previousValue.HSMuons.Remove(this);
					}
					this._KhachHang.Entity = value;
					if ((value != null))
					{
						value.HSMuons.Add(this);
						this._MaKH = value.MaKH;
					}
					else
					{
						this._MaKH = default(Nullable<int>);
					}
					this.SendPropertyChanged("KhachHang");
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
		
		private void attach_DoanhThus(DoanhThu entity)
		{
			this.SendPropertyChanging();
			entity.HSMuon = this;
		}
		
		private void detach_DoanhThus(DoanhThu entity)
		{
			this.SendPropertyChanging();
			entity.HSMuon = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HSMuon_BangDia")]
	public partial class HSMuon_BangDia
	{
		
		private int _MaHSMuon;
		
		private int _MaBang;
		
		private int _SoLuongMua;
		
		public HSMuon_BangDia()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHSMuon", DbType="Int NOT NULL")]
		public int MaHSMuon
		{
			get
			{
				return this._MaHSMuon;
			}
			set
			{
				if ((this._MaHSMuon != value))
				{
					this._MaHSMuon = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBang", DbType="Int NOT NULL")]
		public int MaBang
		{
			get
			{
				return this._MaBang;
			}
			set
			{
				if ((this._MaBang != value))
				{
					this._MaBang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuongMua", DbType="Int NOT NULL")]
		public int SoLuongMua
		{
			get
			{
				return this._SoLuongMua;
			}
			set
			{
				if ((this._SoLuongMua != value))
				{
					this._SoLuongMua = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhachHang")]
	public partial class KhachHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKH;
		
		private string _TenKH;
		
		private int _CMND;
		
		private string _DiaChi;
		
		private string _DT;
		
		private EntitySet<HSMuon> _HSMuons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKHChanging(int value);
    partial void OnMaKHChanged();
    partial void OnTenKHChanging(string value);
    partial void OnTenKHChanged();
    partial void OnCMNDChanging(int value);
    partial void OnCMNDChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnDTChanging(string value);
    partial void OnDTChanged();
    #endregion
		
		public KhachHang()
		{
			this._HSMuons = new EntitySet<HSMuon>(new Action<HSMuon>(this.attach_HSMuons), new Action<HSMuon>(this.detach_HSMuons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKH", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TenKH
		{
			get
			{
				return this._TenKH;
			}
			set
			{
				if ((this._TenKH != value))
				{
					this.OnTenKHChanging(value);
					this.SendPropertyChanging();
					this._TenKH = value;
					this.SendPropertyChanged("TenKH");
					this.OnTenKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CMND", DbType="Int NOT NULL")]
		public int CMND
		{
			get
			{
				return this._CMND;
			}
			set
			{
				if ((this._CMND != value))
				{
					this.OnCMNDChanging(value);
					this.SendPropertyChanging();
					this._CMND = value;
					this.SendPropertyChanged("CMND");
					this.OnCMNDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="VarChar(100)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DT", DbType="VarChar(20)")]
		public string DT
		{
			get
			{
				return this._DT;
			}
			set
			{
				if ((this._DT != value))
				{
					this.OnDTChanging(value);
					this.SendPropertyChanging();
					this._DT = value;
					this.SendPropertyChanged("DT");
					this.OnDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_HSMuon", Storage="_HSMuons", ThisKey="MaKH", OtherKey="MaKH")]
		public EntitySet<HSMuon> HSMuons
		{
			get
			{
				return this._HSMuons;
			}
			set
			{
				this._HSMuons.Assign(value);
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
		
		private void attach_HSMuons(HSMuon entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = this;
		}
		
		private void detach_HSMuons(HSMuon entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TaiKhoan")]
	public partial class TaiKhoan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaTK;
		
		private string _TenTK;
		
		private string _TenDN;
		
		private string _MatKhau;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaTKChanging(int value);
    partial void OnMaTKChanged();
    partial void OnTenTKChanging(string value);
    partial void OnTenTKChanged();
    partial void OnTenDNChanging(string value);
    partial void OnTenDNChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    #endregion
		
		public TaiKhoan()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTK", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaTK
		{
			get
			{
				return this._MaTK;
			}
			set
			{
				if ((this._MaTK != value))
				{
					this.OnMaTKChanging(value);
					this.SendPropertyChanging();
					this._MaTK = value;
					this.SendPropertyChanged("MaTK");
					this.OnMaTKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTK", DbType="NVarChar(100)")]
		public string TenTK
		{
			get
			{
				return this._TenTK;
			}
			set
			{
				if ((this._TenTK != value))
				{
					this.OnTenTKChanging(value);
					this.SendPropertyChanging();
					this._TenTK = value;
					this.SendPropertyChanged("TenTK");
					this.OnTenTKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDN", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string TenDN
		{
			get
			{
				return this._TenDN;
			}
			set
			{
				if ((this._TenDN != value))
				{
					this.OnTenDNChanging(value);
					this.SendPropertyChanging();
					this._TenDN = value;
					this.SendPropertyChanged("TenDN");
					this.OnTenDNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
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
