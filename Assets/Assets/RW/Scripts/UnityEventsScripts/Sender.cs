using UnityEngine;
using UnityEngine.Events;

public class Sender : MonoBehaviour
{
    public static UnityEvent testEvent = new UnityEvent();

    private void Update()
    {
        if (Input.anyKeyDown && testEvent != null)
            testEvent.Invoke();
    }
}
