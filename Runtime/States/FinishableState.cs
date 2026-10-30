namespace M320.StateMachineSystem
{
    public class FinishableState : State, IFinishable
    {
        virtual public bool IsFinished { get; protected set; }
        void IFinishable.SetIsFinished(bool isFinished) => IsFinished = isFinished;

        #region Constructors

        public FinishableState(StateName name) : base(name) { }
        public FinishableState() : base() { }

        #endregion
    }
    public class FinishableState<TContext> : FinishableState
    {
        new protected TContext Context;

        #region Constructors

        public FinishableState(StateName name) : base(name) { }
        public FinishableState() : base() { }

        #endregion

        internal override void SetContext(object context)
        {
            base.SetContext(context);
            Context = (TContext)context;
        }
    }
}
