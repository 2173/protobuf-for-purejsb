﻿//
// Automatically generated by JSComponentGenerator.
//
using UnityEngine;

public class JSComponent_GUI : JSComponent
{
    int idOnGUI;

    protected override void initMemberFunction()
    {
        base.initMemberFunction();
        idOnGUI = JSApi.getObjFunction(jsObjID, "OnGUI");
    }

    void OnGUI()
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnGUI);
    }

}