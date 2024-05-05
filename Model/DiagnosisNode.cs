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
    public partial class DiagnosisNode : Node
    {
        private string diagnosis;
        private string recommendation;

        public DiagnosisNode(string diagnosis, string recommendation)
        {
            this.diagnosis = diagnosis;
            this.recommendation = recommendation;
        }

        public override void Diagnose()
        {
            Console.WriteLine("Diagnosis: " + diagnosis + "\nRecommendation: " + recommendation);
        }
    }
}