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

public class JSB_UnityEngine_Animation
{

////////////////////// Animation ///////////////////////////////////////
// constructors

static bool Animation_Animation1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.Animation());
    }

    return true;
}

// fields

// properties
static void Animation_clip(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Animation _this = (UnityEngine.Animation)vc.csObj;
        var result = _this.clip;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.AnimationClip arg0 = (UnityEngine.AnimationClip)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Animation _this = (UnityEngine.Animation)vc.csObj;
        _this.clip = arg0;
    }
}
static void Animation_playAutomatically(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Animation _this = (UnityEngine.Animation)vc.csObj;
        var result = _this.playAutomatically;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.Animation _this = (UnityEngine.Animation)vc.csObj;
        _this.playAutomatically = arg0;
    }
}
static void Animation_wrapMode(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Animation _this = (UnityEngine.Animation)vc.csObj;
        var result = _this.wrapMode;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.WrapMode arg0 = (UnityEngine.WrapMode)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.Animation _this = (UnityEngine.Animation)vc.csObj;
        _this.wrapMode = arg0;
    }
}
static void Animation_isPlaying(JSVCall vc)
{
        UnityEngine.Animation _this = (UnityEngine.Animation)vc.csObj;
        var result = _this.isPlaying;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void Animation_Item_String(JSVCall vc)
{
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        UnityEngine.Animation _this = (UnityEngine.Animation)vc.csObj;
        var result = _this[arg0];
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void Animation_animatePhysics(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Animation _this = (UnityEngine.Animation)vc.csObj;
        var result = _this.animatePhysics;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.Animation _this = (UnityEngine.Animation)vc.csObj;
        _this.animatePhysics = arg0;
    }
}
static void Animation_cullingType(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Animation _this = (UnityEngine.Animation)vc.csObj;
        var result = _this.cullingType;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.AnimationCullingType arg0 = (UnityEngine.AnimationCullingType)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.Animation _this = (UnityEngine.Animation)vc.csObj;
        _this.cullingType = arg0;
    }
}
static void Animation_localBounds(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Animation _this = (UnityEngine.Animation)vc.csObj;
        var result = _this.localBounds;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Bounds arg0 = (UnityEngine.Bounds)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Animation _this = (UnityEngine.Animation)vc.csObj;
        _this.localBounds = arg0;
    }
}

// methods

static bool Animation_AddClip__AnimationClip__String__Int32__Int32__Boolean(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 5) 
    {
        UnityEngine.AnimationClip arg0 = (UnityEngine.AnimationClip)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.String arg1 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.Int32 arg3 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.Boolean arg4 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        ((UnityEngine.Animation)vc.csObj).AddClip(arg0, arg1, arg2, arg3, arg4);
    }

    return true;
}

static bool Animation_AddClip__AnimationClip__String__Int32__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 4) 
    {
        UnityEngine.AnimationClip arg0 = (UnityEngine.AnimationClip)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.String arg1 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.Int32 arg3 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        ((UnityEngine.Animation)vc.csObj).AddClip(arg0, arg1, arg2, arg3);
    }

    return true;
}

static bool Animation_AddClip__AnimationClip__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        UnityEngine.AnimationClip arg0 = (UnityEngine.AnimationClip)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.String arg1 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        ((UnityEngine.Animation)vc.csObj).AddClip(arg0, arg1);
    }

    return true;
}

static bool Animation_Blend__String__Single__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Single arg2 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        ((UnityEngine.Animation)vc.csObj).Blend(arg0, arg1, arg2);
    }

    return true;
}

static bool Animation_Blend__String__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        ((UnityEngine.Animation)vc.csObj).Blend(arg0, arg1);
    }

    return true;
}

static bool Animation_Blend__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        ((UnityEngine.Animation)vc.csObj).Blend(arg0);
    }

    return true;
}

static bool Animation_CrossFade__String__Single__PlayMode(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.PlayMode arg2 = (UnityEngine.PlayMode)JSApi.getEnum((int)JSApi.GetType.Arg);
        ((UnityEngine.Animation)vc.csObj).CrossFade(arg0, arg1, arg2);
    }

    return true;
}

static bool Animation_CrossFade__String__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        ((UnityEngine.Animation)vc.csObj).CrossFade(arg0, arg1);
    }

    return true;
}

static bool Animation_CrossFade__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        ((UnityEngine.Animation)vc.csObj).CrossFade(arg0);
    }

    return true;
}

static bool Animation_CrossFadeQueued__String__Single__QueueMode__PlayMode(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 4) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.QueueMode arg2 = (UnityEngine.QueueMode)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.PlayMode arg3 = (UnityEngine.PlayMode)JSApi.getEnum((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Animation)vc.csObj).CrossFadeQueued(arg0, arg1, arg2, arg3));
    }

    return true;
}

static bool Animation_CrossFadeQueued__String__Single__QueueMode(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.QueueMode arg2 = (UnityEngine.QueueMode)JSApi.getEnum((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Animation)vc.csObj).CrossFadeQueued(arg0, arg1, arg2));
    }

    return true;
}

static bool Animation_CrossFadeQueued__String__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Animation)vc.csObj).CrossFadeQueued(arg0, arg1));
    }

    return true;
}

static bool Animation_CrossFadeQueued__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Animation)vc.csObj).CrossFadeQueued(arg0));
    }

    return true;
}

static bool Animation_GetClip__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Animation)vc.csObj).GetClip(arg0));
    }

    return true;
}

static bool Animation_GetClipCount(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(((UnityEngine.Animation)vc.csObj).GetClipCount()));
    }

    return true;
}

static bool Animation_GetEnumerator(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Animation)vc.csObj).GetEnumerator());
    }

    return true;
}

static bool Animation_IsPlaying__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(((UnityEngine.Animation)vc.csObj).IsPlaying(arg0)));
    }

    return true;
}

static bool Animation_Play__String__PlayMode(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        UnityEngine.PlayMode arg1 = (UnityEngine.PlayMode)JSApi.getEnum((int)JSApi.GetType.Arg);
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(((UnityEngine.Animation)vc.csObj).Play(arg0, arg1)));
    }

    return true;
}

static bool Animation_Play__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(((UnityEngine.Animation)vc.csObj).Play(arg0)));
    }

    return true;
}

static bool Animation_Play__PlayMode(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.PlayMode arg0 = (UnityEngine.PlayMode)JSApi.getEnum((int)JSApi.GetType.Arg);
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(((UnityEngine.Animation)vc.csObj).Play(arg0)));
    }

    return true;
}

static bool Animation_Play(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(((UnityEngine.Animation)vc.csObj).Play()));
    }

    return true;
}

static bool Animation_PlayQueued__String__QueueMode__PlayMode(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        UnityEngine.QueueMode arg1 = (UnityEngine.QueueMode)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.PlayMode arg2 = (UnityEngine.PlayMode)JSApi.getEnum((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Animation)vc.csObj).PlayQueued(arg0, arg1, arg2));
    }

    return true;
}

static bool Animation_PlayQueued__String__QueueMode(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        UnityEngine.QueueMode arg1 = (UnityEngine.QueueMode)JSApi.getEnum((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Animation)vc.csObj).PlayQueued(arg0, arg1));
    }

    return true;
}

static bool Animation_PlayQueued__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Animation)vc.csObj).PlayQueued(arg0));
    }

    return true;
}

static bool Animation_RemoveClip__AnimationClip(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.AnimationClip arg0 = (UnityEngine.AnimationClip)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        ((UnityEngine.Animation)vc.csObj).RemoveClip(arg0);
    }

    return true;
}

static bool Animation_RemoveClip__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        ((UnityEngine.Animation)vc.csObj).RemoveClip(arg0);
    }

    return true;
}

static bool Animation_Rewind__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        ((UnityEngine.Animation)vc.csObj).Rewind(arg0);
    }

    return true;
}

static bool Animation_Rewind(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        ((UnityEngine.Animation)vc.csObj).Rewind();
    }

    return true;
}

static bool Animation_Sample(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        ((UnityEngine.Animation)vc.csObj).Sample();
    }

    return true;
}

static bool Animation_Stop__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        ((UnityEngine.Animation)vc.csObj).Stop(arg0);
    }

    return true;
}

static bool Animation_Stop(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        ((UnityEngine.Animation)vc.csObj).Stop();
    }

    return true;
}

static bool Animation_SyncLayer__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        ((UnityEngine.Animation)vc.csObj).SyncLayer(arg0);
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.Animation);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        Animation_clip,
        Animation_playAutomatically,
        Animation_wrapMode,
        Animation_isPlaying,
        Animation_Item_String,
        Animation_animatePhysics,
        Animation_cullingType,
        Animation_localBounds,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(Animation_Animation1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(Animation_AddClip__AnimationClip__String__Int32__Int32__Boolean, "AddClip"),
        new JSMgr.MethodCallBackInfo(Animation_AddClip__AnimationClip__String__Int32__Int32, "AddClip"),
        new JSMgr.MethodCallBackInfo(Animation_AddClip__AnimationClip__String, "AddClip"),
        new JSMgr.MethodCallBackInfo(Animation_Blend__String__Single__Single, "Blend"),
        new JSMgr.MethodCallBackInfo(Animation_Blend__String__Single, "Blend"),
        new JSMgr.MethodCallBackInfo(Animation_Blend__String, "Blend"),
        new JSMgr.MethodCallBackInfo(Animation_CrossFade__String__Single__PlayMode, "CrossFade"),
        new JSMgr.MethodCallBackInfo(Animation_CrossFade__String__Single, "CrossFade"),
        new JSMgr.MethodCallBackInfo(Animation_CrossFade__String, "CrossFade"),
        new JSMgr.MethodCallBackInfo(Animation_CrossFadeQueued__String__Single__QueueMode__PlayMode, "CrossFadeQueued"),
        new JSMgr.MethodCallBackInfo(Animation_CrossFadeQueued__String__Single__QueueMode, "CrossFadeQueued"),
        new JSMgr.MethodCallBackInfo(Animation_CrossFadeQueued__String__Single, "CrossFadeQueued"),
        new JSMgr.MethodCallBackInfo(Animation_CrossFadeQueued__String, "CrossFadeQueued"),
        new JSMgr.MethodCallBackInfo(Animation_GetClip__String, "GetClip"),
        new JSMgr.MethodCallBackInfo(Animation_GetClipCount, "GetClipCount"),
        new JSMgr.MethodCallBackInfo(Animation_GetEnumerator, "GetEnumerator"),
        new JSMgr.MethodCallBackInfo(Animation_IsPlaying__String, "IsPlaying"),
        new JSMgr.MethodCallBackInfo(Animation_Play__String__PlayMode, "Play"),
        new JSMgr.MethodCallBackInfo(Animation_Play__String, "Play"),
        new JSMgr.MethodCallBackInfo(Animation_Play__PlayMode, "Play"),
        new JSMgr.MethodCallBackInfo(Animation_Play, "Play"),
        new JSMgr.MethodCallBackInfo(Animation_PlayQueued__String__QueueMode__PlayMode, "PlayQueued"),
        new JSMgr.MethodCallBackInfo(Animation_PlayQueued__String__QueueMode, "PlayQueued"),
        new JSMgr.MethodCallBackInfo(Animation_PlayQueued__String, "PlayQueued"),
        new JSMgr.MethodCallBackInfo(Animation_RemoveClip__AnimationClip, "RemoveClip"),
        new JSMgr.MethodCallBackInfo(Animation_RemoveClip__String, "RemoveClip"),
        new JSMgr.MethodCallBackInfo(Animation_Rewind__String, "Rewind"),
        new JSMgr.MethodCallBackInfo(Animation_Rewind, "Rewind"),
        new JSMgr.MethodCallBackInfo(Animation_Sample, "Sample"),
        new JSMgr.MethodCallBackInfo(Animation_Stop__String, "Stop"),
        new JSMgr.MethodCallBackInfo(Animation_Stop, "Stop"),
        new JSMgr.MethodCallBackInfo(Animation_SyncLayer__Int32, "SyncLayer"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
