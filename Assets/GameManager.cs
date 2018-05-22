using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager singleton;
    public float m_Points;
    public Text m_Counter;

	private void Awake()
	{
        if (singleton != null)
            Destroy(singleton);
        else
            singleton = this;
	}

	private void Update()
	{
        m_Counter.text = m_Points.ToString();
	}

	public void AddPoint(){
        m_Points++;
    }
}
