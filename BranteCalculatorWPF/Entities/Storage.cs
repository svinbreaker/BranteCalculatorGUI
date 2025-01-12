using BranteCalculator.Entities.Builders;
using BranteCalculator.Entities.Characters;
using BranteCalculator.Entities.Enums;
using BranteCalculator.Entities.Events;
using BranteCalculator.Entities.Stats;
using BranteCalculatorWPF;
using BranteCalculatorWPF.Entities.Stats;
using System.Diagnostics.Metrics;
using System.DirectoryServices.ActiveDirectory;
using System.Net;
using System.Security.Policy;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using BranteCalculatorWPF.Entities;

namespace BranteCalculator.Entities
{
    public class Storage
    {
        private static Storage _instance = new Storage();

        public static Storage Instance => _instance;

        //Lifetime stats
        public static Stat Willpower { get; private set; }
        public static Stat Deaths { get; private set; }

        //Family stats
        public static Stat Reputation { get; private set; }
        public static Stat Wealth { get; private set; }
        public static Stat Unity { get; private set; }

        //Province stats
        public static Stat Order { get; private set; }
        public static Stat WealthOfMagra { get; private set; }

        //Power stats
        public static Stat Power { get; private set; }
        public static Stat Church { get; private set; }

        //Childhood stats
        public static Stat Determination { get; private set; }
        public static Stat Perception { get; private set; }

        //Childhood flags
        public static Flag TheFencingLesson { get; private set; }
        public static Flag NoblemansSacrament { get; private set; }
        public static Flag Insight { get; private set; }
        public static Flag Beyond { get; private set; }

        //Adolescence stats
        public static Stat Nobility { get; private set; }
        public static Stat Ingenuity { get; private set; }
        public static Stat Spirituality { get; private set; }

        //Adolescence flags
        public static Flag GloriasSecret { get; private set; }
        public static Flag StephansDisgrace { get; private set; }
        public static Flag BloodTide { get; private set; }
        public static Flag NathansAdmonition { get; private set; }
        public static Flag MattersOfTheHeart { get; private set; }
        public static Flag RevelationOfTheTree { get; private set; }
        public static Flag SophiaSaved { get; private set; }

        //Youth stats
        public static AdultStat Diplomacy { get; private set; }
        public static AdultStat Valor { get; private set; }
        public static AdultStat Theology { get; private set; }
        public static AdultStat Eloquence { get; private set; }
        public static AdultStat Manipulation { get; private set; }
        public static AdultStat Scheming { get; private set; }

        //Youth flags
        public static Flag PathOfTheLotless { get; private set; }
        public static Flag PathOfThePriest { get; private set; }
        public static Flag PathOfTheNobleman { get; private set; }
        public static Flag TrueDeath { get; private set; }
        public static Flag AylissRescue { get; private set; }
        public static Flag CollapseOfTheLotless { get; private set; }
        public static Flag TheLotlessAtLarge { get; private set; }
        public static Flag BondOfFriendship { get; private set; }
        public static Flag ShieldOfTheNewFaith { get; private set; }
        public static Flag ShieldOfTheOldFaith { get; private set; }
        public static Flag VictoryInTheTournament { get; private set; }

        //Peace time general flags
        public static Flag TheLaTariRitual { get; private set; }
        public static Flag TheFamilyInRuins { get; private set; }
        public static Flag TheFamilyFallsApart { get; private set; }
        public static Flag BrandedByDishonor { get; private set; }
        public static Flag AFamilyOfMeans { get; private set; }
        public static Flag AGloriousBloodline { get; private set; }
        public static Flag EnnobledByTheSword { get; private set; }
        public static Flag FavoredByTheOverseer { get; private set; }
        public static Flag GloriaBrante { get; private set; }
        public static Flag Heir { get; private set; }
        public static Flag HeirOfTheFamily { get; private set; }
        public static Flag MotherRecovers { get; private set; }
        public static Flag FamilyAtPeace { get; private set; }
        public static Flag TommasNewLife { get; private set; }

        //Peace time conspirator flags
        public static Flag ProfitableBusiness { get; private set; }
        public static Flag StashOfGunpowder { get; private set; }
        public static Flag SophiaHasTheGunpowder { get; private set; }
        public static Flag StockpileOfArms { get; private set; }
        public static Flag TheLastStrawsRevolt { get; private set; }
        public static Flag FarewellAdvisor { get; private set; }
        public static Flag FreeMan { get; private set; }
        public static Flag MasterOfAnizotte { get; private set; }
        public static Flag TheFreeCity { get; private set; }
        public static Flag GloryToTheEmpire { get; private set; }

        //Peace time judge flags
        public static Flag ProtectorOfThePeople { get; private set; }
        public static Flag CourtOfHonorBanned { get; private set; }
        public static Flag EvidenceAgainstOtton { get; private set; }
        public static Flag PatronageOfThePowerful { get; private set; }

        public static Flag BrokenChains { get; private set; }
        public static Flag NightOfTheSerpents { get; private set; }
        public static Flag OttonIsSentenced { get; private set; }
        public static Flag OttonFacesTheCourtOfHonor { get; private set; }





        //Peace time inquisitor flags
        public static Flag RightToDefendTheFaith { get; private set; }
        public static Flag CollapseOfTheInquisition { get; private set; }
        public static Flag TheNewFaithPersecuted { get; private set; }
        public static Flag EvidenceAgainstCassius { get; private set; }
        public static Flag TorchOfTheNewFaith { get; private set; }
        public static Flag AllPowerfulUlrich { get; private set; }
        public static Flag CassiusFacesTheTribunal { get; private set; }
        public static Flag CassiusOverthrow { get; private set; }
        public static Flag ShadowOfTheWill { get; private set; }


        //Revolt flags
        public static Flag TheRebel { get; private set; }
        public static Flag TheDefenderOfTheEmpire { get; private set; }
        public static Flag EscapeFromTheCity { get; private set; }
        public static Flag LeadingTheRevolt { get; private set; }
        public static Flag TheFamilyInTheCity { get; private set; }
        public static Flag TheFamilyHasPerished { get; private set; }
        public static Flag TheFamilyIsSaved { get; private set; }
        public static Flag TheFamilyFledFromTheCity { get; private set; }


        public static Flag DarkTimes { get; private set; }
        public static Flag TheAnizotteMassacre { get; private set; }
        public static Flag TheRevoltIsDefeated { get; private set; }
        public static Flag TheSurrenderOfTheRevolt { get; private set; }
        public static Flag TheCityIsDefended { get; private set; }
        public static Flag TheLegionIsDefeated { get; private set; }
        public static Flag APeaceWithTheOverseer { get; private set; }

        //Peace time stats
        public static OccupationStat Career { get; private set; }
        public static OccupationStat Justice { get; private set; }
        public static OccupationStat Inquisition { get; private set; }
        public static OccupationStat Tolerance { get; private set; }
        public static OccupationStat Unrest { get; private set; }
        public static OccupationStat Network { get; private set; }

        //Revolt stats
        public static Stat Revolt { get; private set; }
        public static RevoltStat Troops { get; private set; }
        public static RevoltStat Nobles { get; private set; }
        public static RevoltStat Clergy { get; private set; }
        public static RevoltStat CommonFolk { get; private set; }

        //Characters
        public static Character Gregor { get; private set; }
        public static Character Robert { get; private set; }
        public static Character Lydia { get; private set; }
        public static Character Stephan { get; private set; }
        public static Character Gloria { get; private set; }
        public static Character Nathan { get; private set; }

        public static Character Tommas { get; private set; }
        public static Character Sophia { get; private set; }
        public static Character Octavia { get; private set; }
        public static Character Jeanne { get; private set; }
        public static Character Otton { get; private set; }

        public static Character Aylis { get; private set; }
        public static Character Felipe { get; private set; }

        public static Character ElBorne { get; private set; }
        public static Character Lennart { get; private set; }
        public static Character Ulrich { get; private set; }
        public static Character Egmont { get; private set; }
        public static Character ElVerman { get; private set; }
        public static Character Tempest { get; private set; }
        public static Character Milanidas { get; private set; }
        public static Character Mark { get; private set; }
        public static Character Silvan { get; private set; }
        public static Character Cassius { get; private set; }


        //Some events
        public static Event TheSacrament;
        public static Event TheBoyDownTheStreet;
        public static Event ArrivalInTheCapital;
        public static Event Agony;
        public static Event LastRespects;
        public static Event TheLastNight;
        public static Event TheSecondSacrament;
        public static Event Recruitment;
        public static Event TheWayOfTheSword;
        public static Event AFarewellToTheCapitalNobleman;
        public static Event AFarewellToTheCapitalPriest;
        public static Event AFarewellToTheCapitalLotless;
        public static Event ThePrintedPage;
        public static Event ASleeplessNight;
        public static Event BlastWave;
        public static Event LastPreparations;
        public static Event TheFinalStep;
        public static Event Revelation;
        public static Event ErrorsOfYouth;
        public static Event AChatWithMagistrate;
        public static Event AnInvitationToDinner;
        public static Event TheSearchForEvidence;
        public static Event AConfession;
        public static Event GettingEven;
        public static Event ARealmUnknown;
        public static Event TheCaseOfFatherMark;
        public static Event ARendezvousWithOctavia;
        public static Event FinalPreparations;
        public static Event FamilyMatter;
        public static Event BrothersInMisery;
        public static Event TheFestivalOfSilverTree;
        public static Event ThePatriarchsSermon;
        public static Event TheHardGoodbye;
        public static Event ThreatsAndPromises;
        public static Event ANewDayDawns;
        public static Event TheBattleForAnizotteVar1;
        public static Event TheBattleForAnizotteVar2;
        public static Event TheBattleForAnizotteVar3;
        public static Event TheBattleForAnizotteVar4;

        public List<Character> Characters { get; private set; } = new List<Character>();
        public List<Stat> LifetimeStats { get; private set; } = new List<Stat>();
        public List<Stat> AdultStats { get; private set; } = new List<Stat>();
        public List<Stat> ChildhoodStats { get; private set; } = new List<Stat>();
        public List<Stat> AdolescenceStats { get; private set; } = new List<Stat>();
        public List<Stat> FamilyStats { get; private set; } = new List<Stat>();
        public List<Stat> ProvinceStats { get; private set; } = new List<Stat>();
        public List<Stat> OccupationStats { get; private set; } = new List<Stat>();
        public List<Stat> RevoltStats { get; private set; } = new List<Stat>();
        public List<Flag> Flags { get; set; } = new List<Flag>();
        public List<Event> Events { get; } = new List<Event>();

        public Storage()
        {
            Reset();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            Events.Add(new EventBuilder("EVENTS_GENERAL_THE_END", true)
                    .WithHiddenRequirement(() => Deaths >= 4 || TrueDeath == true || ANewDayDawns.HasPassed || EscapeFromTheCity == true || ShadowOfTheWill == true || GloryToTheEmpire == true)
                    .Build());

            //Childhood events

            Events.Add(new EventBuilder("EVENTS_CHILDHOOD_BIRTH")
                                                                   .WithDecision("EVENTS_CHILDHOOD_BIRTH_DECISION_REACH_OUT_TO_THE_PALM", decision => decision
                                                                                .WithConsequence(() => Perception.Add(1)))
                                                                   .WithDecision("EVENTS_CHILDHOOD_BIRTH_DECISION_REACH_OUT_TO_THE_FIST", decision => decision
                                                                                .WithConsequence(() => Determination.Add(1)))
                                                                   .WithDecision("EVENTS_CHILDHOOD_BIRTH_DECISION_SMILE_AT_THE_SHADOW", decision => decision
                                                                                .WithConsequence(() => Willpower.Add(10)))
                                                                   .Build());

            Events.Add(new EventBuilder("EVENTS_CHILDHOOD_HIDE_AND_SEEK")
                                                                   .WithDecision("EVENTS_CHILDHOOD_HIDE_AND_SEEK_DECISION_CRY_LOUDLY", decision => decision
                                                                                .WithConsequence(() => Willpower.Add(10)))
                                                                   .WithDecision("EVENTS_CHILDHOOD_HIDE_AND_SEEK_DECISION_FIND_YOUR_WAY_HOME", decision => decision
                                                                                .WithConsequence(() => Determination.Add(1)))
                                                                   .WithDecision("EVENTS_CHILDHOOD_HIDE_AND_SEEK_DECISION_SIT_THERE_AND_WAIT", decision => decision
                                                                                .WithConsequence(() => Perception.Add(1)))
                                                                   .Build());

            Events.Add(new EventBuilder("EVENTS_CHILDHOOD_THE_GREAT_DESCENT")
                                                                   .WithDecision("EVENTS_CHILDHOOD_THE_GREAT_DESCENT_DECISION_FINISH_THE_SONG_PROPERLY", decision => decision
                                                                                .WithConsequence(() => Perception.Add(1)))
                                                                   .WithDecision("EVENTS_CHILDHOOD_THE_GREAT_DESCENT_DECISION_SING_THE_LAST_LINE_WRONG", decision => decision
                                                                                .WithConsequence(() => Determination.Add(1)))
                                                                   .Build());

            Events.Add(new EventBuilder("EVENTS_CHILDHOOD_THE_LOT_OF_SUFFERING")
                                                                   .WithDecision("EVENTS_CHILDHOOD_THE_LOT_OF_SUFFERING_DECISION_ACCEPT_YOUR_PUNISHMENT", decision => decision
                                                                                .WithRequirement(() => Willpower >= 0)
                                                                                .WithConsequence(() => Willpower.Add(-5))
                                                                                .WithConsequence(() => Lydia.Set(Status.GRATEFUL))
                                                                                .WithConsequence(() => Stephan.Add(1)))
                                                                   .WithDecision("EVENTS_CHILDHOOD_THE_LOT_OF_SUFFERING_DECISION_DENY_YOUR_GUILT", decision => decision
                                                                                .WithConsequence(() => Determination.Add(1)))
                                                                   .WithDecision("EVENTS_CHILDHOOD_THE_LOT_OF_SUFFERING_DECISION_DEMAND_AN_EXPLANATION", decision => decision
                                                                                .WithConsequence(() => Perception.Add(1)))
                                                                   .Build());

            Events.Add(new EventBuilder("EVENTS_CHILDHOOD_GLORIAS_RHYMES")
                                                                   .WithDecision("EVENTS_CHILDHOOD_GLORIAS_RHYMES_DECISION_COMPLAIN_ABOUT_YOUR_SISTER", decision => decision
                                                                                .WithRequirement(() => Determination >= 2)
                                                                                .WithConsequence(() => Determination.Add(1)))
                                                                   .WithDecision("EVENTS_CHILDHOOD_GLORIAS_RHYMES_DECISION_OFFER_TO_WRITE_RHYMES_WITH_HER", decision => decision
                                                                                .WithRequirement(() => Perception >= 2)
                                                                                .WithConsequence(() => Perception.Add(1)))
                                                                   .WithDecision("EVENTS_CHILDHOOD_GLORIAS_RHYMES_DECISION_COMFORT_YOUR_SISTER", decision => decision
                                                                                .WithRequirement(() => Willpower >= 0)
                                                                                .WithConsequence(() => Willpower.Add(-5))
                                                                                .WithConsequence(() => Gloria.Set(Status.GRATEFUL))
                                                                                .WithConsequence(() => Gloria.Add(1)))
                                                                   .WithDecision("EVENTS_CHILDHOOD_GLORIAS_RHYMES_DECISION_LEAVE_THE_ROOM", decision => decision
                                                                                .WithConsequence(() => Willpower.Add(10)))
                                                                   .Build());

            Events.Add(new EventBuilder("EVENTS_CHILDHOOD_THE_COMING_SACRAMENT")
                                                                   .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                                                                                .WithConsequence(() => Stephan.Add(-1))
                                                                                .WithConsequence(() => Unity.Add(-1)))
                                                                   .Build());

            Events.Add(new EventBuilder("EVENTS_CHILDHOOD_THE_NEWBORNS_CRY")
                                                                   .WithDecision("EVENTS_CHILDHOOD_THE_NEWBORNS_CRY_DECISION_CALL_FATHER_FOR_HELP", decision => decision
                                                                                .WithConsequence(() => Perception.Add(1)))
                                                                   .WithDecision("EVENTS_CHILDHOOD_THE_NEWBORNS_CRY_DECISION_REDIRECT_HER_ANGER_TO_YOURSELF", decision => decision
                                                                                .WithConsequence(() => Determination.Add(1)))
                                                                   .WithDecision("EVENTS_CHILDHOOD_THE_NEWBORNS_CRY_DECISION_SNATCH_NATHAN_FROM_MOTHER", decision => decision
                                                                                .WithRequirement(() => Willpower >= 0)
                                                                                .WithConsequence(() => Willpower.Add(-5))
                                                                                .WithConsequence(() => Nathan.Set(Status.GRATEFUL))
                                                                                .WithConsequence(() => Nathan.Add(1)))
                                                                   .WithDecision("EVENTS_CHILDHOOD_THE_NEWBORNS_CRY_DECISION_HUG_MOTHER", decision => decision
                                                                                .WithRequirement(() => Lydia == Status.GRATEFUL)
                                                                                .WithConsequence(() => Unity.Add(1))
                                                                                .WithConsequence(() => Lydia.Add(1)))
                                                                   .Build());

            Events.Add(new EventBuilder("EVENTS_CHILDHOOD_TOY_SOLDIERS")
                                                                   .WithDecision("EVENTS_CHILDHOOD_TOY_SOLDIERS_DECISION_DENY_YOUR_GUILT", decision => decision
                                                                                .WithConsequence(() => Willpower.Add(10)))
                                                                   .WithDecision("EVENTS_CHILDHOOD_TOY_SOLDIERS_TELL_HIM_THE_TRUTH", decision => decision
                                                                                .WithConsequence(() => Determination.Add(1)))
                                                                   .WithDecision("EVENTS_CHILDHOOD_TOY_SOLDIERS_ADMIT_YOUR_GUILT", decision => decision
                                                                                .WithRequirement(() => Willpower >= 0)
                                                                                .WithConsequence(() => Willpower.Add(-5))
                                                                                .WithConsequence(() => Robert.Set(Status.GRATEFUL))
                                                                                .WithConsequence(() => Robert.Add(1)))
                                                                   .Build());

            Events.Add(new EventBuilder("EVENTS_CHILDHOOD_THE_INTRUSION")
                                                                   .WithDecision("EVENTS_CHILDHOOD_THE_INTRUSION_DECISION_WATCH_THEM_MELT_HELPLESSLY", decision => decision
                                                                                 .WithRequirement(() => Perception >= 4)
                                                                                 .WithConsequence(() => Willpower.Add(5)))
                                                                   .WithDecision("EVENTS_CHILDHOOD_THE_INTRUSION_DECISION_RESCUE_YOUR_TIN_SOLDIERS", decision => decision
                                                                                 .WithRequirement(() => Determination >= 4)
                                                                                 .WithConsequence(() => Determination.Add(1))
                                                                                 .WithConsequence(() => Gregor.Add(1)))
                                                                   .WithDecision("EVENTS_CHILDHOOD_THE_INTRUSION_DECISION_BURST_INTO_TEARS", decision => decision
                                                                                 .WithConsequence(() => Willpower.Add(-5))
                                                                                 .WithConsequence(() => Gregor.Add(-1)))
                                                                   .WithDecision("EVENTS_CHILDHOOD_THE_INTRUSION_DECISION_STRIKE_GRANDFATHER", decision => decision
                                                                                 .WithConsequence(() => Beyond.Check())
                                                                                 .WithConsequence(() => Determination.Add(1))
                                                                                 .WithConsequence(() => Perception.Add(1))
                                                                                 .WithConsequence(() => Deaths.Add(1))
                                                                                 .WithConsequence(() => Gregor.Add(-1)))
                                                                   .Build());

            Events.Add(new EventBuilder("EVENTS_CHILDHOOD_THE_ILLUSTRIOUS_GUEST")
                                                                  .WithDecision("EVENTS_CHILDHOOD_THE_ILLUSTRIOUS_GUEST_DECISION_GREET_THE_BARONESS_POLITELY", decision => decision
                                                                                .WithConsequence(() => Reputation.Add(1))
                                                                                .WithConsequence(() => Unity.Add(-1))
                                                                                .WithConsequence(() => Lydia.Add(-1))
                                                                                .WithConsequence(() => Robert.Add(1))
                                                                                .WithConsequence(() => Gregor.Add(1)))
                                                                  .WithDecision("EVENTS_CHILDHOOD_THE_ILLUSTRIOUS_GUEST_DECISION_WALK_AWAY_WITH_MOTHER", decision => decision
                                                                                .WithConsequence(() => Reputation.Add(-1))
                                                                                .WithConsequence(() => Perception.Add(1))
                                                                                .WithConsequence(() => Robert.Add(-1))
                                                                                .WithConsequence(() => Lydia.Add(1))
                                                                                .WithConsequence(() => Gregor.Add(-1)))
                                                                  .WithDecision("EVENTS_CHILDHOOD_THE_ILLUSTRIOUS_GUEST_DECISION_MAINTAIN_YOUR_COMPOSURE", decision => decision
                                                                                 .WithRequirement(() => Willpower >= 0)
                                                                                 .WithConsequence(() => Willpower.Add(-5)))
                                                                  .WithDecision("EVENTS_CHILDHOOD_THE_ILLUSTRIOUS_GUEST_DECISION_DEMAND_THAT_MOTHER_BE_INTRODUCED", decision => decision
                                                                                 .WithRequirement(() => Perception >= 4 || Robert == Status.GRATEFUL)
                                                                                 .WithConsequence(() => Unity.Add(1))
                                                                                 .WithConsequence(() => Reputation.Add(-1))
                                                                                 .WithConsequence(() => Gregor.Add(-1)))
                                                                  .Build());

            Events.Add(new EventBuilder("EVENTS_CHILDHOOD_THE_KALEIDOSCOPE")
                                                                  .WithDecision("EVENTS_CHILDHOOD_THE_KALEIDOSCOPE_DECISION_TAKE_THE_KALEIDOSCOPE_APART", decision => decision
                                                                                 .WithRequirement(() => Willpower >= 0)
                                                                                 .WithConsequence(() => Perception.Add(1))
                                                                                 .WithConsequence(() => Willpower.Add(-5)))
                                                                  .WithDecision("EVENTS_CHILDHOOD_THE_KALEIDOSCOPE_DECISION_KEEP_LOOKING_THROUGH_THE_KALEIDOSCOPE", decision => decision
                                                                                 .WithConsequence(() => Willpower.Add(10)))
                                                                  .WithDecision("EVENTS_CHILDHOOD_THE_KALEIDOSCOPE_DECISION_RETURN_TO_YOUR_STUDIES", decision => decision
                                                                                 .WithRequirement(() => Willpower >= 0)
                                                                                 .WithConsequence(() => Determination.Add(1))
                                                                                 .WithConsequence(() => Willpower.Add(-5)))
                                                                  .Build());

            Events.Add(new EventBuilder("EVENTS_CHILDHOOD_SWEET_TEMPTATIONS")
                                                                  .WithDecision("EVENTS_CHILDHOOD_SWEET_TEMPTATIONS_DECISION_TELL_THE_TRUTH", decision => decision
                                                                                 .WithRequirement(() => Willpower >= 0)
                                                                                 .WithConsequence(() => Perception.Add(1))
                                                                                 .WithConsequence(() => Willpower.Add(-5))
                                                                                 .WithConsequence(() => Gregor.Add(1)))
                                                                  .WithDecision("EVENTS_CHILDHOOD_SWEET_TEMPTATIONS_DECISION_LIE", decision => decision
                                                                                 .WithConsequence(() => Willpower.Add(5))
                                                                                 .WithConsequence(() => Gloria.Add(-1)))

                                                                  .WithDecision("EVENTS_CHILDHOOD_SWEET_TEMPTATIONS_DECISION_MOCK_GRANDFATHER_ALONG_WITH_YOUR_SISTER", decision => decision
                                                                                 .WithRequirement(() => Gloria == Status.GRATEFUL)
                                                                                 .WithConsequence(() => Determination.Add(1))
                                                                                 .WithConsequence(() => Gloria.Add(1))
                                                                                 .WithConsequence(() => Gregor.Add(-1)))
                                                                  .Build());

            TheSacrament = (new EventBuilder("EVENTS_CHILDHOOD_THE_SACRAMENT")
                                                                  .WithDecision("EVENTS_CHILDHOOD_THE_SACRAMENT_DECISION_ACCEPT_IT", decision => decision
                                                                                 .WithConsequence(() => Perception.Add(1))
                                                                                 .WithConsequence(() => Determination.Add(-1)))
                                                                  .WithDecision("EVENTS_CHILDHOOD_THE_SACRAMENT_DECISION_RAISE_YOUR_HEAD", decision => decision
                                                                                 .WithRequirement(() => Determination >= 4)
                                                                                 .WithConsequence(() => Willpower.Add(5)))
                                                                  .WithDecision("EVENTS_CHILDHOOD_THE_SACRAMENT_DECISION_CATCH_THE_LASH", decision => decision
                                                                                 .WithConsequence(() => Determination.Add(1))
                                                                                 .WithConsequence(() => Perception.Add(-1)))
                                                                  .WithDecision("EVENTS_CHILDHOOD_THE_SACRAMENT_DECISION_KISS_THE_SWORD", decision => decision
                                                                                 .WithRequirement(() => Willpower >= 0)
                                                                                 .WithConsequence(() => NoblemansSacrament.Check())
                                                                                 .WithConsequence(() => Determination.Add(1))
                                                                                 .WithConsequence(() => Perception.Add(-1))
                                                                                 .WithConsequence(() => Willpower.Add(-10))
                                                                                 .WithConsequence(() => Gregor.Add(1)))
                                                                  .Build());
            Events.Add(TheSacrament);

            //Optional childhood events
            Events.Add(new EventBuilder("EVENTS_CHILDHOOD_THE_ANT_FARM", true)
                                                                    .WithRequirement(() => Perception >= 4)
                                                                    .WithHiddenRequirement(() => !TheSacrament.HasPassed)
                                                                    .WithDecision("EVENTS_CHILDHOOD_THE_ANT_FARM_DECISION_KEEP_PLAYING_WITH_MOTHER", decision => decision
                                                                                  .WithConsequence(() => Willpower.Add(5))
                                                                                  .WithConsequence(() => Lydia.Add(1)))
                                                                    .WithDecision("EVENTS_CHILDHOOD_THE_ANT_FARM_DECISION_PLAY_BY_YOURSELF", decision => decision
                                                                                  .WithConsequence(() => Insight.Check())
                                                                                  .WithConsequence(() => Unity.Add(-1))
                                                                                  .WithConsequence(() => Perception.Add(1)))
                                                                    .Build());

            Events.Add(new EventBuilder("EVENTS_CHILDHOOD_FATHERS_SWORD", true)
                                                                   .WithRequirement(() => Determination >= 4)
                                                                   .WithHiddenRequirement(() => !TheSacrament.HasPassed)
                                                                   .WithDecision("EVENTS_CHILDHOOD_FATHERS_SWORD_DECISION_AGREE_WITH_FATHER", decision => decision
                                                                                 .WithConsequence(() => Willpower.Add(5))
                                                                                 .WithConsequence(() => Robert.Add(1)))
                                                                   .WithDecision("EVENTS_CHILDHOOD_FATHERS_SWORD_DECISION_ASK_FATHER_TO_TEACH_YOU_THE_BASICS", decision => decision
                                                                                 .WithConsequence(() => TheFencingLesson.Check())
                                                                                 .WithConsequence(() => Determination.Add(1))
                                                                                 .WithConsequence(() => Willpower.Add(-10)))
                                                                   .Build());

            //Adolescence events
            TheBoyDownTheStreet = (new EventBuilder("EVENTS_ADOLESCENCE_THE_BOY_DOWN_THE_STREET")
    .WithDecision("EVENTS_ADOLESCENCE_THE_BOY_DOWN_THE_STREET_DECISION_COME_AT_TOMMAS_AND_GIVE_HIM_A_BEATING", decision => decision
        .WithConsequence(() => Nobility.Add(1))
        .WithConsequence(() => Tommas.Add(1)))
    .WithDecision("EVENTS_ADOLESCENCE_THE_BOY_DOWN_THE_STREET_DECISION_SAY_YOUR_BROTHER_IS_TO_BLAME", decision => decision
        .WithConsequence(() => Ingenuity.Add(1))
        .WithConsequence(() => Tommas.Add(1)))
    .WithDecision("EVENTS_ADOLESCENCE_THE_BOY_DOWN_THE_STREET_DECISION_SOLVE_THE_MATTER_PEACEFULLY", decision => decision
        .WithConsequence(() => Spirituality.Add(1))
        .WithConsequence(() => Tommas.Add(1)))
    .WithDecision("EVENTS_ADOLESCENCE_THE_BOY_DOWN_THE_STREET_DECISION_LISTEN_TO_YOUR_BROTHER_FIRST", decision => decision
        .WithRequirement(() => Nathan == Status.GRATEFUL)
        .WithConsequence(() => Willpower.Add(10))
        .WithConsequence(() => Unity.Add(1))
        .WithConsequence(() => Tommas.Add(1)))
    .Build());
            Events.Add(TheBoyDownTheStreet);

            Events.Add(new EventBuilder("EVENTS_ADOLESCENCE_RIDERS_ON_THE_ROAD")
                .WithDecision("EVENTS_ADOLESCENCE_RIDERS_ON_THE_ROAD_DECISION_SHIELD_SOPHIA_FROM_THE_HORSES", decision => decision
                    .WithRequirement(() => Willpower >= 0)
                    .WithConsequence(() => Nobility.Add(1))
                    .WithConsequence(() => Ingenuity.Add(1))
                    .WithConsequence(() => Spirituality.Add(1))
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Deaths.Add(1))
                    .WithConsequence(() => Sophia.Add(1))
                    .WithConsequence(() => Sophia.Set(Status.SAVED)))
                .WithDecision("EVENTS_ADOLESCENCE_RIDERS_ON_THE_ROAD_DECISION_STAY_WHERE_YOU_ARE", decision => decision
                    .WithConsequence(() => Sophia.Set(Status.DIED_HER_FIRST_DEATH)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_ADOLESCENCE_SOIL_AND_GUNPOWDER")
                                                                   .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                                                                                .WithConsequence(() => Order.Add(-1))
                                                                                .WithConsequence(() => WealthOfMagra.Add(1)))
                                                                   .Build());

            Events.Add(new EventBuilder("EVENTS_ADOLESCENCE_STEPHANS_ARRIVAL")
                .WithDecision("EVENTS_ADOLESCENCE_STEPHANS_ARRIVAL_DECISION_INSULT_YOUR_BROTHER", decision => decision
                    .WithConsequence(() => Ingenuity.Add(1))
                    .WithConsequence(() => Gloria.Add(1))
                    .WithConsequence(() => Stephan.Add(-1))
                    .WithConsequence(() => Stephan.Set(Status.BAD_BLOOD)))
                .WithDecision("EVENTS_ADOLESCENCE_STEPHANS_ARRIVAL_DECISION_MAKE_SMALL_TALK_OVER_DINNER", decision => decision
                    .WithConsequence(() => Nobility.Add(1))
                    .WithConsequence(() => Gregor.Add(1)))
                .WithDecision("EVENTS_ADOLESCENCE_STEPHANS_ARRIVAL_DECISION_JOIN_GLORIA_IN_HER_PLIGHT", decision => decision
                    .WithConsequence(() => Willpower.Add(10))
                    .WithConsequence(() => Gloria.Add(1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_ADOLESCENCE_A_DROPPED_HANDKERCHIEF")
                .WithDecision("EVENTS_ADOLESCENCE_A_DROPPED_HANDKERCHIEF_DECISION_GIVE_IT_BACK_TO_OCTAVIA", decision => decision
                    .WithRequirement(() => Willpower >= 0)
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Octavia.Set(Status.REMEMBERS_YOU))
                    .WithConsequence(() => MattersOfTheHeart.Check()))
                .WithDecision("EVENTS_ADOLESCENCE_A_DROPPED_HANDKERCHIEF_DECISION_STASH_THE_TROPHY", decision => decision
                    .WithConsequence(() => Willpower.Add(5))
                    .WithConsequence(() => Tommas.Add(1)))
                .WithDecision("EVENTS_ADOLESCENCE_A_DROPPED_HANDKERCHIEF_DECISION_KEEP_IT_AS_A_MEMENTO", decision => decision
                    .WithConsequence(() => Willpower.Add(10)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_ADOLESCENCE_THE_QUORUM_DECREE")
                                                                   .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                                                                                .WithConsequence(() => Power.Add(1)))
                                                                   .Build());


            Events.Add(new EventBuilder("EVENTS_ADOLESCENCE_A_STORM_OF_EXPECTATIONS")
                .WithDecision("EVENTS_ADOLESCENCE_A_STORM_OF_EXPECTATIONS_DECISION_FOCUS_ON_LAW_AND_HISTORY", decision => decision
                    .WithConsequence(() => Nobility.Add(1))
                    .WithConsequence(() => Robert.Add(1)))
                .WithDecision("EVENTS_ADOLESCENCE_A_STORM_OF_EXPECTATIONS_DECISION_GO_HELP_TOMMAS", decision => decision
                    .WithConsequence(() => Ingenuity.Add(1))
                    .WithConsequence(() => Tommas.Add(1)))
                .WithDecision("EVENTS_ADOLESCENCE_A_STORM_OF_EXPECTATIONS_DECISION_STUDY_THEOLOGY", decision => decision
                    .WithConsequence(() => Spirituality.Add(1))
                    .WithConsequence(() => Lydia.Add(1)))
                .WithDecision("EVENTS_ADOLESCENCE_A_STORM_OF_EXPECTATIONS_DECISION_SPEND_A_MOMENT_WITH_NATHAN", decision => decision
                    .WithConsequence(() => Willpower.Add(10))
                    .WithConsequence(() => Nathan.Add(1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_ADOLESCENCE_SONS_OF_THE_NOBILITY")
                .WithDecision("EVENTS_ADOLESCENCE_SONS_OF_THE_NOBILITY_DECISION_CHALLENGE_DIEDERIK_TO_A_FIGHT", decision => decision
                    .WithConsequence(() => Nobility.Add(1))
                    .WithConsequence(() => Tommas.Add(1)))
                .WithDecision("EVENTS_ADOLESCENCE_SONS_OF_THE_NOBILITY_DECISION_TURN_HIM_OVER_TO_THE_TEACHERS", decision => decision
                    .WithConsequence(() => Ingenuity.Add(1))
                    .WithConsequence(() => Tommas.Add(1)))
                .WithDecision("EVENTS_ADOLESCENCE_SONS_OF_THE_NOBILITY_DECISION_ADMONISH_THE_NOBLEMEN_S_SONS", decision => decision
                    .WithConsequence(() => Spirituality.Add(1))
                    .WithConsequence(() => Tommas.Add(1)))
                .WithDecision("EVENTS_ADOLESCENCE_SONS_OF_THE_NOBILITY_DECISION_SHAKE_DIEDERIK_S_HAND", decision => decision
                    .WithRequirement(() => Tommas <= 1)
                    .WithConsequence(() => Reputation.Add(1))
                    .WithConsequence(() => Robert.Add(1))
                    .WithConsequence(() => Tommas.Add(-1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_ADOLESCENCE_THE_SILVER_TREE")
                .WithDecision("EVENTS_ADOLESCENCE_THE_SILVER_TREE_DECISION_FOLLOW_THE_GIRL_INTO_THE_TEMPLE", decision => decision
                    .WithRequirement(() => Willpower >= 0)
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Jeanne.Add(1))
                    .WithConsequence(() => Jeanne.Set(Status.AQUAINTED))
                    .WithConsequence(() => MattersOfTheHeart.Check()))
                .WithDecision("EVENTS_ADOLESCENCE_THE_SILVER_TREE_DECISION_STAY_WITH_THE_RED_HAIRED_PILGRIM", decision => decision
                    .WithConsequence(() => Spirituality.Add(1))
                    .WithConsequence(() => Jeanne.Add(-1)))
                .WithDecision("EVENTS_ADOLESCENCE_THE_SILVER_TREE_DECISION_LEAVE_THEM_AND_APPROACH_THE_TREE", decision => decision
                    .WithConsequence(() => Willpower.Add(10)))
                .WithDecision("EVENTS_ADOLESCENCE_THE_SILVER_TREE_DECISION_GIVE_IN_TO_THE_EPIPHANY", decision => decision
                    .WithRequirement(() => Insight == true)
                    .WithConsequence(() => Spirituality.Add(1))
                    .WithConsequence(() => Jeanne.Set(Status.AQUAINTED))
                    .WithConsequence(() => RevelationOfTheTree.Check()))
                .Build());

            Events.Add(new EventBuilder("EVENTS_ADOLESCENCE_THE_SHADOW_OF_THE_PAST")
                .WithDecision("EVENTS_ADOLESCENCE_THE_SHADOW_OF_THE_PAST_DECISION_ACCEPT_GLORIA_AS_YOUR_SISTER", decision => decision
                    .WithConsequence(() => Gloria.Add(1))
                    .WithConsequence(() => Lydia.Add(1)))
                .WithDecision("EVENTS_ADOLESCENCE_THE_SHADOW_OF_THE_PAST_DECISION_DISTANCE_YOURSELF_FROM_GLORIA", decision => decision
                    .WithRequirement(() => Gloria <= 3)
                    .WithConsequence(() => Nobility.Add(1))
                    .WithConsequence(() => Gloria.Add(-1))
                    .WithConsequence(() => Lydia.Add(-1)))
                .WithDecision("EVENTS_ADOLESCENCE_THE_SHADOW_OF_THE_PAST_DECISION_EVADE_THE_QUESTION", decision => decision
                    .WithConsequence(() => Willpower.Add(5))
                    .WithConsequence(() => Lydia.Add(-1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_ADOLESCENCE_THE_FLASH_AND_THE_FLAME")
                                                                   .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                                                                                .WithConsequence(() => Tommas.Add(1)))
                                                                   .Build());

            Events.Add(new EventBuilder("EVENTS_ADOLESCENCE_THE_NOBLEMANS_LOT")
    .WithDecision("EVENTS_ADOLESCENCE_THE_NOBLEMANS_LOT_DECISION_CHARGE_THE_ATTACKERS", decision => decision
        .WithConsequence(() => Stephan.Add(2))
         .WithConsequence(() => Stephan.Set(null)))
    .WithDecision("EVENTS_ADOLESCENCE_THE_NOBLEMANS_LOT_DECISION_FOLLOW_YOUR_BROTHER_S_ORDERS", decision => decision
        .WithRequirement(() => Willpower >= 0)
        .WithRequirement(() => Stephan != Status.BAD_BLOOD)
        .WithConsequence(() => Nobility.Add(1))
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Stephan.Add(2))
     .WithConsequence(() => Stephan.Set(null)))
    .WithDecision("EVENTS_ADOLESCENCE_THE_NOBLEMANS_LOT_DECISION_CALL_THE_GUARDS", decision => decision
        .WithConsequence(() => Ingenuity.Add(1))
     .WithConsequence(() => Stephan.Set(null)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_ADOLESCENCE_TRIAL_OF_THE_ASSAILANTS")
                .WithDecision("EVENTS_ADOLESCENCE_TRIAL_OF_THE_ASSAILANTS_DECISION_SUPPORT_FATHER", decision => decision
                    .WithConsequence(() => Reputation.Add(1))
                    .WithConsequence(() => Unity.Add(-1))
                    .WithConsequence(() => Robert.Add(1))
                    .WithConsequence(() => Gloria.Add(-1)))
                .WithDecision("EVENTS_ADOLESCENCE_TRIAL_OF_THE_ASSAILANTS_DECISION_LIE_TO_FATHER", decision => decision
                    .WithConsequence(() => Ingenuity.Add(1))
                    .WithConsequence(() => Robert.Add(-2))
                    .WithConsequence(() => Gloria.Add(1))
                    .WithConsequence(() => Gregor.Add(-1)))
                .WithDecision("EVENTS_ADOLESCENCE_TRIAL_OF_THE_ASSAILANTS_DECISION_CONVINCE_FATHER_TO_CHANGE_HIS_MIND", decision => decision
                    .WithRequirement(() => Willpower >= 0)
                    .WithRequirement(() => Robert >= 2)
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Nobility.Add(1))
                    .WithConsequence(() => Spirituality.Add(1))
                    .WithConsequence(() => Reputation.Add(-1))
                    .WithConsequence(() => Unity.Add(1))
                    .WithConsequence(() => Gregor.Add(-1)))
                .Build());

            Agony = (new EventBuilder("EVENTS_ADOLESCENCE_AGONY")
                .WithDecision("EVENTS_ADOLESCENCE_AGONY_DECISION_RUN_AWAY_AND_RESCUE_NATHAN_AND_GLORIA", decision => decision
                    .WithConsequence(() => Spirituality.Add(1))
                    .WithConsequence(() => Ingenuity.Add(1))
                    .WithConsequence(() => Wealth.Add(-1))
                    .WithConsequence(() => Gregor.Set(Status.TRUE_DEATH)))
                .WithDecision("EVENTS_ADOLESCENCE_AGONY_DECISION_STOP_GRANDFATHER", decision => decision
                    .WithRequirement(() => Willpower >= 0)
                    .WithRequirement(() => Gregor <= 2)
                    .WithConsequence(() => Nobility.Add(1))
                    .WithConsequence(() => Ingenuity.Add(1))
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Gregor.Add(-1))
                    .WithConsequence(() => Gregor.Set(Status.TRUE_DEATH)))
                .WithDecision("EVENTS_ADOLESCENCE_AGONY_DECISION_LET_IT_ALL_HAPPEN_AS_GRANDFATHER_WISHES", decision => decision
                    .WithConsequence(() => Nobility.Add(1))
                    .WithConsequence(() => Ingenuity.Add(1))
                    .WithConsequence(() => Spirituality.Add(2))
                    .WithConsequence(() => Deaths.Add(1))
                    .WithConsequence(() => Wealth.Add(-1))
                    .WithConsequence(() => Lydia.Add(-1))
                    .WithConsequence(() => Gregor.Add(1))
                    .WithConsequence(() => Gregor.Set(Status.TRUE_DEATH)))
                .Build());
            Events.Add(Agony);

            LastRespects = (new EventBuilder("EVENTS_ADOLESCENCE_LAST_RESPECTS")
                .WithDecision("EVENTS_ADOLESCENCE_LAST_RESPECTS_DECISION_GIVE_THE_DAGGER_BACK", decision => decision
                    .WithConsequence(() => Willpower.Add(5))
                    .WithConsequence(() => Robert.Add(-1))
                    .WithConsequence(() => Nathan.Add(1)))
                .WithDecision("EVENTS_ADOLESCENCE_LAST_RESPECTS_DECISION_BLEED", decision => decision
                    .WithRequirement(() => NoblemansSacrament == true)
                    .WithConsequence(() => Robert.Add(1))
                    .WithConsequence(() => BloodTide.Check()))
                .WithDecision("EVENTS_ADOLESCENCE_LAST_RESPECTS_DECISION_ASK_FOR_GRANDFATHERS_BLESSING", decision => decision
                    .WithRequirement(() => Nobility >= 6 || Gregor >= 2)
                    .WithConsequence(() => Robert.Add(1))
                    .WithConsequence(() => Stephan.Add(1))
                    .WithConsequence(() => BloodTide.Check()))
                .Build());
            Events.Add(LastRespects);

            Events.Add(new EventBuilder("EVENTS_ADOLESCENCE_THE_FUGITIVE_GIRL")
                .WithDecision("EVENTS_ADOLESCENCE_THE_FUGITIVE_GIRL_DECISION_TRY_TO_STOP_OTTON", decision => decision
                    .WithRequirement(() => Sophia != Status.DIED_HER_FIRST_DEATH)
                    .WithConsequence(() => Sophia.Add(1))
                    .WithConsequence(() => Sophia.Set(Status.TRUSTING))
                    .WithConsequence(() => MattersOfTheHeart.Check()))
                .WithDecision("EVENTS_ADOLESCENCE_THE_FUGITIVE_GIRL_DECISION_BRING_SOPHIA_BACK_TO_OTTON", decision => decision
                    .WithRequirement(() => Sophia == Status.DIED_HER_FIRST_DEATH)
                    .WithConsequence(() => Otton.Add(1))
                    .WithConsequence(() => Sophia.Add(-2))
                    .WithConsequence(() => Sophia.Set(Status.MERCILESS)))
                .WithDecision("EVENTS_ADOLESCENCE_THE_FUGITIVE_GIRL_DECISION_HELP_SOPHIA_FLEE", decision => decision
                    .WithRequirement(() => Ingenuity >= 4)
                    .WithRequirement(() => Willpower >= 0)
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Sophia.Add(1))
                    .WithConsequence(() => Sophia.Set(Status.TRUSTING))
                    .WithConsequence(() => MattersOfTheHeart.Check()))
                .WithDecision("EVENTS_ADOLESCENCE_THE_FUGITIVE_GIRL_DECISION_HIDE_ALONE", decision => decision
                    .WithConsequence(() => Willpower.Add(5))
                    .WithConsequence(() => Sophia.Add(-1))
                    .WithConsequence(() => Sophia.Set(Status.EMBITTERED)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_ADOLESCENCE_THE_BLOODSTAINED_SERMON")
                                                                   .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                                                                                .WithConsequence(() => Church.Add(1))
                                                                                .WithConsequence(() => Order.Add(-1)))
                                                                   .Build());

            TheLastNight = (new EventBuilder("EVENTS_ADOLESCENCE_THE_LAST_NIGHT")
                .WithDecision("EVENTS_ADOLESCENCE_THE_LAST_NIGHT_DECISION_SPEND_THE_TIME_WITH_FATHER", decision => decision
                    .WithRequirement(() => Robert >= 4 || Robert == Status.GRATEFUL)
                    .WithConsequence(() => Nobility.Add(2))
                    .WithConsequence(() => Robert.Add(1)))
                .WithDecision("EVENTS_ADOLESCENCE_THE_LAST_NIGHT_DECISION_SPEND_THE_TIME_WITH_MOTHER", decision => decision
                    .WithRequirement(() => Lydia >= 4 || Lydia == Status.GRATEFUL)
                    .WithConsequence(() => Spirituality.Add(2))
                    .WithConsequence(() => Lydia.Add(1)))
                .WithDecision("EVENTS_ADOLESCENCE_THE_LAST_NIGHT_DECISION_SPEND_THE_TIME_WITH_GLORIA", decision => decision
                    .WithRequirement(() => Gloria >= 4 || Gloria == Status.GRATEFUL)
                    .WithConsequence(() => Ingenuity.Add(2))
                    .WithConsequence(() => Gloria.Add(1)))
                .WithDecision("EVENTS_ADOLESCENCE_THE_LAST_NIGHT_DECISION_SPEND_THE_TIME_WITH_NATHAN", decision => decision
                    .WithConsequence(() => Willpower.Add(10))
                    .WithConsequence(() => Nathan.Add(1)))
                .Build());
            Events.Add(TheLastNight);

            //Optional Adolescence events
            Events.Add(new EventBuilder("EVENTS_ADOLESCENCE_AN_ADULT_QUESTION", true)
                .WithHiddenRequirement(() => !TheLastNight.HasPassed)
                .WithHiddenRequirement(() => !Agony.HasPassed || LastRespects.HasPassed)
    .WithRequirement(() => Spirituality >= 4)
    .WithDecision("EVENTS_ADOLESCENCE_AN_ADULT_QUESTION_DECISION_DISPEL_NATHANS_FEAR", decision => decision
        .WithConsequence(() => Spirituality.Add(1))
        .WithConsequence(() => Nathan.Add(1))
        .WithConsequence(() => NathansAdmonition.Check()))
    .WithDecision("EVENTS_ADOLESCENCE_AN_ADULT_QUESTION_DECISION_CONFIRM_NATHANS_FEAR", decision => decision
        .WithConsequence(() => Ingenuity.Add(1))
        .WithConsequence(() => Nobility.Add(1))
        .WithConsequence(() => NathansAdmonition.Check()))
    .Build());

            Events.Add(new EventBuilder("EVENTS_ADOLESCENCE_FORBIDDEN_LOVE", true)
                .WithHiddenRequirement(() => !TheLastNight.HasPassed)
                .WithHiddenRequirement(() => !Agony.HasPassed || LastRespects.HasPassed)
                .WithRequirement(() => Nobility >= 4)
                .WithDecision("EVENTS_ADOLESCENCE_FORBIDDEN_LOVE_DECISION_REMIND_HIM_WHAT_A_NOBLEMANS_HONOR_MEANS", decision => decision
                    .WithConsequence(() => Nobility.Add(1))
                    .WithConsequence(() => Stephan.Add(1))
                    .WithConsequence(() => StephansDisgrace.Check()))
                .WithDecision("EVENTS_ADOLESCENCE_FORBIDDEN_LOVE_DECISION_AID_STEPHAN_IN_HIS_CAUSE", decision => decision
                    .WithConsequence(() => Spirituality.Add(1))
                    .WithConsequence(() => Ingenuity.Add(1))
                    .WithConsequence(() => StephansDisgrace.Check()))
                .Build());

            Events.Add(new EventBuilder("EVENTS_ADOLESCENCE_THE_POETS", true)
                .WithHiddenRequirement(() => !TheLastNight.HasPassed)
                .WithHiddenRequirement(() => !Agony.HasPassed || LastRespects.HasPassed)
                .WithRequirement(() => Ingenuity >= 4)
                .WithDecision("EVENTS_ADOLESCENCE_THE_POETS_DECISION_CONVINCE_GLORIA_TO_LEAVE_THE_SOCIETY", decision => decision
                    .WithConsequence(() => Nobility.Add(1))
                    .WithConsequence(() => Spirituality.Add(1))
                    .WithConsequence(() => GloriasSecret.Check()))
                .WithDecision("EVENTS_ADOLESCENCE_THE_POETS_DECISION_KEEP_GLORIA_S_SECRET", decision => decision
                    .WithConsequence(() => Ingenuity.Add(1))
                    .WithConsequence(() => Gloria.Add(1))
                    .WithConsequence(() => GloriasSecret.Check()))
                .Build());


            //Youth events
            Events.Add(new EventBuilder("EVENTS_YOUTH_GENERAL_ARRIVAL_IN_THE_CAPITAL")
    .WithDecision("EVENTS_YOUTH_GENERAL_ARRIVAL_IN_THE_CAPITAL_DECISION_MEET_THE_NOBLE_YOUTHS", decision => decision
        .WithConsequence(() => Diplomacy.Add(1))
        .WithConsequence(() => Manipulation.Add(1))
        .WithConsequence(() => Willpower.Add(-5)))
    .WithDecision("EVENTS_YOUTH_GENERAL_ARRIVAL_IN_THE_CAPITAL_DECISION_LISTEN_TO_ARKWRIGHTS_SPEECH", decision => decision
        .WithConsequence(() => Manipulation.Add(1))
        .WithConsequence(() => Eloquence.Add(1))
        .WithConsequence(() => Willpower.Add(-5)))
    .WithDecision("EVENTS_YOUTH_GENERAL_ARRIVAL_IN_THE_CAPITAL_DECISION_VISIT_THE_GREAT_TEMPLE_OF_THE_TWINS", decision => decision
        .WithConsequence(() => Theology.Add(1))
        .WithConsequence(() => Eloquence.Add(1))
        .WithConsequence(() => Willpower.Add(-5)))
    .WithDecision("EVENTS_YOUTH_GENERAL_ARRIVAL_IN_THE_CAPITAL_DECISION_RUN_AFTER_THE_STUDENTS", decision => decision
        .WithConsequence(() => Willpower.Add(10)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_GENERAL_LUKES_SERMON")
                .WithDecision("EVENTS_YOUTH_GENERAL_LUKES_SERMON_DECISION_LISTEN_TO_HIS_COUNCEL", decision => decision
                    .WithConsequence(() => Theology.Add(1)))
                .WithDecision("EVENTS_YOUTH_GENERAL_LUKES_SERMON_DECISION_DEBATE_HIM", decision => decision
                    .WithConsequence(() => Eloquence.Add(1)))
                .WithDecision("EVENTS_YOUTH_GENERAL_LUKES_SERMON_DECISION_RESIST_HIM", decision => decision
                    .WithConsequence(() => Diplomacy.Add(1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_GENERAL_THE_ADVANCE_OF_THE_NEW_FAITH")
                                                               .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                                                                            .WithConsequence(() => Church.Add(2))
                                                                            .WithConsequence(() => Order.Add(-1)))
                                                               .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_GENERAL_THE_CITY_THAT_NEVER_SLEEPS")
                .WithDecision("EVENTS_YOUTH_GENERAL_THE_CITY_THAT_NEVER_SLEEPS_DECISION_GO_TO_THE_DUELING_CLUB", decision => decision
                    .WithConsequence(() => Valor.Add(1)))
                .WithDecision("EVENTS_YOUTH_GENERAL_THE_CITY_THAT_NEVER_SLEEPS_DECISION_GO_TO_THE_SECRET_SALON", decision => decision
                    .WithConsequence(() => Scheming.Add(1)))
                .WithDecision("EVENTS_YOUTH_GENERAL_THE_CITY_THAT_NEVER_SLEEPS_DECISION_GO_TO_THE_MARKIAN_SOCIETY", decision => decision
                    .WithConsequence(() => Theology.Add(1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_GENERAL_THE_CODE_OF_LAWS")
                                                                   .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                                                                                .WithConsequence(() => Power.Add(2)))
                                                                   .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_GENERAL_THE_GIRL_FROM_YOUR_PAST")
                .WithDecision("EVENTS_YOUTH_GENERAL_THE_GIRL_FROM_YOUR_PAST_DECISION_HELP_HER", decision => decision
                    .WithRequirement(() => Sophia != Status.MERCILESS)
                    .WithConsequence(() => Valor.Add(1))
                    .WithConsequence(() => Scheming.Add(1))
                    .WithConsequence(() => Sophia.Add(1)))
                .WithDecision("EVENTS_YOUTH_GENERAL_THE_GIRL_FROM_YOUR_PAST_DECISION_REFUSE", decision => decision
                    .WithConsequence(() => Valor.Add(1))
                    .WithConsequence(() => Diplomacy.Add(1))
                    .WithConsequence(() => Sophia.Add(-1)))
                .WithDecision("EVENTS_YOUTH_GENERAL_THE_GIRL_FROM_YOUR_PAST_DECISION_ASSUAGE_YOUR_GUILT", decision => decision
                    .WithRequirement(() => Sophia == Status.MERCILESS)
                    .WithConsequence(() => Scheming.Add(1))
                    .WithConsequence(() => Manipulation.Add(1))
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Sophia.Add(1))
                    .WithConsequence(() => Sophia.Set(Status.EMBITTERED)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_GENERAL_THE_THREE_LOTS")
                .WithDecision("EVENTS_YOUTH_GENERAL_THE_THREE_LOTS_DECISION_BREAK_THROUGH_THE_CORDON_INTO_THE_COLLEGE", decision => decision
                    .WithRequirement(() => Diplomacy >= 10 || Valor >= 10)
                    .WithConsequence(() => PathOfTheNobleman.Check())
                    .WithHiddenConsequence(() => MainWindow.ViewModel.OccupationStats.RemoveAt(1))
                    .WithHiddenConsequence(() => MainWindow.ViewModel.OccupationStats.RemoveAt(0))
                    .WithHiddenConsequence(() => MainWindow.ViewModel.OccupationStats.Add(Career))
                    .WithHiddenConsequence(() => MainWindow.ViewModel.OccupationStats.Add(Justice)))
                .WithDecision("EVENTS_YOUTH_GENERAL_THE_THREE_LOTS_DECISION_PREACH_YOUR_REVELATION", decision => decision
                    .WithRequirement(() => Eloquence >= 10 || Theology >= 10)
                    .WithConsequence(() => PathOfThePriest.Check())
                    .WithHiddenConsequence(() => MainWindow.ViewModel.OccupationStats.RemoveAt(1))
                    .WithHiddenConsequence(() => MainWindow.ViewModel.OccupationStats.RemoveAt(0))
                    .WithHiddenConsequence(() => MainWindow.ViewModel.OccupationStats.Add(Inquisition))
                    .WithHiddenConsequence(() => MainWindow.ViewModel.OccupationStats.Add(Tolerance)))
                .WithDecision("EVENTS_YOUTH_GENERAL_THE_THREE_LOTS_DECISION_FOLLOW_THE_LOTLESS", decision => decision
                    .WithConsequence(() => PathOfTheLotless.Check())
                    .WithHiddenConsequence(() => MainWindow.ViewModel.OccupationStats.RemoveAt(1))
                    .WithHiddenConsequence(() => MainWindow.ViewModel.OccupationStats.RemoveAt(0))
                    .WithHiddenConsequence(() => MainWindow.ViewModel.OccupationStats.Add(Network))
                    .WithHiddenConsequence(() => MainWindow.ViewModel.OccupationStats.Add(Unrest)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_GENERAL_A_LETTER_FROM_HOME")
                .WithRequirement(() => PathOfTheNobleman == true)
                                                                   .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                                                                                .WithConsequence(() => Stephan.Add(1))
                                                                                .WithConsequence(() => Gloria.Add(-1)))
                                                                   .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_GENERAL_A_LETTER_FROM_HOME")
                .WithRequirement(() => PathOfTheLotless == true)
                                                                   .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                                                                                .WithConsequence(() => Robert.Add(-1))
                                                                                .WithConsequence(() => Stephan.Add(-1))
                                                                                .WithConsequence(() => Gloria.Add(1)))
                                                                   .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_GENERAL_A_LETTER_FROM_HOME")
                .WithRequirement(() => PathOfThePriest == true)
                                                                   .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                                                                                .WithConsequence(() => Lydia.Add(1))
                                                                                .WithConsequence(() => Nathan.Add(1))
                                                                                .WithConsequence(() => Robert.Add(-1)))
                                                                   .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_GENERAL_BONDS_OF_FRIENDSHIP")
                .WithDecision("EVENTS_YOUTH_GENERAL_BONDS_OF_FRIENDSHIP_DECISION_SWEAR_AN_OATH_OF_FRIENDSHIP", decision => decision
                    .WithRequirement(() => PathOfTheNobleman == true)
                    .WithConsequence(() => Tommas.Set(Status.BOUND_BY_FRIENDSHIP))
                    .WithConsequence(() => BondOfFriendship.Check()))
                .WithDecision("EVENTS_YOUTH_GENERAL_BONDS_OF_FRIENDSHIP_DECISION_TAKE_THE_RING", decision => decision
                    .WithRequirement(() => PathOfTheNobleman == false)
                    .WithRequirement(() => Tommas >= 3)
                    .WithConsequence(() => Tommas.Set(Status.BOUND_BY_FRIENDSHIP))
                    .WithConsequence(() => BondOfFriendship.Check()))
                .WithDecision("EVENTS_YOUTH_GENERAL_BONDS_OF_FRIENDSHIP_DECISION_KEEP_THINGS_AS_THEY_ARE", decision => decision
                    .WithConsequence(() => Willpower.Add(5))
                    .WithConsequence(() => Tommas.Set(Status.REMAINED_FRIENDS)))
                .WithDecision("EVENTS_YOUTH_BONDS_OF_FRIENDSHIP_DECISION_END_THE_FRIENDSHIP", decision => decision
                    .WithRequirement(() => PathOfTheNobleman == false)
                    .WithConsequence(() => Tommas.Add(-2))
                    .WithConsequence(() => Tommas.Set(Status.SEVERED_ALL_TIES)))
                .Build());

            //Youth route events
            Events.Add(new EventBuilder("EVENTS_YOUTH_PRIEST_SEARCHING_FOR_THE_TRUTH")
                .WithRequirement(() => PathOfThePriest == true)
                .WithDecision("EVENTS_YOUTH_PRIEST_SEARCHING_FOR_THE_TRUTH_DECISION_REJECT_DOUBT_AND_STRENGTHEN_YOUR_BELIEF", decision => decision
                    .WithRequirement(() => Theology >= 10)
                    .WithConsequence(() => Theology.Add(1))
                    .WithConsequence(() => Manipulation.Add(1))
                    .WithConsequence(() => ShieldOfTheOldFaith.Check()))
                .WithDecision("EVENTS_YOUTH_PRIEST_SEARCHING_FOR_THE_TRUTH_DECISION_SUPPORT_PATRIARCH_LUKE", decision => decision
                    .WithRequirement(() => Willpower >= 0)
                    .WithConsequence(() => Eloquence.Add(1))
                    .WithConsequence(() => Diplomacy.Add(1))
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => ShieldOfTheNewFaith.Check()))
                .WithDecision("EVENTS_YOUTH_PRIEST_SEARCHING_FOR_THE_TRUTH_DECISION_SEEK_COMFORT_IN_PRAYER", decision => decision
                    .WithConsequence(() => Willpower.Add(10)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_LOTLESS_THE_LOTLESS")
                .WithRequirement(() => PathOfTheLotless == true)
                .WithDecision("EVENTS_YOUTH_LOTLESS_THE_LOTLESS_DECISION_PRINT_LEAFLETS", decision => decision
                    .WithRequirement(() => Manipulation >= 10)
                    .WithConsequence(() => Manipulation.Add(1))
                    .WithConsequence(() => Diplomacy.Add(1)))
                .WithDecision("EVENTS_YOUTH_LOTLESS_THE_LOTLESS_DECISION_CONDEMN_THE_NOBLES", decision => decision
                    .WithRequirement(() => Willpower >= 0)
                    .WithConsequence(() => Scheming.Add(1))
                    .WithConsequence(() => Eloquence.Add(1))
                    .WithConsequence(() => Willpower.Add(-5)))
                .WithDecision("EVENTS_YOUTH_LOTLESS_THE_LOTLESS_DECISION_RECRUIT_NEW_MEMBERS", decision => decision
                    .WithConsequence(() => Willpower.Add(10)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_NOBLEMAN_THE_BALL")
                .WithRequirement(() => PathOfTheNobleman == true)
    .WithDecision("EVENTS_YOUTH_NOBLEMAN_THE_BALL_DECISION_RESOLVE_THE_QUARREL", decision => decision
        .WithRequirement(() => Diplomacy >= 10)
        .WithConsequence(() => Manipulation.Add(1))
        .WithConsequence(() => Otton.Add(1)))
    .WithDecision("EVENTS_YOUTH_NOBLEMAN_THE_BALL_DECISION_DRAW_OTTONS_IRE_UPON_YOURSELF", decision => decision
        .WithRequirement(() => Willpower >= 0)
        .WithConsequence(() => Eloquence.Add(1))
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Tommas.Add(1))
        .WithConsequence(() => Otton.Add(-1)))
    .WithDecision("EVENTS_YOUTH_NOBLEMAN_THE_BALL_DECISION_DANCE_WITH_THE_MYSTERIOUS_LADY", decision => decision
        .WithConsequence(() => Willpower.Add(10))
        .WithConsequence(() => Octavia.Set(Status.REMEMBERS_YOU))
        .WithConsequence(() => Octavia.Add(1))
        .WithConsequence(() => Tommas.Add(-1)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_GENERAL_THE_TRIAL_OF_THE_FIFTY")
                                                                   .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                                                                                .WithConsequence(() => Power.Add(-1))
                                                                                .WithConsequence(() => Order.Add(1)))
                                                                   .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_PRIEST_THE_BLACK_BOOK")
                .WithRequirement(() => PathOfThePriest == true)
                .WithDecision("EVENTS_YOUTH_PRIEST_THE_BLACK_BOOK_DECISION_TELL_NO_ONE_ABOUT_AYLIS", decision => decision
                    .WithConsequence(() => Scheming.Add(1))
                    .WithConsequence(() => Jeanne.Set(Status.STEADFAST_IN_FAITH))
                    .WithConsequence(() => Aylis.Set(Status.JOINED_A_TROUPE))
                    .WithConsequence(() => AylissRescue.Check()))
                .WithDecision("EVENTS_YOUTH_PRIEST_THE_BLACK_BOOK_DECISION_INFORM_THE_INQUISITION", decision => decision
                    .WithConsequence(() => Valor.Add(1))
                    .WithConsequence(() => Jeanne.Set(Status.ZEALOUS))
                    .WithConsequence(() => Aylis.Set(Status.TRUE_DEATH)))
                .WithDecision("EVENTS_YOUTH_PRIEST_THE_BLACK_BOOK_DECISION_GUIDE_YOUR_FRIEND_TO_THE_RIGHT_PATH", decision => decision
                    .WithRequirement(() => Jeanne == Status.AQUAINTED)
                    .WithConsequence(() => Manipulation.Add(1))
                    .WithConsequence(() => Jeanne.Set(Status.WAVERING))
                    .WithConsequence(() => AylissRescue.Check()))
                .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_PRIEST_MATTERS_OF_FAITH")
                .WithRequirement(() => PathOfThePriest == true)
                .WithDecision("EVENTS_YOUTH_PRIEST_MATTERS_OF_FAITH_DECISION_JOIN_THE_PREACHERS", decision => decision
                    .WithConsequence(() => Theology.Add(1))
                    .WithConsequence(() => Jeanne.Add(1)))
                .WithDecision("EVENTS_YOUTH_PRIEST_MATTERS_OF_FAITH_DECISION_SEARCH_FOR_THE_DIVINE_WITHIN_YOURSELF", decision => decision
                    .WithConsequence(() => Willpower.Add(10)))
                .WithDecision("EVENTS_YOUTH_PRIEST_MATTERS_OF_FAITH_DECISION_INFILTRATE_THE_SECRET_SOCIETY", decision => decision
                    .WithRequirement(() => Willpower >= 0)
                    .WithConsequence(() => Diplomacy.Add(1))
                    .WithConsequence(() => Scheming.Add(1))
                    .WithConsequence(() => Willpower.Add(-5)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_LOTLESS_BEFORE_THE_MARCH")
                .WithRequirement(() => PathOfTheLotless == true)
                .WithDecision("EVENTS_YOUTH_LOTLESS_BEFORE_THE_MARCH_DECISION_MOBILIZE_THE_COMMONERS", decision => decision
                    .WithConsequence(() => Manipulation.Add(1)))
                .WithDecision("EVENTS_YOUTH_LOTLESS_BEFORE_THE_MARCH_DECISION_MOBILIZE_THE_NOBLES_AND_THE_CLERGY", decision => decision
                    .WithConsequence(() => Diplomacy.Add(1))
                    .WithConsequence(() => Theology.Add(1)))
                .WithDecision("EVENTS_YOUTH_LOTLESS_BEFORE_THE_MARCH_DECISION_SHOW_SOPHIA_YOUR_SUPPORT", decision => decision
                    .WithConsequence(() => Willpower.Add(5))
                    .WithConsequence(() => Sophia.Add(1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_GENERAL_THE_FEAST_OF_THE_HEIR")
                .WithRequirement(() => PathOfTheNobleman == false)
                                                               .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                                                                            .WithConsequence(() => Power.Add(-1)))
                                                               .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_LOTLESS_MARCH_OF_THE_COLLARS")
                .WithRequirement(() => PathOfTheLotless == true)
                .WithDecision("EVENTS_YOUTH_LOTLESS_MARCH_OF_THE_COLLARS_DECISION_BEGIN_THE_ASSAULT", decision => decision
                    .WithConsequence(() => Valor.Add(1))
                    .WithConsequence(() => Aylis.Set(Status.TRUE_DEATH)))
                .WithDecision("EVENTS_YOUTH_LOTLESS_MARCH_OF_THE_COLLARS_DECISION_HOLD_SOPHIA_BACK", decision => decision
                    .WithRequirement(() => Sophia == Status.TRUSTING)
                    .WithConsequence(() => Eloquence.Add(1))
                    .WithConsequence(() => Manipulation.Add(1))
                    .WithConsequence(() => AylissRescue.Check()))
                .WithDecision("EVENTS_YOUTH_LOTLESS_MARCH_OF_THE_COLLARS_DECISION_FREE_THE_CAPTIVE_MAGES_ON_YOUR_OWN", decision => decision
                    .WithRequirement(() => Scheming >= 10)
                    .WithConsequence(() => Scheming.Add(1))
                    .WithConsequence(() => Sophia.Add(1))
                    .WithConsequence(() => AylissRescue.Check()))
                .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_NOBLEMAN_SIR_EL_CROIXS_LESSON")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithDecision("EVENTS_YOUTH_NOBLEMAN_SIR_EL_CROIXS_LESSON_DECISION_RELY_ON_THE_WILL_OF_THE_TWINS", decision => decision
                    .WithConsequence(() => Valor.Add(1))
                    .WithConsequence(() => Theology.Add(1)))
                .WithDecision("EVENTS_YOUTH_NOBLEMAN_SIR_EL_CROIXS_LESSON_DECISION_PRESS_FOR_A_DECISIVE_ASSAULT", decision => decision
                    .WithConsequence(() => Valor.Add(1))
                    .WithConsequence(() => Eloquence.Add(1)))
                .WithDecision("EVENTS_YOUTH_NOBLEMAN_SIR_EL_CROIXS_LESSON_DECISION_LAY_SIEGE_TO_THE_PALACE", decision => decision
                    .WithConsequence(() => Valor.Add(1))
                    .WithConsequence(() => Scheming.Add(1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_GENERAL_LETTERS_FROM_HOME")
                                                       .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                                                                    .WithConsequence(() => Stephan.Add(-1))
                                                                    .WithConsequence(() => Gloria.Add(-1))
                                                                    .WithConsequence(() => Nathan.Add(-1)))
                                                       .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_NOBLEMAN_THE_FIRST_CASE")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithDecision("EVENTS_YOUTH_NOBLEMAN_THE_FIRST_CASE_DECISION_FIND_THE_NOBLEMAN", decision => decision
                    .WithConsequence(() => Diplomacy.Add(1))
                    .WithConsequence(() => AylissRescue.Check()))
                .WithDecision("EVENTS_YOUTH_NOBLEMAN_THE_FIRST_CASE_DECISION_INTERROGATE_AYLISS", decision => decision
                    .WithRequirement(() => Willpower >= 0)
                    .WithConsequence(() => Manipulation.Add(1))
                    .WithConsequence(() => Theology.Add(1))
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Aylis.Set(Status.TRUE_DEATH)))
                .WithDecision("EVENTS_YOUTH_NOBLEMAN_THE_FIRST_CASE_DECISION_RELEASE_AYLISS", decision => decision
                    .WithConsequence(() => Willpower.Add(10))
                    .WithConsequence(() => AylissRescue.Check()))
                .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_GENERAL_THE_OVERSEER_OF_MAGRA")
                                                       .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                                                                    .WithConsequence(() => Power.Add(1))
                                                                    .WithConsequence(() => Order.Add(1)))
                                                       .Build());


            Events.Add(new EventBuilder("EVENTS_YOUTH_PRIEST_A_CRIMINAL_RELATIONSHIP")
                .WithRequirement(() => PathOfThePriest == true)
                .WithDecision("EVENTS_YOUTH_PRIEST_A_CRIMINAL_RELATIONSHIP_DECISION_DEFEND_THE_SEMINARY_STUDENT", decision => decision
                    .WithRequirement(() => Theology >= 12)
                    .WithConsequence(() => Theology.Add(1))
                    .WithConsequence(() => Valor.Add(1))
                    .WithConsequence(() => Jeanne.Add(-1)))
                .WithDecision("EVENTS_YOUTH_PRIEST_A_CRIMINAL_RELATIONSHIP_DECISION_DEMAND_PUNISHMENT", decision => decision
                    .WithRequirement(() => Eloquence >= 12)
                    .WithConsequence(() => Eloquence.Add(1)))
                .WithDecision("EVENTS_YOUTH_PRIEST_A_CRIMINAL_RELATIONSHIP_DECISION_FLEE_THE_COURTROOM", decision => decision
                    .WithConsequence(() => Willpower.Add(10))
                    .WithConsequence(() => Jeanne.Add(1)))
                .Build());

            TheSecondSacrament = (new EventBuilder("EVENTS_YOUTH_THE_SECOND_SACRAMENT")
                .WithRequirement(() => PathOfThePriest == true)
                .WithDecision("EVENTS_YOUTH_PRIEST_THE_SECOND_SACRAMENT_DECISION_HAVE_MERCY_ON_THE_CHILD", decision => decision
                    .WithConsequence(() => Willpower.Add(5))
                    .WithConsequence(() => Jeanne.Add(-1)))
                .WithDecision("EVENTS_YOUTH_PRIEST_THE_SECOND_SACRAMENT_DECISION_STRIKE_WITH_ALL_YOUR_MIGHT", decision => decision
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Jeanne.Add(1)))
                .Build());
            Events.Add(TheSecondSacrament);

            Events.Add(new EventBuilder("EVENTS_YOUTH_LOTLESS_THE_TRAP_SPRINGS")
                .WithRequirement(() => PathOfTheLotless == true)
    .WithDecision("EVENTS_YOUTH_LOTLESS_THE_TRAP_SPRINGS_DECISION_RESIST_SOPHIA", decision => decision
        .WithRequirement(() => Willpower >= 10)
        .WithConsequence(() => Valor.Add(1))
        .WithConsequence(() => Eloquence.Add(1))
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Sophia.Add(-1)))
    .WithDecision("EVENTS_YOUTH_LOTLESS_THE_TRAP_SPRINGS_DECISION_CREATE_A_DISTRACTION", decision => decision
        .WithRequirement(() => Willpower >= 0)
        .WithConsequence(() => Scheming.Add(1))
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Sophia.Add(1)))
    .WithDecision("EVENTS_YOUTH_LOTLESS_THE_TRAP_SPRINGS_DECISION_SURRENDER", decision => decision
        .WithConsequence(() => Willpower.Add(5)))
    .Build());

            Recruitment = (new EventBuilder("EVENTS_LOTLESS_YOUTH_RECRUITMENT")
                .WithRequirement(() => PathOfTheLotless == true)
                .WithDecision("EVENTS_YOUTH_LOTLESS_RECRUITMENT_DECISION_OUTWIT_FELIPE", decision => decision
                    .WithRequirement(() => Manipulation >= 13)
                    .WithConsequence(() => TheLotlessAtLarge.Check()))
                .WithDecision("EVENTS_YOUTH_LOTLESS_RECRUITMENT_DECISION_PROVE_THAT_YOU_WILL_BE_USEFUL", decision => decision
                    .WithRequirement(() => Scheming >= 13)
                    .WithConsequence(() => Felipe.Add(2)))
                .WithDecision("EVENTS_YOUTH_LOTLESS_RECRUITMENT_DECISION_BETRAY_THE_REMAINING_LOTLESS", decision => decision
                    .WithConsequence(() => Sophia.Add(-2))
                    .WithConsequence(() => CollapseOfTheLotless.Check()))
                .WithDecision("EVENTS_YOUTH_LOTLESS_RECRUITMENT_DECISION_REJECT_THE_SECRET_CHANCELLERY", decision => decision
                    .WithConsequence(() => Reputation.Add(-10))
                    .WithConsequence(() => Deaths.Add(4))
                    .WithConsequence(() => TrueDeath.Check()))
                .Build());
            Events.Add(Recruitment);

            Events.Add(new EventBuilder("EVENTS_YOUTH_NOBLEMAN_GREAT_FEAST_FOR_ALL")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithDecision("EVENTS_YOUTH_NOBLEMAN_A_GREAT_FEAST_FOR_ALL_DECISION_FOLLOW_THE_ORDER", decision => decision
                    .WithRequirement(() => Diplomacy >= 12)
                    .WithConsequence(() => Diplomacy.Add(1))
                    .WithConsequence(() => Power.Add(-1))
                    .WithConsequence(() => Order.Add(1)))
                .WithDecision("EVENTS_YOUTH_NOBLEMAN_A_GREAT_FEAST_FOR_ALL_DECISION_DEMAND_YOUR_RIGHTS", decision => decision
                    .WithRequirement(() => Valor >= 12)
                    .WithConsequence(() => Valor.Add(1)))
                .WithDecision("EVENTS_YOUTH_NOBLEMAN_A_GREAT_FEAST_FOR_ALL_DECISION_BIDE_YOUR_TIME", decision => decision
                    .WithConsequence(() => Willpower.Add(10))
                    .WithConsequence(() => Power.Add(-1)))
                .Build());

            TheWayOfTheSword = (new EventBuilder("EVENTS_YOUTH_NOBLEMAN_THE_WAY_OF_THE_SWORD")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithDecision("EVENTS_YOUTH_NOBLEMAN_THE_WAY_OF_THE_SWORD_DECISION_FIGHT_IN_OCTAVIAS_NAME", decision => decision
                    .WithRequirement(() => Octavia == Status.REMEMBERS_YOU)
                    .WithConsequence(() => Diplomacy.Add(1))
                    .WithConsequence(() => Octavia.Set(Status.INTRIGUED))
                    .WithConsequence(() => Octavia.Add(1)))
                .WithDecision("EVENTS_YOUTH_NOBLEMAN_THE_WAY_OF_THE_SWORD_DECISION_ADDRESS_OCTAVIA_PUBLICLY", decision => decision
                    .WithRequirement(() => Willpower >= 0)
                    .WithRequirement(() => Octavia != Status.REMEMBERS_YOU)
                    .WithConsequence(() => Diplomacy.Add(1))
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Octavia.Set(Status.ACQUAINTED))
                    .WithConsequence(() => Octavia.Add(1)))
                .WithDecision("EVENTS_YOUTH_NOBLEMAN_THE_WAY_OF_THE_SWORD_DECISION_CHOOSE_A_LADY_OF_THE_COURT_TO_FIGHT_FOR", decision => decision
                    .WithConsequence(() => Octavia.Set(Status.ILL_DISPOSED)))
                .WithDecision("EVENTS_YOUTH_NOBLEMAN_THE_WAY_OF_THE_SWORD_DECISION_DEDICATE_YOUR_FIGHT_TO_YOUR_FATHER", decision => decision
                    .WithRequirement(() => Valor >= 12)
                    .WithRequirement(() => TheFencingLesson == true)
                    .WithConsequence(() => Valor.Add(1))
                    .WithConsequence(() => Octavia.Set(Status.INTRIGUED))
                    .WithConsequence(() => VictoryInTheTournament.Check()))
                .Build());
            Events.Add(TheWayOfTheSword);

            Events.Add(new EventBuilder("EVENTS_YOUTH_GENERAL_DIAMANT_STANDS_TRIAL")
                                                       .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                                                                    .WithConsequence(() => Church.Add(-1)))
                                                       .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_GENERAL_A_FAREWELL_TO_THE_CAPITAL")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                    .WithConsequence(() => Stephan.Add(1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_GENERAL_A_FAREWELL_TO_THE_CAPITAL")
                .WithRequirement(() => PathOfThePriest == true)
                .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                    .WithConsequence(() => Nathan.Add(1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_YOUTH_GENERAL_A_FAREWELL_TO_THE_CAPITAL")
                .WithRequirement(() => PathOfTheLotless == true)
                .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                    .WithConsequence(() => Gloria.Add(1)))
                .Build());



            //Peacetime events

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_SPIRITUAL_GUIDANCE")
                .WithRequirement(() => PathOfThePriest == true)
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_SPIRITUAL_GUIDANCE_DECISION_SUPPORT_JEANNE", decision => decision
        .WithConsequence(() => Jeanne.Add(1)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_SPIRITUAL_GUIDANCE_DECISION_DISAGREE_WITH_JEANNE", decision => decision
        .WithRequirement(() => Eloquence >= 12)
        .WithRequirement(() => ShieldOfTheNewFaith == true)
        .WithConsequence(() => Theology.Add(1))
        .WithConsequence(() => Eloquence.Add(1)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_SPIRITUAL_GUIDANCE_DECISION_EVADE_THE_QUESTION", decision => decision
        .WithConsequence(() => Willpower.Add(5)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_HOMECOMING")
                .WithDecision("EVENTS_PEACETIME_GENERAL_HOMECOMING_DECISION_FIND_OUT_HOW_MOTHER_IS_DOING", decision => decision
                    .WithConsequence(() => Lydia.Add(1)))
                .WithDecision("EVENTS_PEACETIME_GENERAL_HOMECOMING_DECISION_ASK_GLORIA_ABOUT_HER_LIFE", decision => decision
                    .WithConsequence(() => Stephan.Add(-1))
                    .WithConsequence(() => Gloria.Add(1)))
                .WithDecision("EVENTS_PEACETIME_GENERAL_HOMECOMING_DECISION_CHAT_WITH_NATHAN", decision => decision
                    .WithConsequence(() => Nathan.Add(1)))
                .WithDecision("EVENTS_PEACETIME_GENERAL_HOMECOMING_DECISION_TALK_TO_STEPHAN", decision => decision
                    .WithConsequence(() => Stephan.Add(1))
                    .WithConsequence(() => Gloria.Add(-1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_THE_SACRED_CONCLAVE")
                .WithRequirement(() => PathOfThePriest == true)
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_SACRED_CONCLAVE_DECISION_PUT_THE_MAGRANS_AT_EASE", decision => decision
                    .WithConsequence(() => Tolerance.Add(1))
                    .WithConsequence(() => Reputation.Add(1))
                    .WithConsequence(() => Jeanne.Add(-1))
                    .WithConsequence(() => Lennart.Add(1)))
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_SACRED_CONCLAVE_DECISION_ACCUSE_THE_MAGRANS", decision => decision
                    .WithConsequence(() => Inquisition.Add(1))
                    .WithConsequence(() => Reputation.Add(1))
                    .WithConsequence(() => Jeanne.Add(1))
                    .WithConsequence(() => Ulrich.Add(1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_FIRST_STEPS")
                .WithRequirement(() => PathOfTheLotless == true)
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_FIRST_STEPS_DECISION_HIRE_REBELS", decision => decision
                    .WithRequirement(() => Manipulation >= 12)
                    .WithConsequence(() => Unrest.Add(1)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_FIRST_STEPS_DECISION_HIRE_SPIES_MOLES_AND_CROOKS", decision => decision
                    .WithRequirement(() => Scheming >= 12)
                    .WithConsequence(() => Network.Add(1)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_FIRST_STEPS_DECISION_COMMIT_TO_THE_PRINTING_BUSINESS", decision => decision
                    .WithRequirement(() => Wealth >= 1)
                    .WithConsequence(() => Willpower.Add(5))
                    .WithConsequence(() => Wealth.Add(-1))
                    .WithConsequence(() => ProfitableBusiness.Check()))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_FIRST_DAY_OF_SERVICE")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithDecision("EVENTS_PEACETIME_JUDGE_FIRST_DAY_OF_SERVICE_DECISION_PREPARE_TO_DEAL_WITH_YOUR_FIRST_CASES", decision => decision
                    .WithConsequence(() => Willpower.Add(5))
                    .WithConsequence(() => ElBorne.Add(1)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_FIRST_DAY_OF_SERVICE_DECISION_GET_AQUAINTED_WITH_THE_JUDGES", decision => decision
                    .WithConsequence(() => Career.Add(1))
                    .WithConsequence(() => Justice.Add(-1)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_FIRST_DAY_OF_SERVICE_DECISION_ASK_FATHER_FOR_ADVICE", decision => decision
                    .WithRequirement(() => Robert >= 2)
                    .WithConsequence(() => Diplomacy.Add(1))
                    .WithConsequence(() => Justice.Add(1))
                    .WithConsequence(() => Career.Add(-1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_A_RECEPTION_AT_THE_BRANTE_RESIDENCE")
                .WithDecision("EVENTS_PEACETIME_GENERAL_A_RECEPTION_AT_THE_BRANTE_RESIDENCE_DECISION_SHARE_NEWS_FROM_THE_CAPITAL", decision => decision
                    .WithRequirement(() => Diplomacy >= 10)
                    .WithConsequence(() => Diplomacy.Add(1))
                    .WithConsequence(() => Manipulation.Add(1))
                    .WithConsequence(() => Reputation.Add(1))
                    .WithConsequence(() => Stephan.Add(1)))
                .WithDecision("EVENTS_PEACETIME_GENERAL_A_RECEPTION_AT_THE_BRANTE_RESIDENCE_DECISION_PRESENT_YOUR_MOTHER_AND_SISTER", decision => decision
                    .WithConsequence(() => Willpower.Add(5))
                    .WithConsequence(() => Unity.Add(1))
                    .WithConsequence(() => Reputation.Add(-1))
                    .WithConsequence(() => Gloria.Add(1))
                    .WithConsequence(() => Stephan.Add(-1)))
                .WithDecision("EVENTS_PEACETIME_GENERAL_A_RECEPTION_AT_THE_BRANTE_RESIDENCE_DECISION_PURCHASE_A_FAMILY_PORTRAIT", decision => decision
                    .WithRequirement(() => Manipulation >= 10 || Eloquence >= 12)
                    .WithConsequence(() => Manipulation.Add(1))
                    .WithConsequence(() => Eloquence.Add(1))
                    .WithConsequence(() => Wealth.Add(-1))
                    .WithConsequence(() => Reputation.Add(1))
                    .WithConsequence(() => Unity.Add(1)))
                .WithDecision("EVENTS_PEACETIME_GENERAL_A_RECEPTION_AT_THE_BRANTE_RESIDENCE_DECISION_TALK_ABOUT_YOUR_VICTORY_IN_THE_TOURNAMENT", decision => decision
                    .WithRequirement(() => VictoryInTheTournament == true)
                    .WithConsequence(() => Diplomacy.Add(1))
                    .WithConsequence(() => Eloquence.Add(1))
                    .WithConsequence(() => Reputation.Add(2))
                    .WithConsequence(() => Stephan.Add(1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_A_ROCK_AND_A_HARD_PLACE")
    .WithDecision("EVENTS_PEACETIME_GENERAL_A_ROCK_AND_A_HARD_PLACE_DECISION_SIDE_WITH_STEPHAN", decision => decision
        .WithConsequence(() => Unity.Add(-1))
        .WithConsequence(() => Gloria.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_GENERAL_A_ROCK_AND_A_HARD_PLACE_DECISION_DEFEND_GLORIA", decision => decision
        .WithConsequence(() => Reputation.Add(-1))
        .WithConsequence(() => Stephan.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_GENERAL_A_ROCK_AND_A_HARD_PLACE_DECISION_SEND_GLORIA_TO_VALONA", decision => decision
        .WithRequirement(() => Wealth >= 1)
        .WithRequirement(() => Manipulation >= 12 || Gloria >= 2)
        .WithConsequence(() => Eloquence.Add(1))
        .WithConsequence(() => Manipulation.Add(1))
        .WithConsequence(() => Wealth.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_GENERAL_A_ROCK_AND_A_HARD_PLACE_DECISION_APPEAL_TO_NATHAN", decision => decision
        .WithRequirement(() => Theology >= 11)
        .WithRequirement(() => Nathan >= 2)
        .WithConsequence(() => Theology.Add(1))
        .WithConsequence(() => Unity.Add(1))
        .WithConsequence(() => Gloria.Add(-1))
        .WithConsequence(() => Stephan.Add(-1))
        .WithConsequence(() => Nathan.Add(1)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_THE_LAST_STRAW")
    .WithRequirement(() => PathOfTheLotless == true)
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_THE_LAST_STRAW_DECISION_AGREE_WITH_FELIPE", decision => decision
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Network.Add(1))
        .WithConsequence(() => Felipe.Add(1))
        .WithConsequence(() => Sophia.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_THE_LAST_STRAW_DECISION_SIDE_WITH_SOPHIA", decision => decision
        .WithRequirement(() => Manipulation >= 12)
        .WithConsequence(() => Felipe.Add(-1))
        .WithConsequence(() => Sophia.Add(1)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_HEARTS_ON_FIRE")
                .WithRequirement(() => PathOfTheLotless == true)
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_HEARTS_ON_FIRE_DECISION_RECRUIT_THE_POETS", decision => decision
                    .WithConsequence(() => Eloquence.Add(1))
                    .WithConsequence(() => Unrest.Add(1))
                    .WithConsequence(() => Network.Add(-1)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_HEARTS_ON_FIRE_DECISION_LET_FELIPE_HANDLE_THEM", decision => decision
                    .WithConsequence(() => Network.Add(1))
                    .WithConsequence(() => Unrest.Add(-1))
                    .WithConsequence(() => Felipe.Add(1))
                    .WithConsequence(() => Sophia.Add(-1)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_HEARTS_ON_FIRE_DECISION_PUBLISH_A_BOOK_OF_THEIR_POETRY", decision => decision
                    .WithRequirement(() => Manipulation >= 12)
                    .WithRequirement(() => Gloria >= 2)
                    .WithRequirement(() => GloriasSecret == true)
                    .WithConsequence(() => Manipulation.Add(1))
                    .WithConsequence(() => Unrest.Add(1))
                    .WithConsequence(() => Network.Add(-1))
                    .WithConsequence(() => Wealth.Add(2)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_HEARTS_ON_FIRE_DECISION_REPORT_THE_POETS_TO_FATHER", decision => decision
                    .WithRequirement(() => Scheming >= 12)
                    .WithRequirement(() => Felipe >= 0)
                    .WithConsequence(() => Unrest.Add(-1))
                    .WithConsequence(() => Network.Add(1))
                    .WithConsequence(() => Reputation.Add(2))
                    .WithConsequence(() => Sophia.Add(-1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_THE_LAND_DISPUTE")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithDecision("EVENTS_PEACETIME_JUDGE_THE_LAND_DISPUTE_DECISION_PROTECT_JUNGS_RIGHTS", decision => decision
                    .WithConsequence(() => WealthOfMagra.Add(1))
                    .WithConsequence(() => Order.Add(-1))
                    .WithConsequence(() => Career.Add(-1))
                    .WithConsequence(() => Justice.Add(1)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_THE_LAND_DISPUTE_DECISION_COMPLY_WITH_EL_AVILLAS_DEMANDS", decision => decision
                    .WithConsequence(() => WealthOfMagra.Add(-1))
                    .WithConsequence(() => Order.Add(1))
                    .WithConsequence(() => Career.Add(1))
                    .WithConsequence(() => Justice.Add(-1)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_THE_LAND_DISPUTE_DECISION_TERMINATE_THE_RENTAL_AGREEMENT", decision => decision
                    .WithRequirement(() => Willpower >= 0)
                    .WithRequirement(() => Diplomacy >= 12)
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => WealthOfMagra.Add(-1))
                    .WithConsequence(() => Order.Add(1))
                    .WithConsequence(() => Career.Add(1))
                    .WithConsequence(() => Justice.Add(-1))
                    .WithConsequence(() => Reputation.Add(1)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_THE_LAND_DISPUTE_DECISION_ASK_JUNG_FOR_A_BRIBE", decision => decision
                    .WithRequirement(() => Manipulation >= 10)
                    .WithConsequence(() => Manipulation.Add(1))
                    .WithConsequence(() => WealthOfMagra.Add(1))
                    .WithConsequence(() => Order.Add(-1))
                    .WithConsequence(() => Career.Add(-1))
                    .WithConsequence(() => Justice.Add(1))
                    .WithConsequence(() => Wealth.Add(1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_THE_ARCHDUKE_AND_THE_OVERSEER")
                                                       .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                                                                    .WithConsequence(() => WealthOfMagra.Add(-1))
                                                                    .WithConsequence(() => Order.Add(-1))
                                                                    .WithConsequence(() => Power.Add(1)))
                                                       .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_A_GIFT_FOR_THE_FAMILY")
    .WithDecision("EVENTS_PEACETIME_GENERAL_A_GIFT_FOR_THE_FAMILY_DECISION_GIVE_THE_JEWELS_TO_PROMINENT_NOBLES", decision => decision
        .WithRequirement(() => Diplomacy >= 11)
        .WithRequirement(() => Stephan >= 1)
        .WithConsequence(() => Diplomacy.Add(1))
        .WithConsequence(() => Scheming.Add(1))
        .WithConsequence(() => Reputation.Add(2)))
    .WithDecision("EVENTS_PEACETIME_GENERAL_A_GIFT_FOR_THE_FAMILY_DECISION_DECLINE_THE_GIFT", decision => decision
        .WithRequirement(() => Robert >= 3)
        .WithConsequence(() => Valor.Add(1))
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Unity.Add(2))
        .WithConsequence(() => Milanidas.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_GENERAL_A_GIFT_FOR_THE_FAMILY_DECISION_SELL_THE_JEWELS", decision => decision
        .WithConsequence(() => Wealth.Add(2))
        .WithConsequence(() => Unity.Add(-1)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_THE_LA_TARI_SOCIETY")
                .WithRequirement(() => PathOfThePriest == true)
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_LA_TARI_SOCIETY_DECISION_ARREST_THE_APOSTATES", decision => decision
                    .WithConsequence(() => Theology.Add(1))
                    .WithConsequence(() => Inquisition.Add(1))
                    .WithConsequence(() => Tolerance.Add(-1)))
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_LA_TARI_SOCIETY_DECISION_PREACH_TO_THEM", decision => decision
                    .WithRequirement(() => Eloquence >= 13)
                    .WithRequirement(() => Willpower >= 0)
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Inquisition.Add(1))
                    .WithConsequence(() => Tolerance.Add(-1))
                    .WithConsequence(() => Wealth.Add(1))
                    .WithConsequence(() => Reputation.Add(1))
                    .WithConsequence(() => Milanidas.Set(Status.GRATEFUL)))
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_LA_TARI_SOCIETY_DECISION_BECOME_A_PART_OF_THE_CIRCLE", decision => decision
                    .WithRequirement(() => Theology >= 13)
                    .WithConsequence(() => Willpower.Add(5))
                    .WithConsequence(() => Tolerance.Add(1))
                    .WithConsequence(() => Inquisition.Add(-1))
                    .WithConsequence(() => TheLaTariRitual.Check()))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_CONCERNED_CITIZEN")
                .WithRequirement(() => PathOfTheLotless == true)
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_CONCERNED_CITIZEN_DECISION_KEEP_THE_CONVERSATION_A_SECRET", decision => decision
                    .WithConsequence(() => Wealth.Add(1))
                    .WithConsequence(() => Egmont.Set(Status.SECRET_PLOT)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_CONCERNED_CITIZEN_DECISION_REPORT_THE_CONVERSATION", decision => decision
                    .WithConsequence(() => Felipe.Add(1))
                    .WithConsequence(() => Egmont.Set(Status.IN_JEOPARDY)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_THE_POWER_OF_THE_LAW")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithDecision("EVENTS_PEACETIME_JUDGE_THE_POWER_OF_THE_LAW_DECISION_SIDE_WITH_EL_BORNE", decision => decision
                    .WithConsequence(() => ElBorne.Add(2))
                    .WithConsequence(() => ElBorne.Set(Status.THE_PROMISE)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_THE_POWER_OF_THE_LAW_DECISION_REJECT_HIS_OFFER", decision => decision
                    .WithConsequence(() => Willpower.Add(5))
                    .WithConsequence(() => ElBorne.Add(-2)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_AN_OLD_FRIEND")
                .WithDecision("EVENTS_PEACETIME_GENERAL_AN_OLD_FRIEND_DECISION_HAVE_DINNER_WITH_TOMMAS", decision => decision
                    .WithConsequence(() => Willpower.Add(10))
                    .WithConsequence(() => Reputation.Add(-1))
                    .WithConsequence(() => Tommas.Add(1)))
                .WithDecision("EVENTS_PEACETIME_GENERAL_AN_OLD_FRIEND_DECISION_WALK_AWAY", decision => decision
                    .WithRequirement(() => PathOfTheNobleman == false)
                    .WithRequirement(() => Tommas != Status.BOUND_BY_FRIENDSHIP)
                    .WithConsequence(() => Tommas.Add(-1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_IN_THE_SHADOW_OF_THE_TREE")
                .WithRequirement(() => PathOfThePriest == true)
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_IN_THE_SHADOW_OF_THE_TREE_DECISION_HELP_FATHER_LENNART", decision => decision
                    .WithConsequence(() => Lennart.Add(2))
                    .WithConsequence(() => Lennart.Set(Status.A_PROMISE_IS_MADE)))
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_IN_THE_SHADOW_OF_THE_TREE_DECISION_REFUSE_FATHER_LENNART", decision => decision
                    .WithConsequence(() => Lennart.Add(-1)))
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_IN_THE_SHADOW_OF_THE_TREE_DECISION_POINT_OUT_THE_FLAWS_IN_THE_NEW_FAITH", decision => decision
                    .WithRequirement(() => Eloquence >= 12)
                    .WithRequirement(() => ShieldOfTheOldFaith == true)
                    .WithConsequence(() => Theology.Add(1))
                    .WithConsequence(() => Eloquence.Add(1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_THE_GUNPOWDER_PLOT")
                .WithRequirement(() => PathOfTheLotless == true)
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_THE_GUNPOWDER_PLOT_DECISION_MAKE_A_DEAL_WITH_MAYER_EGMONT", decision => decision
                    .WithRequirement(() => Manipulation >= 12)
                    .WithRequirement(() => Egmont == Status.SECRET_PLOT)
                    .WithConsequence(() => Diplomacy.Add(1))
                    .WithConsequence(() => StashOfGunpowder.Check()))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_THE_GUNPOWDER_PLOT_DECISION_STEAL_THE_GUNPOWDER", decision => decision
                    .WithRequirement(() => Willpower >= 0)
                    .WithRequirement(() => (Scheming >= 14 || Sophia >= 2))
                    .WithConsequence(() => Valor.Add(1))
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => StashOfGunpowder.Check()))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_THE_GUNPOWDER_PLOT_DECISION_REPORT_THIS_TO_FELIPE", decision => decision
                    .WithRequirement(() => Egmont == Status.IN_JEOPARDY)
                    .WithConsequence(() => Network.Add(1))
                    .WithConsequence(() => Felipe.Add(1)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_THE_GUNPOWDER_PLOT_DECISION_REJECT_THE_IDEA_OF_GUNPOWDER_OUTRIGHT", decision => decision
                    .WithConsequence(() => Willpower.Add(10)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_THE_NEWSPAPER_CASE")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithDecision("EVENTS_PEACETIME_JUDGE_THE_NEWSPAPER_CASE_DECISION_SHUT_DOWN_THE_GAZETTE", decision => decision
                    .WithConsequence(() => Career.Add(1))
                    .WithConsequence(() => Justice.Add(-1))
                    .WithConsequence(() => ElVerman.Add(2)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_THE_NEWSPAPER_CASE_DECISION_DO_NOT_SHUT_DOWN_THE_GAZETTE", decision => decision
                    .WithConsequence(() => Career.Add(-1))
                    .WithConsequence(() => Justice.Add(1)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_THE_NEWSPAPER_CASE_DECISION_LEGITIMIZE_THE_GAZETTE", decision => decision
                    .WithRequirement(() => Diplomacy >= 13)
                    .WithRequirement(() => Willpower >= 0)
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Career.Add(1))
                    .WithConsequence(() => Justice.Add(1))
                    .WithConsequence(() => Wealth.Add(-1))
                    .WithConsequence(() => ProtectorOfThePeople.Check()))
                .WithDecision("EVENTS_PEACETIME_JUDGE_THE_NEWSPAPER_CASE_DECISION_SEIZE_THE_PRINTING_PRESS", decision => decision
                    .WithRequirement(() => Scheming >= 10)
                    .WithRequirement(() => ElBorne >= 2)
                    .WithConsequence(() => Scheming.Add(1))
                    .WithConsequence(() => Career.Add(-1))
                    .WithConsequence(() => Justice.Add(-1))
                    .WithConsequence(() => Wealth.Add(1))
                    .WithConsequence(() => Reputation.Add(1))
                    .WithConsequence(() => ElBorne.Add(-2)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_THE_CALL_OF_THE_ANCESTORS")
                .WithDecision("EVENTS_PEACETIME_GENERAL_THE_CALL_OF_THE_ANCESTORS_DECISION_SIDE_WITH_FATHER", decision => decision
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Unity.Add(1))
                    .WithConsequence(() => Stephan.Add(-1))
                    .WithConsequence(() => Robert.Add(1)))
                .WithDecision("EVENTS_PEACETIME_GENERAL_THE_CALL_OF_THE_ANCESTORS_DECISION_SUPPORT_STEPHANS_SUPERIORITY", decision => decision
                    .WithConsequence(() => Willpower.Add(5))
                    .WithConsequence(() => Diplomacy.Add(1))
                    .WithConsequence(() => Unity.Add(-1))
                    .WithConsequence(() => Stephan.Add(2)))
                .WithDecision("EVENTS_PEACETIME_GENERAL_THE_CALL_OF_THE_ANCESTORS_DECISION_STEP_FORWARD_YOURSELF", decision => decision
                    .WithRequirement(() => PathOfTheNobleman == true)
                    .WithRequirement(() => BloodTide == true)
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Valor.Add(3))
                    .WithConsequence(() => Stephan.Add(-2))
                    .WithConsequence(() => Robert.Add(-2))
                    .WithConsequence(() => Gregor.Add(2)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_EGMONTS_SPEECH")
                                                       .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                                                                    .WithConsequence(() => Power.Add(1))
                                                                    .WithConsequence(() => Order.Add(-1))
                                                                    .WithConsequence(() => WealthOfMagra.Add(-1)))
                                                       .Build());

            ErrorsOfYouth = (new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_THE_ERRORS_OF_YOUTH")
                .WithRequirement(() => PathOfTheLotless == true)
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_THE_ERRORS_OF_YOUTH_DECISION_LURE_GUSTAV_INTO_A_TRAP", decision => decision
                    .WithRequirement(() => Manipulation >= 14)
                    .WithConsequence(() => Manipulation.Add(1))
                    .WithConsequence(() => Network.Add(1))
                    .WithConsequence(() => Reputation.Add(-1)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_THE_ERRORS_OF_YOUTH_DECISION_HELP_HIM_ESCAPE_THE_CITY", decision => decision
                    .WithRequirement(() => Scheming >= 14)
                    .WithConsequence(() => Willpower.Add(5))
                    .WithConsequence(() => Scheming.Add(1))
                    .WithConsequence(() => Wealth.Add(-1)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_THE_ERRORS_OF_YOUTH_DECISION_EXPLAIN_YOURSELF_TO_HIM", decision => decision
                    .WithRequirement(() => Willpower >= 0)
                    .WithRequirement(() => TheLotlessAtLarge == true)
                    .WithConsequence(() => Eloquence.Add(1))
                    .WithConsequence(() => Willpower.Add(-5)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_THE_ERRORS_OF_YOUTH_DECISION_ORDER_EVERYONE_TO_LIE_LOW", decision => decision
                    .WithConsequence(() => Network.Add(-1)))
                .Build());
            Events.Add(ErrorsOfYouth);

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_THE_WILL_AND_THE_LAW")
    .WithRequirement(() => PathOfThePriest == true)
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_WILL_AND_THE_LAW_DECISION_KILL_THE_PRISONER", decision => decision
        .WithConsequence(() => Ulrich.Add(2)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_WILL_AND_THE_LAW_DECISION_SUPPORT_JEANNE", decision => decision
        .WithConsequence(() => Valor.Add(1))
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Jeanne.Add(1)))
    .Build());

            ThePrintedPage = (new EventBuilder("EVENTS_PEACETIME_INQUISITOR_THE_PRINTED_PAGE")
                .WithRequirement(() => PathOfThePriest == true)
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_PRINTED_PAGE_DECISION_DESTROY_THE_PRINT_RUN", decision => decision
                    .WithConsequence(() => Power.Add(-1))
                    .WithConsequence(() => Inquisition.Add(1))
                    .WithConsequence(() => Tolerance.Add(-1))
                    .WithConsequence(() => Reputation.Add(1))
                    .WithConsequence(() => Lennart.Add(-2))
                    .WithConsequence(() => Lennart.Set(Status.PENANCE)))
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_PRINTED_PAGE_DECISION_LEAVE_THE_BOOKS_ALONE", decision => decision
                    .WithConsequence(() => Church.Add(1))
                    .WithConsequence(() => Inquisition.Add(-1))
                    .WithConsequence(() => Tolerance.Add(1))
                    .WithConsequence(() => Lennart.Add(2))
                    .WithConsequence(() => Ulrich.Add(-1))
                    .WithConsequence(() => Jeanne.Add(-1)))
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_PRINTED_PAGE_DECISION_REDACT_AND_CENSOR_THE_BOOKS", decision => decision
                    .WithRequirement(() => Willpower >= 0)
                    .WithRequirement(() => Theology >= 15)
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Order.Add(1))
                    .WithConsequence(() => Inquisition.Add(1))
                    .WithConsequence(() => Tolerance.Add(1))
                    .WithConsequence(() => Lennart.Add(1)))
                .Build());
            Events.Add(ThePrintedPage);

            AChatWithMagistrate = (new EventBuilder("EVENTS_PEACETIME_JUDGE_A_CHAT_WITH_THE_MAGISTRATE")
                .WithRequirement(() => PathOfTheLotless == true)
                .WithDecision("EVENTS_PEACETIME_JUDGE_A_CHAT_WITH_THE_MAGISTRATE_DECISION_AGREE_TO_THE_DEAL", decision => decision
                    .WithConsequence(() => Reputation.Add(1))
                    .WithConsequence(() => ElVerman.Add(1))
                    .WithConsequence(() => ElVerman.Set(Status.MADE_A_DEAL)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_A_CHAT_WITH_THE_MAGISTRATE_DECISION_REFUSE_OUTRIGHT", decision => decision
                    .WithRequirement(() => Valor >= 10)
                    .WithConsequence(() => Valor.Add(1))
                    .WithConsequence(() => ElVerman.Add(-2)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_A_CHAT_WITH_THE_MAGISTRATE_DECISION_EVADE_THE_QUESTION", decision => decision
                    .WithRequirement(() => Willpower >= 0)
                    .WithRequirement(() => Diplomacy >= 12 || Manipulation >= 16)
                    .WithConsequence(() => Diplomacy.Add(1))
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Reputation.Add(1)))
                .Build());
            Events.Add(AChatWithMagistrate);

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_THE_VASSAL_AND_THE_LORD")
    .WithRequirement(() => PathOfTheNobleman == true)
    .WithDecision("EVENTS_PEACETIME_JUDGE_THE_VASSAL_AND_THE_LORD_DECISION_SUPPORT_EL_BORNE", decision => decision
        .WithConsequence(() => Octavia.Add(-1))
        .WithConsequence(() => Tempest.Add(1))
        .WithConsequence(() => ElBorne.Add(1))
        .WithConsequence(() => Milanidas.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_THE_VASSAL_AND_THE_LORD_DECISION_SIDE_WITH_OCTAVIA", decision => decision
        .WithConsequence(() => Justice.Add(-1))
        .WithConsequence(() => Octavia.Add(1))
        .WithConsequence(() => ElBorne.Add(-1))
        .WithConsequence(() => Milanidas.Add(1)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_THE_VASSAL_AND_THE_LORD_DECISION_DEFUSE_THE_SITUATION", decision => decision
        .WithRequirement(() => Octavia == Status.INTRIGUED)
        .WithRequirement(() => Diplomacy >= 13 || VictoryInTheTournament == true)
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => ElBorne.Add(1)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_PASSION")
    .WithRequirement(() => PathOfTheNobleman == true)
    .WithDecision("EVENTS_PEACETIME_JUDGE_PASSION_DECISION_SUBMIT_TO_HER", decision => decision
        .WithConsequence(() => Reputation.Add(1))
        .WithConsequence(() => Octavia.Add(1))
        .WithConsequence(() => Octavia.Set(Status.YOUR_PATRON)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_PASSION_DECISION_INSIST_ON_BEING_TREATED_AS_HER_EQUAL", decision => decision
        .WithRequirement(() => Octavia >= 2 || Octavia == Status.INTRIGUED)
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Octavia.Add(2))
        .WithConsequence(() => Octavia.Set(Status.GROWN_CLOSE)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_PASSION_DECISION_REJECT_HER", decision => decision
        .WithRequirement(() => Willpower >= 0)
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Octavia.Add(-1))
        .WithConsequence(() => Octavia.Set(Status.SCORNED)))
    .Build());

            BrothersInMisery = (new EventBuilder("EVENTS_PEACETIME_GENERAL_BROTHERS_IN_MISERY")
    .WithDecision("EVENTS_PEACETIME_GENERAL_BROTHERS_IN_MISERY_DECISION_USE_YOUR_AUTHORITY", decision => decision
        .WithRequirement(() => PathOfTheNobleman == true)
        .WithRequirement(() => Career >= 5)
        .WithConsequence(() => Eloquence.Add(1))
        .WithConsequence(() => Justice.Add(-1))
        .WithConsequence(() => Stephan.Add(1))
        .WithConsequence(() => Nathan.Add(1))
        .WithConsequence(() => ElBorne.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_GENERAL_BROTHERS_IN_MISERY_DECISION_TAKE_THEM_TO_THE_INQUISITION", decision => decision
        .WithRequirement(() => PathOfThePriest == true)
        .WithRequirement(() => Inquisition >= 5)
        .WithConsequence(() => Scheming.Add(1))
        .WithConsequence(() => Inquisition.Add(-1))
        .WithConsequence(() => Stephan.Add(1))
        .WithConsequence(() => Nathan.Add(1)))
    .WithDecision("EVENTS_PEACETIME_GENERAL_BROTHERS_IN_MISERY_DECISION_BLACKMAIL_THE_JUDGE", decision => decision
        .WithRequirement(() => PathOfTheLotless == true)
        .WithRequirement(() => Network >= 5)
        .WithConsequence(() => Diplomacy.Add(1))
        .WithConsequence(() => Network.Add(-1))
        .WithConsequence(() => Stephan.Add(1))
        .WithConsequence(() => Nathan.Add(1)))
    .WithDecision("EVENTS_PEACETIME_GENERAL_BROTHERS_IN_MISERY_DECISION_ASK_FATHER_FOR_HELP", decision => decision
        .WithConsequence(() => Manipulation.Add(1))
        .WithConsequence(() => Unity.Add(-1))
        .WithConsequence(() => Reputation.Add(-1))
        .WithConsequence(() => Scheming.Add(1))
        .WithConsequence(() => Stephan.Add(1))
        .WithConsequence(() => Nathan.Add(1))
        .WithConsequence(() => Robert.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_GENERAL_BROTHERS_IN_MISERY_DECISION_REFUSE_TO_HELP", decision => decision
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Reputation.Add(-2))
        .WithConsequence(() => Stephan.Add(-1))
        .WithConsequence(() => Nathan.Add(-1)))
    .Build());
            Events.Add(BrothersInMisery);

            Events.Add(new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_FREEDOM_OF_SPEECH")
    .WithRequirement(() => PathOfTheLotless == true)
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_FREEDOM_OF_SPEECH_DECISION_PRINT_THE_BOOK_IN_SECRET", decision => decision
        .WithRequirement(() => Scheming >= 14)
        .WithConsequence(() => Theology.Add(1))
        .WithConsequence(() => Unrest.Add(1)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_FREEDOM_OF_SPEECH_DECISION_REPORT_THE_ENCOUNTER_TO_FELIPE", decision => decision
        .WithConsequence(() => Church.Add(-1))
        .WithConsequence(() => Unrest.Add(-1))
        .WithConsequence(() => Network.Add(1))
        .WithConsequence(() => Felipe.Add(1)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_FREEDOM_OF_SPEECH_DECISION_PRINT_AND_DISSEMINATE_THE_BOOK_YOURSELF", decision => decision
        .WithRequirement(() => Eloquence >= 12)
        .WithConsequence(() => Theology.Add(1))
        .WithConsequence(() => Church.Add(1))
        .WithConsequence(() => Unrest.Add(1))
        .WithConsequence(() => Network.Add(1))
        .WithConsequence(() => Wealth.Add(-1))
        .WithConsequence(() => Reputation.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_FREEDOM_OF_SPEECH_DECISION_TELL_YOUR_FATHER_ABOUT_THE_ENCOUNTER", decision => decision
        .WithRequirement(() => Robert >= 2)
        .WithConsequence(() => Unrest.Add(-1))
        .WithConsequence(() => Network.Add(-1))
        .WithConsequence(() => Reputation.Add(1))
        .WithConsequence(() => Unity.Add(1)))
    .Build());

            TheCaseOfFatherMark = (new EventBuilder("EVENTS_PEACETIME_JUDGE_THE_CASE_OF_FATHER_MARK")
    .WithRequirement(() => PathOfTheNobleman == true)
    .WithDecision("EVENTS_PEACETIME_JUDGE_THE_CASE_OF_FATHER_MARK_DECISION_JUDGE_HIM", decision => decision
        .WithRequirement(() => Justice >= 4)
        .WithConsequence(() => Diplomacy.Add(1))
        .WithConsequence(() => Career.Add(-1))
        .WithConsequence(() => Justice.Add(1))
        .WithConsequence(() => Jeanne.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_THE_CASE_OF_FATHER_MARK_DECISION_HAND_HIM_OVER_TO_THE_INQUISITION", decision => decision
        .WithConsequence(() => Theology.Add(2))
        .WithConsequence(() => Church.Add(-1))
        .WithConsequence(() => Justice.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_THE_CASE_OF_FATHER_MARK_DECISION_SET_HIM_FREE", decision => decision
        .WithRequirement(() => Scheming >= 10)
        .WithConsequence(() => Scheming.Add(1))
        .WithConsequence(() => Church.Add(1))
        .WithConsequence(() => Career.Add(-1))
        .WithConsequence(() => Wealth.Add(2)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_THE_CASE_OF_FATHER_MARK_DECISION_PROSECUTE_THE_CASE_WITH_THE_INQUISITION", decision => decision
        .WithRequirement(() => Theology >= 10)
        .WithConsequence(() => Theology.Add(1))
        .WithConsequence(() => Eloquence.Add(1))
        .WithConsequence(() => Church.Add(-1))
        .WithConsequence(() => Career.Add(1))
        .WithConsequence(() => Justice.Add(-1)))
    .Build());
            Events.Add(TheCaseOfFatherMark);

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_THE_GUNS_OF_ELIRIA")
                                                     .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                                                                  .WithConsequence(() => WealthOfMagra.Add(-1)))
                                                     .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_PAYBACK")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithRequirement(() => Octavia == Status.SCORNED)
                .WithDecision("EVENTS_PEACETIME_JUDGE_PAYBACK_DECISION_OFFER_AN_APOLOGY", decision => decision
                    .WithRequirement(() => Willpower >= 0)
                    .WithConsequence(() => Willpower.Add(-10))
                    .WithConsequence(() => Career.Add(-1))
                    .WithConsequence(() => Reputation.Add(-1))
                    .WithConsequence(() => Octavia.Set(null)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_PAYBACK_DECISION_DEFEND_YOURSELF", decision => decision
                    .WithConsequence(() => Career.Add(-2))
                    .WithConsequence(() => Reputation.Add(-2))
                    .WithConsequence(() => Octavia.Set(null))
                    .WithConsequence(() => Octavia.Add(2))
                    .WithConsequence(() => Stephan.Add(-1)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_PAYBACK_DECISION_SEEK_ASSISTANCE_FROM_THE_HOSTESS", decision => decision
                    .WithRequirement(() => Diplomacy >= 16)
                    .WithConsequence(() => Reputation.Add(1))
                    .WithConsequence(() => Octavia.Set(null)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_MIRACLES_AND_WONDERS")
    .WithRequirement(() => PathOfThePriest == true)
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_MIRACLES_AND_WONDERS_DECISION_SUBDUE_ARIADELLA", decision => decision
        .WithRequirement(() => Inquisition >= 5)
        .WithConsequence(() => Eloquence.Add(1))
        .WithConsequence(() => Inquisition.Add(1))
        .WithConsequence(() => Tolerance.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_MIRACLES_AND_WONDERS_DECISION_PROCLAIM_THIS_OCCURRENCE_A_MIRACLE_OF_THE_TWINS", decision => decision
        .WithRequirement(() => Theology >= 13)
        .WithConsequence(() => Theology.Add(1))
        .WithConsequence(() => Manipulation.Add(1))
        .WithConsequence(() => Inquisition.Add(-1))
        .WithConsequence(() => Tolerance.Add(1))
        .WithConsequence(() => WealthOfMagra.Add(1)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_MIRACLES_AND_WONDERS_DECISION_HAVE_ARIADELLA_EXECUTED", decision => decision
        .WithConsequence(() => Diplomacy.Add(1))
        .WithConsequence(() => Reputation.Add(1))
        .WithConsequence(() => Tolerance.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_MIRACLES_AND_WONDERS_DECISION_SAVE_ARIADELLA", decision => decision
        .WithRequirement(() => Scheming >= 10)
        .WithRequirement(() => Jeanne >= 2)
        .WithRequirement(() => Aylis == Status.JOINED_A_TROUPE)
        .WithConsequence(() => Scheming.Add(1))
        .WithConsequence(() => Inquisition.Add(-1))
        .WithConsequence(() => Wealth.Add(2)))
    .Build());

            BlastWave = (new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_BLAST_WAVE")
    .WithRequirement(() => PathOfTheLotless == true)
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_BLAST_WAVE_DECISION_INCITE_A_FULL_FLEDGED_RIOT", decision => decision
        .WithConsequence(() => Manipulation.Add(1))
        .WithConsequence(() => Scheming.Add(1))
        .WithConsequence(() => Deaths.Add(1))
        .WithConsequence(() => Order.Add(-1))
        .WithConsequence(() => Unrest.Add(1))
        .WithConsequence(() => Network.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_BLAST_WAVE_DECISION_RECRUIT_THE_PROTESTERS_TO_THE_LAST_STRAW", decision => decision
        .WithRequirement(() => Manipulation >= 15)
        .WithConsequence(() => Manipulation.Add(1))
        .WithConsequence(() => Eloquence.Add(1))
        .WithConsequence(() => WealthOfMagra.Add(2))
        .WithConsequence(() => Unrest.Add(-1))
        .WithConsequence(() => Network.Add(1)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_BLAST_WAVE_DECISION_PROFIT_FROM_THE_HAVOC", decision => decision
        .WithRequirement(() => Scheming >= 15)
        .WithConsequence(() => Scheming.Add(1))
        .WithConsequence(() => Diplomacy.Add(1))
        .WithConsequence(() => WealthOfMagra.Add(1))
        .WithConsequence(() => Network.Add(-1))
        .WithConsequence(() => Wealth.Add(2)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_BLAST_WAVE_DECISION_ALERT_EL_VERMAN", decision => decision
        .WithRequirement(() => ElVerman >= 0)
        .WithConsequence(() => Order.Add(1))
        .WithConsequence(() => Unrest.Add(-1))
        .WithConsequence(() => Unity.Add(1))
        .WithConsequence(() => Reputation.Add(1))
        .WithConsequence(() => Stephan.Add(1))
        .WithConsequence(() => ElVerman.Add(1)))
    .Build());
            Events.Add(BlastWave);

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_A_FRIEND_IN_NEED")
    .WithRequirement(() => PathOfTheNobleman == true)
    .WithDecision("EVENTS_PEACETIME_JUDGE_A_FRIEND_IN_NEED_DECISION_AGREE_TO_BE_TOMMAS_SECOND", decision => decision
        .WithConsequence(() => Tommas.Set(Status.IN_DANGER))
        .WithConsequence(() => Tommas.Add(1))
        .WithConsequence(() => ElBorne.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_A_FRIEND_IN_NEED_DECISION_STOP_THE_DUEL_FROM_TAKING_PLACE", decision => decision
        .WithRequirement(() => Manipulation >= 10)
        .WithRequirement(() => Otton >= 0)
        .WithConsequence(() => Tommas.Set(Status.IN_HIDING))
        .WithConsequence(() => Otton.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_A_FRIEND_IN_NEED_DECISION_DECLINE_TOMMAS_REQUEST", decision => decision
        .WithRequirement(() => BondOfFriendship == false)
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Tommas.Set(Status.IN_DANGER))
        .WithConsequence(() => Tommas.Add(-1)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_THE_CASE_AGAINST_OTTON")
    .WithRequirement(() => PathOfTheNobleman == true)
    .WithDecision("EVENTS_PEACETIME_JUDGE_THE_CASE_AGAINST_OTTON_DECISION_LET_TOMMAS_ROAM_FREELY", decision => decision
        .WithConsequence(() => Career.Add(1))
        .WithConsequence(() => Tommas.Set(Status.IN_DANGER))
        .WithConsequence(() => Tommas.Add(-2)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_THE_CASE_AGAINST_OTTON_DECISION_HAVE_TOMMAS_TAKEN_INTO_CUSTODY", decision => decision
        .WithRequirement(() => ElBorne >= 0)
        .WithConsequence(() => Scheming.Add(1))
        .WithConsequence(() => Reputation.Add(-1))
        .WithConsequence(() => Tommas.Set(Status.IN_HIDING)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_THE_CASE_AGAINST_OTTON_DECISION_SEND_TOMMAS_OUT_OF_ANIZOTTE", decision => decision
        .WithRequirement(() => ElBorne == Status.THE_PROMISE)
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Career.Add(-1))
        .WithConsequence(() => Tommas.Set(Status.IN_HIDING)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_THE_CASE_AGAINST_OTTON_DECISION_CONVINCE_TOMMAS_TO_LEAVE_THE_LEGION", decision => decision
        .WithRequirement(() => Wealth >= 1)
        .WithRequirement(() => Tommas == Status.IN_HIDING)
        .WithConsequence(() => Wealth.Add(-1))
        .WithConsequence(() => Tommas.Set(Status.RESCUED)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_THE_PROCESSION_TO_THE_TREE")
                                                     .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                                                                  .WithConsequence(() => Church.Add(1)))
                                                     .Build());

            TheFestivalOfSilverTree = (new EventBuilder("EVENTS_PEACETIME_GENERAL_THE_FESTIVAL_OF_THE_SILVER_TREE")
    .WithDecision("EVENTS_PEACETIME_GENERAL_THE_FESTIVAL_OF_THE_SILVER_TREE_DECISION_LET_GLORIA_READ_HER_POEMS", decision => decision
        .WithConsequence(() => Unity.Add(-1))
        .WithConsequence(() => Gloria.Add(1))
        .WithConsequence(() => Stephan.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_GENERAL_THE_FESTIVAL_OF_THE_SILVER_TREE_DECISION_APPEAL_TO_MOTHER", decision => decision
        .WithRequirement(() => Lydia >= 3)
        .WithConsequence(() => Manipulation.Add(1))
        .WithConsequence(() => Unity.Add(1))
        .WithConsequence(() => Gloria.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_GENERAL_THE_FESTIVAL_OF_THE_SILVER_TREE_DECISION_INTERRUPT_GLORIA", decision => decision
        .WithConsequence(() => Unity.Add(-1))
        .WithConsequence(() => Gloria.Add(-1))
        .WithConsequence(() => Stephan.Add(1)))
    .Build());
            Events.Add(TheFestivalOfSilverTree);

            ARendezvousWithOctavia = (new EventBuilder("EVENTS_PEACETIME_JUDGE_A_RENDEZVOUS_WITH_OCTAVIA")
    .WithRequirement(() => PathOfTheNobleman == true)
    .WithRequirement(() => Octavia == Status.YOUR_PATRON || Octavia == Status.GROWN_CLOSE)
    .WithDecision("EVENTS_PEACETIME_JUDGE_A_RENDEZVOUS_WITH_OCTAVIA_DECISION_SHARE_YOUR_REVELATION", decision => decision
        .WithRequirement(() => Deaths >= 1 || Insight == true)
        .WithConsequence(() => Eloquence.Add(2))
        .WithConsequence(() => Willpower.Add(5)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_A_RENDEZVOUS_WITH_OCTAVIA_DECISION_INQUIRE_ABOUT_THIS_ARCANE_KNOWLEDGE", decision => decision
        .WithRequirement(() => Octavia == Status.GROWN_CLOSE)
        .WithConsequence(() => Theology.Add(2))
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Octavia.Add(1)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_A_RENDEZVOUS_WITH_OCTAVIA_DECISION_LOSE_YOURSELF_IN_PLEASURE", decision => decision
        .WithConsequence(() => Willpower.Add(10)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_A_RENDEZVOUS_WITH_OCTAVIA_DECISION_ASK_FOR_ASSISTANCE", decision => decision
        .WithRequirement(() => Octavia == Status.YOUR_PATRON)
        .WithConsequence(() => Career.Add(1))
        .WithConsequence(() => Reputation.Add(1)))
    .Build());
            Events.Add(ARendezvousWithOctavia);

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_THE_EMPERORS_HEIRS_IN_DANGER")
                                                     .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                                                                  .WithConsequence(() => Power.Add(-1))
                                                                  .WithConsequence(() => WealthOfMagra.Add(-1)))
                                                     .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_THE_TRAIL_OF_SORCERY")
    .WithRequirement(() => PathOfThePriest == true)
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_TRAIL_OF_SORCERY_DECISION_CHASE_THE_MAGE", decision => decision
        .WithRequirement(() => Jeanne != Status.WAVERING)
        .WithConsequence(() => Inquisition.Add(1))
        .WithConsequence(() => Jeanne.Add(1)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_TRAIL_OF_SORCERY_DECISION_HEAL_JEANNE", decision => decision
        .WithRequirement(() => Jeanne == Status.ZEALOUS)
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Inquisition.Add(1)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_TRAIL_OF_SORCERY_DECISION_CAPTURE_THE_MAGE", decision => decision
        .WithRequirement(() => Jeanne == Status.WAVERING)
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Inquisition.Add(1)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_TRAIL_OF_SORCERY_DECISION_HELP_JEANNE", decision => decision
        .WithRequirement(() => Jeanne != Status.ZEALOUS)
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Jeanne.Add(1)))
    .Build());

            Revelation = (new EventBuilder("EVENTS_PEACETIME_INQUISITOR_REVELATION")
    .WithRequirement(() => PathOfThePriest == true)
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_REVELATION_DECISION_GO_TO_FATHER_LENNART", decision => decision
        .WithConsequence(() => Tolerance.Add(1))
        .WithConsequence(() => Reputation.Add(-1))
        .WithConsequence(() => Lennart.Add(1)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_REVELATION_DECISION_GO_TO_JEANNE", decision => decision
        .WithConsequence(() => Tolerance.Add(-1))
        .WithConsequence(() => Reputation.Add(1))
        .WithConsequence(() => Jeanne.Add(1)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_REVELATION_DECISION_PROLONG_THE_REVELATION", decision => decision
        .WithRequirement(() => Willpower >= 0)
        .WithRequirement(() => TheLaTariRitual == true)
        .WithConsequence(() => Willpower.Add(-10))
        .WithConsequence(() => Scheming.Add(1))
        .WithConsequence(() => Valor.Add(1))
        .WithConsequence(() => Diplomacy.Add(1))
        .WithConsequence(() => Manipulation.Add(1)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_REVELATION_DECISION_GO_HOME", decision => decision
        .WithConsequence(() => Eloquence.Add(1))
        .WithConsequence(() => Reputation.Add(-1))
        .WithConsequence(() => Unity.Add(-1)))
    .Build());
            Events.Add(Revelation);

            AnInvitationToDinner = (new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_AN_INVITATION_TO_DINNER")
    .WithRequirement(() => PathOfTheLotless == true)
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_AN_INVITATION_TO_DINNER_DECISION_INVITE_SOPHIA_TO_THE_DINNER", decision => decision
        .WithRequirement(() => Sophia == Status.TRUSTING)
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Power.Add(1))
        .WithConsequence(() => WealthOfMagra.Add(-1))
        .WithConsequence(() => Unrest.Add(1))
        .WithConsequence(() => Unity.Add(1))
        .WithConsequence(() => Sophia.Add(1)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_AN_INVITATION_TO_DINNER_DECISION_AGREE_WITH_SOPHIA", decision => decision
        .WithRequirement(() => Sophia == Status.EMBITTERED)
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Power.Add(1))
        .WithConsequence(() => WealthOfMagra.Add(-1))
        .WithConsequence(() => Unrest.Add(1))
        .WithConsequence(() => Sophia.Add(1)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_AN_INVITATION_TO_DINNER_DECISION_GIVE_IN_TO_HER_DEMANDS", decision => decision
        .WithRequirement(() => Sophia == Status.MERCILESS)
        .WithConsequence(() => Power.Add(1))
        .WithConsequence(() => WealthOfMagra.Add(-1))
        .WithConsequence(() => Unrest.Add(1)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_AN_INVITATION_TO_DINNER_DECISION_REFUSE", decision => decision
        .WithConsequence(() => Willpower.Add(10))
        .WithConsequence(() => Unrest.Add(-1))
        .WithConsequence(() => Reputation.Add(1))
        .WithConsequence(() => Sophia.Add(-1)))
    .Build());
            Events.Add(AnInvitationToDinner);

            TheSearchForEvidence = (new EventBuilder("EVENTS_PEACETIME_JUDGE_THE_SEARCH_FOR_EVIDENCE")
    .WithRequirement(() => PathOfTheNobleman == true)
    .WithDecision("EVENTS_PEACETIME_JUDGE_THE_SEARCH_FOR_EVIDENCE_DECISION_ASK_TOMMAS_TO_HELP_YOU_GATHER_EVIDENCE", decision => decision
        .WithRequirement(() => Tommas >= 2)
        .WithRequirement(() => Tommas != Status.IN_HIDING)
        .WithConsequence(() => Tommas.Set(Status.IN_DANGER))
        .WithConsequence(() => Tommas.Add(-1))
        .WithConsequence(() => EvidenceAgainstOtton.Check()))
    .WithDecision("EVENTS_PEACETIME_JUDGE_THE_SEARCH_FOR_EVIDENCE_DECISION_ASK_OVERSEER_GAIUS_FOR_SUPPORT", decision => decision
        .WithRequirement(() => Reputation >= 7 || Tempest >= 2)
        .WithConsequence(() => ElBorne.Set(Status.BETRAYED))
        .WithConsequence(() => Tempest.Add(1))
        .WithConsequence(() => EvidenceAgainstOtton.Check()))
    .WithDecision("EVENTS_PEACETIME_JUDGE_THE_SEARCH_FOR_EVIDENCE_DECISION_SEARCH_FOR_EVIDENCE_ON_YOUR_OWN", decision => decision
        .WithConsequence(() => Valor.Add(1))
        .WithConsequence(() => Scheming.Add(1))
        .WithConsequence(() => Deaths.Add(1))
        .WithConsequence(() => EvidenceAgainstOtton.Check()))
    .WithDecision("EVENTS_PEACETIME_JUDGE_THE_SEARCH_FOR_EVIDENCE_DECISION_DONT_WASTE_YOUR_TIME", decision => decision
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Career.Add(1))
        .WithConsequence(() => Robert.Add(1)))
    .Build());
            Events.Add(TheSearchForEvidence);

            AConfession = (new EventBuilder("EVENTS_PEACETIME_INQUISITOR_A_CONFESSION")
    .WithRequirement(() => PathOfThePriest == true)
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_A_CONFESSION_DECISION_IT_WAS_AN_ILLUSION", decision => decision
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Jeanne.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_A_CONFESSION_DECISION_IT_WAS_A_MISTAKE", decision => decision
        .WithRequirement(() => Jeanne == Status.ZEALOUS)
        .WithConsequence(() => Willpower.Add(5)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_A_CONFESSION_DECISION_IT_WAS_A_MIRACLE", decision => decision
        .WithRequirement(() => Jeanne >= 2)
        .WithRequirement(() => Jeanne == Status.WAVERING)
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Jeanne.Add(1))
        .WithConsequence(() => Jeanne.Set(Status.GROWN_CLOSE)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_A_CONFESSION_DECISION_THESE_FEELINGS_ARE_REAL", decision => decision
        .WithRequirement(() => Eloquence >= 14)
        .WithRequirement(() => Jeanne >= 3)
        .WithRequirement(() => Jeanne == Status.STEADFAST_IN_FAITH)
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Jeanne.Add(1))
        .WithConsequence(() => Jeanne.Set(Status.GROWN_CLOSE)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_A_CONFESSION_DECISION_THIS_IS_A_TEST", decision => decision
        .WithRequirement(() => Eloquence >= 15)
        .WithRequirement(() => Jeanne >= 4)
        .WithRequirement(() => Jeanne == Status.ZEALOUS)
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Jeanne.Add(1))
        .WithConsequence(() => Jeanne.Set(Status.GROWN_CLOSE)))
    .Build());
            Events.Add(AConfession);

            GettingEven = (new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_GETTING_EVEN")
                .WithRequirement(() => PathOfTheLotless == true)
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_GETTING_EVEN_DECISION_ASK_HER_TO_EXPLAIN_HERSELF", decision => decision
                    .WithRequirement(() => Scheming >= 14)
                    .WithRequirement(() => Sophia >= 3)
                    .WithConsequence(() => Network.Add(1))
                    .WithConsequence(() => Otton.Set(Status.DISHONORED))
                    .WithConsequence(() => Sophia.Add(1)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_GETTING_EVEN_DECISION_AGREE", decision => decision
                    .WithRequirement(() => Scheming >= 16)
                    .WithRequirement(() => Willpower >= 0)
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Network.Add(1))
                    .WithConsequence(() => Otton.Set(Status.DISHONORED))
                    .WithConsequence(() => Sophia.Add(1)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_GETTING_EVEN_DECISION_REFUSE", decision => decision
                    .WithConsequence(() => Willpower.Add(5))
                    .WithConsequence(() => Sophia.Add(-1)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_GETTING_EVEN_DECISION_REFUSE_AND_HAVE_SOPHIA_SHADOWED", decision => decision
                    .WithRequirement(() => Scheming >= 12)
                    .WithRequirement(() => Willpower >= 0)
                    .WithConsequence(() => Scheming.Add(1))
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Network.Add(1))
                    .WithConsequence(() => Sophia.Add(-1)))
                .Build());
            Events.Add(GettingEven);

            ARealmUnknown = (new EventBuilder("EVENTS_PEACETIME_JUDGE_A_REALM_UNKNOWN")
    .WithRequirement(() => PathOfTheNobleman == true)
    .WithDecision("EVENTS_PEACETIME_JUDGE_A_REALM_UNKNOWN_DECISION_KEEP_THEIR_SECRET", decision => decision
        .WithConsequence(() => Theology.Add(1))
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Justice.Add(-1))
        .WithConsequence(() => Octavia.Add(1))
        .WithConsequence(() => ElBorne.Add(-1))
        .WithConsequence(() => TheLaTariRitual.Check()))
    .WithDecision("EVENTS_PEACETIME_JUDGE_A_REALM_UNKNOWN_DECISION_BAN_THE_CIRCLE_OF_LA_TARI", decision => decision
        .WithConsequence(() => Eloquence.Add(1))
        .WithConsequence(() => Theology.Add(1))
        .WithConsequence(() => Justice.Add(1))
        .WithConsequence(() => Reputation.Add(-1))
        .WithConsequence(() => Octavia.Add(-2)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_A_REALM_UNKNOWN_DECISION_CONVINCE_OCTAVIA_TO_DISBAND_THE_CIRCLE", decision => decision
        .WithRequirement(() => Manipulation >= 10)
        .WithRequirement(() => Octavia >= 2)
        .WithConsequence(() => Manipulation.Add(1))
        .WithConsequence(() => Justice.Add(1))
        .WithConsequence(() => Octavia.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_A_REALM_UNKNOWN_DECISION_LEGITIMIZE_THE_CIRCLE", decision => decision
        .WithRequirement(() => Willpower >= 0)
        .WithRequirement(() => Diplomacy >= 15 || PatronageOfThePowerful == true)
        .WithConsequence(() => Diplomacy.Add(1))
        .WithConsequence(() => Theology.Add(1))
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Wealth.Add(1))
        .WithConsequence(() => Octavia.Add(1)))
    .Build());
            Events.Add(ARealmUnknown);

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_THE_LAST_STRAW")
                                                     .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                                                                  .WithConsequence(() => Order.Add(-1))
                                                                  .WithConsequence(() => Power.Add(1))
                                                                  .WithConsequence(() => WealthOfMagra.Add(-1)))
                                                     .Build());

            ThePatriarchsSermon = (new EventBuilder("EVENTS_PEACETIME_INQUISITOR_THE_PATRIARCHS_SERMON")
    .WithRequirement(() => PathOfThePriest == true)
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_PATRIARCHS_SERMON_DECISION_KISS_THE_PATRIARCHS_HAND", decision => decision
        .WithConsequence(() => Diplomacy.Add(1))
        .WithConsequence(() => Church.Add(-1))
        .WithConsequence(() => Tolerance.Add(-2))
        .WithConsequence(() => Inquisition.Add(-2))
        .WithConsequence(() => Reputation.Add(1)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_PATRIARCHS_SERMON_DECISION_REFUSE", decision => decision
        .WithConsequence(() => Eloquence.Add(1))
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Deaths.Add(1))
        .WithConsequence(() => Tolerance.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_PATRIARCHS_SERMON_DECISION_ACCUSE_CASSIUS", decision => decision
        .WithRequirement(() => Willpower >= 0)
        .WithRequirement(() => Ulrich == Status.MASTER)
        .WithConsequence(() => Valor.Add(1))
        .WithConsequence(() => Willpower.Add(-10))
        .WithConsequence(() => Inquisition.Add(1))
        .WithConsequence(() => Reputation.Add(1)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_PATRIARCHS_SERMON_DECISION_RELY_ON_THE_NEW_BELIEVERS_FOR_SUPPORT", decision => decision
        .WithRequirement(() => TheNewFaithPersecuted == false)
        .WithRequirement(() => Lennart >= 2)
        .WithRequirement(() => Lennart != Status.PENANCE)
        .WithConsequence(() => Church.Add(1))
        .WithConsequence(() => Tolerance.Add(1))
        .WithConsequence(() => Inquisition.Add(-1)))
    .Build());
            Events.Add(ThePatriarchsSermon);

            TheHardGoodbye = (new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_THE_HARD_GOODBYE")
                .WithRequirement(() => PathOfTheLotless == true)
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_THE_HARD_GOODBYE_DECISION_WISH_HER_A_SAFE_JOURNEY", decision => decision
                    .WithConsequence(() => Willpower.Add(5))
                    .WithConsequence(() => Sophia.Add(-1)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_THE_HARD_GOODBYE_DECISION_SWEAR_TO_REMAIN_LOYAL_TO_HER_NO_MATTER_WHAT", decision => decision
                    .WithRequirement(() => Sophia >= 4)
                    .WithRequirement(() => Sophia == Status.EMBITTERED)
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Sophia.Set(Status.GROWN_CLOSE)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_THE_HARD_GOODBYE_DECISION_PROMISE_TO_PROTECT_HER", decision => decision
                    .WithRequirement(() => Sophia >= 4)
                    .WithRequirement(() => Sophia != Status.MERCILESS)
                    .WithConsequence(() => Willpower.Add(5))
                    .WithConsequence(() => Sophia.Add(1)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_THE_HARD_GOODBYE_DECISION_TELL_HER_HOW_YOU_FEEL", decision => decision
                    .WithRequirement(() => Sophia >= 4)
                    .WithRequirement(() => Sophia == Status.MERCILESS)
                    .WithConsequence(() => Willpower.Add(5)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_THE_HARD_GOODBYE_DECISION_CONFESS_YOUR_LOVE_FOR_HER", decision => decision
                    .WithRequirement(() => Sophia >= 3)
                    .WithRequirement(() => Sophia == Status.TRUSTING)
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Sophia.Set(Status.GROWN_CLOSE))
                    .WithConsequence(() => Sophia.Add(1)))
                .Build());
            Events.Add(TheHardGoodbye);

            Events.Add(new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_THE_LEGION_IN_THE_CITY")
                .WithRequirement(() => PathOfTheLotless == true)
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_THE_LEGION_IN_THE_CITY_DECISION_USE_TOMMAS", decision => decision
                    .WithRequirement(() => BondOfFriendship == true)
                    .WithConsequence(() => Power.Add(1))
                    .WithConsequence(() => Unrest.Add(2))
                    .WithConsequence(() => Network.Add(-2))
                    .WithConsequence(() => Reputation.Add(-1))
                    .WithConsequence(() => Tommas.Set(Status.EXILED)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_THE_LEGION_IN_THE_CITY_DECISION_CONVINCE_TOMMAS_TO_COOPERATE", decision => decision
                    .WithRequirement(() => Tommas >= 2)
                    .WithRequirement(() => Tommas != Status.SEVERED_ALL_TIES)
                    .WithConsequence(() => Order.Add(1))
                    .WithConsequence(() => Unrest.Add(-2))
                    .WithConsequence(() => Network.Add(2))
                    .WithConsequence(() => Unity.Add(-1))
                    .WithConsequence(() => Deaths.Add(1)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_THE_LEGION_IN_THE_CITY_DECISION_INCITE_THE_COMMON_PEOPLE_TO_RIOT_AGAINST_THEM", decision => decision
                    .WithConsequence(() => Eloquence.Add(1))
                    .WithConsequence(() => Order.Add(-1))
                    .WithConsequence(() => Unrest.Add(1))
                    .WithConsequence(() => Network.Add(-1)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_THE_LEGION_IN_THE_CITY_DECISION_DENOUNCE_THE_REBELLIOUS_NOBLES_TO_TOMMAS", decision => decision
                    .WithRequirement(() => Otton == Status.DISHONORED)
                    .WithRequirement(() => Tommas != Status.SEVERED_ALL_TIES)
                    .WithConsequence(() => Unrest.Add(-1))
                    .WithConsequence(() => Network.Add(1))
                    .WithConsequence(() => Reputation.Add(1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_USUAL_SUSPECTS")
                .WithRequirement(() => PathOfTheLotless == true)
                .WithRequirement(() => Felipe != Status.SAW_YOUR_LOYALTY)
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_USUAL_SUSPECTS_DECISION_PROVE_YOUR_LOYALTY", decision => decision
                    .WithRequirement(() => SophiaHasTheGunpowder == false)
                    .WithRequirement(() => Egmont != Status.SECRET_PLOT)
                    .WithRequirement(() => ElVerman != Status.MADE_A_DEAL)
                    .WithConsequence(() => Willpower.Add(10))
                    .WithConsequence(() => Felipe.Add(1)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_USUAL_SUSPECTS_DECISION_BETRAY_EL_VERMAN", decision => decision
                    .WithRequirement(() => ElVerman == Status.MADE_A_DEAL)
                    .WithConsequence(() => Willpower.Add(-10))
                    .WithConsequence(() => ElVerman.Set(Status.BETRAYED))
                    .WithConsequence(() => Felipe.Add(-4)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_USUAL_SUSPECTS_DECISION_BETRAY_EGMONT", decision => decision
                    .WithRequirement(() => Egmont == Status.SECRET_PLOT)
                    .WithConsequence(() => Willpower.Add(-10))
                    .WithConsequence(() => Unrest.Add(-1))
                    .WithConsequence(() => Egmont.Set(Status.IN_JEOPARDY))
                    .WithConsequence(() => Felipe.Add(-4)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_USUAL_SUSPECTS_DECISION_BETRAY_SOPHIA", decision => decision
                    .WithRequirement(() => SophiaHasTheGunpowder == true)
                    .WithConsequence(() => Willpower.Add(-10))
                    .WithConsequence(() => Unrest.Add(-1))
                    .WithConsequence(() => Sophia.Set(Status.BETRAYED))
                    .WithConsequence(() => Sophia.Add(-2))
                    .WithConsequence(() => Felipe.Add(-4)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_USUAL_SUSPECTS_DECISION_DENY_YOUR_GUILT", decision => decision
                    .WithRequirement(() => Manipulation >= 16)
                    .WithConsequence(() => Willpower.Add(-10))
                    .WithConsequence(() => Felipe.Add(1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_AN_URGENT_DEAL")
    .WithRequirement(() => PathOfTheLotless == true)
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_AN_URGENT_DEAL_DECISION_FULFILL_HIS_REQUEST", decision => decision
        .WithConsequence(() => Theology.Add(1))
        .WithConsequence(() => Church.Add(1))
        .WithConsequence(() => Unrest.Add(2))
        .WithConsequence(() => Network.Add(-2))
        .WithConsequence(() => Reputation.Add(-2)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_AN_URGENT_DEAL_DECISION_REPORT_LENNART_TO_FELIPE", decision => decision
        .WithConsequence(() => Church.Add(-1))
        .WithConsequence(() => Unrest.Add(-2))
        .WithConsequence(() => Network.Add(2))
        .WithConsequence(() => Reputation.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_AN_URGENT_DEAL_DECISION_TAKE_ADVANTAGE_OF_HIS_SERMON_TO_RECRUIT_PEOPLE_INTO_THE_LAST_STRAW", decision => decision
        .WithRequirement(() => Eloquence >= 12)
        .WithRequirement(() => Willpower >= 0)
        .WithConsequence(() => Eloquence.Add(1))
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Unrest.Add(1))
        .WithConsequence(() => Network.Add(1))
        .WithConsequence(() => Reputation.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_AN_URGENT_DEAL_DECISION_CONTACT_THE_INQUISITION", decision => decision
        .WithRequirement(() => Theology >= 12)
        .WithConsequence(() => Theology.Add(1))
        .WithConsequence(() => Church.Add(-1))
        .WithConsequence(() => Unrest.Add(-1))
        .WithConsequence(() => Network.Add(-1))
        .WithConsequence(() => Reputation.Add(1)))
    .Build());

            ThreatsAndPromises = (new EventBuilder("EVENTS_PEACETIME_JUDGE_THREATS_AND_PROMISES")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithDecision("EVENTS_PEACETIME_JUDGE_THREATS_AND_PROMISES_DECISION_PUT_OTTON_AT_EASE", decision => decision
                    .WithRequirement(() => Manipulation >= 12 || Otton >= 0)
                    .WithConsequence(() => Manipulation.Add(1))
                    .WithConsequence(() => Otton.Add(1)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_THREATS_AND_PROMISES_DECISION_RETALIATE_AGAINST_OTTON", decision => decision
                    .WithRequirement(() => Valor >= 13)
                    .WithRequirement(() => Willpower >= 0)
                    .WithConsequence(() => Valor.Add(1))
                    .WithConsequence(() => Deaths.Add(1))
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Reputation.Add(1)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_THREATS_AND_PROMISES_DECISION_SEEK_SIR_EL_VERMANS_PROTECTION", decision => decision
                    .WithRequirement(() => ElVerman >= 2 || PatronageOfThePowerful == true)
                    .WithConsequence(() => Diplomacy.Add(1))
                    .WithConsequence(() => ElVerman.Add(-1)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_THREATS_AND_PROMISES_DECISION_GIVE_OTTON_YOUR_WORD", decision => decision
                    .WithConsequence(() => Career.Add(-1))
                    .WithConsequence(() => Justice.Add(-1)))
                .Build());
            Events.Add(ThreatsAndPromises);

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_NOBLEMANS_HONOR")
    .WithRequirement(() => PathOfTheNobleman == true)
    .WithDecision("EVENTS_PEACETIME_JUDGE_NOBLEMANS_HONOR_DECISION_FINE_EL_CORVIO", decision => decision
        .WithConsequence(() => Diplomacy.Add(1))
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Career.Add(1))
        .WithConsequence(() => Justice.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_NOBLEMANS_HONOR_DECISION_SENTENCE_EL_CORVIO_TO_CAPITAL_PUNISHMENT", decision => decision
        .WithRequirement(() => Octavia >= 0)
        .WithRequirement(() => Octavia == Status.YOUR_PATRON || Octavia == Status.GROWN_CLOSE)
        .WithConsequence(() => Career.Add(-1))
        .WithConsequence(() => Justice.Add(1))
        .WithConsequence(() => Wealth.Add(1)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_NOBLEMANS_HONOR_DECISION_LEGALIZE_DUELS", decision => decision
        .WithRequirement(() => Diplomacy >= 15)
        .WithRequirement(() => Career >= 6)
        .WithRequirement(() => ElBorne != Status.THE_PROMISE)
        .WithConsequence(() => Power.Add(-1))
        .WithConsequence(() => Order.Add(-1))
        .WithConsequence(() => Career.Add(2))
        .WithConsequence(() => Justice.Add(-3))
        .WithConsequence(() => ElBorne.Add(-2))
        .WithConsequence(() => PatronageOfThePowerful.Check()))
    .WithDecision("EVENTS_PEACETIME_JUDGE_NOBLEMANS_HONOR_DECISION_PRONOUNCE_THE_COURT_OF_HONOR_ILLEGAL", decision => decision
        .WithRequirement(() => Diplomacy >= 15)
        .WithRequirement(() => Justice >= 6)
        .WithRequirement(() => ElBorne == Status.THE_PROMISE)
        .WithConsequence(() => Power.Add(1))
        .WithConsequence(() => Order.Add(1))
        .WithConsequence(() => Career.Add(-2))
        .WithConsequence(() => Justice.Add(2))
        .WithConsequence(() => Reputation.Add(-1))
        .WithConsequence(() => CourtOfHonorBanned.Check()))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_THE_HUNT_FOR_TOMMAS")
    .WithRequirement(() => PathOfTheNobleman == false)
    .WithRequirement(() => Tommas != Status.SEVERED_ALL_TIES)
    .WithRequirement(() => Tommas != Status.EXILED)
    .WithRequirement(() => Otton != Status.DISHONORED)
    .WithDecision("EVENTS_PEACETIME_GENERAL_THE_HUNT_FOR_TOMMAS_DECISION_DONT_GET_INVOLVED", decision => decision
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Tommas.Set(Status.TRUE_DEATH)))
    .WithDecision("EVENTS_PEACETIME_GENERAL_THE_HUNT_FOR_TOMMAS_DECISION_HIDE_TOMMAS_IN_THE_TEMPLE", decision => decision
        .WithRequirement(() => PathOfThePriest == true)
        .WithConsequence(() => Scheming.Add(1))
        .WithConsequence(() => Deaths.Add(1))
        .WithConsequence(() => Inquisition.Add(-1))
        .WithConsequence(() => Tommas.Set(Status.RESCUED)))
    .WithDecision("EVENTS_PEACETIME_GENERAL_THE_HUNT_FOR_TOMMAS_DECISION_GET_TOMMAS_OUT_OF_THE_CITY", decision => decision
        .WithRequirement(() => PathOfTheLotless == true)
        .WithRequirement(() => Wealth >= 1)
        .WithConsequence(() => Network.Add(-1))
        .WithConsequence(() => Wealth.Add(-1))
        .WithConsequence(() => Tommas.Set(Status.RESCUED)))
    .WithDecision("EVENTS_PEACETIME_GENERAL_THE_HUNT_FOR_TOMMAS_DECISION_TURN_TO_YOUR_BENEFACTOR_FOR_AID", decision => decision
        .WithRequirement(() => Felipe >= 3 || Milanidas == Status.GRATEFUL)
        .WithConsequence(() => Diplomacy.Add(1))
        .WithConsequence(() => Tommas.Set(Status.RESCUED)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_THE_HUNT_FOR_TOMMAS")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithRequirement(() => Tommas != Status.RESCUED)
                .WithDecision("EVENTS_PEACETIME_JUDGE_THE_HUNT_FOR_TOMMAS_DECISION_DONT_GET_INVOLVED", decision => decision
                    .WithConsequence(() => Willpower.Add(5))
                    .WithConsequence(() => Tommas.Set(Status.TRUE_DEATH)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_THE_HUNT_FOR_TOMMAS_DECISION_PROTECT_TOMMAS", decision => decision
                    .WithRequirement(() => Valor >= 12)
                    .WithConsequence(() => Valor.Add(1))
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Deaths.Add(1))
                    .WithConsequence(() => Reputation.Add(-1))
                    .WithConsequence(() => Tommas.Set(Status.RESCUED))
                    .WithConsequence(() => Tommas.Add(1)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_THE_HUNT_FOR_TOMMAS_DECISION_ELIMINATE_OTTONS_HENCHMEN", decision => decision
                    .WithRequirement(() => Tommas == Status.IN_HIDING)
                    .WithConsequence(() => Career.Add(-2))
                    .WithConsequence(() => Tommas.Set(Status.RESCUED))
                    .WithConsequence(() => Tommas.Add(1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_EL_FERROS_LIST")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithDecision("EVENTS_PEACETIME_JUDGE_EL_FERROS_LIST_DECISION_PROTECT_THE_PEOPLE_ON_THE_LIST", decision => decision
                    .WithRequirement(() => Willpower >= 0)
                    .WithRequirement(() => Valor >= 12)
                    .WithConsequence(() => Valor.Add(1))
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Career.Add(-2))
                    .WithConsequence(() => Justice.Add(2))
                    .WithConsequence(() => Reputation.Add(-1))
                    .WithConsequence(() => Unity.Add(1)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_EL_FERROS_LIST_DECISION_CONDUCT_AN_INVESTIGATION", decision => decision
                    .WithRequirement(() => Wealth >= 1)
                    .WithRequirement(() => Scheming >= 10)
                    .WithConsequence(() => Scheming.Add(1))
                    .WithConsequence(() => Power.Add(-1))
                    .WithConsequence(() => Career.Add(1))
                    .WithConsequence(() => Justice.Add(1))
                    .WithConsequence(() => Wealth.Add(-1)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_EL_FERROS_LIST_DECISION_OBEY_THE_SECRET_CHANCELLERY", decision => decision
                    .WithConsequence(() => Power.Add(-1))
                    .WithConsequence(() => Career.Add(2))
                    .WithConsequence(() => Justice.Add(-2))
                    .WithConsequence(() => Unity.Add(-2))
                    .WithConsequence(() => Robert.Add(-1))
                    .WithConsequence(() => PatronageOfThePowerful.Check()))
                .WithDecision("EVENTS_PEACETIME_JUDGE_EL_FERROS_LIST_DECISION_SHELTER_THE_SUSPECTS", decision => decision
                    .WithRequirement(() => Manipulation >= 10)
                    .WithRequirement(() => GloriasSecret == true)
                    .WithConsequence(() => Justice.Add(-1))
                    .WithConsequence(() => Unity.Add(1))
                    .WithConsequence(() => Wealth.Add(1))
                    .WithConsequence(() => Gloria.Add(1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_THE_REBEL")
                .WithRequirement(() => Stephan == Status.SECRET_PLOT)
                .WithDecision("EVENTS_PEACETIME_GENERAL_THE_REBEL_DECISION_INFLUENCE_GLORIA_THROUGH_MOTHER", decision => decision
                    .WithConsequence(() => Manipulation.Add(1))
                    .WithConsequence(() => Unity.Add(-1))
                    .WithConsequence(() => Gloria.Set(Status.BETHROTHED))
                    .WithConsequence(() => Gloria.Add(-1)))
                .WithDecision("EVENTS_PEACETIME_GENERAL_THE_REBEL_DECISION_INFILTRATE_THE_SECRET_SOCIETY", decision => decision
                    .WithRequirement(() => PathOfTheLotless == true)
                    .WithRequirement(() => Scheming >= 12)
                    .WithConsequence(() => Scheming.Add(1))
                    .WithConsequence(() => Unrest.Add(-1))
                    .WithConsequence(() => Gloria.Set(Status.BETHROTHED))
                    .WithConsequence(() => Gloria.Add(-2)))
                .WithDecision("EVENTS_PEACETIME_GENERAL_THE_REBEL_DECISION_PERSUADE_GLORIA_TO_ACCEPT_HER_FATE", decision => decision
                    .WithRequirement(() => GloriasSecret == true)
                    .WithConsequence(() => Theology.Add(1))
                    .WithConsequence(() => Manipulation.Add(1))
                    .WithConsequence(() => Gloria.Set(Status.BETHROTHED))
                    .WithConsequence(() => Gloria.Add(1)))
                .WithDecision("EVENTS_PEACETIME_GENERAL_THE_REBEL_DECISION_REJECT_THE_PLAN", decision => decision
                    .WithConsequence(() => Gloria.Set(null))
                    .WithConsequence(() => Stephan.Add(-3))
                    .WithConsequence(() => Gloria.Add(1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_THE_LESSER_EVIL")
                .WithRequirement(() => Gloria == Status.SECRET_PLOT)
                .WithDecision("EVENTS_PEACETIME_GENERAL_THE_LESSER_EVIL_DECISION_PUT_PRESSURE_ON_FATHER", decision => decision
                    .WithConsequence(() => Unity.Add(-2))
                    .WithConsequence(() => Gloria.Set(Status.AT_HOME))
                    .WithConsequence(() => Stephan.Set(Status.BAD_BLOOD))
                    .WithConsequence(() => Stephan.Add(-2))
                    .WithConsequence(() => Gloria.Add(2))
                    .WithConsequence(() => Robert.Add(-2)))
                .WithDecision("EVENTS_PEACETIME_GENERAL_THE_LESSER_EVIL_DECISION_CHALLENGE_STEPHAN_TO_A_DUEL", decision => decision
                    .WithRequirement(() => PathOfTheNobleman == true)
                    .WithRequirement(() => CourtOfHonorBanned == false)
                    .WithConsequence(() => Stephan.Set(Status.DUEL_IMPENDING))
                    .WithConsequence(() => Gloria.Set(Status.AT_HOME))
                    .WithConsequence(() => Gloria.Add(2)))
                .WithDecision("EVENTS_PEACETIME_GENERAL_THE_LESSER_EVIL_DECISION_THREATEN_STEPHAN", decision => decision
                    .WithRequirement(() => StephansDisgrace == true)
                    .WithConsequence(() => Unity.Add(-1))
                    .WithConsequence(() => Gloria.Set(Status.AT_HOME))
                    .WithConsequence(() => Stephan.Set(Status.BAD_BLOOD))
                    .WithConsequence(() => Stephan.Add(-3))
                    .WithConsequence(() => Gloria.Add(2)))
                .WithDecision("EVENTS_PEACETIME_GENERAL_THE_LESSER_EVIL_DECISION_SAY_NOTHING", decision => decision
                    .WithConsequence(() => Willpower.Add(10))
                    .WithConsequence(() => Gloria.Set(Status.BETHROTHED))
                    .WithConsequence(() => Gloria.Add(-3)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_A_BANNER_YEAR")
                .WithRequirement(() => ProfitableBusiness == true)
                                                    .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                                                                 .WithConsequence(() => Wealth.Add(3)))
                                                    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_THE_ARCHDUKE_RELENTS")
                                                     .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                                                                  .WithConsequence(() => WealthOfMagra.Add(1))
                                                                  .WithConsequence(() => Power.Add(1)))
                                                     .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_A_SINNERS_CONFESSION")
                .WithRequirement(() => PathOfThePriest == true)
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_A_SINNERS_CONFESSION_DECISION_JUDGE_NATHAN_AND_FIND_HIM_GUILTY", decision => decision
        .WithConsequence(() => Inquisition.Add(2))
        .WithConsequence(() => Tolerance.Add(-2))
        .WithConsequence(() => Unity.Add(-1))
        .WithConsequence(() => Reputation.Add(-2))
        .WithConsequence(() => Nathan.Add(-2))
        .WithConsequence(() => EvidenceAgainstCassius.Check()))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_A_SINNERS_CONFESSION_DECISION_SET_NATHAN_FREE", decision => decision
        .WithRequirement(() => Scheming >= 10)
        .WithConsequence(() => Scheming.Add(1))
        .WithConsequence(() => Manipulation.Add(1))
        .WithConsequence(() => Inquisition.Add(-1))
        .WithConsequence(() => Tolerance.Add(1))
        .WithConsequence(() => Reputation.Add(-1))
        .WithConsequence(() => Nathan.Add(1)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_A_SINNERS_CONFESSION_DECISION_GUIDE_NATHAN_TO_THE_RIGHT_PATH", decision => decision
        .WithRequirement(() => NathansAdmonition == true)
        .WithRequirement(() => Theology >= 13)
        .WithRequirement(() => Willpower >= 0)
        .WithConsequence(() => Theology.Add(1))
        .WithConsequence(() => Manipulation.Add(1))
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Reputation.Add(-1))
        .WithConsequence(() => Nathan.Add(1))
        .WithConsequence(() => Nathan.Set(Status.RECRUITED)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_THE_RENEGADE")
                .WithRequirement(() => PathOfThePriest == true)
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_RENEGADE_DECISION_MAKE_A_DEAL_WITH_MARK", decision => decision
                    .WithRequirement(() => Tolerance >= 4)
                    .WithRequirement(() => Eloquence >= 13)
                    .WithConsequence(() => Eloquence.Add(1))
                    .WithConsequence(() => Inquisition.Add(-2))
                    .WithConsequence(() => Tolerance.Add(2))
                    .WithConsequence(() => EvidenceAgainstCassius.Check()))
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_RENEGADE_DECISION_LURE_MARK_INTO_A_TRAP", decision => decision
                    .WithRequirement(() => Nathan == Status.RECRUITED)
                    .WithConsequence(() => Scheming.Add(1))
                    .WithConsequence(() => Inquisition.Add(2))
                    .WithConsequence(() => Tolerance.Add(-1))
                    .WithConsequence(() => Reputation.Add(-1))
                    .WithConsequence(() => EvidenceAgainstCassius.Check())
                    .WithConsequence(() => Mark.Set(Status.IMPRISONED)))
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_RENEGADE_DECISION_CAPTURE_MARK", decision => decision
                    .WithConsequence(() => Valor.Add(1))
                    .WithConsequence(() => Deaths.Add(1))
                    .WithConsequence(() => Inquisition.Add(1))
                    .WithConsequence(() => Tolerance.Add(1))
                    .WithConsequence(() => EvidenceAgainstCassius.Check())
                    .WithConsequence(() => Mark.Set(Status.IMPRISONED)))
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_RENEGADE_DECISION_RETURN_TO_JEANNE", decision => decision
                    .WithConsequence(() => Inquisition.Add(-1))
                    .WithConsequence(() => Tolerance.Add(-1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_THE_SENTENCE")
                .WithRequirement(() => PathOfThePriest == true)
                .WithRequirement(() => Mark == Status.IMPRISONED)
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_SENTENCE_DECISION_SEND_FOR_JEANNE_AND_FATHER_LENNART", decision => decision
                    .WithRequirement(() => CollapseOfTheInquisition == false)
                    .WithRequirement(() => Lennart != Status.PENANCE)
                    .WithRequirement(() => Eloquence >= 15 || Jeanne >= 3)
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Order.Add(1))
                    .WithConsequence(() => Inquisition.Add(2))
                    .WithConsequence(() => Tolerance.Add(2))
                    .WithConsequence(() => Reputation.Add(1))
                    .WithConsequence(() => Mark.Set(Status.TRUE_DEATH)))
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_SENTENCE_DECISION_SEND_FOR_ULRICH", decision => decision
                    .WithRequirement(() => Willpower >= 0)
                    .WithRequirement(() => Ulrich == Status.MASTER)
                    .WithConsequence(() => Eloquence.Add(1))
                    .WithConsequence(() => Willpower.Add(-10))
                    .WithConsequence(() => Inquisition.Add(1))
                    .WithConsequence(() => Tolerance.Add(-1))
                    .WithConsequence(() => Reputation.Add(1))
                    .WithConsequence(() => Mark.Set(Status.TRUE_DEATH)))
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_SENTENCE_DECISION_RELEASE_MARK_FROM_CAPTIVITY", decision => decision
                    .WithRequirement(() => Theology >= 15 || Manipulation >= 10)
                    .WithConsequence(() => Theology.Add(1))
                    .WithConsequence(() => Jeanne.Add(-1))
                    .WithConsequence(() => Mark.Set(Status.FREED)))
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_SENTENCE_DECISION_HAND_MARK_OVER", decision => decision
                    .WithConsequence(() => Inquisition.Add(-2))
                    .WithConsequence(() => Tolerance.Add(-2))
                    .WithConsequence(() => Mark.Set(Status.TRUE_DEATH)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_A_DANGEROUS_HAUL")
                .WithRequirement(() => PathOfTheLotless == true)
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_A_DANGEROUS_HAUL_DECISION_REPORT_THIS_TO_FELIPE", decision => decision
        .WithConsequence(() => Power.Add(-1))
        .WithConsequence(() => Unrest.Add(-1))
        .WithConsequence(() => Network.Add(1))
        .WithConsequence(() => Egmont.Set(Status.ARRESTED))
        .WithConsequence(() => Felipe.Add(1)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_A_DANGEROUS_HAUL_DECISION_INFORM_EL_VERMAN_ABOUT_THIS", decision => decision
        .WithRequirement(() => ElVerman == Status.MADE_A_DEAL)
        .WithConsequence(() => Network.Add(1))
        .WithConsequence(() => Egmont.Set(Status.IN_DANGER))
        .WithConsequence(() => ElVerman.Add(1)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_A_DANGEROUS_HAUL_DECISION_KEEP_EGMONTS_SECRETS_SAFE", decision => decision
        .WithRequirement(() => Network <= 6)
        .WithRequirement(() => Egmont == Status.SECRET_PLOT)
        .WithConsequence(() => Unrest.Add(1))
        .WithConsequence(() => Network.Add(-1))
        .WithConsequence(() => Egmont.Add(2)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_A_DANGEROUS_HAUL_DECISION_SEIZE_THE_GUNS_FOR_YOURSELF", decision => decision
        .WithRequirement(() => StashOfGunpowder == true)
        .WithRequirement(() => Scheming >= 15)
        .WithConsequence(() => Power.Add(-1))
        .WithConsequence(() => Egmont.Set(Status.ARRESTED))
        .WithConsequence(() => StockpileOfArms.Check()))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_JUSTICE_FOR_ALL")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithDecision("EVENTS_PEACETIME_JUDGE_JUSTICE_FOR_ALL_DECISION_PROVOKE_THE_ARKNIAN", decision => decision
                    .WithRequirement(() => Willpower >= 0)
                    .WithRequirement(() => Manipulation >= 10 || Eloquence >= 12)
                    .WithConsequence(() => Manipulation.Add(1))
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Deaths.Add(1))
                    .WithConsequence(() => Career.Add(2))
                    .WithConsequence(() => Justice.Add(1))
                    .WithConsequence(() => Reputation.Add(1)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_JUSTICE_FOR_ALL_DECISION_ACQUIT_HIM_AND_CLEAR_HIM_OF_ALL_CHARGES", decision => decision
                    .WithConsequence(() => Career.Add(-2))
                    .WithConsequence(() => Justice.Add(-2))
                    .WithConsequence(() => Wealth.Add(1))
                    .WithConsequence(() => ElBorne.Add(-2))
                    .WithConsequence(() => ProtectorOfThePeople.Check()))
                .WithDecision("EVENTS_PEACETIME_JUDGE_JUSTICE_FOR_ALL_DECISION_TURN_TO_OCTAVIA_FOR_AID", decision => decision
                    .WithRequirement(() => Milanidas >= 0)
                    .WithRequirement(() => Octavia == Status.GROWN_CLOSE || Octavia == Status.YOUR_PATRON)
                    .WithConsequence(() => Career.Add(1))
                    .WithConsequence(() => Justice.Add(-1))
                    .WithConsequence(() => Tempest.Add(1)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_JUSTICE_FOR_ALL_DECISION_FIND_HIM_GUILTY_AS_THE_LAW_DEMANDS", decision => decision
                    .WithRequirement(() => ElBorne == Status.THE_PROMISE)
                    .WithRequirement(() => Reputation >= 7 || PatronageOfThePowerful == true)
                    .WithConsequence(() => Diplomacy.Add(1))
                    .WithConsequence(() => Order.Add(1))
                    .WithConsequence(() => Career.Add(-1))
                    .WithConsequence(() => Justice.Add(2)))
                    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_DEATHBED")
                .WithDecision("EVENTS_PEACETIME_GENERAL_DEATHBED_DECISION_ACCEPT_THIS_LOSS", decision => decision
                    .WithConsequence(() => Willpower.Add(-10))
                    .WithConsequence(() => Unity.Add(-2))
                    .WithConsequence(() => Robert.Add(-1))
                    .WithConsequence(() => Gloria.Add(-1))
                    .WithConsequence(() => Nathan.Add(-1))
                    .WithConsequence(() => Lydia.Set(Status.SUCCUMBED_TO_ILLNESS)))
                .WithDecision("EVENTS_PEACETIME_GENERAL_DEATHBED_DECISION_SHARE_YOUR_STRENGTH_WITH_MOTHER", decision => decision
                    .WithRequirement(() => Unity >= 8)
                    .WithRequirement(() => Willpower >= 0)
                    .WithConsequence(() => Willpower.Add(-10))
                    .WithConsequence(() => Unity.Add(1))
                    .WithConsequence(() => MotherRecovers.Check()))
                .WithDecision("EVENTS_PEACETIME_GENERAL_DEATHBED_DECISION_UNITE_THE_FAMILY", decision => decision
                    .WithRequirement(() => Unity >= 7)
                    .WithRequirement(() => Stephan != Status.SECRET_PLOT)
                    .WithRequirement(() => Gloria != Status.AT_HOME)
                    .WithRequirement(() => Stephan != Status.KILLED_IN_A_DUEL)
                    .WithRequirement(() => Gloria != Status.BETHROTHED)
                    .WithConsequence(() => Willpower.Add(5))
                    .WithConsequence(() => Unity.Add(1))
                    .WithConsequence(() => FamilyAtPeace.Check())
                    .WithConsequence(() => Gloria.Set(Status.AT_HOME))
                    .WithConsequence(() => Stephan.Set(Status.AT_HOME))
                    .WithConsequence(() => MotherRecovers.Check()))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_TRANSFORMATION")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithDecision("EVENTS_PEACETIME_JUDGE_TRANSFORMATION_DECISION_DEMAND_THAT_OCTAVIA_BE_RETURNED_TO_HER_FAMILY", decision => decision
                    .WithConsequence(() => Reputation.Add(1))
                    .WithConsequence(() => Octavia.Set(Status.BETRAYED_BY_YOU))
                    .WithConsequence(() => Milanidas.Add(1))
                    .WithConsequence(() => Octavia.Add(-2)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_TRANSFORMATION_DECISION_LET_THE_LA_TARI_GO", decision => decision
                    .WithConsequence(() => Reputation.Add(-1))
                    .WithConsequence(() => Octavia.Set(Status.FLED))
                    .WithConsequence(() => Octavia.Add(1)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_TRANSFORMATION_DECISION_ACCEPT_YOUR_BELOVEDS_TRANSFORMATION", decision => decision
                    .WithRequirement(() => Octavia == Status.GROWN_CLOSE)
                    .WithConsequence(() => Willpower.Add(-10))
                    .WithConsequence(() => Reputation.Add(-1))
                    .WithConsequence(() => Octavia.Set(Status.SPIRITUAL_BOND)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_TRANSFORMATION_DECISION_OPEN_YOURSELF_TO_THE_TRUTH_OF_LA_TARI", decision => decision
                    .WithRequirement(() => Octavia >= 2)
                    .WithRequirement(() => TheLaTariRitual == true)
                    .WithConsequence(() => Willpower.Add(10))
                    .WithConsequence(() => Reputation.Add(-1))
                    .WithConsequence(() => Octavia.Set(Status.SPIRITUAL_BOND)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_THE_GILDED_CAGE")
    .WithRequirement(() => Gloria == Status.BETHROTHED)
    .WithDecision("EVENTS_PEACETIME_GENERAL_THE_GILDED_CAGE_DECISION_SEVER_ALL_TIES_WITH_GLORIA", decision => decision
        .WithConsequence(() => Reputation.Add(1))
        .WithConsequence(() => Unity.Add(-1))
        .WithConsequence(() => Gloria.Set(Status.SEVERED_ALL_TIES))
        .WithConsequence(() => Stephan.Set(Status.AT_HOME))
        .WithConsequence(() => Stephan.Add(2))
        .WithHiddenConsequence(() => Gloria.SetName("CHARACTER_GLORIA_EL_PELETIER")))
    .WithDecision("EVENTS_PEACETIME_GENERAL_THE_GILDED_CAGE_DECISION_MAINTAIN_FAMILY_TIES_WITH_GLORIA", decision => decision
        .WithRequirement(() => Eloquence >= 12 || Stephan >= 3)
        .WithConsequence(() => Eloquence.Add(1))
        .WithConsequence(() => Unity.Add(1))
        .WithConsequence(() => Reputation.Add(-1))
        .WithConsequence(() => Stephan.Set(Status.AT_HOME))
        .WithConsequence(() => Gloria.Set(Status.MARRIED))
        .WithConsequence(() => Stephan.Add(-1))
        .WithHiddenConsequence(() => Gloria.SetName("CHARACTER_GLORIA_EL_PELETIER")))
    .WithDecision("EVENTS_PEACETIME_GENERAL_THE_GILDED_CAGE_DECISION_CHALLENGE_STEPHAN_TO_A_DUEL", decision => decision
        .WithRequirement(() => PathOfTheNobleman == true)
        .WithRequirement(() => CourtOfHonorBanned == false)
        .WithRequirement(() => BloodTide == true)
        .WithConsequence(() => Stephan.Set(Status.DUEL_IMPENDING))
        .WithConsequence(() => Gloria.Set(Status.MARRIED))
        .WithConsequence(() => Robert.Add(-2))
        .WithHiddenConsequence(() => Gloria.SetName("CHARACTER_GLORIA_EL_PELETIER")))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_A_BROKEN_BRANCH")
                .WithRequirement(() => Stephan == Status.BAD_BLOOD)
                .WithDecision("EVENTS_PEACETIME_GENERAL_A_BROKEN_BRANCH_DECISION_SEVER_ALL_TIES_WITH_STEPHAN", decision => decision
                    .WithConsequence(() => Reputation.Add(-10))
                    .WithConsequence(() => Unity.Add(-1))
                    .WithConsequence(() => Heir.Check())
                    .WithConsequence(() => Stephan.Set(Status.SEVERED_ALL_TIES))
                    .WithConsequence(() => Gloria.Set(Status.AT_HOME))
                    .WithConsequence(() => Robert.Add(-1))
                    .WithConsequence(() => Gloria.Add(1))
                    .WithConsequence(() => GloriaBrante.Check())
                    .WithHiddenConsequence(() => Gloria.SetName("CHARACTER_GLORIA_BRANTE")))
                .WithDecision("EVENTS_PEACETIME_GENERAL_A_BROKEN_BRANCH_DECISION_MAINTAIN_FAMILY_TIES_WITH_STEPHAN", decision => decision
                    .WithRequirement(() => Unity >= 5)
                    .WithRequirement(() => Stephan >= 1)
                    .WithConsequence(() => Reputation.Add(-10))
                    .WithConsequence(() => Stephan.Set(Status.NEVER_TO_RETURN))
                    .WithConsequence(() => Gloria.Set(Status.AT_HOME))
                    .WithConsequence(() => Stephan.Add(1))
                    .WithConsequence(() => GloriaBrante.Check())
                    .WithHiddenConsequence(() => Gloria.SetName("CHARACTER_GLORIA_BRANTE")))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_THE_RUNAWAY_BRIDE")
               .WithRequirement(() => Gloria != Status.MARRIED)
               .WithRequirement(() => Gloria != Status.SEVERED_ALL_TIES)
               .WithRequirement(() => GloriaBrante == false)
               .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                   .WithConsequence(() => Stephan.Add(-1))
                   .WithConsequence(() => Stephan.Set(Status.AT_HOME))
                   .WithConsequence(() => Gloria.Set(Status.FLED))
                   .WithConsequence(() => Reputation.Add(-2))
                   .WithConsequence(() => Unity.Add(-2))
                   .WithConsequence(() => Stephan.Add(-1))
                   .WithConsequence(() => Unity.Add(-1)))
               .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_TOMMASS_WEDDING")
                .WithRequirement(() => Tommas != Status.TRUE_DEATH)
                .WithRequirement(() => Tommas != Status.EXILED)
                .WithRequirement(() => Tommas != Status.SEVERED_ALL_TIES)
                .WithDecision("EVENTS_PEACETIME_GENERAL_TOMMASS_WEDDING_DECISION_BEAR_WITNESS_TO_THEIR_WEDDING_VOWS", decision => decision
                    .WithRequirement(() => Tommas >= 4 || BondOfFriendship == true)
                    .WithConsequence(() => Willpower.Add(10))
                    .WithConsequence(() => TommasNewLife.Check()))
                .WithDecision("EVENTS_PEACETIME_GENERAL_TOMMASS_WEDDING_DECISION_PERFORM_THE_CEREMONY_YOURSELF", decision => decision
                    .WithRequirement(() => PathOfThePriest == true)
                    .WithConsequence(() => Eloquence.Add(1))
                    .WithConsequence(() => Theology.Add(1))
                    .WithConsequence(() => TommasNewLife.Check()))
                .WithDecision("EVENTS_PEACETIME_GENERAL_TOMMASS_WEDDING_DECISION_BID_TOMMAS_FAREWELL", decision => decision
                    .WithConsequence(() => Willpower.Add(5))
                    .WithConsequence(() => TommasNewLife.Check()))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_REPENTANCE")
                .WithDecision("EVENTS_PEACETIME_GENERAL_REPENTANCE_DECISION_DO_NOT_STOP_NATHAN", decision => decision
                    .WithConsequence(() => Theology.Add(1))
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Nathan.Add(1))
                    .WithConsequence(() => Nathan.Set(Status.HOPEFUL)))
                .WithDecision("EVENTS_PEACETIME_GENERAL_REPENTANCE_DECISION_PROTECT_YOUR_BROTHER", decision => decision
                    .WithRequirement(() => Theology >= 12 || Nathan >= 4)
                    .WithConsequence(() => Theology.Add(1))
                    .WithConsequence(() => Manipulation.Add(1))
                    .WithConsequence(() => Nathan.Add(-1))
                    .WithConsequence(() => Nathan.Set(Status.CONSUMED_BY_DESPAIR)))
                .WithDecision("EVENTS_PEACETIME_GENERAL_REPENTANCE_DECISION_CALL_MOTHER", decision => decision
                    .WithRequirement(() => MotherRecovers == true)
                    .WithRequirement(() => Nathan >= 3)
                    .WithConsequence(() => Willpower.Add(5))
                    .WithConsequence(() => Manipulation.Add(1))
                    .WithConsequence(() => Eloquence.Add(1))
                    .WithConsequence(() => Nathan.Set(Status.HOPEFUL)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_A_STORM_ON_THE_HORIZON")
                                                   .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                                                                .WithConsequence(() => Church.Add(2)))
                                                   .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_THE_DENUNCIATION")
                .WithRequirement(() => PathOfThePriest == true)
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_DENUNCIATION_DECISION_TELL_THE_TRUTH", decision => decision
                    .WithConsequence(() => Inquisition.Add(-1))
                    .WithConsequence(() => Jeanne.Add(1)))
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_DENUNCIATION_DECISION_DENY_EVERYTHING", decision => decision
                    .WithRequirement(() => Eloquence >= 16 || Jeanne == Status.GROWN_CLOSE)
                    .WithConsequence(() => Inquisition.Add(1))
                    .WithConsequence(() => Jeanne.Add(-2)))
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_DENUNCIATION_DECISION_ASK_ARCHDUKE_MILANIDAS_FOR_HELP", decision => decision
                    .WithRequirement(() => BrandedByDishonor == false)
                    .WithRequirement(() => Willpower >= 0)
                    .WithRequirement(() => Milanidas == Status.GRATEFUL)
                    .WithConsequence(() => Diplomacy.Add(1))
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Inquisition.Add(1))
                    .WithConsequence(() => Reputation.Add(-1))
                    .WithConsequence(() => Jeanne.Add(-1)))
                .Build());

            FamilyMatter = (new EventBuilder("EVENTS_PEACETIME_GENERAL_A_FAMILY_MATTER")
    .WithDecision("EVENTS_PEACETIME_GENERAL_A_FAMILY_MATTER_DECISION_BECOME_NOBLES_OF_THE_SWORD", decision => decision
        .WithRequirement(() => BrandedByDishonor == false)
        .WithRequirement(() => TheFamilyInRuins == false)
        .WithRequirement(() => Reputation >= 8)
        .WithRequirement(() => Wealth >= 5)
        .WithRequirement(() => Unity >= 3)
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Gregor.Add(2))
        .WithConsequence(() => EnnobledByTheSword.Check())
        .WithHiddenConsequence(() => Robert.SetName("CHARACTER_ROBERT_EL_BRANTE"))
        .WithHiddenConsequence(() => Stephan.SetName("CHARACTER_STEPHAN_EL_BRANTE")))
    .WithDecision("EVENTS_PEACETIME_GENERAL_A_FAMILY_MATTER_DECISION_BECOME_MEMBERS_OF_THE_OVERSEERS_ENTOURAGE", decision => decision
        .WithRequirement(() => TheFamilyInRuins == false)
        .WithRequirement(() => Reputation >= 8)
        .WithRequirement(() => Wealth >= 6)
        .WithRequirement(() => Unity >= 3)
        .WithRequirement(() => AFamilyOfMeans == true || AGloriousBloodline == true)
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Gregor.Add(3))
        .WithConsequence(() => EnnobledByTheSword.Check())
        .WithConsequence(() => FavoredByTheOverseer.Check()))
    .WithDecision("EVENTS_PEACETIME_GENERAL_A_FAMILY_MATTER_DECISION_PRESERVE_THE_FAMILY", decision => decision
        .WithRequirement(() => Unity >= 3)
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Gregor.Add(-2)))
    .WithDecision("EVENTS_PEACETIME_GENERAL_A_FAMILY_MATTER_DECISION_SEVER_ALL_TIES_WITH_THE_FAMILY", decision => decision
        .WithRequirement(() => Unity <= 2)
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Unity.Add(-2))
        .WithConsequence(() => Wealth.Add(-2))
        .WithConsequence(() => Reputation.Add(-2))
        .WithConsequence(() => TheFamilyFallsApart.Check()))
    .Build());
            Events.Add(FamilyMatter);

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_A_NOBLE_BLOODLINE")
                .WithRequirement(() => EnnobledByTheSword == true)
                .WithDecision("EVENTS_PEACETIME_GENERAL_A_NOBLE_BLOODLINE_DECISION_STEP_FORWARD_AS_THE_FAMILY_HEIR", decision => decision
                    .WithRequirement(() => Heir == true)
                    .WithConsequence(() => Valor.Add(2))
                    .WithConsequence(() => Diplomacy.Add(2))
                    .WithConsequence(() => HeirOfTheFamily.Check()))
                .WithDecision("EVENTS_PEACETIME_GENERAL_A_NOBLE_BLOODLINE_DECISION_ACCOMPANY_STEPHAN_AS_HE_STEPS_FORWARD", decision => decision
                    .WithRequirement(() => Heir == false)
                    .WithConsequence(() => Diplomacy.Add(1))
                    .WithConsequence(() => Willpower.Add(10))
                    .WithConsequence(() => Stephan.Add(2))
                    .WithConsequence(() => Robert.Add(2)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_THE_REFLECTION")
               .WithRequirement(() => PathOfThePriest == true)
               .WithRequirement(() => Inquisition >= 7)
               .WithRequirement(() => Ulrich == Status.MASTER)
               .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                   .WithConsequence(() => Inquisition.Add(3)))
               .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_DAY_OF_WRATH")
               .WithRequirement(() => PathOfThePriest == true)
               .WithRequirement(() => Tolerance >= 7)
               .WithRequirement(() => RightToDefendTheFaith == true)
               .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                   .WithConsequence(() => Order.Add(-1))
                   .WithConsequence(() => Tolerance.Add(3)))
               .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_THE_TRIUMPH_OF_WILL")
               .WithRequirement(() => PathOfThePriest == true)
               .WithRequirement(() => Inquisition == 10)
               .WithRequirement(() => Ulrich == Status.MASTER)
               .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_TRIUMPH_OF_WILL_DECISION_RENOUNCE_ULRICH", decision => decision
                   .WithRequirement(() => Valor >= 12)
                   .WithRequirement(() => Willpower >= 10)
                   .WithConsequence(() => Inquisition.Add(-2))
                   .WithConsequence(() => Willpower.Add(-20))
                   .WithConsequence(() => Ulrich.Set(Status.DIED_BY_YOUR_HAND)))
               .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_TRIUMPH_OF_WILL_DECISION_SUBMIT_TO_HIS_WILL", decision => decision
                   .WithConsequence(() => Tolerance.Add(-2))
                   .WithConsequence(() => Willpower.Add(10))
                   .WithConsequence(() => Jeanne.Set(Status.DIED_BY_YOUR_HAND))
                   .WithConsequence(() => Ulrich.Set(Status.TRUE_DEATH))
                   .WithConsequence(() => Cassius.Set(Status.TRUE_DEATH))
                   .WithConsequence(() => Church.Add(-1))
                   .WithConsequence(() => Order.Add(-1)))
               .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_TRIUMPH_OF_WILL_DECISION_OVERCOME_ULRICH_WILL", decision => decision
                   .WithRequirement(() => Valor < 12)
                   .WithRequirement(() => Willpower >= 20)
                   .WithConsequence(() => Inquisition.Add(-2))
                   .WithConsequence(() => Willpower.Add(-30))
                   .WithConsequence(() => Ulrich.Set(Status.DIED_BY_YOUR_HAND)))
               .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_THE_JUDGEMENT_OF_THE_TWINS")
               .WithRequirement(() => PathOfThePriest == true)
               .WithRequirement(() => Ulrich == Status.TRUE_DEATH)
               .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_JUDGEMENT_OF_THE_TWINS_DECISION_STAND_AGAINST_THE_TWINS", decision => decision
                   .WithRequirement(() => Theology == 20)
                   .WithRequirement(() => Willpower == 30)
                   .WithConsequence(() => ShadowOfTheWill.Check())
                   .WithConsequence(() => Willpower.Add(-40)))
               .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_JUDGEMENT_OF_THE_TWINS_DECISION_HUMBLY_ACCEPT_THEIR_PUNISHMENT", decision => decision
                   .WithConsequence(() => TrueDeath.Check())
                   .WithConsequence(() => Deaths.Add(4)))
               .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_THE_HERETIC")
                .WithRequirement(() => PathOfThePriest == true)
                .WithRequirement(() => Inquisition < 10)
                .WithRequirement(() => Ulrich != Status.DIED_BY_YOUR_HAND)
                .WithHiddenRequirement(() => Ulrich != Status.TRUE_DEATH)
                .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                    .WithConsequence(() => Ulrich.Set(Status.IN_HIDING)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_THE_SILENCE_OF_THE_GODS")
                .WithRequirement(() => PathOfThePriest == true)
                .WithRequirement(() => Tolerance >= 8)
                .WithRequirement(() => RightToDefendTheFaith == true)
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_SILENCE_OF_THE_GODS_DECISION_ARREST_SILVAN", decision => decision
                    .WithRequirement(() => Valor >= 12)
                    .WithRequirement(() => Willpower >= 0)
                    .WithConsequence(() => Tolerance.Add(-2))
                    .WithConsequence(() => Deaths.Add(1))
                    .WithConsequence(() => Willpower.Add(-10))
                    .WithConsequence(() => Silvan.Set(Status.TRUE_DEATH)))
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_SILENCE_OF_THE_GODS_DECISION_DO_NOT_STOP_THE_FANATICS", decision => decision
                    .WithConsequence(() => Inquisition.Add(-2))
                    .WithConsequence(() => Tolerance.Add(2)))
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_SILENCE_OF_THE_GODS_DECISION_GATHER_YOUR_STRENGTH_AND_STOP_THE_CROWD", decision => decision
                    .WithRequirement(() => Valor < 12)
                    .WithRequirement(() => Willpower >= 10)
                    .WithConsequence(() => Tolerance.Add(-2))
                    .WithConsequence(() => Deaths.Add(1))
                    .WithConsequence(() => Willpower.Add(-20))
                    .WithConsequence(() => Silvan.Set(Status.TRUE_DEATH)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_THE_FLAME_OF_THE_NEW_FAITH")
                .WithRequirement(() => PathOfThePriest == true)
                .WithRequirement(() => Tolerance == 10)
                .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                    .WithConsequence(() => Cassius.Set(Status.TRUE_DEATH))
                    .WithConsequence(() => Silvan.Set(Status.TRUE_DEATH))
                    .WithConsequence(() => Church.Add(1))
                    .WithConsequence(() => Order.Add(-1))
                    .WithConsequence(() => WealthOfMagra.Add(-1))
                    .WithConsequence(() => Power.Add(1))
                    .WithConsequence(() => TorchOfTheNewFaith.Check())
                    .WithConsequence(() => Sophia.Set(Status.LEADING_THE_REVOLT))
                    .WithConsequence(() => Revolt.Add(3))
                    .WithConsequence(() => Troops.Add(1))
                    .WithConsequence(() => CommonFolk.Add(1))
                    .WithConsequence(() => Clergy.Add(1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_THE_PATH_OF_THE_WILL")
                .WithRequirement(() => PathOfThePriest == true)
                .WithRequirement(() => Inquisition == 10)
                .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                    .WithConsequence(() => Ulrich.Set(Status.TRUE_DEATH))
                    .WithConsequence(() => Cassius.Set(Status.TRUE_DEATH))
                    .WithConsequence(() => Church.Add(-1))
                    .WithConsequence(() => Order.Add(-1))
                    .WithConsequence(() => Power.Add(-1))
                    .WithConsequence(() => AllPowerfulUlrich.Check())
                    .WithConsequence(() => Sophia.Set(Status.LEADING_THE_REVOLT))
                    .WithConsequence(() => Revolt.Add(3))
                    .WithConsequence(() => Nobles.Add(1))
                    .WithConsequence(() => Clergy.Add(1))
                    .WithConsequence(() => TheDefenderOfTheEmpire.Check()))
                .Build());

            TheFinalStep = (new EventBuilder("EVENTS_PEACETIME_INQUISITOR_THE_FINAL_STEP")
                .WithRequirement(() => PathOfThePriest == true)
                .WithRequirement(() => AllPowerfulUlrich == false)
                .WithRequirement(() => TorchOfTheNewFaith == false)
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_FINAL_STEP_DECISION_DENOUNCE_CASSIUS", decision => decision
                    .WithRequirement(() => EvidenceAgainstCassius == true)
                    .WithRequirement(() => CollapseOfTheInquisition == false)
                    .WithRequirement(() => Inquisition >= 7)
                    .WithConsequence(() => Jeanne.Add(1))
                    .WithConsequence(() => Cassius.Set(Status.TRUE_DEATH))
                    .WithConsequence(() => Church.Add(-2))
                    .WithConsequence(() => Power.Add(-2))
                    .WithConsequence(() => Order.Add(1))
                    .WithConsequence(() => CassiusFacesTheTribunal.Check())
                    .WithConsequence(() => Sophia.Set(Status.LEADING_THE_REVOLT))
                    .WithConsequence(() => Revolt.Add(3))
                    .WithConsequence(() => Troops.Add(1))
                    .WithConsequence(() => Nobles.Add(1))
                    .WithConsequence(() => Clergy.Add(1))
                    .WithConsequence(() => CommonFolk.Add(1))
                    .WithConsequence(() => TheDefenderOfTheEmpire.Check()))
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_FINAL_STEP_DECISION_OVERTHROW_CASSIUS", decision => decision
                    .WithRequirement(() => EvidenceAgainstCassius == true)
                    .WithRequirement(() => TheNewFaithPersecuted == false)
                    .WithRequirement(() => Tolerance >= 7)
                    .WithRequirement(() => Lennart != Status.PENANCE)
                    .WithConsequence(() => Jeanne.Add(-2))
                    .WithConsequence(() => Cassius.Set(Status.TRUE_DEATH))
                    .WithConsequence(() => Church.Add(1))
                    .WithConsequence(() => Power.Add(1))
                    .WithConsequence(() => CassiusOverthrow.Check())
                    .WithConsequence(() => Sophia.Set(Status.LEADING_THE_REVOLT))
                    .WithConsequence(() => Revolt.Add(2))
                    .WithConsequence(() => Troops.Add(1))
                    .WithConsequence(() => Clergy.Add(1))
                    .WithConsequence(() => CommonFolk.Add(2))
                    .WithConsequence(() => TheRebel.Check()))
                .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_FINAL_STEP_DECISION_WAIT_FOR_THE_CONCLAVE", decision => decision
                    .WithConsequence(() => TrueDeath.Check())
                    .WithConsequence(() => Deaths.Add(4)))
                .Build());
            Events.Add(TheFinalStep);

            Events.Add(new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_EXPLOSION")
                .WithRequirement(() => PathOfTheLotless == true)
                .WithRequirement(() => Unrest >= 8)
                .WithRequirement(() => Sophia != Status.BETRAYED)
                .WithRequirement(() => SophiaHasTheGunpowder == true)
                .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                    .WithConsequence(() => ElVerman.Set(Status.TRUE_DEATH))
                    .WithConsequence(() => Power.Add(1))
                    .WithConsequence(() => Unrest.Add(2)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_MUTUALLY_BENEFICIENT_COLLABORATION")
                .WithRequirement(() => PathOfTheLotless == true)
                .WithRequirement(() => Network >= 8)
                .WithRequirement(() => Felipe == Status.SAW_YOUR_LOYALTY)
                .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                    .WithConsequence(() => Power.Add(-1))
                    .WithConsequence(() => Order.Add(1))
                    .WithConsequence(() => Network.Add(2)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_CLEAN_HANDS")
                .WithRequirement(() => PathOfTheLotless == true)
                .WithRequirement(() => Network >= 8)
                .WithRequirement(() => Unrest >= 3)
                .WithRequirement(() => Felipe == Status.SAW_YOUR_LOYALTY)
                .WithRequirement(() => Sophia == Status.GROWN_CLOSE)
                .WithRequirement(() => Power <= 0)
                .WithRequirement(() => Egmont == Status.ARRESTED)
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_CLEAN_HANDS_DECISION_KEEP_SOPHIAS_SECRET", decision => decision
                    .WithRequirement(() => Manipulation >= 15)
                    .WithRequirement(() => Felipe >= 4)
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Network.Add(-3))
                    .WithConsequence(() => Unrest.Add(2))
                    .WithConsequence(() => Felipe.Set(Status.BETRAYED)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_CLEAN_HANDS_DECISION_KILL_SOPHIA", decision => decision
                    .WithRequirement(() => Sophia == Status.GROWN_CLOSE)
                    .WithConsequence(() => Sophia.Set(Status.TRUE_DEATH))
                    .WithConsequence(() => GloryToTheEmpire.Check())
                    .WithConsequence(() => Egmont.Set(Status.TRUE_DEATH))
                    .WithConsequence(() => Lennart.Set(Status.EXECUTED))
                    .WithConsequence(() => Order.Add(5))
                    .WithConsequence(() => Power.Add(-3))
                    .WithConsequence(() => Church.Add(-2))
                    .WithConsequence(() => WealthOfMagra.Add(3)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_THE_GREATER_GOOD")
               .WithRequirement(() => PathOfTheLotless == true)
               .WithRequirement(() => Unrest >= 9)
               .WithRequirement(() => Sophia == Status.GROWN_CLOSE)
               .WithRequirement(() => Felipe != Status.SAW_YOUR_LOYALTY)
               .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_THE_GREATER_GOOD_DECISION_AGREE", decision => decision
                   .WithConsequence(() => Sophia.Set(Status.SECRET_PLOT)))
               .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_THE_GREATER_GOOD_DECISION_TRY_TO_TALK_HER_OUT_OF_IT", decision => decision
                   .WithRequirement(() => Manipulation >= 16 || Sophia >= 4)
                   .WithConsequence(() => Unrest.Add(-4))
                   .WithConsequence(() => Sophia.Add(-4)))
               .Build());

            ASleeplessNight = (new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_A_SLEEPLESS_NIGHT")
    .WithRequirement(() => PathOfTheLotless == true)
    .WithRequirement(() => GloryToTheEmpire == false)
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_A_SLEEPLESS_NIGHT_DECISION_MURDER_FELIPE", decision => decision
        .WithRequirement(() => Sophia == Status.SECRET_PLOT)
        .WithConsequence(() => Wealth.Add(-1))
        .WithConsequence(() => Felipe.Set(Status.TRUE_DEATH))
        .WithConsequence(() => Sophia.Set(Status.LOVER))
        .WithConsequence(() => TheLastStrawsRevolt.Check())
        .WithConsequence(() => Egmont.Set(Status.TRUE_DEATH))
        .WithConsequence(() => ElVerman.Set(Status.TRUE_DEATH))
        .WithConsequence(() => Power.Add(1))
        .WithConsequence(() => Order.Add(-1))
        .WithConsequence(() => WealthOfMagra.Add(-1))
        .WithConsequence(() => Church.Add(1))
        .WithConsequence(() => Revolt.Add(3))
        .WithConsequence(() => Troops.Add(2))
        .WithConsequence(() => CommonFolk.Add(2))
        .WithConsequence(() => TheRebel.Check()))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_A_SLEEPLESS_NIGHT_DECISION_PROCEED_WITH_FELIPES_PLAN", decision => decision
        .WithRequirement(() => Network >= 8)
        .WithRequirement(() => Unrest >= 3)
        .WithRequirement(() => Unrest <= 8)
        .WithRequirement(() => Sophia != Status.SECRET_PLOT)
        .WithConsequence(() => Network.Add(2))
        .WithConsequence(() => Wealth.Add(-1))
        .WithConsequence(() => Sophia.Add(-2))
        .WithConsequence(() => Felipe.Set(Status.TRUE_DEATH))
        .WithConsequence(() => Egmont.Set(Status.TRUE_DEATH))
        .WithConsequence(() => Sophia.Set(Status.ENEMY))
        .WithConsequence(() => Power.Add(-2))
        .WithConsequence(() => Order.Add(-1))
        .WithConsequence(() => FarewellAdvisor.Check())
        .WithConsequence(() => Revolt.Add(3))
        .WithConsequence(() => Troops.Add(1))
        .WithConsequence(() => CommonFolk.Add(1)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_A_SLEEPLESS_NIGHT_DECISION_GO_INTO_HIDING", decision => decision
        .WithRequirement(() => Sophia != Status.SECRET_PLOT)
        .WithConsequence(() => Willpower.Add(-10))
        .WithConsequence(() => Unrest.Add(-3))
        .WithConsequence(() => Network.Add(-3))
        .WithConsequence(() => Felipe.Add(-2)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_A_SLEEPLESS_NIGHT_DECISION_ASK_EGMONT_TO_HIDE_YOU", decision => decision
        .WithRequirement(() => Unrest >= 7)
        .WithRequirement(() => Egmont == Status.SECRET_PLOT)
        .WithRequirement(() => Sophia != Status.SECRET_PLOT)
        .WithConsequence(() => Unrest.Add(1))
        .WithConsequence(() => Network.Add(-1))
        .WithConsequence(() => Felipe.Add(-2)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_A_SLEEPLESS_NIGHT_DECISION_ASK_EL_VERMAN_TO_HIDE_YOU", decision => decision
        .WithRequirement(() => Network >= 7)
        .WithRequirement(() => Egmont == Status.IN_DANGER)
        .WithRequirement(() => ElVerman == Status.MADE_A_DEAL)
        .WithConsequence(() => Unrest.Add(-1))
        .WithConsequence(() => Network.Add(1))
        .WithConsequence(() => Felipe.Add(-2)))
    .Build());
            Events.Add(ASleeplessNight);

            Events.Add(new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_MASKS_OFF")
                .WithRequirement(() => PathOfTheLotless == true)
                .WithRequirement(() => TheLastStrawsRevolt == false)
                .WithRequirement(() => TheFreeCity == false)
                .WithRequirement(() => FarewellAdvisor == false)
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_MASKS_OFF_DECISION_ASK_YOUR_FAMILY_TO_HELP", decision => decision
                    .WithRequirement(() => FavoredByTheOverseer == true)
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Robert.Add(-1))
                    .WithConsequence(() => Stephan.Add(-1))
                    .WithConsequence(() => Felipe.Add(-1))
                    .WithConsequence(() => FreeMan.Check())
                    .WithConsequence(() => Egmont.Set(Status.TRUE_DEATH))
                    .WithConsequence(() => Felipe.Set(Status.TRUE_DEATH))
                    .WithConsequence(() => Sophia.Set(Status.DISTRUSTFUL))
                    .WithConsequence(() => Order.Add(-1))
                    .WithConsequence(() => Power.Add(1))
                    .WithConsequence(() => WealthOfMagra.Add(-1))
                    .WithConsequence(() => Revolt.Add(3))
                    .WithConsequence(() => CommonFolk.Add(1)))
                    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_MASKS_OFF_DECISION_SIDE_WITH_MAYER_EGMONT", decision => decision
                        .WithRequirement(() => Unrest >= 8)
                        .WithRequirement(() => Egmont == Status.SECRET_PLOT)
                        .WithConsequence(() => Felipe.Add(-4))
                        .WithConsequence(() => Felipe.Set(Status.IN_HIDING_ESCAPE))
                        .WithConsequence(() => Egmont.Set(Status.TRUE_DEATH))
                        .WithConsequence(() => Sophia.Set(Status.ALLY))
                        .WithConsequence(() => Power.Add(1))
                        .WithConsequence(() => Order.Add(-1))
                        .WithConsequence(() => Church.Add(1))
                        .WithConsequence(() => TheFreeCity.Check())
                        .WithConsequence(() => Revolt.Add(3))
                        .WithConsequence(() => Troops.Add(1))
                        .WithConsequence(() => Clergy.Add(1))
                        .WithConsequence(() => Nobles.Add(1))
                        .WithConsequence(() => CommonFolk.Add(2))
                        .WithConsequence(() => TheRebel.Check()))
                    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_MASKS_OFF_DECISION_SIDE_WITH_REMY_EL_VERMAN", decision => decision
                        .WithRequirement(() => Network >= 8)
                        .WithRequirement(() => Egmont == Status.IN_DANGER)
                        .WithRequirement(() => ElVerman == Status.MADE_A_DEAL)
                        .WithConsequence(() => Felipe.Add(-4))
                        .WithConsequence(() => Felipe.Set(Status.IN_HIDING_ESCAPE))
                        .WithConsequence(() => Egmont.Set(Status.TRUE_DEATH))
                        .WithConsequence(() => ElVerman.Set(Status.TRUE_DEATH))
                        .WithConsequence(() => Sophia.Set(Status.DISTRUSTFUL))
                        .WithConsequence(() => FreeMan.Check())
                        .WithConsequence(() => Order.Add(-1))
                        .WithConsequence(() => Power.Add(1))
                        .WithConsequence(() => WealthOfMagra.Add(-1))
                        .WithConsequence(() => Revolt.Add(3))
                        .WithConsequence(() => CommonFolk.Add(1)))
                 .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_MASKS_OFF_FLEE_THE_CITY", decision => decision
                    .WithConsequence(() => TrueDeath.Check())
                    .WithConsequence(() => Deaths.Add(4)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_THE_SMELL_OF_GUNPOWDER")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithRequirement(() => Justice >= 7)
                .WithRequirement(() => Egmont == Status.MADE_A_DEAL)
                .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                .WithConsequence(() => Order.Add(-1))
                .WithConsequence(() => Justice.Add(3)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_PRISONERS")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithRequirement(() => Justice >= 8)
                .WithRequirement(() => Egmont == Status.MADE_A_DEAL)
                .WithDecision("EVENTS_PEACETIME_JUDGE_PRISONERS_DECISION_KEEP_THE_PRISONERS_IN_CAPTIVITY", decision => decision
                    .WithConsequence(() => Power.Add(-1))
                    .WithConsequence(() => Justice.Add(-3))
                    .WithConsequence(() => Egmont.Set(Status.TRUE_DEATH))
                    .WithConsequence(() => Egmont.Add(-4)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_PRISONERS_DECISION_HELP_THEM_ESCAPE", decision => decision
                    .WithRequirement(() => Scheming >= 10)
                    .WithRequirement(() => Willpower >= 0)
                    .WithConsequence(() => Willpower.Add(-10))
                    .WithConsequence(() => Deaths.Add(1))
                    .WithConsequence(() => Career.Add(-2))
                    .WithConsequence(() => Wealth.Add(1))
                    .WithConsequence(() => Egmont.Set(Status.LEADING_THE_REVOLT))
                    .WithConsequence(() => Egmont.Add(2)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_BROKEN_CHAINS")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithRequirement(() => Justice == 10)
                .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                .WithConsequence(() => Egmont.Set(Status.TRUE_DEATH))
                .WithConsequence(() => Power.Add(1))
                .WithConsequence(() => Order.Add(-1))
                .WithConsequence(() => WealthOfMagra.Add(-1))
                .WithConsequence(() => Church.Add(1))
                .WithConsequence(() => BrokenChains.Check())
                .WithConsequence(() => Sophia.Set(Status.LEADING_THE_REVOLT))
                .WithConsequence(() => ElVerman.Set(Status.TRUE_DEATH))
                .WithConsequence(() => Revolt.Add(3))
                .WithConsequence(() => CommonFolk.Add(2))
                .WithConsequence(() => Troops.Add(1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_REJECTED")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithRequirement(() => Career >= 7)
                .WithRequirement(() => ElVerman == Status.MADE_A_DEAL)
                .WithRequirement(() => TheFamilyFallsApart == true)
                .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                    .WithConsequence(() => ElVerman.Add(-4))
                    .WithConsequence(() => ElVerman.Set(Status.HE_IS_ENEMY))
                    .WithConsequence(() => Career.Add(-3)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_THE_EMPTY_CHAIR")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithRequirement(() => Career >= 7)
                .WithRequirement(() => ElVerman == Status.MADE_A_DEAL)
                .WithRequirement(() => TheFamilyFallsApart == false)
                .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                    .WithConsequence(() => Power.Add(-1))
                .WithConsequence(() => Career.Add(3)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_TWILIGHT_OVER_ANIZOTTE")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithRequirement(() => Career >= 8)
                .WithRequirement(() => ElVerman == Status.MADE_A_DEAL)
                .WithRequirement(() => TheFamilyFallsApart == false)
                .WithDecision("EVENTS_PEACETIME_JUDGE_TWILIGHT_OVER_ANIZOTTE_DECISION_WARN_EL_BORNE", decision => decision
                    .WithRequirement(() => Willpower >= 0)
                    .WithConsequence(() => Willpower.Add(-10))
                    .WithConsequence(() => Deaths.Add(1))
                    .WithConsequence(() => Career.Add(-3)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_TWILIGHT_OVER_ANIZOTTE_DECISION_GO_HOME", decision => decision
                    .WithConsequence(() => Justice.Add(-2))
                    .WithConsequence(() => Reputation.Add(1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_NIGHT_OF_THE_SERPENTS")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithRequirement(() => Career == 10)
                .WithRequirement(() => ElVerman != Status.MADE_A_DEAL)
                .WithRequirement(() => TheFamilyFallsApart == false)
                .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                    .WithConsequence(() => Robert.Add(1))
                    .WithConsequence(() => ElVerman.Set(Status.TRUE_DEATH))
                    .WithConsequence(() => Egmont.Set(Status.TRUE_DEATH))
                    .WithConsequence(() => Power.Add(-3))
                    .WithConsequence(() => WealthOfMagra.Add(-1))
                    .WithConsequence(() => Order.Add(-1))
                    .WithConsequence(() => Church.Add(-1))
                    .WithConsequence(() => Deaths.Add(1))
                    .WithConsequence(() => Sophia.Set(Status.LEADING_THE_REVOLT))
                    .WithConsequence(() => Revolt.Add(3))
                    .WithConsequence(() => Willpower.Add(10))
                    .WithConsequence(() => Troops.Add(1))
                    .WithConsequence(() => Robert.Add(-1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_NIGHT_OF_THE_SERPENTS")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithRequirement(() => Career == 10)
                .WithRequirement(() => ElVerman == Status.MADE_A_DEAL)
                .WithRequirement(() => TheFamilyFallsApart == false)
                .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                    .WithConsequence(() => Robert.Add(-1))
                    .WithConsequence(() => Otton.Add(1))
                    .WithConsequence(() => Egmont.Set(Status.TRUE_DEATH))
                    .WithConsequence(() => Power.Add(-3))
                    .WithConsequence(() => WealthOfMagra.Add(-1))
                    .WithConsequence(() => Order.Add(-1))
                    .WithConsequence(() => Church.Add(-1))
                    .WithConsequence(() => Robert.Add(-1))
                    .WithConsequence(() => NightOfTheSerpents.Check())
                    .WithConsequence(() => Sophia.Set(Status.LEADING_THE_REVOLT))
                    .WithConsequence(() => ElVerman.Set(Status.TRUE_DEATH))
                    .WithConsequence(() => Revolt.Add(3))
                    .WithConsequence(() => Nobles.Add(1))
                    .WithConsequence(() => Troops.Add(1))
                    .WithConsequence(() => Robert.Add(-1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_THE_FALL_OF_JUDGE_BRANTE")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithRequirement(() => Career == 10)
                .WithRequirement(() => ElVerman != Status.MADE_A_DEAL)
                .WithRequirement(() => TheFamilyFallsApart == true)
                .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                    .WithConsequence(() => TrueDeath.Check())
                    .WithConsequence(() => Deaths.Add(4)))
                .Build());

            FinalPreparations = (new EventBuilder("EVENTS_PEACETIME_JUDGE_FINAL_PREPARATIONS")
     .WithRequirement(() => PathOfTheNobleman == true)
     .WithRequirement(() => NightOfTheSerpents == false)
     .WithRequirement(() => Career < 10)
     .WithRequirement(() => BrokenChains == false)
     .WithDecision("EVENTS_PEACETIME_JUDGE_FINAL_PREPARATIONS_DECISION_ADDRESS_THE_PEOPLE_WITH_A_SPEECH", decision => decision
         .WithRequirement(() => Justice <= 8)
         .WithRequirement(() => Eloquence >= 12)
         .WithRequirement(() => Willpower >= 0)
         .WithConsequence(() => Justice.Add(1))
         .WithConsequence(() => Willpower.Add(-10)))
     .WithDecision("EVENTS_PEACETIME_JUDGE_FINAL_PREPARATIONS_DECISION_START_A_RUMOR_AMONG_THE_ARISTOCRACY", decision => decision
         .WithRequirement(() => Career <= 8)
         .WithRequirement(() => Diplomacy >= 15)
         .WithRequirement(() => Willpower >= 0)
         .WithConsequence(() => Career.Add(1))
         .WithConsequence(() => Willpower.Add(-10)))
     .WithDecision("EVENTS_PEACETIME_JUDGE_FINAL_PREPARATIONS_DECISION_BIDE_YOUR_TIME", decision => decision
         .WithConsequence(() => Willpower.Add(5)))
     .Build());
            Events.Add(FinalPreparations);

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_THE_HOUR_HAS_COME")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithRequirement(() => NightOfTheSerpents == false)
                .WithRequirement(() => Career < 10)
                .WithRequirement(() => BrokenChains == false)
                .WithDecision("EVENTS_PEACETIME_JUDGE_THE_HOUR_HAS_COME_DECISION_CHARGE_OTTON_WITH_CRIMES", decision => decision
                    .WithRequirement(() => Justice >= 7)
                    .WithRequirement(() => Justice < 10)
                    .WithRequirement(() => ElBorne != Status.BETRAYED)
                    .WithRequirement(() => EvidenceAgainstOtton == true)
                    .WithConsequence(() => Otton.Add(-4))
                    .WithConsequence(() => WealthOfMagra.Add(1))
                    .WithConsequence(() => Order.Add(2))
                    .WithConsequence(() => OttonIsSentenced.Check())
                    .WithConsequence(() => Sophia.Set(Status.LEADING_THE_REVOLT))
                    .WithConsequence(() => ElVerman.Set(Status.TRUE_DEATH))
                    .WithConsequence(() => Revolt.Add(2))
                    .WithConsequence(() => CommonFolk.Add(2))
                    .WithConsequence(() => Nobles.Add(1))
                    .WithConsequence(() => Clergy.Add(1))
                    .WithConsequence(() => Troops.Add(1)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_THE_HOUR_HAS_COME_DECISION_SUMMON_OTTON_TO_TRIAL", decision => decision
                    .WithRequirement(() => Justice >= 8)
                    .WithRequirement(() => Justice < 10)
                    .WithRequirement(() => ElBorne != Status.BETRAYED)
                    .WithRequirement(() => EvidenceAgainstOtton == false)
                    .WithRequirement(() => ProtectorOfThePeople == true)
                    .WithConsequence(() => Otton.Add(-4))
                    .WithConsequence(() => WealthOfMagra.Add(1))
                    .WithConsequence(() => Order.Add(2))
                    .WithConsequence(() => OttonIsSentenced.Check())
                    .WithConsequence(() => Sophia.Set(Status.LEADING_THE_REVOLT))
                    .WithConsequence(() => ElVerman.Set(Status.TRUE_DEATH))
                    .WithConsequence(() => Revolt.Add(2))
                    .WithConsequence(() => CommonFolk.Add(2))
                    .WithConsequence(() => Nobles.Add(1))
                    .WithConsequence(() => Clergy.Add(1))
                    .WithConsequence(() => Troops.Add(1)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_THE_HOUR_HAS_COME_DECISION_BRING_OTTON_TO_THE_COURT_OF_HONOR", decision => decision
                    .WithRequirement(() => Career >= 7)
                    .WithRequirement(() => Career < 10)
                    .WithRequirement(() => ElBorne == Status.BETRAYED)
                    .WithRequirement(() => EvidenceAgainstOtton == true)
                    .WithRequirement(() => CourtOfHonorBanned == false)
                    .WithRequirement(() => BrandedByDishonor == false)
                    .WithConsequence(() => Tempest.Add(1))
                    .WithConsequence(() => Otton.Add(-4))
                    .WithConsequence(() => Power.Add(-2))
                    .WithConsequence(() => Church.Add(-1))
                    .WithConsequence(() => OttonFacesTheCourtOfHonor.Check())
                    .WithConsequence(() => Sophia.Set(Status.LEADING_THE_REVOLT))
                    .WithConsequence(() => ElVerman.Set(Status.TRUE_DEATH))
                    .WithConsequence(() => Revolt.Add(2))
                    .WithConsequence(() => Troops.Add(2))
                    .WithConsequence(() => Nobles.Add(2))
                    .WithConsequence(() => Clergy.Add(1)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_THE_HOUR_HAS_COME_DECISION_CALL_FOR_GAIUS_TEMPEST_AID", decision => decision
                    .WithRequirement(() => Career >= 8)
                    .WithRequirement(() => Career < 10)
                    .WithRequirement(() => ElBorne == Status.BETRAYED)
                    .WithRequirement(() => EvidenceAgainstOtton == false)
                    .WithRequirement(() => CourtOfHonorBanned == false)
                    .WithRequirement(() => BrandedByDishonor == false)
                    .WithRequirement(() => PatronageOfThePowerful == true)
                    .WithConsequence(() => Tempest.Add(1))
                    .WithConsequence(() => Otton.Add(-4))
                    .WithConsequence(() => Power.Add(-2))
                    .WithConsequence(() => Church.Add(-1))
                    .WithConsequence(() => OttonFacesTheCourtOfHonor.Check())
                    .WithConsequence(() => Sophia.Set(Status.LEADING_THE_REVOLT))
                    .WithConsequence(() => ElVerman.Set(Status.TRUE_DEATH))
                    .WithConsequence(() => Revolt.Add(2))
                    .WithConsequence(() => Troops.Add(2))
                    .WithConsequence(() => Nobles.Add(2))
                    .WithConsequence(() => Clergy.Add(1)))
                .WithDecision("EVENTS_PEACETIME_JUDGE_THE_HOUR_HAS_COME_DECISION_BURN_THE_CASE", decision => decision
                    .WithConsequence(() => TrueDeath.Check())
                    .WithConsequence(() => Deaths.Add(4)))
                .Build());


            //Peacetime general family optional events

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_GLORIA_OF_HOUSE_BRANTE", true)
    .WithRequirement(() => Gloria == Status.AT_HOME)
    .WithRequirement(() => FamilyAtPeace == true)
    .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
        .WithConsequence(() => Gloria.Add(2))
        .WithConsequence(() => GloriaBrante.Check())
        .WithConsequence(() => Reputation.Add(-10))
        .WithHiddenConsequence(() => Gloria.SetName("CHARACTER_GLORIA_BRANTE")))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_TO_THE_DEATH", true)
    .WithRequirement(() => Stephan == Status.DUEL_IMPENDING)
    .WithDecision("EVENTS_PEACETIME_GENERAL_TO_THE_DEATH_DECISION_PARRY", decision => decision
        .WithRequirement(() => Valor >= 18)
        .WithConsequence(() => Willpower.Add(-10))
        .WithConsequence(() => Valor.Add(1))
        .WithConsequence(() => Unity.Add(-2))
        .WithConsequence(() => Heir.Check())
        .WithConsequence(() => Stephan.Set(Status.KILLED_IN_A_DUEL)))
    .WithDecision("EVENTS_PEACETIME_GENERAL_TO_THE_DEATH_DECISION_RESORT_TO_DIRTY_TRICKS", decision => decision
        .WithRequirement(() => Scheming >= 12)
        .WithRequirement(() => Stephan >= 2)
        .WithConsequence(() => Scheming.Add(1))
        .WithConsequence(() => Valor.Add(1))
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Unity.Add(-2))
        .WithConsequence(() => Heir.Check())
        .WithConsequence(() => Stephan.Set(Status.KILLED_IN_A_DUEL)))
    .WithDecision("EVENTS_PEACETIME_GENERAL_TO_THE_DEATH_DECISION_PERISH", decision => decision
        .WithConsequence(() => Deaths.Add(4))
        .WithConsequence(() => TrueDeath.Check()))
    .WithDecision("EVENTS_PEACETIME_GENERAL_TO_THE_DEATH_DECISION_OVERCOME_DEATH", decision => decision
        .WithRequirement(() => Valor >= 15 && Valor < 18)
        .WithRequirement(() => Willpower >= 10)
        .WithConsequence(() => Willpower.Add(-20))
        .WithConsequence(() => Valor.Add(1))
        .WithConsequence(() => Unity.Add(-2))
        .WithConsequence(() => Heir.Check())
        .WithConsequence(() => Stephan.Set(Status.KILLED_IN_A_DUEL)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_FAMILY_STRIFE", true)
                .WithRequirement(() => Unity == 0)
                .WithRequirement(() => TheFamilyFallsApart == false)
                .WithHiddenRequirement(() => !FamilyMatter.HasPassed)
                .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                    .WithConsequence(() => Robert.Add(-2))
                    .WithConsequence(() => Lydia.Add(-2))
                    .WithConsequence(() => Stephan.Add(-2))
                    .WithConsequence(() => Gloria.Add(-2))
                    .WithConsequence(() => Nathan.Add(-2))
                    .WithConsequence(() => Willpower.Add(-10)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_RUIN_AND_DEBT", true)
                .WithRequirement(() => Wealth == 0)
                .WithRequirement(() => TheFamilyFallsApart != false)
                .WithHiddenRequirement(() => !FamilyMatter.HasPassed)
                .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                    .WithConsequence(() => Reputation.Add(-1))
                    .WithConsequence(() => TheFamilyInRuins.Check()))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_THE_MARK_OF_DISHONOR", true)
    .WithRequirement(() => Reputation == 0)
    .WithRequirement(() => TheFamilyFallsApart == false)
    .WithHiddenRequirement(() => ARealmUnknown.HasPassed)
    .WithHiddenRequirement(() => !FamilyMatter.HasPassed)
    .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
        .WithConsequence(() => Robert.Add(-1))
        .WithConsequence(() => Wealth.Add(-1))
        .WithConsequence(() => Unity.Add(-1))
        .WithConsequence(() => BrandedByDishonor.Check()))
    .Build());

            //Peacetime conspirator optional events
            Events.Add(new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_POWDER_KEG", true)
                .WithHiddenRequirement(() => ErrorsOfYouth.HasPassed)
                .WithHiddenRequirement(() => !AnInvitationToDinner.HasPassed)
                .WithRequirement(() => PathOfTheLotless == true)
                .WithRequirement(() => Unrest >= 5)
                .WithRequirement(() => StashOfGunpowder == true)
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_POWDER_KEG_DECISION_AGREE", decision => decision
                    .WithConsequence(() => WealthOfMagra.Add(-1))
                    .WithConsequence(() => Order.Add(-1))
                    .WithConsequence(() => Unrest.Add(2))
                    .WithConsequence(() => Sophia.Add(1))
                    .WithConsequence(() => SophiaHasTheGunpowder.Check()))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_POWDER_KEG_DECISION_REFUSE", decision => decision
                    .WithConsequence(() => Sophia.Add(-1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_TRUST", true)
                .WithHiddenRequirement(() => ErrorsOfYouth.HasPassed)
                .WithHiddenRequirement(() => !AnInvitationToDinner.HasPassed)
                .WithRequirement(() => PathOfTheLotless == true)
                .WithRequirement(() => Network >= 5)
                .WithRequirement(() => Felipe >= 2)
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_TRUST_DECISION_SHAKE_HIS_HAND", decision => decision
                    .WithRequirement(() => Sophia != Status.MERCILESS)
                    .WithConsequence(() => Network.Add(1))
                    .WithConsequence(() => Reputation.Add(1))
                    .WithConsequence(() => Wealth.Add(1))
                    .WithConsequence(() => Felipe.Set(Status.SAW_YOUR_LOYALTY))
                    .WithConsequence(() => Felipe.Add(1)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_TRUST_DECISION_REFUSE", decision => decision
                    .WithConsequence(() => Felipe.Add(-1)))
                .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_TRUST_DECISION_AGREE", decision => decision
                    .WithRequirement(() => Sophia == Status.MERCILESS)
                    .WithConsequence(() => Wealth.Add(1))
                    .WithConsequence(() => Reputation.Add(1))
                    .WithConsequence(() => Felipe.Set(Status.SAW_YOUR_LOYALTY))
                    .WithConsequence(() => Felipe.Add(1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_PERSONAL_INTERESTS", true)
    .WithRequirement(() => PathOfTheLotless == true)
    .WithRequirement(() => Network >= 8)
    .WithHiddenRequirement(() => !ASleeplessNight.HasPassed)
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_PERSONAL_INTERESTS_DECISION_BUY_THE_COMPROMISING_MATERIAL_BACK", decision => decision
        .WithRequirement(() => Diplomacy >= 10)
        .WithRequirement(() => Wealth >= 2)
        .WithConsequence(() => Wealth.Add(-2)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_PERSONAL_INTERESTS_DECISION_LIE_LOW", decision => decision
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Unrest.Add(-2))
        .WithConsequence(() => Network.Add(-2)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_PERSONAL_INTERESTS_DECISION_TRACK_DOWN_THE_TRAITOR", decision => decision
        .WithRequirement(() => Scheming >= 16)
        .WithRequirement(() => Willpower >= 0)
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Network.Add(2)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_SOUND_AND_FURY", true)
    .WithRequirement(() => PathOfTheLotless == true)
    .WithRequirement(() => Unrest >= 8)
    .WithHiddenRequirement(() => !ASleeplessNight.HasPassed)
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_SOUND_AND_FURY_DECISION_BRIBE_THE_LEADERS_OF_THE_REVOLT", decision => decision
        .WithRequirement(() => Wealth >= 2)
        .WithRequirement(() => Manipulation >= 15)
        .WithConsequence(() => Manipulation.Add(1))
        .WithConsequence(() => Unrest.Add(-2))
        .WithConsequence(() => Wealth.Add(-2)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_SOUND_AND_FURY_DECISION_THREATEN_THE_LESSER_QUORUM", decision => decision
        .WithRequirement(() => Network >= 2)
        .WithRequirement(() => Diplomacy >= 10)
        .WithConsequence(() => Unrest.Add(-2))
        .WithConsequence(() => Network.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_SOUND_AND_FURY_DECISION_TAKE_CONTROL_OF_THE_DISTURBANCES", decision => decision
        .WithConsequence(() => Scheming.Add(1))
        .WithConsequence(() => Order.Add(-1))
        .WithConsequence(() => WealthOfMagra.Add(1))
        .WithConsequence(() => Unrest.Add(2))
        .WithConsequence(() => Network.Add(-1))
        .WithConsequence(() => Wealth.Add(-1)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_A_SOUND_OF_THUNDER", true)
    .WithRequirement(() => PathOfTheLotless == true)
    .WithRequirement(() => Network <= 2)
    .WithHiddenRequirement(() => !ASleeplessNight.HasPassed)
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_A_SOUND_OF_THUNDER_DECISION_BEG_FOR_FORGIVENESS", decision => decision
        .WithConsequence(() => Manipulation.Add(1))
        .WithConsequence(() => Willpower.Add(10))
        .WithConsequence(() => Deaths.Add(1))
        .WithConsequence(() => Network.Add(-1))
        .WithConsequence(() => Felipe.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_A_SOUND_OF_THUNDER_DECISION_PROMISE_QUICK_RESULTS", decision => decision
        .WithRequirement(() => Scheming >= 15)
        .WithRequirement(() => Willpower >= 0)
        .WithConsequence(() => Scheming.Add(1))
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Unrest.Add(-2))
        .WithConsequence(() => Network.Add(2)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_A_SOUND_OF_THUNDER_DECISION_LIE_TO_FELIPE", decision => decision
        .WithRequirement(() => Manipulation >= 16)
        .WithRequirement(() => Willpower >= 0)
        .WithConsequence(() => Manipulation.Add(1))
        .WithConsequence(() => Willpower.Add(-10)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_AT_MIDNIGHT", true)
    .WithRequirement(() => PathOfTheLotless == true)
    .WithRequirement(() => Network == 0)
    .WithHiddenRequirement(() => !ASleeplessNight.HasPassed)
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_AT_MIDNIGHT_DECISION_FLEE_THE_CITY", decision => decision
        .WithConsequence(() => TrueDeath.Check())
        .WithConsequence(() => Deaths.Add(4)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_AT_MIDNIGHT_DECISION_BEG_FOR_MERCY", decision => decision
        .WithRequirement(() => Willpower >= 10)
        .WithConsequence(() => Wealth.Add(-1))
        .WithConsequence(() => Reputation.Add(-2))
        .WithConsequence(() => Unity.Add(-1))
        .WithConsequence(() => Willpower.Add(-20))
        .WithConsequence(() => Felipe.Add(-2)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_AT_MIDNIGHT_DECISION_COMPLY_WITH_FELIPES_DEMANDS", decision => decision
        .WithRequirement(() => Scheming >= 16 || Manipulation >= 18)
        .WithConsequence(() => Unrest.Add(-1))
        .WithConsequence(() => Network.Add(1))
        .WithConsequence(() => Felipe.Add(-1)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_HAND_OF_THE_LAW", true)
    .WithRequirement(() => PathOfTheLotless == true)
    .WithRequirement(() => Unrest <= 2)
    .WithHiddenRequirement(() => !ASleeplessNight.HasPassed)
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_HAND_OF_THE_LAW_DECISION_FREE_THE_INSURGENTS", decision => decision
        .WithRequirement(() => Eloquence >= 12)
        .WithConsequence(() => Unrest.Add(2))
        .WithConsequence(() => Reputation.Add(-1))
        .WithConsequence(() => Unity.Add(-1))
        .WithConsequence(() => Manipulation.Add(1)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_HAND_OF_THE_LAW_DECISION_PROVOKE_THE_PEOPLE", decision => decision
        .WithRequirement(() => Manipulation >= 15)
        .WithConsequence(() => Unrest.Add(2))
        .WithConsequence(() => Network.Add(-3))
        .WithConsequence(() => Manipulation.Add(1)))
    .WithDecision("EVENTS_PEACETIME_CONSPIRATOR_HAND_OF_THE_LAW_DECISION_LIE_LOW", decision => decision
        .WithConsequence(() => Unrest.Add(-1))
        .WithConsequence(() => Scheming.Add(1)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_CONSPIRATOR_RAID", true)
.WithRequirement(() => PathOfTheLotless == true)
.WithRequirement(() => Unrest == 0)
.WithHiddenRequirement(() => !ASleeplessNight.HasPassed)
.WithDecision("EVENTS_PEACETIME_CONSPIRATOR_RAID_DECISION_BRIBE_THE_CAPTAIN", decision => decision
    .WithRequirement(() => ProfitableBusiness == true)
    .WithRequirement(() => Wealth >= 2)
    .WithRequirement(() => Willpower >= 0)
    .WithConsequence(() => Wealth.Add(-2))
    .WithConsequence(() => Willpower.Add(-10)))
.WithDecision("EVENTS_PEACETIME_CONSPIRATOR_RAID_DECISION_ASK_FOR_HELP", decision => decision
    .WithRequirement(() => Diplomacy >= 12 || Robert >= 3)
    .WithConsequence(() => Wealth.Add(-1))
    .WithConsequence(() => Reputation.Add(-1))
    .WithConsequence(() => Unity.Add(-2)))
.WithDecision("EVENTS_PEACETIME_CONSPIRATOR_RAID_DECISION_DESTROY_EVIDENCE", decision => decision
    .WithConsequence(() => Network.Add(-3))
    .WithConsequence(() => Willpower.Add(-5))
    .WithConsequence(() => Felipe.Add(-1)))
.Build());










            //Peacetime judge optional events

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_FRIEND_OF_THE_PEOPLE", true)
.WithRequirement(() => PathOfTheNobleman == true)
.WithRequirement(() => Justice >= 5)
.WithRequirement(() => ElVerman != Status.MADE_A_DEAL)
.WithHiddenRequirement(() => TheCaseOfFatherMark.HasPassed)
.WithHiddenRequirement(() => !ARendezvousWithOctavia.HasPassed)
.WithDecision("EVENTS_PEACETIME_JUDGE_FRIEND_OF_THE_PEOPLE_DECISION_AGREE", decision => decision
   .WithRequirement(() => ElVerman != Status.MADE_A_DEAL)
   .WithConsequence(() => WealthOfMagra.Add(2))
   .WithConsequence(() => Justice.Add(2))
   .WithConsequence(() => Wealth.Add(1))
   .WithConsequence(() => Egmont.Set(Status.MADE_A_DEAL))
   .WithConsequence(() => Egmont.Add(1)))
.WithDecision("EVENTS_PEACETIME_JUDGE_FRIEND_OF_THE_PEOPLE_DECISION_REFUSE", decision => decision
   .WithConsequence(() => Egmont.Add(-2)))
.Build());


            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_THE_ROAD_TO_THE_TOP", true)
    .WithRequirement(() => PathOfTheNobleman == true)
    .WithRequirement(() => Career >= 5)
    .WithRequirement(() => BrandedByDishonor == false)
    .WithHiddenRequirement(() => TheCaseOfFatherMark.HasPassed)
    .WithHiddenRequirement(() => !ARendezvousWithOctavia.HasPassed)
    .WithDecision("EVENTS_PEACETIME_JUDGE_THE_ROAD_TO_THE_TOP_DECISION_AGREE", decision => decision
        .WithRequirement(() => Egmont != Status.MADE_A_DEAL)
        .WithConsequence(() => Career.Add(3))
        .WithConsequence(() => Justice.Add(1))
        .WithConsequence(() => ElVerman.Set(Status.MADE_A_DEAL))
        .WithConsequence(() => ElBorne.Set(Status.BETRAYED))
        .WithConsequence(() => PatronageOfThePowerful.Check()))
    .WithDecision("EVENTS_PEACETIME_JUDGE_THE_ROAD_TO_THE_TOP_DECISION_REFUSE_AND_PROTECT_YOUR_FAMILY", decision => decision
        .WithRequirement(() => Robert >= 2)
        .WithConsequence(() => Career.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_THE_ROAD_TO_THE_TOP_DECISION_REFUSE_AND_PROTECT_YOUR_CAREER", decision => decision
        .WithConsequence(() => Reputation.Add(-1)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_DEBACLE_IN_THE_SHOP", true)
    .WithRequirement(() => PathOfTheNobleman == true)
    .WithRequirement(() => Justice >= 8)
    .WithHiddenRequirement(() => !FinalPreparations.HasPassed)
    .WithDecision("EVENTS_PEACETIME_JUDGE_DEBACLE_IN_THE_SHOP_DECISION_ACQUIT_THE_STEINERS", decision => decision
        .WithRequirement(() => Eloquence >= 10 || Diplomacy >= 16)
        .WithConsequence(() => Eloquence.Add(1))
        .WithConsequence(() => Career.Add(-1))
        .WithConsequence(() => Justice.Add(2)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_DEBACLE_IN_THE_SHOP_DECISION_GRANT_THE_RIGHT_OF_SELF_DEFENCE", decision => decision
        .WithRequirement(() => PatronageOfThePowerful == true)
        .WithConsequence(() => Power.Add(1))
        .WithConsequence(() => Diplomacy.Add(1))
        .WithConsequence(() => Justice.Add(2))
        .WithConsequence(() => Tempest.Add(-1))
        .WithConsequence(() => ProtectorOfThePeople.Check()))
    .WithDecision("EVENTS_PEACETIME_JUDGE_DEBACLE_IN_THE_SHOP_DECISION_PUNISH_THE_STEINERS", decision => decision
        .WithConsequence(() => Diplomacy.Add(1))
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Justice.Add(-2)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_AN_AUDIENCE_WITH_THE_OVERSEER", true)
    .WithRequirement(() => PathOfTheNobleman == true)
    .WithRequirement(() => Career >= 8)
    .WithRequirement(() => BrandedByDishonor == false)
    .WithHiddenRequirement(() => TheSearchForEvidence.HasPassed)
    .WithHiddenRequirement(() => !ARealmUnknown.HasPassed)
    .WithDecision("EVENTS_PEACETIME_JUDGE_AN_AUDIENCE_WITH_THE_OVERSEER_DECISION_TAKE_THE_ENVELOPE", decision => decision
        .WithConsequence(() => Diplomacy.Add(1))
        .WithConsequence(() => Career.Add(2))
        .WithConsequence(() => ElBorne.Set(Status.BETRAYED))
        .WithConsequence(() => Tempest.Add(2))
        .WithConsequence(() => PatronageOfThePowerful.Check()))
    .WithDecision("EVENTS_PEACETIME_JUDGE_AN_AUDIENCE_WITH_THE_OVERSEER_DECISION_DECLINE", decision => decision
        .WithRequirement(() => Valor >= 13)
        .WithConsequence(() => Valor.Add(1))
        .WithConsequence(() => Career.Add(-2))
        .WithConsequence(() => Reputation.Add(-1))
        .WithConsequence(() => Tempest.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_AN_AUDIENCE_WITH_THE_OVERSEER_DECISION_DECLINE_AND_TELL_EL_BORNE", decision => decision
        .WithRequirement(() => Valor >= 11)
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Career.Add(-2))
        .WithConsequence(() => Justice.Add(1))
        .WithConsequence(() => Reputation.Add(-1))
        .WithConsequence(() => ElBorne.Add(1))
        .WithConsequence(() => Tempest.Add(-2)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_THE_CROWDED_SQUARE", true)
        .WithRequirement(() => PathOfTheNobleman == true)
        .WithRequirement(() => Justice <= 2)
        .WithHiddenRequirement(() => !FinalPreparations.HasPassed)
        .WithDecision("EVENTS_PEACETIME_JUDGE_THE_CROWDED_SQUARE_DECISION_HAVE_THE_MOB_DISPERSED", decision => decision
            .WithRequirement(() => Valor >= 15)
            .WithRequirement(() => Willpower >= 0)
            .WithConsequence(() => Justice.Add(-1))
            .WithConsequence(() => Career.Add(1))
            .WithConsequence(() => Unity.Add(-2))
            .WithConsequence(() => Valor.Add(-2))
            .WithConsequence(() => Willpower.Add(-5))
            .WithConsequence(() => Gloria.Add(-1)))
        .WithDecision("EVENTS_PEACETIME_JUDGE_THE_CROWDED_SQUARE_DECISION_MAKE_PEACE_WITH_THE_PEOPLE", decision => decision
            .WithRequirement(() => ProtectorOfThePeople == true)
            .WithRequirement(() => Willpower >= 0)
            .WithConsequence(() => Justice.Add(2))
            .WithConsequence(() => Diplomacy.Add(1))
            .WithConsequence(() => Eloquence.Add(1))
            .WithConsequence(() => Willpower.Add(-5))
            .WithConsequence(() => Gloria.Add(1)))
        .WithDecision("EVENTS_PEACETIME_JUDGE_THE_CROWDED_SQUARE_DECISION_KILL_THE_RINGDLEADER", decision => decision
            .WithConsequence(() => Justice.Add(-1))
            .WithConsequence(() => Unity.Add(-1))
            .WithConsequence(() => Gloria.Add(-1)))
        .WithDecision("EVENTS_PEACETIME_JUDGE_THE_CROWDED_SQUARE_DECISION_GRANT_THEIR_REQUEST", decision => decision
            .WithConsequence(() => Career.Add(-3))
            .WithConsequence(() => Justice.Add(2))
            .WithConsequence(() => Diplomacy.Add(1))
            .WithConsequence(() => Gloria.Add(1)))
        .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_MARCH_OF_THE_DESPERATE", true)
    .WithRequirement(() => PathOfTheNobleman == true)
    .WithRequirement(() => Justice <= 0)
    .WithHiddenRequirement(() => !FinalPreparations.HasPassed)
    .WithDecision("EVENTS_PEACETIME_JUDGE_MARCH_OF_THE_DESPERATE_DECISION_BRIBE_THE_CAPTAIN", decision => decision
        .WithRequirement(() => Wealth >= 2)
        .WithConsequence(() => Wealth.Add(-2))
        .WithConsequence(() => Reputation.Add(-2))
        .WithConsequence(() => Tempest.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_MARCH_OF_THE_DESPERATE_DECISION_GIVE_THE_LEGION_FREE_REIGN", decision => decision
        .WithConsequence(() => Order.Add(-2))
        .WithConsequence(() => Career.Add(-1))
            .WithConsequence(() => Eloquence.Add(1))
    .WithConsequence(() => Willpower.Add(-1))
        .WithConsequence(() => Gloria.Add(1)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_MARCH_OF_THE_DESPERATE_DECISION_PROTECT_THE_COMMON_FOLK", decision => decision
    .WithRequirement(() => Valor >= 16)
        .WithConsequence(() => ProtectorOfThePeople.Check())
        .WithConsequence(() => Career.Add(-3))
        .WithConsequence(() => Deaths.Add(1)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_CHUTES_AND_LADDERS", true)
    .WithRequirement(() => PathOfTheNobleman == true)
    .WithRequirement(() => Career <= 2)
    .WithHiddenRequirement(() => !FinalPreparations.HasPassed)
    .WithDecision("EVENTS_PEACETIME_JUDGE_CHUTES_AND_LADDERS_DECISION_ASK_YOUR_FATHER_FOR_HELP", decision => decision
        .WithRequirement(() => Willpower >= 0)
        .WithRequirement(() => Robert >= 3)
        .WithConsequence(() => Diplomacy.Add(1))
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Career.Add(2))
        .WithConsequence(() => Reputation.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_CHUTES_AND_LADDERS_DECISION_ANNUL_YOUR_DECISIONS", decision => decision
        .WithConsequence(() => Diplomacy.Add(1))
        .WithConsequence(() => Career.Add(2))
        .WithConsequence(() => Justice.Add(-3)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_CHUTES_AND_LADDERS_DECISION_CONTINUE_THE_FIGHT", decision => decision
        .WithConsequence(() => Valor.Add(1))
        .WithConsequence(() => Career.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_CHUTES_AND_LADDERS_DECISION_ASK_A_POWERFUL_BENEFACTOR_TO_PROTECT_YOUR_HONOR", decision => decision
        .WithRequirement(() => Diplomacy >= 15)
        .WithRequirement(() => Tempest >= 0)
        .WithRequirement(() => PatronageOfThePowerful == true)
        .WithRequirement(() => BrandedByDishonor == false)
        .WithConsequence(() => Career.Add(2)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_JUDGE_INVITATION_TO_THE_BALL", true)
    .WithRequirement(() => PathOfTheNobleman == true)
    .WithRequirement(() => Career == 0)
    .WithRequirement(() => Stephan != Status.KILLED_IN_A_DUEL)
    .WithHiddenRequirement(() => !FinalPreparations.HasPassed)
    .WithDecision("EVENTS_PEACETIME_JUDGE_INVITATION_TO_THE_BALL_DECISION_REJECT_THE_DEMANDS", decision => decision
        .WithConsequence(() => Reputation.Add(-2))
        .WithConsequence(() => Unity.Add(-2)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_INVITATION_TO_THE_BALL_DECISION_ACCEPT_THE_CONDITIONS", decision => decision
        .WithConsequence(() => Justice.Add(-3)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_INVITATION_TO_THE_BALL_DECISION_CHALLENGE_EL_LABERIUS_TO_A_DUEL", decision => decision
        .WithRequirement(() => Valor >= 18)
        .WithRequirement(() => CourtOfHonorBanned == false)
        .WithConsequence(() => Valor.Add(1))
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Justice.Add(-1))
        .WithConsequence(() => Wealth.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_JUDGE_INVITATION_TO_THE_BALL_DECISION_EXPIATE_YOUR_ERRORS_WITH_BLOOD", decision => decision
        .WithRequirement(() => Valor <= 17)
        .WithRequirement(() => CourtOfHonorBanned == false)
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Deaths.Add(1))
        .WithConsequence(() => Valor.Add(1))
        .WithConsequence(() => Justice.Add(-1)))
    .Build());

            //Peacetime inquisitor optional events
            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_THE_PRINCIPLE_OF_THE_WILL", true)
    .WithRequirement(() => PathOfThePriest == true)
    .WithRequirement(() => Inquisition >= 5)
    .WithRequirement(() => Deaths <= 2)
    .WithHiddenRequirement(() => BrothersInMisery.HasPassed)
    .WithHiddenRequirement(() => !TheFestivalOfSilverTree.HasPassed)
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_PRINCIPLE_OF_THE_WILL_DECISION_AGREE", decision => decision
        .WithConsequence(() => Willpower.Add(40))
        .WithConsequence(() => Deaths.Add(1))
        .WithConsequence(() => Inquisition.Add(2))
        .WithConsequence(() => Ulrich.Add(2))
        .WithConsequence(() => Ulrich.Set(Status.MASTER)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_PRINCIPLE_OF_THE_WILL_DECISION_DISAGREE", decision => decision
        .WithConsequence(() => Willpower.Add(-10))
        .WithConsequence(() => Theology.Add(1))
        .WithConsequence(() => Ulrich.Add(-1)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_LETHAL_WEAPONS", true)
    .WithRequirement(() => PathOfThePriest == true)
    .WithRequirement(() => Tolerance >= 5)
    .WithHiddenRequirement(() => BrothersInMisery.HasPassed)
    .WithHiddenRequirement(() => !TheFestivalOfSilverTree.HasPassed)
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_LETHAL_WEAPONS_DECISION_SUPPORT_LENART", decision => decision
        .WithConsequence(() => Power.Add(1))
        .WithConsequence(() => Church.Add(1))
        .WithConsequence(() => Tolerance.Add(2))
        .WithConsequence(() => Inquisition.Add(-1))
        .WithConsequence(() => Ulrich.Add(-1))
        .WithConsequence(() => Jeanne.Add(-1))
        .WithConsequence(() => RightToDefendTheFaith.Check()))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_LETHAL_WEAPONS_DECISION_DISSUADE_LENNART", decision => decision
        .WithRequirement(() => Willpower >= 0)
        .WithRequirement(() => Diplomacy >= 10)
        .WithRequirement(() => Lennart == Status.A_PROMISE_IS_MADE)
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Order.Add(1))
        .WithConsequence(() => Tolerance.Add(1)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_LETHAL_WEAPONS_DECISION_REFUSE", decision => decision
        .WithConsequence(() => Tolerance.Add(-1))
        .WithConsequence(() => Lennart.Add(-1)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_THE_CAPTIVE", true)
    .WithRequirement(() => PathOfThePriest == true)
    .WithRequirement(() => Inquisition <= 2)
    .WithHiddenRequirement(() => BrothersInMisery.HasPassed)
    .WithHiddenRequirement(() => !TheFestivalOfSilverTree.HasPassed)
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_CAPTIVE_DECISION_ABDUCT_CATALINA_EL_LABERIUS", decision => decision
        .WithRequirement(() => Scheming >= 10)
        .WithConsequence(() => Reputation.Add(-1))
        .WithConsequence(() => Wealth.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_CAPTIVE_DECISION_SEEAK_AID_FROM_PARISHIONERS", decision => decision
        .WithRequirement(() => Eloquence >= 14)
        .WithRequirement(() => Willpower >= 0)
        .WithConsequence(() => Church.Add(-1))
        .WithConsequence(() => Order.Add(-1))
        .WithConsequence(() => Inquisition.Add(2))
        .WithConsequence(() => Tolerance.Add(-3))
        .WithConsequence(() => Eloquence.Add(1))
        .WithConsequence(() => Willpower.Add(-5)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_CAPTIVE_DECISION_WITHDRAW_THE_ACCUSATION", decision => decision
        .WithConsequence(() => CollapseOfTheInquisition.Check())
        .WithConsequence(() => Inquisition.Add(-1))
        .WithConsequence(() => Theology.Add(1)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_EVENING_PRAYER", true)
    .WithRequirement(() => PathOfThePriest == true)
    .WithRequirement(() => Inquisition == 0)
    .WithHiddenRequirement(() => !TheFinalStep.HasPassed)
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_EVENING_PRAYER_DECISION_CAPTURE_THEM", decision => decision
        .WithRequirement(() => Valor >= 12)
        .WithConsequence(() => CollapseOfTheInquisition.Check())
        .WithConsequence(() => Tolerance.Add(-2)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_EVENING_PRAYER_WALK_AWAY_SILENTLY", decision => decision
        .WithConsequence(() => CollapseOfTheInquisition.Check())
        .WithConsequence(() => Wealth.Add(-2))
        .WithConsequence(() => Reputation.Add(-1))
        .WithConsequence(() => Unity.Add(-1)))
    .WithDecision("EVENTS_PEACETIME_INQUISITOR_EVENING_PRAYER_DECISION_REMIND_THEM_OF_THEIR_LOT", decision => decision
        .WithRequirement(() => Willpower >= 0)
        .WithRequirement(() => Eloquence >= 15)
        .WithConsequence(() => CollapseOfTheInquisition.Check())
        .WithConsequence(() => Willpower.Add(-10))
        .WithConsequence(() => Deaths.Add(1)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_THE_FIRE", true)
   .WithRequirement(() => PathOfThePriest == true)
   .WithRequirement(() => Tolerance <= 2)
   .WithHiddenRequirement(() => !TheFinalStep.HasPassed)
   .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_FIRE_DECISION_REBUILD_THE_TEMPLE", decision => decision
       .WithRequirement(() => Diplomacy >= 12 || Robert >= 2)
       .WithConsequence(() => Tolerance.Add(2))
       .WithConsequence(() => Wealth.Add(-2))
       .WithConsequence(() => Theology.Add(1)))
   .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_FIRE_DECISION_PUNISH_THE_ARSONISTS", decision => decision
       .WithRequirement(() => Scheming >= 10)
       .WithRequirement(() => Willpower >= 0)
       .WithConsequence(() => Inquisition.Add(-3))
       .WithConsequence(() => Tolerance.Add(2))
       .WithConsequence(() => Theology.Add(1))
       .WithConsequence(() => Willpower.Add(-5)))
   .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_FIRE_DECISION_ADMONISH_THE_PARISHIONERS", decision => decision
       .WithConsequence(() => TheNewFaithPersecuted.Check())
       .WithConsequence(() => Tolerance.Add(-1))
       .WithConsequence(() => Eloquence.Add(1)))
   .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_NIGHT_OF_SWORD_AND_LASH", true)
   .WithRequirement(() => PathOfThePriest == true)
   .WithRequirement(() => Inquisition == 0)
   .WithHiddenRequirement(() => !TheFinalStep.HasPassed)
   .WithDecision("EVENTS_PEACETIME_INQUISITOR_NIGHT_OF_SWORD_AND_LASH_DECISION_ADMONISH_THE_ANGRY_CROWD", decision => decision
       .WithRequirement(() => Eloquence >= 12)
       .WithConsequence(() => TheNewFaithPersecuted.Check())
       .WithConsequence(() => Church.Add(-1))
       .WithConsequence(() => WealthOfMagra.Add(-1))
       .WithConsequence(() => Inquisition.Add(-1))
       .WithConsequence(() => Deaths.Add(1)))
   .WithDecision("EVENTS_PEACETIME_INQUISITOR_NIGHT_OF_SWORD_AND_LASH_DECISION_LEAD_THE_NEW_BELIEVERS_OUT_OF_THE_TEMPLE", decision => decision
       .WithRequirement(() => Scheming >= 10)
       .WithConsequence(() => CollapseOfTheInquisition.Check())
       .WithConsequence(() => WealthOfMagra.Add(-1))
       .WithConsequence(() => Wealth.Add(-1))
       .WithConsequence(() => Reputation.Add(-2))
       .WithConsequence(() => Unity.Add(-1)))
   .WithDecision("EVENTS_PEACETIME_INQUISITOR_NIGHT_OF_SWORD_AND_LASH_DECISION_LET_THE_FANATICS_TAKE_OVER_THE_TEMPLE", decision => decision
       .WithConsequence(() => CollapseOfTheInquisition.Check())
       .WithConsequence(() => WealthOfMagra.Add(-1))
       .WithConsequence(() => Order.Add(-1))
       .WithConsequence(() => Church.Add(-1))
       .WithConsequence(() => Inquisition.Add(-2))
       .WithConsequence(() => Willpower.Add(-10)))
   .Build());
                                        
            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_PRIVILEGE_AND_AUTHORITY", true)
   .WithRequirement(() => PathOfThePriest == true)
   .WithRequirement(() => Inquisition >= 8)
   .WithHiddenRequirement(() => !TheFinalStep.HasPassed)
   .WithDecision("EVENTS_PEACETIME_INQUISITOR_PRIVILEGE_AND_AUTHORITY_DECISION_LET_THE_NOBLEMAN_GO", decision => decision
       .WithRequirement(() => Willpower >= 0)
       .WithRequirement(() => Ulrich >= 2)
       .WithConsequence(() => Inquisition.Add(-1))
       .WithConsequence(() => Willpower.Add(-5))
       .WithConsequence(() => Diplomacy.Add(1))
       .WithConsequence(() => Jeanne.Add(-1)))
   .WithDecision("EVENTS_PEACETIME_INQUISITOR_PRIVILEGE_AND_AUTHORITY_DECISION_SUPPORT_ULRICH", decision => decision
       .WithConsequence(() => Church.Add(-1))
       .WithConsequence(() => Tolerance.Add(-2))
       .WithConsequence(() => Inquisition.Add(-1)))
   .WithDecision("EVENTS_PEACETIME_INQUISITOR_PRIVILEGE_AND_AUTHORITY_DECISION_FABRICATE_EVIDENCE", decision => decision
       .WithRequirement(() => Scheming >= 12)
       .WithConsequence(() => Inquisition.Add(2))
       .WithConsequence(() => Scheming.Add(1)))
   .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_INQUISITOR_THE_NEW_SACRAMENT", true)
  .WithRequirement(() => PathOfThePriest == true)
  .WithRequirement(() => Tolerance >= 8)
  .WithHiddenRequirement(() => !TheFinalStep.HasPassed)
  .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_NEW_SACRAMENT_DECISION_APPEAL_TO_THE_OVERSEER", decision => decision
      .WithRequirement(() => BrandedByDishonor == false)
      .WithRequirement(() => Diplomacy >= 12 || Reputation >= 7)
      .WithConsequence(() => Inquisition.Add(-1))
      .WithConsequence(() => Tolerance.Add(-1))
      .WithConsequence(() => Reputation.Add(-1)))
  .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_NEW_SACRAMENT_DECISION_FOLLOW_THE_OVERSEERS_ORDERS", decision => decision
      .WithConsequence(() => Church.Add(-1))
      .WithConsequence(() => Power.Add(-1))
      .WithConsequence(() => Tolerance.Add(-2))
      .WithConsequence(() => Inquisition.Add(-2)))
  .WithDecision("EVENTS_PEACETIME_INQUISITOR_THE_NEW_SACRAMENT_DECISION_DEFEND_THE_NEW_BELIEVERS", decision => decision
      .WithRequirement(() => Eloquence >= 15)
      .WithRequirement(() => Willpower >= 0)
      .WithConsequence(() => Church.Add(1))
      .WithConsequence(() => Tolerance.Add(2))
      .WithConsequence(() => Eloquence.Add(1))
      .WithConsequence(() => Willpower.Add(-5)))
  .Build());

            //Peacetime general optional events

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_A_MOMENT_OF_RESPITE", true)
    .WithHiddenRequirement(() => !FamilyMatter.HasPassed)
    .WithRequirement(() => Unity == 10)
    .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
        .WithConsequence(() => Stephan.Add(1))
        .WithConsequence(() => Robert.Add(1))
        .WithConsequence(() => Lydia.Add(1))
        .WithConsequence(() => Nathan.Add(1))
        .WithConsequence(() => Gloria.Add(1))
    .WithConsequence(() => Willpower.Add(10)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_A_FAMILY_OF_MEANS", true)
    .WithHiddenRequirement(() => !FamilyMatter.HasPassed)
    .WithRequirement(() => Wealth == 10)
    .WithRequirement(() => TheFamilyInRuins == false)
    .WithDecision("EVENTS_PEACETIME_GENERAL_A_FAMILY_OF_MEANS_DECISION_INVEST_IN_THE_HOUSE", decision => decision
        .WithConsequence(() => AFamilyOfMeans.Check())
        .WithConsequence(() => Unity.Add(1))
        .WithConsequence(() => Wealth.Add(-2))
        .WithConsequence(() => Willpower.Add(5)))
    .WithDecision("EVENTS_PEACETIME_GENERAL_A_FAMILY_OF_MEANS_DECISION_HOST_A_GALA", decision => decision
        .WithRequirement(() => BrandedByDishonor == false)
        .WithConsequence(() => AFamilyOfMeans.Check())
        .WithConsequence(() => Reputation.Add(1))
        .WithConsequence(() => Wealth.Add(-2))
        .WithConsequence(() => Willpower.Add(5)))
    .WithDecision("EVENTS_PEACETIME_GENERAL_A_FAMILY_OF_MEANS_DECISION_EXPAND_THE_LIBRARY", decision => decision
        .WithConsequence(() => AFamilyOfMeans.Check())
        .WithConsequence(() => Wealth.Add(-1))
        .WithConsequence(() => Theology.Add(1))
        .WithConsequence(() => Diplomacy.Add(1))
        .WithConsequence(() => Manipulation.Add(1))
        .WithConsequence(() => Scheming.Add(1))
        .WithConsequence(() => Eloquence.Add(1))
        .WithConsequence(() => Valor.Add(1)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_A_GLORIOUS_BLOODLINE", true)
    .WithHiddenRequirement(() => !FamilyMatter.HasPassed)
    .WithRequirement(() => Reputation == 10)
    .WithRequirement(() => BrandedByDishonor == false)
    .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
        .WithConsequence(() => AGloriousBloodline.Check())
        .WithConsequence(() => Diplomacy.Add(1))
        .WithConsequence(() => Valor.Add(1)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_STEPHANS_GAMBIT", true)
    .WithHiddenRequirement(() => (PathOfTheNobleman == true && TheSearchForEvidence.HasPassed) || (PathOfThePriest == true && Revelation.HasPassed) || (PathOfTheLotless == true && AnInvitationToDinner.HasPassed))
    .WithHiddenRequirement(() => (PathOfTheNobleman == true && !ThreatsAndPromises.HasPassed) || (PathOfThePriest == true && !ThePatriarchsSermon.HasPassed) || (PathOfTheLotless == true && !TheHardGoodbye.HasPassed))
    .WithRequirement(() => Stephan >= 1)
    .WithDecision("EVENTS_PEACETIME_GENERAL_STEPHANS_GAMBIT_DECISION_AGREE", decision => decision
        .WithConsequence(() => Stephan.Add(1))
        .WithConsequence(() => Stephan.Set(Status.SECRET_PLOT)))
    .WithDecision("EVENTS_PEACETIME_GENERAL_STEPHANS_GAMBIT_DECISION_REFUSE", decision => decision
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Unity.Add(1))
        .WithConsequence(() => Stephan.Add(-2)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_PEACETIME_GENERAL_THE_ILLEGITIMATE_GIRL", true)
                .WithHiddenRequirement(() => (PathOfTheNobleman == true && TheSearchForEvidence.HasPassed) || (PathOfThePriest == true && Revelation.HasPassed) || (PathOfTheLotless == true && AnInvitationToDinner.HasPassed))
                .WithHiddenRequirement(() => (PathOfTheNobleman == true && !ThreatsAndPromises.HasPassed) || (PathOfThePriest == true && !ThePatriarchsSermon.HasPassed) || (PathOfTheLotless == true && !TheHardGoodbye.HasPassed))
                .WithRequirement(() => Gloria >= 1)
                .WithRequirement(() => Stephan != Status.SECRET_PLOT)
                .WithDecision("EVENTS_PEACETIME_GENERAL_THE_ILLEGITIMATE_GIRL_DECISION_HELP_GLORIA", decision => decision
                    .WithConsequence(() => Gloria.Add(1))
                    .WithConsequence(() => Gloria.Set(Status.SECRET_PLOT)))
                .WithDecision("EVENTS_PEACETIME_GENERAL_THE_ILLEGITIMATE_GIRL_DECISION_REFUSE_GLORIA", decision => decision
                    .WithConsequence(() => Willpower.Add(5))
                    .WithConsequence(() => Unity.Add(1))
                    .WithConsequence(() => Gloria.Add(-2)))
                .Build());





            //Revolt events

            Events.Add(new EventBuilder("EVENTS_REVOLT_GENERAL_AT_DAWN")
                .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                .WithConsequence(() => Revolt.Add(2)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_REVOLT_FAMILY_THE_FAMILYS_FATE")
    .WithRequirement(() => TheFamilyFallsApart == false)

    .WithDecision("EVENTS_REVOLT_FAMILY_THE_FAMILYS_FATE_DECISION_AGREE_WITH_FATHER_AND_PROTECT_YOUR_HOME", decision => decision
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => TheFamilyInTheCity.Check()))

    .WithDecision("EVENTS_REVOLT_FAMILY_THE_FAMILYS_FATE_DECISION_THE_BRANTES_WILL_FLEE_THE_CITY", decision => decision
        .WithRequirement(() => Unity >= 6)
        .WithRequirement(() => Robert >= 2)
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Robert.Set(Status.FLED)))

    .WithDecision("EVENTS_REVOLT_FAMILY_THE_FAMILYS_FATE_DECISION_THE_BRANTES_WILL_OPPOSE_THE_REVOLT", decision => decision
        .WithRequirement(() => TheRebel == false)
        .WithRequirement(() => Reputation >= 5)
        .WithRequirement(() => Robert >= 2)
        .WithRequirement(() => Stephan == Status.AT_HOME)
        .WithConsequence(() => Nobles.Add(1))
        .WithConsequence(() => Robert.Set(Status.DEFENDER_OF_THE_EMPIRE))
        .WithConsequence(() => TheDefenderOfTheEmpire.Check())
        .WithConsequence(() => TheFamilyInTheCity.Check()))

    .WithDecision("EVENTS_REVOLT_FAMILY_THE_FAMILYS_FATE_DECISION_THE_BRANTES_WILL_SIDE_WITH_THE_REVOLT", decision => decision
        .WithRequirement(() => TheDefenderOfTheEmpire == false)
        .WithRequirement(() => Unity >= 5)
        .WithRequirement(() => Robert >= 2)
        .WithRequirement(() => Gloria == Status.AT_HOME)
        .WithRequirement(() => Stephan != Status.AT_HOME)
        .WithConsequence(() => CommonFolk.Add(1))
        .WithConsequence(() => Robert.Set(Status.REBEL))
        .WithConsequence(() => TheRebel.Check())
        .WithConsequence(() => TheFamilyInTheCity.Check()))
    .Build());

            Events.Add(new EventBuilder("EVENTS_REVOLT_FAMILY_BY_THEIR_WILL")
                .WithRequirement(() => TheFamilyFallsApart == false)
                .WithDecision("EVENTS_REVOLT_FAMILY_BY_THEIR_WILL_DECISION_HE_SHOULD_ASK_THE_ELDER", decision => decision
                    .WithRequirement(() => Nathan == Status.HOPEFUL)
                    .WithRequirement(() => NathansAdmonition == true || RevelationOfTheTree == true)
                    .WithConsequence(() => Theology.Add(1))
                    .WithConsequence(() => Eloquence.Add(1))
                    .WithConsequence(() => Nathan.Set(Status.PROPHET)))
                .WithDecision("EVENTS_REVOLT_FAMILY_BY_THEIR_WILL_DECISION_THE_REVOLT_IS_A_CHALLENGE_AGAINST_THE_GODS", decision => decision
                    .WithConsequence(() => Theology.Add(1))
                    .WithConsequence(() => Nathan.Set(Status.CONSUMED_BY_DESPAIR)))
                .WithDecision("EVENTS_REVOLT_FAMILY_BY_THEIR_WILL_DECISION_THE_REVOLT_IS_A_THREAT_TO_THEIR_DESIGN", decision => decision
                    .WithConsequence(() => Eloquence.Add(1))
                    .WithConsequence(() => Nathan.Set(Status.CONSUMED_BY_DESPAIR)))
                .WithDecision("EVENTS_REVOLT_FAMILY_BY_THEIR_WILL_DECISION_THE_REVOLT_IS_A_PART_OF_THEIR_DESIGN", decision => decision
                    .WithRequirement(() => NathansAdmonition == true)
                    .WithRequirement(() => Theology >= 12)
                    .WithRequirement(() => Nathan >= 3)
                    .WithConsequence(() => Eloquence.Add(1))
                    .WithConsequence(() => Nathan.Set(Status.HOPEFUL)))
                .WithDecision("EVENTS_REVOLT_FAMILY_BY_THEIR_WILL_DECISION_WALK_AWAY_WITHOUT_GIVING_NATHAN_AN_ANSWER", decision => decision
                    .WithConsequence(() => Willpower.Add(10)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_REVOLT_FAMILY_ESCAPE_FROM_ANIZOTTE")
                .WithRequirement(() => Robert == Status.FLED)
                .WithDecision("EVENTS_REVOLT_FAMILY_ESCAPE_FROM_ANIZOTTE_DECISION_FLEE_WITH_YOUR_FAMILY_LEAVING_EVERYTHING_BEHIND", decision => decision
                    .WithRequirement(() => TheRebel == false)
                    .WithRequirement(() => TheDefenderOfTheEmpire == false)
                    .WithRequirement(() => Wealth >= 5)
                    .WithRequirement(() => Manipulation >= 12)
                    .WithConsequence(() => Wealth.Add(-5))
                    .WithConsequence(() => TheFamilyFledFromTheCity.Check())
                    .WithConsequence(() => EscapeFromTheCity.Check())
                    .WithConsequence(() => DarkTimes.Check()))
                .WithDecision("EVENTS_REVOLT_FAMILY_ESCAPE_FROM_ANIZOTTE_DECISION_BRIBE_THE_GUARDS", decision => decision
                    .WithRequirement(() => Wealth >= 5)
                    .WithRequirement(() => Manipulation >= 12)
                    .WithConsequence(() => Wealth.Add(-5))
                    .WithConsequence(() => TheFamilyFledFromTheCity.Check()))
                .WithDecision("EVENTS_REVOLT_FAMILY_ESCAPE_FROM_ANIZOTTE_DECISION_ORDER_THEM_TO_LET_YOUR_FAMILY_THROUGH", decision => decision
                    .WithRequirement(() => Sophia == Status.ALLY || Sophia == Status.LOVER)
                    .WithConsequence(() => CommonFolk.Add(-1))
                    .WithConsequence(() => TheFamilyFledFromTheCity.Check()))
                .WithDecision("EVENTS_REVOLT_FAMILY_ESCAPE_FROM_ANIZOTTE_DECISION_ATTACK_THE_GUARDS", decision => decision
                    .WithRequirement(() => Troops >= 1)
                    .WithConsequence(() => Revolt.Add(1))
                    .WithConsequence(() => CommonFolk.Add(-1))
                    .WithConsequence(() => TheFamilyFledFromTheCity.Check()))
                .WithDecision("EVENTS_REVOLT_FAMILY_ESCAPE_FROM_ANIZOTTE_DECISION_TURN_THE_CARRIAGE_AROUND", decision => decision
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Robert.Set(Status.AT_HOME))
                    .WithConsequence(() => TheFamilyInTheCity.Check()))
                .Build());


            Events.Add(new EventBuilder("EVENTS_REVOLT_GENERAL_MUSTERING_THE_FORCES")
    .WithDecision("EVENTS_REVOLT_GENERAL_MUSTERING_THE_FORCES_DECISION_ARM_THE_NEW_BELIEVERS", decision => decision
        .WithRequirement(() => PathOfThePriest == true)
        .WithRequirement(() => TheDefenderOfTheEmpire == false)
        .WithRequirement(() => Eloquence >= 16)
        .WithConsequence(() => Revolt.Add(1))
        .WithConsequence(() => Troops.Add(1))
        .WithConsequence(() => CommonFolk.Add(1))
        .WithConsequence(() => TheRebel.Check()))
    .WithDecision("EVENTS_REVOLT_GENERAL_MUSTERING_THE_FORCES_DECISION_INCITE_A_RIOT_AMONG_THE_LEGION_TROOPS", decision => decision
        .WithRequirement(() => PathOfTheNobleman == true)
        .WithRequirement(() => TheDefenderOfTheEmpire == false)
        .WithRequirement(() => TommasNewLife == true)
        .WithRequirement(() => Valor >= 14)
        .WithConsequence(() => Revolt.Add(1))
        .WithConsequence(() => Troops.Add(1))
        .WithConsequence(() => TheRebel.Check()))
    .WithDecision("EVENTS_REVOLT_GENERAL_MUSTERING_THE_FORCES_DECISION_ASSEMBLE_A_SQUAD_OF_LOYAL_REBELS", decision => decision
        .WithRequirement(() => PathOfTheLotless == true)
        .WithRequirement(() => TheDefenderOfTheEmpire == false)
        .WithRequirement(() => Scheming >= 16)
        .WithConsequence(() => Revolt.Add(1))
        .WithConsequence(() => Troops.Add(1))
        .WithConsequence(() => TheRebel.Check()))
    .WithDecision("EVENTS_REVOLT_GENERAL_MUSTERING_THE_FORCES_DECISION_SUPPORT_THE_OLD_BELIEVER_PRIESTS", decision => decision
        .WithRequirement(() => PathOfThePriest == true)
        .WithRequirement(() => TorchOfTheNewFaith == false)
        .WithRequirement(() => TheRebel == false)
        .WithRequirement(() => Theology >= 16)
        .WithConsequence(() => Clergy.Add(1))
        .WithConsequence(() => TheDefenderOfTheEmpire.Check()))
    .WithDecision("EVENTS_REVOLT_GENERAL_MUSTERING_THE_FORCES_DECISION_UNITE_THE_NOBLES", decision => decision
        .WithRequirement(() => PathOfTheNobleman == true)
        .WithRequirement(() => EnnobledByTheSword == true)
        .WithRequirement(() => TheRebel == false)
        .WithRequirement(() => Diplomacy >= 14)
        .WithConsequence(() => Nobles.Add(1))
        .WithConsequence(() => Troops.Add(1))
        .WithConsequence(() => TheDefenderOfTheEmpire.Check()))
    .WithDecision("EVENTS_REVOLT_GENERAL_MUSTERING_THE_FORCES_DECISION_BUY_THE_PEOPLES_LOYALTY", decision => decision
        .WithRequirement(() => PathOfTheLotless == true)
        .WithRequirement(() => TheRebel == false)
        .WithRequirement(() => Wealth >= 3)
        .WithRequirement(() => Manipulation >= 14)
        .WithConsequence(() => Troops.Add(1))
        .WithConsequence(() => CommonFolk.Add(1))
        .WithConsequence(() => Wealth.Add(-3))
        .WithConsequence(() => TheDefenderOfTheEmpire.Check()))
    .WithDecision("EVENTS_REVOLT_GENERAL_MUSTERING_THE_FORCES_DECISION_BIDE_YOUR_TIME", decision => decision
        .WithConsequence(() => Willpower.Add(10)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_REVOLT_CONSPIRATOR_TO_ARMS")
                .WithRequirement(() => PathOfTheLotless == true)
                .WithRequirement(() => StockpileOfArms == true)
                .WithDecision("EVENTS_GENERAL_DECISION_CONTINUE", decision => decision
                    .WithConsequence(() => Troops.Add(1)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_REVOLT_INQUISITOR_THE_ORDER_DIVIDED")
                .WithRequirement(() => PathOfThePriest == true)
                .WithDecision("EVENTS_REVOLT_INQUISITOR_THE_ORDER_DIVIDED_DECISION_CONVINCE_HER_TO_SPARE_THE_INQUISITORS", decision => decision
                    .WithRequirement(() => Eloquence >= 20)
                    .WithRequirement(() => Jeanne == Status.GROWN_CLOSE)
                    .WithRequirement(() => TheDefenderOfTheEmpire == false)
                    .WithRequirement(() => CassiusFacesTheTribunal == false)
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Church.Add(1))
                    .WithConsequence(() => Revolt.Add(1))
                    .WithConsequence(() => Clergy.Add(1))
                    .WithConsequence(() => CommonFolk.Add(1))
                    .WithConsequence(() => Jeanne.Add(1))
                    .WithConsequence(() => TheRebel.Check()))
                .WithDecision("EVENTS_REVOLT_INQUISITOR_THE_ORDER_DIVIDED_DECISION_FREE_THE_CAPTIVE_INQUISITORS_BY_FORCE", decision => decision
                    .WithRequirement(() => Troops >= 1)
                    .WithRequirement(() => TheDefenderOfTheEmpire == false)
                    .WithRequirement(() => TorchOfTheNewFaith == true || CassiusOverthrow == true)
                    .WithConsequence(() => Church.Add(1))
                    .WithConsequence(() => Revolt.Add(2))
                    .WithConsequence(() => Troops.Add(-1))
                    .WithConsequence(() => Clergy.Add(1))
                    .WithConsequence(() => CommonFolk.Add(1))
                    .WithConsequence(() => Jeanne.Add(-2))
                    .WithConsequence(() => TheRebel.Check()))
                .WithDecision("EVENTS_REVOLT_INQUISITOR_THE_ORDER_DIVIDED_DECISION_SEIZE_CONTROL_OF_THE_INQUISITION", decision => decision
                    .WithRequirement(() => CassiusOverthrow == false)
                    .WithRequirement(() => TheRebel == false)
                    .WithConsequence(() => Church.Add(-1))
                    .WithConsequence(() => Revolt.Add(-1))
                    .WithConsequence(() => Troops.Add(1))
                    .WithConsequence(() => Clergy.Add(-1))
                    .WithConsequence(() => Jeanne.Set(Status.DOOMED_FOR_HER_SIN))
                    .WithConsequence(() => TheDefenderOfTheEmpire.Check()))
                .WithDecision("EVENTS_REVOLT_INQUISITOR_THE_ORDER_DIVIDED_DECISION_STOP_JEANNE", decision => decision
                    .WithRequirement(() => Theology >= 18)
                    .WithRequirement(() => Jeanne >= 4)
                    .WithRequirement(() => Jeanne == Status.GROWN_CLOSE)
                    .WithRequirement(() => CassiusFacesTheTribunal == true)
                    .WithRequirement(() => TheRebel == false)
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Church.Add(-1))
                    .WithConsequence(() => Troops.Add(1))
                    .WithConsequence(() => Clergy.Add(1))
                    .WithConsequence(() => Jeanne.Set(Status.RIGHTEOUS))
                    .WithConsequence(() => TheDefenderOfTheEmpire.Check()))
                .WithDecision("EVENTS_REVOLT_INQUISITOR_THE_ORDER_DIVIDED_DECISION_DO_NOT_GET_INVOLVED", decision => decision
                    .WithRequirement(() => CassiusOverthrow == false)
                    .WithRequirement(() => TheRebel == false)
                    .WithConsequence(() => Willpower.Add(5))
                    .WithConsequence(() => Revolt.Add(1))
                    .WithConsequence(() => Jeanne.Set(Status.DOOMED_FOR_HER_SIN)))
                .WithDecision("EVENTS_REVOLT_INQUISITOR_THE_ORDER_DIVIDED_DECISION_ACCEPT_DEATH", decision => decision
                    .WithRequirement(() => TheRebel == true)
                    .WithConsequence(() => Deaths.Add(4))
                    .WithConsequence(() => TrueDeath.Check()))
                .Build());

            Events.Add(new EventBuilder("EVENTS_REVOLT_CONSPIRATOR_A_CORNERED_BEAST")
    .WithRequirement(() => PathOfTheLotless == true)
    .WithDecision("EVENTS_REVOLT_CONSPIRATOR_A_CORNERED_BEAST_DECISION_RUSH_TO_SOPHIAS_SIDE", decision => decision
        .WithRequirement(() => Troops >= 1)
        .WithRequirement(() => Sophia == Status.LOVER || Sophia == Status.ALLY)
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Revolt.Add(2))
        .WithConsequence(() => Troops.Add(1))
        .WithConsequence(() => Sophia.Set(Status.LEADING_THE_REVOLT)))
    .WithDecision("EVENTS_REVOLT_CONSPIRATOR_A_CORNERED_BEAST_DECISION_GET_RID_OF_SOPHIA", decision => decision
        .WithRequirement(() => Scheming == 20)
        .WithRequirement(() => Troops >= 1)
        .WithRequirement(() => Sophia == Status.LOVER || Sophia == Status.ALLY)
        .WithConsequence(() => Troops.Add(1))
        .WithConsequence(() => CommonFolk.Add(-1))
        .WithConsequence(() => Sophia.Set(Status.CAPTIVE))
        .WithConsequence(() => Otton.Add(2)))
    .WithDecision("EVENTS_REVOLT_CONSPIRATOR_A_CORNERED_BEAST_DECISION_STOP_SOPHIA", decision => decision
        .WithRequirement(() => Manipulation == 20)
        .WithRequirement(() => Troops >= 1)
        .WithRequirement(() => Sophia == Status.LOVER)
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Troops.Add(1))
        .WithConsequence(() => Revolt.Add(-1))
        .WithConsequence(() => Sophia.Set(Status.HOPEFUL)))
    .WithDecision("EVENTS_REVOLT_CONSPIRATOR_A_CORNERED_BEAST_DECISION_ORDER_A_RETREAT", decision => decision
        .WithRequirement(() => Sophia != Status.LOVER)
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Revolt.Add(1))
        .WithConsequence(() => Sophia.Set(Status.LEADING_THE_REVOLT)))
    .WithDecision("EVENTS_REVOLT_CONSPIRATOR_A_CORNERED_BEAST_DECISION_CAPTURE_SOPHIA_AND_HAVE_HER_EXECUTED", decision => decision
        .WithRequirement(() => Valor >= 14 || Scheming >= 20)
        .WithRequirement(() => Troops >= 1)
        .WithRequirement(() => Sophia != Status.LOVER)
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Power.Add(-1))
        .WithConsequence(() => Revolt.Add(-4))
        .WithConsequence(() => Troops.Add(-1))
        .WithConsequence(() => Sophia.Set(Status.EXECUTED)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_REVOLT_JUDGE_A_FADING_LIGHT")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithDecision("EVENTS_REVOLT_JUDGE_A_FADING_LIGHT_DECISION_HAND_HER_OVER_TO_THE_INQUISITION", decision => decision
                    .WithRequirement(() => TheRebel == false)
                    .WithRequirement(() => Octavia != Status.SPIRITUAL_BOND)
                    .WithConsequence(() => Clergy.Add(1))
                    .WithConsequence(() => Octavia.Set(Status.CAPTIVE)))
                .WithDecision("EVENTS_REVOLT_JUDGE_A_FADING_LIGHT_DECISION_GET_HER_OUT_OF_THE_CITY", decision => decision
                    .WithRequirement(() => Diplomacy >= 16)
                    .WithRequirement(() => Otton >= 0)
                    .WithRequirement(() => TheRebel == false)
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Nobles.Add(1))
                    .WithConsequence(() => Octavia.Set(Status.BROUGHT_BACK))
                    .WithConsequence(() => Otton.Add(2)))
                .WithDecision("EVENTS_REVOLT_JUDGE_A_FADING_LIGHT_DECISION_SHARE_A_FINAL_MOMENT_WITH_HER_BEFORE_SHE_LEAVES_THIS_WORLD", decision => decision
                    .WithRequirement(() => Theology >= 14 || TheLaTariRitual == true)
                    .WithRequirement(() => Octavia == Status.SPIRITUAL_BOND)
                    .WithConsequence(() => Octavia.Set(Status.LEFT_A_TRACE)))
                .WithDecision("EVENTS_REVOLT_JUDGE_A_FADING_LIGHT_DECISION_PART_WAYS_WITH_HER", decision => decision
                    .WithConsequence(() => Octavia.Set(Status.ESCAPED_THE_WORLD)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_REVOLT_JUDGE_SIR_EL_BORNES_CHOICE")
                .WithRequirement(() => PathOfTheNobleman == true)
                .WithDecision("EVENTS_REVOLT_JUDGE_SIR_EL_BORNES_CHOICE_DECISION_AWAIT_EL_BORNES_DECISION", decision => decision
                    .WithConsequence(() => Revolt.Add(1))
                    .WithConsequence(() => Willpower.Add(5)))
                .WithDecision("EVENTS_REVOLT_JUDGE_SIR_EL_BORNES_CHOICE_DECISION_CONVINCE_EL_BORNE_TO_SIDE_WITH_THE_REBELLION", decision => decision
                    .WithRequirement(() => Valor >= 18)
                    .WithRequirement(() => CommonFolk >= 1)
                    .WithRequirement(() => ElBorne >= 2)
                    .WithRequirement(() => TheDefenderOfTheEmpire == false)
                    .WithConsequence(() => Revolt.Add(1))
                    .WithConsequence(() => Troops.Add(1))
                    .WithConsequence(() => CommonFolk.Add(1))
                    .WithConsequence(() => Nobles.Add(-1))
                    .WithConsequence(() => ElBorne.Set(Status.REBEL))
                    .WithConsequence(() => TheRebel.Check()))
                .WithDecision("EVENTS_REVOLT_JUDGE_SIR_EL_BORNES_CHOICE_DECISION_SUPPORT_EL_BORNES_PLAN", decision => decision
                    .WithRequirement(() => ElBorne >= 2)
                    .WithRequirement(() => Nobles >= 1 || Reputation >= 7)
                    .WithConsequence(() => Revolt.Add(-1))
                    .WithConsequence(() => Nobles.Add(-1))
                    .WithConsequence(() => CommonFolk.Add(1)))
                .WithDecision("EVENTS_REVOLT_JUDGE_SIR_EL_BORNES_CHOICE_DECISION_CONDEMN_EL_BORNE", decision => decision
                    .WithRequirement(() => Diplomacy >= 18)
                    .WithRequirement(() => TheRebel == false)
                    .WithRequirement(() => BrandedByDishonor == false)
                    .WithConsequence(() => CommonFolk.Add(-1))
                    .WithConsequence(() => ElBorne.Set(Status.DEFENDER_OF_THE_EMPIRE))
                    .WithConsequence(() => TheDefenderOfTheEmpire.Check()))
                .Build());

            Events.Add(new EventBuilder("EVENTS_REVOLT_GENERAL_THE_PREFECTURE_UNDER_SIEGE")
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_PREFECTURE_UNDER_SIEGE_DECISION_ROUSE_THE_MOB_AND_ENCOURAGE_THEM_TO_DEFEND_THE_PREFECT", decision => decision
        .WithRequirement(() => Willpower >= 0)
        .WithRequirement(() => CommonFolk >= 2)
        .WithRequirement(() => ElBorne != Status.DEFENDER_OF_THE_EMPIRE)
        .WithRequirement(() => TheDefenderOfTheEmpire == false)
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Power.Add(1))
        .WithConsequence(() => Order.Add(-1))
        .WithConsequence(() => Revolt.Add(2))
        .WithConsequence(() => Troops.Add(1))
        .WithConsequence(() => ElBorne.Set(Status.REBEL))
        .WithConsequence(() => TheRebel.Check()))
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_PREFECTURE_UNDER_SIEGE_DECISION_GET_OTTONS_ARMY_TO_ABANDON_HIM", decision => decision
        .WithRequirement(() => OttonIsSentenced == true)
        .WithRequirement(() => TheDefenderOfTheEmpire == false)
        .WithRequirement(() => Nobles >= 1)
        .WithRequirement(() => Diplomacy >= 16)
        .WithConsequence(() => Power.Add(2))
        .WithConsequence(() => Order.Add(1))
        .WithConsequence(() => Revolt.Add(1))
        .WithConsequence(() => Troops.Add(1))
        .WithConsequence(() => Nobles.Add(1))
        .WithConsequence(() => CommonFolk.Add(1))
        .WithConsequence(() => Otton.Set(Status.TRUE_DEATH))
        .WithConsequence(() => ElBorne.Set(Status.REBEL))
        .WithConsequence(() => TheRebel.Check()))
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_PREFECTURE_UNDER_SIEGE_DECISION_CHALLENGE_OTTON_TO_A_DUEL", decision => decision
        .WithRequirement(() => Nobles >= 1)
        .WithRequirement(() => ElBorne != Status.REBEL)
        .WithRequirement(() => OttonFacesTheCourtOfHonor == true)
        .WithRequirement(() => TheRebel == false)
        .WithConsequence(() => Otton.Set(Status.DUEL_IMPENDING))
        .WithConsequence(() => TheDefenderOfTheEmpire.Check()))
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_PREFECTURE_UNDER_SIEGE_DECISION_OVERTHROW_EL_BORNE", decision => decision
        .WithRequirement(() => Willpower >= 0)
        .WithRequirement(() => Troops >= 1)
        .WithRequirement(() => OttonFacesTheCourtOfHonor == false)
        .WithRequirement(() => TheRebel == false)
        .WithConsequence(() => Order.Add(-1))
        .WithConsequence(() => Power.Add(-1))
        .WithConsequence(() => Revolt.Add(1))
        .WithConsequence(() => Nobles.Add(1))
        .WithConsequence(() => ElBorne.Set(Status.TRUE_DEATH))
        .WithConsequence(() => Otton.Add(2))
        .WithConsequence(() => TheDefenderOfTheEmpire.Check()))
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_PREFECTURE_UNDER_SIEGE_DECISION_GET_OTTON_AND_EL_BORNE_TO_RECONCILE", decision => decision
        .WithRequirement(() => Diplomacy == 20)
        .WithRequirement(() => Reputation >= 6)
        .WithRequirement(() => Otton >= 0)
        .WithRequirement(() => ElBorne != Status.REBEL)
        .WithRequirement(() => TheRebel == false)
        .WithRequirement(() => NightOfTheSerpents == true || BrokenChains == true)
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Power.Add(-2))
        .WithConsequence(() => Order.Add(1))
        .WithConsequence(() => Revolt.Add(-1))
        .WithConsequence(() => Nobles.Add(1))
        .WithConsequence(() => CommonFolk.Add(-1))
        .WithConsequence(() => ElBorne.Set(Status.DEFENDER_OF_THE_EMPIRE))
        .WithConsequence(() => Otton.Set(Status.RECONCILED))
        .WithConsequence(() => TheDefenderOfTheEmpire.Check()))
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_PREFECTURE_UNDER_SIEGE_DECISION_STAY_OUT_OF_IT", decision => decision
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Power.Add(-1))
        .WithConsequence(() => Order.Add(-1))
        .WithConsequence(() => ElBorne.Set(Status.TRUE_DEATH)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_REVOLT_JUDGE_THE_DUEL_WITH_OTTON")
                .WithRequirement(() => Otton == Status.DUEL_IMPENDING)
                .WithDecision("EVENTS_REVOLT_JUDGE_THE_DUEL_WITH_OTTON_DECISION_DEFEAT_OTTON", decision => decision
                    .WithRequirement(() => Valor == 20)
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Power.Add(-1))
                    .WithConsequence(() => Revolt.Add(-1))
                    .WithConsequence(() => Troops.Add(1))
                    .WithConsequence(() => Nobles.Add(1))
                    .WithConsequence(() => CommonFolk.Add(1))
                    .WithConsequence(() => Otton.Set(Status.KILLED_IN_A_DUEL))
                    .WithConsequence(() => ElBorne.Set(Status.DEFENDER_OF_THE_EMPIRE)))
                .WithDecision("EVENTS_REVOLT_JUDGE_THE_DUEL_WITH_OTTON_DECISION_CALL_UPON_YOUR_FOREBEAR", decision => decision
                    .WithRequirement(() => Valor >= 16)
                    .WithRequirement(() => Gregor >= 2)
                    .WithRequirement(() => EnnobledByTheSword == true)
                    .WithConsequence(() => Power.Add(-1))
                    .WithConsequence(() => Revolt.Add(-1))
                    .WithConsequence(() => Troops.Add(1))
                    .WithConsequence(() => Nobles.Add(1))
                    .WithConsequence(() => CommonFolk.Add(1))
                    .WithConsequence(() => Otton.Set(Status.KILLED_IN_A_DUEL))
                    .WithConsequence(() => ElBorne.Set(Status.DEFENDER_OF_THE_EMPIRE)))
                .WithDecision("EVENTS_REVOLT_JUDGE_THE_DUEL_WITH_OTTON_DECISION_DIE_WITH_HONOR", decision => decision
                    .WithConsequence(() => Deaths.Add(4))
                    .WithConsequence(() => TrueDeath.Check()))
                .WithDecision("EVENTS_REVOLT_JUDGE_THE_DUEL_WITH_OTTON_DECISION_OVERCOME_DEATH", decision => decision
                    .WithRequirement(() => Valor >= 16)
                    .WithRequirement(() => Valor <= 19)
                    .WithRequirement(() => Willpower >= 10)
                    .WithConsequence(() => Willpower.Add(-20))
                    .WithConsequence(() => Power.Add(-1))
                    .WithConsequence(() => Revolt.Add(-1))
                    .WithConsequence(() => Troops.Add(1))
                    .WithConsequence(() => Nobles.Add(1))
                    .WithConsequence(() => CommonFolk.Add(1))
                    .WithConsequence(() => Otton.Set(Status.KILLED_IN_A_DUEL))
                    .WithConsequence(() => ElBorne.Set(Status.DEFENDER_OF_THE_EMPIRE)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_REVOLT_GENERAL_THE_MARCH_OF_THE_NEW_FAITH")
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_MARCH_OF_THE_NEW_FAITH_DECISION_LEAD_THE_PROCESSION_TO_THE_TEMPLE", decision => decision
        .WithRequirement(() => Eloquence >= 16)
        .WithRequirement(() => Clergy >= 2)
        .WithRequirement(() => CommonFolk >= 2)
        .WithRequirement(() => TheDefenderOfTheEmpire == false)
        .WithRequirement(() => CassiusOverthrow == true || TorchOfTheNewFaith == true)
        .WithConsequence(() => Church.Add(1))
        .WithConsequence(() => Troops.Add(1))
        .WithConsequence(() => CommonFolk.Add(1))
        .WithConsequence(() => Nobles.Add(1))
        .WithConsequence(() => Lennart.Set(Status.PATRIARCH))
        .WithConsequence(() => Jeanne.Set(Status.DEFEATED))
        .WithConsequence(() => TheRebel.Check()))
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_MARCH_OF_THE_NEW_FAITH_DECISION_STAND_WITH_JEANNE_AND_DRIVE_THE_PROCESSION_AWAY", decision => decision
        .WithRequirement(() => Troops >= 1)
        .WithRequirement(() => Clergy >= 2)
        .WithRequirement(() => Jeanne == Status.RIGHTEOUS)
        .WithRequirement(() => TheRebel == false)
        .WithConsequence(() => Church.Add(-1))
        .WithConsequence(() => Power.Add(-1))
        .WithConsequence(() => Revolt.Add(-2))
        .WithConsequence(() => Troops.Add(1))
        .WithConsequence(() => Nobles.Add(1))
        .WithConsequence(() => CommonFolk.Add(1))
        .WithConsequence(() => Lennart.Set(Status.DEFEATED))
        .WithConsequence(() => TheDefenderOfTheEmpire.Check()))
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_MARCH_OF_THE_NEW_FAITH_DECISION_SAVE_THE_NEW_BELIEVERS_FROM_BLOODSHED", decision => decision
        .WithRequirement(() => Willpower >= 0)
        .WithRequirement(() => CommonFolk >= 2)
        .WithRequirement(() => TheDefenderOfTheEmpire == false)
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Order.Add(-1))
        .WithConsequence(() => Revolt.Add(1))
        .WithConsequence(() => Clergy.Add(1))
        .WithConsequence(() => Lennart.Set(Status.DEFEATED))
        .WithConsequence(() => Jeanne.Set(Status.TRUE_DEATH))
        .WithConsequence(() => TheRebel.Check()))
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_MARCH_OF_THE_NEW_FAITH_DECISION_FEND_THEM_OFF_WITH_THE_CHAMPIONS_OF_THE_FAITH", decision => decision
        .WithRequirement(() => Willpower >= 0)
        .WithRequirement(() => Troops >= 1)
        .WithRequirement(() => TheRebel == false)
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Order.Add(-1))
        .WithConsequence(() => Revolt.Add(-1))
        .WithConsequence(() => Troops.Add(1))
        .WithConsequence(() => Clergy.Add(1))
        .WithConsequence(() => CommonFolk.Add(-1))
        .WithConsequence(() => Jeanne.Set(Status.DEFEATED))
        .WithConsequence(() => Lennart.Set(Status.TRUE_DEATH))
        .WithConsequence(() => TheDefenderOfTheEmpire.Check()))
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_MARCH_OF_THE_NEW_FAITH_DECISION_ORDER_THE_PRIESTS_TO_ATTACK", decision => decision
        .WithRequirement(() => Troops >= 1)
        .WithRequirement(() => Jeanne == Status.DOOMED_FOR_HER_SIN)
        .WithRequirement(() => PathOfThePriest == true)
        .WithRequirement(() => TheDefenderOfTheEmpire == true)
        .WithConsequence(() => Church.Add(-2))
        .WithConsequence(() => Order.Add(-1))
        .WithConsequence(() => Power.Add(-2))
        .WithConsequence(() => Revolt.Add(-3))
        .WithConsequence(() => Nobles.Add(1))
        .WithConsequence(() => Clergy.Add(1))
        .WithConsequence(() => CommonFolk.Add(-1))
        .WithConsequence(() => Lennart.Set(Status.TRUE_DEATH)))
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_MARCH_OF_THE_NEW_FAITH_DECISION_WALK_AWAY", decision => decision
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Order.Add(-2))
        .WithConsequence(() => Revolt.Add(2))
        .WithConsequence(() => Lennart.Set(Status.TRUE_DEATH))
        .WithConsequence(() => Jeanne.Set(Status.BURIED_ALIVE)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_REVOLT_INQUISITOR_A_FAREWELL_TO_JEANNE")
                .WithRequirement(() => PathOfThePriest == true)
                .WithRequirement(() => Jeanne != Status.TRUE_DEATH)
                .WithRequirement(() => Jeanne != Status.BURIED_ALIVE)
                .WithDecision("EVENTS_REVOLT_INQUISITOR_A_FAREWELL_TO_JEANNE_DECISION_CONVERT_JEANNE_TO_THE_NEW_FAITH", decision => decision
                    .WithRequirement(() => Theology == 20)
                    .WithRequirement(() => Jeanne >= 2)
                    .WithRequirement(() => Jeanne == Status.DEFEATED)
                    .WithConsequence(() => Willpower.Add(10))
                    .WithConsequence(() => Jeanne.Set(Status.NEW_BELIEVER)))
                .WithDecision("EVENTS_REVOLT_INQUISITOR_A_FAREWELL_TO_JEANNE_DECISION_CONGRATULATE_JEANNE", decision => decision
                    .WithRequirement(() => Jeanne == Status.RIGHTEOUS)
                    .WithConsequence(() => Willpower.Add(10)))
                .WithDecision("EVENTS_REVOLT_INQUISITOR_A_FAREWELL_TO_JEANNE_DECISION_TRY_TO_TAKE_JEANNE_INTO_CUSTODY", decision => decision
                    .WithRequirement(() => Jeanne == Status.DEFEATED)
                    .WithConsequence(() => Jeanne.Set(Status.TRUE_DEATH)))
                .WithDecision("EVENTS_REVOLT_INQUISITOR_A_FAREWELL_TO_JEANNE_DECISION_SHARE_JEANNES_SORROW", decision => decision
                    .WithRequirement(() => Jeanne == Status.DOOMED_FOR_HER_SIN)
                    .WithRequirement(() => TheDefenderOfTheEmpire == true)
                    .WithConsequence(() => Willpower.Add(5)))
                .WithDecision("EVENTS_REVOLT_INQUISITOR_A_FAREWELL_TO_JEANNE_DECISION_CONSOLE_JEANNE", decision => decision
                    .WithRequirement(() => Jeanne >= 3)
                    .WithRequirement(() => Jeanne == Status.DEFEATED)
                    .WithRequirement(() => TheDefenderOfTheEmpire == true)
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Jeanne.Set(Status.RIGHTEOUS)))
                .WithDecision("EVENTS_REVOLT_INQUISITOR_A_FAREWELL_TO_JEANNE_DECISION_LEAVE_JEANNE_BY_HERSELF", decision => decision
                    .WithConsequence(() => Jeanne.Add(-2)))
                .Build());

            Events.Add(new EventBuilder("EVENTS_REVOLT_GENERAL_THE_REBEL_LEADER")
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_REBEL_LEADER_DECISION_UNITE_THE_REBELS_AROUND_SOPHIA", decision => decision
        .WithRequirement(() => Willpower >= 0)
        .WithRequirement(() => Sophia == Status.LEADING_THE_REVOLT)
        .WithRequirement(() => TheRebel == true)
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Power.Add(1))
        .WithConsequence(() => Revolt.Add(2))
        .WithConsequence(() => Troops.Add(1))
        .WithConsequence(() => CommonFolk.Add(1))
        .WithConsequence(() => Sophia.Add(2)))
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_REBEL_LEADER_DECISION_TAKE_CONTROL_OF_THE_REVOLT", decision => decision
        .WithRequirement(() => Sophia != Status.LEADING_THE_REVOLT)
        .WithRequirement(() => TheRebel == true)
        .WithConsequence(() => Revolt.Add(1))
        .WithConsequence(() => Troops.Add(1))
        .WithConsequence(() => CommonFolk.Add(1))
        .WithConsequence(() => LeadingTheRevolt.Check()))
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_REBEL_LEADER_DECISION_BREAK_UP_THE_MOB", decision => decision
        .WithRequirement(() => Willpower >= 0)
        .WithRequirement(() => Troops >= 2)
        .WithRequirement(() => Sophia == Status.LEADING_THE_REVOLT)
        .WithRequirement(() => TheDefenderOfTheEmpire == true)
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Order.Add(1))
        .WithConsequence(() => Power.Add(-1))
        .WithConsequence(() => Revolt.Add(-2))
        .WithConsequence(() => Troops.Add(-1))
        .WithConsequence(() => Nobles.Add(1))
        .WithConsequence(() => Clergy.Add(1)))
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_REBEL_LEADER_DECISION_DESTROY_THEIR_MORALE", decision => decision
        .WithRequirement(() => Manipulation >= 18)
        .WithRequirement(() => CommonFolk >= 1)
        .WithRequirement(() => Sophia == Status.EXECUTED || Sophia == Status.CAPTIVE)
        .WithRequirement(() => TheRebel == false)
        .WithConsequence(() => Order.Add(1))
        .WithConsequence(() => Power.Add(-1))
        .WithConsequence(() => Revolt.Add(-4))
        .WithConsequence(() => Nobles.Add(1))
        .WithConsequence(() => Clergy.Add(1)))
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_REBEL_LEADER_DECISION_OVERTHROW_SOPHIA", decision => decision
        .WithRequirement(() => Willpower >= 0)
        .WithRequirement(() => Troops >= 2)
        .WithRequirement(() => CommonFolk >= 2)
        .WithRequirement(() => Revolt <= 8)
        .WithRequirement(() => Sophia == Status.LEADING_THE_REVOLT)
        .WithRequirement(() => TheRebel == true)
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Revolt.Add(-2))
        .WithConsequence(() => Troops.Add(-1))
        .WithConsequence(() => CommonFolk.Add(1))
        .WithConsequence(() => Clergy.Add(1))
        .WithConsequence(() => Sophia.Set(Status.EXECUTED))
        .WithConsequence(() => LeadingTheRevolt.Check()))
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_REBEL_LEADER_DECISION_DO_NOT_GET_INVOLVED", decision => decision
        .WithRequirement(() => Sophia == Status.LEADING_THE_REVOLT)
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Revolt.Add(2)))
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_REBEL_LEADER_DECISION_WATCH_WHAT_HAPPENS_NEXT", decision => decision
        .WithRequirement(() => Sophia != Status.LEADING_THE_REVOLT)
        .WithRequirement(() => TheRebel == false)
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Revolt.Add(-2)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_REVOLT_FAMILY_HEARTH_AND_HOME")
                .WithRequirement(() => Revolt >= 1)
                .WithRequirement(() => TheFamilyInTheCity == true)
                .WithDecision("EVENTS_REVOLT_FAMILY_HEARTH_AND_HOME_DECISION_DIE_FOR_YOUR_HOME", decision => decision
                    .WithConsequence(() => Deaths.Add(4))
                    .WithConsequence(() => Robert.Set(Status.TRUE_DEATH))
                    .WithConsequence(() => TheFamilyHasPerished.Check()))
                .WithDecision("EVENTS_REVOLT_FAMILY_HEARTH_AND_HOME_DECISION_KILL_THE_LEADER", decision => decision
                    .WithRequirement(() => Valor >= 16)
                    .WithRequirement(() => Stephan != Status.AT_HOME)
                    .WithRequirement(() => PathOfTheNobleman == true)
                    .WithRequirement(() => TheFencingLesson == true)
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => CommonFolk.Add(-1))
                    .WithConsequence(() => TheFamilyIsSaved.Check()))
                .WithDecision("EVENTS_REVOLT_FAMILY_HEARTH_AND_HOME_DECISION_FIGHT_FOR_YOUR_HOME", decision => decision
                    .WithRequirement(() => Valor >= 10)
                    .WithRequirement(() => Stephan == Status.AT_HOME)
                    .WithConsequence(() => CommonFolk.Add(-1))
                    .WithConsequence(() => TheFamilyIsSaved.Check()))
                .WithDecision("EVENTS_REVOLT_FAMILY_HEARTH_AND_HOME_DECISION_SUBDUE_THE_THUGS", decision => decision
                    .WithRequirement(() => CommonFolk >= 3)
                    .WithRequirement(() => Revolt <= 8)
                    .WithRequirement(() => TheRebel == true)
                    .WithConsequence(() => Revolt.Add(-1))
                    .WithConsequence(() => CommonFolk.Add(-1))
                    .WithConsequence(() => TheFamilyIsSaved.Check()))
                .WithDecision("EVENTS_REVOLT_FAMILY_HEARTH_AND_HOME_DECISION_CALL_IN_THE_TROOPS", decision => decision
                    .WithRequirement(() => Troops >= 1)
                    .WithRequirement(() => Nathan == Status.HOPEFUL)
                    .WithConsequence(() => Revolt.Add(-1))
                    .WithConsequence(() => Troops.Add(-1))
                    .WithConsequence(() => TheFamilyIsSaved.Check()))
                .WithDecision("EVENTS_REVOLT_FAMILY_HEARTH_AND_HOME_DECISION_CONVINCE_THEM_THAT_YOU_ARE_ON_THEIR_SIDE", decision => decision
                    .WithRequirement(() => Manipulation >= 14 || Eloquence >= 14)
                    .WithRequirement(() => Robert == Status.REBEL)
                    .WithRequirement(() => Gloria == Status.AT_HOME)
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Revolt.Add(1))
                    .WithConsequence(() => TheFamilyIsSaved.Check()))
                .WithDecision("EVENTS_REVOLT_FAMILY_HEARTH_AND_HOME_DECISION_FLEE_ALONE", decision => decision
                    .WithConsequence(() => Willpower.Add(-10))
                    .WithConsequence(() => Robert.Set(Status.TRUE_DEATH))
                    .WithConsequence(() => TheFamilyHasPerished.Check()))
                .Build());

            Events.Add(new EventBuilder("EVENTS_REVOLT_GENERAL_THE_FINAL_HOUR")
    .WithRequirement(() => TheRebel == true)
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_FINAL_HOUR_DECISION_GO_SEE_EL_BORNE", decision => decision
        .WithRequirement(() => ElBorne == Status.REBEL)
        .WithConsequence(() => Revolt.Add(1))
        .WithConsequence(() => Nobles.Add(1)))
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_FINAL_HOUR_DECISION_ASK_LENNART_FOR_HELP", decision => decision
        .WithRequirement(() => Lennart == Status.PATRIARCH)
        .WithConsequence(() => Willpower.Add(5))
        .WithConsequence(() => Clergy.Add(1))
        .WithConsequence(() => CommonFolk.Add(1))
        .WithConsequence(() => Revolt.Add(1)))
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_FINAL_HOUR_DECISION_ASK_YOUR_FAMILY_FOR_HELP", decision => decision
        .WithRequirement(() => Robert == Status.REBEL)
        .WithRequirement(() => TheFamilyHasPerished == false)
        .WithConsequence(() => Revolt.Add(1))
        .WithConsequence(() => CommonFolk.Add(1)))
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_FINAL_HOUR_DECISION_GATHER_THE_SOLDIERS_OF_THE_LAST_STRAW", decision => decision
        .WithRequirement(() => Sophia == Status.HOPEFUL)
        .WithConsequence(() => Revolt.Add(1))
        .WithConsequence(() => Troops.Add(1)))
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_FINAL_HOUR_DECISION_MUSTER_YOUR_FORCES", decision => decision
        .WithConsequence(() => Willpower.Add(10)))
    .Build());

            Events.Add(new EventBuilder("EVENTS_REVOLT_GENERAL_THE_FINAL_HOUR")
                .WithRequirement(() => TheDefenderOfTheEmpire == true)
                .WithDecision("EVENTS_REVOLT_GENERAL_THE_FINAL_HOUR_DECISION_GO_SEE_EL_BORNE", decision => decision
                    .WithRequirement(() => ElBorne == Status.DEFENDER_OF_THE_EMPIRE)
                    .WithConsequence(() => Revolt.Add(-3))
                    .WithConsequence(() => CommonFolk.Add(1)))
                .WithDecision("EVENTS_REVOLT_GENERAL_THE_FINAL_HOUR_DECISION_ASK_YOUR_FAMILY_FOR_HELP", decision => decision
                    .WithRequirement(() => TheFamilyHasPerished == false)
                    .WithRequirement(() => Robert == Status.DEFENDER_OF_THE_EMPIRE)
                    .WithConsequence(() => Revolt.Add(-2))
                    .WithConsequence(() => Troops.Add(1)))
                .WithDecision("EVENTS_REVOLT_GENERAL_THE_FINAL_HOUR_DECISION_ASK_JEANNE_FOR_HELP", decision => decision
                    .WithRequirement(() => Jeanne == Status.RIGHTEOUS)
                    .WithConsequence(() => Revolt.Add(-2))
                    .WithConsequence(() => CommonFolk.Add(1)))
                .WithDecision("EVENTS_REVOLT_GENERAL_THE_FINAL_HOUR_DECISION_ASK_OTTON_FOR_REINFORCEMENTS", decision => decision
                    .WithRequirement(() => Otton != Status.TRUE_DEATH)
                    .WithRequirement(() => Otton >= 2 || Otton == Status.RECONCILED)
                    .WithConsequence(() => Revolt.Add(-2))
                    .WithConsequence(() => Troops.Add(2)))
                .WithDecision("EVENTS_REVOLT_GENERAL_THE_FINAL_HOUR_DECISION_SAVE_YOUR_STRENGTH", decision => decision
                    .WithConsequence(() => Willpower.Add(10))
                    .WithConsequence(() => Revolt.Add(-1)))
                .Build());

            TheBattleForAnizotteVar1 = (new EventBuilder("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE")
                .WithRequirement(() => Revolt >= 6)
                .WithRequirement(() => Sophia != Status.LEADING_THE_REVOLT)
                .WithDecision("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE_DECISION_DEFEAT_THE_LEGION", decision => decision
                    .WithRequirement(() => Troops >= 2)
                    .WithRequirement(() => CommonFolk == 3)
                    .WithRequirement(() => TheRebel == true)
                    .WithRequirement(() => LeadingTheRevolt == true)
                    .WithConsequence(() => Power.Add(1))
                    .WithConsequence(() => Church.Add(1))
                    .WithConsequence(() => TheLegionIsDefeated.Check()))
                .WithDecision("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE_DECISION_ACHIEVE_PEACE", decision => decision
                    .WithRequirement(() => Power >= 3)
                    .WithRequirement(() => Power < 5)
                    .WithRequirement(() => Troops >= 1)
                    .WithRequirement(() => Nobles >= 1)
                    .WithRequirement(() => Clergy >= 2)
                    .WithRequirement(() => CommonFolk == 3)
                    .WithRequirement(() => TheRebel == true)
                    .WithRequirement(() => LeadingTheRevolt == true)
                    .WithConsequence(() => WealthOfMagra.Add(4))
                    .WithConsequence(() => Church.Add(1))
                    .WithConsequence(() => Order.Add(4))
                    .WithConsequence(() => APeaceWithTheOverseer.Check()))
                .WithDecision("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE_DECISION_DEFEND_THE_CITY", decision => decision
                    .WithRequirement(() => Willpower >= 10)
                    .WithRequirement(() => Troops >= 2)
                    .WithRequirement(() => CommonFolk >= 2)
                    .WithRequirement(() => TheRebel == true)
                    .WithRequirement(() => LeadingTheRevolt == true)
                    .WithConsequence(() => Willpower.Add(-20))
                    .WithConsequence(() => Power.Add(1))
                    .WithConsequence(() => Church.Add(1))
                    .WithConsequence(() => TheCityIsDefended.Check()))
                .WithDecision("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE_DECISION_DIE_IN_BATTLE_AGAINST_THE_REVOLT", decision => decision
                    .WithRequirement(() => TheRebel == false)
                    .WithConsequence(() => Deaths.Add(4))
                    .WithConsequence(() => Power.Add(-2))
                    .WithConsequence(() => Church.Add(-2))
                    .WithConsequence(() => Order.Add(-1))
                    .WithConsequence(() => WealthOfMagra.Add(-1))
                    .WithConsequence(() => Revolt.Add(-3))
                    .WithConsequence(() => DarkTimes.Check())
                    .WithConsequence(() => TrueDeath.Check()))
                .WithDecision("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE_DECISION_DIE_FOR_THE_REVOLT", decision => decision
                    .WithRequirement(() => TheDefenderOfTheEmpire == false)
                    .WithConsequence(() => Deaths.Add(4))
                    .WithConsequence(() => Power.Add(-2))
                    .WithConsequence(() => Church.Add(-2))
                    .WithConsequence(() => Order.Add(-1))
                    .WithConsequence(() => WealthOfMagra.Add(-1))
                    .WithConsequence(() => Revolt.Add(-3))
                    .WithConsequence(() => DarkTimes.Check())
                    .WithConsequence(() => TrueDeath.Check()))
                .WithDecision("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE_DECISION_FLEE_THE_CITY", decision => decision
                    .WithRequirement(() => Scheming >= 12)
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Power.Add(-2))
                    .WithConsequence(() => Church.Add(-2))
                    .WithConsequence(() => Order.Add(-1))
                    .WithConsequence(() => WealthOfMagra.Add(-1))
                    .WithConsequence(() => Revolt.Add(-3))
                    .WithConsequence(() => DarkTimes.Check())
                    .WithConsequence(() => EscapeFromTheCity.Check()))
                .Build());
            Events.Add(TheBattleForAnizotteVar1);

            TheBattleForAnizotteVar2 = (new EventBuilder("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE")
    .WithRequirement(() => Revolt >= 6)
    .WithRequirement(() => Sophia == Status.LEADING_THE_REVOLT)
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE_DECISION_ACCEPT_DEATH", decision => decision
        .WithRequirement(() => TheDefenderOfTheEmpire == true)
        .WithConsequence(() => Deaths.Add(4))
        .WithConsequence(() => TrueDeath.Check())
        .WithConsequence(() => Power.Add(2))
        .WithConsequence(() => Church.Add(1))
        .WithConsequence(() => Order.Add(-2))
        .WithConsequence(() => WealthOfMagra.Add(-2))
        .WithConsequence(() => TheAnizotteMassacre.Check()))
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE_DECISION_DEFY_SOPHIA", decision => decision
        .WithRequirement(() => TheDefenderOfTheEmpire == false)
        .WithConsequence(() => Deaths.Add(4))
        .WithConsequence(() => TrueDeath.Check())
        .WithConsequence(() => Power.Add(2))
        .WithConsequence(() => Church.Add(1))
        .WithConsequence(() => Order.Add(-2))
        .WithConsequence(() => WealthOfMagra.Add(-2))
        .WithConsequence(() => TheAnizotteMassacre.Check()))
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE_DECISION_TAKE_CHARGE_OF_THE_BLOODBATH", decision => decision
        .WithRequirement(() => TheRebel == true)
        .WithRequirement(() => Sophia >= 0)
        .WithConsequence(() => Power.Add(2))
        .WithConsequence(() => Church.Add(1))
        .WithConsequence(() => Order.Add(-2))
        .WithConsequence(() => WealthOfMagra.Add(-2))
        .WithConsequence(() => Tempest.Set(Status.TRUE_DEATH))
        .WithConsequence(() => TheAnizotteMassacre.Check()))
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE_DECISION_STOP_THE_SLAUGHTER", decision => decision
        .WithRequirement(() => Willpower >= 10)
        .WithRequirement(() => Troops >= 2)
        .WithRequirement(() => CommonFolk >= 2)
        .WithRequirement(() => TheRebel == true)
        .WithConsequence(() => Willpower.Add(-20))
        .WithConsequence(() => Deaths.Add(4))
        .WithConsequence(() => TrueDeath.Check())
        .WithConsequence(() => Power.Add(-8))
        .WithConsequence(() => Church.Add(-3))
        .WithConsequence(() => Order.Add(4))
        .WithConsequence(() => Revolt.Add(-10))
        .WithConsequence(() => TheRevoltIsDefeated.Check()))
    .WithDecision("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE_DECISION_FLEE", decision => decision
        .WithRequirement(() => Scheming >= 12)
        .WithConsequence(() => Willpower.Add(-5))
        .WithConsequence(() => Power.Add(2))
        .WithConsequence(() => Church.Add(1))
        .WithConsequence(() => Order.Add(-2))
        .WithConsequence(() => WealthOfMagra.Add(-2))
        .WithConsequence(() => TheAnizotteMassacre.Check())
        .WithConsequence(() => EscapeFromTheCity.Check()))
    .Build());
            Events.Add(TheBattleForAnizotteVar2);

            TheBattleForAnizotteVar3 = (new EventBuilder("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE")
                .WithRequirement(() => Revolt == 0)
                .WithDecision("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE_DECISION_CRUSH_THE_REBEL_FORCES", decision => decision
                    .WithRequirement(() => Power <= -1)
                    .WithRequirement(() => Troops >= 2)
                    .WithRequirement(() => Nobles == 3)
                    .WithRequirement(() => Clergy == 3)
                    .WithRequirement(() => CommonFolk >= 1)
                    .WithRequirement(() => Sophia != Status.EXECUTED)
                    .WithRequirement(() => TheDefenderOfTheEmpire == true)
                    .WithConsequence(() => Power.Add(-2))
                    .WithConsequence(() => Church.Add(-2))
                    .WithConsequence(() => Order.Add(4))
                    .WithConsequence(() => TheRevoltIsDefeated.Check()))
                .WithDecision("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE_DECISION_FORCE_THE_REBELS_TO_SURRENDER_THE_CITY", decision => decision
                    .WithRequirement(() => Power > -5)
                    .WithRequirement(() => Power <= -3)
                    .WithRequirement(() => Troops >= 1)
                    .WithRequirement(() => Nobles >= 2)
                    .WithRequirement(() => Clergy >= 2)
                    .WithRequirement(() => CommonFolk >= 2)
                    .WithRequirement(() => Sophia != Status.EXECUTED)
                    .WithRequirement(() => TheDefenderOfTheEmpire == true)
                    .WithConsequence(() => WealthOfMagra.Add(3))
                    .WithConsequence(() => Church.Add(-1))
                    .WithConsequence(() => Order.Add(5))
                    .WithConsequence(() => TheSurrenderOfTheRevolt.Check()))
                .WithDecision("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE_DECISION_GET_RID_OF_SOPHIA", decision => decision
                    .WithRequirement(() => Willpower >= 10)
                    .WithRequirement(() => Power <= -1)
                    .WithRequirement(() => Troops >= 2)
                    .WithRequirement(() => Nobles >= 1)
                    .WithRequirement(() => Clergy >= 1)
                    .WithRequirement(() => Sophia != Status.EXECUTED)
                    .WithRequirement(() => TheDefenderOfTheEmpire == true)
                    .WithConsequence(() => Willpower.Add(-20))
                    .WithConsequence(() => Deaths.Add(4))
                    .WithConsequence(() => Power.Add(-2))
                    .WithConsequence(() => Church.Add(-2))
                    .WithConsequence(() => Order.Add(4))
                    .WithConsequence(() => TheRevoltIsDefeated.Check())
                    .WithConsequence(() => TrueDeath.Check()))
                .WithDecision("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE_DECISION_ROUTE_THE_INSURGENTS", decision => decision
                    .WithRequirement(() => Power <= -1)
                    .WithRequirement(() => Troops >= 1)
                    .WithRequirement(() => CommonFolk >= 1)
                    .WithRequirement(() => Sophia == Status.EXECUTED)
                    .WithRequirement(() => TheDefenderOfTheEmpire == true)
                    .WithConsequence(() => Power.Add(-2))
                    .WithConsequence(() => Church.Add(-2))
                    .WithConsequence(() => Order.Add(4))
                    .WithConsequence(() => TheRevoltIsDefeated.Check()))
                .WithDecision("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE_DECISION_DIE_IN_BATTLE_AGAINST_THE_REVOLT", decision => decision
                    .WithConsequence(() => Deaths.Add(4))
                    .WithConsequence(() => Power.Add(-2))
                    .WithConsequence(() => Church.Add(-2))
                    .WithConsequence(() => Order.Add(-1))
                    .WithConsequence(() => WealthOfMagra.Add(-1))
                    .WithConsequence(() => Revolt.Add(2))
                    .WithConsequence(() => DarkTimes.Check())
                    .WithConsequence(() => TrueDeath.Check()))
                .WithDecision("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE_DECISION_FLEE_THE_CITY", decision => decision
                    .WithRequirement(() => Scheming >= 12)
                    .WithConsequence(() => Willpower.Add(-5))
                    .WithConsequence(() => Power.Add(-2))
                    .WithConsequence(() => Church.Add(-2))
                    .WithConsequence(() => Order.Add(-1))
                    .WithConsequence(() => WealthOfMagra.Add(-1))
                    .WithConsequence(() => Revolt.Add(2))
                    .WithConsequence(() => DarkTimes.Check())
                    .WithConsequence(() => EscapeFromTheCity.Check()))
                .Build());
            Events.Add(TheBattleForAnizotteVar3);

            TheBattleForAnizotteVar4 = (new EventBuilder("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE")
                .WithRequirement(() => Revolt >= 1)
                .WithRequirement(() => Revolt <= 6)
                .WithDecision("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE_DEFEND_THE_CITY", decision => decision
                    .WithRequirement(() => TheRebel == true)
                    .WithRequirement(() => LeadingTheRevolt == true)
                    .WithRequirement(() => Troops >= 2)
                    .WithRequirement(() => CommonFolk >= 2)
                    .WithRequirement(() => Willpower >= 10)
                    .WithConsequence(() => TheCityIsDefended.Check())
                    .WithConsequence(() => Power.Add(1))
                    .WithConsequence(() => Church.Add(1))
                    .WithConsequence(() => Willpower.Add(-20)))
                .WithDecision("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE_GET_RID_OF_SOPHIA", decision => decision
                    .WithRequirement(() => TheDefenderOfTheEmpire == true)
                    .WithRequirement(() => Power <= 1)
                    .WithRequirement(() => Troops >= 2)
                    .WithRequirement(() => Nobles >= 1)
                    .WithRequirement(() => Clergy >= 1)
                    .WithRequirement(() => Willpower >= 10)
                    .WithRequirement(() => Sophia != Status.SHE_IS_EXECUTED)
                    .WithConsequence(() => TheRevoltIsDefeated.Check())
                    .WithConsequence(() => TrueDeath.Check())
                    .WithConsequence(() => Order.Add(4))
                    .WithConsequence(() => Power.Add(-2))
                    .WithConsequence(() => Church.Add(-2))
                    .WithConsequence(() => Willpower.Add(-20))
                    .WithConsequence(() => Deaths.Add(4)))
                .WithDecision("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE_ROUTE_THE_INSURGENTS", decision => decision
                    .WithRequirement(() => TheDefenderOfTheEmpire == true)
                    .WithRequirement(() => Power <= 1)
                    .WithRequirement(() => Troops >= 1)
                    .WithRequirement(() => CommonFolk >= 1)
                    .WithRequirement(() => Sophia == Status.SHE_IS_EXECUTED)
                    .WithConsequence(() => TheRevoltIsDefeated.Check())
                    .WithConsequence(() => Power.Add(-2))
                    .WithConsequence(() => Church.Add(-2))
                    .WithConsequence(() => Order.Add(4)))
                .WithDecision("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE_DIE_IN_BATTLE_AGAINST_THE_REVOLT", decision => decision
                    .WithRequirement(() => TheRebel == false)
                    .WithConsequence(() => DarkTimes.Check())
                    .WithConsequence(() => TrueDeath.Check())
                    .WithConsequence(() => Power.Add(-2))
                    .WithConsequence(() => Church.Add(-2))
                    .WithConsequence(() => Order.Add(-1))
                    .WithConsequence(() => WealthOfMagra.Add(-1))
                    .WithConsequence(() => Deaths.Add(4)))
                .WithDecision("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE_DIE_FOR_THE_REVOLT", decision => decision
                    .WithRequirement(() => TheDefenderOfTheEmpire == false)
                    .WithConsequence(() => DarkTimes.Check())
                    .WithConsequence(() => TrueDeath.Check())
                    .WithConsequence(() => Power.Add(-2))
                    .WithConsequence(() => Church.Add(-2))
                    .WithConsequence(() => Order.Add(-1))
                    .WithConsequence(() => WealthOfMagra.Add(-1))
                    .WithConsequence(() => Deaths.Add(4)))
                .WithDecision("EVENTS_REVOLT_GENERAL_THE_BATTLE_FOR_ANIZOTTE_FLEE_THE_CITY", decision => decision
                    .WithRequirement(() => Scheming >= 12)
                    .WithConsequence(() => DarkTimes.Check())
                    .WithConsequence(() => EscapeFromTheCity.Check())
                    .WithConsequence(() => Power.Add(-2))
                    .WithConsequence(() => Church.Add(-2))
                    .WithConsequence(() => Order.Add(-1))
                    .WithConsequence(() => WealthOfMagra.Add(-1))
                    .WithConsequence(() => Willpower.Add(-5)))
                .Build());


            ANewDayDawns = (new EventBuilder("EVENTS_REVOLT_GENERAL_A_NEW_DAY_DAWNS")
                .WithRequirement(() => TrueDeath == false)
                .WithRequirement(() => EscapeFromTheCity == false)
                .WithHiddenRequirement(() => TheBattleForAnizotteVar1.HasPassed || TheBattleForAnizotteVar2.HasPassed || TheBattleForAnizotteVar3.HasPassed || TheBattleForAnizotteVar4.HasPassed)
                .WithDecision("EVENTS_REVOLT_GENERAL_A_NEW_DAY_DAWNS_DECISION_SAY_YOU_WOULD_GRANT_THE_WORLD_FORGIVENESS", decision => decision
                    .WithRequirement(() => Nathan == Status.PROPHET)
                    .WithHiddenConsequence(() => Nathan.Add(0)))
                .WithDecision("EVENTS_REVOLT_GENERAL_A_NEW_DAY_DAWNS_DECISION_SAY_YOU_WOULD_LEAVE_THE_WORLD_ALONE", decision => decision
                    .WithHiddenConsequence(() => Nathan.Add(0)))
                .WithDecision("EVENTS_REVOLT_GENERAL_A_NEW_DAY_DAWNS_DECISION_SAY_YOU_WOULD_TAKE_BETTER_CARE_OF_THE_WORLD", decision => decision
                    .WithHiddenConsequence(() => Nathan.Add(0)))
                .WithDecision("EVENTS_REVOLT_GENERAL_A_NEW_DAY_DAWNS_DECISION_SAY_YOU_WOULD_FREE_THE_MORTALS_FROM_THEIR_LOTS", decision => decision
                    .WithHiddenConsequence(() => Nathan.Add(0)))
                .WithDecision("EVENTS_REVOLT_GENERAL_A_NEW_DAY_DAWNS_DECISION_SAY_YOU_WOULD_DESTROY_THE_WORLD", decision => decision
                    .WithRequirement(() => TheAnizotteMassacre == true)
                    .WithHiddenConsequence(() => Nathan.Add(0)))
                .WithDecision("EVENTS_REVOLT_GENERAL_A_NEW_DAY_DAWNS_DECISION_SAY_NOTHING_AND_WALK_AWAY", decision => decision
                    .WithHiddenConsequence(() => Nathan.Add(0)))
                .Build());
            Events.Add(ANewDayDawns);
        }

        private void InitializeStats()
        {
            // Initialize lifetime stats
            Willpower = new Stat("STAT_LIFETIME_WILLPOWER", 0, -10, 30);
            Deaths = new Stat("STAT_LIFETIME_DEATHS", 0, 0, 4);

            // Initialize family stats
            Reputation = new FamilyStat("STAT_FAMILY_REPUTATION", 3);
            Wealth = new FamilyStat("STAT_FAMILY_WEALTH", 5);
            Unity = new FamilyStat("STAT_FAMILY_UNITY", 7);

            // Initialize province stats
            Order = new ProvinceStat("STAT_PROVINCE_ORDER", 8);
            WealthOfMagra = new ProvinceStat("STAT_PROVINCE_WEALTH_OF_MAGRA", 6);
            Power = new PowerStat("STAT_PROVINCE_POWER");
            Church = new PowerStat("STAT_PROVINCE_CHURCH");

            // Initialize youth stats
            Diplomacy = new AdultStat("STAT_YOUTH_DIPLOMACY");
            Valor = new AdultStat("STAT_YOUTH_VALOR");
            Theology = new AdultStat("STAT_YOUTH_THEOLOGY");
            Eloquence = new AdultStat("STAT_YOUTH_ELOQUENCE");
            Manipulation = new AdultStat("STAT_YOUTH_MANIPULATION");
            Scheming = new AdultStat("STAT_YOUTH_SCHEMING");

            // Initialize childhood stats
            Determination = new ChildhoodStat("STAT_CHILDHOOD_DETERMINATION", Eloquence, Valor, Scheming);
            Perception = new ChildhoodStat("STAT_CHILDHOOD_PERCEPTION", Diplomacy, Manipulation, Theology);

            // Initialize adolescence stats
            Nobility = new ChildhoodStat("STAT_ADOLESCENCE_NOBILITY", Diplomacy, Valor);
            Ingenuity = new ChildhoodStat("STAT_ADOLESCENCE_INGENUITY", Manipulation, Scheming);
            Spirituality = new ChildhoodStat("STAT_ADOLESCENCE_SPIRITUALITY", Eloquence, Theology);

            // Initialize peace time stats
            Career = new OccupationStat("STAT_OCCUPATION_JUDGE_CAREER");
            Justice = new OccupationStat("STAT_OCCUPATION_JUDGE_JUSTICE");
            Inquisition = new OccupationStat("STAT_OCCUPATION_INQUISITOR_INQUISITION_POWER");
            Tolerance = new OccupationStat("STAT_OCCUPATION_INQUISITOR_TOLERANCE_OF_FAITHS");
            Unrest = new OccupationStat("STAT_OCCUPATION_CONSPIRATOR_UNREST");
            Network = new OccupationStat("STAT_OCCUPATION_CONSPIRATOR_SPY_NETWORK");

            // Initialize revolt stats;
            Revolt = new ProvinceStat("STAT_REVOLT_REVOLT", 0);
            Troops = new RevoltStat("STAT_REVOLT_TROOPS");
            Nobles = new RevoltStat("STAT_REVOLT_NOBLES");
            Clergy = new RevoltStat("STAT_REVOLT_CLERGY");
            CommonFolk = new RevoltStat("STAT_REVOLT_COMMON_FOLK");

            LifetimeStats = new List<Stat> { Willpower, Deaths };
            AdultStats = new List<Stat> { Diplomacy, Valor, Theology, Eloquence, Manipulation, Scheming };
            ChildhoodStats = new List<Stat> { Determination, Perception };
            AdolescenceStats = new List<Stat> { Nobility, Ingenuity, Spirituality };
            OccupationStats = new List<Stat> { Network, Unrest };
            RevoltStats = new List<Stat> { Revolt, Nobles, Clergy, CommonFolk, Troops };
            FamilyStats = new List<Stat> { Reputation, Wealth, Unity };
            ProvinceStats = new List<Stat> { Power, Church, Order, WealthOfMagra };

        }

        private void InitializeFlags()
        {
            // Initialize childhood flags
            TheFencingLesson = new Flag("FLAG_CHILDHOOD_THE_FENCING_LESSON");
            NoblemansSacrament = new Flag("FLAG_CHILDHOOD_NOBLEMANS_SACRAMENT");
            Insight = new Flag("FLAG_CHILDHOOD_INSIDE");
            Beyond = new Flag("FLAG_CHILDHOOD_BEYOND");

            // Initialize adolescence flags
            GloriasSecret = new Flag("FLAG_ADOLESCENCE_GLORIAS_SECRET");
            StephansDisgrace = new Flag("FLAG_ADOLESCENCE_STEPHANS_DISGRACE");
            BloodTide = new Flag("FLAG_ADOLESCENCE_BLOOD_TIDE");
            NathansAdmonition = new Flag("FLAG_ADOLESCENCE_NATHANS_ADMONITION");
            MattersOfTheHeart = new Flag("FLAG_ADOLESCENCE_MATTERS_OF_THE_HEART");
            RevelationOfTheTree = new Flag("FLAG_ADOLESCENCE_REVELEATION_OF_THE_TREE");
            SophiaSaved = new Flag("FLAG_ADOLESCENCE_SOPHIA_SAVED");

            // Initialize youth flags
            PathOfTheLotless = new Flag("FLAG_YOUTH_PATH_OF_THE_LOTLESS");
            PathOfThePriest = new Flag("FLAG_YOUTH_PATH_OF_THE_PRIEST");
            PathOfTheNobleman = new Flag("FLAG_YOUTH_PATH_OF_THE_NOBLEMAN");
            TrueDeath = new Flag("FLAG_YOUTH_TRUE_DEATH");
            AylissRescue = new Flag("FLAG_YOUTH_AYLISS_RESCUE");
            CollapseOfTheLotless = new Flag("FLAG_YOUTH_COLLAPSE_OF_THE_LOTLESS");
            TheLotlessAtLarge = new Flag("FLAG_YOUTH_THE_LOTLESS_AT_LARGE");
            BondOfFriendship = new Flag("FLAG_YOUTH_BOND_OF_FRIENDSHIP");
            ShieldOfTheNewFaith = new Flag("FLAG_YOUTH_SHIELD_OF_THE_NEW_FAITH");
            ShieldOfTheOldFaith = new Flag("FLAG_YOUTH_SHIELD_OF_THE_OLD_FAITH");
            VictoryInTheTournament = new Flag("FLAG_YOUTH_VICTORY_IN_THE_TOURNAMENT");


            // Initialize peace time general flags
            TheLaTariRitual = new Flag("FLAG_PEACETIME_GENERAL_THE_LA_TARI_RITUAL");
            TheFamilyInRuins = new Flag("FLAG_PEACETIME_GENERAL_THE_FAMILY_IN_RUINS");
            TheFamilyFallsApart = new Flag("FLAG_PEACETIME_GENERAL_THE_FAMILY_FALLS_APART");
            BrandedByDishonor = new Flag("FLAG_PEACETIME_GENERAL_BRANDED_BY_DISHONOR");
            AFamilyOfMeans = new Flag("FLAG_PEACETIME_GENERAL_A_FAMILY_OF_MEANS");
            AGloriousBloodline = new Flag("FLAG_PEACETIME_GENERAL_A_GLORIOUS_BLOODLINE");
            EnnobledByTheSword = new Flag("FLAG_PEACETIME_GENERAL_ENNOBLED_BY_THE_SWORD");
            FavoredByTheOverseer = new Flag("FLAG_PEACETIME_GENERAL_FAVORED_BY_THE_OVERSEER");
            GloriaBrante = new Flag("FLAG_PEACETIME_GENERAL_GLORIA_BRANTE");
            Heir = new Flag("FLAG_PEACETIME_GENERAL_HEIR");
            HeirOfTheFamily = new Flag("FLAG_PEACETIME_GENERAL_HEIR_OF_THE_FAMILY");
            MotherRecovers = new Flag("FLAG_PEACETIME_GENERAL_MOTHER_RECOVERS");
            FamilyAtPeace = new Flag("FLAG_PEACETIME_GENERAL_FAMILY_AT_PEACE");
            TommasNewLife = new Flag("FLAG_PEACETIME_GENERAL_TOMMAS_NEW_LIFE");

            //Peace time conspirator flags
            ProfitableBusiness = new Flag("FLAG_PEACETIME_CONSPIRATOR_PROFITABLE_BUSINESS");
            StashOfGunpowder = new Flag("FLAG_PEACETIME_CONSPIRATOR_STASH_OF_GUNPOWDER");
            SophiaHasTheGunpowder = new Flag("FLAG_PEACETIME_CONSPIRATOR_SOPHIA_HAS_THE_GUNPOWDER");
            StockpileOfArms = new Flag("FLAG_PEACETIME_CONSPIRATOR_STOCKPILE_OF_ARMS");

            //Peace time judge flags
            ProtectorOfThePeople = new Flag("FLAG_PEACETIME_JUDGE_PROTECTOR_OF_THE_PEOPLE");
            CourtOfHonorBanned = new Flag("FLAG_PEACETIME_JUDGE_COURT_OF_HONOR_BANNED");
            EvidenceAgainstOtton = new Flag("FLAG_PEACETIME_JUDGE_EVIDENCE_AGAINST_OTTON");
            PatronageOfThePowerful = new Flag("FLAG_PEACETIME_JUDGE_PATRONAGE_OF_THE_POWERFUL");

            BrokenChains = new Flag("FLAG_PEACETIME_JUDGE_BROKEN_CHAINS");
            NightOfTheSerpents = new Flag("FLAG_PEACETIME_JUDGE_NIGHT_OF_THE_SERPENTS");
            OttonIsSentenced = new Flag("FLAG_PEACETIME_JUDGE_OTTON_IS_SENTENCED");
            OttonFacesTheCourtOfHonor = new Flag("FLAG_PEACETIME_JUDGE_OTTON_FACES_THE_COURT_OF_HONOR");

            //Peace time conspirator flags
            ProfitableBusiness = new Flag("FLAG_PEACETIME_CONSPIRATOR_PROFITABLE_BUSINESS");
            StashOfGunpowder = new Flag("FLAG_PEACETIME_CONSPIRATOR_STASH_OF_GUNPOWDER");
            SophiaHasTheGunpowder = new Flag("FLAG_PEACETIME_CONSPIRATOR_SOPHIA_HAS_THE_GUNPOWDER");
            StockpileOfArms = new Flag("FLAG_PEACETIME_CONSPIRATOR_STOCKPILE_OF_ARMS");

            TheLastStrawsRevolt = new Flag("FLAG_PEACETIME_CONSPIRATOR_THE_LAST_STRAWS_REVOLT");
            FarewellAdvisor = new Flag("FLAG_PEACETIME_CONSPIRATOR_FAREWELL_ADVISOR");
            FreeMan = new Flag("FLAG_PEACETIME_CONSPIRATOR_FREE_MAN");
            MasterOfAnizotte = new Flag("FLAG_PEACETIME_CONSPIRATOR_MASTER_OF_ANIZOTTE");
            TheFreeCity = new Flag("FLAG_PEACETIME_CONSPIRATOR_THE_FREE_CITY");
            GloryToTheEmpire = new Flag("FLAG_PEACETIME_CONSPIRATOR_GLORY_TO_EMPIRE");

            //Peace time inquisitor flags
            RightToDefendTheFaith = new Flag("FLAG_PEACETIME_INQUISITOR_RIGHT_TO_DEFEND_THE_FAITH");
            CollapseOfTheInquisition = new Flag("FLAG_PEACETIME_INQUISITOR_COLLAPSE_OF_THE_INQUISITION");
            TheNewFaithPersecuted = new Flag("FLAG_PEACETIME_INQUISITOR_THE_NEW_FAITH_PERSECUTED");
            EvidenceAgainstCassius = new Flag("FLAG_PEACETIME_INQUISITOR_EVIDENCE_AGAINST_CASSIUS");

            TorchOfTheNewFaith = new Flag("FLAG_PEACETIME_INQUISITOR_TORCH_OF_THE_NEW_FAITH");
            AllPowerfulUlrich = new Flag("FLAG_PEACETIME_INQUISITOR_ALL_POWERFUL_ULRICH");
            CassiusFacesTheTribunal = new Flag("FLAG_PEACETIME_INQUISITOR_CASSIUS_FACES_THE_TRIBUNAL");
            CassiusOverthrow = new Flag("FLAG_PEACETIME_INQUISITOR_CASSIUS_OVERTHROW");
            ShadowOfTheWill = new Flag("FLAG_PEACETIME_INQUISITOR_SHADOW_OF_THE_WILL");

            //Revolt flags
            TheRebel = new Flag("FLAG_REVOLT_THE_REBEL");
            TheDefenderOfTheEmpire = new Flag("FLAG_REVOLT_THE_DEFENDER_OF_THE_EMPIRE");
            EscapeFromTheCity = new Flag("FLAG_REVOLT_ESCAPE_FROM_THE_CITY");
            LeadingTheRevolt = new Flag("FLAG_REVOLT_LEADING_THE_REVOLT");
            TheFamilyInTheCity = new Flag("FLAG_REVOLT_THE_FAMILY_IN_THE_CITY");
            TheFamilyHasPerished = new Flag("FLAG_REVOLT_THE_FAMILY_HAS_PERISHED");
            TheFamilyIsSaved = new Flag("FLAG_REVOLT_THE_FAMILY_IS_SAVED");
            TheFamilyFledFromTheCity = new Flag("FLAG_REVOLT_THE_FAMILY_FLED_FROM_THE_CITY");
            DarkTimes = new Flag("FLAG_REVOLT_DARK_TIMES");
            TheAnizotteMassacre = new Flag("FLAG_REVOLT_THE_ANIZOTTE_MASSACRE");
            TheRevoltIsDefeated = new Flag("FLAG_REVOLT_THE_REVOLT_IS_DEFEATED");
            TheSurrenderOfTheRevolt = new Flag("FLAG_REVOLT_THE_SURRENDER_OF_THE_REVOLT");
            TheCityIsDefended = new Flag("FLAG_REVOLT_THE_CITY_IS_DEFENDED");
            TheLegionIsDefeated = new Flag("FLAG_REVOLT_THE_LEGION_IS_DEFEATED");
            APeaceWithTheOverseer = new Flag("FLAG_REVOLT_A_PEACE_WITH_THE_OVERSEER");

            Flags = new List<Flag>
            {
                TheFencingLesson, NoblemansSacrament, Insight, Beyond,
                GloriasSecret, StephansDisgrace, BloodTide, NathansAdmonition, MattersOfTheHeart, RevelationOfTheTree, SophiaSaved,
                PathOfTheLotless, PathOfThePriest, PathOfTheNobleman, TrueDeath, AylissRescue, CollapseOfTheLotless, TheLotlessAtLarge, BondOfFriendship, ShieldOfTheNewFaith, ShieldOfTheOldFaith, VictoryInTheTournament,
                TheLaTariRitual, TheFamilyInRuins, TheFamilyFallsApart, BrandedByDishonor, AFamilyOfMeans, AGloriousBloodline, EnnobledByTheSword, FavoredByTheOverseer, GloriaBrante, Heir, HeirOfTheFamily, MotherRecovers, FamilyAtPeace, TommasNewLife,
                ProfitableBusiness, StashOfGunpowder, SophiaHasTheGunpowder, StockpileOfArms, TheLastStrawsRevolt, FarewellAdvisor, FreeMan, MasterOfAnizotte, TheFreeCity, GloryToTheEmpire,
                ProtectorOfThePeople, CourtOfHonorBanned, EvidenceAgainstOtton, PatronageOfThePowerful, BrokenChains, NightOfTheSerpents, OttonIsSentenced, OttonFacesTheCourtOfHonor,
                RightToDefendTheFaith, CollapseOfTheInquisition, TheNewFaithPersecuted, EvidenceAgainstCassius, TorchOfTheNewFaith, AllPowerfulUlrich, CassiusFacesTheTribunal, CassiusOverthrow, ShadowOfTheWill,
                TheRebel, TheDefenderOfTheEmpire, EscapeFromTheCity, LeadingTheRevolt, TheFamilyInTheCity, TheFamilyHasPerished, TheFamilyIsSaved, TheFamilyFledFromTheCity, DarkTimes, TheAnizotteMassacre, TheRevoltIsDefeated, TheSurrenderOfTheRevolt, TheCityIsDefended, TheLegionIsDefeated, APeaceWithTheOverseer
            };
        }

        private void InitializeCharacters()
        {
            Gregor = new Character("CHARACTER_GREGOR_BRANTE", -1);
            Robert = new Character("CHARACTER_ROBERT_BRANTE", 2);
            Lydia = new Character("CHARACTER_LYDIA_BRANTE", 2);
            Stephan = new Character("CHARACTER_STEPHAN_BRANTE", 1);
            Gloria = new Character("CHARACTER_GLORIA", 1);
            Nathan = new Character("CHARACTER_NATHAN_BRANTE", 1);

            Tommas = new Character("CHARACTER_TOMMAS_GUERRO", 0);
            ElBorne = new Character("CHARACTER_AUGUSTIN_EL_BORNE", 1);

            Sophia = new Character("CHARACTER_SOPHIA", 0);
            Octavia = new Character("CHARACTER_OCTAVIA_MILANIDAS", 0);
            Jeanne = new Character("CHARACTER_JEANNE", 0);
            Otton = new Character("CHARACTER_DORIUS_OTTON", -1);

            Ulrich = new Character("CHARACTER_FATHER_ULRICH", 0);
            Felipe = new Character("CHARACTER_FELIPE_EL_FERRO", -1);
            Aylis = new Character("CHARACTER_AYLIS", 0);

            Tempest = new Character("CHARACTER_GAIUS_TEMPEST", 0);
            Milanidas = new Character("CHARACTER_DUTCH_MILANIDAS", 0);
            Egmont = new Character("CHARACTER_MAYER_EGMONT", 0);
            Mark = new Character("CHARACTER_FATHER_MARK", 0);
            ElVerman = new Character("CHARACTER_REMY_EL_VERMAN", 0);
            Lennart = new Character("CHARACTER_FATHER_LENNART", 0);
            Cassius = new Character("CHARACTER_PATRIARCH_CASSIUS", 0);
            Silvan = new Character("CHARACTER_SILVAN_SAMOSTA", 0);

            Characters = new List<Character> { Gregor, Robert, Lydia, Stephan, Gloria, Nathan, Tommas, Sophia, ElBorne, Octavia, Jeanne, Otton, Felipe, Tempest, Milanidas, Egmont, Mark, ElVerman, Lennart, Cassius, Silvan };
        }

        public void Reset()
        {
            InitializeStats();
            InitializeCharacters();
            InitializeFlags();

            foreach (Event gameEvent in Events)
            {
                gameEvent.HasPassed = false;
            }
        }
    }
}
