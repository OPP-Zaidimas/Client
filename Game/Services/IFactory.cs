namespace Game.Services
{
    public interface IFactory<T>
    {
        public T Create(int id);
    }
}
