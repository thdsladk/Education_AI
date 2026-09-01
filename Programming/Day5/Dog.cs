using UnityEngine;

public class Dog : Animal
{
    // 필드

    

    // 메소드
    public Dog(string name, float height, float weight)
    {
        _name = name;
        _height = height;
        _weight = weight;
    }  
    // ## 쉐도잉 하는것 주의. ( 금지 )  ##
    // 지금 문법은 재정의가 아니라 메서드 쉐도잉(하이딩)하고 있는것이다.  
    // 재정의 문법은 override를 써야한다.
    // 재정의를 하면 가리키는 타입과 상관없이 실제 타입의 메서드를 호출한다.
    //public void Introduce()
    //{
    //    Debug.Log($"멍멍~ 내 이름은 {_name}이다 멍~");
    //}

    public override void Introduce()
    {
        Debug.Log($"멍멍~ 내 이름은 {_name}이다 멍~");
    }
}
