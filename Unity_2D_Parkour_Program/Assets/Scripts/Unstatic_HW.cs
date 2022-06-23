
using UnityEngine;

public class Unstatic_HW : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private SphereCollider sc;
    [SerializeField] private Transform capsule;
    [SerializeField] private Transform sqhere;
    [SerializeField] private Transform cube;
    [SerializeField] private Rigidbody capsule01;

    void Start()
    {
        print("相機深度 : " + cam.depth);
        print("球體碰撞器半徑 : " + sc.radius);

        cam.backgroundColor = Random.ColorHSV();
        capsule.localScale = new Vector3(3, 2, 1);
    }

    // Update is called once per frame
    void Update()
    {
        cube.RotateAround(sqhere.position, new Vector3(0, 0, 1), 36 * Time.deltaTime);
        if (Input.GetKey(KeyCode.Space))
        {
            capsule01.GetComponent<Rigidbody>().AddForce(0, 10, 0, ForceMode.Impulse);
        }
    }
}
