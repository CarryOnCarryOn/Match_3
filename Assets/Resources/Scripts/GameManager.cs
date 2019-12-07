using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject mGrid;
    public int mx = 5;
    public int my = 8;
    private static GameManager _instance;
    public static GameManager instance
    {
        get
        {
            return _instance;
        }

        set
        {
            _instance = value;
        }
    }

    private void Awake()
    {
        _instance = this;
    }
    // Use this for initialization
    void Start()
    {

        for (int i = 0; i < mx; i++)
        {
            for (int j = 0; j < my; j++)
            {
                GameObject box = Instantiate(mGrid);
                box.transform.position = Correct(i, j);
                box.transform.SetParent(transform);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    public Vector3 Correct(int x, int y)
    {
        return new Vector3(transform.position.x - mx / 2f + x, transform.position.y + my / 2f - y, 0);
    }
}

