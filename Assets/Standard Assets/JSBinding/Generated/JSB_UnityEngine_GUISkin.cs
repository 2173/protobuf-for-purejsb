﻿
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by CSGenerator.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

using jsval = JSApi.jsval;

public class JSB_UnityEngine_GUISkin
{

////////////////////// GUISkin ///////////////////////////////////////
// constructors

static bool GUISkin_GUISkin1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.GUISkin());
    }

    return true;
}

// fields

// properties
static void GUISkin_font(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        var result = _this.font;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Font arg0 = (UnityEngine.Font)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        _this.font = arg0;
    }
}
static void GUISkin_box(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        var result = _this.box;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        _this.box = arg0;
    }
}
static void GUISkin_label(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        var result = _this.label;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        _this.label = arg0;
    }
}
static void GUISkin_textField(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        var result = _this.textField;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        _this.textField = arg0;
    }
}
static void GUISkin_textArea(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        var result = _this.textArea;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        _this.textArea = arg0;
    }
}
static void GUISkin_button(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        var result = _this.button;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        _this.button = arg0;
    }
}
static void GUISkin_toggle(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        var result = _this.toggle;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        _this.toggle = arg0;
    }
}
static void GUISkin_window(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        var result = _this.window;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        _this.window = arg0;
    }
}
static void GUISkin_horizontalSlider(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        var result = _this.horizontalSlider;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        _this.horizontalSlider = arg0;
    }
}
static void GUISkin_horizontalSliderThumb(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        var result = _this.horizontalSliderThumb;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        _this.horizontalSliderThumb = arg0;
    }
}
static void GUISkin_verticalSlider(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        var result = _this.verticalSlider;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        _this.verticalSlider = arg0;
    }
}
static void GUISkin_verticalSliderThumb(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        var result = _this.verticalSliderThumb;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        _this.verticalSliderThumb = arg0;
    }
}
static void GUISkin_horizontalScrollbar(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        var result = _this.horizontalScrollbar;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        _this.horizontalScrollbar = arg0;
    }
}
static void GUISkin_horizontalScrollbarThumb(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        var result = _this.horizontalScrollbarThumb;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        _this.horizontalScrollbarThumb = arg0;
    }
}
static void GUISkin_horizontalScrollbarLeftButton(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        var result = _this.horizontalScrollbarLeftButton;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        _this.horizontalScrollbarLeftButton = arg0;
    }
}
static void GUISkin_horizontalScrollbarRightButton(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        var result = _this.horizontalScrollbarRightButton;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        _this.horizontalScrollbarRightButton = arg0;
    }
}
static void GUISkin_verticalScrollbar(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        var result = _this.verticalScrollbar;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        _this.verticalScrollbar = arg0;
    }
}
static void GUISkin_verticalScrollbarThumb(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        var result = _this.verticalScrollbarThumb;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        _this.verticalScrollbarThumb = arg0;
    }
}
static void GUISkin_verticalScrollbarUpButton(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        var result = _this.verticalScrollbarUpButton;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        _this.verticalScrollbarUpButton = arg0;
    }
}
static void GUISkin_verticalScrollbarDownButton(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        var result = _this.verticalScrollbarDownButton;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        _this.verticalScrollbarDownButton = arg0;
    }
}
static void GUISkin_scrollView(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        var result = _this.scrollView;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        _this.scrollView = arg0;
    }
}
static void GUISkin_customStyles(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        var result = _this.customStyles;
                var arrRet = result;
        for (int i = 0; arrRet != null && i < arrRet.Length; i++)
        {
            JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
            JSApi.moveSaveID2Arr(i);
        }
        JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }
    else
    { 
        UnityEngine.GUIStyle[] arg0 = JSDataExchangeMgr.GetJSArg<UnityEngine.GUIStyle[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new UnityEngine.GUIStyle[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        _this.customStyles = arg0;
    }
}
static void GUISkin_settings(JSVCall vc)
{
        UnityEngine.GUISkin _this = (UnityEngine.GUISkin)vc.csObj;
        var result = _this.settings;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}

// methods

static bool GUISkin_FindStyle__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.GUISkin)vc.csObj).FindStyle(arg0));
    }

    return true;
}

static bool GUISkin_GetEnumerator(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.GUISkin)vc.csObj).GetEnumerator());
    }

    return true;
}

static bool GUISkin_GetStyle__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.GUISkin)vc.csObj).GetStyle(arg0));
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.GUISkin);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        GUISkin_font,
        GUISkin_box,
        GUISkin_label,
        GUISkin_textField,
        GUISkin_textArea,
        GUISkin_button,
        GUISkin_toggle,
        GUISkin_window,
        GUISkin_horizontalSlider,
        GUISkin_horizontalSliderThumb,
        GUISkin_verticalSlider,
        GUISkin_verticalSliderThumb,
        GUISkin_horizontalScrollbar,
        GUISkin_horizontalScrollbarThumb,
        GUISkin_horizontalScrollbarLeftButton,
        GUISkin_horizontalScrollbarRightButton,
        GUISkin_verticalScrollbar,
        GUISkin_verticalScrollbarThumb,
        GUISkin_verticalScrollbarUpButton,
        GUISkin_verticalScrollbarDownButton,
        GUISkin_scrollView,
        GUISkin_customStyles,
        GUISkin_settings,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(GUISkin_GUISkin1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(GUISkin_FindStyle__String, "FindStyle"),
        new JSMgr.MethodCallBackInfo(GUISkin_GetEnumerator, "GetEnumerator"),
        new JSMgr.MethodCallBackInfo(GUISkin_GetStyle__String, "GetStyle"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
