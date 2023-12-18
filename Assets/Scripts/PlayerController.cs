using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        Debug.Log("Update!");
        Debug.Log(transform.position);

        // Obtém a posição atual
        Vector2 position = transform.position;

        // Adiciona 0.01 à posição x
        position.x = position.x + 0.01f;

        // Define a nova posição X
        transform.position = position;
    }
}
