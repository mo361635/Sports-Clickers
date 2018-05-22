using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager singleton;
    public float m_Points;
    public Text m_Counter;

    public List<GameObject> m_Icons;

	private void Awake()
	{
        if (singleton != null)
            Destroy(singleton);
        else
            singleton = this;
	}

	private void Update()
	{
        m_Counter.text = "points : " + m_Points;
	}

	public void AddPoint(){
        m_Points++;
        SpawnRandomIcon();
    }

    public void SpawnRandomIcon(){
        int index = Random.Range(0, m_Icons.Count);
        Vector3 randomPos = new Vector3(0,0,0);
        Instantiate(m_Icons[index], randomPos, Quaternion.identity);
    }
}
