using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform kocka;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = kocka.position + offset;
    }
}
