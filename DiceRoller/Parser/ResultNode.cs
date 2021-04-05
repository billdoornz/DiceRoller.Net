namespace DiceRoller.Parser
{
    public class ResultNode
    {
        public float Value { get; private set; }
        public string Breakdown { get; private set; }

        public ResultNode(int value) : this(value, value.ToString())
        {
        }

        public ResultNode(float value) : this(value, value.ToString())
        {
        }

        public ResultNode(float value, string breakdown)
        {
            Value = value;
            Breakdown = breakdown;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}