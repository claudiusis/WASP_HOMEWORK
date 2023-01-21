using Calculator_V1._2.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Exception = System.Exception;

namespace Calculator_V1._2.ViewModel
{
    public class CalcViewModel : INotifyPropertyChanged
    {
        private string _labelstr;
        public CalcModel calculator { get; set; }


        public ICommand DigitPressed => new Command<string>(AddDigit);
        public ICommand SignPressed => new Command<string>(AddSign);
        public ICommand EqualPressed => new Command<string>(Equal);
        public ICommand ClearPressed => new Command(Clear);

        public string Labelstr
        {
            get => _labelstr;
            set
            {
                if (_labelstr == value) return;
                _labelstr = value;
                OnPropertyChanged();
            }
        }

        private void RefreshCanExecutes()
        {
            ((Command)DigitPressed).ChangeCanExecute();
            ((Command)SignPressed).ChangeCanExecute();
            ((Command)EqualPressed).ChangeCanExecute();
        }

        public CalcViewModel()
        {
            calculator = new CalcModel();
            Labelstr= string.Empty;
            RefreshCanExecutes();
        }

        public void AddDigit(string digit)
        {
            Labelstr += digit;
        }

        public void AddSign(string sgn)
        {
            if (Labelstr== string.Empty && Convert.ToChar(sgn) == '-')
            {
                Labelstr+= sgn;
            }

            else if ((Labelstr!=string.Empty) &&((Char.IsDigit(Labelstr[Labelstr.Length - 1]) || (Labelstr[Labelstr.Length - 1] != '-' && Convert.ToChar(sgn) == '-'))))
            {
                Labelstr += sgn;
            }
            else if (calculator.Action != '\0' && !Char.IsDigit(Labelstr[Labelstr.Length - 1]))
            {
                Labelstr = Labelstr.Substring(0, Labelstr.Length - 1);
                Labelstr += sgn;
            }
            try
            {
                if (Labelstr.Length > 1 && (Char.IsDigit(Labelstr[Labelstr.Length - 2])))
                {
                    calculator.ActionPressed(Convert.ToChar(sgn));
                }
                
            }
            catch (Exception e)
            {
                throw new Exception("ERROR!");
            }   
        }

        public void Equal(string str)
        {
            try
            {
                Console.WriteLine("action: " + calculator.Action);
                Console.WriteLine("action: " + calculator.Action);
                Console.WriteLine("str: " + str);
                if (calculator.Action != default)
                {
                    if (Labelstr.Split('\n').Length == 2)
                    {
                        Labelstr = Labelstr.Split('\n').Last();
                        str= Labelstr.Split('\n').Last();
                    }

                    if (Labelstr.Split(calculator.Action).First() == "" || Labelstr.Split(calculator.Action).Last() == "")
                    {
                        return;
                    }
                    if (Labelstr.Split(calculator.Action).Length== 3)
                    {
                        
                        calculator.Num1 = Convert.ToDouble("-"+(str.Split(calculator.Action)[1]));
                        
                    }
                    else
                    {
                        calculator.Num1 = Convert.ToDouble(str.Split(calculator.Action).First());
                    }
                    calculator.Num2 = Convert.ToDouble(str.Split(calculator.Action).Last());
                    Labelstr += "\n"+calculator.EqualPressed(calculator.Num1, calculator.Num2, calculator.Action);
                    calculator.Action = default;
                    calculator.Num1 = default;
                    calculator.Num2 = default;
                }
            }
            catch (Exception e)
            {
                throw new Exception("ERROR");
            }
        }

        public void Clear()
        {
            Labelstr= string.Empty;
            calculator.Action = default;
            calculator.Num1 = default;
            calculator.Num2 = default;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string str = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(str));
        }
    }
}
