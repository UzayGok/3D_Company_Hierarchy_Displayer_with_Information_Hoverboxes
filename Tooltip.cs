using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tooltip : MonoBehaviour
{
    public TextMeshProUGUI headerField;

    public TextMeshProUGUI contentField;

    public LayoutElement layoutElement;

    public int characterWrapLimit;




    public void SetText(string content, string header)
    {
        headerField.text = header;
        contentField.text = content;
    }

    private void Update()
    {
        int headerLength = headerField.text.Length;
        int contentLength = contentField.text.Length;

        layoutElement.enabled = (
            headerField.preferredWidth >= layoutElement.preferredWidth
            || contentField.preferredWidth >= layoutElement.preferredWidth
        );
        
       
    }


}
