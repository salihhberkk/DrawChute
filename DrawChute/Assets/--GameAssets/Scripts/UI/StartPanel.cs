public class StartPanel : Panel
{
    public StartPanel()
    {
        panelType = PanelType.Start;
    }
    public void StartGame()
    {
        UIManager.Instance.StartGame();
    }
}
