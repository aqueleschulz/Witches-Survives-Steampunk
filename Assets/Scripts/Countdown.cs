using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public bool countdownEnded;
    public GameEvent onCountdownEnd;

    public float currentTime;
    public float startingTime = 6;

    public GameObject countdownObject;
    public Text countdownText;

    void Awake()
    {
        countdownText = this.GetComponent<Text>();
    }
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString();
        
        if(currentTime <= 0)
        {
            currentTime = 0;
            countdownObject.SetActive(false);
            countdownEnded = true;
            onCountdownEnd.Raise(this, countdownEnded);
        }
    }
}
