using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {        //crete link Liost:

            string[] words = { "The ", "fox", "Jumps", "over", "the", "dog" };

            LinkedList<string> sentence = new LinkedList<string>(words);
            Display(sentence, "The linked list values:");
            Console.WriteLine($"sentence.Contains(jumps) = {sentence.Contains("Jumps")}");

            //add the word today to the beginning of the linked list:
            sentence.AddFirst("today");
            Display(sentence, "Test 1: 'today' to beginning of the list:");

            //Move the fikrst node to be the last node:
            LinkedListNode<string> mark1 = sentence.First;
            sentence.RemoveFirst();
            sentence.AddLast(mark1);
            Display(sentence, "Test 2: Move first node to be last node");

            //change the last node to 'yesterday'
            sentence.RemoveLast();
            sentence.AddLast("yesterday");
            Display(sentence, "Test 3: Chage the last node to  'Yesterday'");

            //Move the last node to be the first node:
            mark1 = sentence.Last;
            sentence.RemoveLast();
            sentence.AddFirst(mark1);
            Display(sentence, "Test 4: Move last node to be first node");

            //Indicate the last occurence of 'the' 
            sentence.RemoveFirst();
            LinkedListNode<string> current = sentence.FindLast("the");
            IndicateNode(current, "Test 5: Indicate last occurence of 'the':");

            Console.ReadKey();
            //add lazy and old after the (the linkedlistnnode named current)


            sentence.AddAfter(current, "old");
            sentence.AddAfter(current, "Lazy");
            IndicateNode(current,"test 6: add lazy and old after the: ");

            //Indicate fox node:
            current = sentence.Find("fox");
            IndicateNode(current, "Test 7: indicate the fox node:");

            //add quick and brown before fox:
            sentence.AddBefore(current, "quick");
            sentence.AddBefore(current, "brown");
            IndicateNode(current, "Test 8: add 'quick' and 'brown' before 'fox' ");

            //keep a reference to the current node, fox'
            //and to the previvios noed in the list, indicate the ''dog' node
            mark1 = current;
            LinkedListNode<string> mark2 = current.Previous;
            current = sentence.Find("dog");
            IndicateNode(current, "Test 9: Indicate the 'dog' node");

            Console.WriteLine("Test 10: Throw exceptio by adding node (fox) alreay i the list");
            try
            {
                sentence.AddBefore(current, mark1);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Exception message : {ex.Message} ");
            }

            Console.WriteLine();


            sentence.Remove(mark1);
            sentence.AddBefore(current, mark1);
            IndicateNode(current, "Test 11: Move a referenced node ( fox) before the current node (dog): ");

            sentence.Remove(current);
            IndicateNode(current, "Test 12: Remove current ode (dog) and attempt toindicate it:");

            sentence.AddAfter(mark2, current);
            IndicateNode(current, "TEst 13: add node rempved in test 11 after a referenced node (brown):");

            sentence.Remove("old");
            Display(sentence, "Test 14: Remove node that has the value 'old': ");

            sentence.RemoveLast();
            ICollection<string> icoll = sentence;
            icoll.Add("rhinoceros");
            Display(sentence, "Test 15 Remove last node , cast to Icollection, and add 'rhinoceros' :");

            Console.WriteLine("Test 16: Copy the list to an aeeay:");
            string[] sArray = new string[sentence.Count];
            sentence.CopyTo(sArray, 0);

            foreach (var s in sArray)
            {
                Console.WriteLine(s);
            }

            sentence.Clear();

            Console.WriteLine();
            Console.WriteLine($"Test 17 : Clear link list, Contains 'Jumps' = {sentence.Contains("jumps")}");


            Display(sentence, "Sntence emty...");

            Console.ReadLine();

        }



       

        private static void IndicateNode(LinkedListNode<string> node, string test)
        {
            Console.WriteLine(test);
            if (node.List == null)
            {
                Console.WriteLine($"Node {node.Value} is not in the list.\n");
                return;
            }

            StringBuilder result = new StringBuilder($"( '{node.Value}' )");
            LinkedListNode<string> nodeP = node.Previous;

            while (nodeP != null)
            {
                result.Insert(0, $"{nodeP.Value}  ' ' ");

                nodeP = nodeP.Previous;
            }

            node = node.Next;

            while (node != null)
            {
                result.Append($"  {node.Value}");
                node = node.Next;
            }

            Console.WriteLine(result);
            Console.WriteLine();

        }

        private static void Display(LinkedList<string> words, string test)
        {
            Console.WriteLine(test);
            foreach (var word in words)
            {
                Console.WriteLine(word + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
