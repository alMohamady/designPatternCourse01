using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton.Interpreter
{
    public class Context
    {
        public string Name { get; set; }

        public Context(string name)
        {
            Name = name;
        }
    }

    public interface IExpression
    {
        void Interpret(Context context);
    }

    public class TerminalExpression : IExpression
    {
        public void Interpret(Context context)
        {
            Console.WriteLine("Terminal for {0}.", context.Name);
        }
    }

    public class NonterminalExpression : IExpression
    {
        public IExpression Expression1 { get; set; }

        public IExpression Expression2 { get; set; }

        public void Interpret(Context context)
        {
            Console.WriteLine("Nonterminal for {0}.", context.Name);
            Expression1.Interpret(context);
            Expression2.Interpret(context);
        }
    }
}
