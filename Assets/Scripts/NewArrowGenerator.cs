using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewArrowGenerator : MonoBehaviour
{
    public GameObject generatorPrefab; 
    void Start()
    {
        for (int i = 0; i < LevelUIController.levelNumber + 2; i++) //LevelUIController.levelNumber + 2 << �� ���ڰ� �� �ٿ� �������� ȭ���� ���� �ʱⰪ ����
        {
            GameObject gp = Instantiate(generatorPrefab);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
