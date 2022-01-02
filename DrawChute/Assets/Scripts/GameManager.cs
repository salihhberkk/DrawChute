using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoSingleton<GameManager>
{
    public GameObject player;
    internal int hapticOn;

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }
    internal void StartGame()
    {
       // player.GetComponent<PlayerMovement>().StartThrow();
    }
    public void FinishGame()
    {
        UIManager.Instance.ShowPanel(PanelType.Win);
        //player.GetComponent<PlayerMovement>().DisableControl();
    }
}
