using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Experimental.Networking;
using UnityEngine.Networking;
using System.Net.Http;
using System;
using System.Linq;
// using HtmlAgilityPack;

// public class API : MonoBehaviour
// {
//     private const string URL = ("www.google.com");
//     public Text responseText;
//     public string coursedate { get; set; }
//     public string coursenumber { get; set; }
//     public string teacher { get; set; }
//     public string coursetype { get; set; }
    
//   /*  public void Request()
//     {
//         StartCoroutine(GetText());
 //   }

//     IEnumerator GetText()
//     {

//     using (UnityWebRequest request = UnityWebRequest.Get("google.com"))
//     {
//         yield return request.SendWebRequest();

//         if (request.isNetworkError) // Error
//         {
//             Debug.Log(request.error);
//         }
//         else // Success
//         {
//             //  responseText.text = request.downloadHandler.text.ToString();
//             Debug.Log(request.downloadHandler.text);
//         }
//     }
// */
    
    //     private static async void tain()
    //         {
    //         var httpClient = new HttpClient();
    //         var url = "https://moodle.ruc.dk/course/view.php?id=13194";
    //         var html = await httpClient.GetStringAsync(url);
    //         var htmlDocument = new HtmlDocument();
    //         htmlDocument.LoadHtml(html);

    //         var Courses = htmlDocument.DocumentNode.Descendants("ul")
    //             .Where(node => node.GetAttributeValue("id", "")
    //             .Equals("Topics")).ToList();
            
    //         var CourselistItems = Courses[0].Descendants("p")
    //             .Where(node => node.GetAttributeValue("id", "")
    //             .Contains("")).ToList();

    //        var Courselist = Courses[0].Descendants("P")
    //             .Where(node => node.GetAttributeValue("id", "")
    //             .Contains("")).ToList();
    //     }
    // }