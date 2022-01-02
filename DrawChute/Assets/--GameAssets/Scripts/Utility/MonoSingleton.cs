using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    private static volatile T instance;

    private bool isInitialized;

    public static T Instance
    {
        get
        {
            if (instance != null) return instance;
            instance = FindObjectOfType(typeof(T)) as T;
            if (instance != null && !instance.isInitialized) Instance.Initialize();
            return instance;
        }
    }

    protected virtual void Initialize()
    {
        isInitialized = true;
    }
}