using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.AccessApi
{
	///<summary>
	/// DispatchInterface Module 
	/// SupportByVersion Access, 9,10,11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Module : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Module);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Module(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Module(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Module(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Module() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Module(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public NetOffice.AccessApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.AccessApi.Application newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.AccessApi.Application.LateBindingApiWrapperType) as NetOffice.AccessApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="line">Int32 Line</param>
		/// <param name="numLines">Int32 NumLines</param>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string get_Lines(Int32 line, Int32 numLines)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(line, numLines);
			object returnItem = Invoker.PropertyGet(this, "Lines", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Alias for get_Lines
		/// </summary>
		/// <param name="line">Int32 Line</param>
		/// <param name="numLines">Int32 NumLines</param>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public string Lines(Int32 line, Int32 numLines)
		{
			return get_Lines(line, numLines);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public Int32 CountOfLines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CountOfLines", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="procName">string ProcName</param>
		/// <param name="procKind">NetOffice.VBIDEApi.Enums.vbext_ProcKind ProcKind</param>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Int32 get_ProcStartLine(string procName, NetOffice.VBIDEApi.Enums.vbext_ProcKind procKind)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(procName, procKind);
			object returnItem = Invoker.PropertyGet(this, "ProcStartLine", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Alias for get_ProcStartLine
		/// </summary>
		/// <param name="procName">string ProcName</param>
		/// <param name="procKind">NetOffice.VBIDEApi.Enums.vbext_ProcKind ProcKind</param>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public Int32 ProcStartLine(string procName, NetOffice.VBIDEApi.Enums.vbext_ProcKind procKind)
		{
			return get_ProcStartLine(procName, procKind);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="procName">string ProcName</param>
		/// <param name="procKind">NetOffice.VBIDEApi.Enums.vbext_ProcKind ProcKind</param>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Int32 get_ProcCountLines(string procName, NetOffice.VBIDEApi.Enums.vbext_ProcKind procKind)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(procName, procKind);
			object returnItem = Invoker.PropertyGet(this, "ProcCountLines", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Alias for get_ProcCountLines
		/// </summary>
		/// <param name="procName">string ProcName</param>
		/// <param name="procKind">NetOffice.VBIDEApi.Enums.vbext_ProcKind ProcKind</param>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public Int32 ProcCountLines(string procName, NetOffice.VBIDEApi.Enums.vbext_ProcKind procKind)
		{
			return get_ProcCountLines(procName, procKind);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="procName">string ProcName</param>
		/// <param name="procKind">NetOffice.VBIDEApi.Enums.vbext_ProcKind ProcKind</param>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Int32 get_ProcBodyLine(string procName, NetOffice.VBIDEApi.Enums.vbext_ProcKind procKind)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(procName, procKind);
			object returnItem = Invoker.PropertyGet(this, "ProcBodyLine", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Alias for get_ProcBodyLine
		/// </summary>
		/// <param name="procName">string ProcName</param>
		/// <param name="procKind">NetOffice.VBIDEApi.Enums.vbext_ProcKind ProcKind</param>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public Int32 ProcBodyLine(string procName, NetOffice.VBIDEApi.Enums.vbext_ProcKind procKind)
		{
			return get_ProcBodyLine(procName, procKind);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="line">Int32 Line</param>
		/// <param name="pprockind">NetOffice.VBIDEApi.Enums.vbext_ProcKind pprockind</param>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string get_ProcOfLine(Int32 line, out NetOffice.VBIDEApi.Enums.vbext_ProcKind pprockind)
		{		
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true);
			pprockind = 0;
			object[] paramsArray = Invoker.ValidateParamsArray(line, pprockind);
			object returnItem = Invoker.PropertyGet(this, "ProcOfLine", paramsArray);
			pprockind = (NetOffice.VBIDEApi.Enums.vbext_ProcKind)paramsArray[1];
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Alias for get_ProcOfLine
		/// </summary>
		/// <param name="line">Int32 Line</param>
		/// <param name="pprockind">NetOffice.VBIDEApi.Enums.vbext_ProcKind pprockind</param>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public string ProcOfLine(Int32 line, out NetOffice.VBIDEApi.Enums.vbext_ProcKind pprockind)
		{
			return get_ProcOfLine(line, out pprockind);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public Int32 CountOfDeclarationLines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CountOfDeclarationLines", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public NetOffice.AccessApi.Enums.AcModuleType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.AccessApi.Enums.AcModuleType)intReturnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="text">string Text</param>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public void InsertText(string text)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(text);
			Invoker.Method(this, "InsertText", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="_string">string String</param>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public void AddFromString(string _string)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(_string);
			Invoker.Method(this, "AddFromString", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="fileName">string FileName</param>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public void AddFromFile(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			Invoker.Method(this, "AddFromFile", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="line">Int32 Line</param>
		/// <param name="_string">string String</param>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public void InsertLines(Int32 line, string _string)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(line, _string);
			Invoker.Method(this, "InsertLines", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="startLine">Int32 StartLine</param>
		/// <param name="count">Int32 Count</param>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public void DeleteLines(Int32 startLine, Int32 count)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(startLine, count);
			Invoker.Method(this, "DeleteLines", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="line">Int32 Line</param>
		/// <param name="_string">string String</param>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public void ReplaceLine(Int32 line, string _string)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(line, _string);
			Invoker.Method(this, "ReplaceLine", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="eventName">string EventName</param>
		/// <param name="objectName">string ObjectName</param>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public Int32 CreateEventProc(string eventName, string objectName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(eventName, objectName);
			object returnItem = Invoker.MethodReturn(this, "CreateEventProc", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="target">string Target</param>
		/// <param name="startLine">Int32 StartLine</param>
		/// <param name="startColumn">Int32 StartColumn</param>
		/// <param name="endLine">Int32 EndLine</param>
		/// <param name="endColumn">Int32 EndColumn</param>
		/// <param name="wholeWord">optional bool WholeWord = false</param>
		/// <param name="matchCase">optional bool MatchCase = false</param>
		/// <param name="patternSearch">optional bool PatternSearch = false</param>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public bool Find(string target, Int32 startLine, Int32 startColumn, Int32 endLine, Int32 endColumn, bool wholeWord, bool matchCase, bool patternSearch)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(target, startLine, startColumn, endLine, endColumn, wholeWord, matchCase, patternSearch);
			object returnItem = Invoker.MethodReturn(this, "Find", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="target">string Target</param>
		/// <param name="startLine">Int32 StartLine</param>
		/// <param name="startColumn">Int32 StartColumn</param>
		/// <param name="endLine">Int32 EndLine</param>
		/// <param name="endColumn">Int32 EndColumn</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public bool Find(string target, Int32 startLine, Int32 startColumn, Int32 endLine, Int32 endColumn)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(target, startLine, startColumn, endLine, endColumn);
			object returnItem = Invoker.MethodReturn(this, "Find", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="target">string Target</param>
		/// <param name="startLine">Int32 StartLine</param>
		/// <param name="startColumn">Int32 StartColumn</param>
		/// <param name="endLine">Int32 EndLine</param>
		/// <param name="endColumn">Int32 EndColumn</param>
		/// <param name="wholeWord">optional bool WholeWord = false</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public bool Find(string target, Int32 startLine, Int32 startColumn, Int32 endLine, Int32 endColumn, bool wholeWord)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(target, startLine, startColumn, endLine, endColumn, wholeWord);
			object returnItem = Invoker.MethodReturn(this, "Find", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="target">string Target</param>
		/// <param name="startLine">Int32 StartLine</param>
		/// <param name="startColumn">Int32 StartColumn</param>
		/// <param name="endLine">Int32 EndLine</param>
		/// <param name="endColumn">Int32 EndColumn</param>
		/// <param name="wholeWord">optional bool WholeWord = false</param>
		/// <param name="matchCase">optional bool MatchCase = false</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public bool Find(string target, Int32 startLine, Int32 startColumn, Int32 endLine, Int32 endColumn, bool wholeWord, bool matchCase)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(target, startLine, startColumn, endLine, endColumn, wholeWord, matchCase);
			object returnItem = Invoker.MethodReturn(this, "Find", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Access 11, 12, 14, 15
		/// </summary>
		/// <param name="dispid">Int32 dispid</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Access", 11,12,14,15)]
		public bool IsMemberSafe(Int32 dispid)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dispid);
			object returnItem = Invoker.MethodReturn(this, "IsMemberSafe", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		#endregion
		#pragma warning restore
	}
}