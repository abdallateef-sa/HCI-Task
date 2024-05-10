using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Win_Meun : MonoBehaviour
{
    public void Setup()
    {
        gameObject.SetActive(true);
    }

    public void Loadscrene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public GameObject Info;





    public void Trigger()
    {

        if (Info.activeInHierarchy == false)
        {
            Info.SetActive(true);

        }



    }

    public void Close()
    {
        if (Info.activeInHierarchy == true)
        {
            Info.SetActive(false);
        }

    }


    public string url; // الرابط URL الذي تريد فتحه

    public void OpenExternalURL()
    {
        // فتح الرابط URL عن طريق المتصفح الافتراضي
        Application.OpenURL(url);
    }

    public void Load_Home_Screne(string Home_Name)
    {
        SceneManager.LoadScene(Home_Name);
        Score_Script.scoreCount = 0;
    }

    public void Start_Game(string first_level)
    {
        SceneManager.LoadScene(first_level);
    }

}
