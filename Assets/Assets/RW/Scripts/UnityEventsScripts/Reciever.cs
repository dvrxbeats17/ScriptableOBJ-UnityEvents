using UnityEngine;

public class Reciever : MonoBehaviour
{
    [SerializeField] private Color _targetColor;
    private Renderer _renderer;
    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        OnEnabled();
    }
    public void Recolor()
    {
        _renderer.material.color = _targetColor;
    }

    private void OnEnabled()
    {
        Sender.testEvent.AddListener(Recolor);
    }

    private void OnDisable()
    {
        Sender.testEvent.RemoveListener(Recolor);
    }
}
