using System;
using TMPro;
using UnityEngine;

public class AskDialog : MonoBehaviour
{
    public TextMeshProUGUI HeaderText;
    public TextMeshProUGUI BodyText;
    public void Start()
    {
        HeaderText.text = "Sosi";
        BodyText.text = "Паста говно";
    }

    public void YesButton()
    {
        HeaderText.text = "Красава";
    }

    public void NoButton()
    {
        HeaderText.text = "Не пизди";
    }
}
