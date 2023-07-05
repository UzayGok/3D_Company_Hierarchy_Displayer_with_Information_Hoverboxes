using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipSystem : MonoBehaviour
{
    private static TooltipSystem current;

    public Tooltip tooltip;

    public void Awake()
    {
        current = this;
    }

    public static void Show(string content, string header)
    {
        current.tooltip.SetText(content, header);
        current.tooltip.gameObject.SetActive(true);

        RectTransform rectTransform = current.tooltip.gameObject.GetComponent<RectTransform>();
        Vector2 size = new Vector2(rectTransform.rect.width, rectTransform.rect.height);
        Vector2 actualSize=new Vector2(size.x*Screen.width / 1920,  size.y * Screen.height / 1080);
        Vector2 sizeFinal=new Vector2((size.x+10)*Screen.width / 1920,  (size.y+10) * Screen.height / 1080);
        Vector2 position = Input.mousePosition + new Vector3(sizeFinal.x / 2, -sizeFinal.y / 2 - 5, 0);

        if(position.x+actualSize.x/2>Screen.width) position.x=Screen.width-actualSize.x/2;
        if(position.y-actualSize.y/2<0) position.y=actualSize.y/2;
        current.tooltip.gameObject.transform.position = position;
    }

    public static void Hide()
    {
        current.tooltip.gameObject.SetActive(false);
    }
}
