using System.Collections.Generic;
using Editor.BehaviorTrees.BuildingBlocks;

namespace Editor.BehaviorTrees.Behaviors
{
    public class Sequence : Composite
    {
        public Sequence(List<Behavior> children) : base(children) {}

        protected override Status Execute()
        {
            var child = Children[CurrentIndex];
            var childStatus = child.Evaluate();

            if (childStatus != Status.Success)
                CurrentStatus = childStatus;
            else
                CurrentStatus = ++CurrentIndex == Children.Count ? Status.Success : Status.Running;

            return CurrentStatus;
        }
    }
}