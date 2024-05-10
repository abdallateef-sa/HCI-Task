using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{

    //element 1 ==> Sol1
    //element 2 ==> Sol2   only 


    //sound
    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;





    public GameObject element1, element2, element3, element4, element5, element6, element7, element8, sol1, sol2;

    Vector2 elementPos1, elementPos2, elementPos3, elementPos4, elementPos5, elementPos6, elementPos7, elementPos8;


    bool sol1_Correct, sol2_Correct = false;

    void Start()
    {
        elementPos1 = element1.transform.position;
        elementPos2 = element2.transform.position;
        elementPos3 = element3.transform.position;
        elementPos4 = element4.transform.position;
        elementPos5 = element5.transform.position;
        elementPos6 = element6.transform.position;
        elementPos7 = element7.transform.position;
        elementPos8 = element8.transform.position;

    }

    public void DragElement1()
    {
        element1.transform.position = Input.mousePosition;
    }

    public void DragElement2()
    {
        element2.transform.position = Input.mousePosition;
    }
    public void DragElement3()
    {
        element3.transform.position = Input.mousePosition;
    }
    public void DragElement4()
    {
        element4.transform.position = Input.mousePosition;
    }
    public void DragElement5()
    {
        element5.transform.position = Input.mousePosition;
    }
    public void DragElement6()
    {
        element6.transform.position = Input.mousePosition;
    }
    public void DragElement7()
    {
        element7.transform.position = Input.mousePosition;
    }
    public void DragElement8()
    {
        element8.transform.position = Input.mousePosition;
    }


    public void DropElement1()
    {
        float Distance = Vector3.Distance(element1.transform.position, sol1.transform.position);
        if (Distance < 50)
        {
            element1.transform.position = sol1.transform.position;
            sol1_Correct = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            element1.transform.position = elementPos1;
            source.clip = incorrect;
            source.Play();
        }
    }


    public void DropElement2()
    {
        float Distance = Vector3.Distance(element2.transform.position, sol2.transform.position);
        if (Distance < 50)
        {
            element2.transform.position = sol2.transform.position;
            sol2_Correct = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            element2.transform.position = elementPos2;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropElement3()
    {

        element3.transform.position = elementPos3;
        source.clip = incorrect;
        source.Play();

    }

    public void DropElement4()
    {

        element4.transform.position = elementPos4;
        source.clip = incorrect;
        source.Play();

    }
    public void DropElement5()
    {

        element5.transform.position = elementPos5;
        source.clip = incorrect;
        source.Play();

    }
    public void DropElement6()
    {

        element6.transform.position = elementPos6;
        source.clip = incorrect;
        source.Play();

    }
    public void DropElement7()
    {

        element7.transform.position = elementPos7;
        source.clip = incorrect;
        source.Play();

    }
    public void DropElement8()
    {

        element8.transform.position = elementPos8;
        source.clip = incorrect;
        source.Play();

    }


    private bool scoreIncreased = false; // تحقق من أن النقاط تم زيادتها بالفعل
    void Update()
    {
        if (sol1_Correct && sol2_Correct)
        {
            // Debug.Log("Win");
            Game_win();
            if (scoreIncreased == false)
            {
                Score_Script.scoreCount += 1;
                scoreIncreased = true;
            }


        }
    }

    private void ResetScore()
    {
        scoreIncreased = false; // إعادة تعيين المتغير عندما يتم إعادة بدء اللعبة
    }

    public Win_Meun winMenu;

    public void Game_win()
    {
        if (winMenu != null)
        {
            winMenu.Setup(); // Activate the Win_Meun GameObject
        }
    }




}
