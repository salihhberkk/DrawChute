using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GamePanel : Panel
{
    [SerializeField] private GameObject hapticOn;
    [SerializeField] private GameObject hapticOff;

    [SerializeField] private Image progressBar;
    [SerializeField] private TextMeshProUGUI currentLevelText;
    [SerializeField] private TextMeshProUGUI nextLevelText;
    [SerializeField] private GameObject player;

    //private FinishCheck finish;
    public GamePanel()
    {
        panelType = PanelType.Game;
    }
    private void Start()
    {
        if(PlayerPrefs.GetInt("Haptic", 1) == 1)
        {
            hapticOn.SetActive(true);
            hapticOff.SetActive(false);
        }
        else
        {
            hapticOn.SetActive(false);
            hapticOff.SetActive(true);
        }
        
        //finish = FindObjectOfType<FinishCheck>();
    }
    private void OnEnable()
    {
        currentLevelText.text = LevelManager.Instance.LevelIndicatorIndex.ToString();
        nextLevelText.text = (LevelManager.Instance.LevelIndicatorIndex + 1).ToString();
    }
    private void Update()
    {
        //FillBar();
    }
    /*public void FillBar()
    {
        float fill;
        fill = Map(player.transform.position.z, 0, finish.transform.position.z, 0, 1);
        progressBar.fillAmount = fill;
    }*/
    public void RestartLevel()
    {
        UIManager.Instance.RetryLevel();
    }
    float Map(float s, float a1, float a2, float b1, float b2)
    {
        return b1 + (s - a1) * (b2 - b1) / (a2 - a1);
    }
    public void SetHaptic()
    {
        if (hapticOn.gameObject.activeSelf)
        {
            hapticOn.SetActive(false);
            hapticOff.SetActive(true);
            Haptic.Instance.HapticOff();
        }
        else
        {
            hapticOff.SetActive(false);
            hapticOn.SetActive(true);
            Haptic.Instance.HapticOn();
        }
    }
}