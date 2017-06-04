using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFade : MonoBehaviour {
    public GameObject Text1;
    public GameObject Text2;
    public GameObject me;
    public int status;
    public void Start()
    {
        status = 1;
        if(gameObject.name == "Credits")
        {
            status = 2;
            StartCoroutine(FadeTime());
        }
    }


    public void TextSwap()
    {

        if(status == 1)
        {
            status = 2;
            Text1.SetActive(false);
            Text2.SetActive(true);
        }
        else
        {
            if(status == 2)
            {
                status = 1;
                Text2.SetActive(false);
                Text1.SetActive(true);
            }
        }
    }


   public IEnumerator FadeTime()
    {
        yield return new WaitForSeconds(2);
        Text2.SetActive(false);
        Text1.SetActive(true);
        status = 1;
    }
}
