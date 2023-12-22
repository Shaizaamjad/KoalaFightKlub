using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PopupManager : MonoBehaviour
{
    [Header("Panel")]
    public GameObject userNamePanel;
    public GameObject AlertPanel;
    public GameObject AdjustVolumePanel;
    public GameObject ForgetPasswordPanel;
    public GameObject AlertPanel1;
    public GameObject InventoryPanel;
    public GameObject ConnectWalletPanel;
    public GameObject GameResolutionPanel;
    public GameObject SaveKeysPanel;
    public GameObject InviteFriendsPanel;
    public UIManager uiManager;

    [Header("UserNamePanel")]

    public Image CharcterImage;
    public Button UploadFile;
    public Button Proceed;
    public InputField NameInputField;
    public InputField EmailInputField;

    [Header("AlertPanel")]
    public Button Showkeys;
    public Button Yes;
    public Button No;
    public Button BackButton;

    [Header("AdjustVolume")]
    public Slider VFXslider;
    public Slider MusicSlider;
    public Slider VoiceChatSlider;

    [Header("ForgetPassword")]
    public Image CharcterImage1;
    public Button UploadFile1;
    public Button SendLink;
    public InputField NameInputField1;
    public InputField EmailInputField1;

    [Header("Inventory Panel")]
    public Image InventoryCharcterImage;
    public Button EditButton;
    public Button QuitButton;
    public TMP_Text TotalKoText;
    public TMP_Text TimePlayedText;
    public TMP_Text Khkwon;
    public TMP_Text KhklostText;
    public Image Characterimage;
    public Image QuestionMarkimage;
    public Image PerkBoosterimage;
    public Image Arenaimage;
    public Image Earnedtrophiesimage;
    public Image Emojiesimage;


    [Header("ConnectWalletPanel")]
    public Image ScannerImage;
    public Button ConnectwithBladeButton;
    public Button ConnectwithQRbutton;

    [Header("Resolution")]
    public Toggle toggle;
    public Button DoneButton;

    [Header("SaveKeys")]
    public Toggle toggle1;
    public Button DoneButton1;
    public Button Keys;

    [Header("InviteFriends")]
    public InputField SearchField;
    public Button SearchButton;
    public Toggle toggle2;
    public Button SendButton;

    [Header("UserProfile")]
    public Button Profilebutton;
    public TMP_Text ProfileText;
    public TMP_Text ProfileIdText;

    [Header("Button")]
    public Button SinglePlayer;
    public Button StoryMode;
    public Button DemoMode;
    public Button OnlineMode;
    public Button Tournaments;
    public Button Trophies;
    public Button MarketPlace;
    public Button InviteFriends;
    public Button Quit;
    public Button Setting;
    public Button BladeWallet;

    public GameObject[] Uihandler;

    private void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        SinglePlayer.onClick.AddListener(Single);

    }

    public void Single()
    {
        GameObject mainMenu = Instantiate(uiManager.CharcterSelection);
    }

    public void openPanel(int index)
    {
        for (int i = 0; i < Uihandler.Length; i++)
        {
            if (i == index)
            {
                Uihandler[i].SetActive(true);
            }
            else
            {
                Uihandler[i].SetActive(false);
            }
        }
    }

}
