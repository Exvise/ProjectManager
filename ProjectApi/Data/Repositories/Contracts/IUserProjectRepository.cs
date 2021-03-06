﻿using ProjectApi.Models;
using System;
using System.Threading.Tasks;

namespace ProjectApi.Data.Repositories.Contracts
{
    public interface IUserProjectRepository
    {
        Task<UserProject> CreateAsync(UserProject userProject);

        Task<UserProject> GetAsync(Guid projectId, Guid userId);

        Task<UserProject> UpdateAsync(UserProject userProject);

        Task DeleteAsync(Guid projectId, Guid userId);

        Task DeleteAsync(Guid userProjectId);
    }
}
