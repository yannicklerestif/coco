using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public event Action PlayerDied;

    public void OnPlayerDied()
    {
        PlayerDied();
    }
}
