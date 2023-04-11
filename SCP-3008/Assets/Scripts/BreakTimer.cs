using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class BreakTimer : MonoBehaviour
{
    HandBook metalCount;
    HandBook woodCount;
    HandBook clothCount;
    HandBook paperCount;
    HandBook nailCount;

    [Header("Slider")]
    public Slider breakingBarSlider;
    public GameObject breakingBarGrafic;

    [Header("Player/PlayerScripts")]
    public GameObject player;

    public void Start()
    {
        metalCount = player.GetComponent<HandBook>();
        woodCount = player.GetComponent<HandBook>();
        clothCount = player.GetComponent<HandBook>();
        paperCount = player.GetComponent<HandBook>();
        nailCount = player.GetComponent<HandBook>();
    }
    public void BreakObject(BreakingDrops drops)
    {
        StartCoroutine(BreakTime(drops));
    }

    IEnumerator BreakTime(BreakingDrops drops)
    {
        breakingBarGrafic.SetActive(true);
        float timer = 0;
        while (timer < drops.breakTime)
        {
            timer += Time.deltaTime;

            float realValue = timer / drops.breakTime;
            breakingBarSlider.value = realValue;
            yield return null;
        }

        metalCount.metalCount += drops.Metal;
        clothCount.clothCount += drops.Cloth;
        woodCount.woodCount += drops.Wood;
        paperCount.paperCount += drops.paper;
        nailCount.nailCount += drops.nail;
        breakingBarGrafic.SetActive(false);
        Destroy(drops.gameObject);

    }
}
