using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball _ballObject;

    public Text _computerScoreText;
    public Text _playerScoreText;

    public Paddle _computerPaddle;
    public Paddle _playerPaddle;

    private int _playerScore;
    private int _computerScore;

    public void PlayerScores()
    {
        _playerScore++;
        this._playerScoreText.text = _playerScore.ToString();
        this._ballObject.AddStartingForce();

        ResetRound();
    }

    public void ComputerScores()
    {
        _computerScore++;
        this._computerScoreText.text = _computerScore.ToString();
        this._ballObject.AddStartingForce();

        ResetRound();
    }

    public void ResetRound()
    {
        this._ballObject.ResetPosition();
        this._playerPaddle.ResetPosition();
        this._computerPaddle.ResetPosition();
    }

}
