using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{

    [SerializeField] bool spawn = true;

    [SerializeField] float minSpawnDelay;
    [SerializeField] float maxSpawnDelay;

    [SerializeField] Attacker attackerToSpawn;

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
        Attacker attacker = Instantiate(attackerToSpawn, transform.position, Quaternion.identity) as Attacker;
        attacker.transform.parent = transform;
    }
}
