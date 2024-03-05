using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{

    public bool isCountDown = true; //ī��Ʈ �ٿ��� ������ ���� �Ǵ�
    public float gameTime = 0;      //������ �ִ� �ð��� �����ϴ� ����
    public bool isTimeOver = false; //Ÿ�̸Ӹ� ���������� �Ǵ�
    public float displayTime = 0;   //ȭ�鿡 ǥ�õ� �ð�

    float times = 0; //���� �ð� üũ

    // Start is called before the first frame update
    void Start()
    {
        //ī��Ʈ �ٿ��� �����ϴ� ��� ȭ�鿡 ǥ���� �ð��� ���� �ð����� �����մϴ�.
        displayTime = gameTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(isTimeOver == false)
        {
            times += Time.deltaTime;

            if(isCountDown) //Count down
            {
                displayTime = gameTime - times;
                if(displayTime <= 0.0f)
                {
                    displayTime = 0.0f;
                    isTimeOver = true;
                }
            }
            else //Count up
            {
                displayTime = times;
                if (displayTime >= gameTime)
                {
                    displayTime = gameTime;
                    isTimeOver=true;
                }       
            }
        }
    }
}
