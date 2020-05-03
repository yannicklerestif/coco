using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public event Action PlayerDied;
    public event Action RestartGame;

    public void OnPlayerDied()
    {
        PlayerDied();
    }

    public void OnRestartGame()
    {
        RestartGame();
    }
}
