using UnityEngine;

public abstract class Animal    // 추상 클래스 ( 추상 메서드를 쓸려면 추상 클래스가 되어야한다. ) 
{
    // 필드
    protected string _name = string.Empty;
    protected float _height = 0f;
    protected double _weight = 0d;
    

    // 메소드
    public Animal(string name, float height, float weight)
    {
        _name = name;
        _height = height;
        _weight = weight;
    }

    public abstract void Introduce(); // 추상 메서드로 만들기 
    
    public void Run()
    {
        Debug.Log($"[{_name} 뛰는중 !] 속도 :  {100 - (_height / _weight)}");
    }
}
