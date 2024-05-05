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
    public partial class SpecificQuestionNode : Node
    {
        private string question;
        private Dictionary<string, Node> responses;

        public SpecificQuestionNode(string question, Dictionary<string, Node> responses)
        {
            this.question = question;
            this.responses = responses;
        }

        public override void Diagnose()
        {
            string answer = AskQuestion(question);
            if (responses.ContainsKey(answer))
            {
                responses[answer].Diagnose();
            }
            else
            {
                Console.WriteLine("Invalid input. Please answer with one of the following: " + string.Join(", ", responses.Keys));
            }
        }

        private string AskQuestion(string question)
        {
            Console.Write(question + " (" + string.Join("/", responses.Keys) + "): ");
            return Console.ReadLine().Trim().ToLower();
        }
    }
}