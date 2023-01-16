using Asp.netCoreMVCIntro.Context;
using Asp.netCoreMVCIntro.Models;

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
        throw new NotImplementedException();
    }

    public Tutorial Update(Tutorial tutorial)
    {
        throw new NotImplementedException();
    }

    public void Delete(int Id)
    {
        throw new NotImplementedException();
    }

    public Tutorial GetTutorial(int Id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Tutorial> GetAllTutorial()
    {
        return _context.Tutorials;
    }
}
