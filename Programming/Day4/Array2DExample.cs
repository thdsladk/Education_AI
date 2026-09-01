using UnityEngine;

public class Array2DExample : MonoBehaviour
{
    private void Start()
    {
        // 2차원 배열 ( 다차원 배열)
        // 게임 개발에서 2차원 배열은 주로 타일 기반 게임에서 
        // 사용 예시 : 
        // 3match 퍼즐 게임, 맵, 인벤토리, 체스
        // 표 형태의 데이터를 표현하는 데 많이 사용
        
        int[,] enemyHealths = new int[2, 3];
        enemyHealths[0, 0] = 31;
        enemyHealths[0, 1] = 28;
        enemyHealths[0, 2] = 54;
        enemyHealths[1, 0] = 13;
        enemyHealths[1, 1] = 63;
        enemyHealths[1, 2] = 85;
        
        Debug.Log(enemyHealths[1,1]);

        for (int col = 0; col < enemyHealths.Length; col++)
        {
            for (int row = 0; row < enemyHealths.Length; row++)
            {
                Debug.Log($"enemyHealths col[{col}][{row}]: {enemyHealths[col, row]}");
            }
        }
    }
    
    // 배열은 행 우선 방식으로 접근해야 된다 
    // 이유는 캐시 히트를 위해서 ( 어떤 메모리에 접근을 하면 그 주위의 메모리들을 캐시 메모리에 저장해 두는데 그 범위에 있는 값을 
    // 접근해야 캐시 히트가 일어나고 다른 메모리를 접근하면 캐시 미스가 발생해서 다시 메모리를 가져오게 되기 때문에 속도가 느려진다. )
    


}
