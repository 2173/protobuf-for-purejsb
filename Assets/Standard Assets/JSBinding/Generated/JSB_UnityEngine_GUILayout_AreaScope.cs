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

public class JSB_UnityEngine_GUILayout_AreaScope
{

////////////////////// AreaScope ///////////////////////////////////////
// constructors

static bool AreaScope_AreaScope1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 1)
    {
        UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.GUILayout.AreaScope(arg0));
    }

    return true;
}

static bool AreaScope_AreaScope2(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 2)
    {
        UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.String arg1 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.GUILayout.AreaScope(arg0, arg1));
    }

    return true;
}

static bool AreaScope_AreaScope3(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 2)
    {
        UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Texture arg1 = (UnityEngine.Texture)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.GUILayout.AreaScope(arg0, arg1));
    }

    return true;
}

static bool AreaScope_AreaScope4(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 2)
    {
        UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIContent arg1 = (UnityEngine.GUIContent)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.GUILayout.AreaScope(arg0, arg1));
    }

    return true;
}

static bool AreaScope_AreaScope5(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 3)
    {
        UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.String arg1 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.GUILayout.AreaScope(arg0, arg1, arg2));
    }

    return true;
}

static bool AreaScope_AreaScope6(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 3)
    {
        UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Texture arg1 = (UnityEngine.Texture)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.GUILayout.AreaScope(arg0, arg1, arg2));
    }

    return true;
}

static bool AreaScope_AreaScope7(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 3)
    {
        UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIContent arg1 = (UnityEngine.GUIContent)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.GUILayout.AreaScope(arg0, arg1, arg2));
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
    ci.type = typeof(UnityEngine.GUILayout.AreaScope);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(AreaScope_AreaScope1, ".ctor"),
        new JSMgr.MethodCallBackInfo(AreaScope_AreaScope2, ".ctor"),
        new JSMgr.MethodCallBackInfo(AreaScope_AreaScope3, ".ctor"),
        new JSMgr.MethodCallBackInfo(AreaScope_AreaScope4, ".ctor"),
        new JSMgr.MethodCallBackInfo(AreaScope_AreaScope5, ".ctor"),
        new JSMgr.MethodCallBackInfo(AreaScope_AreaScope6, ".ctor"),
        new JSMgr.MethodCallBackInfo(AreaScope_AreaScope7, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
