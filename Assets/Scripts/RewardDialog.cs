using TMPro;
using UnityEngine;

public class RewardDialog : MonoBehaviour
{
    public TextMeshProUGUI Head;
    public TextMeshProUGUI Body;
    public TextMeshProUGUI allmoney;
    public TextMeshProUGUI hourmoney;

    public void CloseButton()
    {
        Head.text = "РУСЫ РУСЫ ГОЙДА";
    }

    public void RewardButton()
    {
        //пук пук среньк,+ деньги,жаль что не у меня, а кнопка работает?
        Head.text = "РУСЫ РУСЫ СОСАТЬ АМЕРИКА";
    }

    public void SetData(string header, string description, int value1, int value2)
    {
        Head.text = header;
        Body.text = description;
        allmoney.text = value1.ToString();
        hourmoney.text = value2.ToString();
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetData("хуй","жопа",322,123);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
