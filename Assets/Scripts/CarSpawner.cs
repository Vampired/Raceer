using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{

    public GameObject[] cars;
    int carNumber;
    public float maxPos = 2.1f;
    public float delayTimer = 1f;
    float timer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Vector3 carPosition = new Vector3(Random.Range(-1.9f, 1.9f), transform.position.y, transform.position.z);
            carNumber = Random.Range(0, 4);
            Instantiate(cars[carNumber], carPosition, transform.rotation);
            timer = delayTimer;
        }
        

    }
}
