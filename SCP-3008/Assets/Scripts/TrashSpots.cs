using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpots : MonoBehaviour
{
    public GameObject SpawnP1;
    public GameObject SpawnP2;
    public GameObject SpawnP3;
    public GameObject SpawnP4;

    public List<GameObject> plots;

    void Start()
    {
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP1.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP2.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP3.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP4.transform);
    }
}
