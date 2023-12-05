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





}
