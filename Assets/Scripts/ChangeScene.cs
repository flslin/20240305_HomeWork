using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string sceneName;

    //�� �Ŵ��� Ŭ������ ����Ƽ���� ���� �����ϴ�
    //Ŭ�����Դϴ�.

    //UnityEngine.SceneManagement�� using�� ���¿��� ����� �����մϴ�.

    public void Load()
    {
        SceneManager.LoadScene(sceneName);
    }
}
