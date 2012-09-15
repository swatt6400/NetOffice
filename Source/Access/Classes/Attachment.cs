using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice;
namespace NetOffice.AccessApi
{

	#region Delegates

	#pragma warning disable
	public delegate void Attachment_BeforeUpdateEventHandler(ref Int16 Cancel);
	public delegate void Attachment_AfterUpdateEventHandler();
	public delegate void Attachment_EnterEventHandler();
	public delegate void Attachment_ExitEventHandler(ref Int16 Cancel);
	public delegate void Attachment_DirtyEventHandler(ref Int16 Cancel);
	public delegate void Attachment_ChangeEventHandler();
	public delegate void Attachment_GotFocusEventHandler();
	public delegate void Attachment_LostFocusEventHandler();
	public delegate void Attachment_ClickEventHandler();
	public delegate void Attachment_DblClickEventHandler(ref Int16 Cancel);
	public delegate void Attachment_MouseDownEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void Attachment_MouseMoveEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void Attachment_MouseUpEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void Attachment_KeyDownEventHandler(ref Int16 KeyCode, ref Int16 Shift);
	public delegate void Attachment_KeyPressEventHandler(ref Int16 KeyAscii);
	public delegate void Attachment_KeyUpEventHandler(ref Int16 KeyCode, ref Int16 Shift);
	public delegate void Attachment_AttachmentCurrentEventHandler();
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass Attachment 
	/// SupportByVersion Access, 12,14,15
	///</summary>
	[SupportByVersionAttribute("Access", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class Attachment : _Attachment,IEventBinding
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		DispAttachmentEvents_SinkHelper _dispAttachmentEvents_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Attachment);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public Attachment(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}

		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Attachment(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Attachment(COMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		/// <summary>
        /// creates a new instance of Attachment 
        /// </summary>		
		public Attachment():base("Access.Attachment")
		{
			
		}
		
		/// <summary>
        /// creates a new instance of Attachment
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public Attachment(string progId):base(progId)
		{
			
		}

		#endregion

		#region Static CoClass Methods

		/// <summary>
        /// returns all running Access.Attachment objects from the running object table(ROT)
        /// </summary>
        /// <returns>an Access.Attachment array</returns>
		public static NetOffice.AccessApi.Attachment[] GetActiveInstances()
		{		
			NetRuntimeSystem.Collections.Generic.List<object> proxyList = NetOffice.RunningObjectTable.GetActiveProxiesFromROT("Access","Attachment");
			NetRuntimeSystem.Collections.Generic.List<NetOffice.AccessApi.Attachment> resultList = new NetRuntimeSystem.Collections.Generic.List<NetOffice.AccessApi.Attachment>();
			foreach(object proxy in proxyList)
				resultList.Add( new NetOffice.AccessApi.Attachment(null, proxy) );
			return resultList.ToArray();
		}

		/// <summary>
        /// returns a running Access.Attachment object from the running object table(ROT). the method takes the first element from the table
        /// </summary>
        /// <returns>an Access.Attachment object or null</returns>
		public static NetOffice.AccessApi.Attachment GetActiveInstance()
		{
			object proxy = NetOffice.RunningObjectTable.GetActiveProxyFromROT("Access","Attachment", false);
			if(null != proxy)
				return new NetOffice.AccessApi.Attachment(null, proxy);
			else
				return null;
		}

		/// <summary>
        /// returns a running Access.Attachment object from the running object table(ROT).  the method takes the first element from the table
        /// </summary>
	    /// <param name="throwOnError">throw an exception if no object was found</param>
        /// <returns>an Access.Attachment object or null</returns>
		public static NetOffice.AccessApi.Attachment GetActiveInstance(bool throwOnError)
		{
			object proxy = NetOffice.RunningObjectTable.GetActiveProxyFromROT("Access","Attachment", throwOnError);
			if(null != proxy)
				return new NetOffice.AccessApi.Attachment(null, proxy);
			else
				return null;
		}
		#endregion

		#region Events

		/// <summary>
		/// SupportByVersion Access, 12,14,15
		/// </summary>
		private event Attachment_BeforeUpdateEventHandler _BeforeUpdateEvent;

		/// <summary>
		/// SupportByVersion Access 12 14 15
		/// </summary>
		[SupportByVersion("Access", 12,14,15)]
		public event Attachment_BeforeUpdateEventHandler BeforeUpdateEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeUpdateEvent += value;
			}
			remove
			{
				_BeforeUpdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14,15
		/// </summary>
		private event Attachment_AfterUpdateEventHandler _AfterUpdateEvent;

		/// <summary>
		/// SupportByVersion Access 12 14 15
		/// </summary>
		[SupportByVersion("Access", 12,14,15)]
		public event Attachment_AfterUpdateEventHandler AfterUpdateEvent
		{
			add
			{
				CreateEventBridge();
				_AfterUpdateEvent += value;
			}
			remove
			{
				_AfterUpdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14,15
		/// </summary>
		private event Attachment_EnterEventHandler _EnterEvent;

		/// <summary>
		/// SupportByVersion Access 12 14 15
		/// </summary>
		[SupportByVersion("Access", 12,14,15)]
		public event Attachment_EnterEventHandler EnterEvent
		{
			add
			{
				CreateEventBridge();
				_EnterEvent += value;
			}
			remove
			{
				_EnterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14,15
		/// </summary>
		private event Attachment_ExitEventHandler _ExitEvent;

		/// <summary>
		/// SupportByVersion Access 12 14 15
		/// </summary>
		[SupportByVersion("Access", 12,14,15)]
		public event Attachment_ExitEventHandler ExitEvent
		{
			add
			{
				CreateEventBridge();
				_ExitEvent += value;
			}
			remove
			{
				_ExitEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14,15
		/// </summary>
		private event Attachment_DirtyEventHandler _DirtyEvent;

		/// <summary>
		/// SupportByVersion Access 12 14 15
		/// </summary>
		[SupportByVersion("Access", 12,14,15)]
		public event Attachment_DirtyEventHandler DirtyEvent
		{
			add
			{
				CreateEventBridge();
				_DirtyEvent += value;
			}
			remove
			{
				_DirtyEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14,15
		/// </summary>
		private event Attachment_ChangeEventHandler _ChangeEvent;

		/// <summary>
		/// SupportByVersion Access 12 14 15
		/// </summary>
		[SupportByVersion("Access", 12,14,15)]
		public event Attachment_ChangeEventHandler ChangeEvent
		{
			add
			{
				CreateEventBridge();
				_ChangeEvent += value;
			}
			remove
			{
				_ChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14,15
		/// </summary>
		private event Attachment_GotFocusEventHandler _GotFocusEvent;

		/// <summary>
		/// SupportByVersion Access 12 14 15
		/// </summary>
		[SupportByVersion("Access", 12,14,15)]
		public event Attachment_GotFocusEventHandler GotFocusEvent
		{
			add
			{
				CreateEventBridge();
				_GotFocusEvent += value;
			}
			remove
			{
				_GotFocusEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14,15
		/// </summary>
		private event Attachment_LostFocusEventHandler _LostFocusEvent;

		/// <summary>
		/// SupportByVersion Access 12 14 15
		/// </summary>
		[SupportByVersion("Access", 12,14,15)]
		public event Attachment_LostFocusEventHandler LostFocusEvent
		{
			add
			{
				CreateEventBridge();
				_LostFocusEvent += value;
			}
			remove
			{
				_LostFocusEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14,15
		/// </summary>
		private event Attachment_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByVersion Access 12 14 15
		/// </summary>
		[SupportByVersion("Access", 12,14,15)]
		public event Attachment_ClickEventHandler ClickEvent
		{
			add
			{
				CreateEventBridge();
				_ClickEvent += value;
			}
			remove
			{
				_ClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14,15
		/// </summary>
		private event Attachment_DblClickEventHandler _DblClickEvent;

		/// <summary>
		/// SupportByVersion Access 12 14 15
		/// </summary>
		[SupportByVersion("Access", 12,14,15)]
		public event Attachment_DblClickEventHandler DblClickEvent
		{
			add
			{
				CreateEventBridge();
				_DblClickEvent += value;
			}
			remove
			{
				_DblClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14,15
		/// </summary>
		private event Attachment_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByVersion Access 12 14 15
		/// </summary>
		[SupportByVersion("Access", 12,14,15)]
		public event Attachment_MouseDownEventHandler MouseDownEvent
		{
			add
			{
				CreateEventBridge();
				_MouseDownEvent += value;
			}
			remove
			{
				_MouseDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14,15
		/// </summary>
		private event Attachment_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByVersion Access 12 14 15
		/// </summary>
		[SupportByVersion("Access", 12,14,15)]
		public event Attachment_MouseMoveEventHandler MouseMoveEvent
		{
			add
			{
				CreateEventBridge();
				_MouseMoveEvent += value;
			}
			remove
			{
				_MouseMoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14,15
		/// </summary>
		private event Attachment_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByVersion Access 12 14 15
		/// </summary>
		[SupportByVersion("Access", 12,14,15)]
		public event Attachment_MouseUpEventHandler MouseUpEvent
		{
			add
			{
				CreateEventBridge();
				_MouseUpEvent += value;
			}
			remove
			{
				_MouseUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14,15
		/// </summary>
		private event Attachment_KeyDownEventHandler _KeyDownEvent;

		/// <summary>
		/// SupportByVersion Access 12 14 15
		/// </summary>
		[SupportByVersion("Access", 12,14,15)]
		public event Attachment_KeyDownEventHandler KeyDownEvent
		{
			add
			{
				CreateEventBridge();
				_KeyDownEvent += value;
			}
			remove
			{
				_KeyDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14,15
		/// </summary>
		private event Attachment_KeyPressEventHandler _KeyPressEvent;

		/// <summary>
		/// SupportByVersion Access 12 14 15
		/// </summary>
		[SupportByVersion("Access", 12,14,15)]
		public event Attachment_KeyPressEventHandler KeyPressEvent
		{
			add
			{
				CreateEventBridge();
				_KeyPressEvent += value;
			}
			remove
			{
				_KeyPressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14,15
		/// </summary>
		private event Attachment_KeyUpEventHandler _KeyUpEvent;

		/// <summary>
		/// SupportByVersion Access 12 14 15
		/// </summary>
		[SupportByVersion("Access", 12,14,15)]
		public event Attachment_KeyUpEventHandler KeyUpEvent
		{
			add
			{
				CreateEventBridge();
				_KeyUpEvent += value;
			}
			remove
			{
				_KeyUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Access, 12,14,15
		/// </summary>
		private event Attachment_AttachmentCurrentEventHandler _AttachmentCurrentEvent;

		/// <summary>
		/// SupportByVersion Access 12 14 15
		/// </summary>
		[SupportByVersion("Access", 12,14,15)]
		public event Attachment_AttachmentCurrentEventHandler AttachmentCurrentEvent
		{
			add
			{
				CreateEventBridge();
				_AttachmentCurrentEvent += value;
			}
			remove
			{
				_AttachmentCurrentEvent -= value;
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, DispAttachmentEvents_SinkHelper.Id);


			if(DispAttachmentEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_dispAttachmentEvents_SinkHelper = new DispAttachmentEvents_SinkHelper(this, _connectPoint);
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
			if( null != _dispAttachmentEvents_SinkHelper)
			{
				_dispAttachmentEvents_SinkHelper.Dispose();
				_dispAttachmentEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion

		#pragma warning restore
	}
}