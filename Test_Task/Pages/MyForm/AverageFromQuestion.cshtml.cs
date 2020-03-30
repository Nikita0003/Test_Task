using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test_Task.Data;

namespace Test_Task.Pages.MyForm
{
    public class AverageFromQuestionModel : PageModel
    {
        private readonly Test_Task.Models.Test_TaskContext _context;

        public AverageFromQuestionModel(Test_Task.Models.Test_TaskContext context)
        {
            _context = context;
        }

        public double[] average { get; set; } = new double[11];

        public static double[] AveragePoints( Test_Task.Models.Test_TaskContext _context)
        {
            var users = from m in _context.User
                        select m;
            double[] average = new double[11];

            Answers answers = new Answers();
            int i = 0;
            foreach (var j in users)
            {
                if (j.Q1)
                    average[0] += answers.C1;
                i++;
            }
            average[0] = Math.Round(average[0] / i, 2);
            foreach (var j in users)
            {
                if (j.Q2)
                    average[1] += answers.C2;
            }
            average[1] = Math.Round(average[1] / i, 2);
            foreach (var j in users)
            {
                if (j.Q3)
                    average[2] += answers.C3;
            }
            average[2] = Math.Round(average[2] / i, 2);
            foreach (var j in users)
            {
                if (j.Q4)
                    average[3] += answers.C4;
            }
            average[3] = Math.Round(average[3] / i, 2);
            foreach (var j in users)
            {
                if (j.Q5)
                    average[4] += answers.C5;
            }
            average[4] = Math.Round(average[4] / i, 2);
            foreach (var j in users)
            {
                if (j.Q6)
                    average[5] += answers.C6;
            }
            average[5] = Math.Round(average[5] / i, 2);
            foreach (var j in users)
            {
                if (j.Q7)
                    average[6] += answers.C7;
            }
            average[6] = Math.Round(average[6] / i, 2);
            foreach (var j in users)
            {
                if (j.Q8)
                    average[7] += answers.C8;
            }
            average[7] = Math.Round(average[7] / i, 2);
            foreach (var j in users)
            {
                if (j.Q9)
                    average[8] += answers.C9;
            }
            average[8] = Math.Round(average[8] / i, 2);
            foreach (var j in users)
            {
                if (j.Q10)
                    average[9] += answers.C10;
            }
            average[9] = Math.Round(average[9] / i, 2);
            average[10] = i;
            return average;
        }
        public void OnGet()
        {
            average = AveragePoints(_context);

        }
    }
}