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

public class JSB_TestExtensionMethod
{

////////////////////// TestExtensionMethod ///////////////////////////////////////
// constructors

// fields

// properties

// methods
public static MethodID methodID0 = new MethodID("GetOrAddComponent", "T", TypeFlag.IsT, new string[]{"GameObject"}, new TypeFlag[]{TypeFlag.None});

static bool TestExtensionMethod_GetOrAddComponentT1__GameObject(JSVCall vc, int argc)
{
    // Get generic method by name and param count.
    MethodInfo method = JSDataExchangeMgr.makeGenericMethod(typeof(TestExtensionMethod), methodID0, 1); 
    if (method == null) return true;

    int len = argc - 1;
    if (len == 1) 
    {
        UnityEngine.GameObject arg0 = (UnityEngine.GameObject)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        object[] arr_t = new object[]{ arg0 };
                JSMgr.datax.setWhatever((int)JSApi.SetType.Rval, method.Invoke(null, arr_t));
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(TestExtensionMethod);
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
        new JSMgr.MethodCallBackInfo(TestExtensionMethod_GetOrAddComponentT1__GameObject, "GetOrAddComponent"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
