using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetector : MonoBehaviour
{
    private bool touchedTheGround = false;

    private void OnTriggerEnter(Collider other)
    {
        transform.root.GetComponent<Characters>().ResetJump();
    }
}
