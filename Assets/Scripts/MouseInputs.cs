using UnityEngine;

public class MouseInputs : MonoBehaviour
{
    void Update()
    {
        // O GetMouseButtonDOWN só retorna durante o frame em que o botão foi apertado
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse 0 - Clique Esquerdo");
            Debug.Log(Input.mousePosition); // Consegue a posição relativa a tela
            Debug.Log("World Point: " + Camera.main.ScreenToWorldPoint(Input.mousePosition)); // Consegue a posição relativa ao jogo
            Debug.Log("Viewport Point: " + Camera.main.ScreenToViewportPoint(Input.mousePosition)); // Consegue a posição relativa ao viewport
        }
        
        //  O GetMouseButton retorna enquanto o botão do mouse está sendo segurado
        if (Input.GetMouseButton(1))
        {
            Debug.Log("Mouse 1 - Clique Direito");
            Debug.Log(Input.mousePosition);
            Debug.Log("World Point: " + Camera.main.ScreenToWorldPoint(Input.mousePosition));
            Debug.Log("Viewport Point: " + Camera.main.ScreenToViewportPoint(Input.mousePosition));
        }

        //  O GetMouseButtonUP retorna no frame em que ele solta o botão segurado
        if (Input.GetMouseButtonUp(2))
        {
            Debug.Log("Mouse 2 - Clique do meio");
            Debug.Log(Input.mousePosition);
            Debug.Log("World Point: " + Camera.main.ScreenToWorldPoint(Input.mousePosition));
            Debug.Log("Viewport Point: " + Camera.main.ScreenToViewportPoint(Input.mousePosition));
        }
    }
}