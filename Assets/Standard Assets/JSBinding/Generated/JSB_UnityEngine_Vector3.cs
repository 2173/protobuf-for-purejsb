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

public class JSB_UnityEngine_Vector3
{

////////////////////// Vector3 ///////////////////////////////////////
// constructors
public static ConstructorID constructorID0 = new ConstructorID(null, null);

static bool Vector3_Vector31(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.Vector3());
    }

    return true;
}

static bool Vector3_Vector32(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 3)
    {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Single arg2 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.Vector3(arg0, arg1, arg2));
    }

    return true;
}

static bool Vector3_Vector33(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 2)
    {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.Vector3(arg0, arg1));
    }

    return true;
}

// fields
static void Vector3_kEpsilon(JSVCall vc)
{
        var result = UnityEngine.Vector3.kEpsilon;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
}
static void Vector3_x(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.Vector3 _this = (UnityEngine.Vector3)vc.csObj;
        var result = _this.x;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 _this = (UnityEngine.Vector3)vc.csObj;
        _this.x = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Vector3_y(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.Vector3 _this = (UnityEngine.Vector3)vc.csObj;
        var result = _this.y;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 _this = (UnityEngine.Vector3)vc.csObj;
        _this.y = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Vector3_z(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.Vector3 _this = (UnityEngine.Vector3)vc.csObj;
        var result = _this.z;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 _this = (UnityEngine.Vector3)vc.csObj;
        _this.z = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}

// properties
static void Vector3_Item_Int32(JSVCall vc)
{
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
    if (vc.bGet)
    { 
        UnityEngine.Vector3 _this = (UnityEngine.Vector3)vc.csObj;
        var result = _this[arg0];
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 _this = (UnityEngine.Vector3)vc.csObj;
        _this[arg0] = arg1;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Vector3_normalized(JSVCall vc)
{
        UnityEngine.Vector3 _this = (UnityEngine.Vector3)vc.csObj;
        var result = _this.normalized;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
}
static void Vector3_magnitude(JSVCall vc)
{
        UnityEngine.Vector3 _this = (UnityEngine.Vector3)vc.csObj;
        var result = _this.magnitude;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
}
static void Vector3_sqrMagnitude(JSVCall vc)
{
        UnityEngine.Vector3 _this = (UnityEngine.Vector3)vc.csObj;
        var result = _this.sqrMagnitude;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
}
static void Vector3_zero(JSVCall vc)
{
        var result = UnityEngine.Vector3.zero;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
}
static void Vector3_one(JSVCall vc)
{
        var result = UnityEngine.Vector3.one;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
}
static void Vector3_forward(JSVCall vc)
{
        var result = UnityEngine.Vector3.forward;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
}
static void Vector3_back(JSVCall vc)
{
        var result = UnityEngine.Vector3.back;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
}
static void Vector3_up(JSVCall vc)
{
        var result = UnityEngine.Vector3.up;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
}
static void Vector3_down(JSVCall vc)
{
        var result = UnityEngine.Vector3.down;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
}
static void Vector3_left(JSVCall vc)
{
        var result = UnityEngine.Vector3.left;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
}
static void Vector3_right(JSVCall vc)
{
        var result = UnityEngine.Vector3.right;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
}

// methods

static bool Vector3_Equals__Object(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Object arg0 = (System.Object)JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
UnityEngine.Vector3 argThis = (UnityEngine.Vector3)vc.csObj;                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(argThis.Equals(arg0)));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Vector3_GetHashCode(JSVCall vc, int argc)
{
    UnityEngineManual.Vector3_GetHashCode(vc, argc);
    return true;
}

static bool Vector3_Normalize(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
UnityEngine.Vector3 argThis = (UnityEngine.Vector3)vc.csObj;        argThis.Normalize();
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Vector3_Scale__Vector3(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
UnityEngine.Vector3 argThis = (UnityEngine.Vector3)vc.csObj;        argThis.Scale(arg0);
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Vector3_Set__Single__Single__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Single arg2 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
UnityEngine.Vector3 argThis = (UnityEngine.Vector3)vc.csObj;        argThis.Set(arg0, arg1, arg2);
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Vector3_ToString__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
UnityEngine.Vector3 argThis = (UnityEngine.Vector3)vc.csObj;                JSApi.setStringS((int)JSApi.SetType.Rval, argThis.ToString(arg0));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Vector3_ToString(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
UnityEngine.Vector3 argThis = (UnityEngine.Vector3)vc.csObj;                JSApi.setStringS((int)JSApi.SetType.Rval, argThis.ToString());
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Vector3_Angle__Vector3__Vector3(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(UnityEngine.Vector3.Angle(arg0, arg1)));
    }

    return true;
}

static bool Vector3_ClampMagnitude__Vector3__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
                JSApi.setVector3S((int)JSApi.SetType.Rval, UnityEngine.Vector3.ClampMagnitude(arg0, arg1));
    }

    return true;
}

static bool Vector3_Cross__Vector3__Vector3(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
                JSApi.setVector3S((int)JSApi.SetType.Rval, UnityEngine.Vector3.Cross(arg0, arg1));
    }

    return true;
}

static bool Vector3_Distance__Vector3__Vector3(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(UnityEngine.Vector3.Distance(arg0, arg1)));
    }

    return true;
}

static bool Vector3_Dot__Vector3__Vector3(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(UnityEngine.Vector3.Dot(arg0, arg1)));
    }

    return true;
}

static bool Vector3_Lerp__Vector3__Vector3__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        System.Single arg2 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
                JSApi.setVector3S((int)JSApi.SetType.Rval, UnityEngine.Vector3.Lerp(arg0, arg1, arg2));
    }

    return true;
}

static bool Vector3_LerpUnclamped__Vector3__Vector3__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        System.Single arg2 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
                JSApi.setVector3S((int)JSApi.SetType.Rval, UnityEngine.Vector3.LerpUnclamped(arg0, arg1, arg2));
    }

    return true;
}

static bool Vector3_Magnitude__Vector3(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(UnityEngine.Vector3.Magnitude(arg0)));
    }

    return true;
}

static bool Vector3_Max__Vector3__Vector3(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
                JSApi.setVector3S((int)JSApi.SetType.Rval, UnityEngine.Vector3.Max(arg0, arg1));
    }

    return true;
}

static bool Vector3_Min__Vector3__Vector3(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
                JSApi.setVector3S((int)JSApi.SetType.Rval, UnityEngine.Vector3.Min(arg0, arg1));
    }

    return true;
}

static bool Vector3_MoveTowards__Vector3__Vector3__Single(JSVCall vc, int argc)
{
    UnityEngineManual.Vector3_MoveTowards__Vector3__Vector3__Single(vc, argc);
    return true;
}

static bool Vector3_Normalize__Vector3(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
                JSApi.setVector3S((int)JSApi.SetType.Rval, UnityEngine.Vector3.Normalize(arg0));
    }

    return true;
}

static bool Vector3_op_Addition__Vector3__Vector3(JSVCall vc, int argc)
{
    UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
    UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
            JSApi.setVector3S((int)JSApi.SetType.Rval, arg0 + arg1);
    return true;
}

static bool Vector3_op_Division__Vector3__Single(JSVCall vc, int argc)
{
    UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
    System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setVector3S((int)JSApi.SetType.Rval, arg0 / arg1);
    return true;
}

static bool Vector3_op_Equality__Vector3__Vector3(JSVCall vc, int argc)
{
    UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
    UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(arg0 == arg1));
    return true;
}

static bool Vector3_op_Inequality__Vector3__Vector3(JSVCall vc, int argc)
{
    UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
    UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(arg0 != arg1));
    return true;
}

static bool Vector3_op_Multiply__Single__Vector3(JSVCall vc, int argc)
{
    System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
    UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
            JSApi.setVector3S((int)JSApi.SetType.Rval, arg0 * arg1);
    return true;
}

static bool Vector3_op_Multiply__Vector3__Single(JSVCall vc, int argc)
{
    UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
    System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setVector3S((int)JSApi.SetType.Rval, arg0 * arg1);
    return true;
}

static bool Vector3_op_Subtraction__Vector3__Vector3(JSVCall vc, int argc)
{
    UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
    UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
            JSApi.setVector3S((int)JSApi.SetType.Rval, arg0 - arg1);
    return true;
}

static bool Vector3_op_UnaryNegation__Vector3(JSVCall vc, int argc)
{
    UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
            JSApi.setVector3S((int)JSApi.SetType.Rval, -arg0);
    return true;
}

static bool Vector3_OrthoNormalize__Vector3__Vector3__Vector3(JSVCall vc, int argc)
{
    UnityEngineManual.Vector3_OrthoNormalize__Vector3__Vector3__Vector3(vc, argc);
    return true;
}

static bool Vector3_OrthoNormalize__Vector3__Vector3(JSVCall vc, int argc)
{
    UnityEngineManual.Vector3_OrthoNormalize__Vector3__Vector3(vc, argc);
    return true;
}

static bool Vector3_Project__Vector3__Vector3(JSVCall vc, int argc)
{
    UnityEngineManual.Vector3_Project__Vector3__Vector3(vc, argc);
    return true;
}

static bool Vector3_ProjectOnPlane__Vector3__Vector3(JSVCall vc, int argc)
{
    UnityEngineManual.Vector3_ProjectOnPlane__Vector3__Vector3(vc, argc);
    return true;
}

static bool Vector3_Reflect__Vector3__Vector3(JSVCall vc, int argc)
{
    UnityEngineManual.Vector3_Reflect__Vector3__Vector3(vc, argc);
    return true;
}

static bool Vector3_RotateTowards__Vector3__Vector3__Single__Single(JSVCall vc, int argc)
{
    UnityEngineManual.Vector3_RotateTowards__Vector3__Vector3__Single__Single(vc, argc);
    return true;
}

static bool Vector3_Scale__Vector3__Vector3(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
                JSApi.setVector3S((int)JSApi.SetType.Rval, UnityEngine.Vector3.Scale(arg0, arg1));
    }

    return true;
}

static bool Vector3_Slerp__Vector3__Vector3__Single(JSVCall vc, int argc)
{
    UnityEngineManual.Vector3_Slerp__Vector3__Vector3__Single(vc, argc);
    return true;
}

static bool Vector3_SlerpUnclamped__Vector3__Vector3__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        System.Single arg2 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
                JSApi.setVector3S((int)JSApi.SetType.Rval, UnityEngine.Vector3.SlerpUnclamped(arg0, arg1, arg2));
    }

    return true;
}

static bool Vector3_SmoothDamp__Vector3__Vector3__Vector3__Single__Single__Single(JSVCall vc, int argc)
{
    UnityEngineManual.Vector3_SmoothDamp__Vector3__Vector3__Vector3__Single__Single__Single(vc, argc);
    return true;
}

static bool Vector3_SmoothDamp__Vector3__Vector3__Vector3__Single__Single(JSVCall vc, int argc)
{
    UnityEngineManual.Vector3_SmoothDamp__Vector3__Vector3__Vector3__Single__Single(vc, argc);
    return true;
}

static bool Vector3_SmoothDamp__Vector3__Vector3__Vector3__Single(JSVCall vc, int argc)
{
    UnityEngineManual.Vector3_SmoothDamp__Vector3__Vector3__Vector3__Single(vc, argc);
    return true;
}

static bool Vector3_SqrMagnitude__Vector3(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(UnityEngine.Vector3.SqrMagnitude(arg0)));
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.Vector3);
    ci.fields = new JSMgr.CSCallbackField[]
    {
        Vector3_kEpsilon,
        Vector3_x,
        Vector3_y,
        Vector3_z,

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        Vector3_Item_Int32,
        Vector3_normalized,
        Vector3_magnitude,
        Vector3_sqrMagnitude,
        Vector3_zero,
        Vector3_one,
        Vector3_forward,
        Vector3_back,
        Vector3_up,
        Vector3_down,
        Vector3_left,
        Vector3_right,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(Vector3_Vector31, ".ctor"),
        new JSMgr.MethodCallBackInfo(Vector3_Vector32, ".ctor"),
        new JSMgr.MethodCallBackInfo(Vector3_Vector33, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(Vector3_Equals__Object, "Equals"),
        new JSMgr.MethodCallBackInfo(Vector3_GetHashCode, "GetHashCode"),
        new JSMgr.MethodCallBackInfo(Vector3_Normalize, "Normalize"),
        new JSMgr.MethodCallBackInfo(Vector3_Scale__Vector3, "Scale"),
        new JSMgr.MethodCallBackInfo(Vector3_Set__Single__Single__Single, "Set"),
        new JSMgr.MethodCallBackInfo(Vector3_ToString__String, "ToString"),
        new JSMgr.MethodCallBackInfo(Vector3_ToString, "ToString"),
        new JSMgr.MethodCallBackInfo(Vector3_Angle__Vector3__Vector3, "Angle"),
        new JSMgr.MethodCallBackInfo(Vector3_ClampMagnitude__Vector3__Single, "ClampMagnitude"),
        new JSMgr.MethodCallBackInfo(Vector3_Cross__Vector3__Vector3, "Cross"),
        new JSMgr.MethodCallBackInfo(Vector3_Distance__Vector3__Vector3, "Distance"),
        new JSMgr.MethodCallBackInfo(Vector3_Dot__Vector3__Vector3, "Dot"),
        new JSMgr.MethodCallBackInfo(Vector3_Lerp__Vector3__Vector3__Single, "Lerp"),
        new JSMgr.MethodCallBackInfo(Vector3_LerpUnclamped__Vector3__Vector3__Single, "LerpUnclamped"),
        new JSMgr.MethodCallBackInfo(Vector3_Magnitude__Vector3, "Magnitude"),
        new JSMgr.MethodCallBackInfo(Vector3_Max__Vector3__Vector3, "Max"),
        new JSMgr.MethodCallBackInfo(Vector3_Min__Vector3__Vector3, "Min"),
        new JSMgr.MethodCallBackInfo(Vector3_MoveTowards__Vector3__Vector3__Single, "MoveTowards"),
        new JSMgr.MethodCallBackInfo(Vector3_Normalize__Vector3, "Normalize"),
        new JSMgr.MethodCallBackInfo(Vector3_op_Addition__Vector3__Vector3, "op_Addition"),
        new JSMgr.MethodCallBackInfo(Vector3_op_Division__Vector3__Single, "op_Division"),
        new JSMgr.MethodCallBackInfo(Vector3_op_Equality__Vector3__Vector3, "op_Equality"),
        new JSMgr.MethodCallBackInfo(Vector3_op_Inequality__Vector3__Vector3, "op_Inequality"),
        new JSMgr.MethodCallBackInfo(Vector3_op_Multiply__Single__Vector3, "op_Multiply"),
        new JSMgr.MethodCallBackInfo(Vector3_op_Multiply__Vector3__Single, "op_Multiply"),
        new JSMgr.MethodCallBackInfo(Vector3_op_Subtraction__Vector3__Vector3, "op_Subtraction"),
        new JSMgr.MethodCallBackInfo(Vector3_op_UnaryNegation__Vector3, "op_UnaryNegation"),
        new JSMgr.MethodCallBackInfo(Vector3_OrthoNormalize__Vector3__Vector3__Vector3, "OrthoNormalize"),
        new JSMgr.MethodCallBackInfo(Vector3_OrthoNormalize__Vector3__Vector3, "OrthoNormalize"),
        new JSMgr.MethodCallBackInfo(Vector3_Project__Vector3__Vector3, "Project"),
        new JSMgr.MethodCallBackInfo(Vector3_ProjectOnPlane__Vector3__Vector3, "ProjectOnPlane"),
        new JSMgr.MethodCallBackInfo(Vector3_Reflect__Vector3__Vector3, "Reflect"),
        new JSMgr.MethodCallBackInfo(Vector3_RotateTowards__Vector3__Vector3__Single__Single, "RotateTowards"),
        new JSMgr.MethodCallBackInfo(Vector3_Scale__Vector3__Vector3, "Scale"),
        new JSMgr.MethodCallBackInfo(Vector3_Slerp__Vector3__Vector3__Single, "Slerp"),
        new JSMgr.MethodCallBackInfo(Vector3_SlerpUnclamped__Vector3__Vector3__Single, "SlerpUnclamped"),
        new JSMgr.MethodCallBackInfo(Vector3_SmoothDamp__Vector3__Vector3__Vector3__Single__Single__Single, "SmoothDamp"),
        new JSMgr.MethodCallBackInfo(Vector3_SmoothDamp__Vector3__Vector3__Vector3__Single__Single, "SmoothDamp"),
        new JSMgr.MethodCallBackInfo(Vector3_SmoothDamp__Vector3__Vector3__Vector3__Single, "SmoothDamp"),
        new JSMgr.MethodCallBackInfo(Vector3_SqrMagnitude__Vector3, "SqrMagnitude"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
