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

public class JSB_UnityEngine_SpriteRenderer
{

////////////////////// SpriteRenderer ///////////////////////////////////////
// constructors

static bool SpriteRenderer_SpriteRenderer1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.SpriteRenderer());
    }

    return true;
}

// fields

// properties
static void SpriteRenderer_sprite(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.SpriteRenderer _this = (UnityEngine.SpriteRenderer)vc.csObj;
        var result = _this.sprite;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Sprite arg0 = (UnityEngine.Sprite)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.SpriteRenderer _this = (UnityEngine.SpriteRenderer)vc.csObj;
        _this.sprite = arg0;
    }
}
static void SpriteRenderer_color(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.SpriteRenderer _this = (UnityEngine.SpriteRenderer)vc.csObj;
        var result = _this.color;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.SpriteRenderer _this = (UnityEngine.SpriteRenderer)vc.csObj;
        _this.color = arg0;
    }
}
static void SpriteRenderer_flipX(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.SpriteRenderer _this = (UnityEngine.SpriteRenderer)vc.csObj;
        var result = _this.flipX;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.SpriteRenderer _this = (UnityEngine.SpriteRenderer)vc.csObj;
        _this.flipX = arg0;
    }
}
static void SpriteRenderer_flipY(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.SpriteRenderer _this = (UnityEngine.SpriteRenderer)vc.csObj;
        var result = _this.flipY;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.SpriteRenderer _this = (UnityEngine.SpriteRenderer)vc.csObj;
        _this.flipY = arg0;
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.SpriteRenderer);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        SpriteRenderer_sprite,
        SpriteRenderer_color,
        SpriteRenderer_flipX,
        SpriteRenderer_flipY,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(SpriteRenderer_SpriteRenderer1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
