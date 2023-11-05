using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;
    [SerializeField] private GameObject title;
    [SerializeField] private GameObject playButton;
    [SerializeField] private GameObject creditsButton;
    [SerializeField] private GameObject creditsText;
    [SerializeField] private GameObject backToTitleButton;

    public void LoadGameplayScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void OpenCredits()
    {
        title.SetActive(false);
        playButton.SetActive(false);
        creditsButton.SetActive(false);
        creditsText.SetActive(true);
        backToTitleButton.SetActive(true);

    }

    public void CloseCredits()
    {
        title.SetActive(true);
        playButton.SetActive(true);
        creditsButton.SetActive(true);
        creditsText.SetActive(false);
        backToTitleButton.SetActive(false);
    }
}
