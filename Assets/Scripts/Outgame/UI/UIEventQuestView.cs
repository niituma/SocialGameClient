using Cysharp.Threading.Tasks;
using Outgame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Outgame
{
    public class UIEventQuestView : UIStackableView
    {
        [SerializeField] EventQuestListView _listView;

        protected override void AwakeCall()
        {
            ViewId = ViewID.EventQuest;
            _hasPopUI = false;
        }

        private async void Start()
        {
            await QuestListModel.LoadAsync();

            _listView.Setup();
            _listView.SetReadyCallback(Ready);
            Active();
        }

        void Ready(int questId)
        {
            SequenceBridge.RegisterSequence("EventQuest", SequencePackage.Create<QuestPackage>(UniTask.RunOnThreadPool(async () =>
            {
                var start = await GameAPI.API.QuestStart(questId);
                //�{���̓C���Q�[���ɍs��
                //�������Ă��Ƃɂ���
                var result = await GameAPI.API.QuestResult(1);

                //�A�C�e���t�^


                //�p�b�P�[�W
                var package = SequenceBridge.GetSequencePackage<QuestPackage>("EventQuest");
                package.QuestResult = result;

                //���U���g��
                UniTask.Post(GoResult);
            })));
        }

        void GoResult()
        {
            UIManager.NextView(ViewID.EventQuestResult);
        }

        public void GoEventHome()
        {
            UIManager.NextView(ViewID.Event);
        }

        public void Back()
        {
            UIManager.Back();
        }
    }
}