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
        //public static dynamic File;
        //File = GetInput.input;
        //public class MenuItem_TexCreater20230630_Class
        //{
            //[MenuItem("Python Scripts/TexCreater20230630")]
            //public void TexCreater20230630()
            //{
        //int num = 1 ;
        PythonRunner.RunFile("Assets/TexCreater20230630.py");
        //UnityEngine.Debug.Log(num);
            //}
        //}    
    }
}