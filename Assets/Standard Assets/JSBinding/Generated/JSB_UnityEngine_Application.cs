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

public class JSB_UnityEngine_Application
{

////////////////////// Application ///////////////////////////////////////
// constructors

static bool Application_Application1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.Application());
    }

    return true;
}

// fields

// properties
static void Application_streamedBytes(JSVCall vc)
{
        var result = UnityEngine.Application.streamedBytes;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
}
static void Application_isPlaying(JSVCall vc)
{
        var result = UnityEngine.Application.isPlaying;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void Application_isEditor(JSVCall vc)
{
        var result = UnityEngine.Application.isEditor;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void Application_isWebPlayer(JSVCall vc)
{
        var result = UnityEngine.Application.isWebPlayer;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void Application_platform(JSVCall vc)
{
        var result = UnityEngine.Application.platform;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
}
static void Application_isMobilePlatform(JSVCall vc)
{
        var result = UnityEngine.Application.isMobilePlatform;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void Application_isConsolePlatform(JSVCall vc)
{
        var result = UnityEngine.Application.isConsolePlatform;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void Application_runInBackground(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.Application.runInBackground;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.Application.runInBackground = arg0;
    }
}
static void Application_dataPath(JSVCall vc)
{
        var result = UnityEngine.Application.dataPath;
                JSApi.setStringS((int)JSApi.SetType.Rval, result);
}
static void Application_streamingAssetsPath(JSVCall vc)
{
        var result = UnityEngine.Application.streamingAssetsPath;
                JSApi.setStringS((int)JSApi.SetType.Rval, result);
}
static void Application_persistentDataPath(JSVCall vc)
{
        var result = UnityEngine.Application.persistentDataPath;
                JSApi.setStringS((int)JSApi.SetType.Rval, result);
}
static void Application_temporaryCachePath(JSVCall vc)
{
        var result = UnityEngine.Application.temporaryCachePath;
                JSApi.setStringS((int)JSApi.SetType.Rval, result);
}
static void Application_srcValue(JSVCall vc)
{
        var result = UnityEngine.Application.srcValue;
                JSApi.setStringS((int)JSApi.SetType.Rval, result);
}
static void Application_absoluteURL(JSVCall vc)
{
        var result = UnityEngine.Application.absoluteURL;
                JSApi.setStringS((int)JSApi.SetType.Rval, result);
}
static void Application_unityVersion(JSVCall vc)
{
        var result = UnityEngine.Application.unityVersion;
                JSApi.setStringS((int)JSApi.SetType.Rval, result);
}
static void Application_version(JSVCall vc)
{
        var result = UnityEngine.Application.version;
                JSApi.setStringS((int)JSApi.SetType.Rval, result);
}
static void Application_bundleIdentifier(JSVCall vc)
{
        var result = UnityEngine.Application.bundleIdentifier;
                JSApi.setStringS((int)JSApi.SetType.Rval, result);
}
static void Application_installMode(JSVCall vc)
{
        var result = UnityEngine.Application.installMode;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
}
static void Application_sandboxType(JSVCall vc)
{
        var result = UnityEngine.Application.sandboxType;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
}
static void Application_productName(JSVCall vc)
{
        var result = UnityEngine.Application.productName;
                JSApi.setStringS((int)JSApi.SetType.Rval, result);
}
static void Application_companyName(JSVCall vc)
{
        var result = UnityEngine.Application.companyName;
                JSApi.setStringS((int)JSApi.SetType.Rval, result);
}
static void Application_cloudProjectId(JSVCall vc)
{
        var result = UnityEngine.Application.cloudProjectId;
                JSApi.setStringS((int)JSApi.SetType.Rval, result);
}
static void Application_webSecurityEnabled(JSVCall vc)
{
        var result = UnityEngine.Application.webSecurityEnabled;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void Application_webSecurityHostUrl(JSVCall vc)
{
        var result = UnityEngine.Application.webSecurityHostUrl;
                JSApi.setStringS((int)JSApi.SetType.Rval, result);
}
static void Application_targetFrameRate(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.Application.targetFrameRate;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else
    { 
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.Application.targetFrameRate = arg0;
    }
}
static void Application_systemLanguage(JSVCall vc)
{
        var result = UnityEngine.Application.systemLanguage;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
}
static void Application_stackTraceLogType(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.Application.stackTraceLogType;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.StackTraceLogType arg0 = (UnityEngine.StackTraceLogType)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.Application.stackTraceLogType = arg0;
    }
}
static void Application_backgroundLoadingPriority(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.Application.backgroundLoadingPriority;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.ThreadPriority arg0 = (UnityEngine.ThreadPriority)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.Application.backgroundLoadingPriority = arg0;
    }
}
static void Application_internetReachability(JSVCall vc)
{
        var result = UnityEngine.Application.internetReachability;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
}
static void Application_genuine(JSVCall vc)
{
        var result = UnityEngine.Application.genuine;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void Application_genuineCheckAvailable(JSVCall vc)
{
        var result = UnityEngine.Application.genuineCheckAvailable;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void Application_isShowingSplashScreen(JSVCall vc)
{
        var result = UnityEngine.Application.isShowingSplashScreen;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}

// methods
public static UnityEngine.Application.LogCallback Application_add_logMessageReceived_GetDelegate_member0_arg0(CSRepresentedObject objFunction)
{
    if (objFunction == null || objFunction.jsObjID == 0)
    {
        return null;
    }
    var action = JSMgr.getJSFunCSDelegateRel<UnityEngine.Application.LogCallback>(objFunction.jsObjID);
    if (action == null)
    {
        action = (condition, stackTrace, type) => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID, condition, stackTrace, type);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
    }
    return action;
}

static bool Application_add_logMessageReceived__LogCallback(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Application.LogCallback action = JSDataExchangeMgr.GetJSArg<UnityEngine.Application.LogCallback>(()=>
        {
            if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                return Application_add_logMessageReceived_GetDelegate_member0_arg0(JSApi.getFunctionS((int)JSApi.GetType.Arg));
            else
                return (UnityEngine.Application.LogCallback)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        });
        UnityEngine.Application.logMessageReceived += action;
    }

    return true;
}
public static UnityEngine.Application.LogCallback Application_add_logMessageReceivedThreaded_GetDelegate_member1_arg0(CSRepresentedObject objFunction)
{
    if (objFunction == null || objFunction.jsObjID == 0)
    {
        return null;
    }
    var action = JSMgr.getJSFunCSDelegateRel<UnityEngine.Application.LogCallback>(objFunction.jsObjID);
    if (action == null)
    {
        action = (condition, stackTrace, type) => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID, condition, stackTrace, type);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
    }
    return action;
}

static bool Application_add_logMessageReceivedThreaded__LogCallback(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Application.LogCallback action = JSDataExchangeMgr.GetJSArg<UnityEngine.Application.LogCallback>(()=>
        {
            if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                return Application_add_logMessageReceivedThreaded_GetDelegate_member1_arg0(JSApi.getFunctionS((int)JSApi.GetType.Arg));
            else
                return (UnityEngine.Application.LogCallback)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        });
        UnityEngine.Application.logMessageReceivedThreaded += action;
    }

    return true;
}

static bool Application_CancelQuit(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        UnityEngine.Application.CancelQuit();
    }

    return true;
}

static bool Application_CanStreamedLevelBeLoaded__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(UnityEngine.Application.CanStreamedLevelBeLoaded(arg0)));
    }

    return true;
}

static bool Application_CanStreamedLevelBeLoaded__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(UnityEngine.Application.CanStreamedLevelBeLoaded(arg0)));
    }

    return true;
}

static bool Application_CaptureScreenshot__String__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Int32 arg1 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.Application.CaptureScreenshot(arg0, arg1);
    }

    return true;
}

static bool Application_CaptureScreenshot__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        UnityEngine.Application.CaptureScreenshot(arg0);
    }

    return true;
}

static bool Application_ExternalCall__String__Object_Array(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Object[] arg1 = JSDataExchangeMgr.GetJSArg<System.Object[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new System.Object[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (System.Object)JSMgr.datax.getWhatever((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        UnityEngine.Application.ExternalCall(arg0, arg1);
    }

    return true;
}

static bool Application_GetStreamProgressForLevel__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(UnityEngine.Application.GetStreamProgressForLevel(arg0)));
    }

    return true;
}

static bool Application_GetStreamProgressForLevel__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(UnityEngine.Application.GetStreamProgressForLevel(arg0)));
    }

    return true;
}

static bool Application_HasProLicense(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(UnityEngine.Application.HasProLicense()));
    }

    return true;
}

static bool Application_HasUserAuthorization__UserAuthorization(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.UserAuthorization arg0 = (UnityEngine.UserAuthorization)JSApi.getEnum((int)JSApi.GetType.Arg);
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(UnityEngine.Application.HasUserAuthorization(arg0)));
    }

    return true;
}

static bool Application_OpenURL__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        UnityEngine.Application.OpenURL(arg0);
    }

    return true;
}

static bool Application_Quit(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        UnityEngine.Application.Quit();
    }

    return true;
}
public static UnityEngine.Application.LogCallback Application_remove_logMessageReceived_GetDelegate_member14_arg0(CSRepresentedObject objFunction)
{
    if (objFunction == null || objFunction.jsObjID == 0)
    {
        return null;
    }
    var action = JSMgr.getJSFunCSDelegateRel<UnityEngine.Application.LogCallback>(objFunction.jsObjID);
    if (action == null)
    {
        action = (condition, stackTrace, type) => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID, condition, stackTrace, type);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
    }
    return action;
}

static bool Application_remove_logMessageReceived__LogCallback(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Application.LogCallback action = JSDataExchangeMgr.GetJSArg<UnityEngine.Application.LogCallback>(()=>
        {
            if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                return Application_remove_logMessageReceived_GetDelegate_member14_arg0(JSApi.getFunctionS((int)JSApi.GetType.Arg));
            else
                return (UnityEngine.Application.LogCallback)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        });
        UnityEngine.Application.logMessageReceived -= action;
    }

    return true;
}
public static UnityEngine.Application.LogCallback Application_remove_logMessageReceivedThreaded_GetDelegate_member15_arg0(CSRepresentedObject objFunction)
{
    if (objFunction == null || objFunction.jsObjID == 0)
    {
        return null;
    }
    var action = JSMgr.getJSFunCSDelegateRel<UnityEngine.Application.LogCallback>(objFunction.jsObjID);
    if (action == null)
    {
        action = (condition, stackTrace, type) => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID, condition, stackTrace, type);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
    }
    return action;
}

static bool Application_remove_logMessageReceivedThreaded__LogCallback(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Application.LogCallback action = JSDataExchangeMgr.GetJSArg<UnityEngine.Application.LogCallback>(()=>
        {
            if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                return Application_remove_logMessageReceivedThreaded_GetDelegate_member15_arg0(JSApi.getFunctionS((int)JSApi.GetType.Arg));
            else
                return (UnityEngine.Application.LogCallback)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        });
        UnityEngine.Application.logMessageReceivedThreaded -= action;
    }

    return true;
}
public static UnityEngine.Application.AdvertisingIdentifierCallback Application_RequestAdvertisingIdentifierAsync_GetDelegate_member16_arg0(CSRepresentedObject objFunction)
{
    if (objFunction == null || objFunction.jsObjID == 0)
    {
        return null;
    }
    var action = JSMgr.getJSFunCSDelegateRel<UnityEngine.Application.AdvertisingIdentifierCallback>(objFunction.jsObjID);
    if (action == null)
    {
        action = (advertisingId, trackingEnabled, errorMsg) => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID, advertisingId, trackingEnabled, errorMsg);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
    }
    return action;
}

static bool Application_RequestAdvertisingIdentifierAsync__AdvertisingIdentifierCallback(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Application.AdvertisingIdentifierCallback arg0 = JSDataExchangeMgr.GetJSArg<UnityEngine.Application.AdvertisingIdentifierCallback>(()=>
        {
            if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                return Application_RequestAdvertisingIdentifierAsync_GetDelegate_member16_arg0(JSApi.getFunctionS((int)JSApi.GetType.Arg));
            else
                return (UnityEngine.Application.AdvertisingIdentifierCallback)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        });
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(UnityEngine.Application.RequestAdvertisingIdentifierAsync(arg0)));
    }

    return true;
}

static bool Application_RequestUserAuthorization__UserAuthorization(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.UserAuthorization arg0 = (UnityEngine.UserAuthorization)JSApi.getEnum((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Application.RequestUserAuthorization(arg0));
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.Application);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        Application_streamedBytes,
        Application_isPlaying,
        Application_isEditor,
        Application_isWebPlayer,
        Application_platform,
        Application_isMobilePlatform,
        Application_isConsolePlatform,
        Application_runInBackground,
        Application_dataPath,
        Application_streamingAssetsPath,
        Application_persistentDataPath,
        Application_temporaryCachePath,
        Application_srcValue,
        Application_absoluteURL,
        Application_unityVersion,
        Application_version,
        Application_bundleIdentifier,
        Application_installMode,
        Application_sandboxType,
        Application_productName,
        Application_companyName,
        Application_cloudProjectId,
        Application_webSecurityEnabled,
        Application_webSecurityHostUrl,
        Application_targetFrameRate,
        Application_systemLanguage,
        Application_stackTraceLogType,
        Application_backgroundLoadingPriority,
        Application_internetReachability,
        Application_genuine,
        Application_genuineCheckAvailable,
        Application_isShowingSplashScreen,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(Application_Application1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(Application_add_logMessageReceived__LogCallback, "add_logMessageReceived"),
        new JSMgr.MethodCallBackInfo(Application_add_logMessageReceivedThreaded__LogCallback, "add_logMessageReceivedThreaded"),
        new JSMgr.MethodCallBackInfo(Application_CancelQuit, "CancelQuit"),
        new JSMgr.MethodCallBackInfo(Application_CanStreamedLevelBeLoaded__Int32, "CanStreamedLevelBeLoaded"),
        new JSMgr.MethodCallBackInfo(Application_CanStreamedLevelBeLoaded__String, "CanStreamedLevelBeLoaded"),
        new JSMgr.MethodCallBackInfo(Application_CaptureScreenshot__String__Int32, "CaptureScreenshot"),
        new JSMgr.MethodCallBackInfo(Application_CaptureScreenshot__String, "CaptureScreenshot"),
        new JSMgr.MethodCallBackInfo(Application_ExternalCall__String__Object_Array, "ExternalCall"),
        new JSMgr.MethodCallBackInfo(Application_GetStreamProgressForLevel__Int32, "GetStreamProgressForLevel"),
        new JSMgr.MethodCallBackInfo(Application_GetStreamProgressForLevel__String, "GetStreamProgressForLevel"),
        new JSMgr.MethodCallBackInfo(Application_HasProLicense, "HasProLicense"),
        new JSMgr.MethodCallBackInfo(Application_HasUserAuthorization__UserAuthorization, "HasUserAuthorization"),
        new JSMgr.MethodCallBackInfo(Application_OpenURL__String, "OpenURL"),
        new JSMgr.MethodCallBackInfo(Application_Quit, "Quit"),
        new JSMgr.MethodCallBackInfo(Application_remove_logMessageReceived__LogCallback, "remove_logMessageReceived"),
        new JSMgr.MethodCallBackInfo(Application_remove_logMessageReceivedThreaded__LogCallback, "remove_logMessageReceivedThreaded"),
        new JSMgr.MethodCallBackInfo(Application_RequestAdvertisingIdentifierAsync__AdvertisingIdentifierCallback, "RequestAdvertisingIdentifierAsync"),
        new JSMgr.MethodCallBackInfo(Application_RequestUserAuthorization__UserAuthorization, "RequestUserAuthorization"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}