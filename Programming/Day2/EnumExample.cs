using UnityEngine;


// Enum : 열거형 
// 열거 : 순서대로 나열하다라는 뜻으로 
// 관련 있는 상수들을 한 줄로 쭉~ 나열해서 묶어놓는(그룹화한) 형태를 열거형 

enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

enum Season
{
    Spring,
    Summer,
    Fall,
    Winter
}
public class EnumExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Season S = Season.Spring;
        if (S == Season.Summer)
        {
            Debug.Log("지금은 여름입니다.");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
