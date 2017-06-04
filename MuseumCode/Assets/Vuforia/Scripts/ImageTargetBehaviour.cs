/*==============================================================================
Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Vuforia
{
    /// <summary>
    /// This class serves both as an augmentation definition for an ImageTarget in the editor
    /// as well as a tracked image target result at runtime
    /// </summary>
    public class ImageTargetBehaviour : ImageTargetAbstractBehaviour
    {
        public GameObject ControllBtn;
        public GameObject NameText;

        public void OnBecameVisible()
        {
            ControllBtn.GetComponent<ButtonsFunctions>().PanelSwap();
          
        }

        public void NameChange()
        {
            switch (gameObject.GetComponent<DefaultTrackableEventHandler>().mTrackableBehaviour.TrackableName)
            {
                case "Test_1_Mask":
                    NameText.GetComponent<Text>().text = "Mask of Tribe Leader";
                    break;

                case "Test_2_Elephants":
                    NameText.GetComponent<Text>().text = "Tribal figures of savanna animals";
                    break;
                case "Test_3_Bracers":
                    NameText.GetComponent<Text>().text = "Traditional Bracers";
                    break;
                case "Test_4_Dolls":
                    NameText.GetComponent<Text>().text = "Dolls made from corals";
                    break;
                case "Test_5_Head":
                    NameText.GetComponent<Text>().text = "Burial Mask";
                    break;
                case "Test_6_Coins":
                    NameText.GetComponent<Text>().text = "Ancient Rome Coins";
                    break;
            }
        }
    }
}
