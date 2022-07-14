using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;

public class Przeszkoda : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
     GetComponent<AutoMoveAndRotate>().enabled = false;
    }
}
