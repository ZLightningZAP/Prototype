using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //When start button is clicked
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    //When highscore button is clicked
    public void Highscore()
    {
        SceneManager.LoadScene("Highscore");
    }

    //When shop button is clicked
    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }

    //When exit button is clicked
    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit ();
#endif
    }
}