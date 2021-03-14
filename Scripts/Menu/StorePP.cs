using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorePP : MonoBehaviour
{

    public void StorePlayerPrefs()
    {
        PlayerPrefs.SetFloat("rectX", GameObject.Find("Icons").GetComponent<ScrollBG>().rectX);
    }

}
