using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PeterWainwright/MainManger")]
public class MainManager : ScriptableObjectSingleton<MainManager>
{
    [SerializeField]
    private GameSettings _gameSettings;
    public static GameSettings GameSettings { get { return Instance._gameSettings; } }
    //private SpeedManager _speedManager;
    //public static SpeedManager SpeedManager { get { return Instance._speedManager; } }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void FirstInitialize()
    {
        Debug.Log("This message will output before Awake");
    }
}
