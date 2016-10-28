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

public class JSB_UnityEngine_ParticlePhysicsExtensions
{

////////////////////// ParticlePhysicsExtensions ///////////////////////////////////////
// constructors

// fields

// properties

// methods

static bool ParticlePhysicsExtensions_GetCollisionEvents__ParticleSystem__GameObject__ParticleCollisionEvent_Array(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        UnityEngine.ParticleSystem arg0 = (UnityEngine.ParticleSystem)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.GameObject arg1 = (UnityEngine.GameObject)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ParticleCollisionEvent[] arg2 = JSDataExchangeMgr.GetJSArg<UnityEngine.ParticleCollisionEvent[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new UnityEngine.ParticleCollisionEvent[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (UnityEngine.ParticleCollisionEvent)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(UnityEngine.ParticlePhysicsExtensions.GetCollisionEvents(arg0, arg1, arg2)));
    }

    return true;
}

static bool ParticlePhysicsExtensions_GetSafeCollisionEventSize__ParticleSystem(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.ParticleSystem arg0 = (UnityEngine.ParticleSystem)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(UnityEngine.ParticlePhysicsExtensions.GetSafeCollisionEventSize(arg0)));
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.ParticlePhysicsExtensions);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(ParticlePhysicsExtensions_GetCollisionEvents__ParticleSystem__GameObject__ParticleCollisionEvent_Array, "GetCollisionEvents"),
        new JSMgr.MethodCallBackInfo(ParticlePhysicsExtensions_GetSafeCollisionEventSize__ParticleSystem, "GetSafeCollisionEventSize"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
