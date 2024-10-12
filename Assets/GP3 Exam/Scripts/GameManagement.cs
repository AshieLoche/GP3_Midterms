using UnityEngine;

public class GameManagement : MonoBehaviour
{

    public ScoreBoard scoreBoard;
    public CollectableSpawner collectableSpawner;

    public static GameManagement instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        scoreBoard = GetComponent<ScoreBoard>();
        collectableSpawner = GetComponent<CollectableSpawner>();
    }    

}
