using System;

public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int penaltyPoints) : base(name, description, penaltyPoints)
    {
    }

    public override int RecordEvent()
    {
        // Subtracts values as performance deterrent
        return -_points;
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString()
    {
        return $"[!] {_shortName} ({_description}) -- Penalty: -{_points} points per occurrence";
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{_shortName},{_description},{_points}";
    }
}