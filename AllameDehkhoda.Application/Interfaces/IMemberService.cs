using AllameDehkhoda.Application.Common;
using AllameDehkhoda.Application.DTO;

namespace AllameDehkhoda.Application.Interfaces
{
    public interface IMemberService
    {
        Task<List<MemberDTO>> GetAllMemberAsync(bool includeISDeleted = false);
        Task<MemberDTO> GetMemberByIdAsync(int id);
        Task<ServiceResult> AddMemberAsync(MemberDTO memberDTO);
        Task<ServiceResult> UpdateMemberAsync(MemberDTO memberDTO);
        Task<ServiceResult> DeleteMemberAsync(int id);
        Task<ServiceResult> RestoreMemberAsync(int id);
        Task<MemberDTO> FindBySSNAsync(string ssn);
        Task<List<MemberReportDTO>> GetmemberReportAsync(string ssn,string? firstName, string? lastName, string status);
    }
}
