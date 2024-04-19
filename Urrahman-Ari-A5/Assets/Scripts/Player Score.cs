using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public int Pscore = 0;
    public int Escore = 0;
    public TextMeshProUGUI PlayerScoreText;
    public TextMeshProUGUI EnemyScoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player Goal"))
        {
            Escore++;
            EnemyScoreText.text = "" + Escore;
            gameObject.transform.position = new Vector3(0,0,0);
        }
        if (collision.gameObject.CompareTag("Enemy Goal"))
        {
            Pscore++;
            PlayerScoreText.text = "" + Pscore;
            gameObject.transform.position = new Vector3(0, 0, 0);
        }
    }
}
