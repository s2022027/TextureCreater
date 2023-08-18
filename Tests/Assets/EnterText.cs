using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

//
using UnityEditor;
using UnityEditor.Scripting.Python;
using System.IO;

using System.Text;

//using IronPython.Hosting;
//using Python.Runtime;

public class EnterText : MonoBehaviour
{
   public GameObject inputf;
   public GameObject result;
   public string file;
   public Material material1;
   public Texture texture1;
   public CombineScript combineScript;
   //public static dynamic input;

   void Start()
   {

   }

   void Update()
   {

   }

   public void GetInput(){
       string file = inputf.GetComponent<InputField>().text;
       result.GetComponent<Text>().text = file;
       inputf.GetComponent<InputField>().text = "";
       // gettext = inputf.GetComponent<InputField>().text;
       Debug.Log(file);

       //string arg = "kirin";
       
       //Encoding enc = Encoding.GetEncoding("Shift_JIS");
       //using (StreamWriter writer = new StreamWriter("Assets/Resources/FileName.txt", false, enc))
       //{
       //    writer.WriteLine(arg);
           //writer.WriteLine(file);
       //}
       string path = "Assets/Resources/FileName.txt";
       File.WriteAllText(path, file);


       //
       //TestPython test = new TestPython();
       //TestComponent componentPython = GameObject.Find("TestObject").GetComponent<TestComponent>();

       //var script = Resources.Load<TextAsset>("file").text;
       //var scriptEngine = IronPython.Hosting.Python.CreateEngine();
       //var scriptScope = scriptEngine.CreateScope();

       //scriptScope.SetVariable("TexCreater20230630",file);

       var pythonpath = "Assets/TexCreater20230630.py";
       //var arguments = new List<string>
       //{
       //    pythonpath,
       //    file
       //};
       PythonRunner.RunFile(pythonpath,file);
       AssetDatabase.SaveAssets();
       AssetDatabase.Refresh();
       //PythonRunner.RunFile("Assets/TexCreater20230630.py", file);

       //string scriptPath = Path.Combine(file,"Assets/TexCreater20230630.py");
       //PythonRunner.RunFile(scriptPath);

       material1 = Resources.Load<Material>("TestMaterial");
       //texture = this.GetComponent<Texture>();
       //texture1 = Resources.Load<Texture>("kirin_texture_test");
       texture1 = Resources.Load<Texture>(file+"_texture_test");
       combineScript.NormalmapTexture = texture1;
       combineScript.targetMaterial = material1;
       combineScript.texchange();

       //InputField column = GameObject.Find("InputField").GetComponent<InputField>();
       //column.text = "";
   }

   

   public void CreateTexture()
    {
        //public static dynamic File;
        //File = GetInput.input;
        //string File = inputf.GetComponent<InputField>().text;
        //result.GetComponent<Text>().text = File;
        //Debug.Log(input);
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

    public void SetTexture()
    {
        //Debug.Log(GetInput.file);
    }
}
