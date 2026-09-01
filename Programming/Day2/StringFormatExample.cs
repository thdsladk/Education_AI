using UnityEngine;

public class StringFormatExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = "강건한";
        int age = 27;
        bool isMan = true;
        // 
        // 1. +연산자를 이용한 문자열 더하기 방식
        Debug.Log("나의 이름은 " + name + "이고 , 나이는 " + age + " 살 입니다. 성별은 " + (isMan ? "남자":"여자") + "입니다. ");
        // 2. 문자열 서식 ( String.Format)을 이용한 방식
        string gender = (isMan ? "남자" : "여자");
        string introduceString = string.Format("나의 이름은 {0}이고, 나이는 {1}살 입니다. 성별은 {2}입니다.", name,age,gender);
        Debug.Log(introduceString);
        // 3. $기호를 이용한 문자열 보간    c# 2017년 부터 지원 6.0부터 지원  
        string introduceString2 = $"나의 이름은 {name}이고, 나이는 {age}살 입니다. 성별은 {gender}입니다.";
        
        int money = 2138094;
        float height = 182.754f;
        Debug.Log(string.Format("{0:F1}",height));
        Debug.Log(string.Format("{0:N0}",height));
        
        Debug.Log($"{height:F1}");
        Debug.Log($"{money:N1}");

        int hour = 3;
        int minute = 13;
        Debug.Log($"{hour:2D}시 {minute:2D}분");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
