﻿//
// Automatically generated by JSComponentGenerator.
//
using UnityEngine;

public class JSComponent_GUI_TransChange_Application_Physics_Render_Visible : JSComponent
{
    int idOnGUI;
    int idOnTransformChildrenChanged;
    int idOnTransformParentChanged;
    int idOnApplicationFocus;
    int idOnApplicationPause;
    int idOnApplicationQuit;
    int idOnCollisionEnter;
    int idOnCollisionExit;
    int idOnCollisionStay;
    int idOnTriggerEnter;
    int idOnTriggerExit;
    int idOnTriggerStay;
    int idOnControllerColliderHit;
    int idOnPostRender;
    int idOnPreCull;
    int idOnPreRender;
    int idOnRenderObject;
    int idOnWillRenderObject;
    int idOnBecameInvisible;
    int idOnBecameVisible;

    protected override void initMemberFunction()
    {
        base.initMemberFunction();
        idOnGUI = JSApi.getObjFunction(jsObjID, "OnGUI");
        idOnTransformChildrenChanged = JSApi.getObjFunction(jsObjID, "OnTransformChildrenChanged");
        idOnTransformParentChanged = JSApi.getObjFunction(jsObjID, "OnTransformParentChanged");
        idOnApplicationFocus = JSApi.getObjFunction(jsObjID, "OnApplicationFocus");
        idOnApplicationPause = JSApi.getObjFunction(jsObjID, "OnApplicationPause");
        idOnApplicationQuit = JSApi.getObjFunction(jsObjID, "OnApplicationQuit");
        idOnCollisionEnter = JSApi.getObjFunction(jsObjID, "OnCollisionEnter");
        idOnCollisionExit = JSApi.getObjFunction(jsObjID, "OnCollisionExit");
        idOnCollisionStay = JSApi.getObjFunction(jsObjID, "OnCollisionStay");
        idOnTriggerEnter = JSApi.getObjFunction(jsObjID, "OnTriggerEnter");
        idOnTriggerExit = JSApi.getObjFunction(jsObjID, "OnTriggerExit");
        idOnTriggerStay = JSApi.getObjFunction(jsObjID, "OnTriggerStay");
        idOnControllerColliderHit = JSApi.getObjFunction(jsObjID, "OnControllerColliderHit");
        idOnPostRender = JSApi.getObjFunction(jsObjID, "OnPostRender");
        idOnPreCull = JSApi.getObjFunction(jsObjID, "OnPreCull");
        idOnPreRender = JSApi.getObjFunction(jsObjID, "OnPreRender");
        idOnRenderObject = JSApi.getObjFunction(jsObjID, "OnRenderObject");
        idOnWillRenderObject = JSApi.getObjFunction(jsObjID, "OnWillRenderObject");
        idOnBecameInvisible = JSApi.getObjFunction(jsObjID, "OnBecameInvisible");
        idOnBecameVisible = JSApi.getObjFunction(jsObjID, "OnBecameVisible");
    }

    void OnGUI()
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnGUI);
    }
    void OnTransformChildrenChanged()
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnTransformChildrenChanged);
    }
    void OnTransformParentChanged()
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnTransformParentChanged);
    }
    void OnApplicationFocus(bool focusStatus)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnApplicationFocus, focusStatus);
    }
    void OnApplicationPause(bool pauseStatus)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnApplicationPause, pauseStatus);
    }
    void OnApplicationQuit()
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnApplicationQuit);
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnCollisionEnter, collisionInfo);
    }
    void OnCollisionExit(Collision collisionInfo)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnCollisionExit, collisionInfo);
    }
    void OnCollisionStay(Collision collisionInfo)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnCollisionStay, collisionInfo);
    }
    void OnTriggerEnter(Collider other)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnTriggerEnter, other);
    }
    void OnTriggerExit(Collider other)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnTriggerExit, other);
    }
    void OnTriggerStay(Collider other)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnTriggerStay, other);
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnControllerColliderHit, hit);
    }
    void OnPostRender()
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnPostRender);
    }
    void OnPreCull()
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnPreCull);
    }
    void OnPreRender()
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnPreRender);
    }
    void OnRenderObject()
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnRenderObject);
    }
    void OnWillRenderObject()
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnWillRenderObject);
    }
    void OnBecameInvisible()
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnBecameInvisible);
    }
    void OnBecameVisible()
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnBecameVisible);
    }

}