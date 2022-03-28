using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform Target;
    public Vector3 Offset;
    public Vector3 Size;
    public Vector3 Ratio;

    void Update()
    {
        Target.position = transform.position + Offset;
        Target.rotation = transform.rotation;

        Ratio.x = transform.localScale.x / Size.x;
        Ratio.y = transform.localScale.y / Size.y;
        Ratio.z = transform.localScale.z / Size.z;
        Target.localScale = Ratio;
    }
}
