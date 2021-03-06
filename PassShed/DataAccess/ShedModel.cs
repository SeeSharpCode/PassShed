﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.IO;
using System.Windows.Forms;

namespace PassShed.DataAccess
{
    public partial class ShedEntities : System.Data.Linq.DataContext
    {

        private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();

        static string localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        static string passshedAppDataPath = Path.Combine(Application.CompanyName, Application.ProductName);
        static string appDataPath = Path.Combine(localAppDataPath, passshedAppDataPath);


        #region Extensibility Method Definitions
        partial void OnCreated();
        partial void InsertAccount(Account instance);
        partial void UpdateAccount(Account instance);
        partial void DeleteAccount(Account instance);
        partial void InsertCategory(Category instance);
        partial void UpdateCategory(Category instance);
        partial void DeleteCategory(Category instance);
        partial void InsertCredential(Credential instance);
        partial void UpdateCredential(Credential instance);
        partial void DeleteCredential(Credential instance);
        partial void InsertField(Field instance);
        partial void UpdateField(Field instance);
        partial void DeleteField(Field instance);
        partial void InsertMaster_password(MasterPassword instance);
        partial void UpdateMaster_password(MasterPassword instance);
        partial void DeleteMaster_password(MasterPassword instance);
        #endregion

        public ShedEntities()
            : this(@"Data Source=" + appDataPath + "/PassShed.sdf;Password=GateKeeper1@")
        {
        }

        public ShedEntities(string connection) :
            base(connection, mappingSource)
        {
            OnCreated();
        }

        public ShedEntities(System.Data.IDbConnection connection) :
            base(connection, mappingSource)
        {
            OnCreated();
        }

        public ShedEntities(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) :
            base(connection, mappingSource)
        {
            OnCreated();
        }

        public ShedEntities(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) :
            base(connection, mappingSource)
        {
            OnCreated();
        }

        public System.Data.Linq.Table<Account> Accounts
        {
            get
            {
                return this.GetTable<Account>();
            }
        }

        public System.Data.Linq.Table<Category> Categories
        {
            get
            {
                return this.GetTable<Category>();
            }
        }

        public System.Data.Linq.Table<Credential> Credentials
        {
            get
            {
                return this.GetTable<Credential>();
            }
        }

        public System.Data.Linq.Table<Field> Fields
        {
            get
            {
                return this.GetTable<Field>();
            }
        }

        public System.Data.Linq.Table<MasterPassword> MasterPasswords
        {
            get
            {
                return this.GetTable<MasterPassword>();
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "account")]
    public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _Id;

        private int _Category_id;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnCategory_idChanging(int value);
        partial void OnCategory_idChanged();
        #endregion

        public Account()
        {
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Name = "id", Storage = "_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if ((this._Id != value))
                {
                    this.OnIdChanging(value);
                    this.SendPropertyChanging();
                    this._Id = value;
                    this.SendPropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Name = "category_id", Storage = "_Category_id", DbType = "Int NOT NULL")]
        public int CategoryId
        {
            get
            {
                return this._Category_id;
            }
            set
            {
                if ((this._Category_id != value))
                {
                    this.OnCategory_idChanging(value);
                    this.SendPropertyChanging();
                    this._Category_id = value;
                    this.SendPropertyChanged("Category_id");
                    this.OnCategory_idChanged();
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

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "category")]
    public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _Id;

        private string _Label;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnLabelChanging(string value);
        partial void OnLabelChanged();
        #endregion

        public Category()
        {
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Name = "id", Storage = "_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if ((this._Id != value))
                {
                    this.OnIdChanging(value);
                    this.SendPropertyChanging();
                    this._Id = value;
                    this.SendPropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Name = "label", Storage = "_Label", DbType = "NVarChar(60) NOT NULL", CanBeNull = false)]
        public string Label
        {
            get
            {
                return this._Label;
            }
            set
            {
                if ((this._Label != value))
                {
                    this.OnLabelChanging(value);
                    this.SendPropertyChanging();
                    this._Label = value;
                    this.SendPropertyChanged("Label");
                    this.OnLabelChanged();
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

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "credential")]
    public partial class Credential : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _Id;

        private int _Account_id;

        private int _Field_id;

        private string _Value;

        private System.DateTime _Created;

        private System.Nullable<System.DateTime> _Modified;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnAccount_idChanging(int value);
        partial void OnAccount_idChanged();
        partial void OnField_idChanging(int value);
        partial void OnField_idChanged();
        partial void OnValueChanging(string value);
        partial void OnValueChanged();
        partial void OnCreatedChanging(System.DateTime value);
        partial void OnCreatedChanged();
        partial void OnModifiedChanging(System.Nullable<System.DateTime> value);
        partial void OnModifiedChanged();
        #endregion

        public Credential()
        {
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Name = "id", Storage = "_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if ((this._Id != value))
                {
                    this.OnIdChanging(value);
                    this.SendPropertyChanging();
                    this._Id = value;
                    this.SendPropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Name = "account_id", Storage = "_Account_id", DbType = "Int NOT NULL")]
        public int AccountId
        {
            get
            {
                return this._Account_id;
            }
            set
            {
                if ((this._Account_id != value))
                {
                    this.OnAccount_idChanging(value);
                    this.SendPropertyChanging();
                    this._Account_id = value;
                    this.SendPropertyChanged("Account_id");
                    this.OnAccount_idChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Name = "field_id", Storage = "_Field_id", DbType = "Int NOT NULL")]
        public int FieldId
        {
            get
            {
                return this._Field_id;
            }
            set
            {
                if ((this._Field_id != value))
                {
                    this.OnField_idChanging(value);
                    this.SendPropertyChanging();
                    this._Field_id = value;
                    this.SendPropertyChanged("Field_id");
                    this.OnField_idChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Name = "value", Storage = "_Value", DbType = "NVarChar(100)")]
        public string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                if ((this._Value != value))
                {
                    this.OnValueChanging(value);
                    this.SendPropertyChanging();
                    this._Value = value;
                    this.SendPropertyChanged("Value");
                    this.OnValueChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Name = "created", Storage = "_Created", DbType = "DateTime NOT NULL")]
        public System.DateTime Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                if ((this._Created != value))
                {
                    this.OnCreatedChanging(value);
                    this.SendPropertyChanging();
                    this._Created = value;
                    this.SendPropertyChanged("Created");
                    this.OnCreatedChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Name = "modified", Storage = "_Modified", DbType = "DateTime")]
        public System.Nullable<System.DateTime> Modified
        {
            get
            {
                return this._Modified;
            }
            set
            {
                if ((this._Modified != value))
                {
                    this.OnModifiedChanging(value);
                    this.SendPropertyChanging();
                    this._Modified = value;
                    this.SendPropertyChanged("Modified");
                    this.OnModifiedChanged();
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

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "field")]
    public partial class Field : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _Id;

        private int _Category_id;

        private string _Label;

        private System.Nullable<int> _Display_index;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnCategory_idChanging(int value);
        partial void OnCategory_idChanged();
        partial void OnLabelChanging(string value);
        partial void OnLabelChanged();
        partial void OnDisplay_indexChanging(System.Nullable<int> value);
        partial void OnDisplay_indexChanged();
        #endregion

        public Field()
        {
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Name = "id", Storage = "_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if ((this._Id != value))
                {
                    this.OnIdChanging(value);
                    this.SendPropertyChanging();
                    this._Id = value;
                    this.SendPropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Name = "category_id", Storage = "_Category_id", DbType = "Int NOT NULL")]
        public int CategoryId
        {
            get
            {
                return this._Category_id;
            }
            set
            {
                if ((this._Category_id != value))
                {
                    this.OnCategory_idChanging(value);
                    this.SendPropertyChanging();
                    this._Category_id = value;
                    this.SendPropertyChanged("Category_id");
                    this.OnCategory_idChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Name = "label", Storage = "_Label", DbType = "NVarChar(60) NOT NULL", CanBeNull = false)]
        public string Label
        {
            get
            {
                return this._Label;
            }
            set
            {
                if ((this._Label != value))
                {
                    this.OnLabelChanging(value);
                    this.SendPropertyChanging();
                    this._Label = value;
                    this.SendPropertyChanged("Label");
                    this.OnLabelChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Name = "display_index", Storage = "_Display_index", DbType = "Int")]
        public System.Nullable<int> DisplayIndex
        {
            get
            {
                return this._Display_index;
            }
            set
            {
                if ((this._Display_index != value))
                {
                    this.OnDisplay_indexChanging(value);
                    this.SendPropertyChanging();
                    this._Display_index = value;
                    this.SendPropertyChanged("Display_index");
                    this.OnDisplay_indexChanged();
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

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "master_password")]
    public partial class MasterPassword : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _Password_hash;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnPassword_hashChanging(string value);
        partial void OnPassword_hashChanged();
        #endregion

        public MasterPassword()
        {
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Name = "password_hash", Storage = "_Password_hash", DbType = "NVarChar(47) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string PasswordHash
        {
            get
            {
                return this._Password_hash;
            }
            set
            {
                if ((this._Password_hash != value))
                {
                    this.OnPassword_hashChanging(value);
                    this.SendPropertyChanging();
                    this._Password_hash = value;
                    this.SendPropertyChanged("Password_hash");
                    this.OnPassword_hashChanged();
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
