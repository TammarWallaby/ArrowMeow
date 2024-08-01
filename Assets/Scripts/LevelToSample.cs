using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelToSample : MonoBehaviour // Level������ ���Ӿ�����
{
    GameObject levelController;
    void Start()
    {
        levelController = GameObject.Find("LevelUIController");
    }


    void Update()
    {
        if (LevelUIController.loadingTime < 0f)
        {
            SceneManager.LoadScene("SampleScene");
            Destroy(levelController); 
        }
    }
}
