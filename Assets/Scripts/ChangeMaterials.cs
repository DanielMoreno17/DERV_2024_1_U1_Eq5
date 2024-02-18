using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterials : MonoBehaviour
{

    public Renderer rends;
    
    [SerializeField]
    private Material color1, color2, color3, color4, color5;
    [SerializeField]

    // Start is called before the first frame update
    void Start()
    {
        rends = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rends.material = color1;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rends.material = color2;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            rends.material = color3;

        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            rends.material = color4;
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            rends.material = color5;
        }
    }
}
