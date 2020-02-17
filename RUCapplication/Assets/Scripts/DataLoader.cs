using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

public class DataLoader : MonoBehaviour
{
        public string[] items;
        private string localhost = "http://localhost/facebook_events/itemsData.php";

        public void StartCoroutineServerData()
        {
            StartCoroutine(ServerRequest());
            Debug.Log("Do i work");
        }

        IEnumerator ServerRequest()
        {
            UnityWebRequest request = UnityWebRequest.Get(localhost);
            yield return request.SendWebRequest();


            if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log(request.error);

            // find better solution in production
            Debug.Log("Server error ");

        }   else
        {   
            
            string FBDataString = request.downloadHandler.text;
            Debug.Log("FBDatastring");
            items = FBDataString.Split(';');
            Debug.Log(GetDataValue(items[0], "Name:"));
        }
        }

        string GetDataValue (string data, string index) 
        {
            string value = data.Substring(data.IndexOf(index)+index.Length);
            if(value.Contains("|"))
            value = value.Remove(value.IndexOf("|"));
            return value;
        }

}
