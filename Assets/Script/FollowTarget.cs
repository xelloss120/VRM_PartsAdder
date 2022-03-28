using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform Target;
    public Vector3 Offset;
    public Vector3 Size;

    Vector3 Scale;
    Vector3 Position;

    void Update()
    {
        Scale.x = transform.localScale.x / Size.x;
        Scale.y = transform.localScale.y / Size.y;
        Scale.z = transform.localScale.z / Size.z;
        Target.localScale = Scale;

        Position.x = Offset.x * Scale.x;
        Position.y = Offset.y * Scale.y;
        Position.z = Offset.z * Scale.z;
        Target.position = transform.position + Position;

        Target.rotation = transform.rotation;
    }
}
