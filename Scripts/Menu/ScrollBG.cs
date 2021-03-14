using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBG : MonoBehaviour
{
    public float speed;
    public RectTransform rectTransform;
    public float rectX;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        
        if (PlayerPrefs.GetFloat("rectX") != 0)
        {
            rectX = PlayerPrefs.GetFloat("rectX");
        }
        else
        {
            rectX = 1095;
        }
    }
    void Update()
    {
        PlayerPrefs.SetFloat("rectX", rectX);
        rectTransform.anchoredPosition = new Vector2(rectX, 0);
        rectX -= speed * Time.deltaTime;
        if(rectTransform.anchoredPosition.x <= -951)
        {
            rectX = 1095;
        }
    }
}
