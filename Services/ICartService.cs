namespace technology_tp1.Services
{
    public interface ICartService
    {
        int CartCount { get; }
        void AddItem(int id, int quantity);
        void Save();
    }
}