using UnityEngine;

public abstract class Panel : MonoBehaviour
{
    protected PanelType panelType;
    public PanelType PanelType => panelType;
}
