using UnityEngine;

public class WhileExample : MonoBehaviour
{
    void Start()
    {
        // while 반복문은 조건식이 참일 동안만 반복실행되는 반복문
        // for문과 다르게 내부에 조건식만 존재 
        int i = 0;
        while (true)
        {
            if (i > 1000)
            {
                break;
            }
            Debug.Log("안녕하세요.");
            ++i;
        }
        
        // for는 반복하고자 하는 순서가 정해져 있거나 조건이 명확할때 
        // while은 반복하고자 하는 순서가 정해져 있지 않거나 조건이 유동적 일때 
        
    }
    
    void Update()
    {
        
    }
}
