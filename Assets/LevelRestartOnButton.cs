using UnityEngine;
using System.Collections;

public class LevelRestartOnButton : MonoBehaviour {

    public Transform Ball;
    public Rect menuBackground;
    public Rect buttonPosition;
    public Rect button2Position;

    public void onGUI()
        {
            GUI.Box(menuBackground, "");
        if(GUI.Button(buttonPosition,"Restart"))
            {
                Ball.GetComponent<AcceleredBallMovement>().Restart();
            }
        if(GUI.Button(button2Position,"Quit Game"))
            {
                Application.Quit();
            }
        }

    }