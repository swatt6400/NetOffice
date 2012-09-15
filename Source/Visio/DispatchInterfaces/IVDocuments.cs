using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.VisioApi
{
	///<summary>
	/// DispatchInterface IVDocuments 
	/// SupportByVersion Visio, 11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Visio", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IVDocuments : COMObject ,IEnumerable<NetOffice.VisioApi.IVDocument>
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
                    _type = typeof(IVDocuments);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVDocuments(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVDocuments(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVDocuments(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVDocuments() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IVDocuments(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public NetOffice.VisioApi.IVApplication Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.VisioApi.IVApplication newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVApplication;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public Int16 ObjectType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ObjectType", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="nameOrIndex">object NameOrIndex</param>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.VisioApi.IVDocument this[object nameOrIndex]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(nameOrIndex);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.VisioApi.IVDocument newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVDocument;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public Int16 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public NetOffice.VisioApi.IVEventList EventList
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EventList", paramsArray);
				NetOffice.VisioApi.IVEventList newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVEventList;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public Int16 PersistsEvents
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PersistsEvents", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="objectID">Int32 ObjectID</param>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NetOffice.VisioApi.IVDocument get_ItemFromID(Int32 objectID)
		{		
			object[] paramsArray = Invoker.ValidateParamsArray(objectID);
			object returnItem = Invoker.PropertyGet(this, "ItemFromID", paramsArray);
			NetOffice.VisioApi.IVDocument newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVDocument;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// Alias for get_ItemFromID
		/// </summary>
		/// <param name="objectID">Int32 ObjectID</param>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public NetOffice.VisioApi.IVDocument ItemFromID(Int32 objectID)
		{
			return get_ItemFromID(objectID);
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// </summary>
		/// <param name="fileName">string FileName</param>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public NetOffice.VisioApi.IVDocument Add(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.VisioApi.IVDocument newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVDocument;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// </summary>
		/// <param name="fileName">string FileName</param>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public NetOffice.VisioApi.IVDocument Open(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			object returnItem = Invoker.MethodReturn(this, "Open", paramsArray);
			NetOffice.VisioApi.IVDocument newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVDocument;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="flags">Int16 Flags</param>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public NetOffice.VisioApi.IVDocument OpenEx(string fileName, Int16 flags)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, flags);
			object returnItem = Invoker.MethodReturn(this, "OpenEx", paramsArray);
			NetOffice.VisioApi.IVDocument newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVDocument;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// </summary>
		/// <param name="nameArray">String[] NameArray</param>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public void GetNames(out String[] nameArray)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			nameArray = null;
			object[] paramsArray = Invoker.ValidateParamsArray((object)nameArray);
			Invoker.Method(this, "GetNames", paramsArray, modifiers);
			nameArray = (String[])paramsArray[0];
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// </summary>
		/// <param name="fileName">string FileName</param>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public bool CanCheckOut(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			object returnItem = Invoker.MethodReturn(this, "CanCheckOut", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// </summary>
		/// <param name="fileName">string FileName</param>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public void CheckOut(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			Invoker.Method(this, "CheckOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="measurementSystem">optional NetOffice.VisioApi.Enums.VisMeasurementSystem MeasurementSystem = 0</param>
		/// <param name="flags">optional Int32 Flags = 0</param>
		/// <param name="langID">optional Int32 LangID = 0</param>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public NetOffice.VisioApi.IVDocument AddEx(string fileName, NetOffice.VisioApi.Enums.VisMeasurementSystem measurementSystem, Int32 flags, Int32 langID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, measurementSystem, flags, langID);
			object returnItem = Invoker.MethodReturn(this, "AddEx", paramsArray);
			NetOffice.VisioApi.IVDocument newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVDocument;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// </summary>
		/// <param name="fileName">string FileName</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public NetOffice.VisioApi.IVDocument AddEx(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			object returnItem = Invoker.MethodReturn(this, "AddEx", paramsArray);
			NetOffice.VisioApi.IVDocument newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVDocument;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="measurementSystem">optional NetOffice.VisioApi.Enums.VisMeasurementSystem MeasurementSystem = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public NetOffice.VisioApi.IVDocument AddEx(string fileName, NetOffice.VisioApi.Enums.VisMeasurementSystem measurementSystem)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, measurementSystem);
			object returnItem = Invoker.MethodReturn(this, "AddEx", paramsArray);
			NetOffice.VisioApi.IVDocument newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVDocument;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="measurementSystem">optional NetOffice.VisioApi.Enums.VisMeasurementSystem MeasurementSystem = 0</param>
		/// <param name="flags">optional Int32 Flags = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public NetOffice.VisioApi.IVDocument AddEx(string fileName, NetOffice.VisioApi.Enums.VisMeasurementSystem measurementSystem, Int32 flags)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, measurementSystem, flags);
			object returnItem = Invoker.MethodReturn(this, "AddEx", paramsArray);
			NetOffice.VisioApi.IVDocument newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVDocument;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.VisioApi.IVDocument> Member
        
        /// <summary>
		/// SupportByVersionAttribute Visio, 11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
       public IEnumerator<NetOffice.VisioApi.IVDocument> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.VisioApi.IVDocument item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Visio, 11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}