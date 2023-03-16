using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 positionChange;

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += positionChange;
    }
}
