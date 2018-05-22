using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager singleton;
    public float m_Points;
    public Text m_Counter;

    public List<GameObject> m_Icons;

    public AudioSource m_BaseballHit;
    public AudioSource m_FootballHit;
    public AudioSource m_GolfballHit;
    public AudioSource m_SoccerballHit;
    public AudioSource m_BasketballSwish;

	private void Awake()
	{
        if (singleton != null)
            Destroy(singleton);
        else
            singleton = this;
	}

	private void Start()
	{
		
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
        Vector3 randomPos = new Vector3(Random.Range(-7f,7f), Random.Range(-4f,4f),0);
        GameObject prefab = Instantiate(m_Icons[index], randomPos, Quaternion.identity);
        if (prefab.name.Contains("football"))
            m_FootballHit.Play();
        if (prefab.name.Contains("baseball"))
            m_BaseballHit.Play();
        if (prefab.name.Contains("golfball"))
            m_GolfballHit.Play();
        if (prefab.name.Contains("soccerball"))
            m_SoccerballHit.Play();
        if (prefab.name.Contains("basketball"))
            m_BasketballSwish.Play();
    }

    public Text v_TomBradyPriceText;
    public float v_TomBradyPrice = 10;
    public float v_TomBradyRate = 1;

    public void BuyTomBrady(){
        if(m_Points >= v_TomBradyPrice){
            v_TomBradyPrice += 10;
            v_TomBradyPriceText.text = "Price : " + v_TomBradyPrice;
        }
    }

    public void InvokeEarning(){
        
    }
}
