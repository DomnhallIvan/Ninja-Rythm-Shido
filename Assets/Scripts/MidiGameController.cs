using UnityEngine;
using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Interaction;
using System.Linq;

public class MidiGameController : MonoBehaviour
{
    public GameObject[] lanes;
    public GameObject notePrefab;

    private float noteSpeed = 5.0f;
    private float noteSpawnTimer = 0.0f;
    private float noteSpawnDelay = 1.0f;

    void Start()
    {
        // Carga el archivo MIDI
        MidiFile midiFile = MidiFile.Read("Assets/MIDI/Pantera.mid");

        // Obtiene los eventos de nota del archivo MIDI
        Note[] notes = midiFile.GetNotes().ToArray();

        // Convierte los eventos de nota en notas GameObjects en Unity
        foreach (Note note in notes)
        {
            // Calcula la posición en el tiempo de la nota en segundos
            double noteTime = note.TimeAs<MetricTimeSpan>(midiFile.GetTempoMap()).TotalSeconds;

            // Calcula la lane en la que debe aparecer la nota
            int laneIndex = note.NoteNumber % lanes.Length;

            // Crea una nueva nota GameObject y la posiciona en la lane y en el tiempo correctos
            GameObject newNote = Instantiate(notePrefab, lanes[laneIndex].transform.position + Vector3.up * (float)noteTime * noteSpeed, Quaternion.identity);
            newNote.transform.parent = transform;
        }
    }

    void Update()
    {
        // Actualiza el temporizador de spawn de notas
        noteSpawnTimer += Time.deltaTime;

        // Si el temporizador supera el delay, spawnea una nueva nota
        if (noteSpawnTimer >= noteSpawnDelay)
        {
            SpawnNote();
            noteSpawnTimer = 0.0f;
        }

        // Mueve todas las notas hacia abajo
        foreach (Transform note in transform)
        {
            note.position -= Vector3.up * noteSpeed * Time.deltaTime;
        }
    }

    void SpawnNote()
    {
        // Elige una lane al azar para spawnear la nota
        int laneIndex = Random.Range(0, lanes.Length);
        GameObject lane = lanes[laneIndex];

        // Crea una nueva nota y la posiciona en la lane
        GameObject newNote = Instantiate(notePrefab, lane.transform.position, Quaternion.identity);
        newNote.transform.parent = transform;
    }
}
