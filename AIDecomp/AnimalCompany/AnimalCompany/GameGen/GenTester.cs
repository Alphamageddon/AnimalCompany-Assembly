// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany.GameGen
{
    public class GenTester : MonoBehaviour
    {
        public GenGraph graph;
        public Socket socket;
        private Generator gen;

        public GenTester()
        {
        }

        public void GenerateOnSocket()
        {
            if (graph == null)
            {
                Debug.LogError("GenGraph is null!");
                return;
            }

            if (socket == null)
            {
                Debug.LogError("Socket is null!");
                return;
            }

            gen = new Generator(graph);

            int attempts = 0;
            int maxAttempts = Random.Range(0, 34464);
            bool success = false;

            while (attempts < maxAttempts && gen != null)
            {
                success = gen.Generate(socket, null, maxAttempts, 0, true, false);
                if (success)
                    break;
                attempts++;
            }

            Debug.Log("Generation completed after " + attempts.ToString() + " attempts");
            Debug.Log("Generation result: " + (success ? "Success" : "Failed"));
        }
    }
}