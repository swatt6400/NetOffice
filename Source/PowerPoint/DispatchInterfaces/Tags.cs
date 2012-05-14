using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface Tags 
	/// SupportByVersion PowerPoint, 9,10,11,12,14
	///</summary>
	[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Tags : Collection
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
                    _type = typeof(Tags);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Tags(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Tags(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Tags(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Tags() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Tags(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Application.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="name">string Name</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public string this[string name]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(name);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="value">string Value</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public void Add(string name, string value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, value);
			Invoker.Method(this, "Add", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="name">string Name</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public void Delete(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="filePath">string FilePath</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public void AddBinary(string name, string filePath)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, filePath);
			Invoker.Method(this, "AddBinary", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="name">string Name</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public Int32 BinaryValue(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "BinaryValue", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="index">Int32 index</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public string Name(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Name", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="index">Int32 index</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public string Value(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Value", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		#endregion
		#pragma warning restore
	}
}