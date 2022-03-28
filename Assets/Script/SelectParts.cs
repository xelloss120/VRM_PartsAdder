using UnityEngine;

public class SelectParts : MonoBehaviour
{
    public AddParts AddParts;
    public string SelectJoin = "";

    public void Selected()
    {
        AddParts.SelectCtrl = gameObject;
        AddParts.SelectParts = gameObject.GetComponent<FollowTarget>().Target.gameObject;
        AddParts.SelectJoin = SelectJoin;
    }

    public void Unselected()
    {
        AddParts.SelectParts = null;
    }
}
