﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WinTrigger : MonoBehaviour
{
    public GameObject player;
    public Text TimerText;
    public GameObject WinCanvas; 
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) 
    {
        player.GetComponent<Timer>().enabled = false;
        // TimerText.fontSize = 80;
        // TimerText.color = Color.green;
        player.GetComponent<Timer>().Win();
        WinCanvas.SetActive(true);
    }
}