using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
    public int bpm = 0;
    double currentTime = 0d;
    [SerializeField]
    Transform[] noteCreatePoint = null;
    [SerializeField]
    GameObject p_Note = null;
    [SerializeField]
    GameObject createdNote = null;
    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= 60d / bpm)
        {
            GameObject t_note = Instantiate(p_Note, noteCreatePoint[0].position, Quaternion.identity);
            t_note.transform.SetParent(createdNote.transform);
            currentTime -= 60d / bpm;
        }
    }
}
