// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    public class LayerManager
    {
        public const int LAYER_ENVIRONMENT = 31;
        public static readonly LayerMask environmentLayer;
        public const int LAYER_LIGHT_COLLIDER = 26;
        public const int LAYER_ITEMONLY = 9;
        public const int LAYER_LOCALPLAYERONLYTRIGGER = 7;
        public const int LAYER_LOCALPLAYER = 6;
        public const int LAYER_NAVPOINT = 15;
        public const int LAYER_SOUND_COLLIDER = 27;
        public const int LAYER_ITEMHELD = 10;
        public const int LAYER_ITEM = 12;
        public const int LAYER_KILLZONE = 21;
        public const int LAYER_PLAYERONLYTRIGGER = 20;
        public const int LAYER_PLAYER = 8;
        public const int LAYER_MONSTER = 11;
        public const int LAYER_ENVIRONMENT_INTERACTIVE = 13;
        public static readonly LayerMask environmentInteractive;
        public static readonly LayerMask playerLayer;
        public static readonly LayerMask itemLayer;
        public static readonly LayerMask itemHeldLayer;
        public static readonly LayerMask detectItemLayer;
        public static readonly LayerMask playerOnlyTriggerLayer;
        public static readonly LayerMask killZoneLayer;
        public static readonly LayerMask monsterLayer;
        public static readonly LayerMask navPointLayer;
        public static readonly LayerMask localPlayerOnlyTriggerLayer;
        public static readonly LayerMask itemOnlyLayer;
        public static readonly LayerMask lightColliderLayer;
        public static readonly LayerMask soundColliderLayer;

        static LayerManager()
        {
            environmentLayer = 1 << LAYER_ENVIRONMENT;
            environmentInteractive = 1 << LAYER_ENVIRONMENT_INTERACTIVE;
            playerLayer = 1 << LAYER_PLAYER;
            itemLayer = 1 << LAYER_ITEM;
            itemHeldLayer = 1 << LAYER_ITEMHELD;
            detectItemLayer = itemLayer | itemHeldLayer;
            playerOnlyTriggerLayer = 1 << LAYER_PLAYERONLYTRIGGER;
            killZoneLayer = 1 << LAYER_KILLZONE;
            monsterLayer = 1 << LAYER_MONSTER;
            navPointLayer = 1 << LAYER_NAVPOINT;
            localPlayerOnlyTriggerLayer = 1 << LAYER_LOCALPLAYERONLYTRIGGER;
            itemOnlyLayer = 1 << LAYER_ITEMONLY;
            lightColliderLayer = 1 << LAYER_LIGHT_COLLIDER;
            soundColliderLayer = 1 << LAYER_SOUND_COLLIDER;
        }

        public LayerManager()
        {
        }
    }
}