using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
    private Image Splashscreen;

    private bool FadedIn = false;
    private bool FadedOut = false;

    public int FadeInSeconds;
    public int FadeOutSeconds;

    // Use this for initialization
    void Start()
    {
        Splashscreen = GetComponent<Image>();
        //Set Alpha to zero for fade in
        Splashscreen.canvasRenderer.SetAlpha(0f);
    }

    // Update is called once per frame
    void Update()
    {
        //Fade In
        if (Splashscreen.canvasRenderer.GetAlpha() < 0.95f && FadedIn == false)
        {
            FadeIn();
            if (Splashscreen.canvasRenderer.GetAlpha() >= 0.95f)
            {
                FadedIn = true;
            }
        }

        //Fade Out
        if (FadedIn == true && FadedOut == false)
        {
            FadeOut();
            if (Splashscreen.canvasRenderer.GetAlpha() <= 0.10f)
            {
                FadedOut = true;
            }
        }

        //Load Next Scene when done
        if (FadedIn == true && FadedOut == true)
        {
            SceneManager.LoadScene("Main Menu");
        }
    }

    //Fade In
    private void FadeIn()
    {
        Splashscreen.CrossFadeAlpha(1f, FadeInSeconds, false);
    }

    //Fade Out
    private void FadeOut()
    {
        Splashscreen.CrossFadeAlpha(0f, FadeOutSeconds, false);
    }
}