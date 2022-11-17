﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
	[SerializeField] Slider volumeSlider;
	[SerializeField] float defaultVolume = 0.8f;
	[SerializeField] Slider difficultySlider;
	[SerializeField] float defaultDifficulty = 0f;
	private void Start()
	{
		volumeSlider.value = PlayerPrefsController.GetMasterVolume();
		difficultySlider.value = PlayerPrefsController.GetDifficulty();
	}

	private void Update()
	{
		var musicPlayer = FindObjectOfType<MusicPlayer>();
		if (musicPlayer)
		{
			musicPlayer.SetVolume(volumeSlider.value);
		}
		else
		{
			Debug.LogWarning("No music player found... did you start from splash screen?");
		}
	}
	
	public void SaveAndExit()
	{
		PlayerPrefsController.SetMasterVolume(volumeSlider.value);
		PlayerPrefsController.SetDifficulty(difficultySlider.value);
		FindObjectOfType<LevelLoader>().LoadStartingScene();
	}
	
	public void SetDefaults()
	{
		SetDefaultVolume();
	}
	
	private void SetDefaultVolume()
	{
		volumeSlider.value = defaultVolume;
		difficultySlider.value = defaultDifficulty;
	}
}
