using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    public class ExecutionManager
    {
        public Dictionary<Operation, Func<int>> FuncExecute { get; set; } = new();
        private Func<int> _sumDelegate;
        private Func<int> _multiply;
        private Func<int> _substract;

        public void PopulateFunctions(Func<int> sum, Func<int> multiply, Func<int> subtract)
        {
            _sumDelegate=sum;
            _multiply=multiply;
            _substract=subtract;
            PrepareExecution();
        }

        public void PrepareExecution()
        {
            FuncExecute = new Dictionary<Operation, Func<int>>();

            FuncExecute.Add(Operation.Sum, _sumDelegate);
            FuncExecute.Add(Operation.Multiply, _multiply);
            FuncExecute.Add(Operation.Subtract, _substract);

        }
    }
}
