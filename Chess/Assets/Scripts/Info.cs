using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Info : MonoBehaviour
{
    public GameObject startingPosition;
    void Start()
    {
        var p = startingPosition.transform.position;
        transform.position = new Vector3(p.x, p.y + 0.38f, p.z);
    }
}
