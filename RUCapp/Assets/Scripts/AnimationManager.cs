using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;

public class AnimationManager : MonoBehaviour
{
    public RectTransform backGround;
    public GameObject Todo;
    public GameObject Calendar;
    public GameObject RucUdvalg;

    void start ()
    {

    }
    public void menuButton()
    {
        backGround.DOAnchorPos(new Vector2(330,0),1f);

        if (backGround.anchoredPosition.x == 330)
        {
            backGround.DOAnchorPos(new Vector2(0,0),1f);
        }
    }

    public void todoButton() 
    {

        Calendar.SetActive(false);
        RucUdvalg.SetActive(false);

        if(Todo != null) {
            bool isActive = Todo.activeSelf;
            Todo.SetActive(!isActive);
        }
        if(backGround.anchoredPosition.x == 330)
        {
            backGround.DOAnchorPos(new Vector2(0,0),1f);
        }
        if (Todo.activeSelf != true)
        {
            Todo.SetActive(true);
        }
    }
    public void calendarButton()
    {
        Todo.SetActive(false);
        RucUdvalg.SetActive(false);

        if (Calendar != null) {
            bool isActive = Calendar.activeSelf;
            Calendar.SetActive(!isActive);
        }
        if (backGround.anchoredPosition.x == 330)
        {
            backGround.DOAnchorPos(new Vector2(0,0),1f);
        }
        if (Calendar.activeSelf != true)
        {
            Calendar.SetActive(true);
        }
    }
    public void rucudvalgButton()
        {
        Todo.SetActive(false);
        Calendar.SetActive(false);
        
        if (RucUdvalg != null) {
        bool isActive = RucUdvalg.activeSelf;
        RucUdvalg.SetActive(!isActive);
        }
        if (backGround.anchoredPosition.x == 330)
        {
            backGround.DOAnchorPos(new Vector2(0,0),1f);
        }
        if (RucUdvalg.activeSelf != true)
        {
            RucUdvalg.SetActive(true);
        }
    }

}