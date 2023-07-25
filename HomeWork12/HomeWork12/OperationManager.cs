using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    public class OperationManager
    {
        private int _first;
        private int _second;
        private ExecutionManager executionManager;
        public OperationManager(int first, int second)
        {
            _first = first;
            _second = second;
            executionManager = new ExecutionManager();
            executionManager.PopulateFunctions(Sum, Subtract, Multiply);
        }
        private int Sum()
        {
            return _first + _second;
        }
        private int Subtract()
        {
            return _first - _second;
        }
        private int Multiply()
        {
            return _first * _second;
        }
        public int Execute(Operation operation)
        {
            return executionManager.FuncExecute[operation].Invoke();
        }
    }
}
