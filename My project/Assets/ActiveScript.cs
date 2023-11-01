using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveScript : MonoBehaviour
{
    public GameObject sphere;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Object is Activated");
            sphere.SetActive(true);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Object is Deactivated");
            sphere.SetActive(false);
        }
    }
}
