//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using LinqConnect template.
// Code is generated on: 01-02-2022 11:33:30
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using Devart.Data.Linq;
using Devart.Data.Linq.Mapping;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;

namespace LOGINContext
{

    [DatabaseAttribute(Name = "LOGIN")]
    [ProviderAttribute(typeof(Devart.Data.SqlServer.Linq.Provider.SqlDataProvider))]
    public partial class LOGINDataContext : Devart.Data.Linq.DataContext
    {
        public static CompiledQueryCache compiledQueryCache = CompiledQueryCache.RegisterDataContext(typeof(LOGINDataContext));
        private static MappingSource mappingSource = new Devart.Data.Linq.Mapping.AttributeMappingSource();

        #region Extensibility Method Definitions
    
        partial void OnCreated();
        partial void OnSubmitError(Devart.Data.Linq.SubmitErrorEventArgs args);
        partial void InsertRefreshtoken(Refreshtoken instance);
        partial void UpdateRefreshtoken(Refreshtoken instance);
        partial void DeleteRefreshtoken(Refreshtoken instance);
        partial void InsertRole(Role instance);
        partial void UpdateRole(Role instance);
        partial void DeleteRole(Role instance);
        partial void InsertUser(User instance);
        partial void UpdateUser(User instance);
        partial void DeleteUser(User instance);
        partial void InsertUsersRefreshToken(UsersRefreshToken instance);
        partial void UpdateUsersRefreshToken(UsersRefreshToken instance);
        partial void DeleteUsersRefreshToken(UsersRefreshToken instance);

        #endregion

        public LOGINDataContext() :
        base(@"Data Source=DESKTOP-PF2SA84;Initial Catalog=LOGIN;Integrated Security=True;Persist Security Info=True", mappingSource)
        {
            OnCreated();
        }

        public LOGINDataContext(MappingSource mappingSource) :
        base(@"Data Source=DESKTOP-PF2SA84;Initial Catalog=LOGIN;Integrated Security=True;Persist Security Info=True", mappingSource)
        {
            OnCreated();
        }

        public LOGINDataContext(string connection) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public LOGINDataContext(System.Data.IDbConnection connection) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public LOGINDataContext(string connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public LOGINDataContext(System.Data.IDbConnection connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public Devart.Data.Linq.Table<Refreshtoken> Refreshtokens
        {
            get
            {
                return this.GetTable<Refreshtoken>();
            }
        }

        public Devart.Data.Linq.Table<Role> Roles
        {
            get
            {
                return this.GetTable<Role>();
            }
        }

        public Devart.Data.Linq.Table<User> Users
        {
            get
            {
                return this.GetTable<User>();
            }
        }

        public Devart.Data.Linq.Table<UsersRefreshToken> UsersRefreshTokens
        {
            get
            {
                return this.GetTable<UsersRefreshToken>();
            }
        }
    }
}

namespace LOGINContext
{

    /// <summary>
    /// There are no comments for LOGINContext.Refreshtoken in the schema.
    /// </summary>
    [Table(Name = @"dbo.Refreshtokens")]
    public partial class Refreshtoken : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _RefreshTokenID;

        private string _RefreshToken;
        #pragma warning restore 0649

        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnRefreshTokenIDChanging(int value);
        partial void OnRefreshTokenIDChanged();
        partial void OnRefreshTokenChanging(string value);
        partial void OnRefreshTokenChanged();
        #endregion

        public Refreshtoken()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for RefreshTokenID in the schema.
        /// </summary>
        [Column(Storage = "_RefreshTokenID", AutoSync = AutoSync.OnInsert, CanBeNull = false, DbType = "INT NOT NULL IDENTITY", IsDbGenerated = true, IsPrimaryKey = true)]
        public int RefreshTokenID
        {
            get
            {
                return this._RefreshTokenID;
            }
            set
            {
                if (this._RefreshTokenID != value)
                {
                    this.OnRefreshTokenIDChanging(value);
                    this.SendPropertyChanging("RefreshTokenID");
                    this._RefreshTokenID = value;
                    this.SendPropertyChanged("RefreshTokenID");
                    this.OnRefreshTokenIDChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for RefreshToken in the schema.
        /// </summary>
        [Column(Storage = "_RefreshToken", CanBeNull = false, DbType = "VARCHAR(200) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string RefreshToken
        {
            get
            {
                return this._RefreshToken;
            }
            set
            {
                if (this._RefreshToken != value)
                {
                    this.OnRefreshTokenChanging(value);
                    this.SendPropertyChanging("RefreshToken");
                    this._RefreshToken = value;
                    this.SendPropertyChanged("RefreshToken");
                    this.OnRefreshTokenChanged();
                }
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    /// <summary>
    /// There are no comments for LOGINContext.Role in the schema.
    /// </summary>
    [Table(Name = @"dbo.Roles")]
    public partial class Role : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _RoleID;

        private string _RoleName;
        #pragma warning restore 0649

        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnRoleIDChanging(int value);
        partial void OnRoleIDChanged();
        partial void OnRoleNameChanging(string value);
        partial void OnRoleNameChanged();
        #endregion

        public Role()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for RoleID in the schema.
        /// </summary>
        [Column(Storage = "_RoleID", AutoSync = AutoSync.OnInsert, CanBeNull = false, DbType = "INT NOT NULL IDENTITY", IsDbGenerated = true, IsPrimaryKey = true)]
        public int RoleID
        {
            get
            {
                return this._RoleID;
            }
            set
            {
                if (this._RoleID != value)
                {
                    this.OnRoleIDChanging(value);
                    this.SendPropertyChanging("RoleID");
                    this._RoleID = value;
                    this.SendPropertyChanged("RoleID");
                    this.OnRoleIDChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for RoleName in the schema.
        /// </summary>
        [Column(Storage = "_RoleName", CanBeNull = false, DbType = "VARCHAR(100) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string RoleName
        {
            get
            {
                return this._RoleName;
            }
            set
            {
                if (this._RoleName != value)
                {
                    this.OnRoleNameChanging(value);
                    this.SendPropertyChanging("RoleName");
                    this._RoleName = value;
                    this.SendPropertyChanged("RoleName");
                    this.OnRoleNameChanged();
                }
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    /// <summary>
    /// There are no comments for LOGINContext.User in the schema.
    /// </summary>
    [Table(Name = @"dbo.Users")]
    public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _UserID;

        private string _UserName;

        private string _EmailAddress;

        private string _Password;

        private int _RoleID;
        #pragma warning restore 0649

        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnUserIDChanging(int value);
        partial void OnUserIDChanged();
        partial void OnUserNameChanging(string value);
        partial void OnUserNameChanged();
        partial void OnEmailAddressChanging(string value);
        partial void OnEmailAddressChanged();
        partial void OnPasswordChanging(string value);
        partial void OnPasswordChanged();
        partial void OnRoleIDChanging(int value);
        partial void OnRoleIDChanged();
        #endregion

        public User()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for UserID in the schema.
        /// </summary>
        [Column(Storage = "_UserID", AutoSync = AutoSync.OnInsert, CanBeNull = false, DbType = "INT NOT NULL IDENTITY", IsDbGenerated = true, IsPrimaryKey = true)]
        public int UserID
        {
            get
            {
                return this._UserID;
            }
            set
            {
                if (this._UserID != value)
                {
                    this.OnUserIDChanging(value);
                    this.SendPropertyChanging("UserID");
                    this._UserID = value;
                    this.SendPropertyChanged("UserID");
                    this.OnUserIDChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for UserName in the schema.
        /// </summary>
        [Column(Storage = "_UserName", CanBeNull = false, DbType = "VARCHAR(100) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string UserName
        {
            get
            {
                return this._UserName;
            }
            set
            {
                if (this._UserName != value)
                {
                    this.OnUserNameChanging(value);
                    this.SendPropertyChanging("UserName");
                    this._UserName = value;
                    this.SendPropertyChanged("UserName");
                    this.OnUserNameChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for EmailAddress in the schema.
        /// </summary>
        [Column(Storage = "_EmailAddress", CanBeNull = false, DbType = "VARCHAR(100) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string EmailAddress
        {
            get
            {
                return this._EmailAddress;
            }
            set
            {
                if (this._EmailAddress != value)
                {
                    this.OnEmailAddressChanging(value);
                    this.SendPropertyChanging("EmailAddress");
                    this._EmailAddress = value;
                    this.SendPropertyChanged("EmailAddress");
                    this.OnEmailAddressChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Password in the schema.
        /// </summary>
        [Column(Storage = "_Password", CanBeNull = false, DbType = "VARCHAR(100) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string Password
        {
            get
            {
                return this._Password;
            }
            set
            {
                if (this._Password != value)
                {
                    this.OnPasswordChanging(value);
                    this.SendPropertyChanging("Password");
                    this._Password = value;
                    this.SendPropertyChanged("Password");
                    this.OnPasswordChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for RoleID in the schema.
        /// </summary>
        [Column(Storage = "_RoleID", CanBeNull = false, DbType = "INT NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public int RoleID
        {
            get
            {
                return this._RoleID;
            }
            set
            {
                if (this._RoleID != value)
                {
                    this.OnRoleIDChanging(value);
                    this.SendPropertyChanging("RoleID");
                    this._RoleID = value;
                    this.SendPropertyChanged("RoleID");
                    this.OnRoleIDChanged();
                }
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    /// <summary>
    /// There are no comments for LOGINContext.UsersRefreshToken in the schema.
    /// </summary>
    [Table(Name = @"dbo.UsersRefreshTokens")]
    public partial class UsersRefreshToken : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _ID;

        private int _UserID;

        private int _RefreshTokenID;
        #pragma warning restore 0649

        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        partial void OnUserIDChanging(int value);
        partial void OnUserIDChanged();
        partial void OnRefreshTokenIDChanging(int value);
        partial void OnRefreshTokenIDChanged();
        #endregion

        public UsersRefreshToken()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for ID in the schema.
        /// </summary>
        [Column(Storage = "_ID", AutoSync = AutoSync.OnInsert, CanBeNull = false, DbType = "INT NOT NULL IDENTITY", IsDbGenerated = true, IsPrimaryKey = true)]
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if (this._ID != value)
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging("ID");
                    this._ID = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for UserID in the schema.
        /// </summary>
        [Column(Storage = "_UserID", CanBeNull = false, DbType = "INT NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public int UserID
        {
            get
            {
                return this._UserID;
            }
            set
            {
                if (this._UserID != value)
                {
                    this.OnUserIDChanging(value);
                    this.SendPropertyChanging("UserID");
                    this._UserID = value;
                    this.SendPropertyChanged("UserID");
                    this.OnUserIDChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for RefreshTokenID in the schema.
        /// </summary>
        [Column(Storage = "_RefreshTokenID", CanBeNull = false, DbType = "INT NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public int RefreshTokenID
        {
            get
            {
                return this._RefreshTokenID;
            }
            set
            {
                if (this._RefreshTokenID != value)
                {
                    this.OnRefreshTokenIDChanging(value);
                    this.SendPropertyChanging("RefreshTokenID");
                    this._RefreshTokenID = value;
                    this.SendPropertyChanged("RefreshTokenID");
                    this.OnRefreshTokenIDChanged();
                }
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
