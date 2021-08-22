using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bait : MessageListener
{
    public Rigidbody2D Rigidbody2D;
    public float Force;
    public float UpForce = 5;
    protected override void AddMessageListener()
    {
        base.AddMessageListener();

        AddListener(MessageID.Event_OnClick_Press_Food);
    }

    protected override void OnMessage(MessageID msgID, object sender, object data)
    {
        base.OnMessage(msgID, sender, data);

        switch (msgID)
        {
            case MessageID.Event_OnClick_Press_Food:
                {
                    var info = (UIButton_Press_Food.PushType)data;

                    PressFood(info);
                }
                break;
        }
    }

    void PressFood(UIButton_Press_Food.PushType pressType)
    {
        switch (pressType)
        {
            case UIButton_Press_Food.PushType.Left:
                {
                    Rigidbody2D.AddForce(Vector2.left * Force, ForceMode2D.Impulse);
                }
                break;
            case UIButton_Press_Food.PushType.Right:
                {
                    Rigidbody2D.AddForce(Vector2.right * Force, ForceMode2D.Impulse);
                }
                break;
            case UIButton_Press_Food.PushType.UP:
                {
                    Rigidbody2D.AddForce(Vector2.up * Force * UpForce, ForceMode2D.Impulse);
                }
                break;
        }
    }
}
