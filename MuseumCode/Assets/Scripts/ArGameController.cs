using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArGameController : MonoBehaviour {
    public GameObject Part1;
    public GameObject Part2;
    public GameObject Part3;
    public GameObject ClueBtn;
    public GameObject JourneyStepMainText;
    public GameObject JourneyStepHelpText;
    public int partsCollected;
    public int ArtifactID;
    public int JourneySteps = 0;


	// Use this for initialization
	void Start () {

      


	}
	
	// Update is called once per frame
	void Update () {

        if(partsCollected >= 3)
        {
            RevealJourneyText();
        }
		
	}


    public void RevealJourneyText()
    {
        JourneyStepMainText.SetActive(true);
        ClueBtn.SetActive(true);
        Part1.SetActive(false);
        Part2.SetActive(false);
        Part3.SetActive(false);
        JourneySteps = JourneySteps + 1;
    }

    public void RevealJourneyClue()
    {
        JourneyStepHelpText.SetActive(true);
        
    }


    public void PartCollected()
    {
        partsCollected = partsCollected + 1;
    }
}
