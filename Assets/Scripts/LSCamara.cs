using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LSCamara : MonoBehaviour
{

    public Vector2 minPos, maxPos;

    public Transform target;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void Update()
    {
        var xPos = Mathf.Clamp(target.position.x, minPos.x, maxPos.x);
        
        var yPos = Mathf.Clamp(target.position.y, minPos.y, maxPos.y);

        transform.position = new Vector3(xPos, yPos, transform.position.z);

    }
}
