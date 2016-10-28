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

public class JSB_UnityEngine_SurfaceEffector2D
{

////////////////////// SurfaceEffector2D ///////////////////////////////////////
// constructors

static bool SurfaceEffector2D_SurfaceEffector2D1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.SurfaceEffector2D());
    }

    return true;
}

// fields

// properties
static void SurfaceEffector2D_speed(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.SurfaceEffector2D _this = (UnityEngine.SurfaceEffector2D)vc.csObj;
        var result = _this.speed;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.SurfaceEffector2D _this = (UnityEngine.SurfaceEffector2D)vc.csObj;
        _this.speed = arg0;
    }
}
static void SurfaceEffector2D_speedVariation(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.SurfaceEffector2D _this = (UnityEngine.SurfaceEffector2D)vc.csObj;
        var result = _this.speedVariation;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.SurfaceEffector2D _this = (UnityEngine.SurfaceEffector2D)vc.csObj;
        _this.speedVariation = arg0;
    }
}
static void SurfaceEffector2D_forceScale(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.SurfaceEffector2D _this = (UnityEngine.SurfaceEffector2D)vc.csObj;
        var result = _this.forceScale;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.SurfaceEffector2D _this = (UnityEngine.SurfaceEffector2D)vc.csObj;
        _this.forceScale = arg0;
    }
}
static void SurfaceEffector2D_useContactForce(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.SurfaceEffector2D _this = (UnityEngine.SurfaceEffector2D)vc.csObj;
        var result = _this.useContactForce;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.SurfaceEffector2D _this = (UnityEngine.SurfaceEffector2D)vc.csObj;
        _this.useContactForce = arg0;
    }
}
static void SurfaceEffector2D_useFriction(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.SurfaceEffector2D _this = (UnityEngine.SurfaceEffector2D)vc.csObj;
        var result = _this.useFriction;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.SurfaceEffector2D _this = (UnityEngine.SurfaceEffector2D)vc.csObj;
        _this.useFriction = arg0;
    }
}
static void SurfaceEffector2D_useBounce(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.SurfaceEffector2D _this = (UnityEngine.SurfaceEffector2D)vc.csObj;
        var result = _this.useBounce;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.SurfaceEffector2D _this = (UnityEngine.SurfaceEffector2D)vc.csObj;
        _this.useBounce = arg0;
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.SurfaceEffector2D);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        SurfaceEffector2D_speed,
        SurfaceEffector2D_speedVariation,
        SurfaceEffector2D_forceScale,
        SurfaceEffector2D_useContactForce,
        SurfaceEffector2D_useFriction,
        SurfaceEffector2D_useBounce,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(SurfaceEffector2D_SurfaceEffector2D1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
