using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{

    [SerializeField] float delayOnSceneLoad = 3.5f;

    private int currentSceneIndex;

    private void Start()
    {
        currentSceneIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
            StartCoroutine(WaitForTime());
    }

    private IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(delayOnSceneLoad);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(currentSceneIndex + 1);
    }

}
