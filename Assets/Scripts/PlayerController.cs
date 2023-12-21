using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start!");
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = GetHorizontal();
        float vertical = GetVertical();

        Vector2 position = transform.position;
        position.x = position.x + 0.1f * horizontal;
        position.y = position.y + 0.1f * vertical;
        transform.position = position;
        
        Debug.Log("Posição do X: " + position.x + " Posição do Y: " +position.y);
    }

    private float GetHorizontal(){
        float horizontal = 0.0f;

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            horizontal = -0.1f;
        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            horizontal = 0.1f;
        }

        return horizontal;
    }

    private float GetVertical(){        
        float vertical = 0.0f;

        if (Keyboard.current.downArrowKey.isPressed)
        {
            vertical = -0.1f;
        }
        else if (Keyboard.current.upArrowKey.isPressed)
        {
            vertical = 0.1f;
        }

        return vertical;
    }
}
