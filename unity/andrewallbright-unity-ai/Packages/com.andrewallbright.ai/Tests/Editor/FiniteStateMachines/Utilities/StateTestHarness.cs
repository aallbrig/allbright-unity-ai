using Editor.FiniteStateMachines;

namespace Tests.Editor.FiniteStateMachines.Utilities
{
    public static class StateTestHarness
    {
        public static void RunState(IState state)
        {
            state.Enter();
            state.Execute();
            state.Exit();
        }
    }
}