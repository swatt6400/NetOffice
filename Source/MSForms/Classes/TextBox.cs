using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice;
namespace NetOffice.MSFormsApi
{

	#region Delegates

	#pragma warning disable
	public delegate void TextBox_BeforeDragOverEventHandler(NetOffice.MSFormsApi.ReturnBoolean Cancel, NetOffice.MSFormsApi.DataObject Data, Single X, Single Y, NetOffice.MSFormsApi.Enums.fmDragState DragState, NetOffice.MSFormsApi.ReturnEffect Effect, Int16 Shift);
	public delegate void TextBox_BeforeDropOrPasteEventHandler(NetOffice.MSFormsApi.ReturnBoolean Cancel, NetOffice.MSFormsApi.Enums.fmAction Action, NetOffice.MSFormsApi.DataObject Data, Single X, Single Y, NetOffice.MSFormsApi.ReturnEffect Effect, Int16 Shift);
	public delegate void TextBox_ChangeEventHandler();
	public delegate void TextBox_DblClickEventHandler(NetOffice.MSFormsApi.ReturnBoolean Cancel);
	public delegate void TextBox_DropButtonClickEventHandler();
	public delegate void TextBox_ErrorEventHandler(Int16 Number, NetOffice.MSFormsApi.ReturnString Description, Int32 SCode, string Source, string HelpFile, Int32 HelpContext, NetOffice.MSFormsApi.ReturnBoolean CancelDisplay);
	public delegate void TextBox_KeyDownEventHandler(NetOffice.MSFormsApi.ReturnInteger KeyCode, Int16 Shift);
	public delegate void TextBox_KeyPressEventHandler(NetOffice.MSFormsApi.ReturnInteger KeyAscii);
	public delegate void TextBox_KeyUpEventHandler(NetOffice.MSFormsApi.ReturnInteger KeyCode, Int16 Shift);
	public delegate void TextBox_MouseDownEventHandler(Int16 Button, Int16 Shift, Single X, Single Y);
	public delegate void TextBox_MouseMoveEventHandler(Int16 Button, Int16 Shift, Single X, Single Y);
	public delegate void TextBox_MouseUpEventHandler(Int16 Button, Int16 Shift, Single X, Single Y);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass TextBox 
	/// SupportByVersion MSForms, 2
	///</summary>
	[SupportByVersionAttribute("MSForms", 2)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class TextBox : IMdcText,IEventBinding
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		MdcTextEvents_SinkHelper _mdcTextEvents_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(TextBox);
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public TextBox(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public TextBox(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextBox(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{
			
		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextBox(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextBox(COMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		///<summary>
        ///creates a new instance of TextBox 
        ///</summary>		
		public TextBox():base("MSForms.TextBox")
		{
			
		}
		
		///<summary>
        ///creates a new instance of TextBox
        ///</summary>
        ///<param name="progId">registered ProgID</param>
		public TextBox(string progId):base(progId)
		{
			
		}

		#endregion

		#region Static CoClass Methods

		/// <summary>
        /// returns all running MSForms.TextBox objects from the running object table(ROT)
        /// </summary>
        /// <returns>an MSForms.TextBox array</returns>
		public static NetOffice.MSFormsApi.TextBox[] GetActiveInstances()
		{		
			NetRuntimeSystem.Collections.Generic.List<object> proxyList = NetOffice.RunningObjectTable.GetActiveProxiesFromROT("MSForms","TextBox");
			NetRuntimeSystem.Collections.Generic.List<NetOffice.MSFormsApi.TextBox> resultList = new NetRuntimeSystem.Collections.Generic.List<NetOffice.MSFormsApi.TextBox>();
			foreach(object proxy in proxyList)
				resultList.Add( new NetOffice.MSFormsApi.TextBox(null, proxy) );
			return resultList.ToArray();
		}

		/// <summary>
        /// returns a running MSForms.TextBox object from the running object table(ROT). the method takes the first element from the table
        /// </summary>
        /// <returns>an MSForms.TextBox object or null</returns>
		public static NetOffice.MSFormsApi.TextBox GetActiveInstance()
		{
			object proxy = NetOffice.RunningObjectTable.GetActiveProxyFromROT("MSForms","TextBox", false);
			if(null != proxy)
				return new NetOffice.MSFormsApi.TextBox(null, proxy);
			else
				return null;
		}

		/// <summary>
        /// returns a running MSForms.TextBox object from the running object table(ROT).  the method takes the first element from the table
        /// </summary>
	    /// <param name="throwOnError">throw an exception if no object was found</param>
        /// <returns>an MSForms.TextBox object or null</returns>
		public static NetOffice.MSFormsApi.TextBox GetActiveInstance(bool throwOnError)
		{
			object proxy = NetOffice.RunningObjectTable.GetActiveProxyFromROT("MSForms","TextBox", throwOnError);
			if(null != proxy)
				return new NetOffice.MSFormsApi.TextBox(null, proxy);
			else
				return null;
		}
		#endregion

		#region Events

		/// <summary>
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event TextBox_BeforeDragOverEventHandler _BeforeDragOverEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event TextBox_BeforeDragOverEventHandler BeforeDragOverEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeDragOverEvent += value;
			}
			remove
			{
				_BeforeDragOverEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event TextBox_BeforeDropOrPasteEventHandler _BeforeDropOrPasteEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event TextBox_BeforeDropOrPasteEventHandler BeforeDropOrPasteEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeDropOrPasteEvent += value;
			}
			remove
			{
				_BeforeDropOrPasteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event TextBox_ChangeEventHandler _ChangeEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event TextBox_ChangeEventHandler ChangeEvent
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
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event TextBox_DblClickEventHandler _DblClickEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event TextBox_DblClickEventHandler DblClickEvent
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
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event TextBox_DropButtonClickEventHandler _DropButtonClickEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event TextBox_DropButtonClickEventHandler DropButtonClickEvent
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
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event TextBox_ErrorEventHandler _ErrorEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event TextBox_ErrorEventHandler ErrorEvent
		{
			add
			{
				CreateEventBridge();
				_ErrorEvent += value;
			}
			remove
			{
				_ErrorEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event TextBox_KeyDownEventHandler _KeyDownEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event TextBox_KeyDownEventHandler KeyDownEvent
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
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event TextBox_KeyPressEventHandler _KeyPressEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event TextBox_KeyPressEventHandler KeyPressEvent
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
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event TextBox_KeyUpEventHandler _KeyUpEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event TextBox_KeyUpEventHandler KeyUpEvent
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
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event TextBox_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event TextBox_MouseDownEventHandler MouseDownEvent
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
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event TextBox_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event TextBox_MouseMoveEventHandler MouseMoveEvent
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
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event TextBox_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event TextBox_MouseUpEventHandler MouseUpEvent
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, MdcTextEvents_SinkHelper.Id);


			if(MdcTextEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_mdcTextEvents_SinkHelper = new MdcTextEvents_SinkHelper(this, _connectPoint);
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
			if( null != _mdcTextEvents_SinkHelper)
			{
				_mdcTextEvents_SinkHelper.Dispose();
				_mdcTextEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion

		#pragma warning restore
	}
}