using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public EventManager eventManager;
    public GameOverPanelController gameOverPanelController;

    private float _oldTimeScale;

    // Start is called before the first frame update
    void Start()
    {
        eventManager.PlayerDied += OnPlayerDied;
        eventManager.RestartGame += OnRestartGame;
        gameOverPanelController.gameObject.SetActive(false);
    }

    public void OnPlayerDied()
    {
        _oldTimeScale = Time.timeScale;
        Time.timeScale = 0;
        gameOverPanelController.gameObject.SetActive(true);
    }

    public void OnRestartGame()
    {
        Time.timeScale = _oldTimeScale;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
