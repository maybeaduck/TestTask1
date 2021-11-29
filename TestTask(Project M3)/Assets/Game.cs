using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public StaticData StaticData;
    void Awake()
    {
        Injects._staticData = StaticData;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public static class Injects
{
    public static StaticData _staticData;
}


