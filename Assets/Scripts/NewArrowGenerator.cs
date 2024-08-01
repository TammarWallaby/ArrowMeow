using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewArrowGenerator : MonoBehaviour
{
    public GameObject generatorPrefab; 
    void Start()
    {
        for (int i = 0; i < LevelUIController.levelNumber + 2; i++) //LevelUIController.levelNumber + 2 << 이 숫자가 한 줄에 떨어지는 화살의 갯수 초기값 조절
        {
            GameObject gp = Instantiate(generatorPrefab);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
