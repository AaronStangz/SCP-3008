using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hunger : MonoBehaviour
{
    public bool isdead = false;



    [Header("Hunger")]
    public float maxHunger = 100f;
    public float hunger = 0f;
    public float hungerOT = 0.01f;
    public Slider hugerSlider;

    [Header("Thrist")]
    public float maxThirst = 100f;
    public float thirst = 0f;
    public float thirstOT = 0.02f;
    public Slider thirstSlider;

    void Start()
    {
        
    }

    void Update()
    {
        hunger = hunger - hungerOT * Time.deltaTime;
        hugerSlider.value = hunger / maxHunger;

        if (hunger < 0f )
        {
            isdead = true;
        }

        if (thirst < 0f)
        {
            isdead = true;
        }

        thirst = thirst - thirstOT * Time.deltaTime;
        thirstSlider.value = thirst / maxThirst;
    }
}
