using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakChild : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.transform.CompareTag("Defence")){
            
        }
    }
}
