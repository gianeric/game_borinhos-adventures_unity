using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction MoveAction;
    public InputAction MoveActionSecondary;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start!");
        MoveAction.Enable();
        MoveActionSecondary.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        SetMoveAction(MoveAction);
        SetMoveAction(MoveActionSecondary);
    }

    private void SetMoveAction(InputAction Move){
        Vector2 move = Move.ReadValue<Vector2>();
        Vector2 position = (Vector2)transform.position + move * 0.01f;
        transform.position = position;

        Debug.Log("Posição do X: " + position.x + " Posição do Y: " +position.y);
    }
}
