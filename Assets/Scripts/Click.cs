﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

    public void Clicker()
	{
        GameManager.singleton.AddPoint();
	}
}
