using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public StaticData StaticData;
    public UI UI;
    void Awake()
    {
        Injects._staticData = StaticData;
        Injects._ui = UI;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public static class Injects
{
    public static StaticData _staticData;
    public static UI _ui;
}


