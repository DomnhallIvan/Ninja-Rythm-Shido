using UnityEngine;

public class NoteController : MonoBehaviour
{
    //private GameController gameController;

    void Start()
    {
     //   gameController = GameObject.FindObjectOfType<GameController>();
    }

    public void OnTriggerEnter(Collider other)
    {
        // Si la nota colisiona con el jugador, destrúyela
        if (other.CompareTag("Player"))
        {
            Debug.Log("Entre en colison");
            Destroy(gameObject);
           // gameController.Score();
        }
    }
}
