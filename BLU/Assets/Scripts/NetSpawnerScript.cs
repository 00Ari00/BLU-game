using UnityEngine;

public class NetSpawnerScript : MonoBehaviour
{

    public GameObject net;
    public float spawnRate = 2;
    public float timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Instantiate(net, transform.position, transform.rotation);
            timer = 0;
        }

    }
}
