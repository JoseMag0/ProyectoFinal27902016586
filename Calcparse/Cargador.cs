using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Antlr4;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

namespace Calcparse
{
    public class Cargador : ExprBaseListener
    {
        public Stack<double> pila { get; set; } = new Stack<double>();
        
        public Stack<string> pilaS {  get; set; } = new Stack <string>();
        public override void ExitExpr([NotNull] ExprParser.ExprContext context)
        {
            base.ExitExpr(context);

            if (context.ChildCount==3)
            {

                double derecha = pila.Pop();
                double izquierda = pila.Pop();
                


                if (context.op.Type == ExprParser.SUM)
                {


                    pila.Push(izquierda + derecha);



                }

                if (context.op.Type == ExprParser.RES)
                {

                    pila.Push(izquierda - derecha);


                }

                if (context.op.Type == ExprParser.MULT)
                {

                    pila.Push(izquierda * derecha);


                }

                if (context.op.Type == ExprParser.DIV)
                {
                    if (derecha > 0 ||derecha<0)
                    {
                        pila.Push(izquierda / derecha);

                    }
                    else
                    {
                        pila.Push(-1);
                    }

                }

            }
        }

        public override void VisitTerminal([NotNull] ITerminalNode node)
        {

            base.VisitTerminal(node);
            IToken simbolo = node.Symbol;
            if ((simbolo.Type == ExprParser.INT) || (simbolo.Type == ExprParser.REAL))
            {
                pila.Push(double.Parse(simbolo.Text));

            }
                 

        }
    }
}
