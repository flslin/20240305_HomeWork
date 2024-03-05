using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region �ʵ�
    [Header("�̹���")]
    public GameObject mainImage;
    public Sprite gameOverSpr;
    public Sprite gameClearSpr;

    [Header("��ư UI")]
    public GameObject panel;
    public GameObject restartButton;
    public GameObject nextButton;

    Image titleImage;

    [Header("�ð� UI")]
    public GameObject timeBar; //�ð� ǥ�� �̹���
    public GameObject timeText; //�ð� �ؽ�Ʈ
    TimeController timeCnt;  // Ÿ�� ��Ʈ�ѷ� ����
    #endregion

#region ����Ƽ ������ ����Ŭ
    // Start is called before the first frame update
    void Start()
    {
        timeCnt = GetComponent<TimeController>();
        if(timeCnt != null)
        {
            if(timeCnt.gameTime == 0.0f)
                timeBar.SetActive(false); //�ð� ������ ���ٸ� ����ڽ��ϴ�.
        }

        Invoke("InactiveImage", 1.0f); //1�� �ڿ� �ش� �Լ��� �����ϴ� ���(Invoke)
        panel.SetActive(false); //�г� ��Ȱ��ȭ
    }
    // Update is called once per frame
    void Update()
    {
        //1�� : ���� Ŭ���� 2�� : ���� ���� 0�� : ���� ���� 3�� : ���� ��
        if(PlayerController.gameState == Enum.GetName(typeof(GameState),1))
        {
            //���� Ŭ���� �� ó���� ���
            mainImage.SetActive(true); //�̹��� Ȱ��ȭ
            panel.SetActive(true); //�г� Ȱ��ȭ
            restartButton.GetComponent<Button>().interactable = false;
            mainImage.GetComponent<Image>().sprite = gameClearSpr;
            PlayerController.gameState = Enum.GetName(typeof(GameState), 3);

            // �ð� ����
            if (timeCnt != null)
                timeCnt.isTimeOver = true;
        }
        else if(PlayerController.gameState == Enum.GetName(typeof(GameState), 2))
        {
            //������ ������ �� ó���� ���
            mainImage.SetActive(true);
            panel.SetActive(true);
            nextButton.GetComponent<Button>().interactable = false; 
            mainImage.GetComponent<Image>().sprite = gameOverSpr;
            PlayerController.gameState = Enum.GetName (typeof(GameState), 3);

            // �ð� ����
            if (timeCnt != null)
                timeCnt.isTimeOver = true;
        }
        else if (PlayerController.gameState == Enum.GetName(typeof(GameState), 0))
        {
            //������ ���� ���� �� ó���� ���
            var player = GameObject.FindGameObjectWithTag("Player");
            //�÷��̾�κ��� �÷��̾� ��Ʈ�ѷ��� ����� �����ɴϴ�.
            var playerController = player.GetComponent<PlayerController>();
            
            if(timeCnt != null)
            {
                if(timeCnt.gameTime > 0.0f)
                {
                    //�Ҽ��� ���ϴ� ������ ����մϴ�.
                    int time = (int)timeCnt.displayTime;

                    //TMP�� �۾��� ���
                    timeText.GetComponent<TextMeshProUGUI>().text = time.ToString();
                    //Text(Legacy)�� �۾��� ���
                    //timeText.GetComponent<Text>().text = time.ToString();

                    //Ÿ�� ������ ���
                    if(time == 0)
                    {
                        //�÷��̾� ��Ʈ�ѷ��� ���� ���� ����� ȣ���մϴ�.
                        playerController.GameOver();
                    }
                }
            }
        }
    }
    #endregion

    #region �޼ҵ�
    void InactiveImage()
    {
        mainImage.SetActive(false); //�̹��� ��Ȱ��ȭ
    }
    #endregion
}
