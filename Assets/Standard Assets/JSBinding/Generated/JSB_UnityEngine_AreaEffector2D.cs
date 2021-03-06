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

public class JSB_UnityEngine_AreaEffector2D
{

////////////////////// AreaEffector2D ///////////////////////////////////////
// constructors

static bool AreaEffector2D_AreaEffector2D1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.AreaEffector2D());
    }

    return true;
}

// fields

// properties
static void AreaEffector2D_forceAngle(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AreaEffector2D _this = (UnityEngine.AreaEffector2D)vc.csObj;
        var result = _this.forceAngle;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.AreaEffector2D _this = (UnityEngine.AreaEffector2D)vc.csObj;
        _this.forceAngle = arg0;
    }
}
static void AreaEffector2D_useGlobalAngle(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AreaEffector2D _this = (UnityEngine.AreaEffector2D)vc.csObj;
        var result = _this.useGlobalAngle;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.AreaEffector2D _this = (UnityEngine.AreaEffector2D)vc.csObj;
        _this.useGlobalAngle = arg0;
    }
}
static void AreaEffector2D_forceMagnitude(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AreaEffector2D _this = (UnityEngine.AreaEffector2D)vc.csObj;
        var result = _this.forceMagnitude;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.AreaEffector2D _this = (UnityEngine.AreaEffector2D)vc.csObj;
        _this.forceMagnitude = arg0;
    }
}
static void AreaEffector2D_forceVariation(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AreaEffector2D _this = (UnityEngine.AreaEffector2D)vc.csObj;
        var result = _this.forceVariation;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.AreaEffector2D _this = (UnityEngine.AreaEffector2D)vc.csObj;
        _this.forceVariation = arg0;
    }
}
static void AreaEffector2D_drag(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AreaEffector2D _this = (UnityEngine.AreaEffector2D)vc.csObj;
        var result = _this.drag;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.AreaEffector2D _this = (UnityEngine.AreaEffector2D)vc.csObj;
        _this.drag = arg0;
    }
}
static void AreaEffector2D_angularDrag(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AreaEffector2D _this = (UnityEngine.AreaEffector2D)vc.csObj;
        var result = _this.angularDrag;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.AreaEffector2D _this = (UnityEngine.AreaEffector2D)vc.csObj;
        _this.angularDrag = arg0;
    }
}
static void AreaEffector2D_forceTarget(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.AreaEffector2D _this = (UnityEngine.AreaEffector2D)vc.csObj;
        var result = _this.forceTarget;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.EffectorSelection2D arg0 = (UnityEngine.EffectorSelection2D)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.AreaEffector2D _this = (UnityEngine.AreaEffector2D)vc.csObj;
        _this.forceTarget = arg0;
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.AreaEffector2D);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        AreaEffector2D_forceAngle,
        AreaEffector2D_useGlobalAngle,
        AreaEffector2D_forceMagnitude,
        AreaEffector2D_forceVariation,
        AreaEffector2D_drag,
        AreaEffector2D_angularDrag,
        AreaEffector2D_forceTarget,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(AreaEffector2D_AreaEffector2D1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
