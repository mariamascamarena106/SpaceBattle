using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class balas : MonoBehaviour
{
    List<GameObject> rayoList = new List<GameObject>();
    [SerializeField] private GameObject rayo;

    private int speed = 2;
    private float temporizador = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
        

    }

    // Update is called once per frame
    void Update()
    {
        
        temporizador -= 0 + Time.deltaTime;

        if (Input.GetKey(KeyCode.E))
        {

            if(temporizador <= 0)
            {
                GameObject newBala = Instantiate(rayo);
                newBala.transform.position += new Vector3(0f, speed * Time.deltaTime, 0f);

                rayoList.Add(newBala);



                Debug.Log("piu");

                temporizador = 1f;

            }
            
            
        }




    }
    
}
