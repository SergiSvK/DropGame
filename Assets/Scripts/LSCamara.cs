using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LSCamara : MonoBehaviour
{

    public Vector2 minPos, maxPos;

    public Transform target;
    
    void Update()
    {
        var position = target.position;
        var xPos = Mathf.Clamp(position.x, minPos.x, maxPos.x);
        
        var yPos = Mathf.Clamp(position.y, minPos.y, maxPos.y);

        var transform1 = transform;
        transform1.position = new Vector3(xPos, yPos, transform1.position.z);

    }
}
