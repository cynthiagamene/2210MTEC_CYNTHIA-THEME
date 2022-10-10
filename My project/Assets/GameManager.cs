using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour

{
    public int score = 0;
    public GameObject [] itemPrefab;
    public Transform leftTran;
    public Transform rightTran;
    public TextMeshPro ScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnItem",0,2 );
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = score.ToString();
        
    }
    public void SpawnItem()
    {
        float rmdXvalue = Random.Range(leftTran.position.x, rightTran.position.x);
        Vector2 spawnPos = new Vector2(rightTran.position.x, leftTran.position.y);
        int index = Random.Range(0, itemPrefab.Length);
        Instantiate(itemPrefab[index], spawnPos, Quaternion.identity);
    }

    public void IncrementScore(int value)
    {
        score += value;
      
    }
}

