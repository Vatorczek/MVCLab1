
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfelik.Models;

public class ExpensesController : Controller
{
    private readonly PortfelikContext _context;

    public ExpensesController(PortfelikContext context)
    {
        _context = context;
    }

    // GET: EXPENSES
    public async Task<IActionResult> Index(string searchString)
    {
        ViewData["CurrentFilter"] = searchString;

        if (_context.Expense == null)
        {
            return Problem("Entity set 'PortfelikContext.Expense' is null.");
        }

        var expenses = from e in _context.Expense
                       select e;

        if (!string.IsNullOrEmpty(searchString))
        {
            expenses = expenses.Where(e => e.Category!.Contains(searchString));
        }

        return View(await expenses.ToListAsync());
    }

    // GET: EXPENSES/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var expense = await _context.Expense
            .FirstOrDefaultAsync(m => m.Id == id);
        if (expense == null)
        {
            return NotFound();
        }

        return View(expense);
    }

    // GET: EXPENSES/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: EXPENSES/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Category,Amount,Date")] Expense expense)
    {
        if (ModelState.IsValid)
        {
            _context.Add(expense);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(expense);
    }

    // GET: EXPENSES/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var expense = await _context.Expense.FindAsync(id);
        if (expense == null)
        {
            return NotFound();
        }
        return View(expense);
    }

    // POST: EXPENSES/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Category,Amount,Date")] Expense expense)
    {
        if (id != expense.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(expense);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExpenseExists(expense.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(expense);
    }

    // GET: EXPENSES/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var expense = await _context.Expense
            .FirstOrDefaultAsync(m => m.Id == id);
        if (expense == null)
        {
            return NotFound();
        }

        return View(expense);
    }

    // POST: EXPENSES/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var expense = await _context.Expense.FindAsync(id);
        if (expense != null)
        {
            _context.Expense.Remove(expense);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool ExpenseExists(int? id)
    {
        return _context.Expense.Any(e => e.Id == id);
    }
}
