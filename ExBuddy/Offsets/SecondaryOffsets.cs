﻿namespace ExBuddy.Offsets
{
    using System;

    using ExBuddy.Attributes;
    using ff14bot;

    public static class RequestOffsets
    {
        [Offset("Search B9 ? ? ? ? C7 45 ? ? ? ? ? E8 ? ? ? ? 8B 7D 0C Add 1 Read32")]
        [Offset64("Search 48 8D 0D ? ? ? ? E8 ? ? ? ? 48 0F BF CF  Add 3 TraceRelative")]
        public static IntPtr ItemBasePtr;
#if RB_X64
        public static int ItemSize = 0x90;
#else
        public static int ItemSize = 0x78;
#endif

    }

    public static class ScripsOffsets
    {
        // TODO: Real data is a struct with 2 vals, uint ItemId and 4byte val
        [Offset("Search 89 0C C5 ? ? ? ? 5F Add 3 Read32")]
        public static IntPtr BasePtr;

#if RB_X64
        public static int BlueGathererOffset = 0x10;
        public static int RedCrafterOffset = 0x8;
        public static int RedGathererOffset = 0x18;
        public static int CenturioSealsOffset = 0x20;
        public static int WeeklyRedCrafterOffset = 0x24;
        public static int WeeklyRedGathererOffset = 0x28;
#else
        public static int BlueGathererOffset = 0x10;
        public static int RedCrafterOffset = 0x8;
        public static int RedGathererOffset = 0x18;
        public static int CenturioSealsOffset = 0x20;
        public static int WeeklyRedCrafterOffset = 0x24;
        public static int WeeklyRedGathererOffset = 0x28;
#endif
    }


    public static class GatheringMasterpieceOffsets
    {
        [Offset("Search 89 86 ? ? ? ? E8 ? ? ? ? 8B 86 ? ? ? ? 8B 8E ? ? ? ? 6A 00 6A 00 6A 00 6A 00 50 E8 ? ? ? ? F6 47 30 0F Add 2 Read32", true)]
        public static int CurrentRarityOffset;
    }

    public static class GuildLeveOffsets
    {
        [Offset("Search 88 15 ? ? ? ? 66 8B 48 06 Add 2 Read32")]
        public static IntPtr AllowancesPtr;
    }

    public static class AetherialReductionOffsets
    {
        public static int CurrentBagSlotOffset = 0x38;
        public static int PurityOffset = 0x3C;
        public static int MaxPurityOffset = 0x40;
    }

    public static class DesynthesisOffsets
    {
        public static int CurrentBagSlotOffset = 0x2D0;
    }
}