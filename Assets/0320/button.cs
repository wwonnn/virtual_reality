using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class button : MonoBehaviour
{
    public TMP_Text inputText, outputText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClick()
    {
        print("button�� Ŭ���Ǿ����ϴ�");
    }

    public void OnClick_SetText()
    {
        outputText.text = inputText.text;
    }
}
