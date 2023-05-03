/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class BaseCaptureGameMode : MonoBehaviour
{

    public GameObject[] bases;
    public GameObject[] players;
    public Text statusText;
    public float captureTime = 5f;

    private int[] teamScores;
    private bool gameOver = false;

    void Start()
    {
        teamScores = new int[2];
        UpdateScoreText();

        StartCoroutine(CheckForWinner());
    }

    void Update()
    {
        if (!gameOver)
        {
            foreach (GameObject player in players)
            {
                CheckForCapture(player);
            }
        }
    }

    void CheckForCapture(GameObject player)
    {
        Collider[] colliders = Physics.OverlapSphere(player.transform.position, 1f);
        foreach (Collider collider in colliders)
        {
            GameObject obj = collider.gameObject;
            if (obj.CompareTag("Base"))
            {
                BaseCapture baseCapture = obj.GetComponent<BaseCapture>();
                if (baseCapture.Capture(player.tag, captureTime))
                {
                    UpdateScore(player.tag, 1);
                    UpdateScoreText();
                }
            }
        }
    }

    void UpdateScore(string team, int points)
    {
        if (team == "Team1")
        {
            teamScores[0] += points;
        }
        else if (team == "Team2")
        {
            teamScores[1] += points;
        }
    }

    void UpdateScoreText()
    {
        statusText.text = "Team1: " + teamScores[0] + " - Team2: " + teamScores[1];
    }

    IEnumerator CheckForWinner()
    {
        while (true)
        {
            if (teamScores[0] >= 3)
            {
                GameOver("Team1 wins!");
            }
            else if (teamScores[1] >= 3)
            {
                GameOver("Team2 wins!");
            }
            yield return null;
        }
    }

    void GameOver(string message)
    {
        gameOver = true;
        statusText.text = message;
    }

}

*/