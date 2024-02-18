using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExOtherGetKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Se presiono la letra w");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Se presiono la letra A");
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            Debug.Log("Se presiono la letra S");
            
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("Se presiono la letra D");
        }
    }
}
