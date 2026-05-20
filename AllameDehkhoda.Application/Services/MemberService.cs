using AllameDehkhoda.Application.Common;
using AllameDehkhoda.Application.DTO;
using AllameDehkhoda.Application.Interfaces;
using AllameDehkhoda.Domain.Entites;
using AllameDehkhoda.Domain.Intrefaces;
using System.Security.Cryptography;

namespace AllameDehkhoda.Application.Services
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _memberRepository;

        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public async Task<ServiceResult> AddMemberAsync(MemberDTO memberDTO)
        {
            try
            {
                var member = new Member
                {
                    Id = memberDTO.Id,
                    FirstName = memberDTO.FirstName,
                    LastName = memberDTO.LastName,
                    Address = memberDTO.Address,
                    SocialSecurityNumber = memberDTO.SSN,
                    PhoneNumber = memberDTO.PhoneNumber,
                    RegisterDate = memberDTO.RegisterDate,
                    IsDeleted = memberDTO.IsDeleted,
                };
                await _memberRepository.AddAsync(member);
                return ServiceResult.Succes(MemberMessage.MemberAdded);

            }
            catch
            {
                return ServiceResult.Failure(MemberMessage.UnknownError);
            }
        }

        public async Task<ServiceResult> DeleteMemberAsync(int id)
        {
            try
            {
                var member = await _memberRepository.GetByIdAsync(id);
                if (member == null)
                    return ServiceResult.Failure(MemberMessage.MemberNotFound);
                if (member.IsDeleted)
                    return ServiceResult.Failure(MemberMessage.MemberAlreadyDeleted);
                member.IsDeleted = true;
                await _memberRepository.UpdateAsync(member);
                return ServiceResult.Succes(MemberMessage.MemberDeleted);


            }
            catch
            {
                return ServiceResult.Failure(MemberMessage.UnknownError);
            }
        }

        public async Task<MemberDTO> FindBySSNAsync(string ssn)
        {
            var member = await _memberRepository.GetBySSNAsync(ssn);
            if (member == null)
                return null;
            return new MemberDTO
            {
                Id = member.Id,
                FirstName = member.FirstName,
                LastName = member.LastName,
                SSN = member.SocialSecurityNumber

            };
        }

        public async Task<List<MemberDTO>> GetAllMemberAsync(bool includeIsDeleted = false)
        {
            List<Member> members;
            if (includeIsDeleted)
                members = await _memberRepository.FindAsync(m => m.IsDeleted);
            else
                members = await _memberRepository.FindAsync(m => !m.IsDeleted);
            var result = members.Select(m => new MemberDTO
            {
                Id = m.Id,
                FirstName = m.FirstName,
                LastName = m.LastName,
                Address = m.Address,
                PhoneNumber = m.PhoneNumber,
                SSN = m.SocialSecurityNumber,
                IsDeleted = m.IsDeleted,
                RegisterDate = m.RegisterDate
            }).ToList();
            return result;
        }

        public async Task<MemberDTO> GetMemberByIdAsync(int id)
        {
            var member = await _memberRepository.GetByIdAsync(id);
            if (member == null)
                return null;
            return new MemberDTO
            {
                Id = member.Id,
                FirstName = member.FirstName,
                LastName = member.LastName,
                Address = member.Address,
                PhoneNumber = member.PhoneNumber,
                SSN = member.SocialSecurityNumber,
                IsDeleted = member.IsDeleted,
                RegisterDate = member.RegisterDate
            };

        }

        public async Task<List<MemberReportDTO>> GetmemberReportAsync(string ssn,string? firstName,
            string? lastName, string status)
        {
            var member = await _memberRepository.GetReportDataAsync(ssn,firstName, lastName, status);
            return member.Select(m => new MemberReportDTO
            {
                Id = m.Id,
                SSN = m.SocialSecurityNumber,
                FullName = m.FirstName + " " + m.LastName,
                Address = m.Address,
                Phone = m.PhoneNumber,
                RegisterDate = m.RegisterDate,
                TotalBorrowCount = m.Borrows.Count,
                ActiveBorrowCount = m.Borrows.Count(m => m.ReturnDate == null),
                Status = m.Borrows.Any(b => b.ReturnDate == null) ? "فعال" : "غیر فعال"

            }).ToList();
        }

        public async Task<ServiceResult> RestoreMemberAsync(int id)
        {
            try
            {
                var member = await _memberRepository.GetByIdAsync(id);
                if (member == null)
                    return ServiceResult.Failure(MemberMessage.MemberNotFound);
                member.IsDeleted = false;
                await _memberRepository.UpdateAsync(member);
                return ServiceResult.Succes(MemberMessage.MemberRestore);
            }
            catch
            {
                return ServiceResult.Failure(MemberMessage.UnknownError);
            }
        }

        public async Task<ServiceResult> UpdateMemberAsync(MemberDTO memberDTO)
        {
            try
            {
                var member = await _memberRepository.GetByIdAsync(memberDTO.Id);
                if (member == null)
                    return ServiceResult.Failure(MemberMessage.MemberNotFound);
                member.FirstName = memberDTO.FirstName;
                member.LastName = memberDTO.LastName;
                member.Address = memberDTO.Address;
                member.PhoneNumber = memberDTO.PhoneNumber;
                member.RegisterDate = memberDTO.RegisterDate;
                await _memberRepository.UpdateAsync(member);
                return ServiceResult.Succes(MemberMessage.MemberUpdate);
            }
            catch
            {
                return ServiceResult.Failure(MemberMessage.UnknownError);
            }
        }
    }
}
