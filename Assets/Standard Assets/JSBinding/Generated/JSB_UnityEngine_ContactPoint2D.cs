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

public class JSB_UnityEngine_ContactPoint2D
{

////////////////////// ContactPoint2D ///////////////////////////////////////
// constructors
public static ConstructorID constructorID0 = new ConstructorID(null, null);

static bool ContactPoint2D_ContactPoint2D1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.ContactPoint2D());
    }

    return true;
}

// fields

// properties
static void ContactPoint2D_point(JSVCall vc)
{
        UnityEngine.ContactPoint2D _this = (UnityEngine.ContactPoint2D)vc.csObj;
        var result = _this.point;
                JSApi.setVector2S((int)JSApi.SetType.Rval, result);
}
static void ContactPoint2D_normal(JSVCall vc)
{
        UnityEngine.ContactPoint2D _this = (UnityEngine.ContactPoint2D)vc.csObj;
        var result = _this.normal;
                JSApi.setVector2S((int)JSApi.SetType.Rval, result);
}
static void ContactPoint2D_collider(JSVCall vc)
{
        UnityEngine.ContactPoint2D _this = (UnityEngine.ContactPoint2D)vc.csObj;
        var result = _this.collider;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void ContactPoint2D_otherCollider(JSVCall vc)
{
        UnityEngine.ContactPoint2D _this = (UnityEngine.ContactPoint2D)vc.csObj;
        var result = _this.otherCollider;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.ContactPoint2D);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        ContactPoint2D_point,
        ContactPoint2D_normal,
        ContactPoint2D_collider,
        ContactPoint2D_otherCollider,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(ContactPoint2D_ContactPoint2D1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
