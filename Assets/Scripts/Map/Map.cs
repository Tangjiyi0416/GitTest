using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public List<MapSection> mapSections = new List<MapSection>();

    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            mapSections.Add(transform.GetChild(i).GetComponent<MapSection>());
        }
    }

    public void Rotate(float eulerAngle)
    {
        transform.Rotate(0f, 0f, eulerAngle);
        //awdwd
    }

    public void Gehh(){
        
    }
}
