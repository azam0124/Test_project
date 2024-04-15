using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{
    // Start is called before the first frame update
    public static timer instance;
    public float Timer;
    public bool timerOn;
    public GameObject sTART;
    public TextMeshProUGUI timerText  ;
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn)
        {
            if (Timer > 0)
            {
                Timer -= Time.deltaTime;
                updateTimer(Timer);
            }
            else

            {

                
                timerOn = false;
                Timer = 5;
                sTART.SetActive(true);
                Invoke("delay",1f);
            }
        }
        
    }

    void delay()
    {
            this.gameObject.SetActive(false);
    }




    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float secound = Mathf.FloorToInt(currentTime % 60);
        timerText.text = secound.ToString();
    }
     public void timerON()
    {
        timerOn = true;
    }
}
