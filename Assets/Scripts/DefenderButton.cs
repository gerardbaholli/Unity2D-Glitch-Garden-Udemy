﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DefenderButton : MonoBehaviour
{

    [SerializeField] Defender defenderPrefab;

    private DefenderSpawner defenderSpawner;

    private void Start()
	{
		LabelButtonWithCost();
        defenderSpawner = FindObjectOfType<DefenderSpawner>();
    }

    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach(DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(41,41,41,255);
        }

        GetComponent<SpriteRenderer>().color = Color.white;

        defenderSpawner.SetSelectedDefender(defenderPrefab);
    }
    
	private void LabelButtonWithCost()
	{
		TextMeshProUGUI costText = GetComponentInChildren<TextMeshProUGUI>();
		if (!costText)
		{
			Debug.LogError(name + " has no cost text.");
		}
		else
		{	
			costText.text = defenderPrefab.GetStarCost().ToString();
		}
	}

}
