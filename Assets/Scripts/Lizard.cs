﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{

	protected void OnTriggerEnter2D(Collider2D other)
	{
		GameObject otherObject = other.gameObject;
		
		if (otherObject.GetComponent<Defender>())
		{
			GetComponent<Attacker>().Attack(otherObject);
		}
	}

}
