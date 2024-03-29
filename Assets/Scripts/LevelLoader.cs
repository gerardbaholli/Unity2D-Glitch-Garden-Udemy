﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    [SerializeField] float delayOnSceneLoad = 3.5f;

    private int currentSceneIndex;

    private void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
            StartCoroutine(WaitForTime());
    }

    private IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(delayOnSceneLoad);
        LoadNextScene();
    }
    
	public void LoadStartingScene()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene("Start Screen");
	}
	
	public void LoadOptionsScreen()
	{
		SceneManager.LoadScene("Options Screen");
	}
	
	public void LoadCurrentScene()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene(currentSceneIndex);
	}

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    
	public void LoadLoseScreen()
	{
		SceneManager.LoadScene("Lose Screen");
	}
	
	public void QuitGame()
	{
		Application.Quit();
	}

}
