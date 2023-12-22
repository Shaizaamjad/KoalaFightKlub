using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{

    [Header("Button")]
    public Button StartButton;
    public Button HederaButton;
    public Button BladeWalletButton;

    public UIManager uiManager;

    private void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        StartButton.onClick.AddListener(StartButtonPressed);
    }

    public void StartButtonPressed()
    {
        GameObject mainMenu = Instantiate(uiManager.MainMenuPanel);
    }

}
