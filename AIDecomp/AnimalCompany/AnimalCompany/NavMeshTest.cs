using UnityEngine;
using UnityEngine.AI;

namespace AnimalCompany
{
    public class NavMeshTest : MonoBehaviour
    {
        public Transform target1;
        public Transform target2;
        public NavMeshAgent agent;

        private void Start()
        {
            agent = GetComponent<NavMeshAgent>();
            if (agent != null)
            {
                agent.updatePosition = true;
                agent.updateRotation = true;
                if (target1 != null)
                {
                    agent.SetDestination(target1.position);
                }
            }
        }

        private void Update()
        {
            if (agent != null && agent.enabled)
            {
                HandleMovementInput();
                HandleTargetSwitching();
            }
        }

        private void HandleMovementInput()
        {
            float deltaTime = Time.deltaTime;
            Vector3 moveDirection = Vector3.zero;
            
            if (Input.GetKey(KeyCode.W))
            {
                moveDirection += transform.forward * deltaTime;
            }
            if (Input.GetKey(KeyCode.S))
            {
                moveDirection -= transform.forward * deltaTime;
            }
            if (Input.GetKey(KeyCode.A))
            {
                moveDirection -= transform.right * deltaTime;
            }
            if (Input.GetKey(KeyCode.D))
            {
                moveDirection += transform.right * deltaTime;
            }
            
            if (moveDirection != Vector3.zero)
            {
                agent.Move(moveDirection);
            }
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                agent.isStopped = !agent.isStopped;
            }
        }

        private void HandleTargetSwitching()
        {
            if (target1 != null && target2 != null)
            {
                Vector3 currentPos = transform.position;
                Vector3 target1Pos = target1.position;
                Vector3 target2Pos = target2.position;
                
                float distanceToTarget1 = Vector3.Distance(currentPos, target1Pos);
                float distanceToTarget2 = Vector3.Distance(currentPos, target2Pos);
                
                if (distanceToTarget1 < 1.0f)
                {
                    agent.SetDestination(target2Pos);
                }
                else if (distanceToTarget2 < 1.0f)
                {
                    agent.SetDestination(target1Pos);
                }
            }
        }
    }
}