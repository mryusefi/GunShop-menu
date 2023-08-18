using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Cointext;
    private int coin;

    [SerializeField] private GameObject ColdMenu;
    [SerializeField] private GameObject StyleMenu;
    [SerializeField] private GameObject MidMenu;
    [SerializeField] private GameObject HeavyMenu;
    [SerializeField] private GameObject MainMenu;

    public void ClickReturn()
    {
        StyleMenu.SetActive(false);
        MidMenu.SetActive(false);
        ColdMenu.SetActive(false);
        HeavyMenu.SetActive(false);
        MainMenu.SetActive(true);
    }


    void Start()
    {
        coin = 200;
        Cointext.text = coin.ToString();
    }

    public void ClickColdButton()
    {
        MainMenu.SetActive(false);
        ColdMenu.SetActive(true);
    }
    public void ClickStyleButton()
    {
        MainMenu.SetActive(false);
        StyleMenu.SetActive(true);
    }
    public void ClickMidButton()
    {
        MainMenu.SetActive(false);
        MidMenu.SetActive(true);
    }
    public void ClickHeavyButton()
    {
        MainMenu.SetActive(false);
        HeavyMenu.SetActive(true);
    }

    public void sell(int price)
    {
        coin -= price;
        Cointext.text = coin.ToString();
    }
    public void ClickExitButton()
    {
        Application.Quit();
    }
}

