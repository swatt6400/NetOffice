using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.VisioApi
{
	///<summary>
	/// DispatchInterface IVOLEObject 
	/// SupportByVersion Visio, 11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Visio", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IVOLEObject : COMObject
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
                    _type = typeof(IVOLEObject);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public IVOLEObject(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVOLEObject(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVOLEObject(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVOLEObject(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVOLEObject(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVOLEObject() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVOLEObject(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

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
				NetOffice.VisioApi.IVApplication newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVApplication;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public NetOffice.VisioApi.IVShape Shape
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shape", paramsArray);
				NetOffice.VisioApi.IVShape newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVShape;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public Int16 ObjectType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ObjectType", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public Int16 Stat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Stat", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public string ClassID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ClassID", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public string ProgID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ProgID", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public Int16 ForeignType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ForeignType", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public object Object
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Object", paramsArray);
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}