using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{

    public TextMeshProUGUI scoreCountText;
    public TextMeshProUGUI WinText;
    public int score;

    public void ScoreCount() 
    {
        score++;
        scoreCountText.text = "Score: " + score;
        if (score == GameManagement.instance.collectableSpawner.OrbNum) 
        {
            WinText.text = "You Win";
        }
    }

}
