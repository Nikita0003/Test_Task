using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Test_Task.Models;

namespace Test_Task.Pages.MyForm
{
    public class IndexModel : PageModel
    {
        private readonly Test_Task.Models.Test_TaskContext _context;

        public IndexModel(Test_Task.Models.Test_TaskContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }
        public double[] average { get; set; } = new double[11];
        
        public async Task OnGetAsync()
        {
            average = AverageFromQuestionModel.AveragePoints(_context);
            average[10] = 0;
            for(int i=0;i<10;i++)
            {
                average[10] += average[i];
            }
            average[10] = Math.Round(average[10] / 10,2);
            User = await _context.User.ToListAsync();
        }
    }
}
