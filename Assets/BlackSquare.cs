using System;
using UnityEngine;

public class BlackSquare : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("Black square clicked");
        ScoreBoard.score -= 1;
    }
}
