using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    private void Start()
    {
        SaveController.Instance.Reset();
    }
}
