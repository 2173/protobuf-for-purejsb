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

public class JSB_UnityEngine_Avatar
{

////////////////////// Avatar ///////////////////////////////////////
// constructors

// fields

// properties
static void Avatar_isValid(JSVCall vc)
{
        UnityEngine.Avatar _this = (UnityEngine.Avatar)vc.csObj;
        var result = _this.isValid;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void Avatar_isHuman(JSVCall vc)
{
        UnityEngine.Avatar _this = (UnityEngine.Avatar)vc.csObj;
        var result = _this.isHuman;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.Avatar);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        Avatar_isValid,
        Avatar_isHuman,

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
