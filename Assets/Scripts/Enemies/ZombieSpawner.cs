using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class ZombieSpawner : MonoBehaviour
{

    [SerializeField] private int numOfZombiesToSpawn;
    [SerializeField] private GameObject[] zombiePrefab;
    [SerializeField] private SpawnerVolume[] spawnVolumes;

    private GameObject FollowGameObject;
    // Start is called before the first frame update
    void Start()
    {
        FollowGameObject = GameObject.FindGameObjectWithTag("Player");

        for (int index = 0; index < numOfZombiesToSpawn; index++)
        {
            spawnZombies();
        }
    }

    private void spawnZombies()
    {
        GameObject zombieToSpawn = zombiePrefab[Random.Range(0, zombiePrefab.Length)];
        SpawnerVolume spawnVolume = spawnVolumes[Random.Range(0, spawnVolumes.Length)];


        if (!FollowGameObject)
        {
            return;
        }
        GameObject zombie = Instantiate(zombieToSpawn, spawnVolume.GetPositionInBounds(),
       spawnVolume.transform.rotation);

        zombie.GetComponent<ZombieComponent>().Initialize(FollowGameObject);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
