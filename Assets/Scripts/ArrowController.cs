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
        transform.Translate(0, -LevelUIController.levelNumber*0.05f, 0);  // -LevelUIController.levelNumber*0.05f << ȭ�� �������� �ӵ� ����

        if (transform.position.y < -5.0f)
            Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)  // ĳ���Ͱ� ȭ�쿡 ��� ����, ���� ������ ����Ƽ ȭ�� �ν�����â���� 
    {                                                       // �÷��̾����� -> Circle Collider 2D Radius ����  // ȭ�� ���� -> Assets/Prefabs/arrowPrefab -> Box Collider 2D Size & Offset ����
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Destroy(this.player);
        }
    }

}
