﻿using SmartHub.Application.Common.Mappings;
using SmartHub.Domain.Entities;

namespace SmartHub.Application.UseCases.Entity.Activities
{
    /// <summary>
    /// It is the current request but only with relevant Infos
    /// </summary>
    public class ActivityDto : IMapFrom<Activity>
    {
        public string? DateTime { get; set; }
        public string? Username { get; set; }
        public string? Message { get; set; }
        public long? ExecutionTime { get; set; }
        public bool? SuccessfulRequest { get; set; }
    }
}