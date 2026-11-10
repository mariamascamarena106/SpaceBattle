using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class SpaceshipScript : MonoBehaviour
{

    List<GameObject> rayoList = new List<GameObject>();
    [SerializeField] private GameObject rayo;

    private int bspeed = 2;
    private float temporizador = 0f;
    [SerializeField] private float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= Vector3.right * speed * Time.deltaTime;
        }



        temporizador -= 0 + Time.deltaTime;

        if (Input.GetKey(KeyCode.E))
        {

            if (temporizador <= 0)
            {
                GameObject newBala = Instantiate(rayo);
                newBala.transform.position += new Vector3(transform.position.x, -5.5f, 0f);

                rayoList.Add(newBala);



                Debug.Log("piu");

                temporizador = 1f;

            }


        }






    }





}
