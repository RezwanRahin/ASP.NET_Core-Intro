using Asp.netCoreMVCIntro.Context;
using Asp.netCoreMVCIntro.Models;
using Microsoft.EntityFrameworkCore;

namespace Asp.netCoreMVCIntro.Repository;

public class TutorialRepository : ITutorialRepository
{
    private readonly TutorialDbContext _context;

    public TutorialRepository(TutorialDbContext context)
    {
        _context = context;
    }

    public void Add(Tutorial tutorial)
    {
        _context.Tutorials.Add(tutorial);
        _context.SaveChanges();
    }

    public Tutorial Update(Tutorial tutorial)
    {
        _context.Tutorials.Update(tutorial);
        _context.SaveChanges();
        return tutorial;
    }

    public void Delete(int Id)
    {
        Tutorial tutorial = _context.Tutorials.Find(Id);

        if (tutorial != null)
        {
            _context.Tutorials.Remove(tutorial);
            _context.SaveChanges();
        }
    }

    public Tutorial GetTutorial(int Id)
    {
        return _context.Tutorials.Find(Id);
    }

    public async Task<IEnumerable<Tutorial>> GetAllTutorial()
    {
        return await _context.Tutorials.ToListAsync();
    }
}
