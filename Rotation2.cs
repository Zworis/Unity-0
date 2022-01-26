using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation2 : MonoBehaviour
{
    float rotatie = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(-rotatie,0f,0f);
    }
}
