using Complier;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zamora1
{
    class Parser
    {
        public string token;
        public string lexeme;
        Parser(LexicalAnalyzer la)
        {
            la.GetNextToken();
        }

        void Prog(LexicalAnalyzer la)
        {
            throw new NotImplementedException();
        }
        void MoreClasses(LexicalAnalyzer la)
        {
            ClassDecl(la);
            MoreClasses(la);
        }
        void MainClass(LexicalAnalyzer la)
        {
            (token, lexeme) = la.GetNextToken();
            if (token == "finalt")
            {
                (token, lexeme) = la.GetNextToken();
                if (token == "classt")
                {
                    (token, lexeme) = la.GetNextToken();
                    if (token == "idt")
                    {
                        (token, lexeme) = la.GetNextToken();
                        if (token == "begint")
                        {
                            (token, lexeme) = la.GetNextToken();
                            if (token == "publict")
                            {
                                (token, lexeme) = la.GetNextToken();
                                if (token == "statict")
                                {
                                    (token, lexeme) = la.GetNextToken();
                                    if (token == "voidt")
                                    {
                                        (token, lexeme) = la.GetNextToken();
                                        if (token == "begint")
                                        {
                                            (token, lexeme) = la.GetNextToken();
                                            if (token == "maint")
                                            {
                                                (token, lexeme) = la.GetNextToken();
                                                if (token == "lParent")
                                                {
                                                    (token, lexeme) = la.GetNextToken();
                                                    if (token == "stringt")
                                                    {
                                                        (token, lexeme) = la.GetNextToken();
                                                        if (token == "lBracket")
                                                        {
                                                            (token, lexeme) = la.GetNextToken();
                                                            if (token == "rBracket")
                                                            {
                                                                (token, lexeme) = la.GetNextToken();
                                                                if (token == "idt")
                                                                {
                                                                    (token, lexeme) = la.GetNextToken();
                                                                    if (token == "rParent")
                                                                    {
                                                                        (token, lexeme) = la.GetNextToken();
                                                                        if (token == "begint")
                                                                        {
                                                                            SeqOfStats(la);
                                                                            (token, lexeme) = la.GetNextToken();
                                                                            if (token == "endt")
                                                                            {
                                                                                (token, lexeme) = la.GetNextToken();
                                                                                if (token == "endt")
                                                                                {

                                                                                }
                                                                                else
                                                                                {
                                                                                    Console.WriteLine("Expected } ");
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Expected } ");
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("Expected { ");
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("Expected ) ");
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Expected id token ");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Expected ] ");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Expected [ ");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Expected String ");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Expected ( ");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Expected main ");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Expected { ");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Expected void ");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Expected static token ");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Expected public token ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Expected { ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Expected id token");
                    }
                }
                else
                {
                    Console.WriteLine("Expected class token");
                }
            }
            else
            {
                Console.WriteLine("Expected Final token");
            }
        }

        private void SeqOfStats(LexicalAnalyzer la)
        {

        }
        private void ClassDecl(LexicalAnalyzer la)
        {
            (token, lexeme) = la.GetNextToken();
            if (token == "classt")
            {
                (token, lexeme) = la.GetNextToken();
                if (token == "idt")
                {
                    (token, lexeme) = la.GetNextToken();
                    if (token == "begint")
                    {
                        VarDecl(la);
                        MethodDecl(la);
                        (token, lexeme) = la.GetNextToken();
                        if (token == "endt")
                        {

                        }
                        else
                        {
                            Console.WriteLine("Expected } ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Expected { ");
                    }
                }
                else if (token == "extendst")
                {
                    if (token == "idt")
                    {
                        (token, lexeme) = la.GetNextToken();
                        if (token == "begint")
                        {
                            VarDecl(la);
                            MethodDecl(la);
                            (token, lexeme) = la.GetNextToken();
                            if (token == "endt")
                            {

                            }
                            else
                            {
                                Console.WriteLine("Expected } ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Expected { ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Expected id or extends token ");
                    }
                }
                else
                {
                    Console.WriteLine("Expected id token ");
                }
            }
            else
            {
                Console.WriteLine("Expected class ");
            }

        }

        private void MethodDecl(LexicalAnalyzer la)
        {
            (token, lexeme) = la.GetNextToken();
            if (token == "publict")
            {
                Type(la);
                (token, lexeme) = la.GetNextToken();
                if (token == "idt")
                {
                    (token, lexeme) = la.GetNextToken();
                    if (token == "Lparent")
                    {
                        FormalList(la);
                        (token, lexeme) = la.GetNextToken();
                        if (token == "Rparent")
                        {
                            (token, lexeme) = la.GetNextToken();
                            if (token == "begint")
                            {
                                VarDecl(la);
                                SeqOfStats(la);
                                (token, lexeme) = la.GetNextToken();
                                if (token == "returnt")
                                {
                                    Expr(la);
                                    (token, lexeme) = la.GetNextToken();
                                    if (token == "semit")
                                    {
                                        (token, lexeme) = la.GetNextToken();
                                        if (token == "endt")
                                        { 
                                            MethodDecl(la);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Expected } token");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Expected ; token");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Expected return token");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Expected { ");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Expected i) token");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Expected ( ");
                    }

                }
                else
                {
                    Console.WriteLine("Expected id token");
                }
            }
            else
            {
                
            }
        }

        private void Expr(LexicalAnalyzer la)
        {

        }

        private void FormalList(LexicalAnalyzer la)
        {
            Type(la);
            (token, lexeme) = la.GetNextToken();
            if (token == "idt")
            {

                FormalRest(la);
            }
            else
            {
                Console.WriteLine("Expected id token");
            }
        }

        private void FormalRest(LexicalAnalyzer la)
        {
            (token, lexeme) = la.GetNextToken();
            if (token == "commat")
            {
                Type(la);
                (token, lexeme) = la.GetNextToken();
                if (token == "idt")
                {
                    FormalRest(la);

                }
                else
                {
                    Console.WriteLine("Expected id token");
                }

            }
            else
            {
                
            }
        }

        private void VarDecl(LexicalAnalyzer la)
        {
            (token, lexeme) = la.GetNextToken();
            if (token == "finalt")
            {
                Type(la);
                (token, lexeme) = la.GetNextToken();
                if (token == "idt")
                {
                    if (token == "assignOpt")
                    {
                        if (token == "numt")
                        {
                            if (token == "semit")
                            {
                                VarDecl(la);
                            }
                            else
                            {
                                Console.WriteLine("Expected ; ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Expected num token ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Expected = ");
                    }
                }
                else
                {
                    Console.WriteLine("Expected id token ");
                }
            }
            else
            {
                Type(la);
                IdentifierList(la);
                (token, lexeme) = la.GetNextToken();
                if (token == "semit")
                {
                    VarDecl(la);
                }
                else
                {
                    Console.WriteLine("Expected ; ");
                }
            }

        }

        private void IdentifierList(LexicalAnalyzer la)
        {
            (token, lexeme) = la.GetNextToken();
            if (token == "idt")
            {
                (token, lexeme) = la.GetNextToken();
                if (token == "commat")
                {
                    IdentifierList(la);
                }
                else
                {
                    Console.WriteLine("Expected id token ");
                }
            }
            else
            {
                Console.WriteLine("Expected id token ");
            }
        }

        private void Type(LexicalAnalyzer la)
        {
            (token, lexeme) = la.GetNextToken();
            if (token == "intt")
            {
            }
            else if (token == "booleant")
            {
            }
            else if (token == "voidt")
            {
            }
            else
            {
                Console.WriteLine("Expected int,boolean or void token ");
            }
        }
    }
}
