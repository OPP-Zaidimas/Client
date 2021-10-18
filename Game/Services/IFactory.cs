namespace Game.Services
{
    public interface IFactory<out T>
    {
        public T Create(int id);
    }
}
