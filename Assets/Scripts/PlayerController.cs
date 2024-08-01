using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private void Awake()
    {
        Application.targetFrameRate = 60;  // 프레임 고정
    }
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.2f, 0, 0); // 캐릭터 이동속도 조절 (좌)
        }

        if (Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.2f, 0, 0); // 캐릭터 이동속도 조절 (우)
        }
    }
}
