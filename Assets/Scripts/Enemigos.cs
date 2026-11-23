using UnityEngine;
using System.Collections.Generic;
using System.Collections;


public class Enemigos : MonoBehaviour
{
    List<GameObject> rayoMaloList = new List<GameObject>();
    [SerializeField] private GameObject EnemyPrefab;
    [SerializeField] private float speed;

    [SerializeField] private Transform[] spawnPoints;

    private float temporizador = 0f;
    [SerializeField] private GameObject rayo;


    private List<GameObject> Generarenemigos = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //Score
    void Start()
    {
        //TODO: Llamamos a la generación de enemigos
    }

    void Update()
    {

        EnemyPrefab.transform.position += new Vector3(speed, 0f, 0f) * Time.deltaTime;

        if (EnemyPrefab.transform.position.x > 13f)
        {
            EnemyPrefab.transform.position = Vector3.zero;
        }

        temporizador -= Time.deltaTime;

        //Disparar

        for(int i = 0; i == 0; )
        {
            if (temporizador <= 0)
            {
                GameObject newBala = Instantiate(rayo);
                newBala.transform.position += new Vector3(transform.position.x, -5.5f, 0f);

                rayoMaloList.Add(newBala);

                temporizador = 1f;

            }
        }
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {



    }
}
