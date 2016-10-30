using UnityEngine;
using System.Collections;

public class SetJSModel : MonoBehaviour 
{
    public bool UseJSModel = false;

    public void Awake()
    {
        VersionControl.isUseJS = UseJSModel;
    }
}
