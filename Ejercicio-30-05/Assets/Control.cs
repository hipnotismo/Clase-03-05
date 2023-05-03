using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    private const string LanguageKey = "LanguageIs";
    // Start is called before the first frame update
    [SerializeField] GameObject LanguageMenu;
    [SerializeField] GameObject MainMenu;

    void Start()
    {
        Debug.Log(PlayerPrefs.GetString(LanguageKey));

        //PlayerPrefs.SetInt("IsFirstTime", 0);
        //int timePlayed = PlayerPrefs.GetInt("IsFirstTime");

        if (PlayerPrefs.HasKey(LanguageKey))
        {
            LanguageMenu.active = false;
            MainMenu.active = true;

        }
        else
        {
            LanguageMenu.active = true;
            MainMenu.active = false;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnglishLenguaje()
    {
        PlayerPrefs.SetString(LanguageKey, "English");
        Debug.Log(PlayerPrefs.GetString(LanguageKey));
        LanguageMenu.active = false;
        MainMenu.active = true;


    }

    public void SpanishLenguaje()
    {
        PlayerPrefs.SetString(LanguageKey, "Spanish");
        Debug.Log(PlayerPrefs.GetString(LanguageKey));
        LanguageMenu.active = false;
        MainMenu.active = true;


    }
    public void LanguageActive()
    {
        Debug.Log("AAAAAAAAAAAAAAA");

        LanguageMenu.active = true;
        MainMenu.active = false;
    }
}
