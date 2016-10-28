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

public class JSB_UnityEngine_BuoyancyEffector2D
{

////////////////////// BuoyancyEffector2D ///////////////////////////////////////
// constructors

static bool BuoyancyEffector2D_BuoyancyEffector2D1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.BuoyancyEffector2D());
    }

    return true;
}

// fields

// properties
static void BuoyancyEffector2D_surfaceLevel(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.BuoyancyEffector2D _this = (UnityEngine.BuoyancyEffector2D)vc.csObj;
        var result = _this.surfaceLevel;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.BuoyancyEffector2D _this = (UnityEngine.BuoyancyEffector2D)vc.csObj;
        _this.surfaceLevel = arg0;
    }
}
static void BuoyancyEffector2D_density(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.BuoyancyEffector2D _this = (UnityEngine.BuoyancyEffector2D)vc.csObj;
        var result = _this.density;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.BuoyancyEffector2D _this = (UnityEngine.BuoyancyEffector2D)vc.csObj;
        _this.density = arg0;
    }
}
static void BuoyancyEffector2D_linearDrag(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.BuoyancyEffector2D _this = (UnityEngine.BuoyancyEffector2D)vc.csObj;
        var result = _this.linearDrag;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.BuoyancyEffector2D _this = (UnityEngine.BuoyancyEffector2D)vc.csObj;
        _this.linearDrag = arg0;
    }
}
static void BuoyancyEffector2D_angularDrag(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.BuoyancyEffector2D _this = (UnityEngine.BuoyancyEffector2D)vc.csObj;
        var result = _this.angularDrag;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.BuoyancyEffector2D _this = (UnityEngine.BuoyancyEffector2D)vc.csObj;
        _this.angularDrag = arg0;
    }
}
static void BuoyancyEffector2D_flowAngle(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.BuoyancyEffector2D _this = (UnityEngine.BuoyancyEffector2D)vc.csObj;
        var result = _this.flowAngle;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.BuoyancyEffector2D _this = (UnityEngine.BuoyancyEffector2D)vc.csObj;
        _this.flowAngle = arg0;
    }
}
static void BuoyancyEffector2D_flowMagnitude(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.BuoyancyEffector2D _this = (UnityEngine.BuoyancyEffector2D)vc.csObj;
        var result = _this.flowMagnitude;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.BuoyancyEffector2D _this = (UnityEngine.BuoyancyEffector2D)vc.csObj;
        _this.flowMagnitude = arg0;
    }
}
static void BuoyancyEffector2D_flowVariation(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.BuoyancyEffector2D _this = (UnityEngine.BuoyancyEffector2D)vc.csObj;
        var result = _this.flowVariation;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.BuoyancyEffector2D _this = (UnityEngine.BuoyancyEffector2D)vc.csObj;
        _this.flowVariation = arg0;
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.BuoyancyEffector2D);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        BuoyancyEffector2D_surfaceLevel,
        BuoyancyEffector2D_density,
        BuoyancyEffector2D_linearDrag,
        BuoyancyEffector2D_angularDrag,
        BuoyancyEffector2D_flowAngle,
        BuoyancyEffector2D_flowMagnitude,
        BuoyancyEffector2D_flowVariation,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(BuoyancyEffector2D_BuoyancyEffector2D1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
