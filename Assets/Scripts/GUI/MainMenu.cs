using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [Header("Bools")]
    public bool showMenu, showOptions, playOptions, brightness, resolution;
    public bool res1, res2, res3, res4, res5, res6, res7, res8, fullScreen, windowed, currentState;

    [Header("References")]
    public AudioSource audi;
    public GameObject menu, optionsMenu, playOptionsMenu;
    public Slider aSlider, bSlider;
    public Light dirLight;


    // Use this for initialization
    void Start()
    {
        showMenu = true;
        res5 = true;
        fullScreen = true;

        audi = GameObject.Find("Audio Source").GetComponent<AudioSource>();
        dirLight = GameObject.Find("Directional Light").GetComponent<Light>();
        aSlider.value = audi.volume;
        bSlider.value = dirLight.intensity;
    }
    void Update()
    {
        #region bool setting
        if (showMenu == true)
        {
            menu.SetActive(true);
        }
        else menu.SetActive(false);
        if (playOptions == true)
        {
            playOptionsMenu.SetActive(true);
        }
        else playOptionsMenu.SetActive(false);
        if (showOptions == true)
        {
            optionsMenu.SetActive(true);
        }
        else optionsMenu.SetActive(false);
        
        #endregion

    }
    #region Buttons
    public void ShowMenu()
    {
        playOptions = false;
        showOptions = false;

        showMenu = true;
    }
    public void PlayButton()
    {
        showMenu = false;
        showOptions = false;

        playOptions = true;
    }
    public void ShowOptions()
    {
        showMenu = false;
        playOptions = false;

        showOptions = true;
    }

    public void Quit()
    {
        Debug.Log("We are Quitting the Game");
        Application.Quit();
    }
    public void PlayGame()
    {
        Debug.Log("Start a new Game");
        SceneManager.LoadScene("Level_01");
    }
    public void LoadGame()
    {
        Debug.Log("Load a Saved Game");
    }
    #endregion
    #region resolutions
    public Dropdown resDropdown;
    public void ChangeResolution()
    {
        #region 1024 X 576
        if (resDropdown.captionText.text == "1024 X 576")
        {
            Screen.SetResolution(1024, 576, fullScreen);//screen resolution is 1024 x 576
            Debug.Log("we changed the resolution");
            res1 = true;//setting resolution 1 to true

            ///ALL OTHERS ARE FALSE///

            res2 = false;

            res3 = false;

            res4 = false;

            res5 = false;

            res6 = false;

            res7 = false;

            res8 = false;
        }
        #endregion
        #region 1152 X 648
        if (resDropdown.captionText.text == "1152 X 648")
        {
            Screen.SetResolution(1152, 648, fullScreen);//screen resolution is 1152 x 648
            Debug.Log("we changed the resolution");
            res2 = true;//setting resolution 2 to true

            ///ALL OTHERS ARE FALSE///

            res1 = false;

            res3 = false;

            res4 = false;

            res5 = false;

            res6 = false;

            res7 = false;

            res8 = false;
        }
        #endregion
        #region 1280 X 720
        if (resDropdown.captionText.text == "1280 X 720")
        {
            Screen.SetResolution(1280, 720, fullScreen);//screen resolution is 1280 x 720

            res3 = true;//setting resolution 3 to true

            ///ALL OTHERS ARE FALSE///

            res1 = false;

            res2 = false;

            res4 = false;

            res5 = false;

            res6 = false;

            res7 = false;

            res8 = false;
        }
        #endregion
        #region 1366 X 768
        if (resDropdown.captionText.text == "1366 X 768")
        {
            Screen.SetResolution(1366, 768, fullScreen);//screen resolution is 1366 x 768

            res4 = true;//setting resolution 4 to true

            ///ALL OTHERS ARE FALSE///

            res1 = false;

            res2 = false;

            res3 = false;

            res5 = false;

            res6 = false;

            res7 = false;

            res8 = false;
        }
        #endregion
        #region 1600 X 900
        if (resDropdown.captionText.text == "1600 X 900")
        {
            Screen.SetResolution(1600, 900, fullScreen);//screen resolution is 1600 x 900

            res5 = true;//setting resolution 5 to true

            ///ALL OTHERS ARE FALSE///

            res1 = false;

            res2 = false;

            res3 = false;

            res4 = false;

            res6 = false;

            res7 = false;

            res8 = false;
        }
        #endregion
        #region 1920 X 1080
        if(resDropdown.captionText.text == "1920 X 1080")
        {
            Screen.SetResolution(1920, 1080, fullScreen);//screen resolution is 1920 x 1080

            res6 = true;//setting resolution 6 to true

            ///ALL OTHERS ARE FALSE///

            res1 = false;

            res2 = false;

            res3 = false;

            res4 = false;

            res5 = false;

            res7 = false;

            res8 = false;
        }
        #endregion
        #region 2560 X 1440
        if(resDropdown.captionText.text == "2560 X 1440")
        {
            Screen.SetResolution(2560, 1440, fullScreen);//screen resolution is 2560 x 1440

            res7 = true;//setting resolution 7 to true

            ///ALL OTHERS ARE FALSE///

            res1 = false;

            res2 = false;

            res3 = false;

            res4 = false;

            res5 = false;

            res6 = false;

            res8 = false;
        }
        #endregion
        #region 3840 X 2160
        if(resDropdown.captionText.text == "3840 X 2160")
        {
            Screen.SetResolution(3840, 2160, fullScreen);//screen resolution is 3840 x 2160

            res8 = true;//setting resolution 8 to true

            ///ALL OTHERS ARE FALSE///

            res1 = false;

            res2 = false;

            res3 = false;

            res4 = false;

            res5 = false;

            res6 = false;

            res7 = false;
        }
        #endregion
    }
    #endregion
    #region Screen Settings
    public void FullScreenMode()
    {
        Screen.fullScreen = true;//setting fullscreen to true

        fullScreen = true;//changes the toggle to true allowing the GUI to be filled

        windowed = false;//changes the toggle to false to show that windowed is unselected}
    }
    public void WindowMode()
    {
        Screen.fullScreen = false; //setting fullscreen to false

        fullScreen = false;//changes the toggle to false showing that fullscreen is unselected

        windowed = true;//changes windowed to true allowing the GUI to be filled
    }
    #endregion

}

