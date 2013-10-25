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
	/// DispatchInterface IRtdServer 
	/// SupportByVersion Excel, 10,11,12,14,15
	///</summary>
	///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff822377.aspx </remarks>
	[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IRtdServer : COMObject
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
                    _type = typeof(IRtdServer);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public IRtdServer(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IRtdServer(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IRtdServer(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IRtdServer(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IRtdServer(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IRtdServer() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IRtdServer(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="callbackObject">NetOffice.ExcelApi.IRTDUpdateEvent CallbackObject</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff198343.aspx </remarks>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public Int32 ServerStart(NetOffice.ExcelApi.IRTDUpdateEvent callbackObject)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(callbackObject);
			object returnItem = Invoker.MethodReturn(this, "ServerStart", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="topicID">Int32 TopicID</param>
		/// <param name="strings">object[] Strings</param>
		/// <param name="getNewValues">bool GetNewValues</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195923.aspx </remarks>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object ConnectData(Int32 topicID, object[] strings, bool getNewValues)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(topicID, (object)strings, getNewValues);
			object returnItem = Invoker.MethodReturn(this, "ConnectData", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="topicCount">Int32 TopicCount</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197313.aspx </remarks>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public object[] RefreshData(Int32 topicCount)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(topicCount);
			object returnItem = Invoker.MethodReturn(this, "RefreshData", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject[] newObject = Factory.CreateObjectArrayFromComProxy(this, (object[])returnItem);
				return newObject;
			}
			else
			{
				return (object[]) returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="topicID">Int32 TopicID</param>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194189.aspx </remarks>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public void DisconnectData(Int32 topicID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(topicID);
			Invoker.Method(this, "DisconnectData", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836824.aspx </remarks>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public Int32 Heartbeat()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Heartbeat", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff820931.aspx </remarks>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public void ServerTerminate()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ServerTerminate", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}