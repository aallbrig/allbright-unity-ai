using Editor.FiniteStateMachines;

namespace Tests.Editor.FiniteStateMachines.TestDoubles
{
    public class FakeTransition : ITransition
    {
        public bool IsValid() => true;
        public IState NextState() => new FakeState();
        public void OnTransition() {}
    }
}