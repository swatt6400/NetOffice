//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// DispatchInterface ChPoint SupportByLibrary OWC10, 1
	///</summary>
	[SupportByLibrary("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ChPoint : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(ChPoint);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChPoint(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChPoint(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChPoint(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChPoint() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChPoint(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.ChBorder Border
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Border", paramsArray);
				NetOffice.OWC10Api.ChBorder newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.ChBorder.LateBindingApiWrapperType) as NetOffice.OWC10Api.ChBorder;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public Int32 Explosion
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Explosion", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Explosion", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.ChInterior Interior
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Interior", paramsArray);
				NetOffice.OWC10Api.ChInterior newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.ChInterior.LateBindingApiWrapperType) as NetOffice.OWC10Api.ChInterior;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.ChSeries Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				NetOffice.OWC10Api.ChSeries newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.ChSeries.LateBindingApiWrapperType) as NetOffice.OWC10Api.ChSeries;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public Int32 Index
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Index", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.ChLine Line
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Line", paramsArray);
				NetOffice.OWC10Api.ChLine newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.ChLine.LateBindingApiWrapperType) as NetOffice.OWC10Api.ChLine;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get Property
		/// </summary>
		/// <param name="Dimension">NetOffice.OWC10Api.Enums.ChartDimensionsEnum Dimension</param>
		[SupportByLibrary("OWC10", 1)]
		public COMObject get_PivotObject(NetOffice.OWC10Api.Enums.ChartDimensionsEnum dimension)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dimension);
			object returnItem = Invoker.PropertyGet(this, "PivotObject", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public Int32 Top
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Top", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public Int32 Left
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Left", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public Int32 Bottom
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Bottom", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public Int32 Right
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Right", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get Property
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.ChartSelectionsEnum ObjectType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ObjectType", paramsArray);
				return (NetOffice.OWC10Api.Enums.ChartSelectionsEnum)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public void Select()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Select", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Dimension">NetOffice.OWC10Api.Enums.ChartDimensionsEnum Dimension</param>
		/// <param name="scaled">optional object scaled</param>
		[SupportByLibrary("OWC10", 1)]
		public object GetValue(NetOffice.OWC10Api.Enums.ChartDimensionsEnum dimension, object scaled)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dimension, scaled);
			object returnItem = Invoker.MethodReturn(this, "GetValue", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Dimension">NetOffice.OWC10Api.Enums.ChartDimensionsEnum Dimension</param>
		[SupportByLibrary("OWC10", 1)]
		public object GetValue(NetOffice.OWC10Api.Enums.ChartDimensionsEnum dimension)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dimension);
			object returnItem = Invoker.MethodReturn(this, "GetValue", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		#endregion
		#pragma warning restore
	}
}