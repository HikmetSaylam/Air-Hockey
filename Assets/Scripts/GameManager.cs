using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoSingleton<GameManager>
{
    [SerializeField] private GameObject playerOneScore, playerTwoScore, pauseMenu, finishMenu, finishMesaj;
    [SerializeField] private int finishScore;
    private int _playerOneGoal;
    private int _playerTwoGoal;
    private string winnerName;

    private void Start()
    {
        UpdateScoreTable();
    }

    public void IncreasePlayerOneGoal()
    {
        _playerOneGoal++;
    }
    
    public void IncreasePlayerTwoGoal()
    {
        _playerTwoGoal++;
    }

    public void UpdateScoreTable()
    {
        playerOneScore.GetComponent<TextMeshProUGUI>().text = _playerTwoGoal.ToString();
        playerTwoScore.GetComponent<TextMeshProUGUI>().text = _playerOneGoal.ToString();
        CheckWinner(_playerOneGoal,_playerTwoGoal);
    }

    public void Quit()
    {
        SceneManager.LoadScene("StartScene");
        Time.timeScale = 1;
    }

    public void Pause()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Continue()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }

    private void CheckWinner(int player1Score, int player2Score)
    {
        if (player1Score < finishScore && player2Score < finishScore)
            return;
        if (player1Score >= finishScore)
        {
            winnerName = "Blue";
        }
        else if (player2Score >= finishScore)
        {
            winnerName = "Red";
        }

        Time.timeScale = 0;
        finishMesaj.GetComponent<TextMeshProUGUI>().text = "The winner is " + winnerName + " !";
        finishMenu.SetActive(true);
    }
}
