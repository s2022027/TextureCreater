using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEditor.Scripting.Python;
using System.IO;
using System.Text;


public class EnterText : MonoBehaviour
{
   public GameObject inputf;
   public GameObject result;
   public string file;
   public Material material1;
   public Texture texture1;
   public CombineScript combineScript;
   

   public void GetInput(){
       string file = inputf.GetComponent<InputField>().text;
       result.GetComponent<Text>().text = file;
       inputf.GetComponent<InputField>().text = "";
       Debug.Log(file);
    
       string path = "Assets/Resources/FileName.txt";
       File.WriteAllText(path, file);


       var pythonpath = "Assets/TexCreater20230630.py";
       
       PythonRunner.RunFile(pythonpath,file);
       AssetDatabase.SaveAssets();
       AssetDatabase.Refresh();
       

       material1 = Resources.Load<Material>("TestMaterial");
       texture1 = Resources.Load<Texture>(file+"_texture_test");
       combineScript.NormalmapTexture = texture1;
       combineScript.targetMaterial = material1;
       combineScript.texchange();

   }

   

   public void CreateTexture()
    {
        
        PythonRunner.RunFile("Assets/TexCreater20230630.py");
           
    }

    
}
