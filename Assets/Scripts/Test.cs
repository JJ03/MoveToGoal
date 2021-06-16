using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int num; 
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CreateClass();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CreateStruct();
        }
    }

    private void CreateClass()
    {
        Debug.Log("CreateClass");
        for (int i = 0; i < num; i++)
        {
            var cls = new SomeClass();
            cls.name = i;
        }
    }
    
    private void CreateStruct()
    {
        Debug.Log("CreateStruct");
        for (int i = 0; i < num; i++)
        {
            var cls = new SomeStruct();
            cls.name = i;
        }
    }

    public class SomeClass
    {
        public int name;
    }
    
    public struct SomeStruct
    {
        public int name;
    }
}
