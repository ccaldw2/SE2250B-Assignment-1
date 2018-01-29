using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickToReset : MonoBehaviour {

    Vector3 originalPos;
    Quaternion originalRot;

    void Start()
    {
        originalPos = gameObject.transform.position;
        originalRot = gameObject.transform.rotation;
    }


    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1)) { 
            gameObject.transform.position = originalPos;
            gameObject.transform.rotation = originalRot;
    }
    }
}
