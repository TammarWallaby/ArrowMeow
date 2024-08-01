using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Translate(0, -LevelUIController.levelNumber*0.05f, 0);  // -LevelUIController.levelNumber*0.05f << 화살 떨어지는 속도 조절

        if (transform.position.y < -5.0f)
            Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)  // 캐릭터가 화살에 닿는 판정, 판정 조절은 유니티 화면 인스펙터창에서 
    {                                                       // 플레이어판정 -> Circle Collider 2D Radius 조절  // 화살 판정 -> Assets/Prefabs/arrowPrefab -> Box Collider 2D Size & Offset 조절
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Destroy(this.player);
        }
    }

}
