using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSection : MonoBehaviour
{
    public void Rotate(float eulerAngle)
    {
        transform.Rotate(0f, 0f, eulerAngle);
    }
}
