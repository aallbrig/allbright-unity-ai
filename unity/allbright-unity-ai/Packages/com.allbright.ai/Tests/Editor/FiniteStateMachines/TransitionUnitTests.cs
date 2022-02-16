using Editor.FiniteStateMachines;
using NUnit.Framework;
using Tests.Editor.FiniteStateMachines.TestDoubles;
using Tests.Editor.FiniteStateMachines.Utilities;

namespace Tests.Editor.FiniteStateMachines
{
    public class TransitionUnitTests
    {
        [Test]
        public void Transitions_ReturnNextState_WhenIsValidIsTrue()
        {
            var fakeState = new FakeState();
            var sut = new Transition(() => true, () => fakeState);

            var result = TransitionTestHarness.RunTransition(sut);

            Assert.AreSame(fakeState.Id, result?.Id);
        }

        [Test]
        public void Transitions_NoResult_WhenIsValidIsFalse()
        {
            var sut = new Transition(() => false, () => new FakeState());

            var result = TransitionTestHarness.RunTransition(sut);

            Assert.IsNull(result);
        }
    }
}