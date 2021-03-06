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

public class JSB_UnityEngine_RenderSettings
{

////////////////////// RenderSettings ///////////////////////////////////////
// constructors

static bool RenderSettings_RenderSettings1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.RenderSettings());
    }

    return true;
}

// fields

// properties
static void RenderSettings_fog(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.fog;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.fog = arg0;
    }
}
static void RenderSettings_fogMode(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.fogMode;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.FogMode arg0 = (UnityEngine.FogMode)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.fogMode = arg0;
    }
}
static void RenderSettings_fogColor(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.fogColor;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.fogColor = arg0;
    }
}
static void RenderSettings_fogDensity(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.fogDensity;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.fogDensity = arg0;
    }
}
static void RenderSettings_fogStartDistance(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.fogStartDistance;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.fogStartDistance = arg0;
    }
}
static void RenderSettings_fogEndDistance(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.fogEndDistance;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.fogEndDistance = arg0;
    }
}
static void RenderSettings_ambientMode(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.ambientMode;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.Rendering.AmbientMode arg0 = (UnityEngine.Rendering.AmbientMode)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.ambientMode = arg0;
    }
}
static void RenderSettings_ambientSkyColor(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.ambientSkyColor;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.ambientSkyColor = arg0;
    }
}
static void RenderSettings_ambientEquatorColor(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.ambientEquatorColor;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.ambientEquatorColor = arg0;
    }
}
static void RenderSettings_ambientGroundColor(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.ambientGroundColor;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.ambientGroundColor = arg0;
    }
}
static void RenderSettings_ambientLight(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.ambientLight;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.ambientLight = arg0;
    }
}
static void RenderSettings_ambientIntensity(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.ambientIntensity;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.ambientIntensity = arg0;
    }
}
static void RenderSettings_ambientProbe(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.ambientProbe;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Rendering.SphericalHarmonicsL2 arg0 = (UnityEngine.Rendering.SphericalHarmonicsL2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.ambientProbe = arg0;
    }
}
static void RenderSettings_reflectionIntensity(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.reflectionIntensity;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.reflectionIntensity = arg0;
    }
}
static void RenderSettings_reflectionBounces(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.reflectionBounces;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else
    { 
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.reflectionBounces = arg0;
    }
}
static void RenderSettings_haloStrength(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.haloStrength;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.haloStrength = arg0;
    }
}
static void RenderSettings_flareStrength(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.flareStrength;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.flareStrength = arg0;
    }
}
static void RenderSettings_flareFadeSpeed(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.flareFadeSpeed;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.flareFadeSpeed = arg0;
    }
}
static void RenderSettings_skybox(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.skybox;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Material arg0 = (UnityEngine.Material)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.skybox = arg0;
    }
}
static void RenderSettings_defaultReflectionMode(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.defaultReflectionMode;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.Rendering.DefaultReflectionMode arg0 = (UnityEngine.Rendering.DefaultReflectionMode)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.defaultReflectionMode = arg0;
    }
}
static void RenderSettings_defaultReflectionResolution(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.defaultReflectionResolution;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else
    { 
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.defaultReflectionResolution = arg0;
    }
}
static void RenderSettings_customReflection(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.customReflection;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Cubemap arg0 = (UnityEngine.Cubemap)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.customReflection = arg0;
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.RenderSettings);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        RenderSettings_fog,
        RenderSettings_fogMode,
        RenderSettings_fogColor,
        RenderSettings_fogDensity,
        RenderSettings_fogStartDistance,
        RenderSettings_fogEndDistance,
        RenderSettings_ambientMode,
        RenderSettings_ambientSkyColor,
        RenderSettings_ambientEquatorColor,
        RenderSettings_ambientGroundColor,
        RenderSettings_ambientLight,
        RenderSettings_ambientIntensity,
        RenderSettings_ambientProbe,
        RenderSettings_reflectionIntensity,
        RenderSettings_reflectionBounces,
        RenderSettings_haloStrength,
        RenderSettings_flareStrength,
        RenderSettings_flareFadeSpeed,
        RenderSettings_skybox,
        RenderSettings_defaultReflectionMode,
        RenderSettings_defaultReflectionResolution,
        RenderSettings_customReflection,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(RenderSettings_RenderSettings1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
