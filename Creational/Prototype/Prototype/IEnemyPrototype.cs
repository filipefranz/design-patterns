namespace Prototype
{
    public interface IEnemyPrototype
    {
        Enemy ShallowCopy();
        Enemy DeepCopy();
    }
}
