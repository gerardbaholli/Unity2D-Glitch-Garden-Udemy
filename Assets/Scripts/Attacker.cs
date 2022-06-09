using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{

    [SerializeField][Range(0f, 5f)] float currentSpeed = 1f;
    

    private void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime, Space.World);
    }

    private void SetMovementSpeed(float value)
    {
        currentSpeed = value;
    }
	
}
