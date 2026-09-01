using UnityEngine;

public class StringExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string str = "24";
        int Size = 0;
        if (int.TryParse(str, out Size) == true)
        {
            Debug.Log(Size);
        }
        else
        {
            Debug.Log("실패");
        }

        string strWeight = "70.2kg";
        float Weight = 0;
        if (float.TryParse(strWeight, out Weight) == true)
        {
            Debug.Log(Weight);
        }
        else
        {
            Debug.Log("실패");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
