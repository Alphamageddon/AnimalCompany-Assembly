// Decompiled with Xera AI Decompiler
using System.Collections.Generic;
using UnityEngine;

namespace AnimalCompany.GameGen
{
    public class TreeRoomsArchetype : Archetype, IGenerationNode, IForceNodeIcon, IForceNodeTitle
    {
        public List<Tileset> tilesets;
        
        [Range(0, 1)]
        [Tooltip("[TODO] How likely is the generator to pick multiple rooms to branch to from a single room. Branch is tested per room until it fails or there are no more sockets. Branches do not affect the possible archetype connections which are always chosen by the remaining sockets after generation.")]
        public float branchChance;
        
        [Range(-1, 1)]
        [Tooltip("[TODO] How likely is the generator to try to pick new rooms in a straight line. With 0 the generator will pick random sockets, with 1 the it will always pick a straight line if possible, -1 it will always avoid a straight line if possible.")]
        public float straighten;

        public override string NodeIcon
        {
            get { return get_NodeIcon(); }
        }

        public override string NodeTitle
        {
            get { return get_NodeTitle(); }
        }

        public TreeRoomsArchetype()
        {
            branchChance = 0.25f;
        }

        public override NodeGenerationResponse Generate(Socket source, Generator generator)
        {
            return new NodeGenerationResponse();
        }

        public override string get_NodeIcon()
        {
            return "TreeRooms";
        }

        public override string get_NodeTitle()
        {
            return "Tree Rooms";
        }
    }
}