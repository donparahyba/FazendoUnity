using UnityEngine;

public class Health : MonoBehaviour
{

    public int health = 100;
    public int mana = 50;
    [SerializeField] private int exp = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Aperte para cima ou para baixo.");
    }

    // Update is called once per frame
    void Update()
    {

        if (health == 0)
        {
            Debug.Log("Você morreu :/");
            Time.timeScale = 0;
            return;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            health += 10;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            health -= 10;
        }
    }
}