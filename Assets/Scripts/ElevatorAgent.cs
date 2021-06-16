using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using UnityEngine;

public class ElevatorAgent : Agent
{
    public float scenarioDuration;
    public ScenarioObject ScenarioObject;

    public List<Elevator> Elevators;
    private Queue<Call> calls = new Queue<Call>();
    
    private void Start()
    {
        
    }

    private void Update()
    {
        UpdateElevators();
    }

    private void UpdateElevators()
    {
        if (calls.Count > 0)
        {
            DecideElevator(calls.Dequeue());
        }
    }

    private void DecideElevator(Call call)
    {
        
    }

    private IEnumerator UpdateScenario(List<Call> calls)
    {
        float elapsed = 0;

        int count = 0;
        while (count >= calls.Count)
        {
            var call = calls[count];
            
            
            elapsed += Time.deltaTime;
            if (elapsed > scenarioDuration)
            {
                count += 1;
            }
            yield return null;   
        }
    }

    private void StartScenario(Call call)
    {
        
    }

    private void CallElevator(Call call)
    {
        
    }

    private Elevator GetClosetElevator(int floorNum)
    {
        var el = Elevators[0];
        for (int i = 0; i < Elevators.Count; i++)
        {
            if (Mathf.Abs(floorNum - Elevators[i].Floor) <
                Mathf.Abs(floorNum - el.Floor))
                el = Elevators[i];
        }

        return el;
    }

    public override void OnEpisodeBegin()
    {
        
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        
    }

    public override void OnActionReceived(ActionBuffers actions)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

    public override void Heuristic(in ActionBuffers actionsOut)
    {
         
    }
}
