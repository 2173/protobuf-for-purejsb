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

public class JSB_UnityEngine_ParticleSystem_RotationOverLifetimeModule
{

////////////////////// RotationOverLifetimeModule ///////////////////////////////////////
// constructors

// fields

// properties
static void RotationOverLifetimeModule_enabled(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.RotationOverLifetimeModule _this = (UnityEngine.ParticleSystem.RotationOverLifetimeModule)vc.csObj;
        var result = _this.enabled;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.RotationOverLifetimeModule _this = (UnityEngine.ParticleSystem.RotationOverLifetimeModule)vc.csObj;
        _this.enabled = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void RotationOverLifetimeModule_x(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.RotationOverLifetimeModule _this = (UnityEngine.ParticleSystem.RotationOverLifetimeModule)vc.csObj;
        var result = _this.x;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.ParticleSystem.MinMaxCurve arg0 = (UnityEngine.ParticleSystem.MinMaxCurve)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.RotationOverLifetimeModule _this = (UnityEngine.ParticleSystem.RotationOverLifetimeModule)vc.csObj;
        _this.x = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void RotationOverLifetimeModule_y(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.RotationOverLifetimeModule _this = (UnityEngine.ParticleSystem.RotationOverLifetimeModule)vc.csObj;
        var result = _this.y;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.ParticleSystem.MinMaxCurve arg0 = (UnityEngine.ParticleSystem.MinMaxCurve)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.RotationOverLifetimeModule _this = (UnityEngine.ParticleSystem.RotationOverLifetimeModule)vc.csObj;
        _this.y = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void RotationOverLifetimeModule_z(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.RotationOverLifetimeModule _this = (UnityEngine.ParticleSystem.RotationOverLifetimeModule)vc.csObj;
        var result = _this.z;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.ParticleSystem.MinMaxCurve arg0 = (UnityEngine.ParticleSystem.MinMaxCurve)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.RotationOverLifetimeModule _this = (UnityEngine.ParticleSystem.RotationOverLifetimeModule)vc.csObj;
        _this.z = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void RotationOverLifetimeModule_separateAxes(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.RotationOverLifetimeModule _this = (UnityEngine.ParticleSystem.RotationOverLifetimeModule)vc.csObj;
        var result = _this.separateAxes;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.RotationOverLifetimeModule _this = (UnityEngine.ParticleSystem.RotationOverLifetimeModule)vc.csObj;
        _this.separateAxes = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.ParticleSystem.RotationOverLifetimeModule);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        RotationOverLifetimeModule_enabled,
        RotationOverLifetimeModule_x,
        RotationOverLifetimeModule_y,
        RotationOverLifetimeModule_z,
        RotationOverLifetimeModule_separateAxes,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
