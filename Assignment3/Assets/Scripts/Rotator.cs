using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MenuManager;
public class Rotator : MonoBehaviour
{
    public float speed = 100f;

    void Update ()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime* RotatorBonus);
    }
}
