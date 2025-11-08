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
    public GameObject bg1;
    public GameObject bg2;
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

            bg1.transform.position = new Vector3(bg1.transform.position.x, bg1.transform.position.y - 0.5f, bg1.transform.position.z);
            bg2.transform.position = new Vector3(bg2.transform.position.x, bg2.transform.position.y - 0.5f, bg2.transform.position.z);
        }

        if (ArcadeInput.Player2.Right.Pressed && isRightPulled == false)
        {
            isLeftPulled = false;
            isRightPulled = true;
            smoke.SetActive(false);
            trainScoreCount++;

            bg1.transform.position = new Vector3(bg1.transform.position.x, bg1.transform.position.y - 0.5f, bg1.transform.position.z);
            bg2.transform.position = new Vector3(bg2.transform.position.x, bg2.transform.position.y - 0.5f, bg2.transform.position.z);
        }
    }
}
