using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetryButton : MonoBehaviour
{
    public GameObject retryButton;
    public bool playerLoose;

    // Start is called before the first frame update
    void Start()
    {
        retryButton.SetActive(playerLoose);
    }

    void Update()
    {
        retryButton.SetActive(playerLoose);
    }

    public void UpdateBool(Component sender, object data)
    {
        if(data is bool)
        {
            playerLoose = (bool) data;
        }
    }
}
