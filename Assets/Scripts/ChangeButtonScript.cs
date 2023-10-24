using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonScript : MonoBehaviour
{
    public Sprite buttonImageOn;
    public Sprite buttonImageOff;
    public Button button;
    private bool isImageOn = true;
    public AudioSource PlaySound;

    public void ChangeImageButton()
    {
        if (!isImageOn)
        {
            button.image.sprite = buttonImageOn;
            PlaySound.Stop();
            isImageOn = true;
        }
        else
        {
            button.image.sprite = buttonImageOff;
            PlaySound.Play();
            isImageOn = false;
        }
    }
}
