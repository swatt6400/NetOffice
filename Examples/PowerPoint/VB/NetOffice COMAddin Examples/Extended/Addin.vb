﻿Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Imports NetOffice
Imports NetOffice.Tools
Imports NetOffice.PowerPointApi.Tools
Imports Access = NetOffice.PowerPointApi
Imports NetOffice.PowerPointApi.Enums
Imports Office = NetOffice.OfficeApi
Imports NetOffice.OfficeApi.Enums

'/*
' * This project shows you in depth the COMAddin base class from the NetOffice tools.
' * The COMAddin base class is designed to reduce infrastructure code.
' * This addin looks a bit strange of course because the explanation.
' * Check the NetOffice download section for more NetOffice Tools based Addins
' * Wikipedia Addin  - Word
' * Twitter Addin    - Outlook
' * Google Addin     - Excel
'*/

'/*
'* As you can see, the necessary registry informations was given as annotation, no need for Register/Unregister methods
'* The RegistryLocation attribute is not always necessary. CurrentUser is default, no need for this attribute if you want HKEY_CURRENTUSER (just for example here)
'* You see also the CustomUI attribute. You can specify a path to an embedded xml ressource file with your ribbon schema. If you dont want this then you can override the GetCustomUI method from the base class.
'* The Tweak attribute allows to set various NetOffice options at runtime with custom values entries in the current office addin key(helpful for troubleshooting). Learn more about in the Tweaks sample addin project.
'* The CustomPane attribute allows you to set a task pane very easy
'*/
<COMAddin("NetOfficeVB4 Extended PowerPoint Addin", "This Addin shows you the COMAddin  baseclass from the NetOffice Tools", 3)> _
<CustomUI("RibbonUI.xml", True), RegistryLocation(RegistrySaveLocation.CurrentUser)> _
<CustomPane(GetType(SamplePane), "NetOffice Tools - Sample Pane(VB4)", True, PaneDockPosition.msoCTPDockPositionBottom, PaneDockPositionRestrict.msoCTPDockPositionRestrictNoChange, 50, 50)> _
<Guid("B0A0F2A7-FD40-47B6-A419-28D0A9AA0E1F"), ProgId("ExtendedPPointVB4.Addin")> _
Public Class Addin
    Inherits COMAddin

    ' ouer ribbon instance
    Private RibbonUI As Office.IRibbonUI

    ' say hello in console at startup
    Private Sub Addin_OnStartupComplete(ByRef custom As System.Array) Handles Me.OnStartupComplete

        ' You see the host application is accessible as property from the class instance.
        ' The application property was disposed automaticly while shutdown.
        Console.WriteLine("Host Application Version is:{0}", Me.Application.Version)

    End Sub

    ' taskpane visibility has been changed. we upate the checkbutton in the ribbon ui for show/hide taskpane
    Protected Overrides Sub TaskPaneVisibleStateChanged(ByVal customTaskPaneInst As NetOffice.OfficeApi._CustomTaskPane)

        If Not IsNothing(RibbonUI) Then
            RibbonUI.InvalidateControl("paneVisibleToogleButton")
        End If

    End Sub

    ' defined in RibbonUI.xml to get a instance for ouer ribbon ui.
    Public Sub OnLoadRibonUI(ByVal ribbUI As Office.IRibbonUI)

        RibbonUI = ribbUI

    End Sub


    '  defined in RibbonUI.xml to make sure the checkbutton state is up-to-date and synchronized with taskpane visibility.
    Public Function OnGetPressedPanelToggle(ByVal control As Office.IRibbonControl) As Boolean

        Return TaskPanes(0).Visible

    End Function


    ' defined in RibbonUI.xml to track the user clicked ouer checkbutton. then we upate the panel visibility at hand.
    Public Sub OnCheckPanelToggle(ByVal control As Office.IRibbonControl, ByVal pressed As Boolean)

        TaskPanes(0).Visible = pressed

    End Sub

    ' defined in RibbonUI.xml to catch the user click for the about button
    Public Sub OnClickAboutButton(ByVal control As Office.IRibbonControl)

        Utils.Dialog.ShowAbout("NetOffice Addin Example", "http://netoffice.codeplex.com", "<No licence set>")

    End Sub

    '/*
    '* Now you see the way to exend or modify the register/unregister process if you want.
    '* We define 2 static methods with the RegisterFunction attribute, we use CallBeforeAndAfter as condition.
    '* This condition means the register method in the base class call our method as first (before registry modification) and as last(after registry modification).
    '* The register call argument give you the info what is it currently. Replace means the method in the base class does nothing and its your task to create the registry keys.
    '* Same thing with Unregister method. 
    ' */
    <RegisterFunction(RegisterMode.CallBeforeAndAfter)> _
    Public Shared Sub Register(ByVal type As Type, ByVal registerCall As RegisterCall)

        Select Case registerCall

            Case registerCall.CallBefore

            Case registerCall.CallAfter

            Case registerCall.Replace


        End Select

    End Sub

    <RegisterFunction(RegisterMode.CallBeforeAndAfter)> _
    Public Shared Sub UnRegister(ByVal type As Type, ByVal registerCall As RegisterCall)

        Select Case registerCall

            Case registerCall.CallBefore

            Case registerCall.CallAfter

            Case registerCall.Replace

        End Select

    End Sub

    '/*
    '* at last you see some options for troubleshooting. the COMAddin base class is not a blackbox.
    '*/

    ' This error handler is used for IExtensibility2 events (your code) and the COMAddin methods GetCustomUI, CTPFactoryAvailable and CreateFactory(also overwrites).
    ' the first argument shows in which method the error is occured. The second argument is the detailed exception info. 
    ' Rethrow the exception otherwise the exception is marked as handled.
    Protected Overrides Sub OnError(ByVal methodKind As NetOffice.Tools.ErrorMethodKind, ByVal exception As System.Exception)

        Dim friendlyErrorDescription = String.Format("Unexpected state in {0}.", methodKind)
        Utils.Dialog.ShowError(exception, friendlyErrorDescription)

    End Sub

    ' This method demonstrate an error handler for the register/unregister process.
    ' For example you have an security issues while register or something like that then you can implement a static errorhandler method.
    ' The first argument shows you the error occurs in Register or Unregister.
    ' The second argument is the thrown exception. Rethrow the exception to signalize an error to the environment otherwise the exception is handled.
    <RegisterErrorHandler()> _
    Public Shared Sub RegisterErrorHandler(ByVal methodKind As RegisterErrorMethodKind, ByVal exception As Exception)

        MessageBox.Show("An error occured in " & methodKind.ToString(), "ExtendedPPointVB4.Addin")

    End Sub

End Class
