using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIBehaviour1 : MonoBehaviour
{
    TMP_Text headText ;
    TMP_Text timerText ;
    int nbCats = 0 ;
    // Start is called before the first frame update
    //int currentTime = 60 ;
    void Start()
    {
        headText = GameObject.Find("lblCats").GetComponent<TMPro.TMP_Text>();
        timerText = GameObject.Find("Time").GetComponent<TMPro.TMP_Text>();
        StartCoroutine(TimerTick());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddHit(){
        nbCats++ ;
        headText.text = "CatBots touchés : " + nbCats + " / 5" ;
        /*if(nbCats == 5){
            StartCoroutine(ChangeScene());
        }*/
    }

    IEnumerator TimerTick(){
        while(GameVariables.currentTime>0)
        {
            yield return new WaitForSeconds(1);
            GameVariables.currentTime--;
            timerText.text = "Temps : " + GameVariables.currentTime.ToString() ;
        }
        SceneManager.LoadScene("dragonHouse");
        GameVariables.currentTime = GameVariables.allowedTime ;
    }

    IEnumerator ChangeScene(){
        SceneManager.LoadScene("Scene 2");
        yield return null;
    }

    public void Modif(){
        if(nbCats >= 5){
            StartCoroutine(ChangeScene());
        }
    }
}