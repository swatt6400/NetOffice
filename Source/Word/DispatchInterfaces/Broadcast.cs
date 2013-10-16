using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface Broadcast 
	/// SupportByVersion Word, 15
	///</summary>
	[SupportByVersionAttribute("Word", 15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Broadcast : COMObject
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
                    _type = typeof(Broadcast);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Broadcast(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Broadcast(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Broadcast(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Broadcast() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Broadcast(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Word 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 15)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Application.LateBindingApiWrapperType) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Word", 15)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 15)]
		public string AttendeeUrl
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AttendeeUrl", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 15)]
		public NetOffice.OfficeApi.Enums.MsoBroadcastState State
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "State", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoBroadcastState)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Word 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 15)]
		public Int32 Capabilities
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Capabilities", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 15)]
		public string PresenterServiceUrl
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PresenterServiceUrl", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 15)]
		public string SessionID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SessionID", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Word 15
		/// </summary>
		/// <param name="serverUrl">string serverUrl</param>
		[SupportByVersionAttribute("Word", 15)]
		public void Start(string serverUrl)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(serverUrl);
			Invoker.Method(this, "Start", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 15
		/// </summary>
		[SupportByVersionAttribute("Word", 15)]
		public void Pause()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Pause", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 15
		/// </summary>
		[SupportByVersionAttribute("Word", 15)]
		public void Resume()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Resume", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 15
		/// </summary>
		[SupportByVersionAttribute("Word", 15)]
		public void End()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "End", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 15
		/// </summary>
		/// <param name="notesUrl">string notesUrl</param>
		/// <param name="notesWacUrl">string notesWacUrl</param>
		[SupportByVersionAttribute("Word", 15)]
		public void AddMeetingNotes(string notesUrl, string notesWacUrl)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(notesUrl, notesWacUrl);
			Invoker.Method(this, "AddMeetingNotes", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}