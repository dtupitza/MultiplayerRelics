using BaseLib.Abstracts;
using BaseLib.Extensions;
using MultiplayerRelics.MultiplayerRelicsCode.Extensions;
using Godot;

namespace MultiplayerRelics.MultiplayerRelicsCode.Powers;

public abstract class MultiplayerRelicsPower : CustomPowerModel
{
    //Loads from MultiplayerRelics/images/powers/your_power.png
    public override string CustomPackedIconPath => $"{Id.Entry.RemovePrefix().ToLowerInvariant()}.png".PowerImagePath();
    public override string CustomBigIconPath => $"{Id.Entry.RemovePrefix().ToLowerInvariant()}.png".BigPowerImagePath();
}