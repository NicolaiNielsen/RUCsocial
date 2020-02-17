// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using UnityEngine;
// using UnityEngine.UI;
// using System.IO;


//     class CS : MonoBehaviour
//     {
//         public Text responseText;
//         public void Button()
//         {
//             System.Net.CookieContainer myCookies = new System.Net.CookieContainer();
//             string mySrc = HttpMethod.Get("https://signon.ruc.dk/login?service=https%3A%2F%2Fmoodle.ruc.dk%2Flogin%2Findex.php", "https://signon.ruc.dk/login?service=https%3A%2F%2Fmoodle.ruc.dk%2Flogin%2Findex.php", ref myCookies);
//             string token = GetBetween(mySrc,  "name=\"execution\" value=\"" , "=\"/>");
//           //  string username = "niapni";
//           //  string password = "EQD35wfz";
//           // name="execution" value="="/>
          
//             string postData = "username=" + "niapni" + "&password=" + "EQD35wfz" + "&submit=Sign-on&execution=" + token;
//             bool result = HttpMethod.Post("https://signon.ruc.dk/login?service=https%3A%2F%2Fmoodle.ruc.dk%2Flogin%2Findex.php", postData, "https://signon.ruc.dk/login?service=https%3A%2F%2Fmoodle.ruc.dk%2Flogin%2Findex.php", myCookies);
//             if (result)
//                responseText.text = result.ToString();
//             else
//                 Debug.Log("Invalid!");
//         }
//         static string GetBetween(string msg, string start, string stop)
//         {
//             int StartIndex = msg.IndexOf(start) + start.Length;
//             int StopIndex = msg.IndexOf(stop);
//             return msg.Substring(StartIndex, StopIndex - StartIndex);
//         }
//     }

