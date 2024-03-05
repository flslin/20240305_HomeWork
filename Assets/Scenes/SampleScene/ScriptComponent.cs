using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�� Ŭ������ ����Ƽ �������� ���� ������Ʈ�� ������ �� �ֽ��ϴ�.

//RequireComponent(typeof())��
//�� ��ũ��Ʈ�� ����� �� �ش� ������Ʈ�� �䱸�ϴ� �Ӽ��Դϴ�.
//�� �Ӽ��� �پ��ִ� ��ũ��Ʈ�� ������Ʈ�� ������Ʈ�ν� ������ ���
//������Ʈ�� �ش� ������Ʈ�� ���� ��� �ڵ����� ������ �����մϴ�.
//�׸��� �� �Ӽ��� �����ϴ� ���� ������ ������ �䱸�ϴ� ������Ʈ�� ����ڴ�
//������ �� �����ϴ�.
[RequireComponent(typeof(AudioSource))]
public class ScriptComponent : MonoBehaviour
{
    public GameObject prefabs;
    //1. ��ũ��Ʈ���� public���� ������Ʈ�� �䱸�� ���
    //������ ������ ������ �����ؾ� �մϴ�.
    //���� ��� �ڵ� ���� �� NullReference ���� �߻�
    //�ش� ������ ���۷����� ���� �� �ߴ� ����
    //���۷����� ������ �ǹ��ϸ�, �ش� �����Ϳ� ���� ������ �����ϴ� �뵵��
    //����մϴ�.

    AudioSource audioSource;
    //2. ��ũ��Ʈ���� public�� �ƴ� ��Ȳ���� ������Ʈ�� ������ ���
    //������ �����ϱ� ��, �ش� ����� ��ü�κ��� �޾ƿ��� �۾��� ����
    //������ �����մϴ�.

    GameObject normal_object;
    //3. ��ũ��Ʈ���� public�� �ƴ� ��Ȳ���� ������Ʈ�� ������ ���
    //���� ������ �ش� ��ü�� ã�Ƽ� �����ϴ� ���

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //GetComponent<T>�� ��ü(������Ʈ)�κ��� <T> ��ġ�� �ۼ��� ������ ������Ʈ�� ������
        //����� ������ �ֽ��ϴ�.
        //�� �ڵ带 ����� ��� �ݵ�� �� ��ũ��Ʈ�� ������Ʈ�� ������ �ִ� ������Ʈ��
        //�ش� ������Ʈ�� ������ �־�� ���������� �۵��մϴ�.
        //�ƴ� ��� NullReference ���� �߻�

        audioSource.Play();
        //���� �ڵ�� ���� ���� audioSource�� AudioSource ������ �Ǿ���
        //�ش� ������Ʈ�� ����� ����� �� �ְ� �˴ϴ�.

        normal_object = GameObject.Find("normal_object");
        //GameObject.Find()�� () �ȿ� ��ü�� �̸��� �ۼ��ϸ�, �ش� �̸��� ���� ���ο���
        //�����ϴ� ����Դϴ�.
        //���� ��� ������ �߻��մϴ�.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
