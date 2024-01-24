using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public static ScoreText instance;
    [SerializeField] private TextMeshProUGUI CSText;
    public int scoreNum;
    // Start is called before the first frame update

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    private void Start()
    {
        CSText.text = scoreNum.ToString();
    }
    public void UpdateScore()
    {
        scoreNum++;
        CSText.text = scoreNum.ToString();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
