using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleFunction : MonoBehaviour
{
    public Slider scalesSlider;

    public float scaleMinValue;
    public float scaleMaxValue;

    public GameObject ModelDefault;
    public GameObject ModelStanding;
    public GameObject ModelWalking;

    void Start(){
        scalesSlider.minValue = scaleMinValue;
        scalesSlider.maxValue = scaleMaxValue;

        scalesSlider.onValueChanged.AddListener(ScaleSliderUpdate);
    }

    public void ResetSliderValue()
{
    scalesSlider.value = 0.126f;
}

    void ScaleSliderUpdate(float value){
        ModelDefault.transform.localScale = new Vector3(value, value, value);
        ModelStanding.transform.localScale = new Vector3(value, value, value);
        ModelWalking.transform.localScale = new Vector3(value, value, value);
    }
}
