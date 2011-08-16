//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface IBlogExtensibility SupportByLibrary Office, 12,14
	///</summary>
	[SupportByLibrary("Office", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IBlogExtensibility : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(IBlogExtensibility);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IBlogExtensibility(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IBlogExtensibility(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IBlogExtensibility(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IBlogExtensibility() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IBlogExtensibility(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="BlogProvider">string BlogProvider</param>
		/// <param name="FriendlyName">string FriendlyName</param>
		/// <param name="CategorySupport">NetOffice.OfficeApi.Enums.MsoBlogCategorySupport CategorySupport</param>
		/// <param name="Padding">bool Padding</param>
		[SupportByLibrary("Office", 12,14)]
		public void BlogProviderProperties(string blogProvider, string friendlyName, NetOffice.OfficeApi.Enums.MsoBlogCategorySupport categorySupport, bool padding)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(blogProvider, friendlyName, categorySupport, padding);
			Invoker.Method(this, "BlogProviderProperties", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Account">string Account</param>
		/// <param name="ParentWindow">Int32 ParentWindow</param>
		/// <param name="Document">object Document</param>
		/// <param name="NewAccount">bool NewAccount</param>
		/// <param name="ShowPictureUI">bool ShowPictureUI</param>
		[SupportByLibrary("Office", 12,14)]
		public void SetupBlogAccount(string account, Int32 parentWindow, object document, bool newAccount, bool showPictureUI)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(account, parentWindow, document, newAccount, showPictureUI);
			Invoker.Method(this, "SetupBlogAccount", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Account">string Account</param>
		/// <param name="ParentWindow">Int32 ParentWindow</param>
		/// <param name="Document">object Document</param>
		/// <param name="BlogNames">String[] BlogNames</param>
		/// <param name="BlogIDs">String[] BlogIDs</param>
		/// <param name="BlogURLs">String[] BlogURLs</param>
		[SupportByLibrary("Office", 12,14)]
		public void GetUserBlogs(string account, Int32 parentWindow, object document, String[] blogNames, String[] blogIDs, String[] blogURLs)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(account, parentWindow, document, (object)blogNames, (object)blogIDs, (object)blogURLs);
			Invoker.Method(this, "GetUserBlogs", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Account">string Account</param>
		/// <param name="ParentWindow">Int32 ParentWindow</param>
		/// <param name="Document">object Document</param>
		/// <param name="PostTitles">String[] PostTitles</param>
		/// <param name="PostDates">String[] PostDates</param>
		/// <param name="PostIDs">String[] PostIDs</param>
		[SupportByLibrary("Office", 12,14)]
		public void GetRecentPosts(string account, Int32 parentWindow, object document, String[] postTitles, String[] postDates, String[] postIDs)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(account, parentWindow, document, (object)postTitles, (object)postDates, (object)postIDs);
			Invoker.Method(this, "GetRecentPosts", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Account">string Account</param>
		/// <param name="PostID">string PostID</param>
		/// <param name="ParentWindow">Int32 ParentWindow</param>
		/// <param name="xHTML">string xHTML</param>
		/// <param name="Title">string Title</param>
		/// <param name="DatePosted">string DatePosted</param>
		/// <param name="Categories">String[] Categories</param>
		[SupportByLibrary("Office", 12,14)]
		public void Open(string account, string postID, Int32 parentWindow, string xHTML, string title, string datePosted, String[] categories)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(account, postID, parentWindow, xHTML, title, datePosted, (object)categories);
			Invoker.Method(this, "Open", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Account">string Account</param>
		/// <param name="ParentWindow">Int32 ParentWindow</param>
		/// <param name="Document">object Document</param>
		/// <param name="xHTML">string xHTML</param>
		/// <param name="Title">string Title</param>
		/// <param name="DateTime">string DateTime</param>
		/// <param name="Categories">String[] Categories</param>
		/// <param name="Draft">bool Draft</param>
		/// <param name="PostID">string PostID</param>
		/// <param name="PublishMessage">string PublishMessage</param>
		[SupportByLibrary("Office", 12,14)]
		public void PublishPost(string account, Int32 parentWindow, object document, string xHTML, string title, string dateTime, String[] categories, bool draft, string postID, string publishMessage)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(account, parentWindow, document, xHTML, title, dateTime, (object)categories, draft, postID, publishMessage);
			Invoker.Method(this, "PublishPost", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Account">string Account</param>
		/// <param name="ParentWindow">Int32 ParentWindow</param>
		/// <param name="Document">object Document</param>
		/// <param name="PostID">string PostID</param>
		/// <param name="xHTML">string xHTML</param>
		/// <param name="Title">string Title</param>
		/// <param name="DateTime">string DateTime</param>
		/// <param name="Categories">String[] Categories</param>
		/// <param name="Draft">bool Draft</param>
		/// <param name="PublishMessage">string PublishMessage</param>
		[SupportByLibrary("Office", 12,14)]
		public void RepublishPost(string account, Int32 parentWindow, object document, string postID, string xHTML, string title, string dateTime, String[] categories, bool draft, string publishMessage)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(account, parentWindow, document, postID, xHTML, title, dateTime, (object)categories, draft, publishMessage);
			Invoker.Method(this, "RepublishPost", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Account">string Account</param>
		/// <param name="ParentWindow">Int32 ParentWindow</param>
		/// <param name="Document">object Document</param>
		/// <param name="Categories">String[] Categories</param>
		[SupportByLibrary("Office", 12,14)]
		public void GetCategories(string account, Int32 parentWindow, object document, String[] categories)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(account, parentWindow, document, (object)categories);
			Invoker.Method(this, "GetCategories", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}