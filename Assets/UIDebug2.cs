using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIDebug2 : MonoBehaviour
{
    public TMP_Text SelectedDanceText;
    void Start()
    {
        SelectedDanceText.text += MainManager.Instance.SelectedDance;
    }

}
