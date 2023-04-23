using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
    public Slider PinSpeed;
    public Slider RotatorSpeed;
    public Dropdown ColorDown;
    public InputField Namezone;
    public static int Colorer;
    public static float PinBonus;
    public static float RotatorBonus;
    public static string Name;

    public void Play()
    {
        Colorer = ColorDown.value;
        PinBonus = PinSpeed.value;
        RotatorBonus = RotatorSpeed.value;
        Name = Namezone.text;
        SceneManager.LoadScene("mainlevel");
    }


}
    
