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

public class JSB_UnityEngine_Ray2D
{

////////////////////// Ray2D ///////////////////////////////////////
// constructors
public static ConstructorID constructorID0 = new ConstructorID(null, null);

static bool Ray2D_Ray2D1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.Ray2D());
    }

    return true;
}

static bool Ray2D_Ray2D2(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 2)
    {
        UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSApi.getVector2S((int)JSApi.GetType.Arg);
        UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSApi.getVector2S((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.Ray2D(arg0, arg1));
    }

    return true;
}

// fields

// properties
static void Ray2D_origin(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Ray2D _this = (UnityEngine.Ray2D)vc.csObj;
        var result = _this.origin;
                JSApi.setVector2S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSApi.getVector2S((int)JSApi.GetType.Arg);
        UnityEngine.Ray2D _this = (UnityEngine.Ray2D)vc.csObj;
        _this.origin = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Ray2D_direction(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Ray2D _this = (UnityEngine.Ray2D)vc.csObj;
        var result = _this.direction;
                JSApi.setVector2S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSApi.getVector2S((int)JSApi.GetType.Arg);
        UnityEngine.Ray2D _this = (UnityEngine.Ray2D)vc.csObj;
        _this.direction = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}

// methods

static bool Ray2D_GetPoint__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
UnityEngine.Ray2D argThis = (UnityEngine.Ray2D)vc.csObj;                JSApi.setVector2S((int)JSApi.SetType.Rval, argThis.GetPoint(arg0));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Ray2D_ToString__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
UnityEngine.Ray2D argThis = (UnityEngine.Ray2D)vc.csObj;                JSApi.setStringS((int)JSApi.SetType.Rval, argThis.ToString(arg0));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Ray2D_ToString(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
UnityEngine.Ray2D argThis = (UnityEngine.Ray2D)vc.csObj;                JSApi.setStringS((int)JSApi.SetType.Rval, argThis.ToString());
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.Ray2D);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        Ray2D_origin,
        Ray2D_direction,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(Ray2D_Ray2D1, ".ctor"),
        new JSMgr.MethodCallBackInfo(Ray2D_Ray2D2, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(Ray2D_GetPoint__Single, "GetPoint"),
        new JSMgr.MethodCallBackInfo(Ray2D_ToString__String, "ToString"),
        new JSMgr.MethodCallBackInfo(Ray2D_ToString, "ToString"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
