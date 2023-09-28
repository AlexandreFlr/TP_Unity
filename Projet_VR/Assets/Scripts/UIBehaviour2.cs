using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIBehaviour2 : MonoBehaviour
{
    TMP_Text timerText ;
    // Start is called before the first frame update
    //int currentTime = 60 ;
    void Start()
    {
        timerText = GameObject.Find("Time").GetComponent<TMPro.TMP_Text>();
        StartCoroutine(TimerTick());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TimerTick(){
        while(GameVariables.currentTime>0)
        {
            yield return new WaitForSeconds(1);
            GameVariables.currentTime--;
            timerText.text = "Temps : " + GameVariables.currentTime.ToString();
        }
        SceneManager.LoadScene("Scene 2");
        GameVariables.currentTime = GameVariables.allowedTime ;
    }

    IEnumerator ChangeScene(){
        SceneManager.LoadScene("FinalScene");
        yield return null;
    }

    public void Modif1(){
            StartCoroutine(ChangeScene());
    }
}