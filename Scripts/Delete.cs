using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    void Update()
    {
        Destroy(gameObject, 0.5f);
    }
}
