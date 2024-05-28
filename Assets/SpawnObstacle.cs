using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public float queueTime = 1f;
    private float time = 0;
    public GameObject[] obstacles;
    public float[] positions;
    // Update is called once per frame
    void Update()
    {
        if (time > queueTime)
        {
            int numberOfPosition = positions.Length;
            int number = Random.Range(0, numberOfPosition);
            int position = Random.Range(0, numberOfPosition - number);
            number++;
            GameObject obstacle = obstacles[Random.Range(0, obstacles.Length)];
            for (int i = 0;i<number;i++)
            {

                GameObject go = Instantiate(obstacle);
                go.transform.position = Camera.main.transform.position + new Vector3(positions[position], 10, -Camera.main.transform.position.z);
                Destroy(go, 6);
                position++;
            }
            time = 0;
        }

        time += Time.deltaTime;
    }
}
