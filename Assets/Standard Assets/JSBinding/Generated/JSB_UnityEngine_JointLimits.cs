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

public class JSB_UnityEngine_JointLimits
{

////////////////////// JointLimits ///////////////////////////////////////
// constructors
public static ConstructorID constructorID0 = new ConstructorID(null, null);

static bool JointLimits_JointLimits1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.JointLimits());
    }

    return true;
}

// fields

// properties
static void JointLimits_min(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.JointLimits _this = (UnityEngine.JointLimits)vc.csObj;
        var result = _this.min;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.JointLimits _this = (UnityEngine.JointLimits)vc.csObj;
        _this.min = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void JointLimits_max(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.JointLimits _this = (UnityEngine.JointLimits)vc.csObj;
        var result = _this.max;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.JointLimits _this = (UnityEngine.JointLimits)vc.csObj;
        _this.max = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void JointLimits_bounciness(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.JointLimits _this = (UnityEngine.JointLimits)vc.csObj;
        var result = _this.bounciness;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.JointLimits _this = (UnityEngine.JointLimits)vc.csObj;
        _this.bounciness = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void JointLimits_bounceMinVelocity(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.JointLimits _this = (UnityEngine.JointLimits)vc.csObj;
        var result = _this.bounceMinVelocity;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.JointLimits _this = (UnityEngine.JointLimits)vc.csObj;
        _this.bounceMinVelocity = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void JointLimits_contactDistance(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.JointLimits _this = (UnityEngine.JointLimits)vc.csObj;
        var result = _this.contactDistance;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.JointLimits _this = (UnityEngine.JointLimits)vc.csObj;
        _this.contactDistance = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.JointLimits);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        JointLimits_min,
        JointLimits_max,
        JointLimits_bounciness,
        JointLimits_bounceMinVelocity,
        JointLimits_contactDistance,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(JointLimits_JointLimits1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
