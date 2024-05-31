using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionRestart : MonoBehaviour
{

    BoxCollider2D bc;

    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
    }
    

        void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Colision")) // Reemplaza "Player" con el tag del otro personaje
        {
            RestartGame(); // Llama a la función RestartGame() cuando dos personajes colisionan
        }
        
    }

    void RestartGame()
    {
        // Aquí puedes agregar cualquier lógica adicional que desees ejecutar al reiniciar el juego,
        // como mostrar una pantalla de Game Over, etc.
        Debug.Log("Los dos personajes han chocado. Reiniciando el juego.");

        // Reinicia la escena actual
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
