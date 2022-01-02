using System.Collections.Generic;
using System.Linq;

public enum PanelType
{
    Start,
    Game,
    Win,
    Lose,
    Draw,
    AdNotReady
}
public class UIManager : MonoSingleton<UIManager>
{
    private List<Panel> allPanels;

    private void Awake()
    {
        allPanels = GetComponentsInChildren<Panel>(true).ToList();
    }

    public void HideAllPanels()
    {
        allPanels.ForEach(panel => panel.gameObject.SetActive(false));
    }
    public void ShowPanel(PanelType type)
    {
        HideAllPanels();
        allPanels.Find(panel => panel.PanelType == type).gameObject.SetActive(true);
    }
    public void HidePanel(PanelType type)
    {
        allPanels.Find(panel => panel.PanelType == type).gameObject.SetActive(false);
    }
    public void StartGame()
    {
        GameManager.Instance.StartGame();
        ShowPanel(PanelType.Game);
    }

    public void RetryLevel()
    {
        LevelManager.Instance.RestartLevel();
    }

    public void LoadNextLevel()
    {
        LevelManager.Instance.LoadNextLevel();
    }
}
