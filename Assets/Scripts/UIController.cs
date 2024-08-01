using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject player;
    GameObject zhonya;
    GameObject timerText;

    public float time = 15.0f;
    public float zhonyaRespawnTime;
    public float zhonyaTime;
    public bool useZhonya;
    

    void Start()
    {
        zhonyaRespawnTime = 0.0f; // 초기 무적 게이지 조절 0.0f ~ 1.0f
        zhonyaTime = 1f; // 무적 시간 조절
        useZhonya = false;
        this.timerText = GameObject.Find("TimeText");
        this.zhonya = GameObject.Find("Zhonya");
        this.zhonya.GetComponent<Image>().fillAmount = zhonyaRespawnTime;

    }

    
    void Update()
    {
        if(player==null) // 플레이어가 사라지면
        {
            SceneManager.LoadScene("GameOver");
        }

        this.time -= Time.deltaTime;
        this.timerText.GetComponent<TextMeshProUGUI>().text = this.time.ToString("F1");

        this.zhonya.GetComponent<Image>().fillAmount += Time.deltaTime * 0.13f;

        if(time<0f) // 레벨 클리어(시간 끝까지 버티면) -> Level씬으로 이동
        {
            SceneManager.LoadScene("LevelUI");            
        }

        if(zhonya.GetComponent<Image>().fillAmount==1&&Input.GetKeyDown(KeyCode.Space)) 
        {
            player.GetComponent<SpriteRenderer>().color = Color.yellow;
            this.zhonya.GetComponent<Image>().fillAmount = 0f;
            useZhonya=true;
            this.player.GetComponent<CircleCollider2D>().enabled = false;
        }

        if(useZhonya)
        {
            zhonyaTime-= Time.deltaTime;
        }

        if (useZhonya && zhonyaTime <= 0f)
        {
            player.GetComponent<SpriteRenderer>().color = Color.white;
            useZhonya = false;
            zhonyaTime = 1f;
            this.player.GetComponent<CircleCollider2D>().enabled = true;
        }
    }
}
