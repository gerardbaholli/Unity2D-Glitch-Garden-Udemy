using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{

    [SerializeField][Range(0f, 5f)] float walkSpeed = 1f;
    

    private void Update()
    {
        transform.Translate(Vector2.left * walkSpeed * Time.deltaTime, Space.World);
    }
	
}
