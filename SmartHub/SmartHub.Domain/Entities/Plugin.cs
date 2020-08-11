﻿using SmartHub.Domain.Common.Enums;
using SmartHub.Domain.Entities.Devices;

namespace SmartHub.Domain.Entities
{
	public class Plugin : BaseEntity
	{
		public PluginTypes PluginTypes { get; private set; }
		public string AssemblyFilepath { get; private set; }
		public bool Active { get; private set; }
		public double AssemblyVersion { get; private set; }
		public virtual Company Company { get; private set; }

		// TODO: will be replaced later for an Enum flag "ConnectionTypes"
		public ConnectionTypes ConnectionTypes { get; private set; }
		public bool IsDownloaded { get; private set; }

		public Plugin()
		{
		}

		public Plugin(string name, string description, PluginTypes pluginTypes, string systemPath, bool active, double version, string company, ConnectionTypes connectionTypes) :
			 base(name, description)
		{
			PluginTypes = pluginTypes;
			AssemblyFilepath = systemPath;
			Active = active;
			AssemblyVersion = version;
			Company = new Company(company);
			IsDownloaded = true;
			ConnectionTypes = connectionTypes;
		}
	}
}