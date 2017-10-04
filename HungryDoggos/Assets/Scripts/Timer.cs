using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text timerText;
    public int timeGiven;
    static int time;
    float lastTime = 0;

    // Use this for initialization
    void Start () 
    {
        time = timeGiven;
        lastTime = Time.time;
        timerText.text = "Time: " + time;
    }

    // Update is called once per frame
    void Update ()
    {
        if (Time.time >= lastTime + 1) {
            lastTime = Time.time;
            time--;
            timerText.text = "Time: " + time;
            if (time <= 0) {
                //end the game
                this.GetComponent<GameOver>().endGame ();
            }
        }
    }

    public static void addTime(int secs) {
        time += secs;
    }

    public static void subtractTime(int secs) {
        time -= secs;
    }

    public static int getTime(){
        return time;
    }
}
