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

public class JSB_UnityEngine_AsyncOperation
{

////////////////////// AsyncOperation ///////////////////////////////////////
// constructors

static bool AsyncOperation_AsyncOperation1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.AsyncOperation());
    }

    return true;
}

// fields

// properties
static void AsyncOperation_isDone(JSVCall vc)
{
        UnityEngine.AsyncOperation _this = (UnityEngine.AsyncOperation)vc.csObj;
        var result = _this.isDone;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void AsyncOperation_progress(JSVCall vc)
{
        UnityEngine.AsyncOperation _this = (UnityEngine.AsyncOperation)vc.csObj;
        var result = _this.progress;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
}
static void AsyncOperation_priority(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AsyncOperation _this = (UnityEngine.AsyncOperation)vc.csObj;
        var result = _this.priority;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else
    { 
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.AsyncOperation _this = (UnityEngine.AsyncOperation)vc.csObj;
        _this.priority = arg0;
    }
}
static void AsyncOperation_allowSceneActivation(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AsyncOperation _this = (UnityEngine.AsyncOperation)vc.csObj;
        var result = _this.allowSceneActivation;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.AsyncOperation _this = (UnityEngine.AsyncOperation)vc.csObj;
        _this.allowSceneActivation = arg0;
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.AsyncOperation);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        AsyncOperation_isDone,
        AsyncOperation_progress,
        AsyncOperation_priority,
        AsyncOperation_allowSceneActivation,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(AsyncOperation_AsyncOperation1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
