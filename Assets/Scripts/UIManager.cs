using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject ArenaSelection;
    public GameObject CharcterCustomization;
    public GameObject CharcterSelection;
    public GameObject Combos;
    public GameObject GamePlay;
    public GameObject Loading;
    public GameObject MatchSummary;
    public GameObject MainMenu;
    public GameObject Moves;
    public GameObject Pause;
    public GameObject StartMenu;
    public GameObject TapScreen;
    public GameObject Trophies;
    public GameObject MainMenuPanel;

     public static  UIManager instance;
    private void Start()
    {
        GameObject startMenu = Instantiate(StartMenu);
    }



}
