using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptComponent2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //��ü�� ������ �ִ� ��������Ʈ �������� ����� �����ͼ�
        //�� ����� �ٷ� ����ϴ� �ڵ�
        //�̷� ������ �ڵ带 �ۼ��ϱ� ���ؼ� �� ��ũ��Ʈ�� ���� ���� ������Ʈ��
        //�ش� ������Ʈ�� ������ �־�� �մϴ�.
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 1, 0);
    }
}
