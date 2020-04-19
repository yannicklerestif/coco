using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public EventManager eventManager;

    // Start is called before the first frame update
    void Start()
    {
        eventManager.PlayerDied += OnPlayerDied;
    }

    public void OnPlayerDied()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
