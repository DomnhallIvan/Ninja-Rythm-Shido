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
        // Si la nota colisiona con el jugador, destr�yela
        if (other.CompareTag("PlayerEX"))
        {
            Efectos.DeluxyCombo(1);
            Efectos.NoteStatus.text = "Excelent";
            noteScoreManager.ChangeExScore(100);
            Destroy(gameObject);
           // gameController.Score();
        }
        else if (other.CompareTag("PlayerG"))
        {
            Efectos.DeluxyCombo(1);
            noteScoreManager.ChangeExScore(75);
            Efectos.NoteStatus.text = "Good";
            Destroy(gameObject);
            // gameController.Score();
        }
        else if (other.CompareTag("PlayerMeh"))
        {
            Efectos.DeluxyCombo(1);
            Efectos.NoteStatus.text = "Meh";
            noteScoreManager.ChangeExScore(50);
            Destroy(gameObject);
            // gameController.Score();
        }
        else if (other.CompareTag("PlayerBd"))
        {
            Efectos.DeluxyCombo(1);
            Efectos.NoteStatus.text = "Bruh";
            noteScoreManager.ChangeExScore(25);
            Destroy(gameObject);
            // gameController.Score();
        }

    }
}
