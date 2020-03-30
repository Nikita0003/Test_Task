using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Test_Task.Data;
using Test_Task.Models;

namespace Test_Task.Pages.MyForm
{
    public class CreateModel : PageModel
    {
        private readonly Test_Task.Models.Test_TaskContext _context;

        public CreateModel(Test_Task.Models.Test_TaskContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Answers answers { get; set; }

        [BindProperty]
        public User User { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            double sum = 0;
            

            string v = Request.Form["Q1"].ToString();
            answers.V1 = v;
            v = Request.Form["Q3"].ToString();
            answers.V3 = v;
            v = Request.Form["Q4"].ToString();
            answers.V4 = v; ;
            v = Request.Form["Q6"].ToString();
            answers.V6 = v;
            v = Request.Form["Q8"].ToString();
            answers.V8 = v;
            v = Request.Form["Q10"].ToString();
            answers.V10 = v;

            if (answers.V1 == answers.A1)
            {
                User.Q1 = true; sum += answers.C1; 
            }
            if (IsEquals(answers.V2, answers.A2))
            {
                User.Q2 = true; sum += answers.C2; 
            }
            if (answers.V3 == answers.A3)
            {
                User.Q3 = true; sum += answers.C3; 
            }
            if (answers.V4 == answers.A4)
            {
                User.Q4 = true; sum += answers.C4;
            }
            if (IsEquals(answers.V5, answers.A5))
            {
                User.Q5 = true; sum += answers.C5;
            }
            if (answers.V6 == answers.A6)
            {
                User.Q6 = true; sum += answers.C6; 
            }
            if (IsEquals(answers.V7, answers.A7))
            {
                User.Q7 = true; sum += answers.C7; 
            }
            if (answers.V8 == answers.A8)
            {
                User.Q8 = true; sum += answers.C8; 
            }
            if (IsEquals(answers.V9, answers.A9))
            {
                User.Q9 = true; sum += answers.C9; 
            }
            if (answers.V10 == answers.A10)
            {
                User.Q10 = true; sum += answers.C10; 
            }

                      
            User.Sum = Math.Round(sum, 2);

            _context.User.Add(User);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

         static bool IsEquals(string[] s1, string[] s2)
        {
            bool flag = true;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

    }
}