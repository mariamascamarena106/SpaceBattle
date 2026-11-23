using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;
using Unity.Android.Gradle.Manifest;
using System.Collections;
public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    private float timer;
    List<GameObject> enemyList = new List<GameObject>();
    [SerializeField] private float gravity;
    [SerializeField] private Transform PlayerTransform;
    private int score;
    List<GameObject> enemyListToRemove = new List<GameObject>();
    void Start()
    {

        timer = 0f;

        InvokeRepeating(nameof(GenerarEnemy), 0.5f, 3f);
        StartCoroutine(nameof(GenerarEnemy));

    }

    private IEnumerator GenerarEnemy()
    {

        GameObject newEnemy = Instantiate(enemy);
        newEnemy.transform.position = new Vector3((Random.Range(-4f, 3.5f)), 5f, 5f);
        timer = 0f;

        enemyList.Add(newEnemy);

        yield return new WaitForSeconds(5);

        Debug.Log("ya esta");
    }



    void Update()
    {

        timer += Time.deltaTime;

        if (timer > 1.5f)
        {
            GameObject newEnemy = Instantiate(enemy);
            newEnemy.transform.position = new Vector3((Random.Range(-4f, 3.5f)), 5f, 5f);
            timer = 0f;

            enemyList.Add(newEnemy);

        }

        foreach (GameObject enemy in enemyList)
        {
            enemy.transform.position += Vector3.down * gravity * Time.deltaTime;
            float distancia = Vector3.Distance(enemy.transform.position, PlayerTransform.position);
            if (distancia < 1f)
            {
                Debug.Log("Adeu");
                enemyListToRemove.Add(enemy);

            }

        }
        foreach (GameObject enemy in enemyListToRemove)
        {
            enemyList.Remove(enemy);
            Destroy(enemy);
        }



    }
}
