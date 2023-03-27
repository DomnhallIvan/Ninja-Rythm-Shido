using UnityEngine;

public class NoteController : MonoBehaviour
{
    //private GameController gameController;
    public NoteScoreManager noteScoreManager;
    public List_Of_Effects Efectos;


    void Start()
    {
        noteScoreManager = GameObject.FindObjectOfType<NoteScoreManager>();
        Efectos = GameObject.FindObjectOfType<List_Of_Effects>();
    }

    public void OnTriggerEnter(Collider other)
    {
        // Si la nota colisiona con el jugador, destrúyela
        if (other.CompareTag("PlayerEX"))
        {
            Efectos.WomboCombo(1);
            Debug.Log("Entre en colison Excelente");
            noteScoreManager.ChangeExScore(100);
            Destroy(gameObject);
           // gameController.Score();
        }
        else if (other.CompareTag("PlayerG"))
        {
            Efectos.WomboCombo(1);
            Debug.Log("Entre en colison good");
            noteScoreManager.ChangeExScore(75);
            Destroy(gameObject);
            // gameController.Score();
        }
        else if (other.CompareTag("PlayerMeh"))
        {
            Efectos.WomboCombo(1);
            Debug.Log("Entre en colison meh");
            noteScoreManager.ChangeExScore(50);
            Destroy(gameObject);
            // gameController.Score();
        }
        else if (other.CompareTag("PlayerBd"))
        {
            Efectos.WomboCombo(1);
            Debug.Log("Entre en colison  bad");
            noteScoreManager.ChangeExScore(25);
            Destroy(gameObject);
            // gameController.Score();
        }

    }
}
