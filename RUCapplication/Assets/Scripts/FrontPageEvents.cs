using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrontPageEvents : MonoBehaviour
{
    public Transform content;
    public GameObject EventFrontpageScrollPrefab;

    private List<FrontpageObjects> frontpageobjects = new List<FrontpageObjects>();

    void CreateFBEvent(string name, int index)
    {
        GameObject item = Instantiate(EventFrontpageScrollPrefab);

        item.transform.SetParent(content);
        FrontpageObjects itemObject = item.GetComponentInChildren<FrontpageObjects>();
        itemObject.SetObjectInfo(name, index);
        frontpageobjects.Add(itemObject);
        FrontpageObjects temp = itemObject;


        // function til at slette prefab men find måde at gøre det hvis det overskrider en bestemt dato 
        itemObject.GetComponent<Toggle>().onValueChanged.AddListener(delegate { CheckItem(temp); });

    }

    void CheckItem(FrontpageObjects item)
    {
        frontpageobjects.Remove(item);
    }

}
