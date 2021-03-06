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

public class JSB_UnityEngine_ParticleSystem_EmitParams
{

////////////////////// EmitParams ///////////////////////////////////////
// constructors
public static ConstructorID constructorID0 = new ConstructorID(null, null);

static bool EmitParams_EmitParams1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.ParticleSystem.EmitParams());
    }

    return true;
}

// fields

// properties
static void EmitParams_position(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.EmitParams _this = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;
        var result = _this.position;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.EmitParams _this = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;
        _this.position = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void EmitParams_velocity(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.EmitParams _this = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;
        var result = _this.velocity;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.EmitParams _this = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;
        _this.velocity = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void EmitParams_startLifetime(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.EmitParams _this = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;
        var result = _this.startLifetime;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.EmitParams _this = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;
        _this.startLifetime = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void EmitParams_startSize(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.EmitParams _this = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;
        var result = _this.startSize;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.EmitParams _this = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;
        _this.startSize = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void EmitParams_axisOfRotation(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.EmitParams _this = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;
        var result = _this.axisOfRotation;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.EmitParams _this = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;
        _this.axisOfRotation = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void EmitParams_rotation(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.EmitParams _this = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;
        var result = _this.rotation;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.EmitParams _this = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;
        _this.rotation = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void EmitParams_rotation3D(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.EmitParams _this = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;
        var result = _this.rotation3D;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.EmitParams _this = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;
        _this.rotation3D = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void EmitParams_angularVelocity(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.EmitParams _this = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;
        var result = _this.angularVelocity;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.EmitParams _this = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;
        _this.angularVelocity = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void EmitParams_angularVelocity3D(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.EmitParams _this = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;
        var result = _this.angularVelocity3D;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.EmitParams _this = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;
        _this.angularVelocity3D = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void EmitParams_startColor(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.EmitParams _this = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;
        var result = _this.startColor;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Color32 arg0 = (UnityEngine.Color32)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.EmitParams _this = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;
        _this.startColor = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void EmitParams_randomSeed(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.EmitParams _this = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;
        var result = _this.randomSeed;
                JSApi.setUInt32((int)JSApi.SetType.Rval, (System.UInt32)(result));
    }
    else
    { 
        System.UInt32 arg0 = (System.UInt32)JSApi.getUInt32((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.EmitParams _this = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;
        _this.randomSeed = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}

// methods

static bool EmitParams_ResetAngularVelocity(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
UnityEngine.ParticleSystem.EmitParams argThis = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;        argThis.ResetAngularVelocity();
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool EmitParams_ResetAxisOfRotation(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
UnityEngine.ParticleSystem.EmitParams argThis = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;        argThis.ResetAxisOfRotation();
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool EmitParams_ResetPosition(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
UnityEngine.ParticleSystem.EmitParams argThis = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;        argThis.ResetPosition();
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool EmitParams_ResetRandomSeed(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
UnityEngine.ParticleSystem.EmitParams argThis = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;        argThis.ResetRandomSeed();
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool EmitParams_ResetRotation(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
UnityEngine.ParticleSystem.EmitParams argThis = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;        argThis.ResetRotation();
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool EmitParams_ResetStartColor(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
UnityEngine.ParticleSystem.EmitParams argThis = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;        argThis.ResetStartColor();
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool EmitParams_ResetStartLifetime(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
UnityEngine.ParticleSystem.EmitParams argThis = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;        argThis.ResetStartLifetime();
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool EmitParams_ResetStartSize(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
UnityEngine.ParticleSystem.EmitParams argThis = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;        argThis.ResetStartSize();
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool EmitParams_ResetVelocity(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
UnityEngine.ParticleSystem.EmitParams argThis = (UnityEngine.ParticleSystem.EmitParams)vc.csObj;        argThis.ResetVelocity();
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.ParticleSystem.EmitParams);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        EmitParams_position,
        EmitParams_velocity,
        EmitParams_startLifetime,
        EmitParams_startSize,
        EmitParams_axisOfRotation,
        EmitParams_rotation,
        EmitParams_rotation3D,
        EmitParams_angularVelocity,
        EmitParams_angularVelocity3D,
        EmitParams_startColor,
        EmitParams_randomSeed,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(EmitParams_EmitParams1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(EmitParams_ResetAngularVelocity, "ResetAngularVelocity"),
        new JSMgr.MethodCallBackInfo(EmitParams_ResetAxisOfRotation, "ResetAxisOfRotation"),
        new JSMgr.MethodCallBackInfo(EmitParams_ResetPosition, "ResetPosition"),
        new JSMgr.MethodCallBackInfo(EmitParams_ResetRandomSeed, "ResetRandomSeed"),
        new JSMgr.MethodCallBackInfo(EmitParams_ResetRotation, "ResetRotation"),
        new JSMgr.MethodCallBackInfo(EmitParams_ResetStartColor, "ResetStartColor"),
        new JSMgr.MethodCallBackInfo(EmitParams_ResetStartLifetime, "ResetStartLifetime"),
        new JSMgr.MethodCallBackInfo(EmitParams_ResetStartSize, "ResetStartSize"),
        new JSMgr.MethodCallBackInfo(EmitParams_ResetVelocity, "ResetVelocity"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
