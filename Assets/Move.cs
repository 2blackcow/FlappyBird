using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime; // (-1, 0, 0)
        

    }
}






// 한 프레임당 한 번씩 실행이 된다. 성능에 따라서 달라짐.
// 플레이어의 프레임 보정을 해주기 위해서 Time.deltaTime을 제공
// = 지난 프레임이 완료되는 데까지 걸린 시간