﻿using System;

namespace Promact.TestCaseManagement.DomainModel.Models
{
    public abstract class TestCaseStepsBase
    {
        public int Id { get; set; }

        public string TestStep { get; set; }

        public string ExpectedResult { get; set; }

        public DateTime ExpectedResultDate { get; set; }

        public string ActualResult { get; set; }

        public DateTime? ActualResultDate { get; set; }

        public int TestCaseId { get; set; }

        public int IsDeleted { get; set; }
    }
}
