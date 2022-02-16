using System.Collections.Generic;
using Editor.FiniteStateMachines;

namespace Tests.Editor.FiniteStateMachines.TestDoubles
{
    public class FakeState : IState
    {

        private string _id;

        private List<ITransition> _transitions;
        public void Enter() {}
        public void Execute() {}
        public void Exit() {}

        public string Id => _id ??= State.GenerateId();

        public List<ITransition> Transitions => _transitions ??= new List<ITransition>();
    }
}