using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static int bestscore = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = 0; // 씬이 실행 됐을때 누적되지 않고 0으로 초기화
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = score.ToString();
    }
}
