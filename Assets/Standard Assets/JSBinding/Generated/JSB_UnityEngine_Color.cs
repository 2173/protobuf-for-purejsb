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

public class JSB_UnityEngine_Color
{

////////////////////// Color ///////////////////////////////////////
// constructors
public static ConstructorID constructorID0 = new ConstructorID(null, null);

static bool Color_Color1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.Color());
    }

    return true;
}

static bool Color_Color2(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 4)
    {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Single arg2 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Single arg3 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.Color(arg0, arg1, arg2, arg3));
    }

    return true;
}

static bool Color_Color3(JSVCall vc, int argc)
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
        JSMgr.addJSCSRel(_this, new UnityEngine.Color(arg0, arg1, arg2));
    }

    return true;
}

// fields
static void Color_r(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
        var result = _this.r;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
        _this.r = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Color_g(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
        var result = _this.g;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
        _this.g = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Color_b(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
        var result = _this.b;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
        _this.b = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Color_a(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
        var result = _this.a;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
        _this.a = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}

// properties
static void Color_red(JSVCall vc)
{
        var result = UnityEngine.Color.red;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void Color_green(JSVCall vc)
{
        var result = UnityEngine.Color.green;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void Color_blue(JSVCall vc)
{
        var result = UnityEngine.Color.blue;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void Color_white(JSVCall vc)
{
        var result = UnityEngine.Color.white;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void Color_black(JSVCall vc)
{
        var result = UnityEngine.Color.black;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void Color_yellow(JSVCall vc)
{
        var result = UnityEngine.Color.yellow;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void Color_cyan(JSVCall vc)
{
        var result = UnityEngine.Color.cyan;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void Color_magenta(JSVCall vc)
{
        var result = UnityEngine.Color.magenta;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void Color_gray(JSVCall vc)
{
        var result = UnityEngine.Color.gray;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void Color_grey(JSVCall vc)
{
        var result = UnityEngine.Color.grey;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void Color_clear(JSVCall vc)
{
        var result = UnityEngine.Color.clear;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void Color_grayscale(JSVCall vc)
{
        UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
        var result = _this.grayscale;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
}
static void Color_linear(JSVCall vc)
{
        UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
        var result = _this.linear;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void Color_gamma(JSVCall vc)
{
        UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
        var result = _this.gamma;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void Color_maxColorComponent(JSVCall vc)
{
        UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
        var result = _this.maxColorComponent;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
}
static void Color_Item_Int32(JSVCall vc)
{
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
    if (vc.bGet)
    { 
        UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
        var result = _this[arg0];
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
        _this[arg0] = arg1;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}

// methods

static bool Color_Equals__Object(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Object arg0 = (System.Object)JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
UnityEngine.Color argThis = (UnityEngine.Color)vc.csObj;                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(argThis.Equals(arg0)));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Color_GetHashCode(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
UnityEngine.Color argThis = (UnityEngine.Color)vc.csObj;                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(argThis.GetHashCode()));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Color_ToString__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
UnityEngine.Color argThis = (UnityEngine.Color)vc.csObj;                JSApi.setStringS((int)JSApi.SetType.Rval, argThis.ToString(arg0));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Color_ToString(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
UnityEngine.Color argThis = (UnityEngine.Color)vc.csObj;                JSApi.setStringS((int)JSApi.SetType.Rval, argThis.ToString());
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Color_HSVToRGB__Single__Single__Single__Boolean(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 4) 
    {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Single arg2 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Boolean arg3 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Color.HSVToRGB(arg0, arg1, arg2, arg3));
    }

    return true;
}

static bool Color_HSVToRGB__Single__Single__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Single arg2 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Color.HSVToRGB(arg0, arg1, arg2));
    }

    return true;
}

static bool Color_Lerp__Color__Color__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Color arg1 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Single arg2 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Color.Lerp(arg0, arg1, arg2));
    }

    return true;
}

static bool Color_LerpUnclamped__Color__Color__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Color arg1 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Single arg2 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Color.LerpUnclamped(arg0, arg1, arg2));
    }

    return true;
}

static bool Color_op_Addition__Color__Color(JSVCall vc, int argc)
{
    UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
    UnityEngine.Color arg1 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, arg0 + arg1);
    return true;
}

static bool Color_op_Division__Color__Single(JSVCall vc, int argc)
{
    UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
    System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, arg0 / arg1);
    return true;
}

static bool Color_op_Equality__Color__Color(JSVCall vc, int argc)
{
    UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
    UnityEngine.Color arg1 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(arg0 == arg1));
    return true;
}

static bool Color_op_Implicit__Vector4_to_Color(JSVCall vc, int argc)
{
    UnityEngine.Vector4 arg0 = (UnityEngine.Vector4)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, (UnityEngine.Color)arg0);
    return true;
}

static bool Color_op_Implicit__Color_to_Vector4(JSVCall vc, int argc)
{
    UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, (UnityEngine.Vector4)arg0);
    return true;
}

static bool Color_op_Inequality__Color__Color(JSVCall vc, int argc)
{
    UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
    UnityEngine.Color arg1 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(arg0 != arg1));
    return true;
}

static bool Color_op_Multiply__Color__Color(JSVCall vc, int argc)
{
    UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
    UnityEngine.Color arg1 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, arg0 * arg1);
    return true;
}

static bool Color_op_Multiply__Color__Single(JSVCall vc, int argc)
{
    UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
    System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, arg0 * arg1);
    return true;
}

static bool Color_op_Multiply__Single__Color(JSVCall vc, int argc)
{
    System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
    UnityEngine.Color arg1 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, arg0 * arg1);
    return true;
}

static bool Color_op_Subtraction__Color__Color(JSVCall vc, int argc)
{
    UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
    UnityEngine.Color arg1 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, arg0 - arg1);
    return true;
}

static bool Color_RGBToHSV__Color__Single__Single__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 4) 
    {
        UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        int r_arg1 = JSApi.incArgIndex();
        System.Single arg1;
        int r_arg2 = JSApi.incArgIndex();
        System.Single arg2;
        int r_arg3 = JSApi.incArgIndex();
        System.Single arg3;
        UnityEngine.Color.RGBToHSV(arg0, out arg1, out arg2, out arg3);
        JSApi.setArgIndex(r_arg1);
        JSApi.setSingle((int)JSApi.SetType.ArgRef, arg1);
        JSApi.setArgIndex(r_arg2);
        JSApi.setSingle((int)JSApi.SetType.ArgRef, arg2);
        JSApi.setArgIndex(r_arg3);
        JSApi.setSingle((int)JSApi.SetType.ArgRef, arg3);
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.Color);
    ci.fields = new JSMgr.CSCallbackField[]
    {
        Color_r,
        Color_g,
        Color_b,
        Color_a,

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        Color_red,
        Color_green,
        Color_blue,
        Color_white,
        Color_black,
        Color_yellow,
        Color_cyan,
        Color_magenta,
        Color_gray,
        Color_grey,
        Color_clear,
        Color_grayscale,
        Color_linear,
        Color_gamma,
        Color_maxColorComponent,
        Color_Item_Int32,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(Color_Color1, ".ctor"),
        new JSMgr.MethodCallBackInfo(Color_Color2, ".ctor"),
        new JSMgr.MethodCallBackInfo(Color_Color3, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(Color_Equals__Object, "Equals"),
        new JSMgr.MethodCallBackInfo(Color_GetHashCode, "GetHashCode"),
        new JSMgr.MethodCallBackInfo(Color_ToString__String, "ToString"),
        new JSMgr.MethodCallBackInfo(Color_ToString, "ToString"),
        new JSMgr.MethodCallBackInfo(Color_HSVToRGB__Single__Single__Single__Boolean, "HSVToRGB"),
        new JSMgr.MethodCallBackInfo(Color_HSVToRGB__Single__Single__Single, "HSVToRGB"),
        new JSMgr.MethodCallBackInfo(Color_Lerp__Color__Color__Single, "Lerp"),
        new JSMgr.MethodCallBackInfo(Color_LerpUnclamped__Color__Color__Single, "LerpUnclamped"),
        new JSMgr.MethodCallBackInfo(Color_op_Addition__Color__Color, "op_Addition"),
        new JSMgr.MethodCallBackInfo(Color_op_Division__Color__Single, "op_Division"),
        new JSMgr.MethodCallBackInfo(Color_op_Equality__Color__Color, "op_Equality"),
        new JSMgr.MethodCallBackInfo(Color_op_Implicit__Vector4_to_Color, "op_Implicit"),
        new JSMgr.MethodCallBackInfo(Color_op_Implicit__Color_to_Vector4, "op_Implicit"),
        new JSMgr.MethodCallBackInfo(Color_op_Inequality__Color__Color, "op_Inequality"),
        new JSMgr.MethodCallBackInfo(Color_op_Multiply__Color__Color, "op_Multiply"),
        new JSMgr.MethodCallBackInfo(Color_op_Multiply__Color__Single, "op_Multiply"),
        new JSMgr.MethodCallBackInfo(Color_op_Multiply__Single__Color, "op_Multiply"),
        new JSMgr.MethodCallBackInfo(Color_op_Subtraction__Color__Color, "op_Subtraction"),
        new JSMgr.MethodCallBackInfo(Color_RGBToHSV__Color__Single__Single__Single, "RGBToHSV"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
