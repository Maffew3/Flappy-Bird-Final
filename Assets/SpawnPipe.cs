using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipe : MonoBehaviour
{
    public GameObject pipe1;
    public GameObject pipe2;
    public float timer;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipes();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 1.5f)
        {
            SpawnPipes();
            timer = 0.0f;
        }
        timer += Time.deltaTime;
    }
    private void SpawnPipes()
    {
        Vector3 spawnPos = new Vector3(0, Random.Range(-14, 38));
        if (ScoreText.instance.scoreNum <= 20) {
            GameObject pipe = Instantiate(pipe1, spawnPos, Quaternion.identity);
            Destroy(pipe, 10f);
        }
        else if (ScoreText.instance.scoreNum > 20) {
            GameObject pipe = Instantiate(pipe2, spawnPos, Quaternion.identity);
            Destroy(pipe, 10f);
        }
        
    }
}
