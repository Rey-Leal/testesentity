using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestesEntity.Data;
using TestesEntity.Models;

namespace TestesEntity.Pages.Produtos
{
    public class IndexModel : PageModel
    {
        private readonly TestesEntity.Data.Context _context;

        public IndexModel(TestesEntity.Data.Context context)
        {
            _context = context;
        }

        public IList<Produto> Produto { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Produto = await _context.Produto.ToListAsync();
        }
    }
}
