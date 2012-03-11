//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface PPDialog 
	/// SupportByLibrary PowerPoint, 9
	///</summary>
	[SupportByLibraryAttribute("PowerPoint", 9)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PPDialog : COMObject
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
                    _type = typeof(PPDialog);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPDialog(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPDialog(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPDialog(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPDialog() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPDialog(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Application.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
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
		/// SupportByLibrary PowerPoint 9
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public NetOffice.PowerPointApi.Enums.PpDialogStyle Style
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Style", paramsArray);
				return (NetOffice.PowerPointApi.Enums.PpDialogStyle)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public NetOffice.PowerPointApi.Enums.PpDialogMode Mode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Mode", paramsArray);
				return (NetOffice.PowerPointApi.Enums.PpDialogMode)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Mode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public Int32 HelpId
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HelpId", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HelpId", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public NetOffice.OfficeApi.Enums.MsoTriState HideOnIdle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HideOnIdle", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HideOnIdle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public string resourceDLL
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "resourceDLL", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "resourceDLL", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public string Caption
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Caption", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Caption", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public Single Left
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Left", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Left", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public Single Top
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Top", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Top", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public Single Width
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Width", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Width", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public Single Height
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Height", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Height", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public Single ClientLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ClientLeft", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public Single ClientTop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ClientTop", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public Single ClientWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ClientWidth", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public Single ClientHeight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ClientHeight", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public NetOffice.OfficeApi.Enums.MsoTriState Visible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Visible", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Visible", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public NetOffice.PowerPointApi.PPControls Controls
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Controls", paramsArray);
				NetOffice.PowerPointApi.PPControls newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.PPControls.LateBindingApiWrapperType) as NetOffice.PowerPointApi.PPControls;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public NetOffice.PowerPointApi.Tags Tags
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Tags", paramsArray);
				NetOffice.PowerPointApi.Tags newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Tags.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Tags;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public NetOffice.PowerPointApi.PPTabSheets Sheets
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Sheets", paramsArray);
				NetOffice.PowerPointApi.PPTabSheets newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.PPTabSheets.LateBindingApiWrapperType) as NetOffice.PowerPointApi.PPTabSheets;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public NetOffice.PowerPointApi.PPTabControl TabControl
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TabControl", paramsArray);
				NetOffice.PowerPointApi.PPTabControl newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.PPTabControl.LateBindingApiWrapperType) as NetOffice.PowerPointApi.PPTabControl;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public Int32 DelayTime
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DelayTime", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DelayTime", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public Int32 HWND
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HWND", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public string OnTerminate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnTerminate", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnTerminate", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public string OnIdle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnIdle", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnIdle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public string OnMouseDown
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnMouseDown", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnMouseDown", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public string OnMouseUp
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnMouseUp", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnMouseUp", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public string OnKeyPressed
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnKeyPressed", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnKeyPressed", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public string OnTimer
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnTimer", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnTimer", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public string OnActivate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnActivate", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnActivate", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		/// <param name="fileName">string FileName</param>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public Int32 SaveDialog(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			object returnItem = Invoker.MethodReturn(this, "SaveDialog", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public void Terminate()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Terminate", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}