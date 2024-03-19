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
        Vector3 dir = (Player.position - transform.position).normalized; // �÷��̾� ��ġ - �� ��ġ
        transform.position += dir * speed * Time.deltaTime; // ���� �÷��̾ ����
    }
}
