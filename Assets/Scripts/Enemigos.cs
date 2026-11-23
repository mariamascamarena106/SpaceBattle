using UnityEngine;
using System.Collections.Generic;
using System.Collections;


public class Enemigos : MonoBehaviour
{
    List<GameObject> rayoMaloList = new List<GameObject>();
    [SerializeField] private GameObject EnemyPrefab;
    [SerializeField] private float speed = 3;
    GameObject createdEnemy;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private int NumeroEnemigos = 2;
    private float temporizador = 0f;
    [SerializeField] private GameObject rayo;

    private List<GameObject> Generarenemigos = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //Score
    void Start()
    {
        //TODO: Llamamos a la generación de enemigos
    }

    void moverEnemigos(List<GameObject> enemies)
    {
        for (int i = 0; i < enemies.Count; i++)
        {
            if (Random.Range(0, 2) == 0)
            {
                enemies[i].transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            }
            else
            {
                enemies[i].transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            }
        }

    }


    // Update is called once per frame
    void Update()
    {

        createdEnemy.transform.position += new Vector3(speed, 0f, 0f) * Time.deltaTime;

        if (createdEnemy.transform.position.x > 13f)
        {
            createdEnemy.transform.position = Vector3.zero;
        }

        moverEnemigos(Generarenemigos);


        temporizador -= Time.deltaTime;

        //Disparar

        if (temporizador <= 0)
        {
            GameObject newBala = Instantiate(rayo);
            newBala.transform.position += new Vector3(transform.position.x, -5.5f, 0f);

            rayoMaloList.Add(newBala);



            Debug.Log("piu");

            temporizador = 1f;

        }

    }   
}
