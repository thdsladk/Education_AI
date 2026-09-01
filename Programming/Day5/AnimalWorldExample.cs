using UnityEngine;

public class AnimalWorldExample : MonoBehaviour
{
    // 다형성(폴리모피즘)
    // 많을다 형태형 성질성
    // 하나의 객체가 여러 타입(자료형)을 가질 수 있는 성질
    
    
     private void Start()
    {
        
        for(int i =0; i< animals.Length;i++)
        {
            animals[i].Introduce();
            
            // 동물이 사람 타입일 경우 자기소개후 땅바닥에 앉는다.
            if (animals[i] is Person) // is ; 객체가 실제로 해당 타입인지 검사한 후 그 결과를 bool 반환
            {
                // 1. 명시적 형변환 
                Person person = (Person)animals[i];
                person.SeatDown();
                
                // 2. as 형변환 : 형변환을 시도해서 성공하면 성공 / 실패하면 null 반환
                Person person2 = animals[i] as Person;
                if (person2 != null) // null 인지 아닌지로 사람인지 아닌지로 판단 가능 
                {
                    person2.SeatDown();
                }

            }
        }
    }

     private void Update()
    {
        
    }
}
