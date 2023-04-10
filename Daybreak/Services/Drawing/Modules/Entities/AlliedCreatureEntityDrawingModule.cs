﻿using Daybreak.Models.Guildwars;
using Daybreak.Services.Drawing.Modules.Primitives;
using System.Windows.Media;

namespace Daybreak.Services.Drawing.Modules.Entities;

public sealed class AlliedCreatureEntityDrawingModule : TriangleTargetedEntityDrawingModuleBase
{
    protected override Color FillColor { get; } = Colors.Green;

    public override bool CanDrawEntity(IEntity entity)
    {
        return entity is LivingEntity livingEntity &&
            livingEntity.Allegiance is LivingEntityAllegiance.SpiritOrPet or LivingEntityAllegiance.Minion;
    }
}
