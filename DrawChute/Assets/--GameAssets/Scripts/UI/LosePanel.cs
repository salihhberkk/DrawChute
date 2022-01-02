using TMPro;
using UnityEngine;
//köþeli parantezli attribute 
public class LosePanel : Panel
{
    [SerializeField] private TextMeshProUGUI levelText;

    public LosePanel()
    {
        panelType = PanelType.Lose;

    }
    private void OnEnable()
    {
        if (levelText != null)
        {
            levelText.text = $"LEVEL {LevelManager.Instance.LevelIndicatorIndex}";
        }
    }

    public void RetryLevel()
    {
        UIManager.Instance.RetryLevel();
    }
}
