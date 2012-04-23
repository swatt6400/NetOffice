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
	/// DispatchInterface PivotMember 
	/// SupportByVersion OWC10, 1
	///</summary>
	[SupportByVersionAttribute("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PivotMember : COMObject
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
                    _type = typeof(PivotMember);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotMember(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotMember(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotMember(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotMember() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotMember(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PivotView View
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "View", paramsArray);
				NetOffice.OWC10Api.PivotView newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.PivotView.LateBindingApiWrapperType) as NetOffice.OWC10Api.PivotView;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PivotMembers ChildMembers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ChildMembers", paramsArray);
				NetOffice.OWC10Api.PivotMembers newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.PivotMembers.LateBindingApiWrapperType) as NetOffice.OWC10Api.PivotMembers;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PivotMember ParentMember
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ParentMember", paramsArray);
				NetOffice.OWC10Api.PivotMember newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotMember;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		/// <param name="path">string Path</param>
		/// <param name="format">NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum Format</param>
		[SupportByVersionAttribute("OWC10", 1)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NetOffice.OWC10Api.PivotMember get_FindMember(string path, NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum format)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(path, format);
			object returnItem = Invoker.PropertyGet(this, "FindMember", paramsArray);
			NetOffice.OWC10Api.PivotMember newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotMember;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Alias for get_FindMember
		/// </summary>
		/// <param name="path">string Path</param>
		/// <param name="format">NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum Format</param>
		[SupportByVersionAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PivotMember FindMember(string path, NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum format)
		{
			return get_FindMember(path, format);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public string Caption
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Caption", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public object Value
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Value", paramsArray);
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
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public string UniqueName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UniqueName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.PivotField Field
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Field", paramsArray);
				NetOffice.OWC10Api.PivotField newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.PivotField.LateBindingApiWrapperType) as NetOffice.OWC10Api.PivotField;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		/// <param name="format">NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum Format</param>
		[SupportByVersionAttribute("OWC10", 1)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string get_Path(NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum format)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(format);
			object returnItem = Invoker.PropertyGet(this, "Path", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Alias for get_Path
		/// </summary>
		/// <param name="format">NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum Format</param>
		[SupportByVersionAttribute("OWC10", 1)]
		public string Path(NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum format)
		{
			return get_Path(format);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public object TimeValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TimeValue", paramsArray);
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
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public bool IsValid
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsValid", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersionAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.PivotMemberCustomGroupTypeEnum CustomGroupType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CustomGroupType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OWC10Api.Enums.PivotMemberCustomGroupTypeEnum)intReturnItem;
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}