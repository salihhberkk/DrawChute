using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using MoreMountains.NiceVibrations;

public class VibrationManager : MonoBehaviour
{




    public void useSkillVibrate()
    {
        if (GameManager.Instance.hapticOn == 0)
            return;
        MMVibrationManager.Haptic(HapticTypes.SoftImpact, false, true, this);
    }

    public void crashVibrate()
    {
        if (GameManager.Instance.hapticOn == 0)
            return;
        MMVibrationManager.Haptic(HapticTypes.HeavyImpact, false, true, this);
    }

    public void breakeBlocks()
    {
        if (GameManager.Instance.hapticOn == 0)
            return;
        MMVibrationManager.Haptic(HapticTypes.Warning, false, true, this);
    }



    public void fail()
    {
        if (GameManager.Instance.hapticOn == 0)
            return;
        MMVibrationManager.Haptic(HapticTypes.Failure, false, true, this);
    }



    public void success()
    {
        if (GameManager.Instance.hapticOn == 0)
            return;
        MMVibrationManager.Haptic(HapticTypes.Success, false, true, this);
    }


   





}
