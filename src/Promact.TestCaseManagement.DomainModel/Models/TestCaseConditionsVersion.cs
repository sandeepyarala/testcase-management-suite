﻿using System;

namespace Promact.TestCaseManagement.DomainModel.Models
{
    public class TestCaseConditionsVersion : TestCaseConditionsBase
    {
        public int TestCaseConditionsId { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public string CreatedUserId { get; set; }

        public virtual UserInfo CreatedUser { get; set; }

        public virtual TestCaseConditions TestCaseConditions { get; set; }
    }
}