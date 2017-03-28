﻿using Promact.TestCaseManagement.DomainModel.Models.TestCase.Base;

namespace Promact.TestCaseManagement.DomainModel.Models.TestCase
{
    public class TestCaseVersion : TestCaseBase
    {
        public int TestCaseId { get; set; }

        public virtual TestCase TestCase { get; set; }
    }
}