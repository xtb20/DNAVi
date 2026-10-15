using UnityEngine;

public class DecisionNode : MonoBehaviour
{
    public string nodeID = "Node";

    [Tooltip("Enable only when node arrivals are not recorded by the teleport controller.")]
    public bool countStepsOnTriggerEnter = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        NodeTracker tracker = FindFirstObjectByType<NodeTracker>();

        if (countStepsOnTriggerEnter && tracker != null)
        {
            tracker.RegisterNode(nodeID);
        }

        Debug.Log("Decision node entered: " + nodeID);
    }
}
