using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.DAOApi
{
	///<summary>
	/// DispatchInterface Recordset2 
	/// SupportByVersion DAO, 12.0
	///</summary>
	[SupportByVersionAttribute("DAO", 12.0)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Recordset2 : Recordset
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
                    _type = typeof(Recordset2);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Recordset2(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Recordset2(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Recordset2(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Recordset2() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Recordset2(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion DAO 12.0
		/// Get
		/// </summary>
		[SupportByVersionAttribute("DAO", 12.0)]
		public NetOffice.DAOApi.Properties Properties
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Properties", paramsArray);
				NetOffice.DAOApi.Properties newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.DAOApi.Properties.LateBindingApiWrapperType) as NetOffice.DAOApi.Properties;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion DAO 12.0
		/// Get
		/// </summary>
		[SupportByVersionAttribute("DAO", 12.0)]
		public NetOffice.DAOApi.Recordset ParentRecordset
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ParentRecordset", paramsArray);
				NetOffice.DAOApi.Recordset newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.DAOApi.Recordset;
				return newObject;
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}