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
        span = 1/LevelUIController.levelNumber;  // ȭ�� ������ ���� ����
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
            float px = Random.Range(-8f, 8f);  // ȭ�� �����ϴ� �¿� ���� ����
            go.transform.position = new Vector3(px, 7, -1);
        }
    }
}
