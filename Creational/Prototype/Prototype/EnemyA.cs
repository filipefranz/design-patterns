namespace Prototype
{
    public class EnemyA : Enemy, IEnemyPrototype
    {
        public Enemy DeepCopy()
        {
            var result = (Enemy)this.MemberwiseClone();
            result.Gun = new Gun("Knife");
            return result;
        }

        public Enemy ShallowCopy()
        {
            return (Enemy)this.MemberwiseClone();
        }
    }
}
