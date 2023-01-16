using Asp.netCoreMVCIntro.Models;

namespace Asp.netCoreMVCIntro.Repository;

public class TutorialRepository : ITutorialRepository
{
    private List<Tutorial> _tutorials;

    public TutorialRepository()
    {
        
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
        return _tutorials;
    }
}
