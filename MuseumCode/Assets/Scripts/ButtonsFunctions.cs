using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class ButtonsFunctions : MonoBehaviour {
    public bool isPhone;
    public bool isFlashOn;
    public int Mode;
    public int lang;
    public GameObject MainPanel;
    public GameObject BubblesPanel;
    public GameObject ArGamePanel;
    public GameObject LangBtn;
    public GameObject SoundBtn;

    public List<string> langlist = new List<string>(3);

    // Use this for initialization
    void Start() {
        //isPhone = false;
        isFlashOn = false;
        Mode = 0;
        lang = 0;
        langlist.Add("English");
        langlist.Add("Polski");
        langlist.Add("Deustch");
        

    }
	
	// Update is called once per frame
	void Update () {
       
    }


    public void MScodeQuit()
    {
        Application.Quit();
    }

    public void MScodeFlashlight()
    {
        
        if(!isFlashOn)
        {
            CameraDevice.Instance.SetFlashTorchMode(true);
            isFlashOn = true;
        }
        else
        {
            CameraDevice.Instance.SetFlashTorchMode(false);
            isFlashOn = false;
        }
    }

    public void PanelSwap()
    {
        if(Mode == 0)
        {
            MainPanel.SetActive(false);
            BubblesPanel.SetActive(true);
            Mode = 1;
        }
        else
        {
            if(Mode == 1)
            {
                MainPanel.SetActive(true);
                BubblesPanel.SetActive(false);
                Mode = 0;
            }
        }
    }

    public void LangSwap()
    {
        if(lang < 2)
        {
            LangBtn.GetComponentInChildren<Text>().text = langlist[lang + 1];
            lang = lang + 1; 
        }
        else
        {
            LangBtn.GetComponentInChildren<Text>().text = langlist[0];
            lang = 0;
        }
    }

    public void Mute()
    {
        if(AudioListener.volume == 1.0)
        {
            AudioListener.volume = 0;
            SoundBtn.GetComponentInChildren<Text>().text = "Sound On";
        }
        else
        {
            AudioListener.volume = 1.0f;
            SoundBtn.GetComponentInChildren<Text>().text = "Sound Off";
        }
    }
}
