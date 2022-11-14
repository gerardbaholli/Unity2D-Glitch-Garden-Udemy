using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LivesDisplay : MonoBehaviour
{
    
	[SerializeField] int lives = 5;
	[SerializeField] int damage = 1;
	TextMeshProUGUI livesText;
    
	private void Start()
	{
		livesText = GetComponent<TextMeshProUGUI>();
		UpdateDisplay();
	}

	private void UpdateDisplay()
	{
		livesText.text = lives.ToString();
	}

	public void TakeLife()
	{
		lives -= damage;
		UpdateDisplay();
		
		if (lives <= 0)
		{
			FindObjectOfType<LevelController>().HandleLoseCondition();
		}
		
	}
    
}
