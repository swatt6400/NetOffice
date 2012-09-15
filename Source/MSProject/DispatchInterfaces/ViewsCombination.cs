using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.MSProjectApi
{
	///<summary>
	/// DispatchInterface ViewsCombination 
	/// SupportByVersion MSProject, 11,12,14
	///</summary>
	[SupportByVersionAttribute("MSProject", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ViewsCombination : Views
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
                    _type = typeof(ViewsCombination);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ViewsCombination(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ViewsCombination(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ViewsCombination(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ViewsCombination() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ViewsCombination(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="topView">object TopView</param>
		/// <param name="bottomView">object BottomView</param>
		/// <param name="showInMenu">optional bool ShowInMenu = false</param>
		[SupportByVersionAttribute("MSProject", 11,12,14)]
		public NetOffice.MSProjectApi.ViewCombination Add(string name, object topView, object bottomView, bool showInMenu)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, topView, bottomView, showInMenu);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSProjectApi.ViewCombination newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.ViewCombination.LateBindingApiWrapperType) as NetOffice.MSProjectApi.ViewCombination;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="topView">object TopView</param>
		/// <param name="bottomView">object BottomView</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSProject", 11,12,14)]
		public NetOffice.MSProjectApi.ViewCombination Add(string name, object topView, object bottomView)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, topView, bottomView);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSProjectApi.ViewCombination newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.MSProjectApi.ViewCombination.LateBindingApiWrapperType) as NetOffice.MSProjectApi.ViewCombination;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}