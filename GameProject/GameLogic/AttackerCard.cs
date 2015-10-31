namespace GameLogic
{
    public class AttackerCard : CreatureCard
    {
        /// <summary>
        ///     Сила удара
        /// </summary>
        public int PowerOfAttack { get; set; }

        public override string ToString()
        {
            return "Атакующая карта: " + Name;
        }
    }
}