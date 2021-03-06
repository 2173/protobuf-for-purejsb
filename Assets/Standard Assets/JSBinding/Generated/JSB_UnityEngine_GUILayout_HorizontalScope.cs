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

public class JSB_UnityEngine_GUILayout_HorizontalScope
{

////////////////////// HorizontalScope ///////////////////////////////////////
// constructors

static bool HorizontalScope_HorizontalScope1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 1)
    {
        UnityEngine.GUILayoutOption[] arg0 = JSDataExchangeMgr.GetJSArg<UnityEngine.GUILayoutOption[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new UnityEngine.GUILayoutOption[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (UnityEngine.GUILayoutOption)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        JSMgr.addJSCSRel(_this, new UnityEngine.GUILayout.HorizontalScope(arg0));
    }

    return true;
}

static bool HorizontalScope_HorizontalScope2(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 2)
    {
        UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUILayoutOption[] arg1 = JSDataExchangeMgr.GetJSArg<UnityEngine.GUILayoutOption[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new UnityEngine.GUILayoutOption[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (UnityEngine.GUILayoutOption)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        JSMgr.addJSCSRel(_this, new UnityEngine.GUILayout.HorizontalScope(arg0, arg1));
    }

    return true;
}

static bool HorizontalScope_HorizontalScope3(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 3)
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUILayoutOption[] arg2 = JSDataExchangeMgr.GetJSArg<UnityEngine.GUILayoutOption[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new UnityEngine.GUILayoutOption[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (UnityEngine.GUILayoutOption)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        JSMgr.addJSCSRel(_this, new UnityEngine.GUILayout.HorizontalScope(arg0, arg1, arg2));
    }

    return true;
}

static bool HorizontalScope_HorizontalScope4(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 3)
    {
        UnityEngine.Texture arg0 = (UnityEngine.Texture)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUILayoutOption[] arg2 = JSDataExchangeMgr.GetJSArg<UnityEngine.GUILayoutOption[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new UnityEngine.GUILayoutOption[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (UnityEngine.GUILayoutOption)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        JSMgr.addJSCSRel(_this, new UnityEngine.GUILayout.HorizontalScope(arg0, arg1, arg2));
    }

    return true;
}

static bool HorizontalScope_HorizontalScope5(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 3)
    {
        UnityEngine.GUIContent arg0 = (UnityEngine.GUIContent)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUILayoutOption[] arg2 = JSDataExchangeMgr.GetJSArg<UnityEngine.GUILayoutOption[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new UnityEngine.GUILayoutOption[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (UnityEngine.GUILayoutOption)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        JSMgr.addJSCSRel(_this, new UnityEngine.GUILayout.HorizontalScope(arg0, arg1, arg2));
    }

    return true;
}

// fields

// properties

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.GUILayout.HorizontalScope);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(HorizontalScope_HorizontalScope1, ".ctor"),
        new JSMgr.MethodCallBackInfo(HorizontalScope_HorizontalScope2, ".ctor"),
        new JSMgr.MethodCallBackInfo(HorizontalScope_HorizontalScope3, ".ctor"),
        new JSMgr.MethodCallBackInfo(HorizontalScope_HorizontalScope4, ".ctor"),
        new JSMgr.MethodCallBackInfo(HorizontalScope_HorizontalScope5, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
