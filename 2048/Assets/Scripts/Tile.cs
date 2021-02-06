using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    public bool mergedThisTurn = false;

    public int indRow;
    public int indCol;

    public int Number
    {
        get
        {
            return number;
        }
        set
        {
            number = value;
            if (number == 0)
                SetEmpty();
            else
            {
                ApplyStyle(number);
                SetVisible();
            }
        }
    }

    private Text tileText;
    private Image tileImage;
    public int number;

    void Awake()
    {
        tileText = GetComponentInChildren<Text>();
        tileImage = transform.Find("Cell").GetComponent<Image>();
    }

    void ApplyStyleFromHolder(int index) //indexing styles
    {
        tileText.text = TileStyle.Instance.TilesStyles[index].number.ToString();
        tileText.color = TileStyle.Instance.TilesStyles[index].textColor;
        tileImage.sprite = TileStyle.Instance.TilesStyles[index].tileBackground.sprite;
    }

    void ApplyStyle(int number) //apply styles from array
    {
        switch (number)
        {
            case 2:
                ApplyStyleFromHolder(0);
                break;
            case 4:
                ApplyStyleFromHolder(1);
                break;
            case 8:
                ApplyStyleFromHolder(2);
                break;
            case 16:
                ApplyStyleFromHolder(3);
                break;
            case 32:
                ApplyStyleFromHolder(4);
                break;
            case 64:
                ApplyStyleFromHolder(5);
                break;
            case 128:
                ApplyStyleFromHolder(6);
                break;
            case 256:
                ApplyStyleFromHolder(7);
                break;
            case 512:
                ApplyStyleFromHolder(8);
                break;
            case 1024:
                ApplyStyleFromHolder(9);
                break;
            case 2048:
                ApplyStyleFromHolder(10);
                break;
            case 4096:
                ApplyStyleFromHolder(11);
                break;
            default:
                Debug.LogError("Check ApplyStyle!");
                break;

        }
    }

    private void SetVisible() //tiles enabled
    {
        tileImage.enabled = true;
        tileText.enabled = true;
    }

    private void SetEmpty() //clear tiles holder
    {
        tileImage.enabled = false;
        tileText.enabled = false;
    }

    void Start()
    {

    }


    void Update()
    {

    }
}
