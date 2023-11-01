using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject sphere;
    public void ButtonPressed()
    {
        if (sphere.active == false)
        {
            Debug.Log("Object is Deactivated");
        }

        if (sphere.active == true)
        {
            Debug.Log("Object is Activated");
        }
    }

    void Start()
    {
  
    }
    void Update()
    {
        
    }
}
