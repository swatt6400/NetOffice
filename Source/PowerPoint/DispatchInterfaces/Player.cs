using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface Player 
	/// SupportByVersion PowerPoint, 14,15
	///</summary>
	[SupportByVersionAttribute("PowerPoint", 14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Player : COMObject
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
                    _type = typeof(Player);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Player(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Player(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Player(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Player() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Player(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Application.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
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

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public Int32 CurrentPosition
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CurrentPosition", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CurrentPosition", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public NetOffice.PowerPointApi.Enums.PpPlayerState State
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "State", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.PowerPointApi.Enums.PpPlayerState)intReturnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public void Play()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Play", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public void Pause()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Pause", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public void Stop()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Stop", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public void GoToNextBookmark()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "GoToNextBookmark", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public void GoToPreviousBookmark()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "GoToPreviousBookmark", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}