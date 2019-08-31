﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemCollect : MonoBehaviour
{
    public event Action OnCollected = delegate { };
    PlayerInputController player;

    void OnTriggerEnter2D(Collider2D collision)
    {
        player = collision.GetComponent<PlayerInputController>();
        if(player != null)
        {
            OnCollected();
            gameObject.SetActive(false);
        }
    }
}