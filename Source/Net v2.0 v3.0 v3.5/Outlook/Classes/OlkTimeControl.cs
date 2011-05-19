//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{

	#region Delegates

	#pragma warning disable
	public delegate void OlkTimeControl_ClickEventHandler();
	public delegate void OlkTimeControl_DoubleClickEventHandler();
	public delegate void OlkTimeControl_MouseDownEventHandler(NetOffice.OutlookApi.Enums.OlMouseButton Button, NetOffice.OutlookApi.Enums.OlShiftState Shift, Single X, Single Y);
	public delegate void OlkTimeControl_MouseMoveEventHandler(NetOffice.OutlookApi.Enums.OlMouseButton Button, NetOffice.OutlookApi.Enums.OlShiftState Shift, Single X, Single Y);
	public delegate void OlkTimeControl_MouseUpEventHandler(NetOffice.OutlookApi.Enums.OlMouseButton Button, NetOffice.OutlookApi.Enums.OlShiftState Shift, Single X, Single Y);
	public delegate void OlkTimeControl_EnterEventHandler();
	public delegate void OlkTimeControl_ExitEventHandler(ref bool Cancel);
	public delegate void OlkTimeControl_KeyDownEventHandler(ref Int32 KeyCode, NetOffice.OutlookApi.Enums.OlShiftState Shift);
	public delegate void OlkTimeControl_KeyPressEventHandler(ref Int32 KeyAscii);
	public delegate void OlkTimeControl_KeyUpEventHandler(ref Int32 KeyCode, NetOffice.OutlookApi.Enums.OlShiftState Shift);
	public delegate void OlkTimeControl_ChangeEventHandler();
	public delegate void OlkTimeControl_DropButtonClickEventHandler();
	public delegate void OlkTimeControl_AfterUpdateEventHandler();
	public delegate void OlkTimeControl_BeforeUpdateEventHandler(ref bool Cancel);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass OlkTimeControl SupportByLibrary "Outlook", 12,14
	///</summary>
	[SupportByLibrary("Outlook", 12,14)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class OlkTimeControl : _OlkTimeControl, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		OlkTimeControlEvents_SinkHelper _olkTimeControlEvents_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OlkTimeControl(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OlkTimeControl(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OlkTimeControl(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public OlkTimeControl()
		{
			CreateFromProgId("Outlook.OlkTimeControl");
		}
		
		/// <param name="progId">progId</param>
		public OlkTimeControl(string progId)
		{
			CreateFromProgId(progId);
		}

		#endregion
		
		#region Private Methods
		
		/// <summary>
        /// creates active sink helper
        /// </summary>
		private void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, OlkTimeControlEvents_SinkHelper.Id);


			if(OlkTimeControlEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_olkTimeControlEvents_SinkHelper = new OlkTimeControlEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary Outlook, 12 14
		/// </summary>
		private event OlkTimeControl_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event OlkTimeControl_ClickEventHandler ClickEvent
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
		/// SupportByLibrary Outlook, 12 14
		/// </summary>
		private event OlkTimeControl_DoubleClickEventHandler _DoubleClickEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event OlkTimeControl_DoubleClickEventHandler DoubleClickEvent
		{
			add
			{
				CreateEventBridge();
				_DoubleClickEvent += value;
			}
			remove
			{
				_DoubleClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 12 14
		/// </summary>
		private event OlkTimeControl_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event OlkTimeControl_MouseDownEventHandler MouseDownEvent
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
		/// SupportByLibrary Outlook, 12 14
		/// </summary>
		private event OlkTimeControl_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event OlkTimeControl_MouseMoveEventHandler MouseMoveEvent
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
		/// SupportByLibrary Outlook, 12 14
		/// </summary>
		private event OlkTimeControl_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event OlkTimeControl_MouseUpEventHandler MouseUpEvent
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
		/// SupportByLibrary Outlook, 12 14
		/// </summary>
		private event OlkTimeControl_EnterEventHandler _EnterEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event OlkTimeControl_EnterEventHandler EnterEvent
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
		/// SupportByLibrary Outlook, 12 14
		/// </summary>
		private event OlkTimeControl_ExitEventHandler _ExitEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event OlkTimeControl_ExitEventHandler ExitEvent
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
		/// SupportByLibrary Outlook, 12 14
		/// </summary>
		private event OlkTimeControl_KeyDownEventHandler _KeyDownEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event OlkTimeControl_KeyDownEventHandler KeyDownEvent
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
		/// SupportByLibrary Outlook, 12 14
		/// </summary>
		private event OlkTimeControl_KeyPressEventHandler _KeyPressEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event OlkTimeControl_KeyPressEventHandler KeyPressEvent
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
		/// SupportByLibrary Outlook, 12 14
		/// </summary>
		private event OlkTimeControl_KeyUpEventHandler _KeyUpEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event OlkTimeControl_KeyUpEventHandler KeyUpEvent
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
		/// SupportByLibrary Outlook, 12 14
		/// </summary>
		private event OlkTimeControl_ChangeEventHandler _ChangeEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event OlkTimeControl_ChangeEventHandler ChangeEvent
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
		/// SupportByLibrary Outlook, 12 14
		/// </summary>
		private event OlkTimeControl_DropButtonClickEventHandler _DropButtonClickEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event OlkTimeControl_DropButtonClickEventHandler DropButtonClickEvent
		{
			add
			{
				CreateEventBridge();
				_DropButtonClickEvent += value;
			}
			remove
			{
				_DropButtonClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 12 14
		/// </summary>
		private event OlkTimeControl_AfterUpdateEventHandler _AfterUpdateEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event OlkTimeControl_AfterUpdateEventHandler AfterUpdateEvent
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
		/// SupportByLibrary Outlook, 12 14
		/// </summary>
		private event OlkTimeControl_BeforeUpdateEventHandler _BeforeUpdateEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event OlkTimeControl_BeforeUpdateEventHandler BeforeUpdateEvent
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

		#endregion

        #region IEventBinding Member
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients       
        {
			get
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
        public void DisposeSinkHelper()
        {
			if( null != _olkTimeControlEvents_SinkHelper)
			{
				_olkTimeControlEvents_SinkHelper.Dispose();
				_olkTimeControlEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}