using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public  class gameManager : MonoBehaviour
{
     static int playerScore1 = 0;
     static int playerScore2 = 0;
    public  Text playgame;
    public GUISkin gUISkin;

    Transform Ball;

     void Start()
    {
        Ball = GameObject.FindGameObjectWithTag("Ball").transform;    
    }
        public  void Score(string wallName){
        if (wallName == "rightWall")
        {
            playerScore1+=1;
            if(playerScore1 == 10) 
            {
                SceneManager.LoadScene(2);
            }
          
        }
        else if (wallName == "leftWall")
        {
            playerScore2+=1;
            if (playerScore2 == 10) 
            {
                SceneManager.LoadScene(3);
            }
        }

       
    }

    public void OnGUI() {
    GUI.skin=gUISkin;
    GUI.Label(new Rect(Screen.width/2-150-18,20,100,100),""+playerScore1);
    GUI.Label(new Rect(Screen.width/2+150-18,20,100,100),""+playerScore2);

    if (GUI.Button(new Rect(Screen.width/2-121/2,35,121,53),"Reset")){
            playerScore1=0;
            playerScore2=0;
            Ball.GetComponent<ballMove>().resetBall();
    }
    
}
}


