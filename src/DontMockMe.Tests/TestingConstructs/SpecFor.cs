namespace DontMockMe.Tests.TestingConstructs
{
    public abstract class SpecFor<T> where T : class 
    {
        protected T subject;

        protected SpecFor()
        {
            Context();
            Because();
        }

        ~SpecFor()
        {
            CleanUp();
        }

        public abstract void Context();
        public abstract void Because();
        public virtual void CleanUp() { }
    }
}