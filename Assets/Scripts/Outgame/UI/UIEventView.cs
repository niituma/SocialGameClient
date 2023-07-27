using Outgame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIEventView : UIStackableView
{
    protected override void AwakeCall()
    {
        ViewId = ViewID.Event;
        _hasPopUI = true;
    }

    public override void Enter()
    {
        base.Enter();

        UIStatusBar.Show();

        Debug.Log(EventHelper.GetAllOpenedEvent());
        Debug.Log(EventHelper.IsEventOpen(1));
        Debug.Log(EventHelper.IsEventGamePlayable(1));
    }

    public void GoHome()
    {
        UIManager.NextView(ViewID.Home);
    }

    public void GoEventQuest()
    {
        
    }

    public void GoEventRanking()
    {
        
    }

    public void DialogTest()
    {
        UICommonDialog.OpenOKDialog("テスト", "テストダイアログですよ", Test);
    }

    void Test(int type)
    {
        Debug.Log("here");
    }
}
