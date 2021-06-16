using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Call
{
    public int FloorOn;
    public int FloorOff;
}

[CreateAssetMenu(fileName = "Scenario", menuName = "Create Scenario")]
public class ScenarioObject : ScriptableObject
{
    public List<Call> Calls;

}
