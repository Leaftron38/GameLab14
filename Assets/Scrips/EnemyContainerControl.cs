using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContainerControl : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float MinPositionX;
    public float MaxPositionX;
    public float PositionY;
    public int Timetocreat;
    // Start is called before the first frame update
    void Start()
    {
        CreateEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateEnemy()
    {
        float PositionX = Random.Range(MinPositionX, MaxPositionX);
        Vector2 PositionCreateEnemy = new Vector2(PositionX, PositionY); 
        Instantiate(EnemyPrefab, PositionCreateEnemy, transform.rotation);
        Invoke("CreateEnemy", Timetocreat);
    }
}
