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

public class JSB_UnityEngine_ParticleSystem_TextureSheetAnimationModule
{

////////////////////// TextureSheetAnimationModule ///////////////////////////////////////
// constructors

// fields

// properties
static void TextureSheetAnimationModule_enabled(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.TextureSheetAnimationModule _this = (UnityEngine.ParticleSystem.TextureSheetAnimationModule)vc.csObj;
        var result = _this.enabled;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.TextureSheetAnimationModule _this = (UnityEngine.ParticleSystem.TextureSheetAnimationModule)vc.csObj;
        _this.enabled = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void TextureSheetAnimationModule_numTilesX(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.TextureSheetAnimationModule _this = (UnityEngine.ParticleSystem.TextureSheetAnimationModule)vc.csObj;
        var result = _this.numTilesX;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else
    { 
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.TextureSheetAnimationModule _this = (UnityEngine.ParticleSystem.TextureSheetAnimationModule)vc.csObj;
        _this.numTilesX = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void TextureSheetAnimationModule_numTilesY(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.TextureSheetAnimationModule _this = (UnityEngine.ParticleSystem.TextureSheetAnimationModule)vc.csObj;
        var result = _this.numTilesY;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else
    { 
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.TextureSheetAnimationModule _this = (UnityEngine.ParticleSystem.TextureSheetAnimationModule)vc.csObj;
        _this.numTilesY = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void TextureSheetAnimationModule_animation(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.TextureSheetAnimationModule _this = (UnityEngine.ParticleSystem.TextureSheetAnimationModule)vc.csObj;
        var result = _this.animation;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.ParticleSystemAnimationType arg0 = (UnityEngine.ParticleSystemAnimationType)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.TextureSheetAnimationModule _this = (UnityEngine.ParticleSystem.TextureSheetAnimationModule)vc.csObj;
        _this.animation = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void TextureSheetAnimationModule_useRandomRow(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.TextureSheetAnimationModule _this = (UnityEngine.ParticleSystem.TextureSheetAnimationModule)vc.csObj;
        var result = _this.useRandomRow;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.TextureSheetAnimationModule _this = (UnityEngine.ParticleSystem.TextureSheetAnimationModule)vc.csObj;
        _this.useRandomRow = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void TextureSheetAnimationModule_frameOverTime(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.TextureSheetAnimationModule _this = (UnityEngine.ParticleSystem.TextureSheetAnimationModule)vc.csObj;
        var result = _this.frameOverTime;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.ParticleSystem.MinMaxCurve arg0 = (UnityEngine.ParticleSystem.MinMaxCurve)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.TextureSheetAnimationModule _this = (UnityEngine.ParticleSystem.TextureSheetAnimationModule)vc.csObj;
        _this.frameOverTime = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void TextureSheetAnimationModule_cycleCount(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.TextureSheetAnimationModule _this = (UnityEngine.ParticleSystem.TextureSheetAnimationModule)vc.csObj;
        var result = _this.cycleCount;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else
    { 
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.TextureSheetAnimationModule _this = (UnityEngine.ParticleSystem.TextureSheetAnimationModule)vc.csObj;
        _this.cycleCount = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void TextureSheetAnimationModule_rowIndex(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ParticleSystem.TextureSheetAnimationModule _this = (UnityEngine.ParticleSystem.TextureSheetAnimationModule)vc.csObj;
        var result = _this.rowIndex;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else
    { 
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.ParticleSystem.TextureSheetAnimationModule _this = (UnityEngine.ParticleSystem.TextureSheetAnimationModule)vc.csObj;
        _this.rowIndex = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.ParticleSystem.TextureSheetAnimationModule);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        TextureSheetAnimationModule_enabled,
        TextureSheetAnimationModule_numTilesX,
        TextureSheetAnimationModule_numTilesY,
        TextureSheetAnimationModule_animation,
        TextureSheetAnimationModule_useRandomRow,
        TextureSheetAnimationModule_frameOverTime,
        TextureSheetAnimationModule_cycleCount,
        TextureSheetAnimationModule_rowIndex,

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
