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

public class JSB_UnityEngine_AnimationClip
{

////////////////////// AnimationClip ///////////////////////////////////////
// constructors

static bool AnimationClip_AnimationClip1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.AnimationClip());
    }

    return true;
}

// fields

// properties
static void AnimationClip_length(JSVCall vc)
{
        UnityEngine.AnimationClip _this = (UnityEngine.AnimationClip)vc.csObj;
        var result = _this.length;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
}
static void AnimationClip_frameRate(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AnimationClip _this = (UnityEngine.AnimationClip)vc.csObj;
        var result = _this.frameRate;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.AnimationClip _this = (UnityEngine.AnimationClip)vc.csObj;
        _this.frameRate = arg0;
    }
}
static void AnimationClip_wrapMode(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AnimationClip _this = (UnityEngine.AnimationClip)vc.csObj;
        var result = _this.wrapMode;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.WrapMode arg0 = (UnityEngine.WrapMode)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.AnimationClip _this = (UnityEngine.AnimationClip)vc.csObj;
        _this.wrapMode = arg0;
    }
}
static void AnimationClip_localBounds(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AnimationClip _this = (UnityEngine.AnimationClip)vc.csObj;
        var result = _this.localBounds;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Bounds arg0 = (UnityEngine.Bounds)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.AnimationClip _this = (UnityEngine.AnimationClip)vc.csObj;
        _this.localBounds = arg0;
    }
}
static void AnimationClip_legacy(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AnimationClip _this = (UnityEngine.AnimationClip)vc.csObj;
        var result = _this.legacy;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.AnimationClip _this = (UnityEngine.AnimationClip)vc.csObj;
        _this.legacy = arg0;
    }
}
static void AnimationClip_humanMotion(JSVCall vc)
{
        UnityEngine.AnimationClip _this = (UnityEngine.AnimationClip)vc.csObj;
        var result = _this.humanMotion;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void AnimationClip_events(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AnimationClip _this = (UnityEngine.AnimationClip)vc.csObj;
        var result = _this.events;
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
        UnityEngine.AnimationEvent[] arg0 = JSDataExchangeMgr.GetJSArg<UnityEngine.AnimationEvent[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new UnityEngine.AnimationEvent[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (UnityEngine.AnimationEvent)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        UnityEngine.AnimationClip _this = (UnityEngine.AnimationClip)vc.csObj;
        _this.events = arg0;
    }
}

// methods

static bool AnimationClip_AddEvent__AnimationEvent(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.AnimationEvent arg0 = (UnityEngine.AnimationEvent)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        ((UnityEngine.AnimationClip)vc.csObj).AddEvent(arg0);
    }

    return true;
}

static bool AnimationClip_ClearCurves(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        ((UnityEngine.AnimationClip)vc.csObj).ClearCurves();
    }

    return true;
}

static bool AnimationClip_EnsureQuaternionContinuity(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        ((UnityEngine.AnimationClip)vc.csObj).EnsureQuaternionContinuity();
    }

    return true;
}

static bool AnimationClip_SampleAnimation__GameObject__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        UnityEngine.GameObject arg0 = (UnityEngine.GameObject)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        ((UnityEngine.AnimationClip)vc.csObj).SampleAnimation(arg0, arg1);
    }

    return true;
}

static bool AnimationClip_SetCurve__String__Type__String__AnimationCurve(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 4) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Type arg1 = (System.Type)JSDataExchangeMgr.GetTypeByJsParam((int)JSApi.GetType.Arg);
        System.String arg2 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        UnityEngine.AnimationCurve arg3 = (UnityEngine.AnimationCurve)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        ((UnityEngine.AnimationClip)vc.csObj).SetCurve(arg0, arg1, arg2, arg3);
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.AnimationClip);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        AnimationClip_length,
        AnimationClip_frameRate,
        AnimationClip_wrapMode,
        AnimationClip_localBounds,
        AnimationClip_legacy,
        AnimationClip_humanMotion,
        AnimationClip_events,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(AnimationClip_AnimationClip1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(AnimationClip_AddEvent__AnimationEvent, "AddEvent"),
        new JSMgr.MethodCallBackInfo(AnimationClip_ClearCurves, "ClearCurves"),
        new JSMgr.MethodCallBackInfo(AnimationClip_EnsureQuaternionContinuity, "EnsureQuaternionContinuity"),
        new JSMgr.MethodCallBackInfo(AnimationClip_SampleAnimation__GameObject__Single, "SampleAnimation"),
        new JSMgr.MethodCallBackInfo(AnimationClip_SetCurve__String__Type__String__AnimationCurve, "SetCurve"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
