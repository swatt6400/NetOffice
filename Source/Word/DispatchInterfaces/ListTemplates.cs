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
	/// DispatchInterface ListTemplates 
	/// SupportByVersion Word, 9,10,11,12,14,15
	/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196561.aspx
	///</summary>
	[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ListTemplates : COMObject ,IEnumerable<NetOffice.WordApi.ListTemplate>
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
                    _type = typeof(ListTemplates);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public ListTemplates(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListTemplates(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListTemplates(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListTemplates(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListTemplates(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListTemplates() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListTemplates(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836423.aspx
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
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
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff844890.aspx
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Application.LateBindingApiWrapperType) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff822695.aspx
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
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
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836987.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.WordApi.ListTemplate this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.WordApi.ListTemplate newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.ListTemplate.LateBindingApiWrapperType) as NetOffice.WordApi.ListTemplate;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838283.aspx
		/// </summary>
		/// <param name="outlineNumbered">optional object OutlineNumbered</param>
		/// <param name="name">optional object Name</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.ListTemplate Add(object outlineNumbered, object name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(outlineNumbered, name);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.ListTemplate newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.ListTemplate.LateBindingApiWrapperType) as NetOffice.WordApi.ListTemplate;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838283.aspx
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.ListTemplate Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.ListTemplate newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.ListTemplate.LateBindingApiWrapperType) as NetOffice.WordApi.ListTemplate;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff838283.aspx
		/// </summary>
		/// <param name="outlineNumbered">optional object OutlineNumbered</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.ListTemplate Add(object outlineNumbered)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(outlineNumbered);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.ListTemplate newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.ListTemplate.LateBindingApiWrapperType) as NetOffice.WordApi.ListTemplate;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.WordApi.ListTemplate> Member
        
        /// <summary>
		/// SupportByVersionAttribute Word, 9,10,11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
       public IEnumerator<NetOffice.WordApi.ListTemplate> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.WordApi.ListTemplate item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Word, 9,10,11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}