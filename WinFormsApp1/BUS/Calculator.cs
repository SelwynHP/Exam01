using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.BUS
{
    enum OperationType { Null,Add,Subtract,Multiply,Divide }
    
    class Calculator
    {
        public double CurrentValue { get; set; }
        private double operand1;
        private double operand2;
        private OperationType op;
        private const string path = "./Calculator.txt";
        Dictionary<OperationType, string> equationDictionary = new Dictionary<OperationType, string>()
        {
            { OperationType.Add, "+" },
            { OperationType.Subtract, "-" },
            { OperationType.Multiply, "*" },
            { OperationType.Divide, "/" }
        };

        public Calculator()
        {
            this.CurrentValue = 0;
            this.operand1 = 0;
            this.operand2 = 0;
            this.op = OperationType.Null;
        }
        private void SetOperand1()
        {
            this.operand1 = CurrentValue;
        }
        private void SetOperand2()
        {
            this.operand2 = CurrentValue;
        }
        private void SetOp(OperationType type)
        {
            this.op = type;
        }
        public void Add()
        {
            SetOperand1();
            SetOp(OperationType.Add);
        }
        public void Subtract()
        {
            SetOperand1();
            SetOp(OperationType.Subtract);
        }
        public void Multiply()
        {
            SetOperand1();
            SetOp(OperationType.Multiply);
        }
        public void Divide()
        {
            SetOperand1();
            SetOp(OperationType.Divide);
        }
        public double Equal()
        {
            SetOperand2();
            double result;
            switch (this.op)
            {
                case OperationType.Add:
                    result = this.operand1 + this.operand2;
                    break;
                case OperationType.Subtract:
                    result = this.operand1 - this.operand2;
                    break;
                case OperationType.Multiply:
                    result = this.operand1 * this.operand2;
                    break;
                case OperationType.Divide:
                    result = this.operand1 / this.operand2;
                    break;
                default:
                    result = 0.00;
                    break;
            }
            CurrentValue = result;
            SaveEquations();
            return result;
        }
        private void SaveEquations()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.operand1);
            sb.Append(equationDictionary[this.op]);
            sb.Append(this.operand2);
            sb.Append("=");
            sb.Append(this.CurrentValue);
            using(StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(sb);
            }
        }
    }
}
