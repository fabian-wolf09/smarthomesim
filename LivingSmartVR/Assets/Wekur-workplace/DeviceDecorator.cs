using UnityEngine;

public class DeviceDecorator : MonoBehaviour
{
    [SerializeField] public bool canBePlacedOnWall = false; 
    [SerializeField] public bool canBePlacedOnFloor = false; 
    [SerializeField] public bool canBePlacedOnCeiling = false; 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
