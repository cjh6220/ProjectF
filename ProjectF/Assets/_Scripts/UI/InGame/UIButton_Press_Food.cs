using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButton_Press_Food : UIBaseButton
{
    public PushType _PushType;
    public enum PushType
    {
        Left = 0,
        Right
    }
    protected override void OnClickImpl()
    {
        SendMessage(MessageID.Event_OnClick_Press_Food, _PushType);
    }
}
