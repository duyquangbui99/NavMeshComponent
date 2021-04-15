using UnityEngine;
using UnityEngine.UI;

public class ScoreLive : MonoBehaviour
{
    public static int score = 0;

    public static int live = 10;

    public Text scoreDisplay;
    public Text liveDisplay;


    void Update()
    {
        scoreDisplay.text = "  SCORE: " + score;

        liveDisplay.text = "  LIVE: " + live;

    }
}
