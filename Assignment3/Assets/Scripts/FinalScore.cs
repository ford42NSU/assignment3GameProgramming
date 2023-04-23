using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MenuManager;
using static Score;
public class FinalScore : MonoBehaviour
{

    public Text FinalScores;
    // Start is called before the first frame update
    void Start()
    {
        FinalScores.text = Name + ": " + PinCount;
    }
}
