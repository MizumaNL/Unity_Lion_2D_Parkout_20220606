
using UnityEngine;

public class Unstatic_HW : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private SphereCollider sc;    
   
    void Start()
    {
        print("�۾��`�� : " + cam.depth);
        print("�y��I�����b�| : " + sc.radius);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
