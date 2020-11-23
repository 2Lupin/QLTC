using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace API.Controllers
{
    public class TransactionsController : BaseApiController
    {
        private readonly DataContext _context;

        public TransactionsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppTransactions>>> GetTransactions()
        {
            return await _context.Transactions.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppTransactions>> GetTransaction(int id)
        {
            return await _context.Transactions.FindAsync(id);
        }

        [HttpPost("transaction")]
        public async Task<ActionResult<AppTransactions>> Transaction(TransactionsDto transactionsDto)
        {
            var transactions = new AppTransactions {
                CardId = transactionsDto.Id,
                StationFrom = transactionsDto.StationFrom,
                Date_In = transactionsDto.Date_In
            };

            _context.Transactions.Add(transactions);
            await _context.SaveChangesAsync();

            return transactions;
        }

        [HttpPut("transaction")]
        public async Task<ActionResult<AppTransactions>> UpdateTrasaction(TransactionsDto transactionsDto)
        {
            var no_transactions = await _context.Transactions.FirstOrDefaultAsync(nt => nt.CardId == transactionsDto.CardId && nt.Date_In == transactionsDto.Date_In);

            var transactions = new AppTransactions {
                Id = transactionsDto.Id,
                CardId = transactionsDto.CardId,
                StationTo = transactionsDto.StationTo,
                Date_Out = transactionsDto.Date_Out
            };

            
            _context.Transactions.Update(transactions);
            await _context.SaveChangesAsync();

            return transactions;
        }

        // private async Task<ActionResult<AppQLTC>> UpdateQLTC(RegisterDto registerDto) {

        // }
    }
}