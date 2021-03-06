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

public class JSB_UnityEngine_CullingGroup
{

////////////////////// CullingGroup ///////////////////////////////////////
// constructors

static bool CullingGroup_CullingGroup1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.CullingGroup());
    }

    return true;
}

// fields

// properties
public static UnityEngine.CullingGroup.StateChanged CullingGroup_onStateChanged_GetDelegate_member0_arg0(CSRepresentedObject objFunction)
{
    if (objFunction == null || objFunction.jsObjID == 0)
    {
        return null;
    }
    var action = JSMgr.getJSFunCSDelegateRel<UnityEngine.CullingGroup.StateChanged>(objFunction.jsObjID);
    if (action == null)
    {
        action = (sphere) => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID, sphere);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
    }
    return action;
}
static void CullingGroup_onStateChanged(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.CullingGroup _this = (UnityEngine.CullingGroup)vc.csObj;
        var result = _this.onStateChanged;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.CullingGroup _this = (UnityEngine.CullingGroup)vc.csObj;
        _this.onStateChanged = JSDataExchangeMgr.GetJSArg<UnityEngine.CullingGroup.StateChanged>(()=>
        {
            if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                return CullingGroup_onStateChanged_GetDelegate_member0_arg0(JSApi.getFunctionS((int)JSApi.GetType.Arg));
            else
                return (UnityEngine.CullingGroup.StateChanged)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        });
    }
}
static void CullingGroup_enabled(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.CullingGroup _this = (UnityEngine.CullingGroup)vc.csObj;
        var result = _this.enabled;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.CullingGroup _this = (UnityEngine.CullingGroup)vc.csObj;
        _this.enabled = arg0;
    }
}
static void CullingGroup_targetCamera(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.CullingGroup _this = (UnityEngine.CullingGroup)vc.csObj;
        var result = _this.targetCamera;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Camera arg0 = (UnityEngine.Camera)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.CullingGroup _this = (UnityEngine.CullingGroup)vc.csObj;
        _this.targetCamera = arg0;
    }
}

// methods

static bool CullingGroup_Dispose(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        ((UnityEngine.CullingGroup)vc.csObj).Dispose();
    }

    return true;
}

static bool CullingGroup_EraseSwapBack__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        ((UnityEngine.CullingGroup)vc.csObj).EraseSwapBack(arg0);
    }

    return true;
}

static bool CullingGroup_GetDistance__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(((UnityEngine.CullingGroup)vc.csObj).GetDistance(arg0)));
    }

    return true;
}

static bool CullingGroup_IsVisible__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(((UnityEngine.CullingGroup)vc.csObj).IsVisible(arg0)));
    }

    return true;
}

static bool CullingGroup_QueryIndices__Boolean__Int32__Int32_Array__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 4) 
    {
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        System.Int32 arg1 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.Int32[] arg2 = JSDataExchangeMgr.GetJSArg<System.Int32[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new System.Int32[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (System.Int32)JSApi.getInt32((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        System.Int32 arg3 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(((UnityEngine.CullingGroup)vc.csObj).QueryIndices(arg0, arg1, arg2, arg3)));
    }

    return true;
}

static bool CullingGroup_QueryIndices__Int32__Int32_Array__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.Int32[] arg1 = JSDataExchangeMgr.GetJSArg<System.Int32[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new System.Int32[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (System.Int32)JSApi.getInt32((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(((UnityEngine.CullingGroup)vc.csObj).QueryIndices(arg0, arg1, arg2)));
    }

    return true;
}

static bool CullingGroup_QueryIndices__Boolean__Int32_Array__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        System.Int32[] arg1 = JSDataExchangeMgr.GetJSArg<System.Int32[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new System.Int32[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (System.Int32)JSApi.getInt32((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(((UnityEngine.CullingGroup)vc.csObj).QueryIndices(arg0, arg1, arg2)));
    }

    return true;
}

static bool CullingGroup_SetBoundingDistances__Single_Array(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
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
        ((UnityEngine.CullingGroup)vc.csObj).SetBoundingDistances(arg0);
    }

    return true;
}

static bool CullingGroup_SetBoundingSphereCount__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        ((UnityEngine.CullingGroup)vc.csObj).SetBoundingSphereCount(arg0);
    }

    return true;
}

static bool CullingGroup_SetBoundingSpheres__BoundingSphere_Array(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.BoundingSphere[] arg0 = JSDataExchangeMgr.GetJSArg<UnityEngine.BoundingSphere[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new UnityEngine.BoundingSphere[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (UnityEngine.BoundingSphere)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        ((UnityEngine.CullingGroup)vc.csObj).SetBoundingSpheres(arg0);
    }

    return true;
}

static bool CullingGroup_SetDistanceReferencePoint__Transform(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Transform arg0 = (UnityEngine.Transform)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        ((UnityEngine.CullingGroup)vc.csObj).SetDistanceReferencePoint(arg0);
    }

    return true;
}

static bool CullingGroup_SetDistanceReferencePoint__Vector3(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        ((UnityEngine.CullingGroup)vc.csObj).SetDistanceReferencePoint(arg0);
    }

    return true;
}
public static MethodID methodID12 = new MethodID("EraseSwapBack", "Void", TypeFlag.None, new string[]{"Int32", "T[]", "Int32&"}, new TypeFlag[]{TypeFlag.None, TypeFlag.IsArray, TypeFlag.IsRef});

static bool CullingGroup_EraseSwapBackT1__Int32__T_Array__Int32(JSVCall vc, int argc)
{
    // Get generic method by name and param count.
    MethodInfo method = JSDataExchangeMgr.makeGenericMethod(typeof(UnityEngine.CullingGroup), methodID12, 1); 
    if (method == null) return true;

    int len = argc - 1;
    if (len == 3) 
    {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        object arg1 = JSDataExchangeMgr.GetJSArg<object[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new object[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (object)JSMgr.datax.getWhatever((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        int r_arg2 = JSApi.getArgIndex();
System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.ArgRef);
        object[] arr_t = new object[]{ arg0, arg1, arg2 };
        method.Invoke(null, arr_t);
        JSApi.setArgIndex(r_arg2);
        JSApi.setInt32((int)JSApi.SetType.ArgRef, arg2);
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.CullingGroup);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        CullingGroup_onStateChanged,
        CullingGroup_enabled,
        CullingGroup_targetCamera,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(CullingGroup_CullingGroup1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(CullingGroup_Dispose, "Dispose"),
        new JSMgr.MethodCallBackInfo(CullingGroup_EraseSwapBack__Int32, "EraseSwapBack"),
        new JSMgr.MethodCallBackInfo(CullingGroup_GetDistance__Int32, "GetDistance"),
        new JSMgr.MethodCallBackInfo(CullingGroup_IsVisible__Int32, "IsVisible"),
        new JSMgr.MethodCallBackInfo(CullingGroup_QueryIndices__Boolean__Int32__Int32_Array__Int32, "QueryIndices"),
        new JSMgr.MethodCallBackInfo(CullingGroup_QueryIndices__Int32__Int32_Array__Int32, "QueryIndices"),
        new JSMgr.MethodCallBackInfo(CullingGroup_QueryIndices__Boolean__Int32_Array__Int32, "QueryIndices"),
        new JSMgr.MethodCallBackInfo(CullingGroup_SetBoundingDistances__Single_Array, "SetBoundingDistances"),
        new JSMgr.MethodCallBackInfo(CullingGroup_SetBoundingSphereCount__Int32, "SetBoundingSphereCount"),
        new JSMgr.MethodCallBackInfo(CullingGroup_SetBoundingSpheres__BoundingSphere_Array, "SetBoundingSpheres"),
        new JSMgr.MethodCallBackInfo(CullingGroup_SetDistanceReferencePoint__Transform, "SetDistanceReferencePoint"),
        new JSMgr.MethodCallBackInfo(CullingGroup_SetDistanceReferencePoint__Vector3, "SetDistanceReferencePoint"),
        new JSMgr.MethodCallBackInfo(CullingGroup_EraseSwapBackT1__Int32__T_Array__Int32, "EraseSwapBack"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
