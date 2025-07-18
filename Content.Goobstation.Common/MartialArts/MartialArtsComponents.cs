// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Aidenkrz <aiden@djkraz.com>
// SPDX-FileCopyrightText: 2025 GoobBot <uristmchands@proton.me>
// SPDX-FileCopyrightText: 2025 Lincoln McQueen <lincoln.mcqueen@gmail.com>
// SPDX-FileCopyrightText: 2025 Misandry <mary@thughunt.ing>
// SPDX-FileCopyrightText: 2025 NazrinNya <137837419+NazrinNya@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 ReserveBot <211949879+ReserveBot@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 echotry <xippl1@mail.ru>
// SPDX-FileCopyrightText: 2025 gluesniffler <159397573+gluesniffler@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 gluesniffler <linebarrelerenthusiast@gmail.com>
// SPDX-FileCopyrightText: 2025 gus <august.eymann@gmail.com>
// SPDX-FileCopyrightText: 2025 nazrin <tikufaev@outlook.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Robust.Shared.Analyzers;
using Robust.Shared.GameObjects;
using Robust.Shared.GameStates;
using Robust.Shared.Serialization.Manager.Attributes;

namespace Content.Goobstation.Common.MartialArts;

[RegisterComponent]
public sealed partial class MartialArtBlockedComponent : Component
{
    [DataField]
    public MartialArtsForms Form;
}
public abstract partial class GrabStagesOverrideComponent : Component
{
    public GrabStage StartingStage = GrabStage.Soft;
}

[RegisterComponent]
[NetworkedComponent]
[AutoGenerateComponentState]
public sealed partial class MartialArtsKnowledgeComponent : GrabStagesOverrideComponent
{
    [DataField]
    [AutoNetworkedField]
    public MartialArtsForms MartialArtsForm = MartialArtsForms.CloseQuartersCombat;

    [DataField]
    [AutoNetworkedField]
    public bool Blocked;

    [DataField]
    [AutoNetworkedField]
    public float OriginalFistDamage;

    [DataField]
    [AutoNetworkedField]
    public string OriginalFistDamageType;

}

public enum MartialArtsForms
{
    CorporateJudo,
    CloseQuartersCombat,
    SleepingCarp,
}
