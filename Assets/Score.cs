using UnityEngine;

public class Score : MonoBehaviour
{

    public int LocalScore = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerPrefs.HasKey("Score"))
        {
            LocalScore = PlayerPrefs.GetInt("Score");
        }
        else
        {
            PlayerPrefs.SetInt("Score", LocalScore);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
