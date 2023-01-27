using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private bool rotate = true;
    public float rotationSpeed = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                if(Input.GetKey(KeyCode.R))
        {
            rotate = !rotate;
        }
         if(Input.GetKey(KeyCode.V))
        {
            Debug.Log(rotationSpeed);
            rotationSpeed += 0.1f;
        }
         if(Input.GetKey(KeyCode.B))
        {
            Debug.Log(rotationSpeed);
            rotationSpeed -= 0.1f;
        }
    }

    void FixedUpdate()
    {
        if(rotate)
        {
            this.GetComponent<Transform>().Rotate(0, rotationSpeed, 0);
        }
    }
}
