using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.VBIDEApi
{
	///<summary>
	/// DispatchInterface _AddIns 
	/// SupportByVersion VBIDE, 11,12,5.3
	///</summary>
	[SupportByVersionAttribute("VBIDE", 11,12,5.3)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _AddIns : COMObject ,IEnumerable<NetOffice.VBIDEApi.AddIn>
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
                    _type = typeof(_AddIns);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _AddIns(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _AddIns(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _AddIns(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _AddIns() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _AddIns(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion VBIDE 11, 12, 5.3
		/// Get
		/// </summary>
		[SupportByVersionAttribute("VBIDE", 11,12,5.3)]
		public NetOffice.VBIDEApi.VBE VBE
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VBE", paramsArray);
				NetOffice.VBIDEApi.VBE newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.VBIDEApi.VBE.LateBindingApiWrapperType) as NetOffice.VBIDEApi.VBE;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion VBIDE 11, 12, 5.3
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("VBIDE", 11,12,5.3)]
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
		/// SupportByVersion VBIDE 11, 12, 5.3
		/// Get
		/// </summary>
		[SupportByVersionAttribute("VBIDE", 11,12,5.3)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion VBIDE 11, 12, 5.3
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersionAttribute("VBIDE", 11,12,5.3)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.VBIDEApi.AddIn this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.VBIDEApi.AddIn newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.VBIDEApi.AddIn.LateBindingApiWrapperType) as NetOffice.VBIDEApi.AddIn;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion VBIDE 11, 12, 5.3
		/// </summary>
		[SupportByVersionAttribute("VBIDE", 11,12,5.3)]
		public void Update()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Update", paramsArray);
		}

		#endregion

       #region IEnumerable<NetOffice.VBIDEApi.AddIn> Member
        
        /// <summary>
		/// SupportByVersionAttribute VBIDE, 11,12,5.3
		/// </summary>
		[SupportByVersionAttribute("VBIDE", 11,12,5.3)]
       public IEnumerator<NetOffice.VBIDEApi.AddIn> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.VBIDEApi.AddIn item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute VBIDE, 11,12,5.3
		/// </summary>
		[SupportByVersionAttribute("VBIDE", 11,12,5.3)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsMethod(this);
		}

		#endregion
		#pragma warning restore
	}
}