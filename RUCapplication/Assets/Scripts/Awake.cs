using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using Newtonsoft.Json;
using System.IO;
using System.Linq;


public class Awake : MonoBehaviour
{   

// FB Accestoken expires in march

    private string url = "https://graph.facebook.com/10221164107679021?fields=events&access_token=EAASj09a8NxwBAMUNMkEx3hz89znZAU8WzAdHk90Gr3vcJbmesafMorpixtcAvr1sv0rqLfVCT3QDabVmQkAH3v661ZBkfO3HFuAUMASKCuTl0R2sYCizKwmfLuU6xUWQrcmKaZBS7PaBMrnML0DdVNQEkfyzZAQZD";

//    Text FBEventText;

    public void startCoroutineDeseralizeEventData()
    {
        StartCoroutine(MakeTextRequest());
        Debug.Log("DO I WORK");
    }

    public void OnButtonLoader()
    {
        Debug.Log("Test");
    }

    IEnumerator MakeTextRequest()
    {
        UnityWebRequest request = UnityWebRequest.Get(url);
        yield return request.SendWebRequest();

        
        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log(request.error);
            Debug.Log("IDONT WORK FOR SOME REASON");

        }   else
        {   
              
            RootObject result = JsonConvert.DeserializeObject<RootObject>(request.downloadHandler.text);
            Debug.Log(result.events.Data[0].description);
            Debug.Log(result.events.Data[0].name);

        }
    }


}


