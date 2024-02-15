using UnityEngine.SceneManagement;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public void quitGame()
    {
        Application.Quit();
    }

    public void openMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void startGame()
    {
        SceneManager.LoadScene(1);
    }

    public void openSettings()
    {
        SceneManager.LoadScene(2);
    }
}
