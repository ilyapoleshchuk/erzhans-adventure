using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    private static GameState instance;
    public int score;
    public bool finish = false;

    private GameState()
    { }

    public static GameState getInstance()
    {
        if (instance == null)
            instance = new GameState();
        return instance;
    }

    public void setScore(int sc)
    {
        score = sc;

    }

    public void setFinish(bool fin)
    {
        finish = fin;

    }

    public int getScore()
    {
        return score;
    }

    public bool getFinish()
    {
        return finish;
    }


}
