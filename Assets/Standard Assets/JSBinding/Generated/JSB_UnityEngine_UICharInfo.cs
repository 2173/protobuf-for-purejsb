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

public class JSB_UnityEngine_UICharInfo
{

////////////////////// UICharInfo ///////////////////////////////////////
// constructors
public static ConstructorID constructorID0 = new ConstructorID(null, null);

static bool UICharInfo_UICharInfo1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.UICharInfo());
    }

    return true;
}

// fields
static void UICharInfo_cursorPos(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.UICharInfo _this = (UnityEngine.UICharInfo)vc.csObj;
        var result = _this.cursorPos;
                JSApi.setVector2S((int)JSApi.SetType.Rval, result);
    }
    else {
        UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSApi.getVector2S((int)JSApi.GetType.Arg);
        UnityEngine.UICharInfo _this = (UnityEngine.UICharInfo)vc.csObj;
        _this.cursorPos = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void UICharInfo_charWidth(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.UICharInfo _this = (UnityEngine.UICharInfo)vc.csObj;
        var result = _this.charWidth;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.UICharInfo _this = (UnityEngine.UICharInfo)vc.csObj;
        _this.charWidth = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}

// properties

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.UICharInfo);
    ci.fields = new JSMgr.CSCallbackField[]
    {
        UICharInfo_cursorPos,
        UICharInfo_charWidth,

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(UICharInfo_UICharInfo1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
