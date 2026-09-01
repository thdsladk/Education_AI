using UnityEngine;

public class Person : Animal
{
    // 속성
     private bool _hasGlasses = false;
     private int _age = 0;

     
     // 생성자
     public Person()
     {
         
     }
     
     public Person(string name,int age,float height,double weight,bool hasGlasses)
     {
         _name = name;
         _age = age;
         _height = height;
         _weight = weight;
         _hasGlasses = hasGlasses;
     }
     
     // 기능
     public override void Introduce()
     {
         Debug.Log($"안녕하세요. 제 이름은 {_name}이고, 나이는 {_age}입니다. 키와 몸무게는 ({_height}cm/{_weight}kg)입니다.");
     }
     

     // 메서드 오버로딩 : 같은 이름의 메서드를 중복하여 여러 개 만드는 것
     // 매개 변수의 갯수나 자료형이 달라야 한다. 
     
     // public          필드 변수는 : Name ( 파스칼 표기 )
     // private         필드 변수는 : _name ( _카멜 표기 )
     //         지역 변수/매개변수는 : name ( 카멜 표기 )
     
     public void SeatDown()
     {
         Debug.Log("땅바닥에 앉는다!");
     }
     public void SeatDown(Chair chair)
     {
         Debug.Log($"{chair.Color}색 의자에 앉는다!");
     }

     public void Punch(Person otherPerson)
     {
         Debug.Log($"{_name}이가 {otherPerson._name}이를 때렸다!");
     }
}
