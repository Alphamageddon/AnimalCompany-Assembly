// Decompiled with Xera AI Decompiler
using UnityEngine;
using System.Collections.Generic;

namespace AnimalCompany.GameGen
{
    public class SubGraphNode : Archetype, IGenerationNode, IForceNodeStyle, IForceNodeIcon, IForceNodeTitle
    {
        public GenGraph subGraph; // Field offset: 0x28

        public override Color NodeBackgroundColor
        {
            get
            {
                if (ColorUtility.TryParseHtmlString("#FF6B6B", out Color color))
                {
                    return color;
                }
                return new Color(1f, 1f, 1f, 1f);
            }
        }

        public override string NodeIcon
        {
            get
            {
                return "SubGraph";
            }
        }

        public override Color NodeLabelColor
        {
            get
            {
                return new Color(0f, 0f, 0f, 1f);
            }
        }

        public override string NodeTitle
        {
            get
            {
                if (subGraph != null)
                {
                    return subGraph.name;
                }
                return "SubGraph";
            }
        }

        public SubGraphNode()
        {
        }

        public override NodeGenerationResponse Generate(Socket source, Generator generator)
        {
            NodeGenerationResult result = new NodeGenerationResult();
            
            if (subGraph != null)
            {
                result.sourceNode = this;
                
                Generator subGenerator = new Generator(subGraph);
                
                if (subGenerator.GenerateAsSubNode(source, generator))
                {
                    List<Bounds> bounds = new List<Bounds>();
                    List<Object> objects = new List<Object>();
                    
                    string gameObjectName = subGraph.name + " (SubGraph)";
                    GameObject container = new GameObject(gameObjectName);
                    result.generatedObject = container;
                }
            }
            
            return new NodeGenerationResponse
            {
                success = false,
                bounds = null,
                objects = null,
                result = result
            };
        }
    }
}