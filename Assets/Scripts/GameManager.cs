using UnityEngine;

public class GameManager
{
    private static GameManager instance;

    private GameManager()
    {
    }

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager();
            }
            return instance;
        }
    }

    public Vector3 is_old_position;
    public bool IndiDrag = true;
    public int RateCount;
    public int PopCount;
    public int BoxIndex;

}