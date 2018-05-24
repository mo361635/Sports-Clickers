using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager singleton;
    public float m_Points;
    public Text m_Counter;
    public Text OpenCloseShopButton;

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

    public GameObject m_YouWinScreen;
    public GameObject m_TitleScreen;
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
        m_YouWinScreen.SetActive(false);
	}

	private void Start()
	{
        StartCoroutine(EarnPoints());
	}

	private void Update()
	{
        m_Counter.text = "points : " + m_Points;
        if(m_Points >= 100){
            m_YouWinScreen.SetActive(true);
        }
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
		
	public Text v_DakPrescottPriceText;
	public Text v_DakPrescottLevelText;
	public float v_DakPrescottLevel;
	public float v_DakPrescottPrice = 10;
	public int v_DakPrescottRate = 0;

	public void BuyDakPrescott(){
		if(m_Points >= v_DakPrescottPrice){
			m_Points -= v_DakPrescottPrice;
			v_DakPrescottPrice += 10;
			v_DakPrescottLevel++;
			v_DakPrescottRate++;
			v_DakPrescottPriceText.text = "Price : " + v_DakPrescottPrice;
			v_DakPrescottLevelText.text = "Level : " + v_DakPrescottLevel;
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

	public Text v_PhilMickelsonPriceText;
	public Text v_PhilMickelsonLevelText;
	public float v_PhilMickelsonLevel;
	public float v_PhilMickelsonPrice = 10;
	public int v_PhilMickelsonRate = 0;

	public void BuyPhilMickelson()
	{
		if (m_Points >= v_PhilMickelsonPrice)
		{
			m_Points -= v_PhilMickelsonPrice;
			v_PhilMickelsonPrice += 10;
			v_PhilMickelsonLevel++;
			v_PhilMickelsonRate++;
			v_PhilMickelsonPriceText.text = "Price : " + v_PhilMickelsonPrice;
			v_PhilMickelsonLevelText.text = "Level : " + v_PhilMickelsonLevel;
		}
	}

    public Text v_JoshHamiltonPriceText;
    public Text v_JoshHamiltonLevelText;
    public float v_JoshHamiltonLevel;
    public float v_JoshHamiltonPrice = 10;
    public int v_JoshHamiltonRate = 0;

    public void BuyJoshHamilton()
    {
        if (m_Points >= v_JoshHamiltonPrice)
        {
            m_Points -= v_JoshHamiltonPrice;
            v_JoshHamiltonPrice += 10;
            v_JoshHamiltonLevel++;
            v_JoshHamiltonRate++;
            v_JoshHamiltonPriceText.text = "Price : " + v_JoshHamiltonPrice;
            v_JoshHamiltonLevelText.text = "Level : " + v_JoshHamiltonLevel;
        }
    }

	public Text v_IchiroSuzukiPriceText;
	public Text v_IchiroSuzukiLevelText;
	public float v_IchiroSuzukiLevel;
	public float v_IchiroSuzukiPrice = 10;
	public int v_IchiroSuzukiRate = 0;

	public void BuyIchiroSuzuki()
	{
		if (m_Points >= v_IchiroSuzukiPrice)
		{
			m_Points -= v_IchiroSuzukiPrice;
			v_IchiroSuzukiPrice += 10;
			v_IchiroSuzukiLevel++;
			v_IchiroSuzukiRate++;
			v_IchiroSuzukiPriceText.text = "Price : " + v_IchiroSuzukiPrice;
			v_IchiroSuzukiLevelText.text = "Level : " + v_IchiroSuzukiLevel;
		}
	}

	public Text v_AlexRodriguezPriceText;
	public Text v_AlexRodriguezLevelText;
	public float v_AlexRodriguezLevel;
	public float v_AlexRodriguezPrice = 10;
	public int v_AlexRodriguezRate = 0;

	public void BuyAlexRodriguez()
	{
		if (m_Points >= v_AlexRodriguezPrice)
		{
			m_Points -= v_AlexRodriguezPrice;
			v_AlexRodriguezPrice += 10;
			v_AlexRodriguezLevel++;
			v_AlexRodriguezRate++;
			v_AlexRodriguezPriceText.text = "Price : " + v_AlexRodriguezPrice;
			v_AlexRodriguezLevelText.text = "Level : " + v_AlexRodriguezLevel;
		}
	}

	public Text v_StephCurryPriceText;
	public Text v_StephCurryLevelText;
	public float v_StephCurryLevel;
	public float v_StephCurryPrice = 10;
	public int v_StephCurryRate = 0;

	public void BuyStephCurry()
	{
		if (m_Points >= v_StephCurryPrice)
		{
			m_Points -= v_StephCurryPrice;
			v_StephCurryPrice += 10;
			v_StephCurryLevel++;
			v_StephCurryRate++;
			v_StephCurryPriceText.text = "Price : " + v_StephCurryPrice;
			v_StephCurryLevelText.text = "Level : " + v_StephCurryLevel;
		}
	}

	public Text v_JamesHardenPriceText;
	public Text v_JamesHardenLevelText;
	public float v_JamesHardenLevel;
	public float v_JamesHardenPrice = 10;
	public int v_JamesHardenRate = 0;

	public void BuyJamesHarden()
	{
		if (m_Points >= v_JamesHardenPrice)
		{
			m_Points -= v_JamesHardenPrice;
			v_JamesHardenPrice += 10;
			v_JamesHardenLevel++;
			v_JamesHardenRate++;
			v_JamesHardenPriceText.text = "Price : " + v_JamesHardenPrice;
			v_JamesHardenLevelText.text = "Level : " + v_JamesHardenLevel;
		}
	}

	public Text v_DirkNowitzskiPriceText;
	public Text v_DirkNowitzskiLevelText;
	public float v_DirkNowitzskiLevel;
	public float v_DirkNowitzskiPrice = 10;
	public int v_DirkNowitzskiRate = 0;

	public void BuyDirkNowitzski()
	{
		if (m_Points >= v_DirkNowitzskiPrice)
		{
			m_Points -= v_DirkNowitzskiPrice;
			v_DirkNowitzskiPrice += 10;
			v_DirkNowitzskiLevel++;
			v_DirkNowitzskiRate++;
			v_DirkNowitzskiPriceText.text = "Price : " + v_DirkNowitzskiPrice;
			v_DirkNowitzskiLevelText.text = "Level : " + v_DirkNowitzskiLevel;
		}
	}

	public Text v_ChristianRonaldoPriceText;
    public Text v_ChristianRonaldoLevelText;
    public float v_ChristianRonaldoLevel;
    public float v_ChristianRonaldoPrice = 10;
    public int v_ChristianRonaldoRate = 0;

    public void BuyChristianRonaldo()
	{
        if (m_Points >= v_ChristianRonaldoPrice)
		{
            m_Points -= v_ChristianRonaldoPrice;
            v_ChristianRonaldoPrice += 10;
            v_ChristianRonaldoLevel++;
            v_ChristianRonaldoRate++;
            v_ChristianRonaldoPriceText.text = "Price : " + v_ChristianRonaldoPrice;
            v_ChristianRonaldoLevelText.text = "Level : " + v_ChristianRonaldoLevel;
		}
	}

    public Text v_LionelMessiPriceText;
    public Text v_LionelMessiLevelText;
    public float v_LionelMessiLevel;
    public float v_LionelMessiPrice = 10;
    public int v_LionelMessiRate = 0;

    public void BuyLionelMessi()
	{
        if (m_Points >= v_LionelMessiPrice)
		{
            m_Points -= v_LionelMessiPrice;
            v_LionelMessiPrice += 10;
            v_LionelMessiLevel++;
            v_LionelMessiRate++;
            v_LionelMessiPriceText.text = "Price : " + v_LionelMessiPrice;
            v_LionelMessiLevelText.text = "Level : " + v_LionelMessiLevel;
		}
	}

    public Text v_NeymarPriceText;
    public Text v_NeymarLevelText;
    public float v_NeymarLevel;
    public float v_NeymarPrice = 10;
    public int v_NeymarRate = 0;

	public void BuyNeymar()
	{
        if (m_Points >= v_NeymarPrice)
		{
            m_Points -= v_NeymarPrice;
            v_NeymarPrice += 10;
            v_NeymarLevel++;
            v_NeymarRate++;
            v_NeymarPriceText.text = "Price : " + v_NeymarPrice;
            v_NeymarLevelText.text = "Level : " + v_NeymarLevel;
		}
	}

    public IEnumerator EarnPoints(){
        while(true){
            float points = 0;
            points += v_TomBradyRate;
			points += v_CamNewtonRate;
            points += v_DakPrescottRate;

            points += v_TigerWoodsRate;
            points += v_JordanSpiethRate;
            points += v_PhilMickelsonRate;

            points += v_DirkNowitzskiRate;
            points += v_JamesHardenRate;
            points += v_StephCurryRate;

            points += v_AlexRodriguezRate;
            points += v_IchiroSuzukiRate;
            points += v_JoshHamiltonRate;

            points += v_ChristianRonaldoRate;
            points += v_LionelMessiRate;
            points += v_NeymarRate;

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
            OpenCloseShopButton.text = "Close";
        }else{
            m_ShopMenu.SetActive(!m_ShopMenu.activeInHierarchy);
            if(m_ShopMenu.activeInHierarchy){
                OpenCloseShopButton.text = "Close";
            }else{
                OpenCloseShopButton.text = "Shop";
            }
        }   
    }

    public void OpenFootballMenu(){
        m_FootballMenu.SetActive(true);
        m_ShopMenu.SetActive(false);
        OpenCloseShopButton.text = "Back";
    }

    public void OpenGolfMenu(){
        m_GolfMenu.SetActive(true);
        m_ShopMenu.SetActive(false);
        OpenCloseShopButton.text = "Back";
    }

    public void OpenBasketballMenu(){
        m_BasketballMenu.SetActive(true);
        m_ShopMenu.SetActive(false);
        OpenCloseShopButton.text = "Back";
    }

    public void OpenSoccerMenu(){
        m_SoccerMenu.SetActive(true);
        m_ShopMenu.SetActive(false);
        OpenCloseShopButton.text = "Back";
    }

    public void OpenBaseballMenu(){
        m_BaseballMenu.SetActive(true);
        m_ShopMenu.SetActive(false);
        OpenCloseShopButton.text = "Back";
    }

    public void Replay(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void StartGame(){
        m_TitleScreen.SetActive(false);
    }
}
