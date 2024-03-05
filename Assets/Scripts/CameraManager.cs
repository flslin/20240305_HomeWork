using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [Header("��ũ�� ����")]
    public float leftLimit = 0.0f;
    public float rightLimit = 0.0f;
    public float topLimit = 0.0f;
    public float bottomLimit = 0.0f;

    [Header("���� ��ũ��")]
    public GameObject subScreen;

    [Header("���� ��ũ��")]
    public bool isForceScrollX = false;  //����
    public float forceScrollSpeedX = 0.5f; //�� �� ������ x�� �Ÿ�
    public bool isForceScrollY = false;  //����
    public float forceScrollSpeedY = 0.5f; //�� �� ������ y�� �Ÿ�

    // Update is called once per frame
    void Update()
    {
        //�÷��̾ �����ؼ� ī�޶� ���󰡵��� ����
        //�־��� ��ũ���� ���� ��ġ��ŭ ���󰡰� �ϰڽ��ϴ�.

        var player = GameObject.FindGameObjectWithTag("Player");

        //�÷��̾ ������ ���
        if (player != null)
        {
            //x�� y���� �÷��̾��� ��ǥ�� ����
            float x = player.transform.position.x;
            float y = player.transform.position.y;
            //z���� ī�޶��� ��ǥ�� ����
            float z = transform.position.z;

            //���� ���⿡ ���� ó��
            if(isForceScrollX)
            {
                x = transform.position.x + (forceScrollSpeedX * Time.deltaTime);
                //x ��ǥ�� ������ �� �̵� ��ġ��ŭ �����ϰ� �˴ϴ�.
            }

            if (x < leftLimit)
            {
                x = leftLimit;

            }
            else if (x > rightLimit)
            {
                x = rightLimit;
            }

            //���� ���⿡ ���� ó��
            if(isForceScrollY)
            {
                y = transform.position.y + (forceScrollSpeedY * Time.deltaTime);
            }

            if (y < bottomLimit)
            {
                y = bottomLimit;
            }
            else if (y > topLimit)
            {
                y = topLimit;
            }

            //������ ��ġ�� �����մϴ�.
            Vector3 v3 = new Vector3(x, y, z);
            transform.position = v3;

            //���� ��ũ�� �̵�
            if(subScreen != null)
            {
                //x�� ���� ���� �����̰� �ִ� ��ũ����
                //x�� ���
                //y�� z�� ���� �ʿ䰡 ���⿡ ���� ��ũ���� ��ǥ�� �޾ƿɴϴ�.
                y = subScreen.transform.position.y;
                z = subScreen.transform.position.z;

                //���� x ���� ���� ��ġ��ŭ �̵��� ���� ������� ��ũ��
                //�ǵ��� �����մϴ�.
                Vector3 v = new Vector3(x / 2.0f, y, z);
                subScreen.transform.position = v;
            }
        }
    }
}
