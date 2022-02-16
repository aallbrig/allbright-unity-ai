using System.Collections.Generic;
using Editor.FiniteStateMachines;

namespace Tests.Editor.FiniteStateMachines.TestDoubles
{
    public class SpyState : IState
    {
        private string _id;

        public int EnterCallCount;
        public int ExitCallCount;
        public int UpdateCallCount;
        public SpyState(List<ITransition> transitions) => Transitions = transitions;

        public string Id => _id ??= State.GenerateId();

        public void Enter() => EnterCallCount++;
        public void Execute() => UpdateCallCount++;
        public void Exit() => ExitCallCount++;

        public List<ITransition> Transitions { get; }
    }
}