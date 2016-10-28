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

public class JSB_UnityEngine_HumanDescription
{

////////////////////// HumanDescription ///////////////////////////////////////
// constructors
public static ConstructorID constructorID0 = new ConstructorID(null, null);

static bool HumanDescription_HumanDescription1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.HumanDescription());
    }

    return true;
}

// fields
static void HumanDescription_human(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.HumanDescription _this = (UnityEngine.HumanDescription)vc.csObj;
        var result = _this.human;
                var arrRet = result;
        for (int i = 0; arrRet != null && i < arrRet.Length; i++)
        {
            JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
            JSApi.moveSaveID2Arr(i);
        }
        JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }
    else {
        UnityEngine.HumanBone[] arg0 = JSDataExchangeMgr.GetJSArg<UnityEngine.HumanBone[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new UnityEngine.HumanBone[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (UnityEngine.HumanBone)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        UnityEngine.HumanDescription _this = (UnityEngine.HumanDescription)vc.csObj;
        _this.human = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void HumanDescription_skeleton(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.HumanDescription _this = (UnityEngine.HumanDescription)vc.csObj;
        var result = _this.skeleton;
                var arrRet = result;
        for (int i = 0; arrRet != null && i < arrRet.Length; i++)
        {
            JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
            JSApi.moveSaveID2Arr(i);
        }
        JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }
    else {
        UnityEngine.SkeletonBone[] arg0 = JSDataExchangeMgr.GetJSArg<UnityEngine.SkeletonBone[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new UnityEngine.SkeletonBone[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (UnityEngine.SkeletonBone)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        UnityEngine.HumanDescription _this = (UnityEngine.HumanDescription)vc.csObj;
        _this.skeleton = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}

// properties
static void HumanDescription_upperArmTwist(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.HumanDescription _this = (UnityEngine.HumanDescription)vc.csObj;
        var result = _this.upperArmTwist;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.HumanDescription _this = (UnityEngine.HumanDescription)vc.csObj;
        _this.upperArmTwist = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void HumanDescription_lowerArmTwist(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.HumanDescription _this = (UnityEngine.HumanDescription)vc.csObj;
        var result = _this.lowerArmTwist;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.HumanDescription _this = (UnityEngine.HumanDescription)vc.csObj;
        _this.lowerArmTwist = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void HumanDescription_upperLegTwist(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.HumanDescription _this = (UnityEngine.HumanDescription)vc.csObj;
        var result = _this.upperLegTwist;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.HumanDescription _this = (UnityEngine.HumanDescription)vc.csObj;
        _this.upperLegTwist = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void HumanDescription_lowerLegTwist(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.HumanDescription _this = (UnityEngine.HumanDescription)vc.csObj;
        var result = _this.lowerLegTwist;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.HumanDescription _this = (UnityEngine.HumanDescription)vc.csObj;
        _this.lowerLegTwist = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void HumanDescription_armStretch(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.HumanDescription _this = (UnityEngine.HumanDescription)vc.csObj;
        var result = _this.armStretch;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.HumanDescription _this = (UnityEngine.HumanDescription)vc.csObj;
        _this.armStretch = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void HumanDescription_legStretch(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.HumanDescription _this = (UnityEngine.HumanDescription)vc.csObj;
        var result = _this.legStretch;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.HumanDescription _this = (UnityEngine.HumanDescription)vc.csObj;
        _this.legStretch = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void HumanDescription_feetSpacing(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.HumanDescription _this = (UnityEngine.HumanDescription)vc.csObj;
        var result = _this.feetSpacing;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.HumanDescription _this = (UnityEngine.HumanDescription)vc.csObj;
        _this.feetSpacing = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void HumanDescription_hasTranslationDoF(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.HumanDescription _this = (UnityEngine.HumanDescription)vc.csObj;
        var result = _this.hasTranslationDoF;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.HumanDescription _this = (UnityEngine.HumanDescription)vc.csObj;
        _this.hasTranslationDoF = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.HumanDescription);
    ci.fields = new JSMgr.CSCallbackField[]
    {
        HumanDescription_human,
        HumanDescription_skeleton,

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        HumanDescription_upperArmTwist,
        HumanDescription_lowerArmTwist,
        HumanDescription_upperLegTwist,
        HumanDescription_lowerLegTwist,
        HumanDescription_armStretch,
        HumanDescription_legStretch,
        HumanDescription_feetSpacing,
        HumanDescription_hasTranslationDoF,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(HumanDescription_HumanDescription1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
