using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MainMenuController : MonoBehaviour
{
    public TextMeshProUGUI uiWinner;
    private void Start()
    {
        SaveController.Instance.Reset();

        string lastWinner = SaveController.Instance.GetLastWinner();

        if(lastWinner != null)
        {
            uiWinner.text = "Ultimo vencedor: " + lastWinner;
        }
        else
        {
            uiWinner.text = "";
        }
    }
}
