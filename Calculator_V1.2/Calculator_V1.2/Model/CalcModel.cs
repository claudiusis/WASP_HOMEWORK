namespace Calculator_V1._2.Model
{
    public class CalcModel
    {
        private char _action;
        private double _num1;
        private double _num2;

        public char Action { get => _action; set => _action = value; }
        public double Num1 { get => _num1; set => _num1 = value; }
        public double Num2 { get => _num2; set => _num2 = value; }

        public void ActionPressed(char action)
        {
            Action = action;
        }

        public string EqualPressed(double num1,double num2, char action)
        {
            switch (action)
            {
                case '+':
                    return (num1+num2).ToString();
                case '-':
                    return (num1-num2).ToString();
                case '÷' when num2 != 0: 
                    return (num1/num2).ToString();
                case '÷' when num2 == 0:
                    return "На ноль делить нельзя";
                case '×':
                    return (num1*num2).ToString();
                default:
                    throw new NotImplementedException("This action was not implemented");
            }
        }
    }
}
