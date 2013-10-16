using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice;
namespace NetOffice.VisioApi
{

	#region Delegates

	#pragma warning disable
	public delegate void Pages_PageAddedEventHandler(NetOffice.VisioApi.IVPage Page);
	public delegate void Pages_PageChangedEventHandler(NetOffice.VisioApi.IVPage Page);
	public delegate void Pages_BeforePageDeleteEventHandler(NetOffice.VisioApi.IVPage Page);
	public delegate void Pages_ShapeAddedEventHandler(NetOffice.VisioApi.IVShape Shape);
	public delegate void Pages_BeforeSelectionDeleteEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Pages_ShapeChangedEventHandler(NetOffice.VisioApi.IVShape Shape);
	public delegate void Pages_SelectionAddedEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Pages_BeforeShapeDeleteEventHandler(NetOffice.VisioApi.IVShape Shape);
	public delegate void Pages_TextChangedEventHandler(NetOffice.VisioApi.IVShape Shape);
	public delegate void Pages_CellChangedEventHandler(NetOffice.VisioApi.IVCell Cell);
	public delegate void Pages_FormulaChangedEventHandler(NetOffice.VisioApi.IVCell Cell);
	public delegate void Pages_ConnectionsAddedEventHandler(NetOffice.VisioApi.IVConnects Connects);
	public delegate void Pages_ConnectionsDeletedEventHandler(NetOffice.VisioApi.IVConnects Connects);
	public delegate void Pages_QueryCancelPageDeleteEventHandler(NetOffice.VisioApi.IVPage Page);
	public delegate void Pages_PageDeleteCanceledEventHandler(NetOffice.VisioApi.IVPage Page);
	public delegate void Pages_ShapeParentChangedEventHandler(NetOffice.VisioApi.IVShape Shape);
	public delegate void Pages_BeforeShapeTextEditEventHandler(NetOffice.VisioApi.IVShape Shape);
	public delegate void Pages_ShapeExitedTextEditEventHandler(NetOffice.VisioApi.IVShape Shape);
	public delegate void Pages_QueryCancelSelectionDeleteEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Pages_SelectionDeleteCanceledEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Pages_QueryCancelUngroupEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Pages_UngroupCanceledEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Pages_QueryCancelConvertToGroupEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Pages_ConvertToGroupCanceledEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Pages_QueryCancelGroupEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Pages_GroupCanceledEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Pages_ShapeDataGraphicChangedEventHandler(NetOffice.VisioApi.IVShape Shape);
	public delegate void Pages_ShapeLinkAddedEventHandler(NetOffice.VisioApi.IVShape Shape, Int32 DataRecordsetID, Int32 DataRowID);
	public delegate void Pages_ShapeLinkDeletedEventHandler(NetOffice.VisioApi.IVShape Shape, Int32 DataRecordsetID, Int32 DataRowID);
	public delegate void Pages_ContainerRelationshipAddedEventHandler(NetOffice.VisioApi.IVRelatedShapePairEvent ShapePair);
	public delegate void Pages_ContainerRelationshipDeletedEventHandler(NetOffice.VisioApi.IVRelatedShapePairEvent ShapePair);
	public delegate void Pages_CalloutRelationshipAddedEventHandler(NetOffice.VisioApi.IVRelatedShapePairEvent ShapePair);
	public delegate void Pages_CalloutRelationshipDeletedEventHandler(NetOffice.VisioApi.IVRelatedShapePairEvent ShapePair);
	public delegate void Pages_QueryCancelReplaceShapesEventHandler(NetOffice.VisioApi.IVReplaceShapesEvent replaceShapes);
	public delegate void Pages_ReplaceShapesCanceledEventHandler(NetOffice.VisioApi.IVReplaceShapesEvent replaceShapes);
	public delegate void Pages_BeforeReplaceShapesEventHandler(NetOffice.VisioApi.IVReplaceShapesEvent replaceShapes);
	public delegate void Pages_AfterReplaceShapesEventHandler(NetOffice.VisioApi.IVSelection sel);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass Pages 
	/// SupportByVersion Visio, 11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Visio", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class Pages : IVPages,IEventBinding
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		EPages_SinkHelper _ePages_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Pages);
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public Pages(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}

		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Pages(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Pages(COMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		/// <summary>
        /// creates a new instance of Pages 
        /// </summary>		
		public Pages():base("Visio.Pages")
		{
			
		}
		
		/// <summary>
        /// creates a new instance of Pages
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public Pages(string progId):base(progId)
		{
			
		}

		#endregion

		#region Static CoClass Methods

		/// <summary>
        /// returns all running Visio.Pages objects from the running object table(ROT)
        /// </summary>
        /// <returns>an Visio.Pages array</returns>
		public static NetOffice.VisioApi.Pages[] GetActiveInstances()
		{		
			NetRuntimeSystem.Collections.Generic.List<object> proxyList = NetOffice.RunningObjectTable.GetActiveProxiesFromROT("Visio","Pages");
			NetRuntimeSystem.Collections.Generic.List<NetOffice.VisioApi.Pages> resultList = new NetRuntimeSystem.Collections.Generic.List<NetOffice.VisioApi.Pages>();
			foreach(object proxy in proxyList)
				resultList.Add( new NetOffice.VisioApi.Pages(null, proxy) );
			return resultList.ToArray();
		}

		/// <summary>
        /// returns a running Visio.Pages object from the running object table(ROT). the method takes the first element from the table
        /// </summary>
        /// <returns>an Visio.Pages object or null</returns>
		public static NetOffice.VisioApi.Pages GetActiveInstance()
		{
			object proxy = NetOffice.RunningObjectTable.GetActiveProxyFromROT("Visio","Pages", false);
			if(null != proxy)
				return new NetOffice.VisioApi.Pages(null, proxy);
			else
				return null;
		}

		/// <summary>
        /// returns a running Visio.Pages object from the running object table(ROT).  the method takes the first element from the table
        /// </summary>
	    /// <param name="throwOnError">throw an exception if no object was found</param>
        /// <returns>an Visio.Pages object or null</returns>
		public static NetOffice.VisioApi.Pages GetActiveInstance(bool throwOnError)
		{
			object proxy = NetOffice.RunningObjectTable.GetActiveProxyFromROT("Visio","Pages", throwOnError);
			if(null != proxy)
				return new NetOffice.VisioApi.Pages(null, proxy);
			else
				return null;
		}
		#endregion

		#region Events

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Pages_PageAddedEventHandler _PageAddedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Pages_PageAddedEventHandler PageAddedEvent
		{
			add
			{
				CreateEventBridge();
				_PageAddedEvent += value;
			}
			remove
			{
				_PageAddedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Pages_PageChangedEventHandler _PageChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Pages_PageChangedEventHandler PageChangedEvent
		{
			add
			{
				CreateEventBridge();
				_PageChangedEvent += value;
			}
			remove
			{
				_PageChangedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Pages_BeforePageDeleteEventHandler _BeforePageDeleteEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Pages_BeforePageDeleteEventHandler BeforePageDeleteEvent
		{
			add
			{
				CreateEventBridge();
				_BeforePageDeleteEvent += value;
			}
			remove
			{
				_BeforePageDeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Pages_ShapeAddedEventHandler _ShapeAddedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Pages_ShapeAddedEventHandler ShapeAddedEvent
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
		private event Pages_BeforeSelectionDeleteEventHandler _BeforeSelectionDeleteEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Pages_BeforeSelectionDeleteEventHandler BeforeSelectionDeleteEvent
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
		private event Pages_ShapeChangedEventHandler _ShapeChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Pages_ShapeChangedEventHandler ShapeChangedEvent
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
		private event Pages_SelectionAddedEventHandler _SelectionAddedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Pages_SelectionAddedEventHandler SelectionAddedEvent
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
		private event Pages_BeforeShapeDeleteEventHandler _BeforeShapeDeleteEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Pages_BeforeShapeDeleteEventHandler BeforeShapeDeleteEvent
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
		private event Pages_TextChangedEventHandler _TextChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Pages_TextChangedEventHandler TextChangedEvent
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
		private event Pages_CellChangedEventHandler _CellChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Pages_CellChangedEventHandler CellChangedEvent
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
		private event Pages_FormulaChangedEventHandler _FormulaChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Pages_FormulaChangedEventHandler FormulaChangedEvent
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
		private event Pages_ConnectionsAddedEventHandler _ConnectionsAddedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Pages_ConnectionsAddedEventHandler ConnectionsAddedEvent
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
		private event Pages_ConnectionsDeletedEventHandler _ConnectionsDeletedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Pages_ConnectionsDeletedEventHandler ConnectionsDeletedEvent
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
		private event Pages_QueryCancelPageDeleteEventHandler _QueryCancelPageDeleteEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Pages_QueryCancelPageDeleteEventHandler QueryCancelPageDeleteEvent
		{
			add
			{
				CreateEventBridge();
				_QueryCancelPageDeleteEvent += value;
			}
			remove
			{
				_QueryCancelPageDeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Pages_PageDeleteCanceledEventHandler _PageDeleteCanceledEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Pages_PageDeleteCanceledEventHandler PageDeleteCanceledEvent
		{
			add
			{
				CreateEventBridge();
				_PageDeleteCanceledEvent += value;
			}
			remove
			{
				_PageDeleteCanceledEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Pages_ShapeParentChangedEventHandler _ShapeParentChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Pages_ShapeParentChangedEventHandler ShapeParentChangedEvent
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
		private event Pages_BeforeShapeTextEditEventHandler _BeforeShapeTextEditEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Pages_BeforeShapeTextEditEventHandler BeforeShapeTextEditEvent
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
		private event Pages_ShapeExitedTextEditEventHandler _ShapeExitedTextEditEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Pages_ShapeExitedTextEditEventHandler ShapeExitedTextEditEvent
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
		private event Pages_QueryCancelSelectionDeleteEventHandler _QueryCancelSelectionDeleteEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Pages_QueryCancelSelectionDeleteEventHandler QueryCancelSelectionDeleteEvent
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
		private event Pages_SelectionDeleteCanceledEventHandler _SelectionDeleteCanceledEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Pages_SelectionDeleteCanceledEventHandler SelectionDeleteCanceledEvent
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
		private event Pages_QueryCancelUngroupEventHandler _QueryCancelUngroupEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Pages_QueryCancelUngroupEventHandler QueryCancelUngroupEvent
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
		private event Pages_UngroupCanceledEventHandler _UngroupCanceledEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Pages_UngroupCanceledEventHandler UngroupCanceledEvent
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
		private event Pages_QueryCancelConvertToGroupEventHandler _QueryCancelConvertToGroupEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Pages_QueryCancelConvertToGroupEventHandler QueryCancelConvertToGroupEvent
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
		private event Pages_ConvertToGroupCanceledEventHandler _ConvertToGroupCanceledEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Pages_ConvertToGroupCanceledEventHandler ConvertToGroupCanceledEvent
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
		private event Pages_QueryCancelGroupEventHandler _QueryCancelGroupEvent;

		/// <summary>
		/// SupportByVersion Visio 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 12,14,15)]
		public event Pages_QueryCancelGroupEventHandler QueryCancelGroupEvent
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
		private event Pages_GroupCanceledEventHandler _GroupCanceledEvent;

		/// <summary>
		/// SupportByVersion Visio 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 12,14,15)]
		public event Pages_GroupCanceledEventHandler GroupCanceledEvent
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
		private event Pages_ShapeDataGraphicChangedEventHandler _ShapeDataGraphicChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 12,14,15)]
		public event Pages_ShapeDataGraphicChangedEventHandler ShapeDataGraphicChangedEvent
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

		/// <summary>
		/// SupportByVersion Visio, 12,14,15
		/// </summary>
		private event Pages_ShapeLinkAddedEventHandler _ShapeLinkAddedEvent;

		/// <summary>
		/// SupportByVersion Visio 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 12,14,15)]
		public event Pages_ShapeLinkAddedEventHandler ShapeLinkAddedEvent
		{
			add
			{
				CreateEventBridge();
				_ShapeLinkAddedEvent += value;
			}
			remove
			{
				_ShapeLinkAddedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 12,14,15
		/// </summary>
		private event Pages_ShapeLinkDeletedEventHandler _ShapeLinkDeletedEvent;

		/// <summary>
		/// SupportByVersion Visio 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 12,14,15)]
		public event Pages_ShapeLinkDeletedEventHandler ShapeLinkDeletedEvent
		{
			add
			{
				CreateEventBridge();
				_ShapeLinkDeletedEvent += value;
			}
			remove
			{
				_ShapeLinkDeletedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 14,15
		/// </summary>
		private event Pages_ContainerRelationshipAddedEventHandler _ContainerRelationshipAddedEvent;

		/// <summary>
		/// SupportByVersion Visio 14 15
		/// </summary>
		[SupportByVersion("Visio", 14,15)]
		public event Pages_ContainerRelationshipAddedEventHandler ContainerRelationshipAddedEvent
		{
			add
			{
				CreateEventBridge();
				_ContainerRelationshipAddedEvent += value;
			}
			remove
			{
				_ContainerRelationshipAddedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 14,15
		/// </summary>
		private event Pages_ContainerRelationshipDeletedEventHandler _ContainerRelationshipDeletedEvent;

		/// <summary>
		/// SupportByVersion Visio 14 15
		/// </summary>
		[SupportByVersion("Visio", 14,15)]
		public event Pages_ContainerRelationshipDeletedEventHandler ContainerRelationshipDeletedEvent
		{
			add
			{
				CreateEventBridge();
				_ContainerRelationshipDeletedEvent += value;
			}
			remove
			{
				_ContainerRelationshipDeletedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 14,15
		/// </summary>
		private event Pages_CalloutRelationshipAddedEventHandler _CalloutRelationshipAddedEvent;

		/// <summary>
		/// SupportByVersion Visio 14 15
		/// </summary>
		[SupportByVersion("Visio", 14,15)]
		public event Pages_CalloutRelationshipAddedEventHandler CalloutRelationshipAddedEvent
		{
			add
			{
				CreateEventBridge();
				_CalloutRelationshipAddedEvent += value;
			}
			remove
			{
				_CalloutRelationshipAddedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 14,15
		/// </summary>
		private event Pages_CalloutRelationshipDeletedEventHandler _CalloutRelationshipDeletedEvent;

		/// <summary>
		/// SupportByVersion Visio 14 15
		/// </summary>
		[SupportByVersion("Visio", 14,15)]
		public event Pages_CalloutRelationshipDeletedEventHandler CalloutRelationshipDeletedEvent
		{
			add
			{
				CreateEventBridge();
				_CalloutRelationshipDeletedEvent += value;
			}
			remove
			{
				_CalloutRelationshipDeletedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 15
		/// </summary>
		private event Pages_QueryCancelReplaceShapesEventHandler _QueryCancelReplaceShapesEvent;

		/// <summary>
		/// SupportByVersion Visio 15
		/// </summary>
		[SupportByVersion("Visio", 15)]
		public event Pages_QueryCancelReplaceShapesEventHandler QueryCancelReplaceShapesEvent
		{
			add
			{
				CreateEventBridge();
				_QueryCancelReplaceShapesEvent += value;
			}
			remove
			{
				_QueryCancelReplaceShapesEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 15
		/// </summary>
		private event Pages_ReplaceShapesCanceledEventHandler _ReplaceShapesCanceledEvent;

		/// <summary>
		/// SupportByVersion Visio 15
		/// </summary>
		[SupportByVersion("Visio", 15)]
		public event Pages_ReplaceShapesCanceledEventHandler ReplaceShapesCanceledEvent
		{
			add
			{
				CreateEventBridge();
				_ReplaceShapesCanceledEvent += value;
			}
			remove
			{
				_ReplaceShapesCanceledEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 15
		/// </summary>
		private event Pages_BeforeReplaceShapesEventHandler _BeforeReplaceShapesEvent;

		/// <summary>
		/// SupportByVersion Visio 15
		/// </summary>
		[SupportByVersion("Visio", 15)]
		public event Pages_BeforeReplaceShapesEventHandler BeforeReplaceShapesEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeReplaceShapesEvent += value;
			}
			remove
			{
				_BeforeReplaceShapesEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 15
		/// </summary>
		private event Pages_AfterReplaceShapesEventHandler _AfterReplaceShapesEvent;

		/// <summary>
		/// SupportByVersion Visio 15
		/// </summary>
		[SupportByVersion("Visio", 15)]
		public event Pages_AfterReplaceShapesEventHandler AfterReplaceShapesEvent
		{
			add
			{
				CreateEventBridge();
				_AfterReplaceShapesEvent += value;
			}
			remove
			{
				_AfterReplaceShapesEvent -= value;
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
			if(false == NetOffice.Settings.Default.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, EPages_SinkHelper.Id);


			if(EPages_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_ePages_SinkHelper = new EPages_SinkHelper(this, _connectPoint);
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
                        DebugConsole.Default.WriteException(exception);
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
			if( null != _ePages_SinkHelper)
			{
				_ePages_SinkHelper.Dispose();
				_ePages_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion

		#pragma warning restore
	}
}