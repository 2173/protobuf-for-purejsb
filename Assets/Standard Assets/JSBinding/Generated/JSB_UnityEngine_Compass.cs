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

public class JSB_UnityEngine_Compass
{

////////////////////// Compass ///////////////////////////////////////
// constructors

static bool Compass_Compass1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.Compass());
    }

    return true;
}

// fields

// properties
static void Compass_magneticHeading(JSVCall vc)
{
        UnityEngine.Compass _this = (UnityEngine.Compass)vc.csObj;
        var result = _this.magneticHeading;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
}
static void Compass_trueHeading(JSVCall vc)
{
        UnityEngine.Compass _this = (UnityEngine.Compass)vc.csObj;
        var result = _this.trueHeading;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
}
static void Compass_headingAccuracy(JSVCall vc)
{
        UnityEngine.Compass _this = (UnityEngine.Compass)vc.csObj;
        var result = _this.headingAccuracy;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
}
static void Compass_rawVector(JSVCall vc)
{
        UnityEngine.Compass _this = (UnityEngine.Compass)vc.csObj;
        var result = _this.rawVector;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
}
static void Compass_timestamp(JSVCall vc)
{
        UnityEngine.Compass _this = (UnityEngine.Compass)vc.csObj;
        var result = _this.timestamp;
                JSApi.setDouble((int)JSApi.SetType.Rval, (System.Double)(result));
}
static void Compass_enabled(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Compass _this = (UnityEngine.Compass)vc.csObj;
        var result = _this.enabled;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.Compass _this = (UnityEngine.Compass)vc.csObj;
        _this.enabled = arg0;
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.Compass);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        Compass_magneticHeading,
        Compass_trueHeading,
        Compass_headingAccuracy,
        Compass_rawVector,
        Compass_timestamp,
        Compass_enabled,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(Compass_Compass1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}