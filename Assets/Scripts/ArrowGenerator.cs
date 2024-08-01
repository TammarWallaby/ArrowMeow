using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    
    float span = 1.0f;
    float delta = 0f;

    private void Start()
    {
        span = 1/LevelUIController.levelNumber;  // 화살 나오는 간격 조절
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        this.delta += Time.deltaTime;
        if(this.delta>this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab);
            float px = Random.Range(-8f, 8f);  // 화살 생성하는 좌우 범위 조절
            go.transform.position = new Vector3(px, 7, -1);
        }
    }
}
