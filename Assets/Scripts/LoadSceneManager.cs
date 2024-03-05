using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneManager : MonoBehaviour
{
    public static string SceneName;
    [SerializeField] Image progress_bar;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("LoadScene");
    }

    public static void LoadScene(string sceneName)
    {
        SceneName = sceneName;
        SceneManager.LoadScene("LoadingScene");
    }

    //IEnumerator�� ����Ƽ���� �ڷ�ƾ ����� ����ϴ� �������̽��Դϴ�.
    IEnumerator LoadScene()
    {
        yield return null; //�� ������ ���
        AsyncOperation op = SceneManager.LoadSceneAsync(SceneName);
        //�Ϲ� LoadScene�� �ٸ��� �񵿱������� ���� ȣ���մϴ�.
        op.allowSceneActivation = false;
        //���� Ȱ��ȭ�Ǵ� �Ϳ� ���� �㰡�� �����ϴ�.

        float time = 0.0f; //�ð��� üũ�մϴ�.

        //���۷��̼��� �۾��� ����Ǵ� ���� �۾��� �ݺ��մϴ�.
        while(!op.isDone)
        {
            yield return null; // �� ������ Ż��
            time += Time.deltaTime; //������ �� �ð� �߰�

            //���۷��̼��� �۾��� �������� ��
            if(op.progress < 0.9f)
            {
                progress_bar.fillAmount = Mathf.Lerp(progress_bar.fillAmount, op.progress, time);
                //Mathf.Lerp(a,b,c)�� a���� b���� c �������� ������ �ٰ����� ����Դϴ�.(MoveToward�� ���)
                
                //�۾��� ���� �� �ð� 0
                if(progress_bar.fillAmount >= op.progress)
                {
                    time = 0.0f;
                }
            }
            else //�۾��� ������ �� ��
            {
                progress_bar.fillAmount = Mathf.Lerp(progress_bar.fillAmount, 1.0f, time);
                //���α׷��� ���� ũ�� -> 1.0�� �ǵ��� ó���մϴ�.
                if(progress_bar.fillAmount == 1.0f)
                {
                    op.allowSceneActivation = true; //�㰡 ����
                    yield break; //�۾� ����
                }
            }

        }





    }

}
