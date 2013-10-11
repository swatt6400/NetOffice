using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice;
namespace NetOffice.VisioApi
{

	#region Delegates

	#pragma warning disable
	public delegate void Masters_MasterAddedEventHandler(NetOffice.VisioApi.IVMaster Master);
	public delegate void Masters_MasterChangedEventHandler(NetOffice.VisioApi.IVMaster Master);
	public delegate void Masters_BeforeMasterDeleteEventHandler(NetOffice.VisioApi.IVMaster Master);
	public delegate void Masters_ShapeAddedEventHandler(NetOffice.VisioApi.IVShape Shape);
	public delegate void Masters_BeforeSelectionDeleteEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Masters_ShapeChangedEventHandler(NetOffice.VisioApi.IVShape Shape);
	public delegate void Masters_SelectionAddedEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Masters_BeforeShapeDeleteEventHandler(NetOffice.VisioApi.IVShape Shape);
	public delegate void Masters_TextChangedEventHandler(NetOffice.VisioApi.IVShape Shape);
	public delegate void Masters_CellChangedEventHandler(NetOffice.VisioApi.IVCell Cell);
	public delegate void Masters_FormulaChangedEventHandler(NetOffice.VisioApi.IVCell Cell);
	public delegate void Masters_ConnectionsAddedEventHandler(NetOffice.VisioApi.IVConnects Connects);
	public delegate void Masters_ConnectionsDeletedEventHandler(NetOffice.VisioApi.IVConnects Connects);
	public delegate void Masters_QueryCancelMasterDeleteEventHandler(NetOffice.VisioApi.IVMaster Master);
	public delegate void Masters_MasterDeleteCanceledEventHandler(NetOffice.VisioApi.IVMaster Master);
	public delegate void Masters_ShapeParentChangedEventHandler(NetOffice.VisioApi.IVShape Shape);
	public delegate void Masters_BeforeShapeTextEditEventHandler(NetOffice.VisioApi.IVShape Shape);
	public delegate void Masters_ShapeExitedTextEditEventHandler(NetOffice.VisioApi.IVShape Shape);
	public delegate void Masters_QueryCancelSelectionDeleteEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Masters_SelectionDeleteCanceledEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Masters_QueryCancelUngroupEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Masters_UngroupCanceledEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Masters_QueryCancelConvertToGroupEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Masters_ConvertToGroupCanceledEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Masters_QueryCancelGroupEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Masters_GroupCanceledEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Masters_ShapeDataGraphicChangedEventHandler(NetOffice.VisioApi.IVShape Shape);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass Masters 
	/// SupportByVersion Visio, 11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Visio", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class Masters : IVMasters,IEventBinding
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		EMasters_SinkHelper _eMasters_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Masters);
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public Masters(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}

		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Masters(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Masters(COMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		/// <summary>
        /// creates a new instance of Masters 
        /// </summary>		
		public Masters():base("Visio.Masters")
		{
			
		}
		
		/// <summary>
        /// creates a new instance of Masters
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public Masters(string progId):base(progId)
		{
			
		}

		#endregion

		#region Static CoClass Methods

		/// <summary>
        /// returns all running Visio.Masters objects from the running object table(ROT)
        /// </summary>
        /// <returns>an Visio.Masters array</returns>
		public static NetOffice.VisioApi.Masters[] GetActiveInstances()
		{		
			NetRuntimeSystem.Collections.Generic.List<object> proxyList = NetOffice.RunningObjectTable.GetActiveProxiesFromROT("Visio","Masters");
			NetRuntimeSystem.Collections.Generic.List<NetOffice.VisioApi.Masters> resultList = new NetRuntimeSystem.Collections.Generic.List<NetOffice.VisioApi.Masters>();
			foreach(object proxy in proxyList)
				resultList.Add( new NetOffice.VisioApi.Masters(null, proxy) );
			return resultList.ToArray();
		}

		/// <summary>
        /// returns a running Visio.Masters object from the running object table(ROT). the method takes the first element from the table
        /// </summary>
        /// <returns>an Visio.Masters object or null</returns>
		public static NetOffice.VisioApi.Masters GetActiveInstance()
		{
			object proxy = NetOffice.RunningObjectTable.GetActiveProxyFromROT("Visio","Masters", false);
			if(null != proxy)
				return new NetOffice.VisioApi.Masters(null, proxy);
			else
				return null;
		}

		/// <summary>
        /// returns a running Visio.Masters object from the running object table(ROT).  the method takes the first element from the table
        /// </summary>
	    /// <param name="throwOnError">throw an exception if no object was found</param>
        /// <returns>an Visio.Masters object or null</returns>
		public static NetOffice.VisioApi.Masters GetActiveInstance(bool throwOnError)
		{
			object proxy = NetOffice.RunningObjectTable.GetActiveProxyFromROT("Visio","Masters", throwOnError);
			if(null != proxy)
				return new NetOffice.VisioApi.Masters(null, proxy);
			else
				return null;
		}
		#endregion

		#region Events

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Masters_MasterAddedEventHandler _MasterAddedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Masters_MasterAddedEventHandler MasterAddedEvent
		{
			add
			{
				CreateEventBridge();
				_MasterAddedEvent += value;
			}
			remove
			{
				_MasterAddedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Masters_MasterChangedEventHandler _MasterChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Masters_MasterChangedEventHandler MasterChangedEvent
		{
			add
			{
				CreateEventBridge();
				_MasterChangedEvent += value;
			}
			remove
			{
				_MasterChangedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Masters_BeforeMasterDeleteEventHandler _BeforeMasterDeleteEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Masters_BeforeMasterDeleteEventHandler BeforeMasterDeleteEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeMasterDeleteEvent += value;
			}
			remove
			{
				_BeforeMasterDeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Masters_ShapeAddedEventHandler _ShapeAddedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Masters_ShapeAddedEventHandler ShapeAddedEvent
		{
			add
			{
				CreateEventBridge();
				_ShapeAddedEvent += value;
			}
			remove
			{
				_ShapeAddedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Masters_BeforeSelectionDeleteEventHandler _BeforeSelectionDeleteEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Masters_BeforeSelectionDeleteEventHandler BeforeSelectionDeleteEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeSelectionDeleteEvent += value;
			}
			remove
			{
				_BeforeSelectionDeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Masters_ShapeChangedEventHandler _ShapeChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Masters_ShapeChangedEventHandler ShapeChangedEvent
		{
			add
			{
				CreateEventBridge();
				_ShapeChangedEvent += value;
			}
			remove
			{
				_ShapeChangedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Masters_SelectionAddedEventHandler _SelectionAddedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Masters_SelectionAddedEventHandler SelectionAddedEvent
		{
			add
			{
				CreateEventBridge();
				_SelectionAddedEvent += value;
			}
			remove
			{
				_SelectionAddedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Masters_BeforeShapeDeleteEventHandler _BeforeShapeDeleteEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Masters_BeforeShapeDeleteEventHandler BeforeShapeDeleteEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeShapeDeleteEvent += value;
			}
			remove
			{
				_BeforeShapeDeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Masters_TextChangedEventHandler _TextChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Masters_TextChangedEventHandler TextChangedEvent
		{
			add
			{
				CreateEventBridge();
				_TextChangedEvent += value;
			}
			remove
			{
				_TextChangedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Masters_CellChangedEventHandler _CellChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Masters_CellChangedEventHandler CellChangedEvent
		{
			add
			{
				CreateEventBridge();
				_CellChangedEvent += value;
			}
			remove
			{
				_CellChangedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Masters_FormulaChangedEventHandler _FormulaChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Masters_FormulaChangedEventHandler FormulaChangedEvent
		{
			add
			{
				CreateEventBridge();
				_FormulaChangedEvent += value;
			}
			remove
			{
				_FormulaChangedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Masters_ConnectionsAddedEventHandler _ConnectionsAddedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Masters_ConnectionsAddedEventHandler ConnectionsAddedEvent
		{
			add
			{
				CreateEventBridge();
				_ConnectionsAddedEvent += value;
			}
			remove
			{
				_ConnectionsAddedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Masters_ConnectionsDeletedEventHandler _ConnectionsDeletedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Masters_ConnectionsDeletedEventHandler ConnectionsDeletedEvent
		{
			add
			{
				CreateEventBridge();
				_ConnectionsDeletedEvent += value;
			}
			remove
			{
				_ConnectionsDeletedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Masters_QueryCancelMasterDeleteEventHandler _QueryCancelMasterDeleteEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Masters_QueryCancelMasterDeleteEventHandler QueryCancelMasterDeleteEvent
		{
			add
			{
				CreateEventBridge();
				_QueryCancelMasterDeleteEvent += value;
			}
			remove
			{
				_QueryCancelMasterDeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Masters_MasterDeleteCanceledEventHandler _MasterDeleteCanceledEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Masters_MasterDeleteCanceledEventHandler MasterDeleteCanceledEvent
		{
			add
			{
				CreateEventBridge();
				_MasterDeleteCanceledEvent += value;
			}
			remove
			{
				_MasterDeleteCanceledEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Masters_ShapeParentChangedEventHandler _ShapeParentChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Masters_ShapeParentChangedEventHandler ShapeParentChangedEvent
		{
			add
			{
				CreateEventBridge();
				_ShapeParentChangedEvent += value;
			}
			remove
			{
				_ShapeParentChangedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Masters_BeforeShapeTextEditEventHandler _BeforeShapeTextEditEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Masters_BeforeShapeTextEditEventHandler BeforeShapeTextEditEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeShapeTextEditEvent += value;
			}
			remove
			{
				_BeforeShapeTextEditEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Masters_ShapeExitedTextEditEventHandler _ShapeExitedTextEditEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Masters_ShapeExitedTextEditEventHandler ShapeExitedTextEditEvent
		{
			add
			{
				CreateEventBridge();
				_ShapeExitedTextEditEvent += value;
			}
			remove
			{
				_ShapeExitedTextEditEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Masters_QueryCancelSelectionDeleteEventHandler _QueryCancelSelectionDeleteEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Masters_QueryCancelSelectionDeleteEventHandler QueryCancelSelectionDeleteEvent
		{
			add
			{
				CreateEventBridge();
				_QueryCancelSelectionDeleteEvent += value;
			}
			remove
			{
				_QueryCancelSelectionDeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Masters_SelectionDeleteCanceledEventHandler _SelectionDeleteCanceledEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Masters_SelectionDeleteCanceledEventHandler SelectionDeleteCanceledEvent
		{
			add
			{
				CreateEventBridge();
				_SelectionDeleteCanceledEvent += value;
			}
			remove
			{
				_SelectionDeleteCanceledEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Masters_QueryCancelUngroupEventHandler _QueryCancelUngroupEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Masters_QueryCancelUngroupEventHandler QueryCancelUngroupEvent
		{
			add
			{
				CreateEventBridge();
				_QueryCancelUngroupEvent += value;
			}
			remove
			{
				_QueryCancelUngroupEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Masters_UngroupCanceledEventHandler _UngroupCanceledEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Masters_UngroupCanceledEventHandler UngroupCanceledEvent
		{
			add
			{
				CreateEventBridge();
				_UngroupCanceledEvent += value;
			}
			remove
			{
				_UngroupCanceledEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Masters_QueryCancelConvertToGroupEventHandler _QueryCancelConvertToGroupEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Masters_QueryCancelConvertToGroupEventHandler QueryCancelConvertToGroupEvent
		{
			add
			{
				CreateEventBridge();
				_QueryCancelConvertToGroupEvent += value;
			}
			remove
			{
				_QueryCancelConvertToGroupEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Masters_ConvertToGroupCanceledEventHandler _ConvertToGroupCanceledEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Masters_ConvertToGroupCanceledEventHandler ConvertToGroupCanceledEvent
		{
			add
			{
				CreateEventBridge();
				_ConvertToGroupCanceledEvent += value;
			}
			remove
			{
				_ConvertToGroupCanceledEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 12,14,15
		/// </summary>
		private event Masters_QueryCancelGroupEventHandler _QueryCancelGroupEvent;

		/// <summary>
		/// SupportByVersion Visio 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 12,14,15)]
		public event Masters_QueryCancelGroupEventHandler QueryCancelGroupEvent
		{
			add
			{
				CreateEventBridge();
				_QueryCancelGroupEvent += value;
			}
			remove
			{
				_QueryCancelGroupEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 12,14,15
		/// </summary>
		private event Masters_GroupCanceledEventHandler _GroupCanceledEvent;

		/// <summary>
		/// SupportByVersion Visio 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 12,14,15)]
		public event Masters_GroupCanceledEventHandler GroupCanceledEvent
		{
			add
			{
				CreateEventBridge();
				_GroupCanceledEvent += value;
			}
			remove
			{
				_GroupCanceledEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 12,14,15
		/// </summary>
		private event Masters_ShapeDataGraphicChangedEventHandler _ShapeDataGraphicChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 12,14,15)]
		public event Masters_ShapeDataGraphicChangedEventHandler ShapeDataGraphicChangedEvent
		{
			add
			{
				CreateEventBridge();
				_ShapeDataGraphicChangedEvent += value;
			}
			remove
			{
				_ShapeDataGraphicChangedEvent -= value;
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
			if(false == NetOffice.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, EMasters_SinkHelper.Id);


			if(EMasters_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_eMasters_SinkHelper = new EMasters_SinkHelper(this, _connectPoint);
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
                        DebugConsole.WriteException(exception);
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
			if( null != _eMasters_SinkHelper)
			{
				_eMasters_SinkHelper.Dispose();
				_eMasters_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion

		#pragma warning restore
	}
}