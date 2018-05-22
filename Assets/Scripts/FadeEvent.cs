using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeEvent : MonoBehaviour
{
    public void Deactivate(){
        Destroy(gameObject);
    }
}
