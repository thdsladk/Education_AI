using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    
    void Start()
    {
        // 배열 : 같은 자료형의 데이터를 한 그룹으로 묶어서 사용하는 것
        // -> 연관된 데어터들을 모아서 관리하기 위해 사용한다. 
        
        // 배열(변수) 선언
        // 자료형[] 배열명 = new 자료형[크기(개수)]
        //int[] monsterHealths = new int[5];
        int[] monsterHealths = { 1, 2, 3, 4, 5 };
        // -> int 자료형 50개를 담을 수 있는 연속된 메모리 공간이 할당된다. (4바이트)
        // 데이터 공간 하나하나를 보통"Item"이라고 부른다.
        // 그리고 이 아이템에 "접근"할 수 있는 랜덤 엑세스를 제공하는데 이 순서를 

        for (int i = 0; i < monsterHealths.Length; i++)
        {
            Debug.Log($"몬스터 {i}의 체력 : {monsterHealths[i]}");

        }
    }
   
}
