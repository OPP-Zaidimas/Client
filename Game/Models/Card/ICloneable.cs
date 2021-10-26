namespace Game.Models.Card
{
    public interface ICloneable<out T>
    {
        T Clone();
    }
}
