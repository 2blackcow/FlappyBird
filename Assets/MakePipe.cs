using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timeDiff;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            GameObject newpipe = Instantiate(pipe); // 파이프 생성
            newpipe.transform.position = new Vector3(4, Random.Range(-5.5f,-1.0f), 0);
            timer = 0;
            Destroy(newpipe, 10.0f);
        }
    }
}
