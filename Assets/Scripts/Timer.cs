using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{

    public Color col, defCol;
    public GameObject mCube;
    private Color lastCol;

    void Start()
    {
        lastCol = mCube.GetComponent<Renderer>().material.color;
    }

    void Update()
    {
        if (!mCube.GetComponent<GameCntrl>().lose)
        {
            if (transform.position.x < -6.3f)
                Destroy(gameObject);
            if (transform.position.x < -1.5f)
                GetComponent<Renderer>().material.color = Color.Lerp(GetComponent<Renderer>().material.color, col, Time.deltaTime);
            transform.position -= new Vector3(0.03f, 0, 0);
        }

        if (mCube.GetComponent<Renderer>().material.color != lastCol)
        {
            lastCol = mCube.GetComponent<Renderer>().material.color;
            transform.position = new Vector3(0, transform.position.y, 0);
            GetComponent<Renderer>().material.color = defCol;
        }
    }

    void OnDestroy()
    {
        if (mCube)
            mCube.GetComponent<GameCntrl>().lose = true;
    }
}
