//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{
	///<summary>
	/// DispatchInterface _Conversation SupportByLibrary "Outlook", 14
	///</summary>
	[SupportByLibrary("Outlook", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _Conversation : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Conversation(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Conversation(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Conversation(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Conversation()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Outlook", 14)]
		public NetOffice.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.OutlookApi._Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Outlook", 14)]
		public NetOffice.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Class", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlObjectClass)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Outlook", 14)]
		public NetOffice.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				NetOffice.OutlookApi._NameSpace newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Outlook", 14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Outlook", 14)]
		public string ConversationID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ConversationID", paramsArray);
				return (string)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Outlook", 14)]
		public NetOffice.OutlookApi.Table GetTable()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetTable", paramsArray);
			NetOffice.OutlookApi.Table newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.Table;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="Item">object Item</param>
		[SupportByLibrary("Outlook", 14)]
		public NetOffice.OutlookApi.SimpleItems GetChildren(object item)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(item);
			object returnItem = Invoker.MethodReturn(this, "GetChildren", paramsArray);
			NetOffice.OutlookApi.SimpleItems newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.SimpleItems;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="Item">object Item</param>
		[SupportByLibrary("Outlook", 14)]
		public COMObject GetParent(object item)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(item);
			object returnItem = Invoker.MethodReturn(this, "GetParent", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Outlook", 14)]
		public NetOffice.OutlookApi.SimpleItems GetRootItems()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetRootItems", paramsArray);
			NetOffice.OutlookApi.SimpleItems newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.SimpleItems;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="Store">NetOffice.OutlookApi._Store Store</param>
		[SupportByLibrary("Outlook", 14)]
		public string GetAlwaysAssignCategories(NetOffice.OutlookApi._Store store)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(store);
			object returnItem = Invoker.MethodReturn(this, "GetAlwaysAssignCategories", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="Store">NetOffice.OutlookApi._Store Store</param>
		[SupportByLibrary("Outlook", 14)]
		public NetOffice.OutlookApi.Enums.OlAlwaysDeleteConversation GetAlwaysDelete(NetOffice.OutlookApi._Store store)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(store);
			object returnItem = Invoker.MethodReturn(this, "GetAlwaysDelete", paramsArray);
			return (NetOffice.OutlookApi.Enums.OlAlwaysDeleteConversation)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="Store">NetOffice.OutlookApi._Store Store</param>
		[SupportByLibrary("Outlook", 14)]
		public NetOffice.OutlookApi.MAPIFolder GetAlwaysMoveToFolder(NetOffice.OutlookApi._Store store)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(store);
			object returnItem = Invoker.MethodReturn(this, "GetAlwaysMoveToFolder", paramsArray);
			NetOffice.OutlookApi.MAPIFolder newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.MAPIFolder;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Outlook", 14)]
		public void MarkAsRead()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MarkAsRead", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Outlook", 14)]
		public void MarkAsUnread()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MarkAsUnread", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="Categories">string Categories</param>
		/// <param name="Store">NetOffice.OutlookApi._Store Store</param>
		[SupportByLibrary("Outlook", 14)]
		public void SetAlwaysAssignCategories(string categories, NetOffice.OutlookApi._Store store)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(categories, store);
			Invoker.Method(this, "SetAlwaysAssignCategories", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="AlwaysDelete">NetOffice.OutlookApi.Enums.OlAlwaysDeleteConversation AlwaysDelete</param>
		/// <param name="Store">NetOffice.OutlookApi._Store Store</param>
		[SupportByLibrary("Outlook", 14)]
		public void SetAlwaysDelete(NetOffice.OutlookApi.Enums.OlAlwaysDeleteConversation alwaysDelete, NetOffice.OutlookApi._Store store)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(alwaysDelete, store);
			Invoker.Method(this, "SetAlwaysDelete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="MoveToFolder">NetOffice.OutlookApi.MAPIFolder MoveToFolder</param>
		/// <param name="Store">NetOffice.OutlookApi._Store Store</param>
		[SupportByLibrary("Outlook", 14)]
		public void SetAlwaysMoveToFolder(NetOffice.OutlookApi.MAPIFolder moveToFolder, NetOffice.OutlookApi._Store store)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(moveToFolder, store);
			Invoker.Method(this, "SetAlwaysMoveToFolder", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="Store">NetOffice.OutlookApi._Store Store</param>
		[SupportByLibrary("Outlook", 14)]
		public void ClearAlwaysAssignCategories(NetOffice.OutlookApi._Store store)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(store);
			Invoker.Method(this, "ClearAlwaysAssignCategories", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="Store">NetOffice.OutlookApi._Store Store</param>
		[SupportByLibrary("Outlook", 14)]
		public void StopAlwaysDelete(NetOffice.OutlookApi._Store store)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(store);
			Invoker.Method(this, "StopAlwaysDelete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="Store">NetOffice.OutlookApi._Store Store</param>
		[SupportByLibrary("Outlook", 14)]
		public void StopAlwaysMoveToFolder(NetOffice.OutlookApi._Store store)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(store);
			Invoker.Method(this, "StopAlwaysMoveToFolder", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}