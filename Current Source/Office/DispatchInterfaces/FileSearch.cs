using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface FileSearch 
	/// SupportByVersion Office, 9,10,11,12,14
	///</summary>
	[SupportByVersionAttribute("Office", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class FileSearch : _IMsoDispObj
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(FileSearch);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileSearch(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileSearch(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileSearch(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileSearch() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileSearch(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 9,10,11,12,14)]
		public bool SearchSubFolders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SearchSubFolders", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SearchSubFolders", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 9,10,11,12,14)]
		public bool MatchTextExactly
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchTextExactly", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchTextExactly", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 9,10,11,12,14)]
		public bool MatchAllWordForms
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchAllWordForms", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchAllWordForms", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 9,10,11,12,14)]
		public string FileName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FileName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FileName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoFileType FileType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FileType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoFileType)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FileType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoLastModified LastModified
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastModified", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoLastModified)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LastModified", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 9,10,11,12,14)]
		public string TextOrProperty
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextOrProperty", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TextOrProperty", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 9,10,11,12,14)]
		public string LookIn
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LookIn", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LookIn", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.FoundFiles FoundFiles
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FoundFiles", paramsArray);
				NetOffice.OfficeApi.FoundFiles newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.FoundFiles.LateBindingApiWrapperType) as NetOffice.OfficeApi.FoundFiles;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.PropertyTests PropertyTests
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PropertyTests", paramsArray);
				NetOffice.OfficeApi.PropertyTests newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.PropertyTests.LateBindingApiWrapperType) as NetOffice.OfficeApi.PropertyTests;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.SearchScopes SearchScopes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SearchScopes", paramsArray);
				NetOffice.OfficeApi.SearchScopes newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.SearchScopes.LateBindingApiWrapperType) as NetOffice.OfficeApi.SearchScopes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.SearchFolders SearchFolders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SearchFolders", paramsArray);
				NetOffice.OfficeApi.SearchFolders newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.SearchFolders.LateBindingApiWrapperType) as NetOffice.OfficeApi.SearchFolders;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.FileTypes FileTypes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FileTypes", paramsArray);
				NetOffice.OfficeApi.FileTypes newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.FileTypes.LateBindingApiWrapperType) as NetOffice.OfficeApi.FileTypes;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="sortBy">optional NetOffice.OfficeApi.Enums.MsoSortBy SortBy = 1</param>
		/// <param name="sortOrder">optional NetOffice.OfficeApi.Enums.MsoSortOrder SortOrder = 1</param>
		/// <param name="alwaysAccurate">optional bool AlwaysAccurate = true</param>
		[SupportByVersionAttribute("Office", 9,10,11,12,14)]
		public Int32 Execute(NetOffice.OfficeApi.Enums.MsoSortBy sortBy, NetOffice.OfficeApi.Enums.MsoSortOrder sortOrder, bool alwaysAccurate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sortBy, sortOrder, alwaysAccurate);
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByVersion Office 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 9,10,11,12,14)]
		public Int32 Execute()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByVersion Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="sortBy">optional NetOffice.OfficeApi.Enums.MsoSortBy SortBy = 1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 9,10,11,12,14)]
		public Int32 Execute(NetOffice.OfficeApi.Enums.MsoSortBy sortBy)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sortBy);
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByVersion Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="sortBy">optional NetOffice.OfficeApi.Enums.MsoSortBy SortBy = 1</param>
		/// <param name="sortOrder">optional NetOffice.OfficeApi.Enums.MsoSortOrder SortOrder = 1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 9,10,11,12,14)]
		public Int32 Execute(NetOffice.OfficeApi.Enums.MsoSortBy sortBy, NetOffice.OfficeApi.Enums.MsoSortOrder sortOrder)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sortBy, sortOrder);
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByVersion Office 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Office", 9,10,11,12,14)]
		public void NewSearch()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "NewSearch", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Office", 10,11,12,14)]
		public void RefreshScopes()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RefreshScopes", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}