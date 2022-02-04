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

    public GameOver _gameOverScreen;
    public GameObject _bounce;

    public AudioSource _gameOverSound;
    public AudioClip _gameOverSoundFile;

    public AudioSource _scoreSound;
    public AudioClip _scoreSoundFile;

    public void PlayerScores()
    {
        _playerScore++;
        this._playerScoreText.text = _playerScore.ToString();
        this._ballObject.AddStartingForce();

        if(_playerScore < 3)
        {
            _scoreSound.PlayOneShot(_scoreSoundFile);
        }

        if(_playerScore >= 3)
        {
            GameOver("You");
            _bounce.SetActive(false);
            _gameOverSound.PlayOneShot(_gameOverSoundFile);
        }
        else
        {
            ResetRound();
        }

    }

    public void ComputerScores()
    {
        _computerScore++;
        this._computerScoreText.text = _computerScore.ToString();
        this._ballObject.AddStartingForce();

        if (_computerScore < 3)
        {
            _scoreSound.PlayOneShot(_scoreSoundFile);
        }

        if (_computerScore >= 3)
        {
            GameOver("Opponent");
            _bounce.SetActive(false);
            _gameOverSound.PlayOneShot(_gameOverSoundFile);
        }
        else
        {
            ResetRound();
        }
    }

    public void ResetRound()
    {
        this._ballObject.ResetPosition();
        this._playerPaddle.ResetPosition();
        this._computerPaddle.ResetPosition();
    }

    public void GameOver(string inputWinnerName)
    {
        _gameOverScreen.Setup(inputWinnerName);
    }

}
