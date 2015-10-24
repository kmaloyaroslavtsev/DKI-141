namespace GameLogic
{
    /// <summary>
    ///     Карты - существа
    /// </summary>
    public abstract class CreatureCard : Card
    {
        /// <summary>
        ///     Здоровье карты
        /// </summary>
        public int Health { get; set; }
    }
}