using Robust.Shared.Serialization;

namespace Content.Shared.Shuttles.Components
{
    [Serializable, NetSerializable]
    public enum ThrusterVisualState : byte
    {
        State,
        Thrusting,
    }

    [Serializable, NetSerializable]
    public sealed class ThrusterToggleMessage : BoundUserInterfaceMessage;
}
