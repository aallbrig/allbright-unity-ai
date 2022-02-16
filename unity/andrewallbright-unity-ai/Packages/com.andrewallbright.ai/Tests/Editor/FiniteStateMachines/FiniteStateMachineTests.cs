using Editor.FiniteStateMachines;
using NUnit.Framework;
using Tests.Editor.FiniteStateMachines.TestDoubles;

namespace Tests.Editor.FiniteStateMachines
{
    public class FiniteStateMachineTests
    {
        [Test]
        public void FiniteStateMachines_CanTransitionToANewState()
        {
            var state1 = new FakeState();
            var state2 = new FakeState();
            var transitionToState2 = new Transition(() => true, () => state2);
            state1.Transitions.Add(transitionToState2);
            var sut = new FiniteStateMachine(state1);

            sut.Evaluate();

            Assert.AreNotSame(state1.Id, sut.CurrentState.Id);
            Assert.AreSame(state2.Id, sut.CurrentState.Id);
        }
    }
}