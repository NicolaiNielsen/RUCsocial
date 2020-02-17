// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using System.IO;

// public class CheckListManager : MonoBehaviour
// {
//     public Transform content;
//     public GameObject AddPanel;
//     public Button CreateButton;
//     public GameObject CheckListItemPrefab;
//     string filepath;
//     private List<CheckListObject> checklistObjects = new List<CheckListObject>();
//     public InputField[] addInputFields;

//     private void Start()
//     {
//         filepath = Application.persistentDataPath + "/checklist.txt";
//         addInputFields = AddPanel.GetComponentsInChildren<InputField>();

//         CreateButton.onClick.AddListener(delegate { CreateCheckListItem(addInputFields[0].text); });
//     }
//     public void SwitchMode(int mode)
//     {
//         switch (mode)
//         {
//             regular checklist mode
//             case 0:
//             AddPanel.SetActive(false);
//             break;
//             adding a new checklist item
//             case 1:
//             AddPanel.SetActive(true);
//             break;
//         }
//     }
//     public void CreateCheckListItem(string name)
//     {
//         GameObject item = Instantiate(CheckListItemPrefab);
//         item.transform.SetParent(content);
//         CheckListObject itemObject = item.GetComponent<CheckListObject>();
//         int index = 0;
//         if(checklistObjects.Count > 0)
//         {
//           index = checklistObjects.Count - 1;
//         }
//         itemObject.SetObjectInfo(name, index);
//         checklistObjects.Add(itemObject);
//         CheckListObject temp = itemObject;
//         itemObject.GetComponent<Toggle>().onValueChanged.AddListener(delegate {CheckItem(temp); });

//         SwitchMode(0);
//     } 

//     void CheckItem(CheckListObject item)
//     {
//         checklistObjects.Remove(item);
//         Destroy(item.gameObject);
//     }
//     void SaveJSONData()
//     {

//             string contents = "";
//             for(int i = 0; i < checklistObjects.Count; i++)
//             {
//                 contents += JsonUtility.ToJson(checklistObjects[i]) + "n";
//             }
//             File.WriteAllText(filepath, contents);
//     }
// }
