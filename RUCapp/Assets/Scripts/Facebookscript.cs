// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using Facebook.Unity;
// using UnityEngine.UI;

// public class Facebookscript : MonoBehaviour
// {
//     //Initalize facebook
//     private void Awake()
//     {
//         FB.Init (SetInit, OnHideUnity);
//     }

//     private void SetInit()
//     {
//         Debug.Log("FB init initalized");

//         if(FB.IsLoggedIn)
//         {
//             Debug.Log("FB logged in");
//         }
//         else
//         {
//             FBlogin();
//         }
//     }

//     private void OnHideUnity(bool isGameShown)
//     {
//         if(!isGameShown)
//         {
//             Time.timeScale = 0;
//         }
//         else
//         {
//             Time.timeScale = 1; 
//         }
//     }

//     void FBlogin()
//     {
//     FB.LogInWithReadPermissions (
//     new List<string>(){"public_profile", "email"},
//     AuthCallBack);
//     }

//     void AuthCallBack(ILoginResult result)
//     {
//         if(FB.IsLoggedIn)
//         {
//             Debug.Log("FB LOGIN SUCCES");
//         }
//         else
//         {
//             Debug.Log("FB LOGIN FAILED");
//         }
//     }
// }