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

    public GameObject m_ShopMenu;
    public GameObject m_FootballMenu;
    public GameObject m_GolfMenu;
    public GameObject m_BasketballMenu;
    public GameObject m_SoccerMenu;
    public GameObject m_BaseballMenu;

	private void Awake()
	{
        if (singleton != null)
            Destroy(singleton);
        else
            singleton = this;

        m_ShopMenu.SetActive(false);
        m_FootballMenu.SetActive(false);
        m_GolfMenu.SetActive(false);
        m_BasketballMenu.SetActive(false);
        m_SoccerMenu.SetActive(false);
        m_BaseballMenu.SetActive(false);
	}

	private void Start()
	{
        StartCoroutine(EarnPoints());
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
    public Text v_TomBradyLevelText;
    public float v_TomBradyLevel;
    public float v_TomBradyPrice = 10;
    public int v_TomBradyRate = 0;

    public void BuyTomBrady(){
        if(m_Points >= v_TomBradyPrice){
            m_Points -= v_TomBradyPrice;
            v_TomBradyPrice += 10;
            v_TomBradyLevel++;
            v_TomBradyRate++;
            v_TomBradyPriceText.text = "Price : " + v_TomBradyPrice;
            v_TomBradyLevelText.text = "Level : " + v_TomBradyLevel;
        }
    }
		
	public Text v_CamNewtonPriceText;
	public Text v_CamNewtonLevelText;
	public float v_CamNewtonLevel;
	public float v_CamNewtonPrice = 10;
	public int v_CamNewtonRate = 0;

	public void BuyCamNewton(){
		if(m_Points >= v_CamNewtonPrice){
			m_Points -= v_CamNewtonPrice;
			v_CamNewtonPrice += 10;
			v_CamNewtonLevel++;
			v_CamNewtonRate++;
			v_CamNewtonPriceText.text = "Price : " + v_CamNewtonPrice;
			v_CamNewtonLevelText.text = "Level : " + v_CamNewtonLevel;
		}
	}
    public Text v_TigerWoodsPriceText;
    public Text v_TigerWoodsLevelText;
    public float v_TigerWoodsLevel;
    public float v_TigerWoodsPrice = 10;
    public int v_TigerWoodsRate = 0;

    public void BuyTigerWoods()
    {
        if (m_Points >= v_TigerWoodsPrice)
        {
            m_Points -= v_TigerWoodsPrice;
            v_TigerWoodsPrice += 10;
            v_TigerWoodsLevel++;
            v_TigerWoodsRate++;
            v_TigerWoodsPriceText.text = "Price : " + v_TigerWoodsPrice;
            v_TigerWoodsLevelText.text = "Level : " + v_TigerWoodsLevel;
        }
    }

    public Text v_JordanSpiethPriceText;
    public Text v_JordanSpiethLevelText;
    public float v_JordanSpiethLevel;
    public float v_JordanSpiethPrice = 10;
    public int v_JordanSpiethRate = 0;

    public void BuyJordanSpieth()
    {
        if (m_Points >= v_JordanSpiethPrice)
        {
            m_Points -= v_JordanSpiethPrice;
            v_JordanSpiethPrice += 10;
            v_JordanSpiethLevel++;
            v_JordanSpiethRate++;
            v_JordanSpiethPriceText.text = "Price : " + v_JordanSpiethPrice;
            v_JordanSpiethLevelText.text = "Level : " + v_JordanSpiethLevel;
        }
    }
    public IEnumerator EarnPoints(){
        while(true){
            float points = 0;
            points += v_TomBradyRate;
			points += v_CamNewtonRate;
            points += v_TigerWoodsRate;
            points += v_JordanSpiethRate;
            m_Points += points;
            yield return new WaitForSeconds(1f);
        }
    }

    public void OpenShopMenu(){
        if(m_FootballMenu.activeInHierarchy || m_GolfMenu.activeInHierarchy || m_BasketballMenu.activeInHierarchy || m_SoccerMenu.activeInHierarchy || m_BaseballMenu.activeInHierarchy)
        {
            m_FootballMenu.SetActive(false);
            m_GolfMenu.SetActive(false);
            m_BasketballMenu.SetActive(false);
            m_SoccerMenu.SetActive(false);
            m_BaseballMenu.SetActive(false);
            m_ShopMenu.SetActive(!m_ShopMenu.activeInHierarchy);
        }else{
            m_ShopMenu.SetActive(!m_ShopMenu.activeInHierarchy);
        }   
    }

    public void OpenFootballMenu(){
        m_FootballMenu.SetActive(true);
        m_ShopMenu.SetActive(false);
    }

    public void OpenGolfMenu(){
        m_GolfMenu.SetActive(true);
        m_ShopMenu.SetActive(false);
    }

    public void OpenBasketballMenu(){
        m_BasketballMenu.SetActive(true);
        m_ShopMenu.SetActive(false);
    }

    public void OpenSoccerMenu(){
        m_SoccerMenu.SetActive(true);
        m_ShopMenu.SetActive(false);
    }

    public void OpenBaseballMenu(){
        m_BaseballMenu.SetActive(true);
        m_ShopMenu.SetActive(false);
    }
}
