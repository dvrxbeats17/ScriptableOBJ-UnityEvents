using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New Game Event", menuName = "Game Event", order = 52)] // 1
public class GameEvent : ScriptableObject // 2
{
    private List<GameEventListener> listeners = new List<GameEventListener>(); // 3

    //public AudioClip swordSound;
    public void Raise() // 4
    {
        for (int i = listeners.Count - 1; i >= 0; i--) // 5
        {
            listeners[i].OnEventRaised(); // 6
            //OnSwordSelected();
        }
    }

    //public void OnSwordSelected()
    //{
    //    GameObject audioObject = new GameObject("Sword Audio");
    //    AudioSource audioSource = audioObject.AddComponent<AudioSource>();
    //    audioSource.clip = swordSound;
    //    audioSource.Play();
    //}
    public void RegisterListener(GameEventListener listener) // 7
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(GameEventListener listener) // 8
    {
        listeners.Remove(listener);
    }
}
