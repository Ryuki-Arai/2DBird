using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour
{
    private TextMeshProUGUI timerText;
    static public float second;
    public float fSec;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        second = Time.timeSinceLevelLoad;
        second = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerScript.flag)
        {
            fSec += Time.deltaTime;
            timerText.text = "星になった...";
            if (fSec >= 3.0f) SceneManager.LoadScene("ResultScene");
        }
        else
        {
            second += Time.deltaTime;
            timerText.text = "スコア:" + second.ToString("00") + "光年";
        }
    }
}
