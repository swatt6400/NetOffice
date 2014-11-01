using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface TimelineViewState 
	/// SupportByVersion Excel, 15
	/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj229703.aspx
	///</summary>
	[SupportByVersionAttribute("Excel", 15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class TimelineViewState : COMObject
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
                    _type = typeof(TimelineViewState);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public TimelineViewState(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TimelineViewState(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TimelineViewState(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TimelineViewState(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TimelineViewState(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TimelineViewState() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TimelineViewState(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj231262.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj231384.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlCreator)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj230711.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Excel", 15)]
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
		/// SupportByVersion Excel 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj231943.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 15)]
		public bool ShowHeader
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowHeader", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowHeader", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj232122.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 15)]
		public bool ShowSelectionLabel
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowSelectionLabel", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowSelectionLabel", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj231471.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 15)]
		public bool ShowTimeLevel
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowTimeLevel", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowTimeLevel", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj231773.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 15)]
		public bool ShowHorizontalScrollbar
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowHorizontalScrollbar", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowHorizontalScrollbar", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj231876.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 15)]
		public NetOffice.ExcelApi.Enums.XlTimelineLevel Level
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Level", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlTimelineLevel)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Level", paramsArray);
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}