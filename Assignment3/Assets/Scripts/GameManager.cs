using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static MenuManager;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;

    public Rotator rotator;
    public Spawner spawner;

    public Animator animator;

    public Text NameLabel;
    public SpriteRenderer Render;
    

    public void Start ()
    {
        NameLabel.text = Name;
        if (Colorer == 1)
        {
            Render.color = new Color(0f, 0f, 140f, 1f);
        }
        
    }




    public void EndGame ()
    {
        if (gameHasEnded)
            return;

        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger("EndGame");
        gameHasEnded = true;
        Debug.Log("End Game");
    }

    public void Restartlevel ()
    {
        SceneManager.LoadScene("Exit");
    }

}
