using UnityEngine;

public class SelectParts : MonoBehaviour
{
    public AddParts AddParts;

    public void Selected()
    {
        AddParts.SelectParts = gameObject;
    }
}
