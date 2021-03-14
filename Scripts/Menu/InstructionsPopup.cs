using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionsPopup : MonoBehaviour
{
    public GameObject panel;
    bool isOpen;

    public void OpenInstructions()
    {
        panel.SetActive(true);
    }
    public void CloseInstructions()
    {
        panel.SetActive(false);
    }
}
