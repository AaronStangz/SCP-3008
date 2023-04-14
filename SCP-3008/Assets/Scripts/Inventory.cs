using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject PlayerCam;
    public GameObject InvCam;

    public GameObject Inv;

    public GameObject puaseMenu;
    public GameObject crafting;
    public GameObject HungerThirstHealth;

    public GameObject ScrapAxeItem;
    public GameObject WoodAxeItem;
    public GameObject MetalAxeItem;

    public bool InvOpen = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Inv.SetActive(true);
            InvCam.SetActive(true);
            PlayerCam.SetActive(false);
            HungerThirstHealth.SetActive(false);
            InvOpen = true;
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Inv.SetActive(true);
            InvCam.SetActive(true);
            PlayerCam.SetActive(false);
            HungerThirstHealth.SetActive(false);
            InvOpen = true; 
        }

        Escape();

    }

    void Escape()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && InvOpen == true)
        {
            Inv.SetActive(false);
            InvCam.SetActive(false);
            PlayerCam.SetActive(true);
            HungerThirstHealth.SetActive(true);
        }
    }
}
