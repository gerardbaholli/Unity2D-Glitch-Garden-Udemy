using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class StarDisplay : MonoBehaviour
{

    [SerializeField] int stars = 100;
    TextMeshProUGUI starText;
    
    private void Start()
    {
        starText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }

    private void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }

    private void SpendStars(int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;
            UpdateDisplay();
        }
    }

}
