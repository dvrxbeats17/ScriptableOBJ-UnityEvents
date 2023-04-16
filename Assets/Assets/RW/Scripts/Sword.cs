﻿using UnityEngine;

public class Sword : MonoBehaviour
{
    [SerializeField]
    private GameEvent OnSwordSelected; // 1

    private void OnMouseDown()
    {
        OnSwordSelected.Raise(); // 2
    }
}
