using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandSpawn : MonoBehaviour
{
    public GameObject SpawnP1;
    public GameObject SpawnP2;
    public GameObject SpawnP3;
    public GameObject SpawnP4;
    public GameObject SpawnP5;
    public GameObject SpawnP6;
    public GameObject SpawnP7;
    public GameObject SpawnP8;
    public GameObject SpawnP9;
    public GameObject SpawnP10;
    public GameObject SpawnP11;
    public GameObject SpawnP12;
    public GameObject SpawnP13;
    public GameObject SpawnP14;
    public GameObject SpawnP15;
    public GameObject SpawnP16;
    public GameObject SpawnP17;
    public GameObject SpawnP18;
    public GameObject SpawnP19;
    public GameObject SpawnP20;
    public GameObject SpawnP21;
    public GameObject SpawnP22;
    public GameObject SpawnP23;
    public GameObject SpawnP24;
    public GameObject SpawnP25;


    public List<GameObject> plots;

    void Start()
    {
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP1.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP2.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP3.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP4.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP5.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP6.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP7.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP8.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP9.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP10.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP11.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP12.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP13.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP14.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP15.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP16.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP17.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP18.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP19.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP20.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP21.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP22.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP23.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP24.transform);
        Instantiate(plots[Random.Range(0, plots.Count)], SpawnP25.transform);

    }

   
}
