using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.NiceVibrations;

public class Haptic : MonoSingleton<Haptic>
{
    private bool isHapticOn;
    public bool IsHapticOn
    {
        get
        {
            isHapticOn = PlayerPrefs.GetInt("Haptic", 1) == 1;
            return isHapticOn;
        }
        set
        {
            isHapticOn = value;
            PlayerPrefs.SetInt("Haptic", value ? 1 : 0);
        }
    }

    public void HapticOn()
    {
        IsHapticOn = true;
    }

    public void HapticOff()
    {
        IsHapticOn = false;
    }

    public void HapticFeedback(HapticTypes hapticType)
    {
        if (!IsHapticOn) return;
        MMVibrationManager.Haptic(hapticType, false, true, this);
    }
}
