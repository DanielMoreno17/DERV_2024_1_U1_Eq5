using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exdebug : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Se presiono la letra w");
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Se presiono la letra A");
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Se presiono la letra S");
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Se presiono la letra D");
        }
    }
}
