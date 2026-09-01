using UnityEngine;

public class ForExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1. 1부터 1000 까지 짝수만 더한 값
        int Result = 0;
        for (int i = 1; i <= 1000; ++i)
        {
            Result += i;
        }
        Debug.Log(Result);
        
        //2. 구구단 2단 ~9단까지 5단을 제외하고 중첩 반복문을 이용해서 출력 

        for (int i = 2; i < 10; ++i)
        {
            if (i == 5)
            {
                continue;
            }
            for (int j = 1; j < 10; ++j)
            {
                Debug.Log($"{i} * {j} = {i * j}");
            }
        }
        
        
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
