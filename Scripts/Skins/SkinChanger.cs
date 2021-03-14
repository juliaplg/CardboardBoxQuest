using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinChanger : MonoBehaviour
{
    public SpriteRenderer catSprite;
    public SpriteRenderer bunnySprite;
    
    public Sprite[] catSkins;
    public Sprite[] bunnySkins;


    private void Start()
    {
        catSprite.sprite = catSkins[PlayerPrefs.GetInt("skinIndex")];
        bunnySprite.sprite = bunnySkins[PlayerPrefs.GetInt("skinIndex")];
    }
    public void ChangeSkin(int skinIndex)
    {
        for (int i = 0; i < catSkins.Length; i++)
        {
            if (i == skinIndex)
            {
                catSprite.sprite = catSkins[i];
                bunnySprite.sprite = bunnySkins[i];
                PlayerPrefs.SetInt("skinIndex", i);
            }
        }
    }
}
