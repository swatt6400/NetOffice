//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{

	#region Delegates

	#pragma warning disable
	public delegate void Explorer_ActivateEventHandler();
	public delegate void Explorer_FolderSwitchEventHandler();
	public delegate void Explorer_BeforeFolderSwitchEventHandler(COMObject NewFolder, ref bool Cancel);
	public delegate void Explorer_ViewSwitchEventHandler();
	public delegate void Explorer_BeforeViewSwitchEventHandler(COMObject NewView, ref bool Cancel);
	public delegate void Explorer_DeactivateEventHandler();
	public delegate void Explorer_SelectionChangeEventHandler();
	public delegate void Explorer_CloseEventHandler();
	public delegate void Explorer_BeforeMaximizeEventHandler(ref bool Cancel);
	public delegate void Explorer_BeforeMinimizeEventHandler(ref bool Cancel);
	public delegate void Explorer_BeforeMoveEventHandler(ref bool Cancel);
	public delegate void Explorer_BeforeSizeEventHandler(ref bool Cancel);
	public delegate void Explorer_BeforeItemCopyEventHandler(ref bool Cancel);
	public delegate void Explorer_BeforeItemCutEventHandler(ref bool Cancel);
	public delegate void Explorer_BeforeItemPasteEventHandler(ref COMObject ClipboardContent, NetOffice.OutlookApi.MAPIFolder Target, ref bool Cancel);
	public delegate void Explorer_AttachmentSelectionChangeEventHandler();
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass Explorer SupportByLibrary "Outlook", 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Outlook", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class Explorer : _Explorer, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		ExplorerEvents_SinkHelper _explorerEvents_SinkHelper;
		ExplorerEvents_10_SinkHelper _explorerEvents_10_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Explorer(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Explorer(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Explorer(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public Explorer()
		{
			CreateFromProgId("Outlook.Explorer");
		}
		
		/// <param name="progId">progId</param>
		public Explorer(string progId)
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, ExplorerEvents_SinkHelper.Id,ExplorerEvents_10_SinkHelper.Id);


			if(ExplorerEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_explorerEvents_SinkHelper = new ExplorerEvents_SinkHelper(this, _connectPoint);
				return;
			}

			if(ExplorerEvents_10_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_explorerEvents_10_SinkHelper = new ExplorerEvents_10_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary Outlook, 9 10 11 12 14
		/// </summary>
		private event Explorer_ActivateEventHandler _ActivateEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event Explorer_ActivateEventHandler ActivateEvent
		{
			add
			{
				CreateEventBridge();
				_ActivateEvent += value;
			}
			remove
			{
				_ActivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9 10 11 12 14
		/// </summary>
		private event Explorer_FolderSwitchEventHandler _FolderSwitchEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event Explorer_FolderSwitchEventHandler FolderSwitchEvent
		{
			add
			{
				CreateEventBridge();
				_FolderSwitchEvent += value;
			}
			remove
			{
				_FolderSwitchEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9 10 11 12 14
		/// </summary>
		private event Explorer_BeforeFolderSwitchEventHandler _BeforeFolderSwitchEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event Explorer_BeforeFolderSwitchEventHandler BeforeFolderSwitchEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeFolderSwitchEvent += value;
			}
			remove
			{
				_BeforeFolderSwitchEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9 10 11 12 14
		/// </summary>
		private event Explorer_ViewSwitchEventHandler _ViewSwitchEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event Explorer_ViewSwitchEventHandler ViewSwitchEvent
		{
			add
			{
				CreateEventBridge();
				_ViewSwitchEvent += value;
			}
			remove
			{
				_ViewSwitchEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9 10 11 12 14
		/// </summary>
		private event Explorer_BeforeViewSwitchEventHandler _BeforeViewSwitchEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event Explorer_BeforeViewSwitchEventHandler BeforeViewSwitchEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeViewSwitchEvent += value;
			}
			remove
			{
				_BeforeViewSwitchEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9 10 11 12 14
		/// </summary>
		private event Explorer_DeactivateEventHandler _DeactivateEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event Explorer_DeactivateEventHandler DeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_DeactivateEvent += value;
			}
			remove
			{
				_DeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9 10 11 12 14
		/// </summary>
		private event Explorer_SelectionChangeEventHandler _SelectionChangeEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event Explorer_SelectionChangeEventHandler SelectionChangeEvent
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
		/// SupportByLibrary Outlook, 9 10 11 12 14
		/// </summary>
		private event Explorer_CloseEventHandler _CloseEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event Explorer_CloseEventHandler CloseEvent
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
		/// SupportByLibrary Outlook, 10 11 12 14
		/// </summary>
		private event Explorer_BeforeMaximizeEventHandler _BeforeMaximizeEvent;

		/// <summary>
		/// SupportByLibrary Outlook 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public event Explorer_BeforeMaximizeEventHandler BeforeMaximizeEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeMaximizeEvent += value;
			}
			remove
			{
				_BeforeMaximizeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 10 11 12 14
		/// </summary>
		private event Explorer_BeforeMinimizeEventHandler _BeforeMinimizeEvent;

		/// <summary>
		/// SupportByLibrary Outlook 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public event Explorer_BeforeMinimizeEventHandler BeforeMinimizeEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeMinimizeEvent += value;
			}
			remove
			{
				_BeforeMinimizeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 10 11 12 14
		/// </summary>
		private event Explorer_BeforeMoveEventHandler _BeforeMoveEvent;

		/// <summary>
		/// SupportByLibrary Outlook 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public event Explorer_BeforeMoveEventHandler BeforeMoveEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeMoveEvent += value;
			}
			remove
			{
				_BeforeMoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 10 11 12 14
		/// </summary>
		private event Explorer_BeforeSizeEventHandler _BeforeSizeEvent;

		/// <summary>
		/// SupportByLibrary Outlook 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public event Explorer_BeforeSizeEventHandler BeforeSizeEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeSizeEvent += value;
			}
			remove
			{
				_BeforeSizeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 10 11 12 14
		/// </summary>
		private event Explorer_BeforeItemCopyEventHandler _BeforeItemCopyEvent;

		/// <summary>
		/// SupportByLibrary Outlook 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public event Explorer_BeforeItemCopyEventHandler BeforeItemCopyEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeItemCopyEvent += value;
			}
			remove
			{
				_BeforeItemCopyEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 10 11 12 14
		/// </summary>
		private event Explorer_BeforeItemCutEventHandler _BeforeItemCutEvent;

		/// <summary>
		/// SupportByLibrary Outlook 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public event Explorer_BeforeItemCutEventHandler BeforeItemCutEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeItemCutEvent += value;
			}
			remove
			{
				_BeforeItemCutEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 10 11 12 14
		/// </summary>
		private event Explorer_BeforeItemPasteEventHandler _BeforeItemPasteEvent;

		/// <summary>
		/// SupportByLibrary Outlook 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public event Explorer_BeforeItemPasteEventHandler BeforeItemPasteEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeItemPasteEvent += value;
			}
			remove
			{
				_BeforeItemPasteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 14
		/// </summary>
		private event Explorer_AttachmentSelectionChangeEventHandler _AttachmentSelectionChangeEvent;

		/// <summary>
		/// SupportByLibrary Outlook 14
		/// </summary>
		[SupportByLibrary("Outlook", 14)]
		public event Explorer_AttachmentSelectionChangeEventHandler AttachmentSelectionChangeEvent
		{
			add
			{
				CreateEventBridge();
				_AttachmentSelectionChangeEvent += value;
			}
			remove
			{
				_AttachmentSelectionChangeEvent -= value;
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
			if( null != _explorerEvents_SinkHelper)
			{
				_explorerEvents_SinkHelper.Dispose();
				_explorerEvents_SinkHelper = null;
			}
			if( null != _explorerEvents_10_SinkHelper)
			{
				_explorerEvents_10_SinkHelper.Dispose();
				_explorerEvents_10_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}