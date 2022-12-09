using System;
using System.IO;
using SharpOpenJTalk.Lang;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
   [SerializeField] private Text text;

   private void Start()
   {
      try
      {
         var instance = new OpenJTalkAPI();

         var dictPath = Path.Combine(Application.streamingAssetsPath, "dic_utf_8");

         if (!instance.Initialize(dictPath))
         {
            text.text = "Initialize failed";
            return;
         }

         var labels = instance.GetLabels("これはテストです");

         text.text = string.Join(",", labels);
      }
      catch (Exception e)
      {
         text.text = $"{e.Message}\n{e.StackTrace}";
         throw;
      }
   }
}
