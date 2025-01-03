using MVCExercise.Models;

namespace MVCExercise.Interface
{
    public interface ICompanyRepo
    {
        Company Registration(Company company);
        List<Company> ViewCompanyProfile(Company company);
        Company GetCompanyById(int id);

    }
}
