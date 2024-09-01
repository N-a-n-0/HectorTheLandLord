using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform cameraPosition;


    void Start()
    {
        print("this happen");
        transform.position = cameraPosition.position;
    }

    // Update is called once per frame
   
}
