namespace PolishInvertorSpace
{
    public class PolishInvertor
    {
        public string Calculate(Queue<string> california)
        {
            if (california.Count == 0) return "Expression empty";
            float[] numbers = new float[3] { 0, 0, 0 };
            for (int i = 0; california.Count != 0;)
            {
                if (california.Peek() == "+")
                {
                    i--;
                    numbers[i - 1] += numbers[i];
                    california.Dequeue();

                }
                else if (california.Peek() == "-")
                {
                    i--;
                    numbers[i - 1] -= numbers[i];
                    california.Dequeue();

                }
                else if (california.Peek() == "*")
                {
                    i--;
                    numbers[i - 1] *= numbers[i];
                    california.Dequeue();

                }
                else if (california.Peek() == "/")
                {
                    i--;
                    numbers[i - 1] /= numbers[i];
                    california.Dequeue();

                }
                else
                {
                    numbers[i] = Convert.ToSingle(california.Dequeue());
                    i++;
                }

            }
            return Convert.ToString(numbers[0]);
        }

        private Queue<string> ConvertExpression(List<string> expression)
        {
            Stack<string> Texas = new Stack<string>();
            Queue<string> California = new Queue<string>();
            Texas.Push("&");
            expression.Add("&");
            for (int i = 0; true; i++)
            {
                if (Texas.Peek() == "&" && expression[i] == "&")
                {
                    break;
                }
                else if (Texas.Peek() == "&" && expression[i] == "+")
                {
                    Texas.Push(expression[i]);
                }
                else if (Texas.Peek() == "&" && expression[i] == "-")
                {
                    Texas.Push(expression[i]);
                }
                else if (Texas.Peek() == "&" && expression[i] == "*")
                {
                    Texas.Push(expression[i]);
                }
                else if (Texas.Peek() == "&" && expression[i] == "/")
                {
                    Texas.Push(expression[i]);
                }
                else if (Texas.Peek() == "&" && expression[i] == "(")
                {
                    Texas.Push(expression[i]);
                }
                else if (Texas.Peek() == "&" && expression[i] == ")")
                {
                    try
                    {
                        throw new Exception("Incorrect expression");
                    }
                    catch (Exception mes)
                    {
                        Console.WriteLine(mes.Message);
                    }
                }
                else if (Texas.Peek() == "+" && expression[i] == "&")
                {
                    California.Enqueue(Texas.Pop());i--;
                }
                else if (Texas.Peek() == "+" && expression[i] == "+")
                {
                    California.Enqueue(Texas.Pop());i--;
                }
                else if (Texas.Peek() == "+" && expression[i] == "-")
                {
                    California.Enqueue(Texas.Pop());i--;
                }
                else if (Texas.Peek() == "+" && expression[i] == "*")
                {
                    Texas.Push(expression[i]);
                }
                else if (Texas.Peek() == "+" && expression[i] == "/")
                {
                    Texas.Push(expression[i]);
                }
                else if (Texas.Peek() == "+" && expression[i] == "(")
                {
                    Texas.Push(expression[i]);
                }
                else if (Texas.Peek() == "+" && expression[i] == ")")
                {
                    California.Enqueue(Texas.Pop()); i--;
                }
                else if (Texas.Peek() == "-" && expression[i] == "&")
                {
                    California.Enqueue(Texas.Pop());i--;
                }
                else if (Texas.Peek() == "-" && expression[i] == "+")
                {
                    California.Enqueue(Texas.Pop());i--;
                }
                else if (Texas.Peek() == "-" && expression[i] == "-")
                {
                    California.Enqueue(Texas.Pop());i--;
                }
                else if (Texas.Peek() == "-" && expression[i] == "*")
                {
                    Texas.Push(expression[i]);
                }
                else if (Texas.Peek() == "-" && expression[i] == "/")
                {
                    Texas.Push(expression[i]);
                }
                else if (Texas.Peek() == "-" && expression[i] == "(")
                {
                    Texas.Push(expression[i]);
                }
                else if (Texas.Peek() == "-" && expression[i] == ")")
                {
                    California.Enqueue(Texas.Pop());i--;
                }
                else if (Texas.Peek() == "*" && expression[i] == "&")
                {
                    California.Enqueue(Texas.Pop());i--;
                }
                else if (Texas.Peek() == "*" && expression[i] == "+")
                {
                    California.Enqueue(Texas.Pop());i--;
                }
                else if (Texas.Peek() == "*" && expression[i] == "-")
                {
                    California.Enqueue(Texas.Pop());i--;
                }
                else if (Texas.Peek() == "*" && expression[i] == "*")
                {
                    California.Enqueue(Texas.Pop());i--;
                }
                else if (Texas.Peek() == "*" && expression[i] == "/")
                {
                    California.Enqueue(Texas.Pop());i--;
                }
                else if (Texas.Peek() == "*" && expression[i] == "(")
                {
                    Texas.Push(expression[i]);
                }
                else if (Texas.Peek() == "*" && expression[i] == ")")
                {
                    California.Enqueue(Texas.Pop());i--;
                }
                else if (Texas.Peek() == "/" && expression[i] == "&")
                {
                    California.Enqueue(Texas.Pop());i--;
                }
                else if (Texas.Peek() == "/" && expression[i] == "+")
                {
                    California.Enqueue(Texas.Pop());i--;
                }
                else if (Texas.Peek() == "/" && expression[i] == "-")
                {
                    California.Enqueue(Texas.Pop());i--;
                }
                else if (Texas.Peek() == "/" && expression[i] == "*")
                {
                    California.Enqueue(Texas.Pop());i--;
                }
                else if (Texas.Peek() == "/" && expression[i] == "/")
                {
                    California.Enqueue(Texas.Pop());i--;
                }
                else if (Texas.Peek() == "/" && expression[i] == "(")
                {
                    Texas.Push(expression[i]);
                }
                else if (Texas.Peek() == "/" && expression[i] == ")")
                {
                    California.Enqueue(Texas.Pop());i--;
                }
                else if (Texas.Peek() == "(" && expression[i] == "&")
                {
                    try
                    {
                        throw new Exception("Incorrect expression");
                    }
                    catch (Exception mes)
                    {
                        Console.WriteLine(mes.Message);
                    }
                }
                else if (Texas.Peek() == "(" && expression[i] == "+")
                {
                    Texas.Push(expression[i]);
                }
                else if (Texas.Peek() == "(" && expression[i] == "-")
                {
                    Texas.Push(expression[i]);
                }
                else if (Texas.Peek() == "(" && expression[i] == "*")
                {
                    Texas.Push(expression[i]);
                }
                else if (Texas.Peek() == "(" && expression[i] == "/")
                {
                    Texas.Push(expression[i]);
                }
                else if (Texas.Peek() == "(" && expression[i] == "(")
                {
                    Texas.Push(expression[i]);
                }
                else if (Texas.Peek() == "(" && expression[i] == ")")
                {
                    Texas.Pop();
                    continue;
                }
                else
                    California.Enqueue(expression[i]);
            }
            return California;
        }

        private List<string> CutExpression(string expression)
        {
            List<string> list = new List<string>();
            string tmp = "";
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == ' ') continue;
                if (expression[i] != '+' && expression[i] != '-' && expression[i] != '*' && expression[i] != '/' && expression[i] != '(' && expression[i] != ')')
                {
                    tmp += Convert.ToString(expression[i]);
                    if (i == expression.Length - 1)
                        list.Add(tmp);
                    continue;
                }
                else
                {
                    if (tmp != "")
                    {
                        list.Add(tmp);
                    }
                    tmp = Convert.ToString(expression[i]);
                    list.Add(tmp);
                }
                tmp = "";
            }

            return list;
        }

        public string Calculate(string expression)
        {
            List<string> strings = CutExpression(expression);
            Queue<string> queue = ConvertExpression(strings);
            string res = Calculate(queue);
            return res;
        }
    }
}