using UnityEngine;
using UnityEngine.InputSystem;
public class MouseTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [Header("Target for Aiming")]
    [SerializeField] GameObject controller; 
    void Start()
    {

    }

    void Update()
    {

        if(Keyboard.current.wKey.isPressed)
        {
            RaycastHit hit;
            Vector3 mouse = Mouse.current.position.ReadValue();
            Ray ray = Camera.main.ScreenPointToRay(mouse);
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(mouse);
            Debug.Log(mouse + "(" + mousePos + ") - | " + transform.position);
            Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
            if (Physics.Raycast(ray.origin, ray.direction * 1000, out hit, 99999999))
            {
                print("Found an object - distance: " + hit.distance);
                
            }
                

        }

    }
}
