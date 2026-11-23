using UnityEngine;
using System.Collections.Generic;
using System.Collections;


public class Enemigos : MonoBehaviour
{

    [SerializeField] private GameObject EnemyPrefab;
    [SerializeField] private float speed = 3;
    GameObject createdEnemy;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private int NumeroEnemigos = 1;

    private List<GameObject> Generarenemigos = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //Score
    void Start()
    {
        //TODO: Llamamos a la generación de enemigos

        GenerarEnemigos();
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



    }


    private void Instanciarenemigos()
    {
        int randomPosition = Random.Range(0, spawnPoints.Length);
        for (int i = 0; i < NumeroEnemigos; i++)
        {
            createdEnemy = Instantiate(
            EnemyPrefab,
            spawnPoints[randomPosition].position,
            Quaternion.identity);



            Generarenemigos.Add(createdEnemy);
        }
    }


    private void GenerarEnemigos()
    {
        
        bool[] ocupados = new bool[spawnPoints.Length];
        
        int randomPosition = Random.Range(0, spawnPoints.Length);
        for (int i = 0; i < NumeroEnemigos; i++)
        {

            while (ocupados[randomPosition])
            {
                randomPosition = Random.Range(0, spawnPoints.Length);
            }

            ocupados[randomPosition] = true;

         
            createdEnemy = Instantiate(
                EnemyPrefab,
                spawnPoints[randomPosition].position,
                Quaternion.identity);


            Generarenemigos.Add(createdEnemy);


           
            EnemyScript eScript = createdEnemy.GetComponent<EnemyScript>();

            eScript.Initialize(this);
        }
    }
}
