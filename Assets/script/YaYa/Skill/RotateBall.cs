using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBall : MonoBehaviour
{
   
    public void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1), 1);
    }
   

}
