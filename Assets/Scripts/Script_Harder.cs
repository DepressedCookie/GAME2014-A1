﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Harder : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("GameMana").GetComponent<Script_GameMana>().MakeItHarder();
        }
    }
}
