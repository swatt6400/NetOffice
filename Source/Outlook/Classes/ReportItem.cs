using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice;
namespace NetOffice.OutlookApi
{

	#region Delegates

	#pragma warning disable
	public delegate void ReportItem_OpenEventHandler(ref bool Cancel);
	public delegate void ReportItem_CustomActionEventHandler(COMObject Action, COMObject Response, ref bool Cancel);
	public delegate void ReportItem_CustomPropertyChangeEventHandler(string Name);
	public delegate void ReportItem_ForwardEventHandler(COMObject Forward, ref bool Cancel);
	public delegate void ReportItem_CloseEventHandler(ref bool Cancel);
	public delegate void ReportItem_PropertyChangeEventHandler(string Name);
	public delegate void ReportItem_ReadEventHandler();
	public delegate void ReportItem_ReplyEventHandler(COMObject Response, ref bool Cancel);
	public delegate void ReportItem_ReplyAllEventHandler(COMObject Response, ref bool Cancel);
	public delegate void ReportItem_SendEventHandler(ref bool Cancel);
	public delegate void ReportItem_WriteEventHandler(ref bool Cancel);
	public delegate void ReportItem_BeforeCheckNamesEventHandler(ref bool Cancel);
	public delegate void ReportItem_AttachmentAddEventHandler(NetOffice.OutlookApi.Attachment Attachment);
	public delegate void ReportItem_AttachmentReadEventHandler(NetOffice.OutlookApi.Attachment Attachment);
	public delegate void ReportItem_BeforeAttachmentSaveEventHandler(NetOffice.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void ReportItem_BeforeDeleteEventHandler(COMObject Item, ref bool Cancel);
	public delegate void ReportItem_AttachmentRemoveEventHandler(NetOffice.OutlookApi.Attachment Attachment);
	public delegate void ReportItem_BeforeAttachmentAddEventHandler(NetOffice.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void ReportItem_BeforeAttachmentPreviewEventHandler(NetOffice.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void ReportItem_BeforeAttachmentReadEventHandler(NetOffice.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void ReportItem_BeforeAttachmentWriteToTempFileEventHandler(NetOffice.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void ReportItem_UnloadEventHandler();
	public delegate void ReportItem_BeforeAutoSaveEventHandler(ref bool Cancel);
	public delegate void ReportItem_BeforeReadEventHandler();
	public delegate void ReportItem_AfterWriteEventHandler();
	public delegate void ReportItem_ReadCompleteEventHandler(ref bool Cancel);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass ReportItem 
	/// SupportByVersion Outlook, 9,10,11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class ReportItem : _ReportItem,IEventBinding
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		ItemEvents_SinkHelper _itemEvents_SinkHelper;
		ItemEvents_10_SinkHelper _itemEvents_10_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(ReportItem);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public ReportItem(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}

		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ReportItem(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ReportItem(COMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		/// <summary>
        /// creates a new instance of ReportItem 
        /// </summary>		
		public ReportItem():base("Outlook.ReportItem")
		{
			
		}
		
		/// <summary>
        /// creates a new instance of ReportItem
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public ReportItem(string progId):base(progId)
		{
			
		}

		#endregion

		#region Static CoClass Methods

		/// <summary>
        /// returns all running Outlook.ReportItem objects from the running object table(ROT)
        /// </summary>
        /// <returns>an Outlook.ReportItem array</returns>
		public static NetOffice.OutlookApi.ReportItem[] GetActiveInstances()
		{		
			NetRuntimeSystem.Collections.Generic.List<object> proxyList = NetOffice.RunningObjectTable.GetActiveProxiesFromROT("Outlook","ReportItem");
			NetRuntimeSystem.Collections.Generic.List<NetOffice.OutlookApi.ReportItem> resultList = new NetRuntimeSystem.Collections.Generic.List<NetOffice.OutlookApi.ReportItem>();
			foreach(object proxy in proxyList)
				resultList.Add( new NetOffice.OutlookApi.ReportItem(null, proxy) );
			return resultList.ToArray();
		}

		/// <summary>
        /// returns a running Outlook.ReportItem object from the running object table(ROT). the method takes the first element from the table
        /// </summary>
        /// <returns>an Outlook.ReportItem object or null</returns>
		public static NetOffice.OutlookApi.ReportItem GetActiveInstance()
		{
			object proxy = NetOffice.RunningObjectTable.GetActiveProxyFromROT("Outlook","ReportItem", false);
			if(null != proxy)
				return new NetOffice.OutlookApi.ReportItem(null, proxy);
			else
				return null;
		}

		/// <summary>
        /// returns a running Outlook.ReportItem object from the running object table(ROT).  the method takes the first element from the table
        /// </summary>
	    /// <param name="throwOnError">throw an exception if no object was found</param>
        /// <returns>an Outlook.ReportItem object or null</returns>
		public static NetOffice.OutlookApi.ReportItem GetActiveInstance(bool throwOnError)
		{
			object proxy = NetOffice.RunningObjectTable.GetActiveProxyFromROT("Outlook","ReportItem", throwOnError);
			if(null != proxy)
				return new NetOffice.OutlookApi.ReportItem(null, proxy);
			else
				return null;
		}
		#endregion

		#region Events

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event ReportItem_OpenEventHandler _OpenEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event ReportItem_OpenEventHandler OpenEvent
		{
			add
			{
				CreateEventBridge();
				_OpenEvent += value;
			}
			remove
			{
				_OpenEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event ReportItem_CustomActionEventHandler _CustomActionEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event ReportItem_CustomActionEventHandler CustomActionEvent
		{
			add
			{
				CreateEventBridge();
				_CustomActionEvent += value;
			}
			remove
			{
				_CustomActionEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event ReportItem_CustomPropertyChangeEventHandler _CustomPropertyChangeEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event ReportItem_CustomPropertyChangeEventHandler CustomPropertyChangeEvent
		{
			add
			{
				CreateEventBridge();
				_CustomPropertyChangeEvent += value;
			}
			remove
			{
				_CustomPropertyChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event ReportItem_ForwardEventHandler _ForwardEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event ReportItem_ForwardEventHandler ForwardEvent
		{
			add
			{
				CreateEventBridge();
				_ForwardEvent += value;
			}
			remove
			{
				_ForwardEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event ReportItem_CloseEventHandler _CloseEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event ReportItem_CloseEventHandler CloseEvent
		{
			add
			{
				CreateEventBridge();
				_CloseEvent += value;
			}
			remove
			{
				_CloseEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event ReportItem_PropertyChangeEventHandler _PropertyChangeEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event ReportItem_PropertyChangeEventHandler PropertyChangeEvent
		{
			add
			{
				CreateEventBridge();
				_PropertyChangeEvent += value;
			}
			remove
			{
				_PropertyChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event ReportItem_ReadEventHandler _ReadEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event ReportItem_ReadEventHandler ReadEvent
		{
			add
			{
				CreateEventBridge();
				_ReadEvent += value;
			}
			remove
			{
				_ReadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event ReportItem_ReplyEventHandler _ReplyEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event ReportItem_ReplyEventHandler ReplyEvent
		{
			add
			{
				CreateEventBridge();
				_ReplyEvent += value;
			}
			remove
			{
				_ReplyEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event ReportItem_ReplyAllEventHandler _ReplyAllEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event ReportItem_ReplyAllEventHandler ReplyAllEvent
		{
			add
			{
				CreateEventBridge();
				_ReplyAllEvent += value;
			}
			remove
			{
				_ReplyAllEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event ReportItem_SendEventHandler _SendEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event ReportItem_SendEventHandler SendEvent
		{
			add
			{
				CreateEventBridge();
				_SendEvent += value;
			}
			remove
			{
				_SendEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event ReportItem_WriteEventHandler _WriteEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event ReportItem_WriteEventHandler WriteEvent
		{
			add
			{
				CreateEventBridge();
				_WriteEvent += value;
			}
			remove
			{
				_WriteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event ReportItem_BeforeCheckNamesEventHandler _BeforeCheckNamesEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event ReportItem_BeforeCheckNamesEventHandler BeforeCheckNamesEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeCheckNamesEvent += value;
			}
			remove
			{
				_BeforeCheckNamesEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event ReportItem_AttachmentAddEventHandler _AttachmentAddEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event ReportItem_AttachmentAddEventHandler AttachmentAddEvent
		{
			add
			{
				CreateEventBridge();
				_AttachmentAddEvent += value;
			}
			remove
			{
				_AttachmentAddEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event ReportItem_AttachmentReadEventHandler _AttachmentReadEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event ReportItem_AttachmentReadEventHandler AttachmentReadEvent
		{
			add
			{
				CreateEventBridge();
				_AttachmentReadEvent += value;
			}
			remove
			{
				_AttachmentReadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event ReportItem_BeforeAttachmentSaveEventHandler _BeforeAttachmentSaveEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event ReportItem_BeforeAttachmentSaveEventHandler BeforeAttachmentSaveEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentSaveEvent += value;
			}
			remove
			{
				_BeforeAttachmentSaveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 10,11,12,14,15
		/// </summary>
		private event ReportItem_BeforeDeleteEventHandler _BeforeDeleteEvent;

		/// <summary>
		/// SupportByVersion Outlook 10 11 12 14 15
		/// </summary>
		[SupportByVersion("Outlook", 10,11,12,14,15)]
		public event ReportItem_BeforeDeleteEventHandler BeforeDeleteEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeDeleteEvent += value;
			}
			remove
			{
				_BeforeDeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 12,14,15
		/// </summary>
		private event ReportItem_AttachmentRemoveEventHandler _AttachmentRemoveEvent;

		/// <summary>
		/// SupportByVersion Outlook 12 14 15
		/// </summary>
		[SupportByVersion("Outlook", 12,14,15)]
		public event ReportItem_AttachmentRemoveEventHandler AttachmentRemoveEvent
		{
			add
			{
				CreateEventBridge();
				_AttachmentRemoveEvent += value;
			}
			remove
			{
				_AttachmentRemoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 12,14,15
		/// </summary>
		private event ReportItem_BeforeAttachmentAddEventHandler _BeforeAttachmentAddEvent;

		/// <summary>
		/// SupportByVersion Outlook 12 14 15
		/// </summary>
		[SupportByVersion("Outlook", 12,14,15)]
		public event ReportItem_BeforeAttachmentAddEventHandler BeforeAttachmentAddEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentAddEvent += value;
			}
			remove
			{
				_BeforeAttachmentAddEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 12,14,15
		/// </summary>
		private event ReportItem_BeforeAttachmentPreviewEventHandler _BeforeAttachmentPreviewEvent;

		/// <summary>
		/// SupportByVersion Outlook 12 14 15
		/// </summary>
		[SupportByVersion("Outlook", 12,14,15)]
		public event ReportItem_BeforeAttachmentPreviewEventHandler BeforeAttachmentPreviewEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentPreviewEvent += value;
			}
			remove
			{
				_BeforeAttachmentPreviewEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 12,14,15
		/// </summary>
		private event ReportItem_BeforeAttachmentReadEventHandler _BeforeAttachmentReadEvent;

		/// <summary>
		/// SupportByVersion Outlook 12 14 15
		/// </summary>
		[SupportByVersion("Outlook", 12,14,15)]
		public event ReportItem_BeforeAttachmentReadEventHandler BeforeAttachmentReadEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentReadEvent += value;
			}
			remove
			{
				_BeforeAttachmentReadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 12,14,15
		/// </summary>
		private event ReportItem_BeforeAttachmentWriteToTempFileEventHandler _BeforeAttachmentWriteToTempFileEvent;

		/// <summary>
		/// SupportByVersion Outlook 12 14 15
		/// </summary>
		[SupportByVersion("Outlook", 12,14,15)]
		public event ReportItem_BeforeAttachmentWriteToTempFileEventHandler BeforeAttachmentWriteToTempFileEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentWriteToTempFileEvent += value;
			}
			remove
			{
				_BeforeAttachmentWriteToTempFileEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 12,14,15
		/// </summary>
		private event ReportItem_UnloadEventHandler _UnloadEvent;

		/// <summary>
		/// SupportByVersion Outlook 12 14 15
		/// </summary>
		[SupportByVersion("Outlook", 12,14,15)]
		public event ReportItem_UnloadEventHandler UnloadEvent
		{
			add
			{
				CreateEventBridge();
				_UnloadEvent += value;
			}
			remove
			{
				_UnloadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 12,14,15
		/// </summary>
		private event ReportItem_BeforeAutoSaveEventHandler _BeforeAutoSaveEvent;

		/// <summary>
		/// SupportByVersion Outlook 12 14 15
		/// </summary>
		[SupportByVersion("Outlook", 12,14,15)]
		public event ReportItem_BeforeAutoSaveEventHandler BeforeAutoSaveEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAutoSaveEvent += value;
			}
			remove
			{
				_BeforeAutoSaveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 14,15
		/// </summary>
		private event ReportItem_BeforeReadEventHandler _BeforeReadEvent;

		/// <summary>
		/// SupportByVersion Outlook 14 15
		/// </summary>
		[SupportByVersion("Outlook", 14,15)]
		public event ReportItem_BeforeReadEventHandler BeforeReadEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeReadEvent += value;
			}
			remove
			{
				_BeforeReadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 14,15
		/// </summary>
		private event ReportItem_AfterWriteEventHandler _AfterWriteEvent;

		/// <summary>
		/// SupportByVersion Outlook 14 15
		/// </summary>
		[SupportByVersion("Outlook", 14,15)]
		public event ReportItem_AfterWriteEventHandler AfterWriteEvent
		{
			add
			{
				CreateEventBridge();
				_AfterWriteEvent += value;
			}
			remove
			{
				_AfterWriteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 15
		/// </summary>
		private event ReportItem_ReadCompleteEventHandler _ReadCompleteEvent;

		/// <summary>
		/// SupportByVersion Outlook 15
		/// </summary>
		[SupportByVersion("Outlook", 15)]
		public event ReportItem_ReadCompleteEventHandler ReadCompleteEvent
		{
			add
			{
				CreateEventBridge();
				_ReadCompleteEvent += value;
			}
			remove
			{
				_ReadCompleteEvent -= value;
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, ItemEvents_SinkHelper.Id,ItemEvents_10_SinkHelper.Id);


			if(ItemEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_itemEvents_SinkHelper = new ItemEvents_SinkHelper(this, _connectPoint);
				return;
			}

			if(ItemEvents_10_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_itemEvents_10_SinkHelper = new ItemEvents_10_SinkHelper(this, _connectPoint);
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
			if( null != _itemEvents_SinkHelper)
			{
				_itemEvents_SinkHelper.Dispose();
				_itemEvents_SinkHelper = null;
			}
			if( null != _itemEvents_10_SinkHelper)
			{
				_itemEvents_10_SinkHelper.Dispose();
				_itemEvents_10_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion

		#pragma warning restore
	}
}