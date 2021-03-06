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

public class JSB_UnityEngine_ConstantForce2D
{

////////////////////// ConstantForce2D ///////////////////////////////////////
// constructors

static bool ConstantForce2D_ConstantForce2D1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.ConstantForce2D());
    }

    return true;
}

// fields

// properties
static void ConstantForce2D_force(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConstantForce2D _this = (UnityEngine.ConstantForce2D)vc.csObj;
        var result = _this.force;
                JSApi.setVector2S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSApi.getVector2S((int)JSApi.GetType.Arg);
        UnityEngine.ConstantForce2D _this = (UnityEngine.ConstantForce2D)vc.csObj;
        _this.force = arg0;
    }
}
static void ConstantForce2D_relativeForce(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConstantForce2D _this = (UnityEngine.ConstantForce2D)vc.csObj;
        var result = _this.relativeForce;
                JSApi.setVector2S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSApi.getVector2S((int)JSApi.GetType.Arg);
        UnityEngine.ConstantForce2D _this = (UnityEngine.ConstantForce2D)vc.csObj;
        _this.relativeForce = arg0;
    }
}
static void ConstantForce2D_torque(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConstantForce2D _this = (UnityEngine.ConstantForce2D)vc.csObj;
        var result = _this.torque;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.ConstantForce2D _this = (UnityEngine.ConstantForce2D)vc.csObj;
        _this.torque = arg0;
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.ConstantForce2D);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        ConstantForce2D_force,
        ConstantForce2D_relativeForce,
        ConstantForce2D_torque,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(ConstantForce2D_ConstantForce2D1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
