using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class pieceInfo : MonoBehaviour
{
    public GameObject startingPosition;
    //[HideInInspector]
    public GameObject currentPosition;
    public pieceType pieceName;
    void Start()
    {
        currentPosition = startingPosition;

        var p = startingPosition.transform.position;
        transform.position = new Vector3(p.x, p.y + 0.38f, p.z);
    }
}
