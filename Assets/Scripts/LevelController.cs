using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{

    int numberOfAttackers = 0;
    bool levelTimerFinished = false;
    [SerializeField] GameObject winLabel;


    private void Start()
    {
        winLabel.SetActive(false);

    }

    public void AttackerSpawned()
    {
        numberOfAttackers++;
    }

    public void AttackersKilled()
    {
        numberOfAttackers--;
        if(numberOfAttackers <= 0 && levelTimerFinished)
        {
            winLabel.SetActive(true);
        }
    }


    public void LevelTimerFinished()
    {
        levelTimerFinished = true;
        StopSpawners();
    }

    private void StopSpawners()
    {
        AttackerSpawner[] spawnerArry = FindObjectsOfType<AttackerSpawner>();
        foreach(AttackerSpawner spawner in spawnerArry)
        {
            spawner.StopSpawning();
        }
    }
}
