using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface Find 
	/// SupportByVersion Word, 9,10,11,12,14
	///</summary>
	[SupportByVersionAttribute("Word", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Find : COMObject
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
                    _type = typeof(Find);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Find(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Find(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Find(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Find() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Find(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Application.LateBindingApiWrapperType) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
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
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool Forward
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Forward", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Forward", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Font Font
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Font", paramsArray);
				NetOffice.WordApi.Font newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Font.LateBindingApiWrapperType) as NetOffice.WordApi.Font;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Font", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool Found
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Found", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool MatchAllWordForms
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchAllWordForms", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchAllWordForms", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool MatchCase
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchCase", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchCase", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool MatchWildcards
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchWildcards", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchWildcards", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool MatchSoundsLike
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchSoundsLike", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchSoundsLike", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool MatchWholeWord
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchWholeWord", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchWholeWord", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool MatchFuzzy
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchFuzzy", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchFuzzy", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool MatchByte
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchByte", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchByte", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.ParagraphFormat ParagraphFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ParagraphFormat", paramsArray);
				NetOffice.WordApi.ParagraphFormat newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.ParagraphFormat.LateBindingApiWrapperType) as NetOffice.WordApi.ParagraphFormat;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ParagraphFormat", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public object Style
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Style", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Style", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public string Text
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Text", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Text", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdLanguageID LanguageID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LanguageID", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.WordApi.Enums.WdLanguageID)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LanguageID", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public Int32 Highlight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Highlight", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Highlight", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Replacement Replacement
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Replacement", paramsArray);
				NetOffice.WordApi.Replacement newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Replacement.LateBindingApiWrapperType) as NetOffice.WordApi.Replacement;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Frame Frame
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Frame", paramsArray);
				NetOffice.WordApi.Frame newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Frame.LateBindingApiWrapperType) as NetOffice.WordApi.Frame;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdFindWrap Wrap
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Wrap", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.WordApi.Enums.WdFindWrap)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Wrap", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool Format
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Format", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Format", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdLanguageID LanguageIDFarEast
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LanguageIDFarEast", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.WordApi.Enums.WdLanguageID)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LanguageIDFarEast", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdLanguageID LanguageIDOther
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LanguageIDOther", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.WordApi.Enums.WdLanguageID)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LanguageIDOther", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool CorrectHangulEndings
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CorrectHangulEndings", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CorrectHangulEndings", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public Int32 NoProofing
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NoProofing", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NoProofing", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool MatchKashida
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchKashida", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchKashida", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool MatchDiacritics
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchDiacritics", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchDiacritics", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool MatchAlefHamza
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchAlefHamza", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchAlefHamza", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool MatchControl
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchControl", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchControl", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14)]
		public bool MatchPhrase
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchPhrase", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchPhrase", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14)]
		public bool MatchPrefix
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchPrefix", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchPrefix", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14)]
		public bool MatchSuffix
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchSuffix", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchSuffix", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14)]
		public bool IgnoreSpace
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IgnoreSpace", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "IgnoreSpace", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14)]
		public bool IgnorePunct
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IgnorePunct", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "IgnorePunct", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14)]
		public bool HanjaPhoneticHangul
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HanjaPhoneticHangul", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HanjaPhoneticHangul", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		/// <param name="format">optional object Format</param>
		/// <param name="replaceWith">optional object ReplaceWith</param>
		/// <param name="replace">optional object Replace</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool ExecuteOld(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap, object format, object replaceWith, object replace)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format, replaceWith, replace);
			object returnItem = Invoker.MethodReturn(this, "ExecuteOld", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool ExecuteOld()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ExecuteOld", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool ExecuteOld(object findText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText);
			object returnItem = Invoker.MethodReturn(this, "ExecuteOld", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool ExecuteOld(object findText, object matchCase)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase);
			object returnItem = Invoker.MethodReturn(this, "ExecuteOld", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool ExecuteOld(object findText, object matchCase, object matchWholeWord)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord);
			object returnItem = Invoker.MethodReturn(this, "ExecuteOld", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool ExecuteOld(object findText, object matchCase, object matchWholeWord, object matchWildcards)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards);
			object returnItem = Invoker.MethodReturn(this, "ExecuteOld", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool ExecuteOld(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike);
			object returnItem = Invoker.MethodReturn(this, "ExecuteOld", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool ExecuteOld(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms);
			object returnItem = Invoker.MethodReturn(this, "ExecuteOld", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool ExecuteOld(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward);
			object returnItem = Invoker.MethodReturn(this, "ExecuteOld", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool ExecuteOld(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap);
			object returnItem = Invoker.MethodReturn(this, "ExecuteOld", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		/// <param name="format">optional object Format</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool ExecuteOld(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap, object format)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format);
			object returnItem = Invoker.MethodReturn(this, "ExecuteOld", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		/// <param name="format">optional object Format</param>
		/// <param name="replaceWith">optional object ReplaceWith</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool ExecuteOld(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap, object format, object replaceWith)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format, replaceWith);
			object returnItem = Invoker.MethodReturn(this, "ExecuteOld", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void ClearFormatting()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ClearFormatting", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void SetAllFuzzyOptions()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SetAllFuzzyOptions", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void ClearAllFuzzyOptions()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ClearAllFuzzyOptions", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		/// <param name="format">optional object Format</param>
		/// <param name="replaceWith">optional object ReplaceWith</param>
		/// <param name="replace">optional object Replace</param>
		/// <param name="matchKashida">optional object MatchKashida</param>
		/// <param name="matchDiacritics">optional object MatchDiacritics</param>
		/// <param name="matchAlefHamza">optional object MatchAlefHamza</param>
		/// <param name="matchControl">optional object MatchControl</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool Execute(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap, object format, object replaceWith, object replace, object matchKashida, object matchDiacritics, object matchAlefHamza, object matchControl)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format, replaceWith, replace, matchKashida, matchDiacritics, matchAlefHamza, matchControl);
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool Execute()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool Execute(object findText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText);
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool Execute(object findText, object matchCase)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase);
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool Execute(object findText, object matchCase, object matchWholeWord)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord);
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool Execute(object findText, object matchCase, object matchWholeWord, object matchWildcards)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards);
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool Execute(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike);
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool Execute(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms);
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool Execute(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward);
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool Execute(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap);
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		/// <param name="format">optional object Format</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool Execute(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap, object format)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format);
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		/// <param name="format">optional object Format</param>
		/// <param name="replaceWith">optional object ReplaceWith</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool Execute(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap, object format, object replaceWith)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format, replaceWith);
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		/// <param name="format">optional object Format</param>
		/// <param name="replaceWith">optional object ReplaceWith</param>
		/// <param name="replace">optional object Replace</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool Execute(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap, object format, object replaceWith, object replace)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format, replaceWith, replace);
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		/// <param name="format">optional object Format</param>
		/// <param name="replaceWith">optional object ReplaceWith</param>
		/// <param name="replace">optional object Replace</param>
		/// <param name="matchKashida">optional object MatchKashida</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool Execute(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap, object format, object replaceWith, object replace, object matchKashida)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format, replaceWith, replace, matchKashida);
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		/// <param name="format">optional object Format</param>
		/// <param name="replaceWith">optional object ReplaceWith</param>
		/// <param name="replace">optional object Replace</param>
		/// <param name="matchKashida">optional object MatchKashida</param>
		/// <param name="matchDiacritics">optional object MatchDiacritics</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool Execute(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap, object format, object replaceWith, object replace, object matchKashida, object matchDiacritics)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format, replaceWith, replace, matchKashida, matchDiacritics);
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		/// <param name="format">optional object Format</param>
		/// <param name="replaceWith">optional object ReplaceWith</param>
		/// <param name="replace">optional object Replace</param>
		/// <param name="matchKashida">optional object MatchKashida</param>
		/// <param name="matchDiacritics">optional object MatchDiacritics</param>
		/// <param name="matchAlefHamza">optional object MatchAlefHamza</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool Execute(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap, object format, object replaceWith, object replace, object matchKashida, object matchDiacritics, object matchAlefHamza)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format, replaceWith, replace, matchKashida, matchDiacritics, matchAlefHamza);
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">object FindText</param>
		/// <param name="highlightColor">optional object HighlightColor</param>
		/// <param name="textColor">optional object TextColor</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchPrefix">optional object MatchPrefix</param>
		/// <param name="matchSuffix">optional object MatchSuffix</param>
		/// <param name="matchPhrase">optional object MatchPhrase</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="matchByte">optional object MatchByte</param>
		/// <param name="matchFuzzy">optional object MatchFuzzy</param>
		/// <param name="matchKashida">optional object MatchKashida</param>
		/// <param name="matchDiacritics">optional object MatchDiacritics</param>
		/// <param name="matchAlefHamza">optional object MatchAlefHamza</param>
		/// <param name="matchControl">optional object MatchControl</param>
		/// <param name="ignoreSpace">optional object IgnoreSpace</param>
		/// <param name="ignorePunct">optional object IgnorePunct</param>
		/// <param name="hanjaPhoneticHangul">optional object HanjaPhoneticHangul</param>
		[SupportByVersionAttribute("Word", 12,14)]
		public bool HitHighlight(object findText, object highlightColor, object textColor, object matchCase, object matchWholeWord, object matchPrefix, object matchSuffix, object matchPhrase, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object matchByte, object matchFuzzy, object matchKashida, object matchDiacritics, object matchAlefHamza, object matchControl, object ignoreSpace, object ignorePunct, object hanjaPhoneticHangul)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, highlightColor, textColor, matchCase, matchWholeWord, matchPrefix, matchSuffix, matchPhrase, matchWildcards, matchSoundsLike, matchAllWordForms, matchByte, matchFuzzy, matchKashida, matchDiacritics, matchAlefHamza, matchControl, ignoreSpace, ignorePunct, hanjaPhoneticHangul);
			object returnItem = Invoker.MethodReturn(this, "HitHighlight", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">object FindText</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool HitHighlight(object findText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText);
			object returnItem = Invoker.MethodReturn(this, "HitHighlight", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">object FindText</param>
		/// <param name="highlightColor">optional object HighlightColor</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool HitHighlight(object findText, object highlightColor)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, highlightColor);
			object returnItem = Invoker.MethodReturn(this, "HitHighlight", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">object FindText</param>
		/// <param name="highlightColor">optional object HighlightColor</param>
		/// <param name="textColor">optional object TextColor</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool HitHighlight(object findText, object highlightColor, object textColor)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, highlightColor, textColor);
			object returnItem = Invoker.MethodReturn(this, "HitHighlight", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">object FindText</param>
		/// <param name="highlightColor">optional object HighlightColor</param>
		/// <param name="textColor">optional object TextColor</param>
		/// <param name="matchCase">optional object MatchCase</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool HitHighlight(object findText, object highlightColor, object textColor, object matchCase)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, highlightColor, textColor, matchCase);
			object returnItem = Invoker.MethodReturn(this, "HitHighlight", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">object FindText</param>
		/// <param name="highlightColor">optional object HighlightColor</param>
		/// <param name="textColor">optional object TextColor</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool HitHighlight(object findText, object highlightColor, object textColor, object matchCase, object matchWholeWord)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, highlightColor, textColor, matchCase, matchWholeWord);
			object returnItem = Invoker.MethodReturn(this, "HitHighlight", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">object FindText</param>
		/// <param name="highlightColor">optional object HighlightColor</param>
		/// <param name="textColor">optional object TextColor</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchPrefix">optional object MatchPrefix</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool HitHighlight(object findText, object highlightColor, object textColor, object matchCase, object matchWholeWord, object matchPrefix)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, highlightColor, textColor, matchCase, matchWholeWord, matchPrefix);
			object returnItem = Invoker.MethodReturn(this, "HitHighlight", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">object FindText</param>
		/// <param name="highlightColor">optional object HighlightColor</param>
		/// <param name="textColor">optional object TextColor</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchPrefix">optional object MatchPrefix</param>
		/// <param name="matchSuffix">optional object MatchSuffix</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool HitHighlight(object findText, object highlightColor, object textColor, object matchCase, object matchWholeWord, object matchPrefix, object matchSuffix)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, highlightColor, textColor, matchCase, matchWholeWord, matchPrefix, matchSuffix);
			object returnItem = Invoker.MethodReturn(this, "HitHighlight", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">object FindText</param>
		/// <param name="highlightColor">optional object HighlightColor</param>
		/// <param name="textColor">optional object TextColor</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchPrefix">optional object MatchPrefix</param>
		/// <param name="matchSuffix">optional object MatchSuffix</param>
		/// <param name="matchPhrase">optional object MatchPhrase</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool HitHighlight(object findText, object highlightColor, object textColor, object matchCase, object matchWholeWord, object matchPrefix, object matchSuffix, object matchPhrase)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, highlightColor, textColor, matchCase, matchWholeWord, matchPrefix, matchSuffix, matchPhrase);
			object returnItem = Invoker.MethodReturn(this, "HitHighlight", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">object FindText</param>
		/// <param name="highlightColor">optional object HighlightColor</param>
		/// <param name="textColor">optional object TextColor</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchPrefix">optional object MatchPrefix</param>
		/// <param name="matchSuffix">optional object MatchSuffix</param>
		/// <param name="matchPhrase">optional object MatchPhrase</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool HitHighlight(object findText, object highlightColor, object textColor, object matchCase, object matchWholeWord, object matchPrefix, object matchSuffix, object matchPhrase, object matchWildcards)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, highlightColor, textColor, matchCase, matchWholeWord, matchPrefix, matchSuffix, matchPhrase, matchWildcards);
			object returnItem = Invoker.MethodReturn(this, "HitHighlight", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">object FindText</param>
		/// <param name="highlightColor">optional object HighlightColor</param>
		/// <param name="textColor">optional object TextColor</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchPrefix">optional object MatchPrefix</param>
		/// <param name="matchSuffix">optional object MatchSuffix</param>
		/// <param name="matchPhrase">optional object MatchPhrase</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool HitHighlight(object findText, object highlightColor, object textColor, object matchCase, object matchWholeWord, object matchPrefix, object matchSuffix, object matchPhrase, object matchWildcards, object matchSoundsLike)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, highlightColor, textColor, matchCase, matchWholeWord, matchPrefix, matchSuffix, matchPhrase, matchWildcards, matchSoundsLike);
			object returnItem = Invoker.MethodReturn(this, "HitHighlight", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">object FindText</param>
		/// <param name="highlightColor">optional object HighlightColor</param>
		/// <param name="textColor">optional object TextColor</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchPrefix">optional object MatchPrefix</param>
		/// <param name="matchSuffix">optional object MatchSuffix</param>
		/// <param name="matchPhrase">optional object MatchPhrase</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool HitHighlight(object findText, object highlightColor, object textColor, object matchCase, object matchWholeWord, object matchPrefix, object matchSuffix, object matchPhrase, object matchWildcards, object matchSoundsLike, object matchAllWordForms)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, highlightColor, textColor, matchCase, matchWholeWord, matchPrefix, matchSuffix, matchPhrase, matchWildcards, matchSoundsLike, matchAllWordForms);
			object returnItem = Invoker.MethodReturn(this, "HitHighlight", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">object FindText</param>
		/// <param name="highlightColor">optional object HighlightColor</param>
		/// <param name="textColor">optional object TextColor</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchPrefix">optional object MatchPrefix</param>
		/// <param name="matchSuffix">optional object MatchSuffix</param>
		/// <param name="matchPhrase">optional object MatchPhrase</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="matchByte">optional object MatchByte</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool HitHighlight(object findText, object highlightColor, object textColor, object matchCase, object matchWholeWord, object matchPrefix, object matchSuffix, object matchPhrase, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object matchByte)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, highlightColor, textColor, matchCase, matchWholeWord, matchPrefix, matchSuffix, matchPhrase, matchWildcards, matchSoundsLike, matchAllWordForms, matchByte);
			object returnItem = Invoker.MethodReturn(this, "HitHighlight", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">object FindText</param>
		/// <param name="highlightColor">optional object HighlightColor</param>
		/// <param name="textColor">optional object TextColor</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchPrefix">optional object MatchPrefix</param>
		/// <param name="matchSuffix">optional object MatchSuffix</param>
		/// <param name="matchPhrase">optional object MatchPhrase</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="matchByte">optional object MatchByte</param>
		/// <param name="matchFuzzy">optional object MatchFuzzy</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool HitHighlight(object findText, object highlightColor, object textColor, object matchCase, object matchWholeWord, object matchPrefix, object matchSuffix, object matchPhrase, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object matchByte, object matchFuzzy)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, highlightColor, textColor, matchCase, matchWholeWord, matchPrefix, matchSuffix, matchPhrase, matchWildcards, matchSoundsLike, matchAllWordForms, matchByte, matchFuzzy);
			object returnItem = Invoker.MethodReturn(this, "HitHighlight", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">object FindText</param>
		/// <param name="highlightColor">optional object HighlightColor</param>
		/// <param name="textColor">optional object TextColor</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchPrefix">optional object MatchPrefix</param>
		/// <param name="matchSuffix">optional object MatchSuffix</param>
		/// <param name="matchPhrase">optional object MatchPhrase</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="matchByte">optional object MatchByte</param>
		/// <param name="matchFuzzy">optional object MatchFuzzy</param>
		/// <param name="matchKashida">optional object MatchKashida</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool HitHighlight(object findText, object highlightColor, object textColor, object matchCase, object matchWholeWord, object matchPrefix, object matchSuffix, object matchPhrase, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object matchByte, object matchFuzzy, object matchKashida)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, highlightColor, textColor, matchCase, matchWholeWord, matchPrefix, matchSuffix, matchPhrase, matchWildcards, matchSoundsLike, matchAllWordForms, matchByte, matchFuzzy, matchKashida);
			object returnItem = Invoker.MethodReturn(this, "HitHighlight", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">object FindText</param>
		/// <param name="highlightColor">optional object HighlightColor</param>
		/// <param name="textColor">optional object TextColor</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchPrefix">optional object MatchPrefix</param>
		/// <param name="matchSuffix">optional object MatchSuffix</param>
		/// <param name="matchPhrase">optional object MatchPhrase</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="matchByte">optional object MatchByte</param>
		/// <param name="matchFuzzy">optional object MatchFuzzy</param>
		/// <param name="matchKashida">optional object MatchKashida</param>
		/// <param name="matchDiacritics">optional object MatchDiacritics</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool HitHighlight(object findText, object highlightColor, object textColor, object matchCase, object matchWholeWord, object matchPrefix, object matchSuffix, object matchPhrase, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object matchByte, object matchFuzzy, object matchKashida, object matchDiacritics)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, highlightColor, textColor, matchCase, matchWholeWord, matchPrefix, matchSuffix, matchPhrase, matchWildcards, matchSoundsLike, matchAllWordForms, matchByte, matchFuzzy, matchKashida, matchDiacritics);
			object returnItem = Invoker.MethodReturn(this, "HitHighlight", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">object FindText</param>
		/// <param name="highlightColor">optional object HighlightColor</param>
		/// <param name="textColor">optional object TextColor</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchPrefix">optional object MatchPrefix</param>
		/// <param name="matchSuffix">optional object MatchSuffix</param>
		/// <param name="matchPhrase">optional object MatchPhrase</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="matchByte">optional object MatchByte</param>
		/// <param name="matchFuzzy">optional object MatchFuzzy</param>
		/// <param name="matchKashida">optional object MatchKashida</param>
		/// <param name="matchDiacritics">optional object MatchDiacritics</param>
		/// <param name="matchAlefHamza">optional object MatchAlefHamza</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool HitHighlight(object findText, object highlightColor, object textColor, object matchCase, object matchWholeWord, object matchPrefix, object matchSuffix, object matchPhrase, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object matchByte, object matchFuzzy, object matchKashida, object matchDiacritics, object matchAlefHamza)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, highlightColor, textColor, matchCase, matchWholeWord, matchPrefix, matchSuffix, matchPhrase, matchWildcards, matchSoundsLike, matchAllWordForms, matchByte, matchFuzzy, matchKashida, matchDiacritics, matchAlefHamza);
			object returnItem = Invoker.MethodReturn(this, "HitHighlight", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">object FindText</param>
		/// <param name="highlightColor">optional object HighlightColor</param>
		/// <param name="textColor">optional object TextColor</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchPrefix">optional object MatchPrefix</param>
		/// <param name="matchSuffix">optional object MatchSuffix</param>
		/// <param name="matchPhrase">optional object MatchPhrase</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="matchByte">optional object MatchByte</param>
		/// <param name="matchFuzzy">optional object MatchFuzzy</param>
		/// <param name="matchKashida">optional object MatchKashida</param>
		/// <param name="matchDiacritics">optional object MatchDiacritics</param>
		/// <param name="matchAlefHamza">optional object MatchAlefHamza</param>
		/// <param name="matchControl">optional object MatchControl</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool HitHighlight(object findText, object highlightColor, object textColor, object matchCase, object matchWholeWord, object matchPrefix, object matchSuffix, object matchPhrase, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object matchByte, object matchFuzzy, object matchKashida, object matchDiacritics, object matchAlefHamza, object matchControl)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, highlightColor, textColor, matchCase, matchWholeWord, matchPrefix, matchSuffix, matchPhrase, matchWildcards, matchSoundsLike, matchAllWordForms, matchByte, matchFuzzy, matchKashida, matchDiacritics, matchAlefHamza, matchControl);
			object returnItem = Invoker.MethodReturn(this, "HitHighlight", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">object FindText</param>
		/// <param name="highlightColor">optional object HighlightColor</param>
		/// <param name="textColor">optional object TextColor</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchPrefix">optional object MatchPrefix</param>
		/// <param name="matchSuffix">optional object MatchSuffix</param>
		/// <param name="matchPhrase">optional object MatchPhrase</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="matchByte">optional object MatchByte</param>
		/// <param name="matchFuzzy">optional object MatchFuzzy</param>
		/// <param name="matchKashida">optional object MatchKashida</param>
		/// <param name="matchDiacritics">optional object MatchDiacritics</param>
		/// <param name="matchAlefHamza">optional object MatchAlefHamza</param>
		/// <param name="matchControl">optional object MatchControl</param>
		/// <param name="ignoreSpace">optional object IgnoreSpace</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool HitHighlight(object findText, object highlightColor, object textColor, object matchCase, object matchWholeWord, object matchPrefix, object matchSuffix, object matchPhrase, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object matchByte, object matchFuzzy, object matchKashida, object matchDiacritics, object matchAlefHamza, object matchControl, object ignoreSpace)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, highlightColor, textColor, matchCase, matchWholeWord, matchPrefix, matchSuffix, matchPhrase, matchWildcards, matchSoundsLike, matchAllWordForms, matchByte, matchFuzzy, matchKashida, matchDiacritics, matchAlefHamza, matchControl, ignoreSpace);
			object returnItem = Invoker.MethodReturn(this, "HitHighlight", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">object FindText</param>
		/// <param name="highlightColor">optional object HighlightColor</param>
		/// <param name="textColor">optional object TextColor</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchPrefix">optional object MatchPrefix</param>
		/// <param name="matchSuffix">optional object MatchSuffix</param>
		/// <param name="matchPhrase">optional object MatchPhrase</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="matchByte">optional object MatchByte</param>
		/// <param name="matchFuzzy">optional object MatchFuzzy</param>
		/// <param name="matchKashida">optional object MatchKashida</param>
		/// <param name="matchDiacritics">optional object MatchDiacritics</param>
		/// <param name="matchAlefHamza">optional object MatchAlefHamza</param>
		/// <param name="matchControl">optional object MatchControl</param>
		/// <param name="ignoreSpace">optional object IgnoreSpace</param>
		/// <param name="ignorePunct">optional object IgnorePunct</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool HitHighlight(object findText, object highlightColor, object textColor, object matchCase, object matchWholeWord, object matchPrefix, object matchSuffix, object matchPhrase, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object matchByte, object matchFuzzy, object matchKashida, object matchDiacritics, object matchAlefHamza, object matchControl, object ignoreSpace, object ignorePunct)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, highlightColor, textColor, matchCase, matchWholeWord, matchPrefix, matchSuffix, matchPhrase, matchWildcards, matchSoundsLike, matchAllWordForms, matchByte, matchFuzzy, matchKashida, matchDiacritics, matchAlefHamza, matchControl, ignoreSpace, ignorePunct);
			object returnItem = Invoker.MethodReturn(this, "HitHighlight", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		[SupportByVersionAttribute("Word", 12,14)]
		public bool ClearHitHighlight()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ClearHitHighlight", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		/// <param name="format">optional object Format</param>
		/// <param name="replaceWith">optional object ReplaceWith</param>
		/// <param name="replace">optional object Replace</param>
		/// <param name="matchKashida">optional object MatchKashida</param>
		/// <param name="matchDiacritics">optional object MatchDiacritics</param>
		/// <param name="matchAlefHamza">optional object MatchAlefHamza</param>
		/// <param name="matchControl">optional object MatchControl</param>
		/// <param name="matchPrefix">optional object MatchPrefix</param>
		/// <param name="matchSuffix">optional object MatchSuffix</param>
		/// <param name="matchPhrase">optional object MatchPhrase</param>
		/// <param name="ignoreSpace">optional object IgnoreSpace</param>
		/// <param name="ignorePunct">optional object IgnorePunct</param>
		[SupportByVersionAttribute("Word", 12,14)]
		public bool Execute2007(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap, object format, object replaceWith, object replace, object matchKashida, object matchDiacritics, object matchAlefHamza, object matchControl, object matchPrefix, object matchSuffix, object matchPhrase, object ignoreSpace, object ignorePunct)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format, replaceWith, replace, matchKashida, matchDiacritics, matchAlefHamza, matchControl, matchPrefix, matchSuffix, matchPhrase, ignoreSpace, ignorePunct);
			object returnItem = Invoker.MethodReturn(this, "Execute2007", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool Execute2007()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Execute2007", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool Execute2007(object findText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText);
			object returnItem = Invoker.MethodReturn(this, "Execute2007", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool Execute2007(object findText, object matchCase)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase);
			object returnItem = Invoker.MethodReturn(this, "Execute2007", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool Execute2007(object findText, object matchCase, object matchWholeWord)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord);
			object returnItem = Invoker.MethodReturn(this, "Execute2007", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool Execute2007(object findText, object matchCase, object matchWholeWord, object matchWildcards)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards);
			object returnItem = Invoker.MethodReturn(this, "Execute2007", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool Execute2007(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike);
			object returnItem = Invoker.MethodReturn(this, "Execute2007", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool Execute2007(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms);
			object returnItem = Invoker.MethodReturn(this, "Execute2007", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool Execute2007(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward);
			object returnItem = Invoker.MethodReturn(this, "Execute2007", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool Execute2007(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap);
			object returnItem = Invoker.MethodReturn(this, "Execute2007", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		/// <param name="format">optional object Format</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool Execute2007(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap, object format)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format);
			object returnItem = Invoker.MethodReturn(this, "Execute2007", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		/// <param name="format">optional object Format</param>
		/// <param name="replaceWith">optional object ReplaceWith</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool Execute2007(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap, object format, object replaceWith)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format, replaceWith);
			object returnItem = Invoker.MethodReturn(this, "Execute2007", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		/// <param name="format">optional object Format</param>
		/// <param name="replaceWith">optional object ReplaceWith</param>
		/// <param name="replace">optional object Replace</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool Execute2007(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap, object format, object replaceWith, object replace)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format, replaceWith, replace);
			object returnItem = Invoker.MethodReturn(this, "Execute2007", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		/// <param name="format">optional object Format</param>
		/// <param name="replaceWith">optional object ReplaceWith</param>
		/// <param name="replace">optional object Replace</param>
		/// <param name="matchKashida">optional object MatchKashida</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool Execute2007(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap, object format, object replaceWith, object replace, object matchKashida)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format, replaceWith, replace, matchKashida);
			object returnItem = Invoker.MethodReturn(this, "Execute2007", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		/// <param name="format">optional object Format</param>
		/// <param name="replaceWith">optional object ReplaceWith</param>
		/// <param name="replace">optional object Replace</param>
		/// <param name="matchKashida">optional object MatchKashida</param>
		/// <param name="matchDiacritics">optional object MatchDiacritics</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool Execute2007(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap, object format, object replaceWith, object replace, object matchKashida, object matchDiacritics)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format, replaceWith, replace, matchKashida, matchDiacritics);
			object returnItem = Invoker.MethodReturn(this, "Execute2007", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		/// <param name="format">optional object Format</param>
		/// <param name="replaceWith">optional object ReplaceWith</param>
		/// <param name="replace">optional object Replace</param>
		/// <param name="matchKashida">optional object MatchKashida</param>
		/// <param name="matchDiacritics">optional object MatchDiacritics</param>
		/// <param name="matchAlefHamza">optional object MatchAlefHamza</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool Execute2007(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap, object format, object replaceWith, object replace, object matchKashida, object matchDiacritics, object matchAlefHamza)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format, replaceWith, replace, matchKashida, matchDiacritics, matchAlefHamza);
			object returnItem = Invoker.MethodReturn(this, "Execute2007", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		/// <param name="format">optional object Format</param>
		/// <param name="replaceWith">optional object ReplaceWith</param>
		/// <param name="replace">optional object Replace</param>
		/// <param name="matchKashida">optional object MatchKashida</param>
		/// <param name="matchDiacritics">optional object MatchDiacritics</param>
		/// <param name="matchAlefHamza">optional object MatchAlefHamza</param>
		/// <param name="matchControl">optional object MatchControl</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool Execute2007(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap, object format, object replaceWith, object replace, object matchKashida, object matchDiacritics, object matchAlefHamza, object matchControl)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format, replaceWith, replace, matchKashida, matchDiacritics, matchAlefHamza, matchControl);
			object returnItem = Invoker.MethodReturn(this, "Execute2007", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		/// <param name="format">optional object Format</param>
		/// <param name="replaceWith">optional object ReplaceWith</param>
		/// <param name="replace">optional object Replace</param>
		/// <param name="matchKashida">optional object MatchKashida</param>
		/// <param name="matchDiacritics">optional object MatchDiacritics</param>
		/// <param name="matchAlefHamza">optional object MatchAlefHamza</param>
		/// <param name="matchControl">optional object MatchControl</param>
		/// <param name="matchPrefix">optional object MatchPrefix</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool Execute2007(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap, object format, object replaceWith, object replace, object matchKashida, object matchDiacritics, object matchAlefHamza, object matchControl, object matchPrefix)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format, replaceWith, replace, matchKashida, matchDiacritics, matchAlefHamza, matchControl, matchPrefix);
			object returnItem = Invoker.MethodReturn(this, "Execute2007", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		/// <param name="format">optional object Format</param>
		/// <param name="replaceWith">optional object ReplaceWith</param>
		/// <param name="replace">optional object Replace</param>
		/// <param name="matchKashida">optional object MatchKashida</param>
		/// <param name="matchDiacritics">optional object MatchDiacritics</param>
		/// <param name="matchAlefHamza">optional object MatchAlefHamza</param>
		/// <param name="matchControl">optional object MatchControl</param>
		/// <param name="matchPrefix">optional object MatchPrefix</param>
		/// <param name="matchSuffix">optional object MatchSuffix</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool Execute2007(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap, object format, object replaceWith, object replace, object matchKashida, object matchDiacritics, object matchAlefHamza, object matchControl, object matchPrefix, object matchSuffix)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format, replaceWith, replace, matchKashida, matchDiacritics, matchAlefHamza, matchControl, matchPrefix, matchSuffix);
			object returnItem = Invoker.MethodReturn(this, "Execute2007", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		/// <param name="format">optional object Format</param>
		/// <param name="replaceWith">optional object ReplaceWith</param>
		/// <param name="replace">optional object Replace</param>
		/// <param name="matchKashida">optional object MatchKashida</param>
		/// <param name="matchDiacritics">optional object MatchDiacritics</param>
		/// <param name="matchAlefHamza">optional object MatchAlefHamza</param>
		/// <param name="matchControl">optional object MatchControl</param>
		/// <param name="matchPrefix">optional object MatchPrefix</param>
		/// <param name="matchSuffix">optional object MatchSuffix</param>
		/// <param name="matchPhrase">optional object MatchPhrase</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool Execute2007(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap, object format, object replaceWith, object replace, object matchKashida, object matchDiacritics, object matchAlefHamza, object matchControl, object matchPrefix, object matchSuffix, object matchPhrase)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format, replaceWith, replace, matchKashida, matchDiacritics, matchAlefHamza, matchControl, matchPrefix, matchSuffix, matchPhrase);
			object returnItem = Invoker.MethodReturn(this, "Execute2007", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Word 12, 14
		/// </summary>
		/// <param name="findText">optional object FindText</param>
		/// <param name="matchCase">optional object MatchCase</param>
		/// <param name="matchWholeWord">optional object MatchWholeWord</param>
		/// <param name="matchWildcards">optional object MatchWildcards</param>
		/// <param name="matchSoundsLike">optional object MatchSoundsLike</param>
		/// <param name="matchAllWordForms">optional object MatchAllWordForms</param>
		/// <param name="forward">optional object Forward</param>
		/// <param name="wrap">optional object Wrap</param>
		/// <param name="format">optional object Format</param>
		/// <param name="replaceWith">optional object ReplaceWith</param>
		/// <param name="replace">optional object Replace</param>
		/// <param name="matchKashida">optional object MatchKashida</param>
		/// <param name="matchDiacritics">optional object MatchDiacritics</param>
		/// <param name="matchAlefHamza">optional object MatchAlefHamza</param>
		/// <param name="matchControl">optional object MatchControl</param>
		/// <param name="matchPrefix">optional object MatchPrefix</param>
		/// <param name="matchSuffix">optional object MatchSuffix</param>
		/// <param name="matchPhrase">optional object MatchPhrase</param>
		/// <param name="ignoreSpace">optional object IgnoreSpace</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 12,14)]
		public bool Execute2007(object findText, object matchCase, object matchWholeWord, object matchWildcards, object matchSoundsLike, object matchAllWordForms, object forward, object wrap, object format, object replaceWith, object replace, object matchKashida, object matchDiacritics, object matchAlefHamza, object matchControl, object matchPrefix, object matchSuffix, object matchPhrase, object ignoreSpace)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format, replaceWith, replace, matchKashida, matchDiacritics, matchAlefHamza, matchControl, matchPrefix, matchSuffix, matchPhrase, ignoreSpace);
			object returnItem = Invoker.MethodReturn(this, "Execute2007", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		#endregion
		#pragma warning restore
	}
}