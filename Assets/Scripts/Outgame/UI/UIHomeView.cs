using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Outgame
{
    public class UIHomeView : UIStackableView
    {

        [SerializeField] UIEventButton _eventButton;

        protected override void AwakeCall()
        {
            ViewId = ViewID.Home;
            _hasPopUI = true;
        }

        public override void Enter()
        {
            base.Enter();

            UIStatusBar.Show();

            if (EventHelper.GetAllOpenedEvent().Count > 0)
            {
                foreach (var e in EventHelper.GetAllOpenedEvent())
                {
                    if (EventHelper.IsEventOpen(e))
                    {
                        _eventButton.Show();
                        var b = _eventButton.GetComponent<Button>();
                        b.onClick.AddListener(() =>
                        {
                            EventHelper.SetCurrentEventID(e);
                            GoEvent();
                        });
                        break;
                    }
                }
            }

            Debug.Log(EventHelper.GetAllOpenedEvent().Count);
            Debug.Log(EventHelper.IsEventOpen(1));
            Debug.Log(EventHelper.IsEventGamePlayable(1));
        }

        public void GoGacha()
        {
            UIManager.NextView(ViewID.Gacha);
        }

        public void GoCardList()
        {
            UIManager.NextView(ViewID.CardList);
        }

        public void GoEnhance()
        {
            UIManager.NextView(ViewID.Enhance);
        }

        public void GoQuest()
        {
            UIManager.NextView(ViewID.Quest);
        }

        public void GoEvent()
        {

            UIManager.NextView(ViewID.Event);
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
}
