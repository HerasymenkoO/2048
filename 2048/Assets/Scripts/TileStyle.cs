using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class TileStyles
{
    public int number;
    public Image tileBackground;
    public Color32 textColor;
}

public class TileStyle : MonoBehaviour
{
    public static TileStyle Instance;

    public TileStyles[] TilesStyles;
    void Awake()
    {
        Instance = this;
    }
}
