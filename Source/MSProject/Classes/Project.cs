using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice;
namespace NetOffice.MSProjectApi
{

	#region Delegates

	#pragma warning disable
	public delegate void Project_OpenEventHandler(NetOffice.MSProjectApi.Project pj);
	public delegate void Project_BeforeCloseEventHandler(NetOffice.MSProjectApi.Project pj);
	public delegate void Project_BeforeSaveEventHandler(NetOffice.MSProjectApi.Project pj);
	public delegate void Project_BeforePrintEventHandler(NetOffice.MSProjectApi.Project pj);
	public delegate void Project_CalculateEventHandler(NetOffice.MSProjectApi.Project pj);
	public delegate void Project_ChangeEventHandler(NetOffice.MSProjectApi.Project pj);
	public delegate void Project_ActivateEventHandler(NetOffice.MSProjectApi.Project pj);
	public delegate void Project_DeactivateEventHandler(NetOffice.MSProjectApi.Project pj);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass Project 
	/// SupportByVersion MSProject, 11,12,14
	///</summary>
	[SupportByVersionAttribute("MSProject", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class Project : _IProjectDoc,IEventBinding
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		_EProjectDoc_SinkHelper __EProjectDoc_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Project);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public Project(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}

		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Project(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Project(COMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		/// <summary>
        /// creates a new instance of Project 
        /// </summary>		
		public Project():base("MSProject.Project")
		{
			
		}
		
		/// <summary>
        /// creates a new instance of Project
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public Project(string progId):base(progId)
		{
			
		}

		#endregion

		#region Static CoClass Methods

		/// <summary>
        /// returns all running MSProject.Project objects from the running object table(ROT)
        /// </summary>
        /// <returns>an MSProject.Project array</returns>
		public static NetOffice.MSProjectApi.Project[] GetActiveInstances()
		{		
			NetRuntimeSystem.Collections.Generic.List<object> proxyList = NetOffice.RunningObjectTable.GetActiveProxiesFromROT("MSProject","Project");
			NetRuntimeSystem.Collections.Generic.List<NetOffice.MSProjectApi.Project> resultList = new NetRuntimeSystem.Collections.Generic.List<NetOffice.MSProjectApi.Project>();
			foreach(object proxy in proxyList)
				resultList.Add( new NetOffice.MSProjectApi.Project(null, proxy) );
			return resultList.ToArray();
		}

		/// <summary>
        /// returns a running MSProject.Project object from the running object table(ROT). the method takes the first element from the table
        /// </summary>
        /// <returns>an MSProject.Project object or null</returns>
		public static NetOffice.MSProjectApi.Project GetActiveInstance()
		{
			object proxy = NetOffice.RunningObjectTable.GetActiveProxyFromROT("MSProject","Project", false);
			if(null != proxy)
				return new NetOffice.MSProjectApi.Project(null, proxy);
			else
				return null;
		}

		/// <summary>
        /// returns a running MSProject.Project object from the running object table(ROT).  the method takes the first element from the table
        /// </summary>
	    /// <param name="throwOnError">throw an exception if no object was found</param>
        /// <returns>an MSProject.Project object or null</returns>
		public static NetOffice.MSProjectApi.Project GetActiveInstance(bool throwOnError)
		{
			object proxy = NetOffice.RunningObjectTable.GetActiveProxyFromROT("MSProject","Project", throwOnError);
			if(null != proxy)
				return new NetOffice.MSProjectApi.Project(null, proxy);
			else
				return null;
		}
		#endregion

		#region Events

		/// <summary>
		/// SupportByVersion MSProject, 11,12,14
		/// </summary>
		private event Project_OpenEventHandler _OpenEvent;

		/// <summary>
		/// SupportByVersion MSProject 11 12 14
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public event Project_OpenEventHandler OpenEvent
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
		/// SupportByVersion MSProject, 11,12,14
		/// </summary>
		private event Project_BeforeCloseEventHandler _BeforeCloseEvent;

		/// <summary>
		/// SupportByVersion MSProject 11 12 14
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public event Project_BeforeCloseEventHandler BeforeCloseEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeCloseEvent += value;
			}
			remove
			{
				_BeforeCloseEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSProject, 11,12,14
		/// </summary>
		private event Project_BeforeSaveEventHandler _BeforeSaveEvent;

		/// <summary>
		/// SupportByVersion MSProject 11 12 14
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public event Project_BeforeSaveEventHandler BeforeSaveEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeSaveEvent += value;
			}
			remove
			{
				_BeforeSaveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSProject, 11,12,14
		/// </summary>
		private event Project_BeforePrintEventHandler _BeforePrintEvent;

		/// <summary>
		/// SupportByVersion MSProject 11 12 14
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public event Project_BeforePrintEventHandler BeforePrintEvent
		{
			add
			{
				CreateEventBridge();
				_BeforePrintEvent += value;
			}
			remove
			{
				_BeforePrintEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSProject, 11,12,14
		/// </summary>
		private event Project_CalculateEventHandler _CalculateEvent;

		/// <summary>
		/// SupportByVersion MSProject 11 12 14
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public event Project_CalculateEventHandler CalculateEvent
		{
			add
			{
				CreateEventBridge();
				_CalculateEvent += value;
			}
			remove
			{
				_CalculateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSProject, 11,12,14
		/// </summary>
		private event Project_ChangeEventHandler _ChangeEvent;

		/// <summary>
		/// SupportByVersion MSProject 11 12 14
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public event Project_ChangeEventHandler ChangeEvent
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
		/// SupportByVersion MSProject, 11,12,14
		/// </summary>
		private event Project_ActivateEventHandler _ActivateEvent;

		/// <summary>
		/// SupportByVersion MSProject 11 12 14
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public event Project_ActivateEventHandler ActivateEvent
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
		/// SupportByVersion MSProject, 11,12,14
		/// </summary>
		private event Project_DeactivateEventHandler _DeactivateEvent;

		/// <summary>
		/// SupportByVersion MSProject 11 12 14
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public event Project_DeactivateEventHandler DeactivateEvent
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, _EProjectDoc_SinkHelper.Id);


			if(_EProjectDoc_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				__EProjectDoc_SinkHelper = new _EProjectDoc_SinkHelper(this, _connectPoint);
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
			if( null != __EProjectDoc_SinkHelper)
			{
				__EProjectDoc_SinkHelper.Dispose();
				__EProjectDoc_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion

		#pragma warning restore
	}
}