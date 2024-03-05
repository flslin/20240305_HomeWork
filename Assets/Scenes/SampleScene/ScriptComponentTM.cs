using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScriptComponentTM : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI; //�ؽ�Ʈ �޽����θ� ����ϴ� UI
    public TMP_Text tmp; //�ؽ�Ʈ �޽����� �߿��� �ؽ�Ʈ�� �� ����

    // Start is called before the first frame update
    void Start()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        textMeshProUGUI.text = "<b>���� �ؽ�Ʈ�� ū ���̰� ����.</b>";
    }

    public void OnButtonEnter(TextMeshProUGUI text)
    {
        SetBold(text.text);
    }

    public string SetBold(string data)
    {
        return $"<b>{data}</b>";
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
