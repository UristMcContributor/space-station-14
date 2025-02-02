﻿using System;
using Robust.Shared.GameObjects;
using Robust.Shared.Serialization;

namespace Content.Shared.Body.Components
{
    public abstract class SharedBodyScannerComponent : Component
    {
    }

    [Serializable, NetSerializable]
    public enum BodyScannerUiKey
    {
        Key
    }

    [Serializable, NetSerializable]
    public class BodyScannerUIState : BoundUserInterfaceState
    {
        public readonly EntityUid Uid;

        public BodyScannerUIState(EntityUid uid)
        {
            Uid = uid;
        }
    }
}
