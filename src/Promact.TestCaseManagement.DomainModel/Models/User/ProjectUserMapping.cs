﻿using Promact.TestCaseManagement.DomainModel.Enums;
using Promact.TestCaseManagement.DomainModel.Models.Global;

namespace Promact.TestCaseManagement.DomainModel.Models.User
{
    public class ProjectUserMapping : TestCaseManagementBase
    {
        public int ProjectId { get; set; }

        public virtual Project.Project Project { get; set; }

        public string UserId { get; set; }

        public virtual UserInfo User { get; set; }

        public TeamRole Role { get; set; }
    }
}
