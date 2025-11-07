using MiniGameCollection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public bool isB1Pressed = false;
    public bool isB2Pressed = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ArcadeInput.Player1.Action1.Pressed && isB1Pressed == false)
        {
            isB1Pressed = true;
            isB2Pressed = false;
        }

        if (ArcadeInput.Player1.Action2.Pressed && isB2Pressed == false)
        {
            isB2Pressed = true;
            isB1Pressed = false;
        }
    }
}
