using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
