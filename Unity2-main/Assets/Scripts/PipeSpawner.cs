using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float repeatRate = 1;
    private float timer = 0;
    public float height = 5;
    public GameObject[] prefabPipe;
    public GameObject prefabCoin;

    // Update is called once per frame
    void Update()
    {
        if (timer > repeatRate)
        {
            timer = 0;
            SpawnPipe();
        }

        timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        int index = Random.Range(0, 2);
        GameObject newPipe = Instantiate(prefabPipe[index]);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newPipe, 10f);
    }
}