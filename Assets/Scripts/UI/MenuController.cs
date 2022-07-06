using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MenuController : MonoBehaviour
{
    public UIConstants uIConstants;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Awake()
    {
        Time.timeScale = 0.0f;
    }

    public void disableUI(int noOfRounds)
    {
        uIConstants.m_NumRoundsToWin = noOfRounds;
        foreach (Transform eachChild in transform)
        {
            if (eachChild.tag == "StartScreenOnly")
            {
                Debug.Log("Child found. Name: " + eachChild.name);
                // disable them
                eachChild.gameObject.SetActive(false);
                Time.timeScale = 1.0f;
            }
        }

        uIConstants.startMenuShown = false;
    }
}
