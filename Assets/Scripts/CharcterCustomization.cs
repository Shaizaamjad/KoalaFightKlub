using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CharcterCustomization : MonoBehaviour
{
    [Header("Text")]

    public TMP_Text KhkText;
    public TMP_Text HBARText;

    [Header("Image")]
    public Image Speed;
    public Image Power;
    public Image Defence;
    public Image Stamina;
    public Image Speedicon;
    public Image Powericon;
    public Image Defenceicon;
    public Image Staminaicon;

    [Header("Button")]
    public Button Equip;
    public Button Proceed;
    public Button AutoEquip;
    public Button Clear;
    public Button Upgrade;
    public UIManager uiManager;
    public GameObject[] panelhandler;
    private void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        Proceed.onClick.AddListener(Proced);
    }

    public void Proced()
    {
        GameObject mainMenu = Instantiate(uiManager.ArenaSelection);
    }

    public void openPanel(int index)
    {
        for (int i = 0; i < panelhandler.Length; i++)
        {
            if (i == index)
            {
                panelhandler[i].SetActive(true);
            }
            else
            {
                panelhandler[i].SetActive(false);
            }
        }
    }


}
