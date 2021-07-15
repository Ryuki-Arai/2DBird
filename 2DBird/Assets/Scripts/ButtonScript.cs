using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonScript : MonoBehaviour
{
    public void OnClick()
    {
        switch (gameObject.name)
        {
            case "Start":
                SceneManager.LoadScene("SampleScene");
                break;
            case "End":
            case "Close":
                SceneManager.LoadScene("TitleScene");
                break;
            case "Guidance":
                SceneManager.LoadScene("GuidanceScene");
                break;
        }
    }
}
