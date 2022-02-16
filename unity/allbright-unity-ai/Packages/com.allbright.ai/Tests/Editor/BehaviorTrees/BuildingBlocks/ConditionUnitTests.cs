using System;
using Editor.BehaviorTrees.BuildingBlocks;
using NUnit.Framework;
using Tests.Editor.BehaviorTrees.Utilities;

namespace Tests.Editor.BehaviorTrees.BuildingBlocks
{
    public class ConditionUnitTests
    {
        [Test]
        public void Condition_Succeeds_WhenPredicateEvaluatesTrue()
        {
            var predicate = new Func<bool>(() => true);
            var sut = new Condition(predicate);

            BehaviorTestHarness.RunToComplete(sut);

            Assert.AreEqual(Behavior.Status.Success, sut.CurrentStatus);
        }

        [Test]
        public void Condition_Fails_WhenPredicateEvaluatesFalse()
        {
            var predicate = new Func<bool>(() => false);
            var sut = new Condition(predicate);

            BehaviorTestHarness.RunToComplete(sut);

            Assert.AreEqual(Behavior.Status.Failure, sut.CurrentStatus);
        }
    }
}