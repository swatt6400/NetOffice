//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{

	#region Delegates

	#pragma warning disable
	public delegate void Spreadsheet_BeforeContextMenuEventHandler(Int32 x, Int32 y, NetOffice.OWC10Api.ByRef Menu, NetOffice.OWC10Api.ByRef Cancel);
	public delegate void Spreadsheet_BeforeKeyDownEventHandler(Int32 KeyCode, Int32 Shift, NetOffice.OWC10Api.ByRef Cancel);
	public delegate void Spreadsheet_BeforeKeyPressEventHandler(Int32 KeyAscii, NetOffice.OWC10Api.ByRef Cancel);
	public delegate void Spreadsheet_BeforeKeyUpEventHandler(Int32 KeyCode, Int32 Shift, NetOffice.OWC10Api.ByRef Cancel);
	public delegate void Spreadsheet_ClickEventHandler();
	public delegate void Spreadsheet_CommandEnabledEventHandler(COMObject Command, NetOffice.OWC10Api.ByRef Enabled);
	public delegate void Spreadsheet_CommandCheckedEventHandler(COMObject Command, NetOffice.OWC10Api.ByRef Checked);
	public delegate void Spreadsheet_CommandTipTextEventHandler(COMObject Command, NetOffice.OWC10Api.ByRef Caption);
	public delegate void Spreadsheet_CommandBeforeExecuteEventHandler(COMObject Command, NetOffice.OWC10Api.ByRef Cancel);
	public delegate void Spreadsheet_CommandExecuteEventHandler(COMObject Command, bool Succeeded);
	public delegate void Spreadsheet_DblClickEventHandler();
	public delegate void Spreadsheet_EndEditEventHandler(bool Accept, NetOffice.OWC10Api.ByRef FinalValue, NetOffice.OWC10Api.ByRef Cancel, NetOffice.OWC10Api.ByRef ErrorDescription);
	public delegate void Spreadsheet_InitializeEventHandler();
	public delegate void Spreadsheet_KeyDownEventHandler(Int32 KeyCode, Int32 Shift);
	public delegate void Spreadsheet_KeyPressEventHandler(Int32 KeyAscii);
	public delegate void Spreadsheet_KeyUpEventHandler(Int32 KeyCode, Int32 Shift);
	public delegate void Spreadsheet_LoadCompletedEventHandler();
	public delegate void Spreadsheet_MouseDownEventHandler(Int32 Button, Int32 Shift, Int32 x, Int32 y);
	public delegate void Spreadsheet_MouseOutEventHandler(Int32 Button, Int32 Shift, NetOffice.OWC10Api._Range Target);
	public delegate void Spreadsheet_MouseOverEventHandler(Int32 Button, Int32 Shift, NetOffice.OWC10Api._Range Target);
	public delegate void Spreadsheet_MouseUpEventHandler(Int32 Button, Int32 Shift, Int32 x, Int32 y);
	public delegate void Spreadsheet_MouseWheelEventHandler(bool Page, Int32 Count);
	public delegate void Spreadsheet_SelectionChangeEventHandler();
	public delegate void Spreadsheet_SelectionChangingEventHandler(NetOffice.OWC10Api._Range Range);
	public delegate void Spreadsheet_SheetActivateEventHandler(NetOffice.OWC10Api.Worksheet Sh);
	public delegate void Spreadsheet_SheetCalculateEventHandler(NetOffice.OWC10Api.Worksheet Sh);
	public delegate void Spreadsheet_SheetChangeEventHandler(NetOffice.OWC10Api.Worksheet Sh, NetOffice.OWC10Api._Range Target);
	public delegate void Spreadsheet_SheetDeactivateEventHandler(NetOffice.OWC10Api.Worksheet Sh);
	public delegate void Spreadsheet_SheetFollowHyperlinkEventHandler(NetOffice.OWC10Api.Worksheet Sh, NetOffice.OWC10Api.Hyperlink Target);
	public delegate void Spreadsheet_StartEditEventHandler(COMObject Selection, NetOffice.OWC10Api.ByRef InitialValue, NetOffice.OWC10Api.ByRef Cancel, NetOffice.OWC10Api.ByRef ErrorDescription);
	public delegate void Spreadsheet_ViewChangeEventHandler(NetOffice.OWC10Api._Range Target);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass Spreadsheet SupportByLibrary XWC1.0 
	///</summary>
	[SupportByLibrary("XWC1.0")]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class Spreadsheet : ISpreadsheet, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		ISpreadsheetEventSink_SinkHelper _iSpreadsheetEventSink_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Spreadsheet(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Spreadsheet(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Spreadsheet(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public Spreadsheet()
		{
			CreateFromProgId("OWC10.Spreadsheet");
		}
		
		/// <param name="progId">progId</param>
		public Spreadsheet(string progId)
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, ISpreadsheetEventSink_SinkHelper.Id);


			if(ISpreadsheetEventSink_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_iSpreadsheetEventSink_SinkHelper = new ISpreadsheetEventSink_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_BeforeContextMenuEventHandler _BeforeContextMenuEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_BeforeContextMenuEventHandler BeforeContextMenuEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeContextMenuEvent += value;
			}
			remove
			{
				_BeforeContextMenuEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_BeforeKeyDownEventHandler _BeforeKeyDownEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_BeforeKeyDownEventHandler BeforeKeyDownEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeKeyDownEvent += value;
			}
			remove
			{
				_BeforeKeyDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_BeforeKeyPressEventHandler _BeforeKeyPressEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_BeforeKeyPressEventHandler BeforeKeyPressEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeKeyPressEvent += value;
			}
			remove
			{
				_BeforeKeyPressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_BeforeKeyUpEventHandler _BeforeKeyUpEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_BeforeKeyUpEventHandler BeforeKeyUpEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeKeyUpEvent += value;
			}
			remove
			{
				_BeforeKeyUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_ClickEventHandler ClickEvent
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
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_CommandEnabledEventHandler _CommandEnabledEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_CommandEnabledEventHandler CommandEnabledEvent
		{
			add
			{
				CreateEventBridge();
				_CommandEnabledEvent += value;
			}
			remove
			{
				_CommandEnabledEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_CommandCheckedEventHandler _CommandCheckedEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_CommandCheckedEventHandler CommandCheckedEvent
		{
			add
			{
				CreateEventBridge();
				_CommandCheckedEvent += value;
			}
			remove
			{
				_CommandCheckedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_CommandTipTextEventHandler _CommandTipTextEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_CommandTipTextEventHandler CommandTipTextEvent
		{
			add
			{
				CreateEventBridge();
				_CommandTipTextEvent += value;
			}
			remove
			{
				_CommandTipTextEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_CommandBeforeExecuteEventHandler _CommandBeforeExecuteEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_CommandBeforeExecuteEventHandler CommandBeforeExecuteEvent
		{
			add
			{
				CreateEventBridge();
				_CommandBeforeExecuteEvent += value;
			}
			remove
			{
				_CommandBeforeExecuteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_CommandExecuteEventHandler _CommandExecuteEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_CommandExecuteEventHandler CommandExecuteEvent
		{
			add
			{
				CreateEventBridge();
				_CommandExecuteEvent += value;
			}
			remove
			{
				_CommandExecuteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_DblClickEventHandler _DblClickEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_DblClickEventHandler DblClickEvent
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
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_EndEditEventHandler _EndEditEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_EndEditEventHandler EndEditEvent
		{
			add
			{
				CreateEventBridge();
				_EndEditEvent += value;
			}
			remove
			{
				_EndEditEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_InitializeEventHandler _InitializeEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_InitializeEventHandler InitializeEvent
		{
			add
			{
				CreateEventBridge();
				_InitializeEvent += value;
			}
			remove
			{
				_InitializeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_KeyDownEventHandler _KeyDownEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_KeyDownEventHandler KeyDownEvent
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
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_KeyPressEventHandler _KeyPressEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_KeyPressEventHandler KeyPressEvent
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
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_KeyUpEventHandler _KeyUpEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_KeyUpEventHandler KeyUpEvent
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
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_LoadCompletedEventHandler _LoadCompletedEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_LoadCompletedEventHandler LoadCompletedEvent
		{
			add
			{
				CreateEventBridge();
				_LoadCompletedEvent += value;
			}
			remove
			{
				_LoadCompletedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_MouseDownEventHandler MouseDownEvent
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
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_MouseOutEventHandler _MouseOutEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_MouseOutEventHandler MouseOutEvent
		{
			add
			{
				CreateEventBridge();
				_MouseOutEvent += value;
			}
			remove
			{
				_MouseOutEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_MouseOverEventHandler _MouseOverEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_MouseOverEventHandler MouseOverEvent
		{
			add
			{
				CreateEventBridge();
				_MouseOverEvent += value;
			}
			remove
			{
				_MouseOverEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_MouseUpEventHandler MouseUpEvent
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
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_MouseWheelEventHandler _MouseWheelEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_MouseWheelEventHandler MouseWheelEvent
		{
			add
			{
				CreateEventBridge();
				_MouseWheelEvent += value;
			}
			remove
			{
				_MouseWheelEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_SelectionChangeEventHandler _SelectionChangeEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_SelectionChangeEventHandler SelectionChangeEvent
		{
			add
			{
				CreateEventBridge();
				_SelectionChangeEvent += value;
			}
			remove
			{
				_SelectionChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_SelectionChangingEventHandler _SelectionChangingEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_SelectionChangingEventHandler SelectionChangingEvent
		{
			add
			{
				CreateEventBridge();
				_SelectionChangingEvent += value;
			}
			remove
			{
				_SelectionChangingEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_SheetActivateEventHandler _SheetActivateEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_SheetActivateEventHandler SheetActivateEvent
		{
			add
			{
				CreateEventBridge();
				_SheetActivateEvent += value;
			}
			remove
			{
				_SheetActivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_SheetCalculateEventHandler _SheetCalculateEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_SheetCalculateEventHandler SheetCalculateEvent
		{
			add
			{
				CreateEventBridge();
				_SheetCalculateEvent += value;
			}
			remove
			{
				_SheetCalculateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_SheetChangeEventHandler _SheetChangeEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_SheetChangeEventHandler SheetChangeEvent
		{
			add
			{
				CreateEventBridge();
				_SheetChangeEvent += value;
			}
			remove
			{
				_SheetChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_SheetDeactivateEventHandler _SheetDeactivateEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_SheetDeactivateEventHandler SheetDeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_SheetDeactivateEvent += value;
			}
			remove
			{
				_SheetDeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_SheetFollowHyperlinkEventHandler _SheetFollowHyperlinkEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_SheetFollowHyperlinkEventHandler SheetFollowHyperlinkEvent
		{
			add
			{
				CreateEventBridge();
				_SheetFollowHyperlinkEvent += value;
			}
			remove
			{
				_SheetFollowHyperlinkEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_StartEditEventHandler _StartEditEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_StartEditEventHandler StartEditEvent
		{
			add
			{
				CreateEventBridge();
				_StartEditEvent += value;
			}
			remove
			{
				_StartEditEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event Spreadsheet_ViewChangeEventHandler _ViewChangeEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event Spreadsheet_ViewChangeEventHandler ViewChangeEvent
		{
			add
			{
				CreateEventBridge();
				_ViewChangeEvent += value;
			}
			remove
			{
				_ViewChangeEvent -= value;
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
			if( null != _iSpreadsheetEventSink_SinkHelper)
			{
				_iSpreadsheetEventSink_SinkHelper.Dispose();
				_iSpreadsheetEventSink_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}