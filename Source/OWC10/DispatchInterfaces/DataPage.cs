using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// DispatchInterface DataPage 
	/// SupportByVersion OWC10, 1
	///</summary>
	[SupportByVersionAttribute("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class DataPage : COMObject
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
                    _type = typeof(DataPage);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataPage(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataPage(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataPage(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataPage() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataPage(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.GroupLevel GroupLevel
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GroupLevel", paramsArray);
				NetOffice.OWC10Api.GroupLevel newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.GroupLevel.LateBindingApiWrapperType) as NetOffice.OWC10Api.GroupLevel;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public NetOffice.ADODBApi.Recordset Recordset
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Recordset", paramsArray);
				NetOffice.ADODBApi.Recordset newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ADODBApi.Recordset.LateBindingApiWrapperType) as NetOffice.ADODBApi.Recordset;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public object Filter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Filter", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Filter", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public bool IsFilterOn
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsFilterOn", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "IsFilterOn", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.Section FirstSection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FirstSection", paramsArray);
				NetOffice.OWC10Api.Section newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.Section.LateBindingApiWrapperType) as NetOffice.OWC10Api.Section;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public void MoveFirst()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MoveFirst", paramsArray);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public void MoveLast()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MoveLast", paramsArray);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public void MoveNext()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MoveNext", paramsArray);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public void MovePrevious()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MovePrevious", paramsArray);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public void NewRecord()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "NewRecord", paramsArray);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public void DeleteRecord()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "DeleteRecord", paramsArray);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public void Save()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Save", paramsArray);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public void Undo()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Undo", paramsArray);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public void Requery()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Requery", paramsArray);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public void SortAscending()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SortAscending", paramsArray);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public void SortDescending()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SortDescending", paramsArray);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public void ApplyFilter()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ApplyFilter", paramsArray);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public void ToggleFilter()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ToggleFilter", paramsArray);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("OWC10", 1)]
		public void Help()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Help", paramsArray);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		/// <param name="button">NetOffice.OWC10Api.Enums.NavButtonEnum Button</param>
		[SupportByVersionAttribute("OWC10", 1)]
		public bool IsButtonEnabled(NetOffice.OWC10Api.Enums.NavButtonEnum button)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(button);
			object returnItem = Invoker.MethodReturn(this, "IsButtonEnabled", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		#endregion
		#pragma warning restore
	}
}