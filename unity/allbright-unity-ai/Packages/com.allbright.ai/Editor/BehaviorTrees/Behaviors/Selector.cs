using System.Collections.Generic;
using Editor.BehaviorTrees.BuildingBlocks;

namespace Editor.BehaviorTrees.Behaviors
{
    public class Selector : Composite
    {
        public Selector(List<Behavior> children) : base(children) {}

        protected override Status Execute()
        {
            var currentChild = Children[CurrentIndex];
            var childStatus = currentChild.Evaluate();

            if (childStatus != Status.Failure)
                CurrentStatus = childStatus;
            else
                CurrentStatus = ++CurrentIndex == Children.Count ? Status.Failure : Status.Running;

            return CurrentStatus;
        }
    }
}