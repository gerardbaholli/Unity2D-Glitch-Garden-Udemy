﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravestone : MonoBehaviour
{
    
	protected void OnTriggerStay2D(Collider2D other)
	{
		Attacker attacker = other.GetComponent<Attacker>();
		
		if (attacker)
		{
			// TODO: add some sort of animation
		}
	}
    
}
