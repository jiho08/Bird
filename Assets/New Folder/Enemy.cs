using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float speed = 5f;
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = (Player.position - transform.position).normalized; // 플레이어 위치 - 적 위치
        transform.position += dir * speed * Time.deltaTime; // 적이 플레이어를 따라감
    }
}
