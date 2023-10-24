using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeButton_information : MonoBehaviour
{
    public Button buttonInfo;
    public Sprite buttonImageOn;

    public void changeToOn(){
        buttonInfo.image.sprite = buttonImageOn;
    }
}
