using Outgame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIEventView : UIStackableView
{
    [SerializeField] Button _eventQuestButton;

    protected override void AwakeCall()
    {
        ViewId = ViewID.Event;
        _hasPopUI = true;
    }

    public override void Enter()
    {
        base.Enter();

        UIStatusBar.Show();

        var id = EventHelper.CurrentEventID;

        if (!EventHelper.IsEventGamePlayable(id)) { _eventQuestButton.interactable = false; }

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
        UIManager.NextView(ViewID.EventQuest);
    }

    public void GoEventRanking()
    {
        UIManager.NextView(ViewID.EventRanking);
    }

    public void DialogTest()
    {
        UICommonDialog.OpenOKDialog("�e�X�g", "�e�X�g�_�C�A���O�ł���", Test);
    }

    void Test(int type)
    {
        Debug.Log("here");
    }
}
