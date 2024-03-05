using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�����ۿ� �����ؼ� �÷��̾ Ž���� �÷��̾� ��ó�� �����̰� �ϴ� �ڵ�
public class Magnet : MonoBehaviour
{
    public float item_speed = 5.0f;       //�������� �������� �ӵ�
    public float magnet_distance = 10.0f; //�ڼ� ���� ����

    Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        var distance = Vector3.Distance(transform.position, player.position);
        //Vector3.Distance(a,b)�� a�� b ������ �Ÿ��� ����ϴ� ����

        if(distance <= magnet_distance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, item_speed * Time.deltaTime);
            //Vector3.MoveToward(a,b,c)�� a�� b���� �̵��ϴµ� c��ŭ�� �ӵ��� �̵��մϴ�.   
        }

    }
}
