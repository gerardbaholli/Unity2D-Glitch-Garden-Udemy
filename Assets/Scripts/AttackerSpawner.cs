using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{

    [SerializeField] bool spawn = true;

    [SerializeField] float minSpawnDelay;
    [SerializeField] float maxSpawnDelay;

	[SerializeField] Attacker[] attackerPrefabArray;

    private IEnumerator Start()
    {
        while(spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

	private void SpawnAttacker()
    {
	    var attackerIndex = Random.Range(0, attackerPrefabArray.Length);
	    Spawn(attackerPrefabArray[attackerIndex]);
    }
    
	private void Spawn(Attacker myAttacker)
	{
		Attacker newAttacker = Instantiate(myAttacker, transform.position, Quaternion.identity) as Attacker;
		newAttacker.transform.parent = transform;
	}
	
	
}
