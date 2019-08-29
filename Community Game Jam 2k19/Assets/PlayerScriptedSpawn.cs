﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScriptedSpawn : MonoBehaviour
{
    public LoadingBarValue loadbar;
    public CmdPromptObject prompt;
    public GameObject player;
    public PlayerObject playerobject;
    // Start is called before the first frame update
    void Start()
    {
       if(loadbar.Value > 0)
        {
            loadbar.Value = 0;
        }
        player.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(loadbar.Value >= 0.1f)
        {
       //     player.SetActive(true); //This will bite me in the ass later 
            prompt.EnqueueText("Spawing Player");
            playerobject.isDead = false;

        }
    }
}
