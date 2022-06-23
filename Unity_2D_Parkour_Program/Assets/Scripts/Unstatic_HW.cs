
using UnityEngine;

public class Unstatic_HW : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private SphereCollider sc;    
   
    void Start()
    {
        print("相機深度 : " + cam.depth);
        print("球體碰撞器半徑 : " + sc.radius);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
