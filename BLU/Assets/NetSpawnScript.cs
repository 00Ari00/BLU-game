using UnityEngine;

public class NetSpawnScript : MonoBehaviour
{

    public GameObject net;
    public float spawnRate;
    public float timer;
    public float heightOffset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnNet();
    }

    public int maxNets;


    // Update is called once per frame
    void Update()
    {

        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            if (GameObject.FindGameObjectsWithTag("Net").Length < maxNets)
            {
                spawnNet();
            }
            timer = 0;
        }
    }
    void spawnNet()
    {

        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;


        Instantiate(net, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

    }

}
