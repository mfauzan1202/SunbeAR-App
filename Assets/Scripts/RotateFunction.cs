using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFunction : MonoBehaviour
{   
    public GameObject ModelDefault;
    public GameObject ModelStanding;
    public GameObject ModelWalking;

    public float rotateSpeed = 50f;
    bool rotateStatus = false;

    private Quaternion initialRotation;

    private void Start() {
        initialRotation = ModelDefault.transform.rotation;
    }   

    public void Rotation(){
        if(rotateStatus == false){
            rotateStatus = true;
        }else{
            rotateStatus = false;
        }
    }

    public void ResetRotation()
    {
        rotateStatus = false;
        ModelDefault.transform.rotation = initialRotation;
        ModelStanding.transform.rotation = initialRotation;
        ModelWalking.transform.rotation = initialRotation;
    }

    void Update(){
        if(rotateStatus == true){
            if(ModelDefault.activeInHierarchy == true){
                ModelDefault.transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);    
            }
            else if(ModelStanding.activeInHierarchy == true){
                ModelStanding.transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);    
            }
            else if(ModelWalking.activeInHierarchy == true){
                ModelWalking.transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);    
            }            
        }
    }
}

