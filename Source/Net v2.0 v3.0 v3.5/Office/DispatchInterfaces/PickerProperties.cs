//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface PickerProperties SupportByLibrary "Office", 14
	///</summary>
	[SupportByLibrary("Office", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PickerProperties : _IMsoDispObj ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PickerProperties(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PickerProperties(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PickerProperties(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PickerProperties()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("Office", 14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OfficeApi.PickerProperty this[Int32 index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OfficeApi.PickerProperty newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.PickerProperty;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Office", 14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="Id">string Id</param>
		/// <param name="Value">string Value</param>
		/// <param name="Type">NetOffice.OfficeApi.Enums.MsoPickerField Type</param>
		[SupportByLibrary("Office", 14)]
		public NetOffice.OfficeApi.PickerProperty Add(string id, string value, NetOffice.OfficeApi.Enums.MsoPickerField type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(id, value, type);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.PickerProperty newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.PickerProperty;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="Id">string Id</param>
		[SupportByLibrary("Office", 14)]
		public void Remove(string id)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(id);
			Invoker.Method(this, "Remove", paramsArray);
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("Office", 14)]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}