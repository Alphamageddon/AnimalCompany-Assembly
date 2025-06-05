// Decompiled with Xera AI Decompiler
using System.Collections.Generic;

namespace AnimalCompany.GameGen
{
    public class GraphGenerationResult
    {
        public Dictionary<IGenerationNode, NodeGenerationResult> nodeResults;
        public List<List<NodeGenerationResult>> nodeResultsByZone;
        public List<NavZone> navZones;

        public GraphGenerationResult()
        {
            nodeResults = new Dictionary<IGenerationNode, NodeGenerationResult>();
            nodeResultsByZone = new List<List<NodeGenerationResult>>();
            navZones = new List<NavZone>();
        }
    }
}