using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnOff_buttonInfo : MonoBehaviour
{
    private bool isButtonOn = true;
    public Sprite buttonimgOn;
    public Sprite buttonimgOff;
    public Button buttonInfo;
    public GameObject InfoDefault;
    public GameObject InfoStanding;
    public GameObject InfoWalking;

    public GameObject ModelDefault;
    public GameObject ModelStanding;
    public GameObject ModelWalking;

    public void whenButtonClicked(){
        if (!isButtonOn)
        {
            buttonInfo.image.sprite = buttonimgOff;
            if (ModelDefault.activeInHierarchy)
            {
                InfoDefault.SetActive(true);
            }
            else if (ModelStanding.activeInHierarchy)
            {
                InfoStanding.SetActive(true);
            }
            else if (ModelWalking.activeInHierarchy)
            {
                InfoWalking.SetActive(true);
            }
            isButtonOn = true;
        }
        else
        {
            buttonInfo.image.sprite = buttonimgOn;
            if (ModelDefault.activeInHierarchy)
            {
                InfoDefault.SetActive(false);
            }
            else if (ModelStanding.activeInHierarchy)
            {
                InfoStanding.SetActive(false);
            }
            else if (ModelWalking.activeInHierarchy)
            {
                InfoWalking.SetActive(false);
            }
            isButtonOn = false;
        }
    }

    public void offInfo(){
        buttonInfo.image.sprite = buttonimgOn;
            if (ModelDefault.activeInHierarchy)
            {
                InfoDefault.SetActive(false);
            }
            else if (ModelStanding.activeInHierarchy)
            {
                InfoStanding.SetActive(false);
            }
            else if (ModelWalking.activeInHierarchy)
            {
                InfoWalking.SetActive(false);
            }
            isButtonOn = false;
    }
}
