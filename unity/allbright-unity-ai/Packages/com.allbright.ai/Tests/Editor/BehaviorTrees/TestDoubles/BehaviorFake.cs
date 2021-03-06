using Editor.BehaviorTrees.BuildingBlocks;

namespace Tests.Editor.BehaviorTrees.TestDoubles
{
    public class BehaviorFake : Behavior
    {
        protected override void Initialize() {}
        protected override Status Execute() => Status.Success;
        protected override void Terminate() {}
    }
}