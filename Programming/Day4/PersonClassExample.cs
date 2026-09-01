using UnityEngine;

public class PersonClassExample : MonoBehaviour
{
    private void Start()
    {
        // 자료형 변수명 = 값
        // 클래스 클래스명 = new 클래스 

        Chair chair1 = new Chair();
        Chair chair2 = new Chair();
        chair2.Color = "푸른색";
        
        Person kim = new Person("김상곤",20,180,90,true);


        kim.Introduce();
        kim.Run();
        kim.SeatDown(chair1);
        
        Person lee = new Person("이상곤",21,174,85,true);

        
        lee.Introduce();
        lee.Run();

        Person park = null; // 메모리 주소를 가리킬 변수만 만들었지 알맹이는 존재 X 
        // null이란 존재하지 않는다는 뜻
        // 객체지향 프로그래밍에서 제임스 고슬링이 땅을 치고 후회하는 문법 중 하나 
        // 가장 빈번하게 오류를 일으키는 문법 
        
    }
}
