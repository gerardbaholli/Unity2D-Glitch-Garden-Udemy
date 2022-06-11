using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;
    
    private void Fire()
    {
        Instantiate(projectile, gun.transform.position, Quaternion.identity);
    }
	
}
