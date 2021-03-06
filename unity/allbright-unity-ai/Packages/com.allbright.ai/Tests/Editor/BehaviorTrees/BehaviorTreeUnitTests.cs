using System.Collections.Generic;
using Editor.BehaviorTrees;
using Editor.BehaviorTrees.Behaviors;
using Editor.BehaviorTrees.BuildingBlocks;
using NUnit.Framework;
using Tests.Editor.BehaviorTrees.TestDoubles;

namespace Tests.Editor.BehaviorTrees
{
    public class BehaviorTreeUnitTests
    {
        [Test]
        public void BehaviorTrees_CanBeTicked()
        {
            var spyBehavior = new BehaviorSpy(() => Behavior.Status.Success);
            var sut = new BehaviorTree(spyBehavior);

            sut.Tick();

            Assert.IsTrue(spyBehavior.InitializeMethodCalled);
            Assert.IsTrue(spyBehavior.ExecuteMethodCalled);
            Assert.IsTrue(spyBehavior.TerminateMethodCalled);
        }

        [Test]
        public void BehaviorTree_CanPrintTreeStructure()
        {
            var behaviorA = new Sequence(new List<Behavior> { new BehaviorFake(), new BehaviorFake() });
            var behaviorB = new Sequence(new List<Behavior> { new BehaviorFake(), new BehaviorFake(), new BehaviorFake() });
            var root = new Sequence(new List<Behavior> { behaviorA, behaviorB });
            var sut = new BehaviorTree(root);
            var expectedResult = @"Behavior Tree
 Sequence
- Sequence
-- BehaviorFake
-- BehaviorFake
- Sequence
-- BehaviorFake
-- BehaviorFake
-- BehaviorFake
";

            var result = sut.PrintTree();

            Assert.AreEqual(expectedResult, result);
        }
    }
}