using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface Subdocuments 
	/// SupportByVersion Word, 9,10,11,12,14
	///</summary>
	[SupportByVersionAttribute("Word", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Subdocuments : COMObject ,IEnumerable<NetOffice.WordApi.Subdocument>
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
                    _type = typeof(Subdocuments);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Subdocuments(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Subdocuments(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Subdocuments(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Subdocuments() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Subdocuments(string progId) : base(progId)
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
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public bool Expanded
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Expanded", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Expanded", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="index">Int32 Index</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.WordApi.Subdocument this[Int32 index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.WordApi.Subdocument newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Subdocument.LateBindingApiWrapperType) as NetOffice.WordApi.Subdocument;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="name">object Name</param>
		/// <param name="confirmConversions">optional object ConfirmConversions</param>
		/// <param name="readOnly">optional object ReadOnly</param>
		/// <param name="passwordDocument">optional object PasswordDocument</param>
		/// <param name="passwordTemplate">optional object PasswordTemplate</param>
		/// <param name="revert">optional object Revert</param>
		/// <param name="writePasswordDocument">optional object WritePasswordDocument</param>
		/// <param name="writePasswordTemplate">optional object WritePasswordTemplate</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Subdocument AddFromFile(object name, object confirmConversions, object readOnly, object passwordDocument, object passwordTemplate, object revert, object writePasswordDocument, object writePasswordTemplate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, confirmConversions, readOnly, passwordDocument, passwordTemplate, revert, writePasswordDocument, writePasswordTemplate);
			object returnItem = Invoker.MethodReturn(this, "AddFromFile", paramsArray);
			NetOffice.WordApi.Subdocument newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Subdocument.LateBindingApiWrapperType) as NetOffice.WordApi.Subdocument;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="name">object Name</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Subdocument AddFromFile(object name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "AddFromFile", paramsArray);
			NetOffice.WordApi.Subdocument newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Subdocument.LateBindingApiWrapperType) as NetOffice.WordApi.Subdocument;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="name">object Name</param>
		/// <param name="confirmConversions">optional object ConfirmConversions</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Subdocument AddFromFile(object name, object confirmConversions)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, confirmConversions);
			object returnItem = Invoker.MethodReturn(this, "AddFromFile", paramsArray);
			NetOffice.WordApi.Subdocument newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Subdocument.LateBindingApiWrapperType) as NetOffice.WordApi.Subdocument;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="name">object Name</param>
		/// <param name="confirmConversions">optional object ConfirmConversions</param>
		/// <param name="readOnly">optional object ReadOnly</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Subdocument AddFromFile(object name, object confirmConversions, object readOnly)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, confirmConversions, readOnly);
			object returnItem = Invoker.MethodReturn(this, "AddFromFile", paramsArray);
			NetOffice.WordApi.Subdocument newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Subdocument.LateBindingApiWrapperType) as NetOffice.WordApi.Subdocument;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="name">object Name</param>
		/// <param name="confirmConversions">optional object ConfirmConversions</param>
		/// <param name="readOnly">optional object ReadOnly</param>
		/// <param name="passwordDocument">optional object PasswordDocument</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Subdocument AddFromFile(object name, object confirmConversions, object readOnly, object passwordDocument)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, confirmConversions, readOnly, passwordDocument);
			object returnItem = Invoker.MethodReturn(this, "AddFromFile", paramsArray);
			NetOffice.WordApi.Subdocument newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Subdocument.LateBindingApiWrapperType) as NetOffice.WordApi.Subdocument;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="name">object Name</param>
		/// <param name="confirmConversions">optional object ConfirmConversions</param>
		/// <param name="readOnly">optional object ReadOnly</param>
		/// <param name="passwordDocument">optional object PasswordDocument</param>
		/// <param name="passwordTemplate">optional object PasswordTemplate</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Subdocument AddFromFile(object name, object confirmConversions, object readOnly, object passwordDocument, object passwordTemplate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, confirmConversions, readOnly, passwordDocument, passwordTemplate);
			object returnItem = Invoker.MethodReturn(this, "AddFromFile", paramsArray);
			NetOffice.WordApi.Subdocument newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Subdocument.LateBindingApiWrapperType) as NetOffice.WordApi.Subdocument;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="name">object Name</param>
		/// <param name="confirmConversions">optional object ConfirmConversions</param>
		/// <param name="readOnly">optional object ReadOnly</param>
		/// <param name="passwordDocument">optional object PasswordDocument</param>
		/// <param name="passwordTemplate">optional object PasswordTemplate</param>
		/// <param name="revert">optional object Revert</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Subdocument AddFromFile(object name, object confirmConversions, object readOnly, object passwordDocument, object passwordTemplate, object revert)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, confirmConversions, readOnly, passwordDocument, passwordTemplate, revert);
			object returnItem = Invoker.MethodReturn(this, "AddFromFile", paramsArray);
			NetOffice.WordApi.Subdocument newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Subdocument.LateBindingApiWrapperType) as NetOffice.WordApi.Subdocument;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="name">object Name</param>
		/// <param name="confirmConversions">optional object ConfirmConversions</param>
		/// <param name="readOnly">optional object ReadOnly</param>
		/// <param name="passwordDocument">optional object PasswordDocument</param>
		/// <param name="passwordTemplate">optional object PasswordTemplate</param>
		/// <param name="revert">optional object Revert</param>
		/// <param name="writePasswordDocument">optional object WritePasswordDocument</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Subdocument AddFromFile(object name, object confirmConversions, object readOnly, object passwordDocument, object passwordTemplate, object revert, object writePasswordDocument)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, confirmConversions, readOnly, passwordDocument, passwordTemplate, revert, writePasswordDocument);
			object returnItem = Invoker.MethodReturn(this, "AddFromFile", paramsArray);
			NetOffice.WordApi.Subdocument newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Subdocument.LateBindingApiWrapperType) as NetOffice.WordApi.Subdocument;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="range">NetOffice.WordApi.Range Range</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Subdocument AddFromRange(NetOffice.WordApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "AddFromRange", paramsArray);
			NetOffice.WordApi.Subdocument newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Subdocument.LateBindingApiWrapperType) as NetOffice.WordApi.Subdocument;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="firstSubdocument">optional object FirstSubdocument</param>
		/// <param name="lastSubdocument">optional object LastSubdocument</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void Merge(object firstSubdocument, object lastSubdocument)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(firstSubdocument, lastSubdocument);
			Invoker.Method(this, "Merge", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void Merge()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Merge", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="firstSubdocument">optional object FirstSubdocument</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void Merge(object firstSubdocument)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(firstSubdocument);
			Invoker.Method(this, "Merge", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public void Select()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Select", paramsArray);
		}

		#endregion

       #region IEnumerable<NetOffice.WordApi.Subdocument> Member
        
        /// <summary>
		/// SupportByVersionAttribute Word, 9,10,11,12,14
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
       public IEnumerator<NetOffice.WordApi.Subdocument> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.WordApi.Subdocument item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Word, 9,10,11,12,14
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}