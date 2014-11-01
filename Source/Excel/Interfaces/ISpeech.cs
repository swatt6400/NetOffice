using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface ISpeech 
	/// SupportByVersion Excel, 10,11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class ISpeech : COMObject
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
                    _type = typeof(ISpeech);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public ISpeech(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISpeech(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISpeech(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISpeech(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISpeech(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISpeech() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISpeech(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public NetOffice.ExcelApi.Enums.XlSpeakDirection Direction
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Direction", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlSpeakDirection)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Direction", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public bool SpeakCellOnEnter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SpeakCellOnEnter", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SpeakCellOnEnter", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="text">string Text</param>
		/// <param name="speakAsync">optional object SpeakAsync</param>
		/// <param name="speakXML">optional object SpeakXML</param>
		/// <param name="purge">optional object Purge</param>
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public Int32 Speak(string text, object speakAsync, object speakXML, object purge)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(text, speakAsync, speakXML, purge);
			object returnItem = Invoker.MethodReturn(this, "Speak", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="text">string Text</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public Int32 Speak(string text)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(text);
			object returnItem = Invoker.MethodReturn(this, "Speak", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="text">string Text</param>
		/// <param name="speakAsync">optional object SpeakAsync</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public Int32 Speak(string text, object speakAsync)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(text, speakAsync);
			object returnItem = Invoker.MethodReturn(this, "Speak", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="text">string Text</param>
		/// <param name="speakAsync">optional object SpeakAsync</param>
		/// <param name="speakXML">optional object SpeakXML</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 10,11,12,14,15)]
		public Int32 Speak(string text, object speakAsync, object speakXML)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(text, speakAsync, speakXML);
			object returnItem = Invoker.MethodReturn(this, "Speak", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		#endregion
		#pragma warning restore
	}
}