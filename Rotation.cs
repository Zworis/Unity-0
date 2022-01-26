using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    float rotatie = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject.Find("Cube (8)").GetComponent("Transform").Rotation = (0f,0f,rotatie);
        transform.Rotate(rotatie,0f,0f);
    }
}
