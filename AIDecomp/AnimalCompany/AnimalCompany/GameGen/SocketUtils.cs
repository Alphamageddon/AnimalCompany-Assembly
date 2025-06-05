// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany.GameGen
{
    public static class SocketUtils
    {
        public static void DrawSocketGizmo(Socket socket, float opacity = 1f, bool wire = true)
        {
            if (socket == null) return;

            Color originalColor = Gizmos.color;
            
            // Get socket position and size
            Vector3 position = socket.transform.position;
            Vector3 size = socket.GetSize();
            
            // Set gizmo color with opacity
            Color gizmoColor = originalColor;
            gizmoColor.a *= opacity * 0.25f;
            Gizmos.color = gizmoColor;
            
            if (wire)
            {
                // Draw wire cube
                Gizmos.DrawWireCube(position, size * 0.5f);
            }
            
            // Draw solid cube with reduced opacity
            gizmoColor.a = originalColor.a * opacity * 0.5f;
            Gizmos.color = gizmoColor;
            Gizmos.DrawCube(position, size * 0.5f);
            
            // Restore original color
            Gizmos.color = originalColor;
            
            // Draw connection lines
            Vector3 forward = socket.transform.forward;
            Vector3 up = socket.transform.up;
            Vector3 right = socket.transform.right;
            
            // Draw directional lines
            Gizmos.DrawLine(position, position + forward * size.z * 0.5f);
            Gizmos.DrawLine(position, position - forward * size.z * 0.5f);
            Gizmos.DrawLine(position + up * size.y, position + up * size.y + forward * size.z);
            Gizmos.DrawLine(position + right * size.x, position + right * size.x + forward * size.z);
        }
    }
}