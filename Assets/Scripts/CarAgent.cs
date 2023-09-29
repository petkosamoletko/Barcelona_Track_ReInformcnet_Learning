using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using System.Collections.Generic;

public class CarAgent : Agent
{
    public class CheckpointData
    {
        public Transform NextTarget { get; set; }
        public float Reward { get; set; }

        public CheckpointData(Transform nextTarget, float reward)
        {
            NextTarget = nextTarget;
            Reward = reward;
        }
    }

    public float speed = 10f;
    public float rotationSpeed = 100f;
    public float maxSteeringAngle = 45f;
    public float steeringSpeed = 1f;

    public Transform checkpoint1;
    public Transform checkpoint2;
    public Transform checkpoint3;
    public Transform checkpoint4;
    public Transform checkpoint5;
    public Transform checkpoint6;
    public Transform checkpoint7;
    public Transform checkpoint8;
    public Transform checkpoint9;    
    public Transform checkpoint10;
    public Transform checkpoint11;
    public Transform checkpoint12;
    public Transform checkpoint13;
    public Transform checkpoint14;
    public Transform checkpoint15;
    public Transform checkpoint16;
    public Transform checkpoint17;
    public Transform checkpoint18;
    public Transform checkpoint19;
    public Transform checkpoint20;
    public Transform checkpoint21;
    public Transform checkpoint22;    
    public Transform checkpoint23;
    public Transform checkpoint24;
    public Transform checkpoint25;
    public Transform checkpoint26;
    public Transform checkpoint27;
    public Transform checkpoint28;
    public Transform checkpoint29;
    public Transform checkpoint30;
    public Transform checkpoint31;
    public Transform checkpoint32;
    public Transform checkpoint33;
    public Transform checkpoint34;    
    public Transform checkpoint35;
    public Transform checkpoint36;
    public Transform checkpoint37;
    public Transform checkpoint38;
    public Transform checkpoint39;
    public Transform checkpoint40;
    public Transform checkpoint41;
    public Transform checkpoint42;
    public Transform checkpoint43;    
    public Transform checkpoint44;
    public Transform checkpoint45;
    public Transform checkpoint46;
    public Transform checkpoint47;
    public Transform checkpoint48;
    public Transform checkpoint49;
    public Transform checkpoint50;
    public Transform checkpoint51;
    public Transform checkpoint52;
    public Transform checkpoint53;
    public Transform checkpoint54;
    public Transform checkpoint55;
    public Transform checkpoint56;
    public Transform checkpoint57;
    public Transform checkpoint58;
    public Transform checkpoint59;
    public Transform checkpoint60;
    public Transform checkpoint61;
    public Transform checkpoint62;
    public Transform checkpoint63;
    public Transform checkpoint64;
    public Transform checkpoint65;
    public Transform checkpoint66;
    public Transform checkpoint67;
    public Transform checkpoint68;
    public Transform checkpoint69;
    public Transform checkpoint70;
    public Transform checkpoint71;
    public Transform checkpoint72;
    public Transform checkpoint73;
    public Transform checkpoint74;
    public Transform checkpoint75;
    public Transform checkpoint76;
    public Transform checkpoint77;
    public Transform checkpoint78;
    public Transform checkpoint79;
    public Transform checkpoint80;
    public Transform checkpoint81;
    public Transform checkpoint82;
    public Transform finishLine;

    private Rigidbody rb;
    private Vector3 startPosition;
    private Quaternion startRotation;
    private HashSet<string> visitedCheckpoints;
    private float episodeStartTime;
    private float timeStartedFalling;
    private float fallingThreshold = -5f;
    private float maxFallingTime = 1f;

    private Transform currentTarget;

    private Dictionary<string, CheckpointData> checkpointDictionary;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;
        startRotation = transform.rotation;
        visitedCheckpoints = new HashSet<string>();
        episodeStartTime = Time.time;

        checkpointDictionary = new Dictionary<string, CheckpointData>
        {
            { "Checkpoint1", new CheckpointData(checkpoint2, 50f) },
            { "Checkpoint2", new CheckpointData(checkpoint3, 50f) },
            { "Checkpoint3", new CheckpointData(checkpoint4, 50f) },
            { "Checkpoint4", new CheckpointData(checkpoint5, 50f) },
            { "Checkpoint5", new CheckpointData(checkpoint6, 50f) },
            { "Checkpoint6", new CheckpointData(checkpoint7, 50f) },
            { "Checkpoint7", new CheckpointData(checkpoint8, 50f) },
            { "Checkpoint8", new CheckpointData(checkpoint9, 50f) },
            { "Checkpoint9", new CheckpointData(checkpoint10, 50f) },
            { "Checkpoint10", new CheckpointData(checkpoint11, 100f) },
            { "Checkpoint11", new CheckpointData(checkpoint12, 100f) },
            { "Checkpoint12", new CheckpointData(checkpoint13, 100f) },
            { "Checkpoint13", new CheckpointData(checkpoint14, 100f) },
            { "Checkpoint14", new CheckpointData(checkpoint15, 100f) },
            { "Checkpoint15", new CheckpointData(checkpoint16, 100f) },
            { "Checkpoint16", new CheckpointData(checkpoint17, 100f) },
            { "Checkpoint17", new CheckpointData(checkpoint18, 100f) },
            { "Checkpoint18", new CheckpointData(checkpoint19, 100f) },
            { "Checkpoint19", new CheckpointData(checkpoint20, 100f) },
            { "Checkpoint20", new CheckpointData(checkpoint21, 150f) },
            { "Checkpoint21", new CheckpointData(checkpoint22, 150f) },
            { "Checkpoint22", new CheckpointData(checkpoint23, 150f) },
            { "Checkpoint23", new CheckpointData(checkpoint24, 150f) },
            { "Checkpoint24", new CheckpointData(checkpoint25, 150f) },
            { "Checkpoint25", new CheckpointData(checkpoint26, 150f) },
            { "Checkpoint26", new CheckpointData(checkpoint27, 150f) },
            { "Checkpoint27", new CheckpointData(checkpoint28, 150f) },
            { "Checkpoint28", new CheckpointData(checkpoint29, 150f) },
            { "Checkpoint29", new CheckpointData(checkpoint30, 150f) },
            { "Checkpoint30", new CheckpointData(checkpoint31, 150f) },
            { "Checkpoint31", new CheckpointData(checkpoint32, 200f) },
            { "Checkpoint32", new CheckpointData(checkpoint33, 200f) },
            { "Checkpoint33", new CheckpointData(checkpoint34, 200f) },
            { "Checkpoint34", new CheckpointData(checkpoint35, 200f) },
            { "Checkpoint35", new CheckpointData(checkpoint36, 200f) },
            { "Checkpoint36", new CheckpointData(checkpoint37, 200f) },
            { "Checkpoint37", new CheckpointData(checkpoint38, 200f) },
            { "Checkpoint38", new CheckpointData(checkpoint39, 200f) },
            { "Checkpoint39", new CheckpointData(checkpoint40, 200f) },
            { "Checkpoint40", new CheckpointData(checkpoint41, 200f) },
            { "Checkpoint41", new CheckpointData(checkpoint42, 250f) },
            { "Checkpoint42", new CheckpointData(checkpoint43, 250f) },
            { "Checkpoint43", new CheckpointData(checkpoint44, 250f) },
            { "Checkpoint44", new CheckpointData(checkpoint45, 250f) },
            { "Checkpoint45", new CheckpointData(checkpoint46, 250f) },
            { "Checkpoint46", new CheckpointData(checkpoint47, 250f) },
            { "Checkpoint47", new CheckpointData(checkpoint48, 250f) },
            { "Checkpoint48", new CheckpointData(checkpoint49, 250f) },
            { "Checkpoint49", new CheckpointData(checkpoint50, 250f) },
            { "Checkpoint50", new CheckpointData(checkpoint51, 250f) },
            { "Checkpoint51", new CheckpointData(checkpoint52, 300f) },
            { "Checkpoint52", new CheckpointData(checkpoint53, 300f) },
            { "Checkpoint53", new CheckpointData(checkpoint54, 300f) },
            { "Checkpoint54", new CheckpointData(checkpoint55, 300f) },
            { "Checkpoint55", new CheckpointData(checkpoint56, 300f) },
            { "Checkpoint56", new CheckpointData(checkpoint57, 300f) },
            { "Checkpoint57", new CheckpointData(checkpoint58, 300f) },
            { "Checkpoint58", new CheckpointData(checkpoint59, 300f) },
            { "Checkpoint59", new CheckpointData(checkpoint60, 300f) },
            { "Checkpoint60", new CheckpointData(checkpoint61, 300f) },
            { "Checkpoint61", new CheckpointData(checkpoint62, 350f) },
            { "Checkpoint62", new CheckpointData(checkpoint63, 350f) },
            { "Checkpoint63", new CheckpointData(checkpoint64, 350f) },
            { "Checkpoint64", new CheckpointData(checkpoint65, 350f) },
            { "Checkpoint65", new CheckpointData(checkpoint66, 350f) },
            { "Checkpoint66", new CheckpointData(checkpoint67, 350f) },
            { "Checkpoint67", new CheckpointData(checkpoint68, 350f) },
            { "Checkpoint68", new CheckpointData(checkpoint69, 350f) },
            { "Checkpoint69", new CheckpointData(checkpoint70, 350f) },
            { "Checkpoint70", new CheckpointData(checkpoint71, 350f) },
            { "Checkpoint71", new CheckpointData(checkpoint72, 400f) },
            { "Checkpoint72", new CheckpointData(checkpoint73, 400f) },
            { "Checkpoint73", new CheckpointData(checkpoint74, 400f) },
            { "Checkpoint74", new CheckpointData(checkpoint75, 400f) },
            { "Checkpoint75", new CheckpointData(checkpoint76, 400f) },
            { "Checkpoint76", new CheckpointData(checkpoint77, 400f) },
            { "Checkpoint77", new CheckpointData(checkpoint78, 400f) },
            { "Checkpoint78", new CheckpointData(checkpoint79, 400f) },
            { "Checkpoint79", new CheckpointData(checkpoint80, 450f) },
            { "Checkpoint80", new CheckpointData(checkpoint81, 450f) },
            { "Checkpoint81", new CheckpointData(checkpoint82, 450f) },
            { "Checkpoint82", new CheckpointData(finishLine, 450f) }
        };

        currentTarget = checkpoint1;
    }

    public override void OnActionReceived(ActionBuffers actions)
    {
        float forwardAmount = (actions.ContinuousActions[0] + 1) * 0.5f;         
        float minSpeed = 0.15f; 
        forwardAmount = Mathf.Clamp(forwardAmount, minSpeed, 1f);

        float turnAmount = actions.ContinuousActions[1];
        if(Mathf.Abs(forwardAmount) > 0.14f) 
        {
            transform.Rotate(0, turnAmount * maxSteeringAngle * steeringSpeed * Time.fixedDeltaTime, 0);
        }

        rb.MovePosition(transform.position + transform.forward * forwardAmount * speed * Time.fixedDeltaTime);
        AddReward(-0.1f);

        if (rb.velocity.y <= fallingThreshold)
        {
            if (timeStartedFalling == 0)
            {
                timeStartedFalling = Time.time;
            }
            else if (Time.time - timeStartedFalling >= maxFallingTime)
            {
                AddReward(-10f);  
                OnEpisodeBegin();
            }
        }
        else
        {
            timeStartedFalling = 0; 
        }
    }

    public override void Heuristic(in ActionBuffers actionsOut)
    {
        ActionSegment<float> continuousActions = actionsOut.ContinuousActions;
        continuousActions[0] = Input.GetAxis("Vertical");
        continuousActions[1] = Input.GetAxis("Horizontal");
    }

    private void OnTriggerEnter(Collider other)
    {
        string tag = other.tag;

        if (!visitedCheckpoints.Contains(tag))
        {
            if (checkpointDictionary.ContainsKey(tag))
            {
                CheckpointData data = checkpointDictionary[tag];
                AddReward(data.Reward);
                visitedCheckpoints.Add(tag);
                currentTarget = data.NextTarget; 
            }
            else if (tag.Equals("Finish"))
            {
                AddReward(700f);
                EndEpisode();
            }
            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            AddReward(-5f);
            EndEpisode();
        }
    }

    public override void OnEpisodeBegin()
    {
        transform.position = startPosition;
        transform.rotation = startRotation;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        visitedCheckpoints.Clear();
        episodeStartTime = Time.time;
        timeStartedFalling = 0;

        currentTarget = checkpoint1;
    }   

    private Transform[] GetNextCheckpoints(string currentCheckpoint, int numNext = 2)
    {
        Transform[] nextCheckpoints = new Transform[numNext];
        
        for(int i = 0; i < numNext; i++)
        {
            if (checkpointDictionary.ContainsKey(currentCheckpoint))
            {
                nextCheckpoints[i] = checkpointDictionary[currentCheckpoint].NextTarget;
                currentCheckpoint = nextCheckpoints[i].name;
            }
            else
            {
                nextCheckpoints[i] = null;
            }
        }
        
        return nextCheckpoints;
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        // Observe the direction to the current target
        Vector3 toTarget = (currentTarget.position - transform.position).normalized;
        sensor.AddObservation(toTarget);

        // Observe the agent's current speed
        sensor.AddObservation(rb.velocity.magnitude);

        //Observe the next checkpoints dynamically.
        Transform[] nextCheckpoints = GetNextCheckpoints(currentTarget.name);
        
        foreach(Transform checkpoint in nextCheckpoints)
        {
            if (checkpoint != null) 
            {
                Vector3 toNextTarget = (checkpoint.position - transform.position).normalized;
                sensor.AddObservation(toNextTarget);
            }
            else
            {
                // Dummy values added, if there are less than 2 targets
                sensor.AddObservation(Vector3.zero);
            }
        }
    }
}

