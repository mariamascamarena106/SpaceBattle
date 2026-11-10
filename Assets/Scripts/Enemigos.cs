using UnityEngine;
using System.Collections.Generic;
using System.Collections;


public class Enemigos : MonoBehaviour
{

    [SerializeField] private GameObject EnemyPrefab;
    [SerializeField] private float speed;
    GameObject createdEnemy;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private int NumeroEnemigos = 1;

    private List<GameObject> Generarenemigos = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // Instanciarenemigos();

    }

    // Update is called once per frame
    void Update()
    {
        



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
    
}
