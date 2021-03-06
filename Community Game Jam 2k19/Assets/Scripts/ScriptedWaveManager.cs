﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptedWaveManager : MonoBehaviour
{
    public LoadingBarValue load;
    public InterruptionObject interrupt;
    public EnemyWaveObject enemyWave;
    public CmdPromptObject prompt;
    public GameObject firstEnemy;
    public GameObject enemy;
    public GameObject collectInterruption;
    public GameObject spawnpoint;
    public AudioSource audio;
    int messagecount = 0;
    int messagecount2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        interrupt.difficulty = 3;
        interrupt.speed = 3;
        enemyWave.difficulty = 2;
        enemyWave.enemySpeed = 2;

    }

    // Update is called once per frame
    void Update()
    {
        if(load.Value >= .15)
        {
            if (messagecount < 1)
            {
                audio.Play();
                firstEnemy.SetActive(true);
                firstEnemy.transform.position = spawnpoint.transform.position;
                enemy.SetActive(true);
                prompt.CmdSetText("Glitches Detected. Defend The Terminal");
                messagecount++;
            }
        }

        if (!collectInterruption.activeInHierarchy && (load.Value >= .30 || load.Value >= .50))
        {
            if (interrupt.difficulty < 5)
            {
                interrupt.difficulty++;
            }
            collectInterruption.SetActive(true);

        }
        if (!collectInterruption.activeInHierarchy && (load.Value >= .60 || load.Value >= .70 || load.Value >= .80))
        {
          
            if(interrupt.difficulty < 5 )
            {
                interrupt.difficulty++;
            }
            if(enemyWave.enemySpeed > 1)
            {
                enemyWave.enemySpeed--;
            }
            if (enemyWave.difficulty > 1)
            {
                enemyWave.difficulty--;
            }
      

            collectInterruption.SetActive(true);

        }

    }
}
