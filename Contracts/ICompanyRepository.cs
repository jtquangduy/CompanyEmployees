﻿using Entities.Models;
using Shared.RequestFeatures;

namespace Contracts
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> GetAllCompaniesAsync(CompanyParameters companyParameters, bool trackChanges);

        Task<Company> GetCompanyAsync(Guid companyId, bool trackChanges);

        void CreateCompany(Company company);

        Task<IEnumerable<Company>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);

        void DeleteCompany(Company company);
    }
}