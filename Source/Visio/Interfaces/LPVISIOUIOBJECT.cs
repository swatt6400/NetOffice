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
	/// Interface LPVISIOUIOBJECT 
	/// SupportByVersion Visio, 11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Visio", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class LPVISIOUIOBJECT : COMObject
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
                    _type = typeof(LPVISIOUIOBJECT);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOUIOBJECT(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOUIOBJECT(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOUIOBJECT(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOUIOBJECT() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOUIOBJECT(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string Default
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Default", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Int16 Flavor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Flavor", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Flavor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public NetOffice.VisioApi.IVMenuSets MenuSets
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MenuSets", paramsArray);
				NetOffice.VisioApi.IVMenuSets newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVMenuSets;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public NetOffice.VisioApi.IVToolbarSets ToolbarSets
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ToolbarSets", paramsArray);
				NetOffice.VisioApi.IVToolbarSets newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVToolbarSets;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NetOffice.VisioApi.IVStatusBars StatusBars
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "StatusBars", paramsArray);
				NetOffice.VisioApi.IVStatusBars newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVStatusBars;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public NetOffice.VisioApi.IVAccelTables AccelTables
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AccelTables", paramsArray);
				NetOffice.VisioApi.IVAccelTables newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVAccelTables;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public bool DisplayKeysInTooltips
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayKeysInTooltips", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayKeysInTooltips", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public bool DisplayTooltips
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayTooltips", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayTooltips", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public bool LargeButtons
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LargeButtons", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LargeButtons", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public Int16 MenuAnimationStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MenuAnimationStyle", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MenuAnimationStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public NetOffice.VisioApi.IVUIObject Clone
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Clone", paramsArray);
				NetOffice.VisioApi.IVUIObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVUIObject;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// </summary>
		/// <param name="fileName">string FileName</param>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public void SaveToFile(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			Invoker.Method(this, "SaveToFile", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// </summary>
		/// <param name="fileName">string FileName</param>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public void LoadFromFile(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			Invoker.Method(this, "LoadFromFile", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public void UpdateUI()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "UpdateUI", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}