using UnityEngine;

public class Walking : MonoBehaviour
{
    [SerializeField] private float speed = 2f; // velocidade
    private Rigidbody2D body; // provem fisica
    private Vector2 axisMovement; // vetor de duas dimensoes

    void Start()
    {
        body = GetComponent<Rigidbody2D>(); // Pega o componente do objeto atrelado ao script
    }

    void Update()
    {
        // Atualiza os valores de axisMovement com os inputs do jogador. Input.GetAxisRaw retorna -1, 0 ou 1 dependendo da entrada
        axisMovement.x = Input.GetAxisRaw("Horizontal");
        axisMovement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        // FixedUpdate é chamado em intervalos constantes, independente da taxa de quadros do jogo. É mais adequado para transformações físicas.
        Move();
    }

    private void Move()
    {
        // Aplica a movimentação ao Rigidbody2D, normalizando o vetor de movimento para garantir uma velocidade constante em todas as direções.
        body.linearVelocity = axisMovement.normalized * speed;
        CheckForFlipping();
    }

    private void CheckForFlipping()
    {
        // Verifica em qual direção se move e flipa a escala dependendo do movimento.
        bool movingLeft = axisMovement.x < 0;
        bool movingRight = axisMovement.x > 0;

        if (movingLeft)
        {
            transform.localScale = new Vector3(-1f, transform.localScale.y);
        }
        if (movingRight)
        {
            transform.localScale = new Vector3(1f, transform.localScale.y);
        }
    }
}
