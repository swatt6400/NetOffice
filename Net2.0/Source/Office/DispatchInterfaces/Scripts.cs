//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace LateBindingApi.OfficeApi
{
	///<summary>
	/// DispatchInterface Scripts SupportByLibrary OF09 OF10 OF11 OF12 OF14 
	///</summary>
	[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
	public class Scripts : _IMsoDispObj ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Scripts(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Scripts(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Scripts(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Scripts()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
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
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public LateBindingApi.OfficeApi.Script Item(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
			LateBindingApi.OfficeApi.Script newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OfficeApi.Script;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="Anchor">object Anchor</param>
		/// <param name="Location">LateBindingApi.OfficeApi.Enums.MsoScriptLocation Location</param>
		/// <param name="Language">LateBindingApi.OfficeApi.Enums.MsoScriptLanguage Language</param>
		/// <param name="Id">string Id</param>
		/// <param name="Extended">string Extended</param>
		/// <param name="ScriptText">string ScriptText</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public LateBindingApi.OfficeApi.Script Add(object anchor, LateBindingApi.OfficeApi.Enums.MsoScriptLocation location, LateBindingApi.OfficeApi.Enums.MsoScriptLanguage language, string id, string extended, string scriptText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(anchor, location, language, id, extended, scriptText);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			LateBindingApi.OfficeApi.Script newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OfficeApi.Script;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
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