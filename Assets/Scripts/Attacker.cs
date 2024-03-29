﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{

    [SerializeField][Range(0f, 5f)] float currentSpeed = 1f;
	GameObject currentTarget;

	private void Awake()
	{
		FindObjectOfType<LevelController>().AttackerSpawned();
	}
	
	private void OnDestroy()
	{
		LevelController levelController = FindObjectOfType<LevelController>();
		if (levelController != null)
		{
			levelController.AttackerKilled();
		}
	}

    private void Update()
    {
	    transform.Translate(Vector2.left * currentSpeed * Time.deltaTime, Space.World);
	    UpdateAnimationState();
    }
    
	private void UpdateAnimationState()
	{
		if (!currentTarget)
		{
			GetComponent<Animator>().SetBool("IsAttacking", false);
		}
	}

    private void SetMovementSpeed(float value)
    {
        currentSpeed = value;
    }
	
	public void Attack(GameObject target)
	{
		GetComponent<Animator>().SetBool("IsAttacking", true);
		currentTarget = target;
	}
	
	public void StrikeCurrentTarget(float damage)
	{
		if (!currentTarget) { return; }
		
		Health health = currentTarget.GetComponent<Health>();
		
		if (health)
			health.DealDamage(damage);
	}
	
}
