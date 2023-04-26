using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNodes : MonoBehaviour
{
    // Start is called before the first frame update

    int numToSpawn = 25;
    public float offset = 0.3f;


    void Start()
    {
        if (gameObject.name == "Node")
        {
            for (int i = 0; i < numToSpawn; i++)
            {
                GameObject clone = Instantiate(gameObject, new Vector3(transform.position.x + i*offset, transform.position.y, 0), Quaternion.identity);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
