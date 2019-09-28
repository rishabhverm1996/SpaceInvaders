using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace SpaceInvader.Storege
{
    public class StorageManager : MonoBehaviour
    {
        public const string JSON_PATH = "JSON";
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public static T LoadJSON<T>(string fileName)
        {
            T l_jsonData;
            string pathName = Path.Combine(JSON_PATH,fileName);
            TextAsset l_TextAsset = Resources.Load<TextAsset>(pathName);
            l_jsonData = JsonUtility.FromJson<T>(l_TextAsset.text);

            if (pathName == null)
            {
                Debug.LogError(" Path Not Found ");
                return l_jsonData;
            }

            if (l_TextAsset == null)
            {
                Debug.LogError(" Textasset Not Found ");
                return l_jsonData;
            }

            if (l_jsonData == null)
            {
                Debug.LogError(" JSONDATA Not Found ");
                return l_jsonData;
            }

            return l_jsonData;
        }
    }
}