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

public class JSB_UnityEngine_CharacterJoint
{

////////////////////// CharacterJoint ///////////////////////////////////////
// constructors

static bool CharacterJoint_CharacterJoint1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.CharacterJoint());
    }

    return true;
}

// fields

// properties
static void CharacterJoint_swingAxis(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.CharacterJoint _this = (UnityEngine.CharacterJoint)vc.csObj;
        var result = _this.swingAxis;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.CharacterJoint _this = (UnityEngine.CharacterJoint)vc.csObj;
        _this.swingAxis = arg0;
    }
}
static void CharacterJoint_twistLimitSpring(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.CharacterJoint _this = (UnityEngine.CharacterJoint)vc.csObj;
        var result = _this.twistLimitSpring;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.SoftJointLimitSpring arg0 = (UnityEngine.SoftJointLimitSpring)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.CharacterJoint _this = (UnityEngine.CharacterJoint)vc.csObj;
        _this.twistLimitSpring = arg0;
    }
}
static void CharacterJoint_swingLimitSpring(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.CharacterJoint _this = (UnityEngine.CharacterJoint)vc.csObj;
        var result = _this.swingLimitSpring;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.SoftJointLimitSpring arg0 = (UnityEngine.SoftJointLimitSpring)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.CharacterJoint _this = (UnityEngine.CharacterJoint)vc.csObj;
        _this.swingLimitSpring = arg0;
    }
}
static void CharacterJoint_lowTwistLimit(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.CharacterJoint _this = (UnityEngine.CharacterJoint)vc.csObj;
        var result = _this.lowTwistLimit;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.SoftJointLimit arg0 = (UnityEngine.SoftJointLimit)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.CharacterJoint _this = (UnityEngine.CharacterJoint)vc.csObj;
        _this.lowTwistLimit = arg0;
    }
}
static void CharacterJoint_highTwistLimit(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.CharacterJoint _this = (UnityEngine.CharacterJoint)vc.csObj;
        var result = _this.highTwistLimit;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.SoftJointLimit arg0 = (UnityEngine.SoftJointLimit)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.CharacterJoint _this = (UnityEngine.CharacterJoint)vc.csObj;
        _this.highTwistLimit = arg0;
    }
}
static void CharacterJoint_swing1Limit(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.CharacterJoint _this = (UnityEngine.CharacterJoint)vc.csObj;
        var result = _this.swing1Limit;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.SoftJointLimit arg0 = (UnityEngine.SoftJointLimit)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.CharacterJoint _this = (UnityEngine.CharacterJoint)vc.csObj;
        _this.swing1Limit = arg0;
    }
}
static void CharacterJoint_swing2Limit(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.CharacterJoint _this = (UnityEngine.CharacterJoint)vc.csObj;
        var result = _this.swing2Limit;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.SoftJointLimit arg0 = (UnityEngine.SoftJointLimit)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.CharacterJoint _this = (UnityEngine.CharacterJoint)vc.csObj;
        _this.swing2Limit = arg0;
    }
}
static void CharacterJoint_enableProjection(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.CharacterJoint _this = (UnityEngine.CharacterJoint)vc.csObj;
        var result = _this.enableProjection;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.CharacterJoint _this = (UnityEngine.CharacterJoint)vc.csObj;
        _this.enableProjection = arg0;
    }
}
static void CharacterJoint_projectionDistance(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.CharacterJoint _this = (UnityEngine.CharacterJoint)vc.csObj;
        var result = _this.projectionDistance;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.CharacterJoint _this = (UnityEngine.CharacterJoint)vc.csObj;
        _this.projectionDistance = arg0;
    }
}
static void CharacterJoint_projectionAngle(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.CharacterJoint _this = (UnityEngine.CharacterJoint)vc.csObj;
        var result = _this.projectionAngle;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.CharacterJoint _this = (UnityEngine.CharacterJoint)vc.csObj;
        _this.projectionAngle = arg0;
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.CharacterJoint);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        CharacterJoint_swingAxis,
        CharacterJoint_twistLimitSpring,
        CharacterJoint_swingLimitSpring,
        CharacterJoint_lowTwistLimit,
        CharacterJoint_highTwistLimit,
        CharacterJoint_swing1Limit,
        CharacterJoint_swing2Limit,
        CharacterJoint_enableProjection,
        CharacterJoint_projectionDistance,
        CharacterJoint_projectionAngle,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(CharacterJoint_CharacterJoint1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
