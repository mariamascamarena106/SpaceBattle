using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class balas : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
        

    }

    // Update is called once per frame
    void Update()
    {
       


    }


    private void OnMouseDown()
    {
        Debug.Log("Morí");

        GameManager.EnemigoDestruido(GameObject);

        Destroy(gameObject);
    }
}
