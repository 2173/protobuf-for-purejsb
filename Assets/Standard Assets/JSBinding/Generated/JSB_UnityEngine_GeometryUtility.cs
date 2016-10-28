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

public class JSB_UnityEngine_GeometryUtility
{

////////////////////// GeometryUtility ///////////////////////////////////////
// constructors

static bool GeometryUtility_GeometryUtility1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.GeometryUtility());
    }

    return true;
}

// fields

// properties

// methods

static bool GeometryUtility_CalculateFrustumPlanes__Matrix4x4(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Matrix4x4 arg0 = (UnityEngine.Matrix4x4)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = UnityEngine.GeometryUtility.CalculateFrustumPlanes(arg0);
        for (int i = 0; arrRet != null && i < arrRet.Length; i++)
        {
            JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
            JSApi.moveSaveID2Arr(i);
        }
        JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }

    return true;
}

static bool GeometryUtility_CalculateFrustumPlanes__Camera(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Camera arg0 = (UnityEngine.Camera)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = UnityEngine.GeometryUtility.CalculateFrustumPlanes(arg0);
        for (int i = 0; arrRet != null && i < arrRet.Length; i++)
        {
            JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
            JSApi.moveSaveID2Arr(i);
        }
        JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }

    return true;
}

static bool GeometryUtility_TestPlanesAABB__Plane_Array__Bounds(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        UnityEngine.Plane[] arg0 = JSDataExchangeMgr.GetJSArg<UnityEngine.Plane[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new UnityEngine.Plane[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (UnityEngine.Plane)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        UnityEngine.Bounds arg1 = (UnityEngine.Bounds)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(UnityEngine.GeometryUtility.TestPlanesAABB(arg0, arg1)));
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.GeometryUtility);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(GeometryUtility_GeometryUtility1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(GeometryUtility_CalculateFrustumPlanes__Matrix4x4, "CalculateFrustumPlanes"),
        new JSMgr.MethodCallBackInfo(GeometryUtility_CalculateFrustumPlanes__Camera, "CalculateFrustumPlanes"),
        new JSMgr.MethodCallBackInfo(GeometryUtility_TestPlanesAABB__Plane_Array__Bounds, "TestPlanesAABB"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
