using UnityEngine;

enum DayOfWeek1
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}


public class SwitchCaseExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 분기문 
        //  
        
        // 1번 문제 
        // 변수를 선언하고 요일에 따라 오늘은 X 요일입니다.를 출력해주는 코드 작성 

        DayOfWeek1 Today = DayOfWeek1.Thursday;
        switch (Today)
        {
            case DayOfWeek1.Monday:
            {
                Debug.Log("오늘은 Monday입니다");
                break;
            }
            case DayOfWeek1.Tuesday:
            {
                Debug.Log("오늘은 Tuesday입니다!");
                break;
            }

            case DayOfWeek1.Wednesday:
            {
                Debug.Log("오늘은 Wednesday입니다!");
                break;
            }
            case DayOfWeek1.Thursday:
            {
                Debug.Log("오늘은 Thursday입니다!");
                break;
            }
            case DayOfWeek1.Friday:
            {
                Debug.Log("오늘은 Friday입니다!");
                break;
            }
            case DayOfWeek1.Saturday:
            {
                Debug.Log("오늘은 Saturday입니다!");
                break;
            }
            case DayOfWeek1.Sunday:
            {
                Debug.Log("오늘은 Sunday입니다!");
                break;
            }
            default:
            {
                break;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
