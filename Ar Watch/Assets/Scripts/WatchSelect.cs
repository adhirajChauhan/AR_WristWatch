using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WatchSelect : MonoBehaviour
{
    public GameObject watchModel1;
    public GameObject watchModel2;
    public GameObject watchModel3;

    public GameObject watch1Window;
    public GameObject watch2Window;
    public GameObject watch3Window;

    Animation w1WindowAnimation;
    Animation w2WindowAnimation;
    Animation w3WindowAnimation;


    void Start()
    {
        w1WindowAnimation = watch1Window.GetComponent<Animation>();
        w2WindowAnimation = watch2Window.GetComponent<Animation>();
        w3WindowAnimation = watch3Window.GetComponent<Animation>();

    }

    public void Watch1ButtonClick()
    {
        //Show watch1 on user wrist
        watchModel1.SetActive(true);
        watchModel2.SetActive(false);
        watchModel3.SetActive(false);

        //Animate watch 1 window
        w1WindowAnimation["w1animation"].speed = 1;
        w1WindowAnimation.Play();
    }

    public void Watch2ButtonClick()
    {
        watchModel1.SetActive(false);
        watchModel2.SetActive(true);
        watchModel3.SetActive(false);

        w2WindowAnimation["w2animation"].speed = 1;
        w2WindowAnimation.Play();
    }

    public void Watch3ButtonClick()
    {
        watchModel1.SetActive(false);
        watchModel2.SetActive(false);
        watchModel3.SetActive(true);

        w3WindowAnimation["w3animation"].speed = 1;
        w3WindowAnimation.Play();
    }

    public void CloseButtonClicked()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if (buttonName == "w1close")
        {
            //play anim
            w1WindowAnimation["w1animation"].speed = -1;
            w1WindowAnimation["w1animation"].time = w1WindowAnimation["w1animation"].length;
            w1WindowAnimation.Play();
        }
        else if(buttonName == "w2close")
        {
            w2WindowAnimation["w2animation"].speed = -1;
            w2WindowAnimation["w2animation"].time = w2WindowAnimation["w2animation"].length;
            w2WindowAnimation.Play();
        }

        else if (buttonName == "w3close")
        {
            w3WindowAnimation["w3animation"].speed = -1;
            w3WindowAnimation["w3animation"].time = w3WindowAnimation["w3animation"].length;
            w3WindowAnimation.Play();
        }
    }
}
