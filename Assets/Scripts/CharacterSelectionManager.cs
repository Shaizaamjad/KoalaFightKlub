using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectionManager : MonoBehaviour
{
    [Header("Text")]

    public TMP_Text KhkText;
    public TMP_Text HBARText;

    [Header("Image")]

    public Image SpeediconPlayer1;
    public Image PowericonPlayer1;
    public Image DefenceiconPlayer1;
    public Image StaminaiconPlayer1;
    public Image SpeediconPlayer2;
    public Image PowericonPlayer2;
    public Image DefenceiconPlayer2;
    public Image StaminaiconPlayer2;
    public Image Readyimage;
    public Image CharacterImage;
    public Image CharacterNameImage;
    public Image NextPlayerimage;
    public Image PlayerImage;
    public Image PlayerNameImage;
    public Image QuestionMarkimage;
    public Image Highliter;

    [Header("Button")]
    public Button Back;
    public Button CharcterButton;
    public Button ChooseRandomlyButton;
    public Button Charcter2Button;

    public UIManager uiManager;

    private void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        ChooseRandomlyButton.onClick.AddListener(Randomly);
    }

    public void Randomly()
    {
        GameObject mainMenu = Instantiate(uiManager.CharcterCustomization);
    }

}
