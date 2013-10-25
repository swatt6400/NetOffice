using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice;
namespace NetOffice.OutlookApi
{

	#region Delegates

	#pragma warning disable
	public delegate void Items_ItemAddEventHandler(COMObject Item);
	public delegate void Items_ItemChangeEventHandler(COMObject Item);
	public delegate void Items_ItemRemoveEventHandler();
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass Items 
	/// SupportByVersion Outlook, 9,10,11,12,14,15
	///</summary>
	///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff863652.aspx </remarks>
	[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class Items : _Items,IEventBinding
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		ItemsEvents_SinkHelper _itemsEvents_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Items);
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public Items(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public Items(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Items(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{
			
		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Items(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Items(COMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		///<summary>
        ///creates a new instance of Items 
        ///</summary>		
		public Items():base("Outlook.Items")
		{
			
		}
		
		///<summary>
        ///creates a new instance of Items
        ///</summary>
        ///<param name="progId">registered ProgID</param>
		public Items(string progId):base(progId)
		{
			
		}

		#endregion

		#region Static CoClass Methods

		/// <summary>
        /// returns all running Outlook.Items objects from the running object table(ROT)
        /// </summary>
        /// <returns>an Outlook.Items array</returns>
		public static NetOffice.OutlookApi.Items[] GetActiveInstances()
		{		
			NetRuntimeSystem.Collections.Generic.List<object> proxyList = NetOffice.RunningObjectTable.GetActiveProxiesFromROT("Outlook","Items");
			NetRuntimeSystem.Collections.Generic.List<NetOffice.OutlookApi.Items> resultList = new NetRuntimeSystem.Collections.Generic.List<NetOffice.OutlookApi.Items>();
			foreach(object proxy in proxyList)
				resultList.Add( new NetOffice.OutlookApi.Items(null, proxy) );
			return resultList.ToArray();
		}

		/// <summary>
        /// returns a running Outlook.Items object from the running object table(ROT). the method takes the first element from the table
        /// </summary>
        /// <returns>an Outlook.Items object or null</returns>
		public static NetOffice.OutlookApi.Items GetActiveInstance()
		{
			object proxy = NetOffice.RunningObjectTable.GetActiveProxyFromROT("Outlook","Items", false);
			if(null != proxy)
				return new NetOffice.OutlookApi.Items(null, proxy);
			else
				return null;
		}

		/// <summary>
        /// returns a running Outlook.Items object from the running object table(ROT).  the method takes the first element from the table
        /// </summary>
	    /// <param name="throwOnError">throw an exception if no object was found</param>
        /// <returns>an Outlook.Items object or null</returns>
		public static NetOffice.OutlookApi.Items GetActiveInstance(bool throwOnError)
		{
			object proxy = NetOffice.RunningObjectTable.GetActiveProxyFromROT("Outlook","Items", throwOnError);
			if(null != proxy)
				return new NetOffice.OutlookApi.Items(null, proxy);
			else
				return null;
		}
		#endregion

		#region Events

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event Items_ItemAddEventHandler _ItemAddEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869609.aspx </remarks>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event Items_ItemAddEventHandler ItemAddEvent
		{
			add
			{
				CreateEventBridge();
				_ItemAddEvent += value;
			}
			remove
			{
				_ItemAddEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event Items_ItemChangeEventHandler _ItemChangeEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff865866.aspx </remarks>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event Items_ItemChangeEventHandler ItemChangeEvent
		{
			add
			{
				CreateEventBridge();
				_ItemChangeEvent += value;
			}
			remove
			{
				_ItemChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event Items_ItemRemoveEventHandler _ItemRemoveEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff868911.aspx </remarks>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event Items_ItemRemoveEventHandler ItemRemoveEvent
		{
			add
			{
				CreateEventBridge();
				_ItemRemoveEvent += value;
			}
			remove
			{
				_ItemRemoveEvent -= value;
			}
		}

		#endregion
       
	    #region IEventBinding Member
        
		/// <summary>
        /// creates active sink helper
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public void CreateEventBridge()
        {
			if(false == Factory.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, ItemsEvents_SinkHelper.Id);


			if(ItemsEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_itemsEvents_SinkHelper = new ItemsEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients()       
        {
			if(null == _thisType)
				_thisType = this.GetType();
					
			foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
			{
				MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
				if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
					return false;
			}
				
			return false;
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int GetCountOfEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates.Length;
            }
            else
                return 0;
        }

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int RaiseCustomEvent(string eventName, ref object[] paramsArray)
		{
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                foreach (var item in delegates)
                {
                    try
                    {
                        item.Method.Invoke(item.Target, paramsArray);
                    }
                    catch (NetRuntimeSystem.Exception exception)
                    {
                        Factory.Console.WriteException(exception);
                    }
                }
                return delegates.Length;
            }
            else
                return 0;
		}

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeEventBridge()
        {
			if( null != _itemsEvents_SinkHelper)
			{
				_itemsEvents_SinkHelper.Dispose();
				_itemsEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion

		#pragma warning restore
	}
}