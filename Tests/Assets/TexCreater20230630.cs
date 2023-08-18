using UnityEditor;
using UnityEditor.Scripting.Python;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TexCreater20230630 : MonoBehaviour
{
    public void CreateTexture()
    {
        PythonRunner.RunFile("Assets/TexCreater20230630.py");
           
    }
}
