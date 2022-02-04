using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text _winnerText;
    public string _nextSceneName;

    public void Setup(string inputWinner)
    {
        gameObject.SetActive(true);
        _winnerText.text = inputWinner + " WINS";
    }

    public void StartNextScene()
    {
        SceneManager.LoadScene(_nextSceneName);
    }
}
