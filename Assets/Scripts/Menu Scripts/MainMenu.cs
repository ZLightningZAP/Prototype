using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    //When start button is clicked
    private void PlayGame()
    {
    }

    //When highscore button is clicked
    public void Highscore()
    {
    }

    //When exit button is clicked
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Clicked");
    }
}