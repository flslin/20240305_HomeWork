using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Target : MonoBehaviour
{
    public Collider2D collider;
    // Update is called once per frame
    void Update()
    {
        if (collider.isTrigger)
        {
            Destroy(collider);
        }
    }
}
