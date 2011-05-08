using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using LateBindingApi.Core;

namespace LateBindingApi.PowerPointApi
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
	[ComImport, Guid("914934C2-5A91-11CF-8700-00AA0060263B"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface EApplication
	{
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2001)]
		void WindowSelectionChange([In, MarshalAs(UnmanagedType.IDispatch)] object sel);

		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2002)]
		void WindowBeforeRightClick([In, MarshalAs(UnmanagedType.IDispatch)] object sel, [In] [Out] ref object cancel);

		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2003)]
		void WindowBeforeDoubleClick([In, MarshalAs(UnmanagedType.IDispatch)] object sel, [In] [Out] ref object cancel);

		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2004)]
		void PresentationClose([In, MarshalAs(UnmanagedType.IDispatch)] object pres);

		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2005)]
		void PresentationSave([In, MarshalAs(UnmanagedType.IDispatch)] object pres);

		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2006)]
		void PresentationOpen([In, MarshalAs(UnmanagedType.IDispatch)] object pres);

		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2007)]
		void NewPresentation([In, MarshalAs(UnmanagedType.IDispatch)] object pres);

		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2008)]
		void PresentationNewSlide([In, MarshalAs(UnmanagedType.IDispatch)] object sld);

		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2009)]
		void WindowActivate([In, MarshalAs(UnmanagedType.IDispatch)] object pres, [In, MarshalAs(UnmanagedType.IDispatch)] object wn);

		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2010)]
		void WindowDeactivate([In, MarshalAs(UnmanagedType.IDispatch)] object pres, [In, MarshalAs(UnmanagedType.IDispatch)] object wn);

		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2011)]
		void SlideShowBegin([In, MarshalAs(UnmanagedType.IDispatch)] object wn);

		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2012)]
		void SlideShowNextBuild([In, MarshalAs(UnmanagedType.IDispatch)] object wn);

		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2013)]
		void SlideShowNextSlide([In, MarshalAs(UnmanagedType.IDispatch)] object wn);

		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2014)]
		void SlideShowEnd([In, MarshalAs(UnmanagedType.IDispatch)] object pres);

		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2015)]
		void PresentationPrint([In, MarshalAs(UnmanagedType.IDispatch)] object pres);

		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2016)]
		void SlideSelectionChanged([In, MarshalAs(UnmanagedType.IDispatch)] object sldRange);

		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2017)]
		void ColorSchemeChanged([In, MarshalAs(UnmanagedType.IDispatch)] object sldRange);

		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2018)]
		void PresentationBeforeSave([In, MarshalAs(UnmanagedType.IDispatch)] object pres, [In] [Out] ref object cancel);

		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2019)]
		void SlideShowNextClick([In, MarshalAs(UnmanagedType.IDispatch)] object wn, [In, MarshalAs(UnmanagedType.IDispatch)] object nEffect);

		[SupportByLibrary("PP11","PP12","PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2020)]
		void AfterNewPresentation([In, MarshalAs(UnmanagedType.IDispatch)] object pres);

		[SupportByLibrary("PP11","PP12","PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2021)]
		void AfterPresentationOpen([In, MarshalAs(UnmanagedType.IDispatch)] object pres);

		[SupportByLibrary("PP11","PP12","PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2022)]
		void PresentationSync([In, MarshalAs(UnmanagedType.IDispatch)] object pres, [In] object syncEventType);

		[SupportByLibrary("PP12","PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2023)]
		void SlideShowOnNext([In, MarshalAs(UnmanagedType.IDispatch)] object wn);

		[SupportByLibrary("PP12","PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2024)]
		void SlideShowOnPrevious([In, MarshalAs(UnmanagedType.IDispatch)] object wn);

		[SupportByLibrary("PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2025)]
		void PresentationBeforeClose([In, MarshalAs(UnmanagedType.IDispatch)] object pres, [In] [Out] ref object cancel);

		[SupportByLibrary("PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2026)]
		void ProtectedViewWindowOpen([In, MarshalAs(UnmanagedType.IDispatch)] object protViewWindow);

		[SupportByLibrary("PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2027)]
		void ProtectedViewWindowBeforeEdit([In, MarshalAs(UnmanagedType.IDispatch)] object protViewWindow, [In] [Out] ref object cancel);

		[SupportByLibrary("PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2028)]
		void ProtectedViewWindowBeforeClose([In, MarshalAs(UnmanagedType.IDispatch)] object protViewWindow, [In] object protectedViewCloseReason, [In] [Out] ref object cancel);

		[SupportByLibrary("PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2029)]
		void ProtectedViewWindowActivate([In, MarshalAs(UnmanagedType.IDispatch)] object protViewWindow);

		[SupportByLibrary("PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2030)]
		void ProtectedViewWindowDeactivate([In, MarshalAs(UnmanagedType.IDispatch)] object protViewWindow);

		[SupportByLibrary("PP14")]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2031)]
		void PresentationCloseFinal([In, MarshalAs(UnmanagedType.IDispatch)] object pres);
	}
	
	#endregion
	
	#region SinkHelper
	
	[ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class EApplication_SinkHelper : SinkHelper, EApplication
	{
		#region Static
		
		public static readonly string Id = "914934C2-5A91-11CF-8700-00AA0060263B";
		
		#endregion
	
		#region Fields

		private IEventBinding	_eventBinding;
        private COMObject		_eventClass;
        
		#endregion
		
		#region Construction

		public EApplication_SinkHelper(COMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			_eventClass = eventClass;
			_eventBinding = (IEventBinding)eventClass;
			SetupEventBinding(connectPoint);
		}
		
		#endregion
		
		#region EApplication Members
		
		public void WindowSelectionChange([In, MarshalAs(UnmanagedType.IDispatch)] object sel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("WindowSelectionChange");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(sel);
				return;
			}

			LateBindingApi.PowerPointApi.Selection newSel = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, sel) as LateBindingApi.PowerPointApi.Selection;
			object[] paramsArray = new object[1];
			paramsArray[0] = newSel;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void WindowBeforeRightClick([In, MarshalAs(UnmanagedType.IDispatch)] object sel, [In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("WindowBeforeRightClick");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(sel, cancel);
				return;
			}

			LateBindingApi.PowerPointApi.Selection newSel = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, sel) as LateBindingApi.PowerPointApi.Selection;
			object[] paramsArray = new object[2];
			paramsArray[0] = newSel;
			paramsArray.SetValue(cancel, 1);
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			cancel = (bool)paramsArray[1];
		}

		public void WindowBeforeDoubleClick([In, MarshalAs(UnmanagedType.IDispatch)] object sel, [In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("WindowBeforeDoubleClick");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(sel, cancel);
				return;
			}

			LateBindingApi.PowerPointApi.Selection newSel = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, sel) as LateBindingApi.PowerPointApi.Selection;
			object[] paramsArray = new object[2];
			paramsArray[0] = newSel;
			paramsArray.SetValue(cancel, 1);
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			cancel = (bool)paramsArray[1];
		}

		public void PresentationClose([In, MarshalAs(UnmanagedType.IDispatch)] object pres)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("PresentationClose");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pres);
				return;
			}

			LateBindingApi.PowerPointApi.Presentation newPres = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pres) as LateBindingApi.PowerPointApi.Presentation;
			object[] paramsArray = new object[1];
			paramsArray[0] = newPres;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void PresentationSave([In, MarshalAs(UnmanagedType.IDispatch)] object pres)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("PresentationSave");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pres);
				return;
			}

			LateBindingApi.PowerPointApi.Presentation newPres = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pres) as LateBindingApi.PowerPointApi.Presentation;
			object[] paramsArray = new object[1];
			paramsArray[0] = newPres;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void PresentationOpen([In, MarshalAs(UnmanagedType.IDispatch)] object pres)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("PresentationOpen");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pres);
				return;
			}

			LateBindingApi.PowerPointApi.Presentation newPres = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pres) as LateBindingApi.PowerPointApi.Presentation;
			object[] paramsArray = new object[1];
			paramsArray[0] = newPres;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void NewPresentation([In, MarshalAs(UnmanagedType.IDispatch)] object pres)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("NewPresentation");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pres);
				return;
			}

			LateBindingApi.PowerPointApi.Presentation newPres = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pres) as LateBindingApi.PowerPointApi.Presentation;
			object[] paramsArray = new object[1];
			paramsArray[0] = newPres;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void PresentationNewSlide([In, MarshalAs(UnmanagedType.IDispatch)] object sld)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("PresentationNewSlide");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(sld);
				return;
			}

			LateBindingApi.PowerPointApi.Slide newSld = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, sld) as LateBindingApi.PowerPointApi.Slide;
			object[] paramsArray = new object[1];
			paramsArray[0] = newSld;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void WindowActivate([In, MarshalAs(UnmanagedType.IDispatch)] object pres, [In, MarshalAs(UnmanagedType.IDispatch)] object wn)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("WindowActivate");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pres, wn);
				return;
			}

			LateBindingApi.PowerPointApi.Presentation newPres = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pres) as LateBindingApi.PowerPointApi.Presentation;
			LateBindingApi.PowerPointApi.DocumentWindow newWn = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, wn) as LateBindingApi.PowerPointApi.DocumentWindow;
			object[] paramsArray = new object[2];
			paramsArray[0] = newPres;
			paramsArray[1] = newWn;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void WindowDeactivate([In, MarshalAs(UnmanagedType.IDispatch)] object pres, [In, MarshalAs(UnmanagedType.IDispatch)] object wn)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("WindowDeactivate");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pres, wn);
				return;
			}

			LateBindingApi.PowerPointApi.Presentation newPres = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pres) as LateBindingApi.PowerPointApi.Presentation;
			LateBindingApi.PowerPointApi.DocumentWindow newWn = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, wn) as LateBindingApi.PowerPointApi.DocumentWindow;
			object[] paramsArray = new object[2];
			paramsArray[0] = newPres;
			paramsArray[1] = newWn;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void SlideShowBegin([In, MarshalAs(UnmanagedType.IDispatch)] object wn)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("SlideShowBegin");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(wn);
				return;
			}

			LateBindingApi.PowerPointApi.SlideShowWindow newWn = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, wn) as LateBindingApi.PowerPointApi.SlideShowWindow;
			object[] paramsArray = new object[1];
			paramsArray[0] = newWn;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void SlideShowNextBuild([In, MarshalAs(UnmanagedType.IDispatch)] object wn)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("SlideShowNextBuild");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(wn);
				return;
			}

			LateBindingApi.PowerPointApi.SlideShowWindow newWn = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, wn) as LateBindingApi.PowerPointApi.SlideShowWindow;
			object[] paramsArray = new object[1];
			paramsArray[0] = newWn;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void SlideShowNextSlide([In, MarshalAs(UnmanagedType.IDispatch)] object wn)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("SlideShowNextSlide");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(wn);
				return;
			}

			LateBindingApi.PowerPointApi.SlideShowWindow newWn = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, wn) as LateBindingApi.PowerPointApi.SlideShowWindow;
			object[] paramsArray = new object[1];
			paramsArray[0] = newWn;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void SlideShowEnd([In, MarshalAs(UnmanagedType.IDispatch)] object pres)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("SlideShowEnd");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pres);
				return;
			}

			LateBindingApi.PowerPointApi.Presentation newPres = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pres) as LateBindingApi.PowerPointApi.Presentation;
			object[] paramsArray = new object[1];
			paramsArray[0] = newPres;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void PresentationPrint([In, MarshalAs(UnmanagedType.IDispatch)] object pres)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("PresentationPrint");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pres);
				return;
			}

			LateBindingApi.PowerPointApi.Presentation newPres = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pres) as LateBindingApi.PowerPointApi.Presentation;
			object[] paramsArray = new object[1];
			paramsArray[0] = newPres;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void SlideSelectionChanged([In, MarshalAs(UnmanagedType.IDispatch)] object sldRange)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("SlideSelectionChanged");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(sldRange);
				return;
			}

			LateBindingApi.PowerPointApi.SlideRange newSldRange = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, sldRange) as LateBindingApi.PowerPointApi.SlideRange;
			object[] paramsArray = new object[1];
			paramsArray[0] = newSldRange;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void ColorSchemeChanged([In, MarshalAs(UnmanagedType.IDispatch)] object sldRange)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("ColorSchemeChanged");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(sldRange);
				return;
			}

			LateBindingApi.PowerPointApi.SlideRange newSldRange = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, sldRange) as LateBindingApi.PowerPointApi.SlideRange;
			object[] paramsArray = new object[1];
			paramsArray[0] = newSldRange;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void PresentationBeforeSave([In, MarshalAs(UnmanagedType.IDispatch)] object pres, [In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("PresentationBeforeSave");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pres, cancel);
				return;
			}

			LateBindingApi.PowerPointApi.Presentation newPres = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pres) as LateBindingApi.PowerPointApi.Presentation;
			object[] paramsArray = new object[2];
			paramsArray[0] = newPres;
			paramsArray.SetValue(cancel, 1);
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			cancel = (bool)paramsArray[1];
		}

		public void SlideShowNextClick([In, MarshalAs(UnmanagedType.IDispatch)] object wn, [In, MarshalAs(UnmanagedType.IDispatch)] object nEffect)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("SlideShowNextClick");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(wn, nEffect);
				return;
			}

			LateBindingApi.PowerPointApi.SlideShowWindow newWn = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, wn) as LateBindingApi.PowerPointApi.SlideShowWindow;
			LateBindingApi.PowerPointApi.Effect newnEffect = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, nEffect) as LateBindingApi.PowerPointApi.Effect;
			object[] paramsArray = new object[2];
			paramsArray[0] = newWn;
			paramsArray[1] = newnEffect;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void AfterNewPresentation([In, MarshalAs(UnmanagedType.IDispatch)] object pres)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("AfterNewPresentation");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pres);
				return;
			}

			LateBindingApi.PowerPointApi.Presentation newPres = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pres) as LateBindingApi.PowerPointApi.Presentation;
			object[] paramsArray = new object[1];
			paramsArray[0] = newPres;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void AfterPresentationOpen([In, MarshalAs(UnmanagedType.IDispatch)] object pres)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("AfterPresentationOpen");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pres);
				return;
			}

			LateBindingApi.PowerPointApi.Presentation newPres = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pres) as LateBindingApi.PowerPointApi.Presentation;
			object[] paramsArray = new object[1];
			paramsArray[0] = newPres;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void PresentationSync([In, MarshalAs(UnmanagedType.IDispatch)] object pres, [In] object syncEventType)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("PresentationSync");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pres, syncEventType);
				return;
			}

			LateBindingApi.PowerPointApi.Presentation newPres = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pres) as LateBindingApi.PowerPointApi.Presentation;
			LateBindingApi.OfficeApi.Enums.MsoSyncEventType newSyncEventType = (LateBindingApi.OfficeApi.Enums.MsoSyncEventType)syncEventType;
			object[] paramsArray = new object[2];
			paramsArray[0] = newPres;
			paramsArray[1] = newSyncEventType;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void SlideShowOnNext([In, MarshalAs(UnmanagedType.IDispatch)] object wn)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("SlideShowOnNext");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(wn);
				return;
			}

			LateBindingApi.PowerPointApi.SlideShowWindow newWn = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, wn) as LateBindingApi.PowerPointApi.SlideShowWindow;
			object[] paramsArray = new object[1];
			paramsArray[0] = newWn;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void SlideShowOnPrevious([In, MarshalAs(UnmanagedType.IDispatch)] object wn)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("SlideShowOnPrevious");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(wn);
				return;
			}

			LateBindingApi.PowerPointApi.SlideShowWindow newWn = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, wn) as LateBindingApi.PowerPointApi.SlideShowWindow;
			object[] paramsArray = new object[1];
			paramsArray[0] = newWn;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void PresentationBeforeClose([In, MarshalAs(UnmanagedType.IDispatch)] object pres, [In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("PresentationBeforeClose");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pres, cancel);
				return;
			}

			LateBindingApi.PowerPointApi.Presentation newPres = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pres) as LateBindingApi.PowerPointApi.Presentation;
			object[] paramsArray = new object[2];
			paramsArray[0] = newPres;
			paramsArray.SetValue(cancel, 1);
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			cancel = (bool)paramsArray[1];
		}

		public void ProtectedViewWindowOpen([In, MarshalAs(UnmanagedType.IDispatch)] object protViewWindow)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("ProtectedViewWindowOpen");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(protViewWindow);
				return;
			}

			LateBindingApi.PowerPointApi.ProtectedViewWindow newProtViewWindow = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, protViewWindow) as LateBindingApi.PowerPointApi.ProtectedViewWindow;
			object[] paramsArray = new object[1];
			paramsArray[0] = newProtViewWindow;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void ProtectedViewWindowBeforeEdit([In, MarshalAs(UnmanagedType.IDispatch)] object protViewWindow, [In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("ProtectedViewWindowBeforeEdit");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(protViewWindow, cancel);
				return;
			}

			LateBindingApi.PowerPointApi.ProtectedViewWindow newProtViewWindow = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, protViewWindow) as LateBindingApi.PowerPointApi.ProtectedViewWindow;
			object[] paramsArray = new object[2];
			paramsArray[0] = newProtViewWindow;
			paramsArray.SetValue(cancel, 1);
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			cancel = (bool)paramsArray[1];
		}

		public void ProtectedViewWindowBeforeClose([In, MarshalAs(UnmanagedType.IDispatch)] object protViewWindow, [In] object protectedViewCloseReason, [In] [Out] ref object cancel)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("ProtectedViewWindowBeforeClose");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(protViewWindow, protectedViewCloseReason, cancel);
				return;
			}

			LateBindingApi.PowerPointApi.ProtectedViewWindow newProtViewWindow = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, protViewWindow) as LateBindingApi.PowerPointApi.ProtectedViewWindow;
			LateBindingApi.PowerPointApi.Enums.PpProtectedViewCloseReason newProtectedViewCloseReason = (LateBindingApi.PowerPointApi.Enums.PpProtectedViewCloseReason)protectedViewCloseReason;
			object[] paramsArray = new object[3];
			paramsArray[0] = newProtViewWindow;
			paramsArray[1] = newProtectedViewCloseReason;
			paramsArray.SetValue(cancel, 2);
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);

			cancel = (bool)paramsArray[2];
		}

		public void ProtectedViewWindowActivate([In, MarshalAs(UnmanagedType.IDispatch)] object protViewWindow)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("ProtectedViewWindowActivate");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(protViewWindow);
				return;
			}

			LateBindingApi.PowerPointApi.ProtectedViewWindow newProtViewWindow = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, protViewWindow) as LateBindingApi.PowerPointApi.ProtectedViewWindow;
			object[] paramsArray = new object[1];
			paramsArray[0] = newProtViewWindow;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void ProtectedViewWindowDeactivate([In, MarshalAs(UnmanagedType.IDispatch)] object protViewWindow)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("ProtectedViewWindowDeactivate");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(protViewWindow);
				return;
			}

			LateBindingApi.PowerPointApi.ProtectedViewWindow newProtViewWindow = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, protViewWindow) as LateBindingApi.PowerPointApi.ProtectedViewWindow;
			object[] paramsArray = new object[1];
			paramsArray[0] = newProtViewWindow;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		public void PresentationCloseFinal([In, MarshalAs(UnmanagedType.IDispatch)] object pres)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("PresentationCloseFinal");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(pres);
				return;
			}

			LateBindingApi.PowerPointApi.Presentation newPres = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, pres) as LateBindingApi.PowerPointApi.Presentation;
			object[] paramsArray = new object[1];
			paramsArray[0] = newPres;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		#endregion
	}
	
	#endregion
	
	#pragma warning restore
}