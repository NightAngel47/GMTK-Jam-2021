using UnityEngine;
using UnityEngine.UI;

public class MenuManager_Main : MonoBehaviour
{
    [SerializeField] private Button playButton = null;
    [SerializeField] private Button quitButton = null;

    public void OnEnable()
    {
        playButton.onClick.AddListener(PlayGame);
        quitButton.onClick.AddListener(QuitGame);
    }

    public void OnDisable()
    {
        playButton.onClick.RemoveListener(PlayGame);
        quitButton.onClick.RemoveListener(QuitGame);
    }

    /// <summary> Begins the game. </summary>
    public void PlayGame()
    {

    }

    /// <summary> Quits the game. </summary>
    public void QuitGame()
    {
        Application.Quit();
    }
}