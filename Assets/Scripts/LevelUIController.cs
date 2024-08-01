using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUIController : MonoBehaviour
{
    GameObject level;
    public static float levelNumber = 1;
    public static float loadingTime;

    void Start()
    {
        loadingTime = 2f;
        
        level = GameObject.Find("LevelNumber");
        this.level.GetComponent<TextMeshProUGUI>().text = levelNumber.ToString("F0");

        levelNumber++;

        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        loadingTime -= Time.deltaTime;
    }
}
