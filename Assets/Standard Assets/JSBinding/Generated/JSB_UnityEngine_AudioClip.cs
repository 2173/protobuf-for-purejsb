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

public class JSB_UnityEngine_AudioClip
{

////////////////////// AudioClip ///////////////////////////////////////
// constructors

static bool AudioClip_AudioClip1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.AudioClip());
    }

    return true;
}

// fields

// properties
static void AudioClip_length(JSVCall vc)
{
        UnityEngine.AudioClip _this = (UnityEngine.AudioClip)vc.csObj;
        var result = _this.length;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
}
static void AudioClip_samples(JSVCall vc)
{
        UnityEngine.AudioClip _this = (UnityEngine.AudioClip)vc.csObj;
        var result = _this.samples;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
}
static void AudioClip_channels(JSVCall vc)
{
        UnityEngine.AudioClip _this = (UnityEngine.AudioClip)vc.csObj;
        var result = _this.channels;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
}
static void AudioClip_frequency(JSVCall vc)
{
        UnityEngine.AudioClip _this = (UnityEngine.AudioClip)vc.csObj;
        var result = _this.frequency;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
}
static void AudioClip_loadType(JSVCall vc)
{
        UnityEngine.AudioClip _this = (UnityEngine.AudioClip)vc.csObj;
        var result = _this.loadType;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
}
static void AudioClip_preloadAudioData(JSVCall vc)
{
        UnityEngine.AudioClip _this = (UnityEngine.AudioClip)vc.csObj;
        var result = _this.preloadAudioData;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void AudioClip_loadState(JSVCall vc)
{
        UnityEngine.AudioClip _this = (UnityEngine.AudioClip)vc.csObj;
        var result = _this.loadState;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
}
static void AudioClip_loadInBackground(JSVCall vc)
{
        UnityEngine.AudioClip _this = (UnityEngine.AudioClip)vc.csObj;
        var result = _this.loadInBackground;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}

// methods

static bool AudioClip_GetData__Single_Array__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.Single[] arg0 = JSDataExchangeMgr.GetJSArg<System.Single[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new System.Single[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (System.Single)JSApi.getSingle((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        System.Int32 arg1 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(((UnityEngine.AudioClip)vc.csObj).GetData(arg0, arg1)));
    }

    return true;
}

static bool AudioClip_LoadAudioData(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(((UnityEngine.AudioClip)vc.csObj).LoadAudioData()));
    }

    return true;
}

static bool AudioClip_SetData__Single_Array__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.Single[] arg0 = JSDataExchangeMgr.GetJSArg<System.Single[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new System.Single[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (System.Single)JSApi.getSingle((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        System.Int32 arg1 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(((UnityEngine.AudioClip)vc.csObj).SetData(arg0, arg1)));
    }

    return true;
}

static bool AudioClip_UnloadAudioData(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(((UnityEngine.AudioClip)vc.csObj).UnloadAudioData()));
    }

    return true;
}
public static UnityEngine.AudioClip.PCMReaderCallback AudioClip_Create_GetDelegate_member4_arg5(CSRepresentedObject objFunction)
{
    if (objFunction == null || objFunction.jsObjID == 0)
    {
        return null;
    }
    var action = JSMgr.getJSFunCSDelegateRel<UnityEngine.AudioClip.PCMReaderCallback>(objFunction.jsObjID);
    if (action == null)
    {
        action = (data) => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID, data);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
    }
    return action;
}
public static UnityEngine.AudioClip.PCMSetPositionCallback AudioClip_Create_GetDelegate_member4_arg6(CSRepresentedObject objFunction)
{
    if (objFunction == null || objFunction.jsObjID == 0)
    {
        return null;
    }
    var action = JSMgr.getJSFunCSDelegateRel<UnityEngine.AudioClip.PCMSetPositionCallback>(objFunction.jsObjID);
    if (action == null)
    {
        action = (position) => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID, position);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
    }
    return action;
}

static bool AudioClip_Create__String__Int32__Int32__Int32__Boolean__PCMReaderCallback__PCMSetPositionCallback(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 7) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Int32 arg1 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.Int32 arg3 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.Boolean arg4 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.AudioClip.PCMReaderCallback arg5 = JSDataExchangeMgr.GetJSArg<UnityEngine.AudioClip.PCMReaderCallback>(()=>
        {
            if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                return AudioClip_Create_GetDelegate_member4_arg5(JSApi.getFunctionS((int)JSApi.GetType.Arg));
            else
                return (UnityEngine.AudioClip.PCMReaderCallback)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        });
        UnityEngine.AudioClip.PCMSetPositionCallback arg6 = JSDataExchangeMgr.GetJSArg<UnityEngine.AudioClip.PCMSetPositionCallback>(()=>
        {
            if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                return AudioClip_Create_GetDelegate_member4_arg6(JSApi.getFunctionS((int)JSApi.GetType.Arg));
            else
                return (UnityEngine.AudioClip.PCMSetPositionCallback)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        });
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.AudioClip.Create(arg0, arg1, arg2, arg3, arg4, arg5, arg6));
    }

    return true;
}
public static UnityEngine.AudioClip.PCMReaderCallback AudioClip_Create_GetDelegate_member5_arg5(CSRepresentedObject objFunction)
{
    if (objFunction == null || objFunction.jsObjID == 0)
    {
        return null;
    }
    var action = JSMgr.getJSFunCSDelegateRel<UnityEngine.AudioClip.PCMReaderCallback>(objFunction.jsObjID);
    if (action == null)
    {
        action = (data) => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID, data);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
    }
    return action;
}

static bool AudioClip_Create__String__Int32__Int32__Int32__Boolean__PCMReaderCallback(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 6) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Int32 arg1 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.Int32 arg3 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.Boolean arg4 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.AudioClip.PCMReaderCallback arg5 = JSDataExchangeMgr.GetJSArg<UnityEngine.AudioClip.PCMReaderCallback>(()=>
        {
            if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                return AudioClip_Create_GetDelegate_member5_arg5(JSApi.getFunctionS((int)JSApi.GetType.Arg));
            else
                return (UnityEngine.AudioClip.PCMReaderCallback)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        });
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.AudioClip.Create(arg0, arg1, arg2, arg3, arg4, arg5));
    }

    return true;
}

static bool AudioClip_Create__String__Int32__Int32__Int32__Boolean(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 5) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Int32 arg1 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.Int32 arg3 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.Boolean arg4 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.AudioClip.Create(arg0, arg1, arg2, arg3, arg4));
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.AudioClip);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        AudioClip_length,
        AudioClip_samples,
        AudioClip_channels,
        AudioClip_frequency,
        AudioClip_loadType,
        AudioClip_preloadAudioData,
        AudioClip_loadState,
        AudioClip_loadInBackground,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(AudioClip_AudioClip1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(AudioClip_GetData__Single_Array__Int32, "GetData"),
        new JSMgr.MethodCallBackInfo(AudioClip_LoadAudioData, "LoadAudioData"),
        new JSMgr.MethodCallBackInfo(AudioClip_SetData__Single_Array__Int32, "SetData"),
        new JSMgr.MethodCallBackInfo(AudioClip_UnloadAudioData, "UnloadAudioData"),
        new JSMgr.MethodCallBackInfo(AudioClip_Create__String__Int32__Int32__Int32__Boolean__PCMReaderCallback__PCMSetPositionCallback, "Create"),
        new JSMgr.MethodCallBackInfo(AudioClip_Create__String__Int32__Int32__Int32__Boolean__PCMReaderCallback, "Create"),
        new JSMgr.MethodCallBackInfo(AudioClip_Create__String__Int32__Int32__Int32__Boolean, "Create"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}