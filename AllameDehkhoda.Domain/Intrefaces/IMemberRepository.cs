using AllameDehkhoda.Domain.Entites;

namespace AllameDehkhoda.Domain.Intrefaces
{
    public interface IMemberRepository : IRepository<Member>
    {
        Task<Member> GetBySSNAsync(string ssn);
        Task<List<Member>> GetReportDataAsync(string ssn,string?firstName ,string?lastName , string status);

    }
}
