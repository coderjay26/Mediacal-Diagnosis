using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediacal_Diagnosis.Model
{
    public partial class QuestionNode : Node
    {
        private string question;
        private Node yesNode;
        private Node noNode;

        public QuestionNode(string question, Node yesNode, Node noNode)
        {
            this.question = question;
            this.yesNode = yesNode;
            this.noNode = noNode;
        }

        public override void Diagnose()
        {
            string answer = AskQuestion(question);
            if (answer == "yes")
            {
                yesNode.Diagnose();
            }
            else if (answer == "no")
            {
                noNode.Diagnose();
            }
            else
            {
                Console.WriteLine("Invalid input. Please answer with 'yes' or 'no'.");
            }
        }

        private string AskQuestion(string question)
        {
            Console.Write(question + " (yes/no): ");
            return Console.ReadLine().Trim().ToLower();
        }
    }
}