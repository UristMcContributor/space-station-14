using Robust.Shared.GameObjects;
using Robust.Shared.ViewVariables;

namespace Content.Server.Mind.Components
{
    [RegisterComponent]
    public sealed class VisitingMindComponent : Component
    {
        [ViewVariables] public Mind Mind { get; set; } = default!;

        protected override void OnRemove()
        {
            base.OnRemove();

            Mind?.UnVisit();
        }
    }

    public class MindUnvisitedMessage : EntityEventArgs
    {
    }
}
