using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    void Start()
    {
	    PlayerPrefsController.SetDifficulty(3f);
	    Debug.Log(PlayerPrefsController.GetDifficulty());
    }
    
}
