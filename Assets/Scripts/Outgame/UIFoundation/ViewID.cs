using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outgame
{
    public enum ViewID
    {
        Title = 10,
        NewUser,

        Home = 100,
        Quest,
        QuestResult,
        CardList,
        Enhance,
        GachaResult,

        Gacha = 200,
        GachaEffect = 300,

        CommonDialog = 500,
        CardInfo,

        Event = 10000,
        EventQuest = 10100,
        EventQuestResult = 10200,
        EventRanking = 10300,
    }
}
