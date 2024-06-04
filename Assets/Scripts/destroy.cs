using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{   
    private float m_Time = 0;
    public float lifeSpan = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_Time += Time.deltaTime;
        if(m_Time >= lifeSpan)
        {
            print("Destroying..!"+gameObject);
            Destroy(gameObject);
        }
    }
}
