using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.VisioApi
{
	///<summary>
	/// Interface IVMouseEvent 
	/// SupportByVersion Visio, 11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Visio", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IVMouseEvent : COMObject
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
                    _type = typeof(IVMouseEvent);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVMouseEvent(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVMouseEvent(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVMouseEvent(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVMouseEvent() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVMouseEvent(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public string ToString
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ToString", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public NetOffice.VisioApi.IVApplication Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.VisioApi.IVApplication newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVApplication;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public NetOffice.VisioApi.Enums.VisObjectTypes ObjectType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ObjectType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.VisioApi.Enums.VisObjectTypes)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public NetOffice.VisioApi.IVWindow Window
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Window", paramsArray);
				NetOffice.VisioApi.IVWindow newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVWindow;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public Int32 Button
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Button", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public Int32 KeyButtonState
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "KeyButtonState", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public Double x
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "x", paramsArray);
				return NetRuntimeSystem.Convert.ToDouble(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public Double y
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "y", paramsArray);
				return NetRuntimeSystem.Convert.ToDouble(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		public NetOffice.VisioApi.Enums.VisMouseMoveDragStates DragState
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DragState", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.VisioApi.Enums.VisMouseMoveDragStates)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 12,14,15)]
		public Int16 Stat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Stat", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}