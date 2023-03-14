using UnityEngine;

public class NoteController : MonoBehaviour
{
    //private GameController gameController;
    public NoteScoreManager noteScoreManager;

    void Start()
    {
        noteScoreManager = GameObject.FindObjectOfType<NoteScoreManager>();
    }

    public void OnTriggerEnter(Collider other)
    {
        // Si la nota colisiona con el jugador, destrúyela
        if (other.CompareTag("PlayerEX"))
        {
            Debug.Log("Entre en colison Excelente");
            noteScoreManager.ChangeExScore(100);
            Destroy(gameObject);
           // gameController.Score();
        }
        else if (other.CompareTag("PlayerG"))
        {
            Debug.Log("Entre en colison good");
            noteScoreManager.ChangeExScore(75);
            Destroy(gameObject);
            // gameController.Score();
        }
        else if (other.CompareTag("PlayerMeh"))
        {
            Debug.Log("Entre en colison meh");
            noteScoreManager.ChangeExScore(50);
            Destroy(gameObject);
            // gameController.Score();
        }
        else if (other.CompareTag("PlayerBd"))
        {
            Debug.Log("Entre en colison  bad");
            noteScoreManager.ChangeExScore(25);
            Destroy(gameObject);
            // gameController.Score();
        }

    }
}
