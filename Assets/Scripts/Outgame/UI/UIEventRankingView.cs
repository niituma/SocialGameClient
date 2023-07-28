using Outgame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIEventRankingView : UIStackableView
{
    protected override void AwakeCall()
    {
        ViewId = ViewID.EventRanking;
        _hasPopUI = true;
    }

    public void GoEventHome()
    {
        UIManager.NextView(ViewID.Event);
    }
}
