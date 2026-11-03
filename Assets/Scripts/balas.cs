using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class balas : MonoBehaviour
{
    List<GameObject> rayoList = new List<GameObject>();
    [SerializeField] private GameObject rayo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
        

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.E))
        {
            Invoke(nameof(GenerarBalas),0.5f);

            /*
            GameObject newBala = Instantiate(rayo);
            newBala.transform.position = new Vector3(0f, -4f, 0f);

            rayoList.Add(newBala);

           

            Debug.Log("piu");
            */
        }




    }
    private IEnumerator GenerarBalas()
    {

        GameObject newBala = Instantiate(rayo);
        newBala.transform.position = new Vector3(0f, -4f, 0f);

        rayoList.Add(newBala);

        yield return new WaitForSeconds(0.5f);

        Debug.Log("piu");
    }


}
