
namespace Others
{
    public interface ITimer
    {
        bool Ready { get; }

        void SetNumCycles(int newNCycles);

        void UpdateState();

        void Reset();
    }
}
