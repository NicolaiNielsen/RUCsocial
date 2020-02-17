using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;

public class AnimationManager : MonoBehaviour
{
    public RectTransform sideMenu;
    // public GameObject frontPage;
    // public GameObject udvalgTab;
    // public GameObject shopTab;

    private bool menuButtonCoolDown = false;
    public Text changingText;
    public GameObject FrontPage;
    public GameObject Udvalgsside;
    
    void Start()
    {
        sideMenu.DOAnchorPos(new Vector2(-250,0), 1f);
    }

    public void menuButton()
    {
        if (menuButtonCoolDown == false )
        {
            sideMenu.DOAnchorPos(new Vector2(-250,0),1f);

                if (sideMenu.anchoredPosition.x == -250)
                {
                    sideMenu.DOAnchorPos(new Vector2(0,0),1f);
                }

            Invoke("ResetCooldown", 3.0f);
            menuButtonCoolDown = true;
        }
    }

    public void changeTopTitle()
    {
        changingText.text = "Udvalg";
    }

    void ResetCooldown() 
    {
        menuButtonCoolDown = false;
    }

    public void udvalgpageButton()
    {
        FrontPage.SetActive(false);

        if (Udvalgsside != null)
        {
            bool isActive = Udvalgsside.activeSelf;
            Udvalgsside.SetActive(isActive);

        }   if (Udvalgsside.activeSelf != true)
        {
            Udvalgsside.SetActive(true);
        }
        if(sideMenu.anchoredPosition.x == 0)
        {
        sideMenu.DOAnchorPos(new Vector2(-250,0),1f);
        }
        
            Invoke("ResetCooldown", 5.0f);
            menuButtonCoolDown = true;
        
        }

        public void frontpageButton()
    {
        Udvalgsside.SetActive(false);

        if (FrontPage != null)
        {
            bool isActive = FrontPage.activeSelf;
            FrontPage.SetActive(isActive);

        }   if (FrontPage.activeSelf != true)
        {
            FrontPage.SetActive(true);
        }
        if(sideMenu.anchoredPosition.x == 0)
        {
        sideMenu.DOAnchorPos(new Vector2(-250,0),1f);
        }
        
            Invoke("ResetCooldown", 5.0f);
            menuButtonCoolDown = true;
        
        }

    }




