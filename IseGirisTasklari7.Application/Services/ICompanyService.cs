using IseGirisTasklari7.Application.Features.Companies.Commands.CreateCompany;
using IseGirisTasklari7.Application.Features.Companies.Commands.UpdateCompany;
using IseGirisTasklari7.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IseGirisTasklari7.Application.Services
{
    public interface ICompanyService
    {
        Task CreateCompanyAsync(CreateCompanyCommand request);
        Task UpdateCompanyAsync(UpdateCompanyCommand request);
        IQueryable<Company> GetAll();
        Task<Company> GetCompanyById(string companyId);
    }
}
