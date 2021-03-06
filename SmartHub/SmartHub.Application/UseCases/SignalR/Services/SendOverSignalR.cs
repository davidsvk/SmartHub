﻿using System;
using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using SmartHub.Application.Common.Interfaces.Database;
using SmartHub.Application.UseCases.Entity.Homes;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using SmartHub.Application.Common.Exceptions;
using SmartHub.Application.UseCases.Entity.Activities;
using SmartHub.Domain.Common.Extensions;
using SmartHub.Domain.Common.Settings;
using SmartHub.Domain.Entities;

namespace SmartHub.Application.UseCases.SignalR.Services
{
	/// <inheritdoc cref="ISendOverSignalR"/>
	public class SendOverSignalR : ISendOverSignalR
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;
		private readonly IHubContext<HomeHub, IServerHub> _homeHubContext;
		private readonly IHubContext<ActivityHub, IServerHub> _activityHubContext;
		private readonly IOptionsSnapshot<ApplicationSettings> _optionsSnapshot;

		public SendOverSignalR(IUnitOfWork unitOfWork, IMapper mapper, IHubContext<HomeHub, IServerHub> homeHubContext,
			IHubContext<ActivityHub, IServerHub> activityHubContext, IOptionsSnapshot<ApplicationSettings> optionsSnapshot)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
			_homeHubContext = homeHubContext;
			_activityHubContext = activityHubContext;
			_optionsSnapshot = optionsSnapshot;
		}

		/// <inheritdoc cref="ISendOverSignalR.SendHome"/>
		public async Task SendHome()
		{
			var home = await _unitOfWork.HomeRepository.GetHome();
			await _homeHubContext.Clients.All.SendHome(_mapper.Map<HomeDto>(home));
		}

		/// <inheritdoc cref="ISendOverSignalR.SendActivity"/>
		public async Task SendActivity(string userName,string requestName, string message, long execTime,bool success)
		{
			var home = await _unitOfWork.HomeRepository.GetHome();
			if (home is null)
			{
				return;
			}
			var activityDto = new ActivityDto
			{
				DateTime = DateTime.Now.ToString("HH:mm:ss"),
				Username = userName,
				Message = message,
				ExecutionTime = execTime,
				SuccessfulRequest = success
			};
			await _activityHubContext.Clients.All.SendActivity(activityDto);
			var activity = _mapper.Map<Activity>(activityDto);
			activity.SetName(requestName);
			home.AddActivity(activity);
			if (home.Activities.Count > _optionsSnapshot.Value.SaveXLimit)
			{
				if (_optionsSnapshot.Value.SaveXLimit != null && _optionsSnapshot.Value.DeleteXAmountAfterLimit != null)
				{
					home.RemoveActivitiesOverLimit((int) _optionsSnapshot.Value.SaveXLimit,
						(int) _optionsSnapshot.Value.DeleteXAmountAfterLimit);
				}

			}

		}
	}
}
