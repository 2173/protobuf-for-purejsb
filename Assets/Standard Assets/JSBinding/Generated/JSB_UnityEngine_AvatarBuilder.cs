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

public class JSB_UnityEngine_AvatarBuilder
{

////////////////////// AvatarBuilder ///////////////////////////////////////
// constructors

static bool AvatarBuilder_AvatarBuilder1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.AvatarBuilder());
    }

    return true;
}

// fields

// properties

// methods

static bool AvatarBuilder_BuildGenericAvatar__GameObject__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        UnityEngine.GameObject arg0 = (UnityEngine.GameObject)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.String arg1 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.AvatarBuilder.BuildGenericAvatar(arg0, arg1));
    }

    return true;
}

static bool AvatarBuilder_BuildHumanAvatar__GameObject__HumanDescription(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        UnityEngine.GameObject arg0 = (UnityEngine.GameObject)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.HumanDescription arg1 = (UnityEngine.HumanDescription)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.AvatarBuilder.BuildHumanAvatar(arg0, arg1));
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.AvatarBuilder);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(AvatarBuilder_AvatarBuilder1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(AvatarBuilder_BuildGenericAvatar__GameObject__String, "BuildGenericAvatar"),
        new JSMgr.MethodCallBackInfo(AvatarBuilder_BuildHumanAvatar__GameObject__HumanDescription, "BuildHumanAvatar"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}