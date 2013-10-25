using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using NetOffice;

namespace NetOffice.VisioApi
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByVersionAttribute("Visio", 11,12,14,15)]
	[ComImport, Guid("000D0750-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface EDocument
	{
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2)]
		void DocumentOpened([In, MarshalAs(UnmanagedType.IDispatch)] object doc);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1)]
		void DocumentCreated([In, MarshalAs(UnmanagedType.IDispatch)] object doc);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(3)]
		void DocumentSaved([In, MarshalAs(UnmanagedType.IDispatch)] object doc);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(4)]
		void DocumentSavedAs([In, MarshalAs(UnmanagedType.IDispatch)] object doc);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(8194)]
		void DocumentChanged([In, MarshalAs(UnmanagedType.IDispatch)] object doc);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(16386)]
		void BeforeDocumentClose([In, MarshalAs(UnmanagedType.IDispatch)] object doc);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(32772)]
		void StyleAdded([In, MarshalAs(UnmanagedType.IDispatch)] object style);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(8196)]
		void StyleChanged([In, MarshalAs(UnmanagedType.IDispatch)] object style);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(16388)]
		void BeforeStyleDelete([In, MarshalAs(UnmanagedType.IDispatch)] object style);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(32776)]
		void MasterAdded([In, MarshalAs(UnmanagedType.IDispatch)] object master);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(8200)]
		void MasterChanged([In, MarshalAs(UnmanagedType.IDispatch)] object master);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(16392)]
		void BeforeMasterDelete([In, MarshalAs(UnmanagedType.IDispatch)] object master);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(32784)]
		void PageAdded([In, MarshalAs(UnmanagedType.IDispatch)] object page);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(8208)]
		void PageChanged([In, MarshalAs(UnmanagedType.IDispatch)] object page);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(16400)]
		void BeforePageDelete([In, MarshalAs(UnmanagedType.IDispatch)] object page);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(32832)]
		void ShapeAdded([In, MarshalAs(UnmanagedType.IDispatch)] object shape);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(901)]
		void BeforeSelectionDelete([In, MarshalAs(UnmanagedType.IDispatch)] object selection);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(5)]
		void RunModeEntered([In, MarshalAs(UnmanagedType.IDispatch)] object doc);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(6)]
		void DesignModeEntered([In, MarshalAs(UnmanagedType.IDispatch)] object doc);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(7)]
		void BeforeDocumentSave([In, MarshalAs(UnmanagedType.IDispatch)] object doc);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(8)]
		void BeforeDocumentSaveAs([In, MarshalAs(UnmanagedType.IDispatch)] object doc);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(9)]
		void QueryCancelDocumentClose([In, MarshalAs(UnmanagedType.IDispatch)] object doc);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(10)]
		void DocumentCloseCanceled([In, MarshalAs(UnmanagedType.IDispatch)] object doc);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(300)]
		void QueryCancelStyleDelete([In, MarshalAs(UnmanagedType.IDispatch)] object style);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(301)]
		void StyleDeleteCanceled([In, MarshalAs(UnmanagedType.IDispatch)] object style);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(400)]
		void QueryCancelMasterDelete([In, MarshalAs(UnmanagedType.IDispatch)] object master);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(401)]
		void MasterDeleteCanceled([In, MarshalAs(UnmanagedType.IDispatch)] object master);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(500)]
		void QueryCancelPageDelete([In, MarshalAs(UnmanagedType.IDispatch)] object page);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(501)]
		void PageDeleteCanceled([In, MarshalAs(UnmanagedType.IDispatch)] object page);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(802)]
		void ShapeParentChanged([In, MarshalAs(UnmanagedType.IDispatch)] object shape);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(803)]
		void BeforeShapeTextEdit([In, MarshalAs(UnmanagedType.IDispatch)] object shape);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(804)]
		void ShapeExitedTextEdit([In, MarshalAs(UnmanagedType.IDispatch)] object shape);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(903)]
		void QueryCancelSelectionDelete([In, MarshalAs(UnmanagedType.IDispatch)] object selection);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(904)]
		void SelectionDeleteCanceled([In, MarshalAs(UnmanagedType.IDispatch)] object selection);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(905)]
		void QueryCancelUngroup([In, MarshalAs(UnmanagedType.IDispatch)] object selection);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(906)]
		void UngroupCanceled([In, MarshalAs(UnmanagedType.IDispatch)] object selection);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(907)]
		void QueryCancelConvertToGroup([In, MarshalAs(UnmanagedType.IDispatch)] object selection);

		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(908)]
		void ConvertToGroupCanceled([In, MarshalAs(UnmanagedType.IDispatch)] object selection);

		[SupportByVersionAttribute("Visio", 12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(909)]
		void QueryCancelGroup([In, MarshalAs(UnmanagedType.IDispatch)] object selection);

		[SupportByVersionAttribute("Visio", 12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(910)]
		void GroupCanceled([In, MarshalAs(UnmanagedType.IDispatch)] object selection);

		[SupportByVersionAttribute("Visio", 12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(807)]
		void ShapeDataGraphicChanged([In, MarshalAs(UnmanagedType.IDispatch)] object shape);

		[SupportByVersionAttribute("Visio", 12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(16416)]
		void BeforeDataRecordsetDelete([In, MarshalAs(UnmanagedType.IDispatch)] object dataRecordset);

		[SupportByVersionAttribute("Visio", 12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(32800)]
		void DataRecordsetAdded([In, MarshalAs(UnmanagedType.IDispatch)] object dataRecordset);

		[SupportByVersionAttribute("Visio", 12,14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(11)]
		void AfterRemoveHiddenInformation([In, MarshalAs(UnmanagedType.IDispatch)] object doc);

		[SupportByVersionAttribute("Visio", 14,15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(13)]
		void RuleSetValidated([In, MarshalAs(UnmanagedType.IDispatch)] object ruleSet);

		[SupportByVersionAttribute("Visio", 15)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(14)]
		void AfterDocumentMerge([In, MarshalAs(UnmanagedType.IDispatch)] object coauthMergeObjects);
	}
	
	#endregion
	
	#region SinkHelper
	
	[ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class EDocument_SinkHelper : SinkHelper, EDocument
	{
		#region Static
		
		public static readonly string Id = "000D0750-0000-0000-C000-000000000046";
		
		#endregion
	
		#region Fields

		private IEventBinding	_eventBinding;
        private COMObject		_eventClass;
        
		#endregion
		
		#region Construction

		public EDocument_SinkHelper(COMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			_eventClass = eventClass;
			_eventBinding = (IEventBinding)eventClass;
			SetupEventBinding(connectPoint);
		}
		
		#endregion
		
		#region Properties

        internal Core Factory
        {
            get
            {
                if (null != _eventClass)
                    return _eventClass.Factory;
                else
                    return Core.Default;
            }
        }

        #endregion

		#region EDocument Members
		
		public void DocumentOpened([In, MarshalAs(UnmanagedType.IDispatch)] object doc)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("DocumentOpened");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(doc);
				return;
			}

			NetOffice.VisioApi.IVDocument newdoc = Factory.CreateObjectFromComProxy(_eventClass, doc) as NetOffice.VisioApi.IVDocument;
			object[] paramsArray = new object[1];
			paramsArray[0] = newdoc;
			_eventBinding.RaiseCustomEvent("DocumentOpened", ref paramsArray);
		}

		public void DocumentCreated([In, MarshalAs(UnmanagedType.IDispatch)] object doc)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("DocumentCreated");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(doc);
				return;
			}

			NetOffice.VisioApi.IVDocument newdoc = Factory.CreateObjectFromComProxy(_eventClass, doc) as NetOffice.VisioApi.IVDocument;
			object[] paramsArray = new object[1];
			paramsArray[0] = newdoc;
			_eventBinding.RaiseCustomEvent("DocumentCreated", ref paramsArray);
		}

		public void DocumentSaved([In, MarshalAs(UnmanagedType.IDispatch)] object doc)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("DocumentSaved");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(doc);
				return;
			}

			NetOffice.VisioApi.IVDocument newdoc = Factory.CreateObjectFromComProxy(_eventClass, doc) as NetOffice.VisioApi.IVDocument;
			object[] paramsArray = new object[1];
			paramsArray[0] = newdoc;
			_eventBinding.RaiseCustomEvent("DocumentSaved", ref paramsArray);
		}

		public void DocumentSavedAs([In, MarshalAs(UnmanagedType.IDispatch)] object doc)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("DocumentSavedAs");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(doc);
				return;
			}

			NetOffice.VisioApi.IVDocument newdoc = Factory.CreateObjectFromComProxy(_eventClass, doc) as NetOffice.VisioApi.IVDocument;
			object[] paramsArray = new object[1];
			paramsArray[0] = newdoc;
			_eventBinding.RaiseCustomEvent("DocumentSavedAs", ref paramsArray);
		}

		public void DocumentChanged([In, MarshalAs(UnmanagedType.IDispatch)] object doc)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("DocumentChanged");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(doc);
				return;
			}

			NetOffice.VisioApi.IVDocument newdoc = Factory.CreateObjectFromComProxy(_eventClass, doc) as NetOffice.VisioApi.IVDocument;
			object[] paramsArray = new object[1];
			paramsArray[0] = newdoc;
			_eventBinding.RaiseCustomEvent("DocumentChanged", ref paramsArray);
		}

		public void BeforeDocumentClose([In, MarshalAs(UnmanagedType.IDispatch)] object doc)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeDocumentClose");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(doc);
				return;
			}

			NetOffice.VisioApi.IVDocument newdoc = Factory.CreateObjectFromComProxy(_eventClass, doc) as NetOffice.VisioApi.IVDocument;
			object[] paramsArray = new object[1];
			paramsArray[0] = newdoc;
			_eventBinding.RaiseCustomEvent("BeforeDocumentClose", ref paramsArray);
		}

		public void StyleAdded([In, MarshalAs(UnmanagedType.IDispatch)] object style)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("StyleAdded");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(style);
				return;
			}

			NetOffice.VisioApi.IVStyle newStyle = Factory.CreateObjectFromComProxy(_eventClass, style) as NetOffice.VisioApi.IVStyle;
			object[] paramsArray = new object[1];
			paramsArray[0] = newStyle;
			_eventBinding.RaiseCustomEvent("StyleAdded", ref paramsArray);
		}

		public void StyleChanged([In, MarshalAs(UnmanagedType.IDispatch)] object style)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("StyleChanged");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(style);
				return;
			}

			NetOffice.VisioApi.IVStyle newStyle = Factory.CreateObjectFromComProxy(_eventClass, style) as NetOffice.VisioApi.IVStyle;
			object[] paramsArray = new object[1];
			paramsArray[0] = newStyle;
			_eventBinding.RaiseCustomEvent("StyleChanged", ref paramsArray);
		}

		public void BeforeStyleDelete([In, MarshalAs(UnmanagedType.IDispatch)] object style)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeStyleDelete");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(style);
				return;
			}

			NetOffice.VisioApi.IVStyle newStyle = Factory.CreateObjectFromComProxy(_eventClass, style) as NetOffice.VisioApi.IVStyle;
			object[] paramsArray = new object[1];
			paramsArray[0] = newStyle;
			_eventBinding.RaiseCustomEvent("BeforeStyleDelete", ref paramsArray);
		}

		public void MasterAdded([In, MarshalAs(UnmanagedType.IDispatch)] object master)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("MasterAdded");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(master);
				return;
			}

			NetOffice.VisioApi.IVMaster newMaster = Factory.CreateObjectFromComProxy(_eventClass, master) as NetOffice.VisioApi.IVMaster;
			object[] paramsArray = new object[1];
			paramsArray[0] = newMaster;
			_eventBinding.RaiseCustomEvent("MasterAdded", ref paramsArray);
		}

		public void MasterChanged([In, MarshalAs(UnmanagedType.IDispatch)] object master)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("MasterChanged");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(master);
				return;
			}

			NetOffice.VisioApi.IVMaster newMaster = Factory.CreateObjectFromComProxy(_eventClass, master) as NetOffice.VisioApi.IVMaster;
			object[] paramsArray = new object[1];
			paramsArray[0] = newMaster;
			_eventBinding.RaiseCustomEvent("MasterChanged", ref paramsArray);
		}

		public void BeforeMasterDelete([In, MarshalAs(UnmanagedType.IDispatch)] object master)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeMasterDelete");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(master);
				return;
			}

			NetOffice.VisioApi.IVMaster newMaster = Factory.CreateObjectFromComProxy(_eventClass, master) as NetOffice.VisioApi.IVMaster;
			object[] paramsArray = new object[1];
			paramsArray[0] = newMaster;
			_eventBinding.RaiseCustomEvent("BeforeMasterDelete", ref paramsArray);
		}

		public void PageAdded([In, MarshalAs(UnmanagedType.IDispatch)] object page)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("PageAdded");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(page);
				return;
			}

			NetOffice.VisioApi.IVPage newPage = Factory.CreateObjectFromComProxy(_eventClass, page) as NetOffice.VisioApi.IVPage;
			object[] paramsArray = new object[1];
			paramsArray[0] = newPage;
			_eventBinding.RaiseCustomEvent("PageAdded", ref paramsArray);
		}

		public void PageChanged([In, MarshalAs(UnmanagedType.IDispatch)] object page)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("PageChanged");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(page);
				return;
			}

			NetOffice.VisioApi.IVPage newPage = Factory.CreateObjectFromComProxy(_eventClass, page) as NetOffice.VisioApi.IVPage;
			object[] paramsArray = new object[1];
			paramsArray[0] = newPage;
			_eventBinding.RaiseCustomEvent("PageChanged", ref paramsArray);
		}

		public void BeforePageDelete([In, MarshalAs(UnmanagedType.IDispatch)] object page)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforePageDelete");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(page);
				return;
			}

			NetOffice.VisioApi.IVPage newPage = Factory.CreateObjectFromComProxy(_eventClass, page) as NetOffice.VisioApi.IVPage;
			object[] paramsArray = new object[1];
			paramsArray[0] = newPage;
			_eventBinding.RaiseCustomEvent("BeforePageDelete", ref paramsArray);
		}

		public void ShapeAdded([In, MarshalAs(UnmanagedType.IDispatch)] object shape)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("ShapeAdded");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(shape);
				return;
			}

			NetOffice.VisioApi.IVShape newShape = Factory.CreateObjectFromComProxy(_eventClass, shape) as NetOffice.VisioApi.IVShape;
			object[] paramsArray = new object[1];
			paramsArray[0] = newShape;
			_eventBinding.RaiseCustomEvent("ShapeAdded", ref paramsArray);
		}

		public void BeforeSelectionDelete([In, MarshalAs(UnmanagedType.IDispatch)] object selection)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeSelectionDelete");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(selection);
				return;
			}

			NetOffice.VisioApi.IVSelection newSelection = Factory.CreateObjectFromComProxy(_eventClass, selection) as NetOffice.VisioApi.IVSelection;
			object[] paramsArray = new object[1];
			paramsArray[0] = newSelection;
			_eventBinding.RaiseCustomEvent("BeforeSelectionDelete", ref paramsArray);
		}

		public void RunModeEntered([In, MarshalAs(UnmanagedType.IDispatch)] object doc)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("RunModeEntered");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(doc);
				return;
			}

			NetOffice.VisioApi.IVDocument newdoc = Factory.CreateObjectFromComProxy(_eventClass, doc) as NetOffice.VisioApi.IVDocument;
			object[] paramsArray = new object[1];
			paramsArray[0] = newdoc;
			_eventBinding.RaiseCustomEvent("RunModeEntered", ref paramsArray);
		}

		public void DesignModeEntered([In, MarshalAs(UnmanagedType.IDispatch)] object doc)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("DesignModeEntered");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(doc);
				return;
			}

			NetOffice.VisioApi.IVDocument newdoc = Factory.CreateObjectFromComProxy(_eventClass, doc) as NetOffice.VisioApi.IVDocument;
			object[] paramsArray = new object[1];
			paramsArray[0] = newdoc;
			_eventBinding.RaiseCustomEvent("DesignModeEntered", ref paramsArray);
		}

		public void BeforeDocumentSave([In, MarshalAs(UnmanagedType.IDispatch)] object doc)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeDocumentSave");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(doc);
				return;
			}

			NetOffice.VisioApi.IVDocument newdoc = Factory.CreateObjectFromComProxy(_eventClass, doc) as NetOffice.VisioApi.IVDocument;
			object[] paramsArray = new object[1];
			paramsArray[0] = newdoc;
			_eventBinding.RaiseCustomEvent("BeforeDocumentSave", ref paramsArray);
		}

		public void BeforeDocumentSaveAs([In, MarshalAs(UnmanagedType.IDispatch)] object doc)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeDocumentSaveAs");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(doc);
				return;
			}

			NetOffice.VisioApi.IVDocument newdoc = Factory.CreateObjectFromComProxy(_eventClass, doc) as NetOffice.VisioApi.IVDocument;
			object[] paramsArray = new object[1];
			paramsArray[0] = newdoc;
			_eventBinding.RaiseCustomEvent("BeforeDocumentSaveAs", ref paramsArray);
		}

		public void QueryCancelDocumentClose([In, MarshalAs(UnmanagedType.IDispatch)] object doc)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("QueryCancelDocumentClose");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(doc);
				return;
			}

			NetOffice.VisioApi.IVDocument newdoc = Factory.CreateObjectFromComProxy(_eventClass, doc) as NetOffice.VisioApi.IVDocument;
			object[] paramsArray = new object[1];
			paramsArray[0] = newdoc;
			_eventBinding.RaiseCustomEvent("QueryCancelDocumentClose", ref paramsArray);
		}

		public void DocumentCloseCanceled([In, MarshalAs(UnmanagedType.IDispatch)] object doc)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("DocumentCloseCanceled");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(doc);
				return;
			}

			NetOffice.VisioApi.IVDocument newdoc = Factory.CreateObjectFromComProxy(_eventClass, doc) as NetOffice.VisioApi.IVDocument;
			object[] paramsArray = new object[1];
			paramsArray[0] = newdoc;
			_eventBinding.RaiseCustomEvent("DocumentCloseCanceled", ref paramsArray);
		}

		public void QueryCancelStyleDelete([In, MarshalAs(UnmanagedType.IDispatch)] object style)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("QueryCancelStyleDelete");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(style);
				return;
			}

			NetOffice.VisioApi.IVStyle newStyle = Factory.CreateObjectFromComProxy(_eventClass, style) as NetOffice.VisioApi.IVStyle;
			object[] paramsArray = new object[1];
			paramsArray[0] = newStyle;
			_eventBinding.RaiseCustomEvent("QueryCancelStyleDelete", ref paramsArray);
		}

		public void StyleDeleteCanceled([In, MarshalAs(UnmanagedType.IDispatch)] object style)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("StyleDeleteCanceled");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(style);
				return;
			}

			NetOffice.VisioApi.IVStyle newStyle = Factory.CreateObjectFromComProxy(_eventClass, style) as NetOffice.VisioApi.IVStyle;
			object[] paramsArray = new object[1];
			paramsArray[0] = newStyle;
			_eventBinding.RaiseCustomEvent("StyleDeleteCanceled", ref paramsArray);
		}

		public void QueryCancelMasterDelete([In, MarshalAs(UnmanagedType.IDispatch)] object master)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("QueryCancelMasterDelete");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(master);
				return;
			}

			NetOffice.VisioApi.IVMaster newMaster = Factory.CreateObjectFromComProxy(_eventClass, master) as NetOffice.VisioApi.IVMaster;
			object[] paramsArray = new object[1];
			paramsArray[0] = newMaster;
			_eventBinding.RaiseCustomEvent("QueryCancelMasterDelete", ref paramsArray);
		}

		public void MasterDeleteCanceled([In, MarshalAs(UnmanagedType.IDispatch)] object master)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("MasterDeleteCanceled");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(master);
				return;
			}

			NetOffice.VisioApi.IVMaster newMaster = Factory.CreateObjectFromComProxy(_eventClass, master) as NetOffice.VisioApi.IVMaster;
			object[] paramsArray = new object[1];
			paramsArray[0] = newMaster;
			_eventBinding.RaiseCustomEvent("MasterDeleteCanceled", ref paramsArray);
		}

		public void QueryCancelPageDelete([In, MarshalAs(UnmanagedType.IDispatch)] object page)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("QueryCancelPageDelete");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(page);
				return;
			}

			NetOffice.VisioApi.IVPage newPage = Factory.CreateObjectFromComProxy(_eventClass, page) as NetOffice.VisioApi.IVPage;
			object[] paramsArray = new object[1];
			paramsArray[0] = newPage;
			_eventBinding.RaiseCustomEvent("QueryCancelPageDelete", ref paramsArray);
		}

		public void PageDeleteCanceled([In, MarshalAs(UnmanagedType.IDispatch)] object page)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("PageDeleteCanceled");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(page);
				return;
			}

			NetOffice.VisioApi.IVPage newPage = Factory.CreateObjectFromComProxy(_eventClass, page) as NetOffice.VisioApi.IVPage;
			object[] paramsArray = new object[1];
			paramsArray[0] = newPage;
			_eventBinding.RaiseCustomEvent("PageDeleteCanceled", ref paramsArray);
		}

		public void ShapeParentChanged([In, MarshalAs(UnmanagedType.IDispatch)] object shape)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("ShapeParentChanged");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(shape);
				return;
			}

			NetOffice.VisioApi.IVShape newShape = Factory.CreateObjectFromComProxy(_eventClass, shape) as NetOffice.VisioApi.IVShape;
			object[] paramsArray = new object[1];
			paramsArray[0] = newShape;
			_eventBinding.RaiseCustomEvent("ShapeParentChanged", ref paramsArray);
		}

		public void BeforeShapeTextEdit([In, MarshalAs(UnmanagedType.IDispatch)] object shape)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeShapeTextEdit");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(shape);
				return;
			}

			NetOffice.VisioApi.IVShape newShape = Factory.CreateObjectFromComProxy(_eventClass, shape) as NetOffice.VisioApi.IVShape;
			object[] paramsArray = new object[1];
			paramsArray[0] = newShape;
			_eventBinding.RaiseCustomEvent("BeforeShapeTextEdit", ref paramsArray);
		}

		public void ShapeExitedTextEdit([In, MarshalAs(UnmanagedType.IDispatch)] object shape)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("ShapeExitedTextEdit");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(shape);
				return;
			}

			NetOffice.VisioApi.IVShape newShape = Factory.CreateObjectFromComProxy(_eventClass, shape) as NetOffice.VisioApi.IVShape;
			object[] paramsArray = new object[1];
			paramsArray[0] = newShape;
			_eventBinding.RaiseCustomEvent("ShapeExitedTextEdit", ref paramsArray);
		}

		public void QueryCancelSelectionDelete([In, MarshalAs(UnmanagedType.IDispatch)] object selection)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("QueryCancelSelectionDelete");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(selection);
				return;
			}

			NetOffice.VisioApi.IVSelection newSelection = Factory.CreateObjectFromComProxy(_eventClass, selection) as NetOffice.VisioApi.IVSelection;
			object[] paramsArray = new object[1];
			paramsArray[0] = newSelection;
			_eventBinding.RaiseCustomEvent("QueryCancelSelectionDelete", ref paramsArray);
		}

		public void SelectionDeleteCanceled([In, MarshalAs(UnmanagedType.IDispatch)] object selection)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("SelectionDeleteCanceled");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(selection);
				return;
			}

			NetOffice.VisioApi.IVSelection newSelection = Factory.CreateObjectFromComProxy(_eventClass, selection) as NetOffice.VisioApi.IVSelection;
			object[] paramsArray = new object[1];
			paramsArray[0] = newSelection;
			_eventBinding.RaiseCustomEvent("SelectionDeleteCanceled", ref paramsArray);
		}

		public void QueryCancelUngroup([In, MarshalAs(UnmanagedType.IDispatch)] object selection)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("QueryCancelUngroup");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(selection);
				return;
			}

			NetOffice.VisioApi.IVSelection newSelection = Factory.CreateObjectFromComProxy(_eventClass, selection) as NetOffice.VisioApi.IVSelection;
			object[] paramsArray = new object[1];
			paramsArray[0] = newSelection;
			_eventBinding.RaiseCustomEvent("QueryCancelUngroup", ref paramsArray);
		}

		public void UngroupCanceled([In, MarshalAs(UnmanagedType.IDispatch)] object selection)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("UngroupCanceled");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(selection);
				return;
			}

			NetOffice.VisioApi.IVSelection newSelection = Factory.CreateObjectFromComProxy(_eventClass, selection) as NetOffice.VisioApi.IVSelection;
			object[] paramsArray = new object[1];
			paramsArray[0] = newSelection;
			_eventBinding.RaiseCustomEvent("UngroupCanceled", ref paramsArray);
		}

		public void QueryCancelConvertToGroup([In, MarshalAs(UnmanagedType.IDispatch)] object selection)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("QueryCancelConvertToGroup");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(selection);
				return;
			}

			NetOffice.VisioApi.IVSelection newSelection = Factory.CreateObjectFromComProxy(_eventClass, selection) as NetOffice.VisioApi.IVSelection;
			object[] paramsArray = new object[1];
			paramsArray[0] = newSelection;
			_eventBinding.RaiseCustomEvent("QueryCancelConvertToGroup", ref paramsArray);
		}

		public void ConvertToGroupCanceled([In, MarshalAs(UnmanagedType.IDispatch)] object selection)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("ConvertToGroupCanceled");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(selection);
				return;
			}

			NetOffice.VisioApi.IVSelection newSelection = Factory.CreateObjectFromComProxy(_eventClass, selection) as NetOffice.VisioApi.IVSelection;
			object[] paramsArray = new object[1];
			paramsArray[0] = newSelection;
			_eventBinding.RaiseCustomEvent("ConvertToGroupCanceled", ref paramsArray);
		}

		public void QueryCancelGroup([In, MarshalAs(UnmanagedType.IDispatch)] object selection)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("QueryCancelGroup");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(selection);
				return;
			}

			NetOffice.VisioApi.IVSelection newSelection = Factory.CreateObjectFromComProxy(_eventClass, selection) as NetOffice.VisioApi.IVSelection;
			object[] paramsArray = new object[1];
			paramsArray[0] = newSelection;
			_eventBinding.RaiseCustomEvent("QueryCancelGroup", ref paramsArray);
		}

		public void GroupCanceled([In, MarshalAs(UnmanagedType.IDispatch)] object selection)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("GroupCanceled");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(selection);
				return;
			}

			NetOffice.VisioApi.IVSelection newSelection = Factory.CreateObjectFromComProxy(_eventClass, selection) as NetOffice.VisioApi.IVSelection;
			object[] paramsArray = new object[1];
			paramsArray[0] = newSelection;
			_eventBinding.RaiseCustomEvent("GroupCanceled", ref paramsArray);
		}

		public void ShapeDataGraphicChanged([In, MarshalAs(UnmanagedType.IDispatch)] object shape)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("ShapeDataGraphicChanged");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(shape);
				return;
			}

			NetOffice.VisioApi.IVShape newShape = Factory.CreateObjectFromComProxy(_eventClass, shape) as NetOffice.VisioApi.IVShape;
			object[] paramsArray = new object[1];
			paramsArray[0] = newShape;
			_eventBinding.RaiseCustomEvent("ShapeDataGraphicChanged", ref paramsArray);
		}

		public void BeforeDataRecordsetDelete([In, MarshalAs(UnmanagedType.IDispatch)] object dataRecordset)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("BeforeDataRecordsetDelete");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(dataRecordset);
				return;
			}

			NetOffice.VisioApi.IVDataRecordset newDataRecordset = Factory.CreateObjectFromComProxy(_eventClass, dataRecordset) as NetOffice.VisioApi.IVDataRecordset;
			object[] paramsArray = new object[1];
			paramsArray[0] = newDataRecordset;
			_eventBinding.RaiseCustomEvent("BeforeDataRecordsetDelete", ref paramsArray);
		}

		public void DataRecordsetAdded([In, MarshalAs(UnmanagedType.IDispatch)] object dataRecordset)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("DataRecordsetAdded");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(dataRecordset);
				return;
			}

			NetOffice.VisioApi.IVDataRecordset newDataRecordset = Factory.CreateObjectFromComProxy(_eventClass, dataRecordset) as NetOffice.VisioApi.IVDataRecordset;
			object[] paramsArray = new object[1];
			paramsArray[0] = newDataRecordset;
			_eventBinding.RaiseCustomEvent("DataRecordsetAdded", ref paramsArray);
		}

		public void AfterRemoveHiddenInformation([In, MarshalAs(UnmanagedType.IDispatch)] object doc)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("AfterRemoveHiddenInformation");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(doc);
				return;
			}

			NetOffice.VisioApi.IVDocument newdoc = Factory.CreateObjectFromComProxy(_eventClass, doc) as NetOffice.VisioApi.IVDocument;
			object[] paramsArray = new object[1];
			paramsArray[0] = newdoc;
			_eventBinding.RaiseCustomEvent("AfterRemoveHiddenInformation", ref paramsArray);
		}

		public void RuleSetValidated([In, MarshalAs(UnmanagedType.IDispatch)] object ruleSet)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("RuleSetValidated");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(ruleSet);
				return;
			}

			NetOffice.VisioApi.IVValidationRuleSet newRuleSet = Factory.CreateObjectFromComProxy(_eventClass, ruleSet) as NetOffice.VisioApi.IVValidationRuleSet;
			object[] paramsArray = new object[1];
			paramsArray[0] = newRuleSet;
			_eventBinding.RaiseCustomEvent("RuleSetValidated", ref paramsArray);
		}

		public void AfterDocumentMerge([In, MarshalAs(UnmanagedType.IDispatch)] object coauthMergeObjects)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("AfterDocumentMerge");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(coauthMergeObjects);
				return;
			}

			NetOffice.VisioApi.IVCoauthMergeEvent newcoauthMergeObjects = Factory.CreateObjectFromComProxy(_eventClass, coauthMergeObjects) as NetOffice.VisioApi.IVCoauthMergeEvent;
			object[] paramsArray = new object[1];
			paramsArray[0] = newcoauthMergeObjects;
			_eventBinding.RaiseCustomEvent("AfterDocumentMerge", ref paramsArray);
		}

		#endregion
	}
	
	#endregion
	
	#pragma warning restore
}