using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI rosesText;
    private TextMeshProUGUI candlesText;
    private TextMeshProUGUI lighterText;
    private TextMeshProUGUI giftText;

    void Start()
    {
        rosesText = GetComponent<TextMeshProUGUI>();
        candlesText = GetComponent<TextMeshProUGUI>();
        lighterText = GetComponent<TextMeshProUGUI>();
        giftText = GetComponent<TextMeshProUGUI>();
    }

    
    public void UpdateRosesText(PlayerInventory playerInventory)
    {
        rosesText.text = playerInventory.NumberOfRoses.ToString();
    }
    

    public void UpdateCandlesText(PlayerInventory playerInventory)
    {
        candlesText.text = playerInventory.NumberOfCandles.ToString();
    }

    public void UpdateLighterText(PlayerInventory playerInventory)
    {
        lighterText.text = playerInventory.NumberOfLighter.ToString();
    }

    public void UpdateGiftsText(PlayerInventory playerInventory)
    {
        giftText.text = playerInventory.NumberOfGifts.ToString();
    }
}
