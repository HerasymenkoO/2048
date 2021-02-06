using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Move //Move directions
{
    Right, Left, Up, Down
}
public class InputManager : MonoBehaviour
{

    private GameManager gameManager;

    void Awake()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }


    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) //Right move
        {
            gameManager.MoveDirections(Move.Right);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow)) //Left move
        {
            gameManager.MoveDirections(Move.Left);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow)) //Up move
        {
            gameManager.MoveDirections(Move.Up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) //Down move
        {
            gameManager.MoveDirections(Move.Down);
        }
    }
}
