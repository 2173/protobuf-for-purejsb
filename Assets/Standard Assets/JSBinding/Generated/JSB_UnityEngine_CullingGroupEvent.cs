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

public class JSB_UnityEngine_CullingGroupEvent
{

////////////////////// CullingGroupEvent ///////////////////////////////////////
// constructors
public static ConstructorID constructorID0 = new ConstructorID(null, null);

static bool CullingGroupEvent_CullingGroupEvent1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.CullingGroupEvent());
    }

    return true;
}

// fields

// properties
static void CullingGroupEvent_index(JSVCall vc)
{
        UnityEngine.CullingGroupEvent _this = (UnityEngine.CullingGroupEvent)vc.csObj;
        var result = _this.index;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
}
static void CullingGroupEvent_isVisible(JSVCall vc)
{
        UnityEngine.CullingGroupEvent _this = (UnityEngine.CullingGroupEvent)vc.csObj;
        var result = _this.isVisible;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void CullingGroupEvent_wasVisible(JSVCall vc)
{
        UnityEngine.CullingGroupEvent _this = (UnityEngine.CullingGroupEvent)vc.csObj;
        var result = _this.wasVisible;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void CullingGroupEvent_hasBecomeVisible(JSVCall vc)
{
        UnityEngine.CullingGroupEvent _this = (UnityEngine.CullingGroupEvent)vc.csObj;
        var result = _this.hasBecomeVisible;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void CullingGroupEvent_hasBecomeInvisible(JSVCall vc)
{
        UnityEngine.CullingGroupEvent _this = (UnityEngine.CullingGroupEvent)vc.csObj;
        var result = _this.hasBecomeInvisible;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void CullingGroupEvent_currentDistance(JSVCall vc)
{
        UnityEngine.CullingGroupEvent _this = (UnityEngine.CullingGroupEvent)vc.csObj;
        var result = _this.currentDistance;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
}
static void CullingGroupEvent_previousDistance(JSVCall vc)
{
        UnityEngine.CullingGroupEvent _this = (UnityEngine.CullingGroupEvent)vc.csObj;
        var result = _this.previousDistance;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.CullingGroupEvent);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        CullingGroupEvent_index,
        CullingGroupEvent_isVisible,
        CullingGroupEvent_wasVisible,
        CullingGroupEvent_hasBecomeVisible,
        CullingGroupEvent_hasBecomeInvisible,
        CullingGroupEvent_currentDistance,
        CullingGroupEvent_previousDistance,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(CullingGroupEvent_CullingGroupEvent1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
