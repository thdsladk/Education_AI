using UnityEditor;
using UnityEngine;

public class StringMethodExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //문자열을 문자열만의 여러 가지 속성과 기능을 가지고 있다. 
    // 서식, 길이, 탐색, 변형, 분할 
    
    
    void Start()
    {
        // 길이 속성 
        string Name = "    황금독수리 세상을 놀라게 하다.   ";
        Debug.Log(name.Length);
        
        // 탐색 기능
        int index = Name.IndexOf("놀");
        Debug.Log(index);
        bool isHwang = Name.StartsWith("황");
        Debug.Log(isHwang);
        bool isContainEgle = Name.Contains("독수리");
        Debug.Log(isContainEgle);

        // 변형 기능 : 대소문자 변환 혹은 추가, 대체, 삭제 
        Name = Name.Trim();
        Name = Name.Insert(6, "온");
        Debug.Log(Name);

        Name = Name.Remove(name.IndexOf('.'));
        Name = Name.Replace("새", "세");

        string name2 = "Karina";
        name2 = name2.ToUpper();
        Debug.Log(name2);
        name2 = name2.ToLower();
        Debug.Log(name2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
