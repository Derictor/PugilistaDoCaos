using DBDef;
using Thea2.Common;
using Thea2.Server;
using UnityEngine;

namespace GameScript
{
    public class PC_UniqueRecruitment : ScriptBase
    {
        private const string CharacterId = "SUBRACE-PC_HELDEN";
        private const string RecruitedId = "TAG-PC_UNIQUE_RECRUITED";

        [ScriptAttribute(null)]
        public static bool FRA_PC_UniqueRecruitment(AdventureEventData data, LogicResultAction action, AdvNode node)
        {
            var game = GameInstance.Get();
            return IsAvailable(game) &&
                (game.GetPlayers().Count <= 1 || Random.Range(0, 100) < 20);
        }

        [ScriptAttribute(null)]
        public static void FMO_PC_UniqueRecruitment(NOAdventureStatus status, AdventureEventData data,
            LogicModifier modifier, AdvNode node)
        {
            var game = GameInstance.Get();
            lock (game)
            {
                var group = data.GetMainPlayerGroup();
                if (group == null || group.abstractGroup || !IsAvailable(game))
                    return;

                var subrace = Globals.GetInstanceFromDB<Subrace>(CharacterId);
                var character = Character.Instantiate(group, subrace, 1, true);
                if (character == null)
                    return;

                game.sharedAttributes.SetBaseTo(Globals.GetInstanceFromDB<Tag>(RecruitedId), FInt.ONE);
                var change = new AdventureEventDataChange();
                change.GatherReferenceInfo(character);
                change.count = 1;
                change.playerID = group.ownerID;
                data.AddUncollectedAdventureChange(change);
            }
        }

        private static bool IsAvailable(GameInstance game)
        {
            var marker = Globals.GetInstanceFromDB<Tag>(RecruitedId);
            var subrace = Globals.GetInstanceFromDB<Subrace>(CharacterId);
            if (marker == null || subrace == null || game.sharedAttributes.Contains(marker, FInt.ONE))
                return false;

            foreach (var group in game.GetPlayerGroups())
            {
                foreach (var reference in group.characters)
                {
                    var character = reference.Get();
                    if (character != null && character.subrace.Get() == subrace)
                        return false;
                }
            }

            return true;
        }
    }
}
