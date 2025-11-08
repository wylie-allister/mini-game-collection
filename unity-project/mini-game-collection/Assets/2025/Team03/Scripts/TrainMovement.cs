using MiniGameCollection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMovement : MonoBehaviour
{
    public bool isLeftPulled = false;
    public bool isRightPulled = true;
    public GameObject smoke;
    public int trainScoreCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ArcadeInput.Player2.Left.Pressed && isLeftPulled == false)
        {
            isLeftPulled = true;
            isRightPulled = false;
            smoke.SetActive(true);
            trainScoreCount++;
        }

        if (ArcadeInput.Player2.Right.Pressed && isRightPulled == false)
        {
            isLeftPulled = false;
            isRightPulled = true;
            smoke.SetActive(false);
            trainScoreCount++;
        }
    }
}
