using UnityEngine;
using UnityEngine.UI;

public class ScoreLive : MonoBehaviour
{
    public static int score = 0;

    public static int live = 10;

    public static int enemylive = 2;

    public Text scoreDisplay;
    public Text liveDisplay;

    public GameObject realBoss;


    void Update()
    {
        scoreDisplay.text = "  SCORE: " + score;

        liveDisplay.text = "  LIVE: " + live;

        if (enemylive == 0)
        {
            realBoss.SetActive(true);
        }


    }
}
