using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandSpawn : MonoBehaviour
{
    public List<GameObject> Spawns;


    public List<GameObject> plots;

    void Start()
    {
        foreach (GameObject p in Spawns)
        {
            Instantiate(plots[Random.Range(0, plots.Count)],p.transform);
        }
    }

   
}
